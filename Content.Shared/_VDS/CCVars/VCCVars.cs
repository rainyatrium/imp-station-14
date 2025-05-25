using Robust.Shared.Configuration;

namespace Content.Shared._VDS.CCVars;
/// <summary>
/// Vermist Dust Sector specific cvars.
/// </summary>
[CVarDefs]
public sealed class VCCVars
{
    /// <summary>
    /// Client OOC color, which will become stored in the DB.
    /// </summary>
    public static readonly CVarDef<string> OOCColor =
        CVarDef.Create("customization.ooccolor", "#b5aa6b", CVar.CLIENTONLY | CVar.ARCHIVE);
}
