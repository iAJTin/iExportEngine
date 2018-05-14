
namespace iTin.Export.ComponentModel.Patterns
{
    using System.Diagnostics;

    public class NotSpecification<T> : CompositeSpecification<T>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ISpecification<T> _other;

        public NotSpecification(ISpecification<T> other) => _other = other;

        public override bool IsSatisfiedBy(T candidate) => !_other.IsSatisfiedBy(candidate);
    }
}
