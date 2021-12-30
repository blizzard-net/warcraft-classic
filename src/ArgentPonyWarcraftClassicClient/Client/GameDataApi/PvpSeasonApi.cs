namespace ArgentPonyWarcraftClassicClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<PvpSeasonsIndex>> GetPvpSeasonsIndexAsync(string @namespace)
    {
        return await GetPvpSeasonsIndexAsync(@namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpSeasonsIndex>> GetPvpSeasonsIndexAsync(string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PvpSeasonsIndex>($"{host}/data/wow/pvp-season/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpSeason>> GetPvpSeasonAsync(int pvpSeasonId, string @namespace)
    {
        return await GetPvpSeasonAsync(pvpSeasonId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpSeason>> GetPvpSeasonAsync(int pvpSeasonId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PvpSeason>($"{host}/data/wow/pvp-season/{pvpSeasonId}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpLeaderboardsIndex>> GetPvpLeaderboardsIndexAsync(int pvpRegionId, int pvpSeasonId, string @namespace)
    {
        return await GetPvpLeaderboardsIndexAsync(pvpRegionId, pvpSeasonId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpLeaderboardsIndex>> GetPvpLeaderboardsIndexAsync(int pvpRegionId, int pvpSeasonId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PvpLeaderboardsIndex>($"{host}/data/wow/pvp-region/{pvpRegionId}/pvp-season/{pvpSeasonId}/pvp-leaderboard/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpLeaderboard>> GetPvpLeaderboardAsync(int pvpRegionId, int pvpSeasonId, string pvpBracket, string @namespace)
    {
        return await GetPvpLeaderboardAsync(pvpRegionId, pvpSeasonId, pvpBracket, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpLeaderboard>> GetPvpLeaderboardAsync(int pvpRegionId, int pvpSeasonId, string pvpBracket, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PvpLeaderboard>($"{host}/data/wow/pvp-region/{pvpRegionId}/pvp-season/{pvpSeasonId}/pvp-leaderboard/{pvpBracket}?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpRewardsIndex>> GetPvpRewardsIndexAsync(int pvpRegionId, int pvpSeasonId, string @namespace)
    {
        return await GetPvpRewardsIndexAsync(pvpRegionId, pvpSeasonId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<PvpRewardsIndex>> GetPvpRewardsIndexAsync(int pvpRegionId, int pvpSeasonId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<PvpRewardsIndex>($"{host}/data/wow/pvp-region/{pvpRegionId}/pvp-season/{pvpSeasonId}/pvp-reward/index?namespace={@namespace}&locale={locale}");
    }
}
