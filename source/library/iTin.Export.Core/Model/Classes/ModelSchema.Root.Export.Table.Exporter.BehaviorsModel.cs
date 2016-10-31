using System.Collections.Generic;
using System.Linq;

using iTin.Export.ComponentModel;
using iTin.Export.Helper;

namespace iTin.Export.Model
{
    public partial class BehaviorsModel
    {
        #region constructor/s

            #region [public] BehaviorsModel(ExporterModel):
            /// <summary>
            /// Initializes a new instance of the <see cref="BehaviorsModel"/> class.
            /// </summary>
            /// <param name="parent">The parent.</param>
            public BehaviorsModel(ExporterModel parent)
                : base(parent)
            {
            }
            #endregion

        #endregion

        #region public methods

            #region [public] (void) Execute(IWriter, ExportSettings): Executes defined behaviors.
            /// <summary>
            /// Executes defined behaviors.
            /// </summary>
            /// <param name="writer">Writer to use.</param>
            /// <param name="settings">Writer settings.</param>
            public void Execute(IWriter writer, ExportSettings settings)
            {
                var behaviors =
                    this.Where(
                        behavior =>
                            behavior.GetType() != typeof(TransformFileBehaviorModel)
                            && behavior.GetType() != typeof(DownloadBehaviorModel));

                foreach (var behavior in behaviors)
                {
                    behavior.Execute(writer, settings);
                }

                var downloadBehavior = Get<DownloadBehaviorModel>();
                if (downloadBehavior != null)
                {
                    downloadBehavior.Execute(writer, settings);
                }
            }
            #endregion

        #endregion

        protected override void SetOwner(BaseBehaviorModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        #region [public] {static} (T) Get<T>(this List<T>) where T : IBehavior : Returns specified behavior.
        /// <summary>
        /// Returns specified behavior.
        /// </summary>
        /// <typeparam name="T">Behavior type</typeparam>
        /// <returns>
        /// Specified behavior.
        /// </returns>
        public T Get<T>() where T : IBehavior
        {
            return GetRange<T>().FirstOrDefault();
        }
        #endregion

        #region [public] {static} (List<T>) GetRange(this List<T>) where T : IBehavior: Returns an enumerator to a field list containing only those who meet the condition of type.
        /// <summary>
        /// Returns an enumerator to a field list containing only those who meet the condition of type.
        /// </summary>
        /// <typeparam name="T">Behavior type</typeparam>
        /// <returns>
        /// Enumerator that contains list of fields that meet the condition.
        /// </returns>
        public List<T> GetRange<T>() where T : IBehavior
        {

            return this.Where(behavior => behavior.GetType() == typeof(T)).Cast<T>().ToList();
        }
        #endregion
    }
}
