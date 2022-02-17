using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring
{
    public interface ILoyaltyDiscountCalculator
    {
        decimal ApplyDiscount(decimal price, int YearsOfHavingAccount);
    }
    public class LoyaltyDiscountCalculator : ILoyaltyDiscountCalculator
    {
        public decimal ApplyDiscount(decimal price, int YearsOfHavingAccount)
        {
            decimal discountForAccountAge = (YearsOfHavingAccount > Constants.MaxDiscountForLoyalty) ?
              (decimal)Constants.MaxDiscountForLoyalty / 100 : (decimal)YearsOfHavingAccount / 100;
            return price - (discountForAccountAge * price);
        }
    }
}
