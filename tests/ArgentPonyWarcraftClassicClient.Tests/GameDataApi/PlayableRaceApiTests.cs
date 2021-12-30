namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class PlayableRaceApiTests
{
    [Fact]
    public async Task GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex()
    {
        IPlayableRaceApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/playable-race/index?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.PlayableRacesIndexResponse);

        RequestResult<PlayableRacesIndex> result = await warcraftClient.GetPlayableRacesIndexAsync("static-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPlayableRaceAsync_Gets_PlayableRace()
    {
        IPlayableRaceApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/playable-race/2?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.PlayableRaceResponse);

        RequestResult<PlayableRace> result = await warcraftClient.GetPlayableRaceAsync(2, "static-classic-us");
        Assert.NotNull(result.Value);
    }
}
