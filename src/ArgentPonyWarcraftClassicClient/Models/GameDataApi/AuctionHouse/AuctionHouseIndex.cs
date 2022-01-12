namespace ArgentPonyWarcraftClassicClient;

/// <summary>
/// An index of auctions.
/// </summary>
public class AuctionHouseIndex
{
    /// <summary>
    /// Gets links for the index of auctions.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the auction house references.
    /// </summary>
    [JsonPropertyName("auctions")]
    public AuctionHouseReference[] AuctionHouse { get; init; }
}
