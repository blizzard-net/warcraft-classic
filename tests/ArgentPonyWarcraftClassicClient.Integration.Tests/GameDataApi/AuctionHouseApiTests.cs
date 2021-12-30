namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class AuctionHouseApiTests
{
    [ResilientFact]
    public async Task GetAuctionsAsync_Gets_Auctions()
    {
        IAuctionHouseApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<AuctionsIndex> result = await warcraftClient.GetAuctionsAsync(4372, "dynamic-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/connected-realm/4372/auctions/index?namespace=dynamic-classic-us&locale=en_US");
    }
}
