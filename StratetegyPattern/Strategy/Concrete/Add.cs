namespace StratetegyPattern.Strategy.Concrete
{
    public class Add : IStrategy
    {
        public decimal Execute(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
