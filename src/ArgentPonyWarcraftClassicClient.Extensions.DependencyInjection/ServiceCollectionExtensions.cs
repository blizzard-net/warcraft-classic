using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;

namespace ArgentPonyWarcraftClassicClient.Extensions.DependencyInjection;

/// <summary>
/// Extensions to the <see cref="IServiceCollection"/> for registering
/// the World of Warcraft Game Data and Profile API clients.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers the the various World of Warcraft API interfaces using the specified client credentials.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> instance.</param>
    /// <param name="clientId">The Blizzard OAuth client ID.</param>
    /// <param name="clientSecret">The Blizzard OAuth client secret.</param>
    /// <returns>The updated <see cref="IServiceCollection"/> instance.</returns>
    public static IServiceCollection AddWarcraftClients(this IServiceCollection services, string clientId, string clientSecret)
    {
        return services.AddWarcraftClients(clientId, clientSecret, Region.US, Locale.en_US);
    }

    /// <summary>
    /// Registers the the various World of Warcraft API interfaces using the specified client credentials,
    /// <paramref name="region"/>, and <paramref name="locale"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> instance.</param>
    /// <param name="clientId">The Blizzard OAuth client ID.</param>
    /// <param name="clientSecret">The Blizzard OAuth client secret.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">
    ///     Specifies the language that the result will be in. Visit
    ///     https://develop.battle.net/documentation/world-of-warcraft-classic/guides/localization to see a list of available locales.
    /// </param>
    /// <returns>The updated <see cref="IServiceCollection"/> instance.</returns>
    public static IServiceCollection AddWarcraftClients(this IServiceCollection services, string clientId,
        string clientSecret, Region region, Locale locale)
    {
        if (clientId == null)
        {
            throw new ArgumentNullException(nameof(clientId));
        }

        if (clientSecret == null)
        {
            throw new ArgumentNullException(nameof(clientSecret));
        }

        if (!locale.IsSupportedInRegion(region))
        {
            throw new ArgumentException("The locale selected is not supported by the selected region.");
        }

        services.AddHttpClient(
            "ArgentPonyWarcraftClassicClient.WarcraftClient.HttpClient",
            client => client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"))
        ).AddTypedClient(httpClient =>
            new WarcraftClient(clientId, clientSecret, region, locale, httpClient)
        );

        services.AddTransientUsingServiceProvider<IWarcraftClient, WarcraftClient>()
            .AddGameDataApiServices();

        return services;
    }

    /// <summary>
    /// Adds the interfaces for the game data APIs.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> instance.</param>
    /// <returns>The updated <see cref="IServiceCollection"/> instance.</returns>
    private static IServiceCollection AddGameDataApiServices(this IServiceCollection services)
    {
        services.AddTransientUsingServiceProvider<IGameDataApi, IWarcraftClient>();

        return services.AddTransientUsingServiceProvider<IAuctionHouseApi, IGameDataApi>()
            .AddTransientUsingServiceProvider<IConnectedRealmApi, IGameDataApi>()
            .AddTransientUsingServiceProvider<ICreatureApi, IGameDataApi>()
            .AddTransientUsingServiceProvider<IGuildCrestApi, IGameDataApi>()
            .AddTransientUsingServiceProvider<IItemApi, IGameDataApi>()
            .AddTransientUsingServiceProvider<IPlayableClassApi, IGameDataApi>()
            .AddTransientUsingServiceProvider<IPlayableRaceApi, IGameDataApi>()
            .AddTransientUsingServiceProvider<IPowerTypeApi, IGameDataApi>()
            .AddTransientUsingServiceProvider<IPvpSeasonApi, IGameDataApi>()
            .AddTransientUsingServiceProvider<IRealmApi, IGameDataApi>()
            .AddTransientUsingServiceProvider<IRegionApi, IGameDataApi>()
            .AddTransientUsingServiceProvider<IWowTokenApi, IGameDataApi>();
    }

    /// <summary>
    /// Adds a transient service of the type specified in <typeparamref name="TService"/> with a
    /// factory that uses the type specified in <typeparamref name="TImplementation"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> instance.</param>
    /// <typeparam name="TService">The type of service to add.</typeparam>
    /// <typeparam name="TImplementation">The type of the implementation to use.</typeparam>
    /// <returns>The updated <see cref="IServiceCollection"/> instance.</returns>
    private static IServiceCollection AddTransientUsingServiceProvider<TService, TImplementation>(this IServiceCollection services)
        where TService : class
        where TImplementation : class, TService

    {
        return services.AddTransient<TService>(serviceProvider =>
            serviceProvider.GetRequiredService<TImplementation>()
        );
    }
}
