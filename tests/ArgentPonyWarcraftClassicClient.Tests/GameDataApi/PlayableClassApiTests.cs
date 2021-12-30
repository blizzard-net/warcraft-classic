namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class PlayableClassApiTests
{
    [Fact]
    public async Task GetPlayableClassesIndexAsync_Gets_PlayableClassesIndex()
    {
        IPlayableClassApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/playable-class/index?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.PlayableClassesIndexResponse);

        RequestResult<PlayableClassesIndex> result = await warcraftClient.GetPlayableClassesIndexAsync("static-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPlayableClassAsync_Gets_PlayableClass()
    {
        IPlayableClassApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/playable-class/7?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.PlayableClassResponse);

        RequestResult<PlayableClass> result = await warcraftClient.GetPlayableClassAsync(7, "static-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPlayableClassMediaAsync_Gets_PlayableClassMedia()
    {
        IPlayableClassApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/media/playable-class/7?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.PlayableClassMediaResponse);

        RequestResult<PlayableClassMedia> result = await warcraftClient.GetPlayableClassMediaAsync(7, "static-classic-us");
        Assert.NotNull(result.Value);
    }
}
