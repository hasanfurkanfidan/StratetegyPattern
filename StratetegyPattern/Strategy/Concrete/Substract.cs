namespace StratetegyPattern.Strategy.Concrete
{
    public class Substract : IStrategy
    {
        public decimal Execute(decimal a, decimal b)
        {
            return a - b;
        }
    }
}
