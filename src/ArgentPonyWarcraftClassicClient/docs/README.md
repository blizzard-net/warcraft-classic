# Argent Pony Warcraft Client

The Argent Pony Warcraft Client is a .NET client for the [Blizzard World of Warcraft Classic APIs](https://develop.battle.net/documentation/world-of-warcraft-classic).  It lets .NET applications easily access information about World of Warcraft characters, items, creatures, and more.  It is a [.NET Standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) 2.0 library, which means it supports a broad range of platforms, including .NET Core 2.0+ and .NET Framework 4.6.1+.

## Documentation

Documentation is available at [https://blizzard-net.github.io/warcraft-classic/](https://blizzard-net.github.io/warcraft-classic/)

## Usage

The `WarcraftClient` class provides access to the World of Warcraft APIs.

```cs
// Secrets from https://develop.battle.net/documentation/guides/getting-started.
string clientId = "MY-CLIENT-ID-GOES-HERE";
string clientSecret = "MY-CLIENT-SECRET-GOES-HERE";
var warcraftClient = new WarcraftClient(clientId, clientSecret);

// Retrieve the Westfall realm.
RequestResult<Realm> result = await warcraftClient.GetRealmAsync("westfall", "dynamic-classic-us");

// If we got it, display the realm slug.
if (result.Success)
{
    Realm realm = result.Value;
    Console.WriteLine($"Slug for {realm.Name}: {realm.Slug}");
}
```

See [Getting Started](https://blizzard-net.github.io/warcraft-classic/docs/getting-started) and [Using the Library](https://blizzard-net.github.io/warcraft-classic/docs/usage) for detailed instructions.

## Feedback

Report problems in the [GitHub Issues](https://github.com/blizzard-net/warcraft-classic/issues) for the project or join the [Discussions](https://github.com/blizzard-net/warcraft-classic/discussions).
