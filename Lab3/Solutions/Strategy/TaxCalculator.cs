using Strategy;

namespace TaxStrategy
{
    public class TaxCalculator
    {
        private readonly ITaxStrategy _strategy;

        public TaxCalculator(ITaxStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal Calculate(decimal amount)
        {
            return _strategy.CalculateTax(amount);
        }
    }
}
