namespace ArgentPonyWarcraftClassicClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<AuctionHouseIndex>> GetAuctionHousesAsync(int connectedRealmId, string @namespace)
    {
        return await GetAuctionHousesAsync(connectedRealmId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AuctionHouseIndex>> GetAuctionHousesAsync(int connectedRealmId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<AuctionHouseIndex>($"{host}/data/wow/connected-realm/{connectedRealmId}/auctions/index?namespace={@namespace}&locale={locale}");
    }

    /// <inheritdoc />
    public async Task<RequestResult<AuctionsIndex>> GetAuctionsAsync(int auctionHouseId, int connectedRealmId, string @namespace)
    {
        return await GetAuctionsAsync(auctionHouseId, connectedRealmId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AuctionsIndex>> GetAuctionsAsync(int auctionHouseId, int connectedRealmId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<AuctionsIndex>(
            $"{host}/data/wow/connected-realm/{connectedRealmId}/auctions/{auctionHouseId}?namespace={@namespace}&locale={locale}");
    }
}
