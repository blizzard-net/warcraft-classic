namespace ArgentPonyWarcraftClassicClient;

/// <summary>
///     A client for the World of Warcraft Game Data APIs.
/// </summary>
public interface IGameDataApi :
    IAuctionHouseApi,
    IConnectedRealmApi,
    ICreatureApi,
    IGuildCrestApi,
    IItemApi,
    IPlayableClassApi,
    IPlayableRaceApi,
    IPowerTypeApi,
    IPvpSeasonApi,
    IRealmApi,
    IRegionApi,
    IWowTokenApi
{
}
