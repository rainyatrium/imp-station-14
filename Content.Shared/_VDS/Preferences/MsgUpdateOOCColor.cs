using System.IO;
using Lidgren.Network;
using Robust.Shared.Network;
using Robust.Shared.Serialization;
using Robust.Shared.Utility;

namespace Content.Shared._VDS.Preferences
{
    /// <summary>
    /// The client sends this to update their OOC color.
    /// </summary>

    #nullable disable
    public sealed class MsgUpdateOOCColor : NetMessage
    {
        public override MsgGroups MsgGroup => MsgGroups.Command;

        public string OOCColor = default!;

        public override void ReadFromBuffer(NetIncomingMessage buffer, IRobustSerializer serializer)
        {
            var length = buffer.ReadVariableInt32();
            using var stream = new MemoryStream(length);
            buffer.ReadAlignedMemory(stream, length);
            serializer.DeserializeDirect(stream, out OOCColor);
        }

        public override void WriteToBuffer(NetOutgoingMessage buffer, IRobustSerializer serializer)
        {
            var stream = new MemoryStream();
            serializer.SerializeDirect(stream, OOCColor);
            buffer.WriteVariableInt32((int) stream.Length);
            buffer.Write(stream.AsSpan());

        }
    }
}
