using System.Net;

namespace ArgentPonyWarcraftClassicClient.Tests;

public class WarcraftClientTestsErrorConditions
{
    [Fact]
    public async Task InvalidIdProducesNotFoundError()
    {
        IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/item/99999991?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.Item404ErrorResponse,
            statusCode: HttpStatusCode.NotFound);

        RequestResult<Item> result = await warcraftClient.GetItemAsync(99999991, "static-classic-us");
        Assert.NotNull(result.Error);
        Assert.Equal(404, result.Error.Code);
        Assert.False(result.Success);
        Assert.Null(result.Value);
    }

    [Fact]
    public async Task ProducesForbiddenError()
    {
        IWarcraftClient warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/item/19019?namespace=static-classic-us&locale=en_US",
            responseContent: Resources.AccountInactive403ForbiddenResponse,
            statusCode: HttpStatusCode.Forbidden);

        RequestResult<Item> result = await warcraftClient.GetItemAsync(19019, "static-classic-us");
        Assert.NotNull(result.Error);
        Assert.Equal(403, result.Error.Code);
        Assert.False(result.Success);
        Assert.Null(result.Value);
    }

    [Fact]
    public void Throws_ArgumentException_Invaild_Region_Locale()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            IWarcraftClient client = new WarcraftClient("clientIdHere", "clientSecretHere", Region.Korea, Locale.fr_FR);
        });
    }
}
