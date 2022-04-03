namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class GuildCrestApiTests
{
    string namespaceBCC = "static-classic-us";
    string namespaceEra = "static-classic1x-eu";


    [Fact]
    public async Task GetGuildCrestComponentsIndexAsync_Gets_GuildCrestComponentsIndex_ForBCC()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/guild-crest/index?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.GuildCrestComponentsIndexResponse_ForBCC);

        RequestResult<GuildCrestComponentsIndex> result = await warcraftClient.GetGuildCrestComponentsIndexAsync(namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetGuildCrestBorderMediaAsync_Gets_GuildCrestBorderMedia_ForBCC()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/media/guild-crest/border/0?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.GuildCrestBorderMediaResponse_ForBCC);

        RequestResult<GuildCrestBorderMedia> result = await warcraftClient.GetGuildCrestBorderMediaAsync(0, namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetGuildCrestEmblemMediaAsync_Gets_GuildCrestEmblemMedia_ForBCC()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/media/guild-crest/emblem/0?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.GuildCrestEmblemMediaResponse_ForBCC);

        RequestResult<GuildCrestEmblemMedia> result = await warcraftClient.GetGuildCrestEmblemMediaAsync(0, namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetGuildCrestComponentsIndexAsync_Gets_GuildCrestComponentsIndex_ForEra()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/guild-crest/index?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.GuildCrestComponentsIndexResponse_ForEra);

        RequestResult<GuildCrestComponentsIndex> result = await warcraftClient.GetGuildCrestComponentsIndexAsync(namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetGuildCrestBorderMediaAsync_Gets_GuildCrestBorderMedia_ForEra()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/media/guild-crest/border/0?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.GuildCrestBorderMediaResponse_ForEra);

        RequestResult<GuildCrestBorderMedia> result = await warcraftClient.GetGuildCrestBorderMediaAsync(0, namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetGuildCrestEmblemMediaAsync_Gets_GuildCrestEmblemMedia_ForEra()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/media/guild-crest/emblem/0?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.GuildCrestEmblemMediaResponse_ForEra);

        RequestResult<GuildCrestEmblemMedia> result = await warcraftClient.GetGuildCrestEmblemMediaAsync(0, namespaceEra);
        Assert.NotNull(result.Value);
    }

}
