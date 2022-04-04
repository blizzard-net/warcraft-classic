namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class CreatureApiTests
{
    string namespaceBCC = "static-classic-us";
    Locale localeBCC = Locale.en_US;
    string hostBCC = "us.api.blizzard.com";

    string namespaceEra = "static-classic1x-eu";
    Region regionEra = Region.Europe;
    Locale localeEra = Locale.en_US;
    string hostEra = "eu.api.blizzard.com";

    [ResilientFact]
    public async Task GetCreatureFamiliesIndexAsync_Gets_CreatureFamiliesIndex_ForBCC()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureFamiliesIndex> result = await warcraftClient.GetCreatureFamiliesIndexAsync(namespaceBCC);
        
        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/creature-family/index?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetCreatureFamilyAsync_Gets_CreatureFamily_ForBCC()
    {

        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureFamily> result = await warcraftClient.GetCreatureFamilyAsync(1, namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/creature-family/1?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetCreatureTypesIndexAsync_Gets_CreatureTypesIndex_ForBCC()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureTypesIndex> result = await warcraftClient.GetCreatureTypesIndexAsync(namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/creature-type/index?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetCreatureTypeAsync_Gets_CreatureType_ForBCC()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureType> result = await warcraftClient.GetCreatureTypeAsync(1, namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/creature-type/1?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetCreatureAsync_Gets_Creature_ForBCC()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Creature> result = await warcraftClient.GetCreatureAsync(30, namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/creature/30?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetCreatureDisplayMediaAsync_Gets_CreatureDisplayMedia_ForBCC()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureDisplayMedia> result = await warcraftClient.GetCreatureDisplayMediaAsync(30, namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/media/creature-display/30?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetCreatureFamilyMediaAsync_Gets_CreatureFamilyMedia_ForBCC()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureFamilyMedia> result = await warcraftClient.GetCreatureFamilyMediaAsync(1, namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/media/creature-family/1?namespace={namespaceBCC}&locale={localeBCC}");
    }


    [ResilientFact]
    public async Task GetCreatureFamiliesIndexAsync_Gets_CreatureFamiliesIndex_ForEra()
    {

        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureFamiliesIndex> result = await warcraftClient.GetCreatureFamiliesIndexAsync(namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/creature-family/index?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetCreatureFamilyAsync_Gets_CreatureFamily_ForEra()
    {

        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureFamily> result = await warcraftClient.GetCreatureFamilyAsync(1, namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/creature-family/1?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetCreatureTypesIndexAsync_Gets_CreatureTypesIndex_ForEra()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureTypesIndex> result = await warcraftClient.GetCreatureTypesIndexAsync(namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/creature-type/index?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetCreatureTypeAsync_Gets_CreatureType_ForEra()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureType> result = await warcraftClient.GetCreatureTypeAsync(1, namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/creature-type/1?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetCreatureAsync_Gets_Creature_ForEra()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Creature> result = await warcraftClient.GetCreatureAsync(30, namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/creature/30?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetCreatureDisplayMediaAsync_Gets_CreatureDisplayMedia_ForEra()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureDisplayMedia> result = await warcraftClient.GetCreatureDisplayMediaAsync(30, namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/media/creature-display/30?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetCreatureFamilyMediaAsync_Gets_CreatureFamilyMedia_ForEra()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureFamilyMedia> result = await warcraftClient.GetCreatureFamilyMediaAsync(1, namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/media/creature-family/1?namespace={namespaceEra}&locale={localeEra}");
    }

}
