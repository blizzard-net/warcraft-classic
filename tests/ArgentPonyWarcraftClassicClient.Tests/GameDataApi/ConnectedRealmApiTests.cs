namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class ConnectedRealmApiTests
{
    [Fact]
    public async Task GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex()
    {
        IConnectedRealmApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/connected-realm/index?namespace=dynamic-classic-us&locale=en_US",
            responseContent: Resources.ConnectedRealmsIndexResponse);

        RequestResult<ConnectedRealmsIndex> result = await warcraftClient.GetConnectedRealmsIndexAsync("dynamic-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetRealmAsync_Gets_Realm()
    {
        IConnectedRealmApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/connected-realm/11?namespace=dynamic-classic-us&locale=en_US",
            responseContent: Resources.ConnectedRealmResponse);

        RequestResult<ConnectedRealm> result = await warcraftClient.GetConnectedRealmAsync(11, "dynamic-classic-us");
        Assert.NotNull(result.Value);
    }
}
