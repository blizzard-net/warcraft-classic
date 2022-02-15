namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class ItemApiTests
{
    [Fact]
    public async Task GetItemClassesIndexAsync_Gets_ItemClassesIndex()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/item-class/index?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.ItemClassesIndexResponse_ForBCC);

        RequestResult<ItemClassesIndex> result = await warcraftClient.GetItemClassesIndexAsync("static-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemClassAsync_Gets_ItemClass()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/item-class/0?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.ItemClassResponse_ForBCC);

        RequestResult<ItemClass> result = await warcraftClient.GetItemClassAsync(0, "static-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemSubclassAsync_Gets_ItemSubclass()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/item-class/0/item-subclass/0?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.ItemSubclassResponse_ForBCC);

        RequestResult<ItemSubclass> result = await warcraftClient.GetItemSubclassAsync(0, 0, "static-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemAsync_Gets_Item()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/item/19019?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.ItemResponse_ForBCC);

        RequestResult<Item> result = await warcraftClient.GetItemAsync(19019, "static-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemMediaAsync_Gets_Item()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/media/item/19019?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.ItemMediaResponse_ForBCC);

        RequestResult<ItemMedia> result = await warcraftClient.GetItemMediaAsync(19019, "static-classic-us");
        Assert.NotNull(result.Value);
    }
}
