namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class PlayableClassApiTests
{
    string namespaceBCC = "static-classic-us";
    Locale localeBCC = Locale.en_US;
    string hostBCC = "us.api.blizzard.com";

    string namespaceEra = "static-classic1x-eu";
    Region regionEra = Region.Europe;
    Locale localeEra = Locale.en_US;
    string hostEra = "eu.api.blizzard.com";

    [ResilientFact]
    public async Task GetPlayableClassesIndexAsync_Gets_PlayableClassesIndex_ForBCC()
    {
        IPlayableClassApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PlayableClassesIndex> result = await warcraftClient.GetPlayableClassesIndexAsync(namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/playable-class/index?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetPlayableClassAsync_Gets_PlayableClass_ForBCC()
    {
        IPlayableClassApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PlayableClass> result = await warcraftClient.GetPlayableClassAsync(7, namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/playable-class/7?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetPlayableClassMediaAsync_Gets_PlayableClassMedia_ForBCC()
    {
        IPlayableClassApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PlayableClassMedia> result = await warcraftClient.GetPlayableClassMediaAsync(7, namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/media/playable-class/7?namespace={namespaceBCC}&locale={localeBCC}");
    }


    [ResilientFact]
    public async Task GetPlayableClassesIndexAsync_Gets_PlayableClassesIndex_ForEra()
    {
        IPlayableClassApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PlayableClassesIndex> result = await warcraftClient.GetPlayableClassesIndexAsync(namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/playable-class/index?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetPlayableClassAsync_Gets_PlayableClass_ForEra()
    {
        IPlayableClassApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PlayableClass> result = await warcraftClient.GetPlayableClassAsync(7, namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/playable-class/7?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetPlayableClassMediaAsync_Gets_PlayableClassMedia_ForEra()
    {
        IPlayableClassApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PlayableClassMedia> result = await warcraftClient.GetPlayableClassMediaAsync(7, namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/media/playable-class/7?namespace={namespaceEra}&locale={localeEra}");
    }

}
