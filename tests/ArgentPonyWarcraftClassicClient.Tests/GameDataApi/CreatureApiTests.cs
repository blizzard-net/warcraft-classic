namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class CreatureApiTests
{
    string namespaceBCC = "static-classic-us";
    string namespaceEra = "static-classic1x-eu";

    [Fact]
    public async Task GetCreatureFamiliesIndexAsync_Gets_CreatureFamiliesIndex_ForBCC()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/creature-family/index?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.CreatureFamiliesIndexResponse_ForBCC);

        RequestResult<CreatureFamiliesIndex> result = await warcraftClient.GetCreatureFamiliesIndexAsync(namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureFamilyAsync_Gets_CreatureFamily_ForBCC()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/creature-family/1?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.CreatureFamilyResponse_ForBCC);

        RequestResult<CreatureFamily> result = await warcraftClient.GetCreatureFamilyAsync(1, namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureTypesIndexAsync_Gets_CreatureTypesIndex_ForBCC()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/creature-type/index?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.CreatureTypesIndexResponse_ForBCC);

        RequestResult<CreatureTypesIndex> result = await warcraftClient.GetCreatureTypesIndexAsync(namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureTypeAsync_Gets_CreatureType_ForBCC()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/creature-type/1?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.CreatureTypeResponse_ForBCC);

        RequestResult<CreatureType> result = await warcraftClient.GetCreatureTypeAsync(1, namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureAsync_Gets_Creature_ForBCC()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/creature/42722?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.CreatureResponse_ForBCC);

        RequestResult<Creature> result = await warcraftClient.GetCreatureAsync(42722, namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureDisplayMediaAsync_Gets_CreatureDisplayMedia_ForBCC()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/media/creature-display/30221?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.CreatureDisplayMediaResponse_ForBCC);

        RequestResult<CreatureDisplayMedia> result = await warcraftClient.GetCreatureDisplayMediaAsync(30221, namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureFamilyMediaAsync_Gets_CreatureFamilyMedia_ForBCC()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/media/creature-family/1?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.CreatureFamilyMediaResponse_ForBCC);

        RequestResult<CreatureFamilyMedia> result = await warcraftClient.GetCreatureFamilyMediaAsync(1, namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureFamiliesIndexAsync_Gets_CreatureFamiliesIndex_ForEra()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/creature-family/index?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.CreatureFamiliesIndexResponse_ForEra);

        RequestResult<CreatureFamiliesIndex> result = await warcraftClient.GetCreatureFamiliesIndexAsync(namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureFamilyAsync_Gets_CreatureFamily_ForEra()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/creature-family/1?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.CreatureFamilyResponse_ForEra);

        RequestResult<CreatureFamily> result = await warcraftClient.GetCreatureFamilyAsync(1, namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureTypesIndexAsync_Gets_CreatureTypesIndex_ForEra()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/creature-type/index?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.CreatureTypesIndexResponse_ForEra);

        RequestResult<CreatureTypesIndex> result = await warcraftClient.GetCreatureTypesIndexAsync(namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureTypeAsync_Gets_CreatureType_ForEra()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/creature-type/1?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.CreatureTypeResponse_ForEra);

        RequestResult<CreatureType> result = await warcraftClient.GetCreatureTypeAsync(1, namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureAsync_Gets_Creature_ForEra()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/creature/42722?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.CreatureResponse_ForEra);

        RequestResult<Creature> result = await warcraftClient.GetCreatureAsync(42722, namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureDisplayMediaAsync_Gets_CreatureDisplayMedia_ForEra()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/media/creature-display/30221?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.CreatureDisplayMediaResponse_ForEra);

        RequestResult<CreatureDisplayMedia> result = await warcraftClient.GetCreatureDisplayMediaAsync(30221, namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetCreatureFamilyMediaAsync_Gets_CreatureFamilyMedia_ForEra()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/media/creature-family/1?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.CreatureFamilyMediaResponse_ForEra);

        RequestResult<CreatureFamilyMedia> result = await warcraftClient.GetCreatureFamilyMediaAsync(1, namespaceEra);
        Assert.NotNull(result.Value);
    }

}
