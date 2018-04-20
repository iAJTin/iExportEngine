
namespace iTin.Export.Model
{
    using ComponentModel;

    /// <summary>
    /// Declares a generic behavior to use to with an exporter.
    /// </summary>
    public interface IBehavior
    {
        /// <summary>
        /// Gets a value indicating whether executes behavior.
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> if executes behavior; otherwise, <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.Yes" />.
        /// </value>
        YesNo CanExecute { get; }

        /// <summary>
        /// Gets the element that owns this data field.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.BehaviorsModel" /> that owns this data field.
        /// </value>
        BehaviorsModel Owner { get; }

        /// <summary>
        /// Execute behavior.
        /// </summary>
        /// <param name="writer">The writer.</param>
        void Execute(IWriter writer);

        /// <summary>
        /// Execute behavior.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="settings">Exporter settings.</param>
        void Execute(IWriter writer, ExportSettings settings);

        /// <summary>
        /// Sets a reference to the owner object that contains this instance.
        /// </summary>
        /// <param name="reference">Owner reference.</param>
        void SetOwner(BehaviorsModel reference);
    }
}
