namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class PlayableRaceApiTests
{
    string namespaceBCC = "static-classic-us";
    string namespaceEra = "static-classic1x-us";

    [Fact]
    public async Task GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex_ForBCC()
    {
        IPlayableRaceApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/playable-race/index?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.PlayableRacesIndexResponse_ForBCC);

        RequestResult<PlayableRacesIndex> result = await warcraftClient.GetPlayableRacesIndexAsync(namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPlayableRaceAsync_Gets_PlayableRace_ForBCC()
    {
        IPlayableRaceApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/playable-race/2?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.PlayableRaceResponse_ForBCC);

        RequestResult<PlayableRace> result = await warcraftClient.GetPlayableRaceAsync(2, namespaceBCC);
        Assert.NotNull(result.Value);
    }


    [Fact]
    public async Task GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex_ForEra()
    {
        IPlayableRaceApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/playable-race/index?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.PlayableRacesIndexResponse_ForEra);

        RequestResult<PlayableRacesIndex> result = await warcraftClient.GetPlayableRacesIndexAsync(namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPlayableRaceAsync_Gets_PlayableRace_ForEra()
    {
        IPlayableRaceApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/playable-race/2?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.PlayableRaceResponse_ForEra);

        RequestResult<PlayableRace> result = await warcraftClient.GetPlayableRaceAsync(2, namespaceEra);
        Assert.NotNull(result.Value);
    }

}
