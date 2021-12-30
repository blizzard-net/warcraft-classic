namespace ArgentPonyWarcraftClassicClient.Integration.Tests.GameDataApi;

public class RealmApiTests
{
    [ResilientFact]
    public async Task GetRealmsIndexAsync_Gets_RealmsIndex()
    {
        IRealmApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<RealmsIndex> result = await warcraftClient.GetRealmsIndexAsync("dynamic-classic-us");

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/realm/index?namespace=dynamic-classic-us&locale=en_US");
    }

    [ResilientFact]
    public async Task GetRealmAsync_Gets_Realm()
    {
        IRealmApi warcraftClient = ClientFactory.BuildClient();

        RequestResult<Realm> result = await warcraftClient.GetRealmAsync("westfall", "dynamic-classic-us");

        if (result.Success)
        {
            Realm realm = result.Value;
            Console.WriteLine($"Slug for {realm.Name}: {realm.Slug}");
        }

        await result.Should().BeSuccessfulRequest()
            .BeEquivalentToBlizzardResponseAsync("https://us.api.blizzard.com/data/wow/realm/westfall?namespace=dynamic-classic-us&locale=en_US");
    }
}
