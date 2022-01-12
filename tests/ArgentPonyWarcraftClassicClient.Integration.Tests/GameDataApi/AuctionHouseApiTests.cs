namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class AuctionHouseApiTests
{
    [ResilientFact]
    public async Task GetAuctionHousesAsync_Gets_AuctionHouseIndex_ForBCC()
    {
        int realmId = 4372;
        string @namespace = "dynamic-classic-us";

        IAuctionHouseApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<AuctionHouseIndex> result = await warcraftClient.GetAuctionHousesAsync(realmId, @namespace);

        await result.Should().BeSuccessfulRequest().BeEquivalentToBlizzardResponseAsync(
            $"https://us.api.blizzard.com/data/wow/connected-realm/{realmId}/auctions/index?namespace={@namespace}&locale=en_US");
    }

    [ResilientFact]
    public async Task GetAuctionsAsync_Gets_Auctions_ForBCC()
    {
        int realmId = 4386; // this must be a low pop server, otherwise this test could run very long
        int auctionHouseId = 2;
        string @namespace = "dynamic-classic-us";

        IAuctionHouseApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<AuctionsIndex> result = await warcraftClient.GetAuctionsAsync(auctionHouseId, realmId, @namespace);

        await result.Should().BeSuccessfulRequest().BeEquivalentToBlizzardResponseAsync(
            $"https://us.api.blizzard.com/data/wow/connected-realm/{realmId}/auctions/{auctionHouseId}?namespace={@namespace}&locale=en_US");
    }

    [ResilientFact]
    public async Task GetAuctionHousesAsync_Gets_AuctionHouseIndex_ForEra()
    {
        int realmId = 5121;
        string @namespace = "dynamic-classic1x-us";

        IAuctionHouseApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<AuctionHouseIndex> result = await warcraftClient.GetAuctionHousesAsync(realmId, @namespace);

        await result.Should().BeSuccessfulRequest().BeEquivalentToBlizzardResponseAsync(
            $"https://us.api.blizzard.com/data/wow/connected-realm/{realmId}/auctions/index?namespace={@namespace}&locale=en_US");
    }

    [ResilientFact]
    public async Task GetAuctionsAsync_Gets_Auctions_ForEra()
    {
        int realmId = 5139; // this must be a low pop server, otherwise this test could run very long
        int auctionHouseId = 6;
        string @namespace = "dynamic-classic1x-us";

        IAuctionHouseApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<AuctionsIndex> result = await warcraftClient.GetAuctionsAsync(auctionHouseId, realmId, @namespace);

        await result.Should().BeSuccessfulRequest().BeEquivalentToBlizzardResponseAsync(
            $"https://us.api.blizzard.com/data/wow/connected-realm/{realmId}/auctions/{auctionHouseId}?namespace={@namespace}&locale=en_US");
    }
}
