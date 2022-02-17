using System;

namespace Refactoring
{
    public enum AccountType
    {
        NotRegistered = 1,
        SimpleCustomer = 2,
        ValuableCustomer = 3,
        MostValuableCustomer = 4
    }
    public class DiscountManager
    {
        private IAccountDiscountCalculatorFactory _factory;
        private ILoyaltyDiscountCalculator _loyaltyDiscountCalculator;
        public DiscountManager(IAccountDiscountCalculatorFactory factory, ILoyaltyDiscountCalculator loyaltyDiscountCalculator)
        {
            _factory = factory;
            _loyaltyDiscountCalculator = loyaltyDiscountCalculator;
        }
        public decimal CalculateCost(decimal price, AccountType accountType, int YearsOfHavingAccount)
        {
            decimal priceAfterDiscount = 0;
             var calc = _factory.GetAccountDiscountCalculator(accountType);
            priceAfterDiscount = calc.CalculateCost(price);
            priceAfterDiscount = _loyaltyDiscountCalculator.ApplyDiscount(priceAfterDiscount, YearsOfHavingAccount);
            return priceAfterDiscount;
        }
    }
}
