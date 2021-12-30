﻿namespace ArgentPonyWarcraftClassicClient;

/// <summary>
/// A reference to a power type.
/// </summary>
public record PowerTypeReference
{
    /// <summary>
    /// Gets the key for the power type.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the name of the power type.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the ID of the power type.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
