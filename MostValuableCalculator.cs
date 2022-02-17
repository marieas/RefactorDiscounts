using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring
{
    public class MostValuableCalculator : IAccountDiscountCalculator
    {
        public decimal CalculateCost(decimal price)
        {
            return price - Constants.MostValuableDiscount * price;
        }
    }
}
