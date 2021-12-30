namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class ItemApiTests
{
    [ResilientFact]
    public async Task GetItemClassesIndexAsync_Gets_ItemClassesIndex()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemClassesIndex> result = await warcraftClient.GetItemClassesIndexAsync("static-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/item-class/index?namespace=static-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetItemClassAsync_Gets_ItemClass()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemClass> result = await warcraftClient.GetItemClassAsync(0, "static-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/item-class/0?namespace=static-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetItemSubclassAsync_Gets_ItemSubclass()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemSubclass> result = await warcraftClient.GetItemSubclassAsync(0, 0, "static-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/item-class/0/item-subclass/0?namespace=static-classic-us&locale=en_US");
    }

    [ResilientFact(Skip = "Needs work after porting from retail.")]
    public async Task GetItemAsync_Gets_Item()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Item> result = await warcraftClient.GetItemAsync(19019, "static-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/item/19019?namespace=static-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetItemMediaAsync_Gets_Item()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemMedia> result = await warcraftClient.GetItemMediaAsync(19019, "static-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/media/item/19019?namespace=static-classic-us&locale=en_US");
    }
}
