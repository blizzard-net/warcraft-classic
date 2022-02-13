namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class PowerTypeApiTests
{
    [Fact]
    public async Task GetPowerTypesIndexAsync_Gets_PowerTypesIndex()
    {
        IPowerTypeApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/power-type/index?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.PowerTypesIndexResponse_ForBCC);

        RequestResult<PowerTypesIndex> result = await warcraftClient.GetPowerTypesIndexAsync("static-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPowerTypeAsync_Gets_PowerType()
    {
        IPowerTypeApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/power-type/0?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.PowerTypeResponse_ForBCC);

        RequestResult<PowerType> result = await warcraftClient.GetPowerTypeAsync(0, "static-classic-us");
        Assert.NotNull(result.Value);
    }
}
