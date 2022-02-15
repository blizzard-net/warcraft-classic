namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class AuctionHouseApiTests
{
    [Fact]
    public async Task GetAuctionHousesAsync_Gets_AuctionHouseIndex_ForBCC()
    {
        int realmId = 4372;
        string @namespace = "dynamic-classic-us";

        IAuctionHouseApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/connected-realm/{realmId}/auctions/index?namespace={@namespace}&locale=en_US",
            responseContent: Resources.AuctionIndexResponse_ForBCC);

        RequestResult<AuctionHouseIndex> result = await warcraftClient.GetAuctionHousesAsync(realmId, @namespace);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetAuctionsAsync_Gets_Auctions_ForBCC()
    {
        int realmId = 4372; 
        int auctionHouseId = 7;
        string @namespace = "dynamic-classic-us";

        IAuctionHouseApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/connected-realm/{realmId}/auctions/{auctionHouseId}?namespace={@namespace}&locale=en_US",
            responseContent: Resources.AuctionsResponse_ForBCC);

        RequestResult<AuctionsIndex> result = await warcraftClient.GetAuctionsAsync(auctionHouseId, realmId, @namespace);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetAuctionHousesAsync_Gets_AuctionHouseIndex_ForEra()
    {
        int realmId = 5265;
        string @namespace = "dynamic-classic1x-eu";

        IAuctionHouseApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/connected-realm/{realmId}/auctions/index?namespace={@namespace}&locale=en_US",
            responseContent: Resources.AuctionIndexResponse_ForEra);

        RequestResult<AuctionHouseIndex> result = await warcraftClient.GetAuctionHousesAsync(realmId, @namespace);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetAuctionsAsync_Gets_Auctions_ForEra()
    {
        int realmId = 5265; 
        int auctionHouseId = 7;
        string @namespace = "dynamic-classic1x-eu";

        IAuctionHouseApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/connected-realm/{realmId}/auctions/{auctionHouseId}?namespace={@namespace}&locale=en_US",
            responseContent: Resources.AuctionsResponse_ForEra);

        RequestResult<AuctionsIndex> result = await warcraftClient.GetAuctionsAsync(auctionHouseId, realmId, @namespace);
        Assert.NotNull(result.Value);
    }

}

