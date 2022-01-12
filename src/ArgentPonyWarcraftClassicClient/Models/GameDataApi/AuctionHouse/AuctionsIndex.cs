namespace ArgentPonyWarcraftClassicClient;

/// <summary>
/// An index of auctions.
/// </summary>
public record AuctionsIndex
{
    /// <summary>
    /// Gets links for the index of auctions.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the connected realm associated with the auctions.
    /// </summary>
    [JsonPropertyName("connected_realm")]
    public Self ConnectedRealm { get; init; }

    /// <summary>
    /// Gets the auction house references.
    /// </summary>
    [JsonPropertyName("auctions")]
    public Auction[] Auctions { get; init; }

    /// <summary>
    /// Gets the index of the auction house
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the auction house
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

}
