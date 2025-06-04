namespace Strategy
{
    public class PolandTax : ITaxStrategy
    {
        public decimal CalculateTax(decimal amount)
        {
            return amount * 0.23m;
        }
    }
}
