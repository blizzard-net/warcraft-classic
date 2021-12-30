namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class PowerTypeApiTests
{
    [ResilientFact]
    public async Task GetPowerTypesIndexAsync_Gets_PowerTypesIndex()
    {
        IPowerTypeApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PowerTypesIndex> result = await warcraftClient.GetPowerTypesIndexAsync("static-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/power-type/index?namespace=static-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetPowerTypeAsync_Gets_PowerType()
    {
        IPowerTypeApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PowerType> result = await warcraftClient.GetPowerTypeAsync(0, "static-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/power-type/0?namespace=static-classic-us&locale=en_US");
    }
}
