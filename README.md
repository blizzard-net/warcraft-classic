# Argent Pony Warcraft Classic Client

The Argent Pony Warcraft Classic Client is a .NET client for the [Blizzard World of Warcraft Classic APIs](https://develop.battle.net/documentation/world-of-warcraft-classic).  It lets .NET applications easily access information about World of Warcraft characters, items, creatures, and more.  It is a [.NET Standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) 2.0 library, which means it supports a broad range of platforms, including .NET Core 2.0+ and .NET Framework 4.6.1+.

[![NuGet version](https://badge.fury.io/nu/ArgentPonyWarcraftClassicClient.svg)](https://badge.fury.io/nu/ArgentPonyWarcraftClassicClient)
[![build](https://github.com/blizzard-net/warcraft-classic/actions/workflows/build.yml/badge.svg)](https://github.com/blizzard-net/warcraft-classic/actions/workflows/build.yml)
[![CodeQL](https://github.com/blizzard-net/warcraft-classic/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/blizzard-net/warcraft-classic/actions/workflows/codeql-analysis.yml)

## Documentation

Documentation is available at [https://blizzard-net.github.io/warcraft-classic/](https://blizzard-net.github.io/warcraft-classic/)

- [Introduction](https://blizzard-net.github.io/warcraft-classic/docs/)
- [Getting Started](https://blizzard-net.github.io/warcraft-classic/docs/getting-started)
- [Using the Library](https://blizzard-net.github.io/warcraft-classic/docs/usage)
- [Dependency Injection](https://blizzard-net.github.io/warcraft-classic/docs/dependency-injection)

## Quick Start

Create a new Console Application in Visual Studio or via [dotnet new](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new).

```shell
dotnet new console --name QuickStart
```

Add the [ArgentPonyWarcraftClassicClient](https://www.nuget.org/packages/ArgentPonyWarcraftClassicClient) NuGet package to the project:

```shell
dotnet add QuickStart package ArgentPonyWarcraftClassicClient
```

Update **Program.cs** in the new project as follows, subsituting your own client ID and secret from Blizzard's [Getting Started](https://develop.battle.net/documentation/guides/getting-started) instructions:

```cs
using System;
using System.Threading.Tasks;
using ArgentPonyWarcraftClassicClient;

namespace QuickStart
{
    class Program
    {
        static async Task Main(string[] args)
        {
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
        }
    }
}
```

Build and run the console application.

```shell
cd QuickStart
dotnet run
```

The console output displays the profile data that was retrieved from the Blizzard Realm API.
The library supports many other APIs, too.

```shell
Slug for Westfall: westfall
```
