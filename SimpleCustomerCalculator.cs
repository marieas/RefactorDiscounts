namespace Refactoring
{
    internal class SimpleCustomerCalculator : IAccountDiscountCalculator
    {
        public decimal CalculateCost(decimal price)
        {
            return price - Constants.SimpleCustomerDiscount * price;
        }
    }
}