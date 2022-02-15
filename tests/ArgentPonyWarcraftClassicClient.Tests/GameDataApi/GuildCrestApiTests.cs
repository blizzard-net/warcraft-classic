namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class GuildCrestApiTests
{
    [Fact]
    public async Task GetGuildCrestComponentsIndexAsync_Gets_GuildCrestComponentsIndex()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/guild-crest/index?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.GuildCrestComponentsIndexResponse_ForBCC);

        RequestResult<GuildCrestComponentsIndex> result = await warcraftClient.GetGuildCrestComponentsIndexAsync("static-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetGuildCrestBorderMediaAsync_Gets_GuildCrestBorderMedia()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/media/guild-crest/border/0?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.GuildCrestBorderMediaResponse_ForBCC);

        RequestResult<GuildCrestBorderMedia> result = await warcraftClient.GetGuildCrestBorderMediaAsync(0, "static-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetGuildCrestEmblemMediaAsync_Gets_GuildCrestEmblemMedia()
    {
        IGuildCrestApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/media/guild-crest/emblem/0?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.GuildCrestEmblemMediaResponse_ForBCC);

        RequestResult<GuildCrestEmblemMedia> result = await warcraftClient.GetGuildCrestEmblemMediaAsync(0, "static-classic-us");
        Assert.NotNull(result.Value);
    }
}
