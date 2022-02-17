namespace Refactoring
{
    internal class NotRegisteredDiscountCalculator : IAccountDiscountCalculator
    {
        public decimal CalculateCost(decimal price)
        {
            return price;
        }
    }
}