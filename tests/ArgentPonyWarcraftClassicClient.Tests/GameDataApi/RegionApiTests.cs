namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class RegionApiTests
{
    [Fact]
    public async Task GetRegionsIndexAsync_Gets_RegionsIndex()
    {
        IRegionApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/region/index?namespace=dynamic-classic-us&locale=en_US",
            responseContent: Resources.RegionsIndexResponse);

        RequestResult<RegionsIndex> result = await warcraftClient.GetRegionsIndexAsync("dynamic-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetRegionAsync_Gets_Region()
    {
        IRegionApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/region/1?namespace=dynamic-classic-us&locale=en_US",
            responseContent: Resources.RegionResponse);

        RequestResult<RegionData> result = await warcraftClient.GetRegionAsync(1, "dynamic-classic-us");
        Assert.NotNull(result.Value);
    }
}
