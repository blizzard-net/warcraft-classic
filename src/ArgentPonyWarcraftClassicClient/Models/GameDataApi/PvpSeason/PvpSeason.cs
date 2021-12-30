namespace ArgentPonyWarcraftClassicClient;

/// <summary>
/// A PvP season.
/// </summary>
public record PvpSeason
{
    /// <summary>
    /// Gets links for the PvP season.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the PvP season.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the start timestamp of the PvP season.
    /// </summary>
    [JsonPropertyName("season_start_timestamp")]
    public DateTimeOffset SeasonStartTimestamp { get; init; }

    /// <summary>
    /// Gets the end timestamp of the PvP season.
    /// </summary>
    [JsonPropertyName("season_end_timestamp")]
    public DateTimeOffset SeasonEndTimestamp { get; init; }

    /// <summary>
    /// Gets references to the PvP regions for the PvP season.
    /// </summary>
    [JsonPropertyName("pvp_regions")]
    public Self[] PvpRegions { get; init; }
}
