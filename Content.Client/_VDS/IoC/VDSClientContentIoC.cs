using Content.Client._VDS.Chat.Managers;

namespace Content.Client._VDS.IoC;

/// <summary>
/// Registers Vermist Dust Sector client-side dependencies.
/// </summary>
internal static class VDSClientContentIoC
{
    public static void Register()
    {
        var collection = IoCManager.Instance!;

        collection.Register<IClientChatOOCColorManager, ClientChatOOCColorManager>();
    }
}
