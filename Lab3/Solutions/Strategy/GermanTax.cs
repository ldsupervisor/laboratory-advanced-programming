
namespace Strategy
{
    public class GermanyTax : ITaxStrategy
    {
        public decimal CalculateTax(decimal amount)
        {
            return amount * 0.19m;
        }
    }
}
