using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring
{
    public interface IAccountDiscountCalculatorFactory
    {
        IAccountDiscountCalculator GetAccountDiscountCalculator(AccountType type);

    }
    public interface IAccountDiscountCalculator
    {
       decimal CalculateCost(decimal price );
    }
    class DefaultAccountDiscountCalculatorFactory : IAccountDiscountCalculatorFactory
    {
        public IAccountDiscountCalculator GetAccountDiscountCalculator(AccountType type)
        {
            IAccountDiscountCalculator calculator;
            switch (type)
            {
                case AccountType.NotRegistered:
                    calculator = new NotRegisteredDiscountCalculator();
                    break;
                case AccountType.SimpleCustomer:
                    calculator = new SimpleCustomerCalculator();
                    break;
                case AccountType.MostValuableCustomer:
                    calculator = new MostValuableCalculator();
                    break;
                case AccountType.ValuableCustomer:
                    calculator = new ValuableCalculator();
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }
            return calculator;
        }
    }
}
