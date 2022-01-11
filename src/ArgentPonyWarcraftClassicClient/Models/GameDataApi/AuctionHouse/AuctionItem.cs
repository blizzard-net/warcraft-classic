namespace ArgentPonyWarcraftClassicClient;

/// <summary>
/// An auction item.
/// </summary>
public record AuctionItem
{
    /// <summary>
    /// Gets the ID of the auction item.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the rand of the auction item.
    /// </summary>
    [JsonPropertyName("rand")]
    public int? Rand { get; init; }

    /// <summary>
    /// Gets the seed of the auction item.
    /// </summary>
    [JsonPropertyName("seed")]
    public int? Seed { get; init; }
    
}
