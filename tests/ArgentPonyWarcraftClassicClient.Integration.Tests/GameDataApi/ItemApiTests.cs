namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class ItemApiTests
{
    string namespaceBCC = "static-classic-us";
    Locale localeBCC = Locale.en_US;
    string hostBCC = "us.api.blizzard.com";

    string namespaceEra = "static-classic1x-eu";
    Region regionEra = Region.Europe;
    Locale localeEra = Locale.en_US;
    string hostEra = "eu.api.blizzard.com";

    [ResilientFact]
    public async Task GetItemClassesIndexAsync_Gets_ItemClassesIndex_ForBCC()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemClassesIndex> result = await warcraftClient.GetItemClassesIndexAsync(namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/item-class/index?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetItemClassAsync_Gets_ItemClass_ForBCC()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemClass> result = await warcraftClient.GetItemClassAsync(0, namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/item-class/0?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetItemSubclassAsync_Gets_ItemSubclass_ForBCC()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemSubclass> result = await warcraftClient.GetItemSubclassAsync(0, 0, namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/item-class/0/item-subclass/0?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetItemAsync_Gets_Item_ForBCC()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Item> result = await warcraftClient.GetItemAsync(19019, namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/item/19019?namespace={namespaceBCC}&locale={localeBCC}");
    }

    [ResilientFact]
    public async Task GetItemMediaAsync_Gets_ItemMedia_ForBCC()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemMedia> result = await warcraftClient.GetItemMediaAsync(19019, namespaceBCC);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostBCC}/data/wow/media/item/19019?namespace={namespaceBCC}&locale={localeBCC}");
    }


    [ResilientFact]
    public async Task GetItemClassesIndexAsync_Gets_ItemClassesIndex_ForEra()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemClassesIndex> result = await warcraftClient.GetItemClassesIndexAsync(namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/item-class/index?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetItemClassAsync_Gets_ItemClass_ForEra()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemClass> result = await warcraftClient.GetItemClassAsync(0, namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/item-class/0?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetItemSubclassAsync_Gets_ItemSubclass_ForEra()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemSubclass> result = await warcraftClient.GetItemSubclassAsync(0, 0, namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/item-class/0/item-subclass/0?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetItemAsync_Gets_Item_ForEra()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Item> result = await warcraftClient.GetItemAsync(19019, namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/item/19019?namespace={namespaceEra}&locale={localeEra}");
    }

    [ResilientFact]
    public async Task GetItemMediaAsync_Gets_ItemMedia_ForEra()
    {
        IItemApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ItemMedia> result = await warcraftClient.GetItemMediaAsync(19019, namespaceEra, regionEra, localeEra);

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync($"https://{hostEra}/data/wow/media/item/19019?namespace={namespaceEra}&locale={localeEra}");
    }

}
