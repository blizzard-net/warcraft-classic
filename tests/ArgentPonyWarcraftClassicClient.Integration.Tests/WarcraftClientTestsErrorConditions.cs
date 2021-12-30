using Xunit;

namespace ArgentPonyWarcraftClassicClient.Integration.Tests;

public class WarcraftClientTestsErrorConditions
{
    [ResilientFact]
    public async Task InvalidIdProducesNotFoundError()
    {
        IWarcraftClient warcraftClient = ClientFactory.BuildClient();

        RequestResult<Item> result = await warcraftClient.GetItemAsync(99999991, "static-classic-us");
        Assert.NotNull(result.Error);
        Assert.Equal(404, result.Error.Code);
        Assert.False(result.Success);
        Assert.Null(result.Value);
    }
}
