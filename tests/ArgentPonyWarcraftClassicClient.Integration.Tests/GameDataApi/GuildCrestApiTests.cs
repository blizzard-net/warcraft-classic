namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class GuildCrestApiTests
{
    string namespaceBCC = "static-classic-us";
    Locale localeBCC = Locale.en_US;
    string hostBCC = "us.api.blizzard.com";

    string namespaceEra = "static-classic1x-eu";
    Region regionEra = Region.Europe;
    Locale localeEra = Locale.en_US;
    string hostEra = "eu.api.blizzard.com";

    [ResilientFact]
    public async Task GetGuildCrestComponentsIndexAsync_Gets_GuildCrestComponentsIndex_ForBCC()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<GuildCrestComponentsIndex> result = await warcraftClient.GetGuildCrestComponentsIndexAsync(namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/guild-crest/index?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetGuildCrestBorderMediaAsync_Gets_GuildCrestBorderMedia_ForBCC()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<GuildCrestBorderMedia> result = await warcraftClient.GetGuildCrestBorderMediaAsync(0, namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/media/guild-crest/border/0?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetGuildCrestEmblemMediaAsync_Gets_GuildCrestEmblemMedia_ForBCC()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<GuildCrestEmblemMedia> result = await warcraftClient.GetGuildCrestEmblemMediaAsync(0, namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/media/guild-crest/emblem/0?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetGuildCrestComponentsIndexAsync_Gets_GuildCrestComponentsIndex_ForEra()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<GuildCrestComponentsIndex> result = await warcraftClient.GetGuildCrestComponentsIndexAsync(namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/guild-crest/index?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetGuildCrestBorderMediaAsync_Gets_GuildCrestBorderMedia_ForEra()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<GuildCrestBorderMedia> result = await warcraftClient.GetGuildCrestBorderMediaAsync(0, namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/media/guild-crest/border/0?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetGuildCrestEmblemMediaAsync_Gets_GuildCrestEmblemMedia_ForEra()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<GuildCrestEmblemMedia> result = await warcraftClient.GetGuildCrestEmblemMediaAsync(0, namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/media/guild-crest/emblem/0?namespace={namespaceEra}&locale={localeEra}");
    }

}
