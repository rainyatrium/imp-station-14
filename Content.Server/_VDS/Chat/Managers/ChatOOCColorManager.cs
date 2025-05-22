using Content.Server.Database;
using Content.Server.EUI;
using Content.Shared._VDS.Preferences;
using Robust.Shared.Network;

namespace Content.Server._VDS.Chat.Managers;

public sealed class ChatOOCColorManager
{
    [Dependency] private readonly IServerDbManager _db = default!;
    [Dependency] private readonly INetManager _net = default!;
    [Dependency] private readonly ISawmill _sawmill = default!;

    public void Initialize()
    {
        _net.RegisterNetMessage<MsgUpdateOOCColor>();
    }
    public async void HandleUpdateOOCColorMessage(MsgUpdateOOCColor message)
    {
        var userId = message.MsgChannel.UserId;
        var hex = message.OOCColor;
        var color = Color.TryFromHex(hex);
        if (!color.HasValue)
        {
            _sawmill.Error("Incoming OOC Color is invalid.");
            return;
        }
        await _db.SaveOOCColorAsync(userId, color.Value);
    }

    public void PostInject()
    {

    }
}
