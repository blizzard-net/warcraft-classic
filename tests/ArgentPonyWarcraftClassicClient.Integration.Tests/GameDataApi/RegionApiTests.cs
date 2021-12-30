namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class RegionApiTests
{
    [ResilientFact]
    public async Task GetRegionsIndexAsync_Gets_RegionsIndex()
    {
        IRegionApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<RegionsIndex> result = await warcraftClient.GetRegionsIndexAsync("dynamic-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/region/index?namespace=dynamic-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetRegionAsync_Gets_Region()
    {
        IRegionApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<RegionData> result = await warcraftClient.GetRegionAsync(41, "dynamic-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/region/41?namespace=dynamic-classic-us&locale=en_US");
    }
}
