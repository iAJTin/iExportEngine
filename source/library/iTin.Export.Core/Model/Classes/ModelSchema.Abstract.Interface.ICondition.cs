
namespace iTin.Export.Model
{
    using ComponentModel;

    /// <summary>
    /// Declares a generic condition to use.
    /// </summary>
    public interface ICondition
    {
        string Apply();

        string Apply(int row, int col);

        string Apply(int row, int col, FieldValueInformation target);
    }
}
