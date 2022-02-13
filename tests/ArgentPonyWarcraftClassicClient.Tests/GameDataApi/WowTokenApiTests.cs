﻿namespace ArgentPonyWarcraftClassicClient.Tests.GameDataApi;

public class WowTokenApiTests
{
    [Fact]
    public async Task GetWowTokenIndexAsync_Gets_WowTokenIndex()
    {
        IWowTokenApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/token/index?namespace=dynamic-us&locale=en_US",
            responseContent: Resources.WowTokenIndexResponse_ForBCC);

        RequestResult<WowTokenIndex> result = await warcraftClient.GetWowTokenIndexAsync("dynamic-us");
        Assert.NotNull(result.Value);
    }
}
