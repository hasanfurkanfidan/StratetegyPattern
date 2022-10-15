namespace StratetegyPattern.Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public decimal ExecuteStrategy(int a, int b)
        {
            return _strategy.Execute(a, b);
        }
    }
}
