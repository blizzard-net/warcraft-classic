namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class PlayableClassApiTests
{
    string namespaceBCC = "static-classic-us";
    string namespaceEra = "static-classic1x-us";

    [Fact]
    public async Task GetPlayableClassesIndexAsync_Gets_PlayableClassesIndex_ForBCC()
    {
        IPlayableClassApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/playable-class/index?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.PlayableClassesIndexResponse_ForBCC);

        RequestResult<PlayableClassesIndex> result = await warcraftClient.GetPlayableClassesIndexAsync(namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPlayableClassAsync_Gets_PlayableClass_ForBCC()
    {
        IPlayableClassApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/playable-class/7?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.PlayableClassResponse_ForBCC);

        RequestResult<PlayableClass> result = await warcraftClient.GetPlayableClassAsync(7, namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPlayableClassMediaAsync_Gets_PlayableClassMedia_ForBCC()
    {
        IPlayableClassApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/media/playable-class/7?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.PlayableClassMediaResponse_ForBCC);

        RequestResult<PlayableClassMedia> result = await warcraftClient.GetPlayableClassMediaAsync(7, namespaceBCC);
        Assert.NotNull(result.Value);
    }


    [Fact]
    public async Task GetPlayableClassesIndexAsync_Gets_PlayableClassesIndex_ForEra()
    {
        IPlayableClassApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/playable-class/index?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.PlayableClassesIndexResponse_ForEra);

        RequestResult<PlayableClassesIndex> result = await warcraftClient.GetPlayableClassesIndexAsync(namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPlayableClassAsync_Gets_PlayableClass_ForEra()
    {
        IPlayableClassApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/playable-class/7?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.PlayableClassResponse_ForEra);

        RequestResult<PlayableClass> result = await warcraftClient.GetPlayableClassAsync(7, namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPlayableClassMediaAsync_Gets_PlayableClassMedia_ForEra()
    {
        IPlayableClassApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/media/playable-class/7?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.PlayableClassMediaResponse_ForEra);

        RequestResult<PlayableClassMedia> result = await warcraftClient.GetPlayableClassMediaAsync(7, namespaceEra);
        Assert.NotNull(result.Value);
    }

}
