// File to store as much VDS related database things outside of Model.cs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Content.Server.Database;

public static class VDSModel
{
    /// <summary>
    /// Stores CD Character data separately from the main Profile. This is done to work around a bug
    /// in EFCore migrations.
    /// <p />
    /// There is no way of forcing a dependent table to exist in EFCore (according to MS).
    /// You must always account for the possibility of this table not existing.
    /// </summary>
    public class VDSProfile
    {
        [Key]
        [ForeignKey("Preference")]
        public string OOCColor { get; set; } = string.Empty;
x

    }

}
