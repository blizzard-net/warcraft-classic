namespace ArgentPonyWarcraftClassicClient;

/// <summary>
/// A reference to an auction house.
/// </summary>
public record AuctionHouseReference
{
    /// <summary>
    /// Gets the key for the auction house.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the auction house.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the auction house.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
