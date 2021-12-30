namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class PvpSeasonApiTests
{
    [ResilientFact]
    public async Task GetPvpSeasonsIndexAsync_Gets_PvpSeasonsIndex()
    {
        IPvpSeasonApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PvpSeasonsIndex> result = await warcraftClient.GetPvpSeasonsIndexAsync("dynamic-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/pvp-season/index?namespace=dynamic-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetPvpSeasonAsync_Gets_PvpSeason()
    {
        IPvpSeasonApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PvpSeason> result = await warcraftClient.GetPvpSeasonAsync(1, "dynamic-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/pvp-season/1?namespace=dynamic-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetPvpLeaderboardsIndexAsync_Gets_PvpLeaderboardsIndex()
    {
        IPvpSeasonApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PvpLeaderboardsIndex> result = await warcraftClient.GetPvpLeaderboardsIndexAsync(1, 1, "dynamic-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/pvp-region/1/pvp-season/1/pvp-leaderboard/index?namespace=dynamic-classic-us&locale=en_US");
    }

    [ResilientFact(Skip = "Needs work after porting from retail.")]
    public async Task GetPvpLeaderboardAsync_Gets_PvpLeaderboard()
    {
        IPvpSeasonApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PvpLeaderboard> result = await warcraftClient.GetPvpLeaderboardAsync(1, 1, "3v3", "dynamic-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/pvp-region/1/pvp-season/1/pvp-leaderboard/3v3?namespace=dynamic-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetPvpRewardsIndexAsync_Gets_PvpRewardsIndex()
    {
        IPvpSeasonApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PvpRewardsIndex> result = await warcraftClient.GetPvpRewardsIndexAsync(1, 1, "dynamic-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/pvp-region/1/pvp-season/1/pvp-reward/index?namespace=dynamic-classic-us&locale=en_US");
    }
}
