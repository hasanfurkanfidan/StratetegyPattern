namespace StratetegyPattern.Strategy.Concrete
{
    public class Multiply : IStrategy
    {
        public decimal Execute(decimal a, decimal b)
        {
            return a * b;
        }
    }
}
