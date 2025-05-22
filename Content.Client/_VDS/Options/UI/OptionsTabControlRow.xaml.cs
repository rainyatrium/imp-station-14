using Content.Client._VDS.Options.UI;
using Robust.Shared.Configuration;

namespace Content.Client.Options.UI;

public sealed partial class OptionsTabControlRow
{
    // TODO: comment details about all this later im tired
    public OptionOOCColorSlider AddOptionOOCColorSlider(
        CVarDef<string> cVar,
        OptionColorSlider slider)
    {
        return AddOption(new OptionOOCColorSlider(this,
            _cfg,
            cVar,
            slider));
    }
}
