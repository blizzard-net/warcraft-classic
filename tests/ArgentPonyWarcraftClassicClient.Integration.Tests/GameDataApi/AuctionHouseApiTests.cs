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
        int realmId = 4372; 
        int auctionHouseId = 7;
        string @namespace = "dynamic-classic-us";

        IAuctionHouseApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<AuctionsIndex> result = await warcraftClient.GetAuctionsAsync(auctionHouseId, realmId, @namespace);

        await result.Should().BeSuccessfulRequest().BeEquivalentToBlizzardResponseAsync(
            $"https://us.api.blizzard.com/data/wow/connected-realm/{realmId}/auctions/{auctionHouseId}?namespace={@namespace}&locale=en_US");
    }

    [ResilientFact]
    public async Task GetAuctionHousesAsync_Gets_AuctionHouseIndex_ForEra()
    {
        int realmId = 5265;
        string @namespace = "dynamic-classic1x-eu";
        Region region = Region.Europe;
        Locale locale = Locale.en_US;
        string host = "eu.api.blizzard.com";

        IAuctionHouseApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<AuctionHouseIndex> result = await warcraftClient.GetAuctionHousesAsync(realmId, @namespace, region, locale);

        await result.Should().BeSuccessfulRequest().BeEquivalentToBlizzardResponseAsync(
            $"https://{host}/data/wow/connected-realm/{realmId}/auctions/index?namespace={@namespace}&locale=en_US");
    }

    [ResilientFact]
    public async Task GetAuctionsAsync_Gets_Auctions_ForEra()
    {
        int realmId = 5265; 
        int auctionHouseId = 7;
        string @namespace = "dynamic-classic1x-eu";
        Region region = Region.Europe;
        Locale locale = Locale.en_US;
        string host = "eu.api.blizzard.com";


        IAuctionHouseApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<AuctionsIndex> result = await warcraftClient.GetAuctionsAsync(auctionHouseId, realmId, @namespace, region, locale);

        await result.Should().BeSuccessfulRequest().BeEquivalentToBlizzardResponseAsync(
            $"https://{host}/data/wow/connected-realm/{realmId}/auctions/{auctionHouseId}?namespace={@namespace}&locale=en_US");
    }
}
