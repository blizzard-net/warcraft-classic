namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class PlayableRaceApiTests
{
    string namespaceBCC = "static-classic-us";
    Locale localeBCC = Locale.en_US;
    string hostBCC = "us.api.blizzard.com";

    string namespaceEra = "static-classic1x-eu";
    Region regionEra = Region.Europe;
    Locale localeEra = Locale.en_US;
    string hostEra = "eu.api.blizzard.com";

    [ResilientFact]
    public async Task GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex_ForBCC()
    {
        IPlayableRaceApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PlayableRacesIndex> result = await warcraftClient.GetPlayableRacesIndexAsync(namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/playable-race/index?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetPlayableRaceAsync_Gets_PlayableRace_ForBCC()
    {
        IPlayableRaceApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PlayableRace> result = await warcraftClient.GetPlayableRaceAsync(2, namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/playable-race/2?namespace={namespaceBCC}&locale={localeBCC}");
    }


    [ResilientFact]
    public async Task GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex_ForEra()
    {
        IPlayableRaceApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PlayableRacesIndex> result = await warcraftClient.GetPlayableRacesIndexAsync(namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/playable-race/index?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetPlayableRaceAsync_Gets_PlayableRace_ForEra()
    {
        IPlayableRaceApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<PlayableRace> result = await warcraftClient.GetPlayableRaceAsync(2, namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/playable-race/2?namespace={namespaceEra}&locale={localeEra}");
    }

}
