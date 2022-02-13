namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class ConnectedRealmApiTests
{
    [ResilientFact]
    public async Task GetConnectedRealmsIndexAsync_Gets_ConnectedRealmsIndex_ForBCC()
    {
        IConnectedRealmApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ConnectedRealmsIndex> result = await warcraftClient.GetConnectedRealmsIndexAsync("dynamic-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/connected-realm/index?namespace=dynamic-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetRealmAsync_Gets_Realm_ForBCC()
    {
        IConnectedRealmApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ConnectedRealm> result = await warcraftClient.GetConnectedRealmAsync(4372, "dynamic-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/connected-realm/4372?namespace=dynamic-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetConnectedRealmsIndexAsync_Gets_ConnectedRealmsIndex_ForEra()
    {
        string @namespace = "dynamic-classic1x-eu";
        Region region = Region.Europe;
        Locale locale = Locale.en_US;
        string host = "eu.api.blizzard.com";

        IConnectedRealmApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ConnectedRealmsIndex> result = await warcraftClient.GetConnectedRealmsIndexAsync(@namespace, region, locale);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{host}/data/wow/connected-realm/index?namespace={@namespace}&locale=en_US");
    }

    [ResilientFact]
    public async Task GetRealmAsync_Gets_Realm_ForEra()
    {
        int realmId = 5265;
        string @namespace = "dynamic-classic1x-eu";
        Region region = Region.Europe;
        Locale locale = Locale.en_US;
        string host = "eu.api.blizzard.com";

        IConnectedRealmApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ConnectedRealm> result = await warcraftClient.GetConnectedRealmAsync(realmId, @namespace, region, locale);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{host}/data/wow/connected-realm/{realmId}?namespace={@namespace}&locale=en_US");
    }
}
