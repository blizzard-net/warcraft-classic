namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class PowerTypeApiTests
{
    string namespaceBCC = "static-classic-us";
    string namespaceEra = "static-classic1x-us";

    [Fact]
    public async Task GetPowerTypesIndexAsync_Gets_PowerTypesIndex_ForBCC()
    {
        IPowerTypeApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/power-type/index?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.PowerTypesIndexResponse_ForBCC);

        RequestResult<PowerTypesIndex> result = await warcraftClient.GetPowerTypesIndexAsync(namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPowerTypeAsync_Gets_PowerType_ForBCC()
    {
        IPowerTypeApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/power-type/0?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.PowerTypeResponse_ForBCC);

        RequestResult<PowerType> result = await warcraftClient.GetPowerTypeAsync(0, namespaceBCC);
        Assert.NotNull(result.Value);
    }


    [Fact]
    public async Task GetPowerTypesIndexAsync_Gets_PowerTypesIndex_ForEra()
    {
        IPowerTypeApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/power-type/index?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.PowerTypesIndexResponse_ForEra);

        RequestResult<PowerTypesIndex> result = await warcraftClient.GetPowerTypesIndexAsync(namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPowerTypeAsync_Gets_PowerType_ForEra()
    {
        IPowerTypeApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/power-type/0?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.PowerTypeResponse_ForEra);

        RequestResult<PowerType> result = await warcraftClient.GetPowerTypeAsync(0, namespaceEra);
        Assert.NotNull(result.Value);
    }

}
