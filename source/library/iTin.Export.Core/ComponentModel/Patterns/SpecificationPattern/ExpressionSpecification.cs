
namespace iTin.Export.ComponentModel.Patterns
{
    using System;
    using System.Diagnostics;

    public class ExpressionSpecification<T> : CompositeSpecification<T>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Func<T, bool> _expression;

        public ExpressionSpecification(Func<T, bool> expression)
        {
            _expression = expression ?? throw new ArgumentNullException();
        }

        public override bool IsSatisfiedBy(T candidate)
        {
            return _expression(candidate);
        }
    }
}
