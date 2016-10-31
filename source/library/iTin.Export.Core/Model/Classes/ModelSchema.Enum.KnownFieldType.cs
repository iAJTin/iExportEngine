namespace iTin.Export.Model
{
    /// <summary>
    /// Specifies data field type.
    /// </summary>
    public enum KnownFieldType
    {
        /// <summary>
        /// Data field, please see <see cref="T:iTin.Export.Model.DataFieldModel"/> for more information.
        /// </summary>
        Field,

        /// <summary>
        /// Gap field, please see <see cref="T:iTin.Export.Model.GapFieldModel"/> for more information.
        /// </summary>
        Gap,

        /// <summary>
        /// Group field, please see <see cref="T:iTin.Export.Model.GroupFieldModel"/> for more information.
        /// </summary>
        Group,

        /// <summary>
        /// Fixed field, please see <see cref="T:iTin.Export.Model.FixedFieldModel"/> for more information.
        /// </summary>
        Fixed,

        /// <summary>
        /// Packet data field, please see <see cref="T:iTin.Export.Model.PacketFieldModel"/> for more information.
        /// </summary>
        Packet
    }
}
