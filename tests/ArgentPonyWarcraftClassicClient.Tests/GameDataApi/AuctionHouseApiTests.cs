namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class AuctionHouseApiTests
{
    [Fact]
    public async Task GetAuctionsAsync_Gets_Auctions()
    {
        IAuctionHouseApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/connected-realm/4372/auctions/index?namespace=dynamic-classic-us&locale=en_US",
            responseContent: Resources.AuctionsResponse);

        RequestResult<AuctionsIndex> result = await warcraftClient.GetAuctionsAsync(4372, "dynamic-classic-us");
        Assert.NotNull(result.Value);
    }
}
