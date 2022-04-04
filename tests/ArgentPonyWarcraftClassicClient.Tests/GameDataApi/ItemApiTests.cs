namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class ItemApiTests
{
    string namespaceBCC = "static-classic-us";
    string namespaceEra = "static-classic1x-eu";

    [Fact]
    public async Task GetItemClassesIndexAsync_Gets_ItemClassesIndex_ForBCC()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/item-class/index?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.ItemClassesIndexResponse_ForBCC);

        RequestResult<ItemClassesIndex> result = await warcraftClient.GetItemClassesIndexAsync(namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemClassAsync_Gets_ItemClass_ForBCC()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/item-class/0?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.ItemClassResponse_ForBCC);

        RequestResult<ItemClass> result = await warcraftClient.GetItemClassAsync(0, namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemSubclassAsync_Gets_ItemSubclass_ForBCC()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/item-class/0/item-subclass/0?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.ItemSubclassResponse_ForBCC);

        RequestResult<ItemSubclass> result = await warcraftClient.GetItemSubclassAsync(0, 0, namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemAsync_Gets_Item_ForBCC()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/item/19019?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.ItemResponse_ForBCC);

        RequestResult<Item> result = await warcraftClient.GetItemAsync(19019, namespaceBCC);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemMediaAsync_Gets_Item_ForBCC()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/media/item/19019?namespace={namespaceBCC}&locale=en_US",
            responseContent: Resources.ItemMediaResponse_ForBCC);

        RequestResult<ItemMedia> result = await warcraftClient.GetItemMediaAsync(19019, namespaceBCC);
        Assert.NotNull(result.Value);
    }


    [Fact]
    public async Task GetItemClassesIndexAsync_Gets_ItemClassesIndex_ForEra()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/item-class/index?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.ItemClassesIndexResponse_ForBCC);

        RequestResult<ItemClassesIndex> result = await warcraftClient.GetItemClassesIndexAsync(namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemClassAsync_Gets_ItemClass_ForEra()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/item-class/0?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.ItemClassResponse_ForBCC);

        RequestResult<ItemClass> result = await warcraftClient.GetItemClassAsync(0, namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemSubclassAsync_Gets_ItemSubclass_ForEra()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/item-class/0/item-subclass/0?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.ItemSubclassResponse_ForBCC);

        RequestResult<ItemSubclass> result = await warcraftClient.GetItemSubclassAsync(0, 0, namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemAsync_Gets_Item_ForEra()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/item/19019?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.ItemResponse_ForBCC);

        RequestResult<Item> result = await warcraftClient.GetItemAsync(19019, namespaceEra);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetItemMediaAsync_Gets_Item_ForEra()
    {
        IItemApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/media/item/19019?namespace={namespaceEra}&locale=en_US",
            responseContent: Resources.ItemMediaResponse_ForBCC);

        RequestResult<ItemMedia> result = await warcraftClient.GetItemMediaAsync(19019, namespaceEra);
        Assert.NotNull(result.Value);
    }

}
