# Argent Pony Warcraft Classic Client Dependency Injection

The Argent Pony Warcraft Classic Client Dependency Injection NuGet package is an extension that enables dependency injection for the [Argent Pony Warcraft Classic Client](https://www.nuget.org/packages/ArgentPonyWarcraftClassicClient/), a .NET client for the [Blizzard World of Warcraft Classic APIs](https://develop.battle.net/documentation/world-of-warcraft-classic).
It is a [.NET Standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) 2.0 library, which means it supports a broad range of platforms, including .NET Core 2.0+ and .NET Framework 4.6.1+.

## Documentation

Documentation is available at [https://blizzard-net.github.io/warcraft-classic/](https://blizzard-net.github.io/warcraft-classic/).

See especially [Dependency Injection](https://blizzard-net.github.io/warcraft-classic/docs/dependency-injection).

## Usage

Use the `AddWarcraftClients()` extension method on the `IServiceCollection` instance to register the necessary types.

```cs
public void ConfigureServices(IServiceCollection services)
{
    string clientId = "MY-CLIENT-ID-GOES-HERE";
    string clientSecret = "MY-CLIENT-SECRET-GOES-HERE";

    services.AddWarcraftClients(clientId, clientSecret);
}
```

## Feedback

Report problems in the [GitHub Issues](https://github.com/blizzard-net/warcraft-classic/issues) for the project or join the [Discussions](https://github.com/blizzard-net/warcraft-classic/discussions).
