namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class ConnectedRealmApiTests
{
    [ResilientFact]
    public async Task GetConnectedRealmsIndexAsync_Gets_ConnectedRealmsIndex()
    {
        IConnectedRealmApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ConnectedRealmsIndex> result = await warcraftClient.GetConnectedRealmsIndexAsync("dynamic-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/connected-realm/index?namespace=dynamic-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetRealmAsync_Gets_Realm()
    {
        IConnectedRealmApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<ConnectedRealm> result = await warcraftClient.GetConnectedRealmAsync(4372, "dynamic-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/connected-realm/4372?namespace=dynamic-classic-us&locale=en_US");
    }
}
