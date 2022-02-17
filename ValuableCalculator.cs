namespace Refactoring
{
    public class ValuableCalculator : IAccountDiscountCalculator
    {
        public decimal CalculateCost(decimal price)
        {
            return price - Constants.ValuableCustomerDiscount * price;
        }
    }
}