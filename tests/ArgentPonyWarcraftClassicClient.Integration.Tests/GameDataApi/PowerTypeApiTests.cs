namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class PowerTypeApiTests
{
    string namespaceBCC = "static-classic-us";
    Locale localeBCC = Locale.en_US;
    string hostBCC = "us.api.blizzard.com";

    string namespaceEra = "static-classic1x-eu";
    Region regionEra = Region.Europe;
    Locale localeEra = Locale.en_US;
    string hostEra = "eu.api.blizzard.com";

    [ResilientFact]
    public async Task GetPowerTypesIndexAsync_Gets_PowerTypesIndex_ForBCC()
    {
        IPowerTypeApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PowerTypesIndex> result = await warcraftClient.GetPowerTypesIndexAsync(namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/power-type/index?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetPowerTypeAsync_Gets_PowerType_ForBCC()
    {
        IPowerTypeApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PowerType> result = await warcraftClient.GetPowerTypeAsync(0, namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/power-type/0?namespace={namespaceBCC}&locale={localeBCC}");
    }


    [ResilientFact]
    public async Task GetPowerTypesIndexAsync_Gets_PowerTypesIndex_ForEra()
    {
        IPowerTypeApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PowerTypesIndex> result = await warcraftClient.GetPowerTypesIndexAsync(namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/power-type/index?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetPowerTypeAsync_Gets_PowerType_ForEra()
    {
        IPowerTypeApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PowerType> result = await warcraftClient.GetPowerTypeAsync(0, namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/power-type/0?namespace={namespaceEra}&locale={localeEra}");
    }

}
