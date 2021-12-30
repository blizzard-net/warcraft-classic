namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class PvpSeasonApiTests
{
    [Fact]
    public async Task GetPvpSeasonsIndexAsync_Gets_PvpSeasonsIndex()
    {
        IPvpSeasonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pvp-season/index?namespace=dynamic-classic-us&locale=en_US",
            responseContent: Resources.PvpSeasonsIndexResponse);

        RequestResult<PvpSeasonsIndex> result = await warcraftClient.GetPvpSeasonsIndexAsync("dynamic-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPvpSeasonAsync_Gets_PvpSeason()
    {
        IPvpSeasonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pvp-season/27?namespace=dynamic-classic-us&locale=en_US",
            responseContent: Resources.PvpSeasonResponse);

        RequestResult<PvpSeason> result = await warcraftClient.GetPvpSeasonAsync(27, "dynamic-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPvpLeaderboardsIndexAsync_Gets_PvpLeaderboardsIndex()
    {
        IPvpSeasonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pvp-region/1/pvp-season/1/pvp-leaderboard/index?namespace=dynamic-classic-us&locale=en_US",
            responseContent: Resources.PvpLeaderboardsIndexResponse);

        RequestResult<PvpLeaderboardsIndex> result = await warcraftClient.GetPvpLeaderboardsIndexAsync(1, 1, "dynamic-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPvpLeaderboardAsync_Gets_PvpLeaderboard()
    {
        IPvpSeasonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pvp-region/1/pvp-season/1/pvp-leaderboard/3v3?namespace=dynamic-classic-us&locale=en_US",
            responseContent: Resources.PvpLeaderboardResponse);

        RequestResult<PvpLeaderboard> result = await warcraftClient.GetPvpLeaderboardAsync(1, 1, "3v3", "dynamic-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPvpRewardsIndexAsync_Gets_PvpRewardsIndex()
    {
        IPvpSeasonApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/pvp-region/1/pvp-season/1/pvp-reward/index?namespace=dynamic-classic-us&locale=en_US",
            responseContent: Resources.PvpRewardsIndexResponse);

        RequestResult<PvpRewardsIndex> result = await warcraftClient.GetPvpRewardsIndexAsync(1, 1, "dynamic-classic-us");
        Assert.NotNull(result.Value);
    }
}
