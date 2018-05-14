
namespace iTin.Export.ComponentModel.Patterns
{
    using System.Diagnostics;

    public abstract class StrategyContext
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly IStrategy _strategy;

        protected StrategyContext(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Execute()
        {
            _strategy.Execute();
        }
    }
}
