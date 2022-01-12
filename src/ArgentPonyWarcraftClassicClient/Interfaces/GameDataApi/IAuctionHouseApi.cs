﻿namespace ArgentPonyWarcraftClassicClient;

/// <summary>
///     A client for the World of Warcraft Auction House API.
/// </summary>
public interface IAuctionHouseApi
{
    /// <summary>
    ///     Gets an index of auction houses
    /// </summary>
    /// <param name="connectedRealmId">The ID of the connected realm.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <returns>
    ///     The auction house index
    /// </returns>
    Task<RequestResult<AuctionHouseIndex>> GetAuctionHousesAsync(int connectedRealmId, string @namespace);

    /// <summary>
    ///     Gets an index of auction houses
    /// </summary>
    /// <param name="connectedRealmId">The ID of the connected realm.</param>
    /// <param name="namespace">The namespace to use to locate this document.</param>
    /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
    /// <param name="locale">Specifies the language that the result will be in.</param>
    /// <returns>
    ///     The auction house index
    /// </returns>
    Task<RequestResult<AuctionHouseIndex>> GetAuctionHousesAsync(int connectedRealmId, string @namespace, Region region, Locale locale);

    /// <summary>
    ///     Gets an index of auctions
    /// </summary>
    /// <param name="auctionHouseId"></param>
    /// <param name="connectedRealmId"></param>
    /// <param name="namespace"></param>
    /// <returns>
    ///     The auctions index
    /// </returns>
    Task<RequestResult<AuctionsIndex>> GetAuctionsAsync(int auctionHouseId, int connectedRealmId, string @namespace);

    /// <summary>
    ///     Gets an index of auctions
    /// </summary>
    /// <param name="auctionHouseId"></param>
    /// <param name="connectedRealmId"></param>
    /// <param name="namespace"></param>
    /// <param name="region"></param>
    /// <param name="locale"></param>
    /// <returns>
    ///     The auctions index
    /// </returns>
    Task<RequestResult<AuctionsIndex>> GetAuctionsAsync(int auctionHouseId, int connectedRealmId, string @namespace, Region region, Locale locale);
}
