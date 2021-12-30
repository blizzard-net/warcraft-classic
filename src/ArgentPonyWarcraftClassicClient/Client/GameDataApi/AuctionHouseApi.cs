﻿namespace ArgentPonyWarcraftClassicClient;

public partial class WarcraftClient
{
    /// <inheritdoc />
    public async Task<RequestResult<AuctionsIndex>> GetAuctionsAsync(int connectedRealmId, string @namespace)
    {
        return await GetAuctionsAsync(connectedRealmId, @namespace, Region, Locale);
    }

    /// <inheritdoc />
    public async Task<RequestResult<AuctionsIndex>> GetAuctionsAsync(int connectedRealmId, string @namespace, Region region, Locale locale)
    {
        string host = GetHost(region);
        return await GetAsync<AuctionsIndex>($"{host}/data/wow/connected-realm/{connectedRealmId}/auctions/index?namespace={@namespace}&locale={locale}");
    }
}
