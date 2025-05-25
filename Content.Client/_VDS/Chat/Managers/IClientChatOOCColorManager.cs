namespace Content.Client._VDS.Chat.Managers;

public interface IClientChatOOCColorManager
{
    void Initialize();
    void HandleUpdateOOCColorMessage(Color color);
}
