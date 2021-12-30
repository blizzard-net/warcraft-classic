namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class CreatureApiTests
{
    [ResilientFact]
    public async Task GetCreatureFamiliesIndexAsync_Gets_CreatureFamiliesIndex()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureFamiliesIndex> result = await warcraftClient.GetCreatureFamiliesIndexAsync("static-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/creature-family/index?namespace=static-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetCreatureFamilyAsync_Gets_CreatureFamily()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureFamily> result = await warcraftClient.GetCreatureFamilyAsync(1, "static-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/creature-family/1?namespace=static-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetCreatureTypesIndexAsync_Gets_CreatureTypesIndex()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureTypesIndex> result = await warcraftClient.GetCreatureTypesIndexAsync("static-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/creature-type/index?namespace=static-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetCreatureTypeAsync_Gets_CreatureType()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureType> result = await warcraftClient.GetCreatureTypeAsync(1, "static-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/creature-type/1?namespace=static-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetCreatureAsync_Gets_Creature()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Creature> result = await warcraftClient.GetCreatureAsync(30, "static-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/creature/30?namespace=static-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetCreatureDisplayMediaAsync_Gets_CreatureDisplayMedia()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureDisplayMedia> result = await warcraftClient.GetCreatureDisplayMediaAsync(30, "static-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/creature-display/30?namespace=static-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetCreatureFamilyMediaAsync_Gets_CreatureFamilyMedia()
    {
        ICreatureApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<CreatureFamilyMedia> result = await warcraftClient.GetCreatureFamilyMediaAsync(1, "static-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/creature-family/1?namespace=static-classic-us&locale=en_US");
    }
}
