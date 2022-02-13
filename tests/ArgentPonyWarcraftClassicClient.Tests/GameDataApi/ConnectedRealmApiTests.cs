namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class ConnectedRealmApiTests
{
    [Fact]
    public async Task GetConnectedRealmsIndexAsync_Gets_ConnectedRealmsIndex_ForBCC()
    {
        string @namespace = "dynamic-classic-us";

        IConnectedRealmApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/connected-realm/index?namespace={@namespace}&locale=en_US",
            responseContent: Resources.ConnectedRealmsIndexResponse_ForBCC);

        RequestResult<ConnectedRealmsIndex> result = await warcraftClient.GetConnectedRealmsIndexAsync(@namespace);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetRealmAsync_Gets_Realm_ForBCC()
    {
        int realmId = 4388;
        string @namespace = "dynamic-classic-us";

        IConnectedRealmApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/connected-realm/{realmId}?namespace={@namespace}&locale=en_US",
            responseContent: Resources.ConnectedRealmResponse_ForBCC);

        RequestResult<ConnectedRealm> result = await warcraftClient.GetConnectedRealmAsync(realmId, @namespace);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetConnectedRealmsIndexAsync_Gets_ConnectedRealmsIndex_ForEra()
    {
        string @namespace = "dynamic-classic1x-eu";

        IConnectedRealmApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/connected-realm/index?namespace={@namespace}&locale=en_US",
            responseContent: Resources.ConnectedRealmsIndexResponse_ForEra);

        RequestResult<ConnectedRealmsIndex> result = await warcraftClient.GetConnectedRealmsIndexAsync(@namespace);
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetRealmAsync_Gets_Realm_ForEra()
    {
        int realmId = 5265;
        string @namespace = "dynamic-classic1x-eu";

        IConnectedRealmApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: $"https://us.api.blizzard.com/data/wow/connected-realm/{realmId}?namespace={@namespace}&locale=en_US",
            responseContent: Resources.ConnectedRealmResponse_ForEra);

        RequestResult<ConnectedRealm> result = await warcraftClient.GetConnectedRealmAsync(realmId, @namespace);
        Assert.NotNull(result.Value);
    }
}
