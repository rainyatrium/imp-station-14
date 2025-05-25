
using Content.Server._VDS.Chat.Managers;

namespace Content.Server._VDS.IoC;

/// <summary>
/// Registers Vermist Dust Sector server-side dependencies.
/// </summary>
internal static class VDSServerContentIoC
{
    public static void Register()
    {
        var collection = IoCManager.Instance!;

        collection.Register<IServerChatOOCColorManager, ServerChatOOCColorManager>();
    }
}
