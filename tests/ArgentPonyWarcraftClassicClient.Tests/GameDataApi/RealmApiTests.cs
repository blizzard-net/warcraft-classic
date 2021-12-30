namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class RealmApiTests
{
    [Fact]
    public async Task GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex()
    {
        IRealmApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/realm/index?namespace=dynamic-classic-us&locale=en_US",
            responseContent: Resources.RealmIndexResponse);

        RequestResult<RealmsIndex> result = await warcraftClient.GetRealmsIndexAsync("dynamic-classic-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetRealmAsync_Gets_Realm()
    {
        IRealmApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/realm/tichondrius?namespace=dynamic-classic-us&locale=en_US",
            responseContent: Resources.RealmResponse);

        RequestResult<Realm> result = await warcraftClient.GetRealmAsync("tichondrius", "dynamic-classic-us");
        Assert.NotNull(result.Value);
    }
}
