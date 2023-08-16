using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetPlannerWPF
{
    class carLoan : Expense
    {
        public double totalCarMonthlyCost()
        {
            // calculates the amountt due
            InitialAmount = price - deposit;
            // converts interest rate
            interestRate = interestRate / 100;
            //A=P(1+(I*N))
            CarCost = InitialAmount * (1 + (interestRate * 5));
            // Car cost in months
            monthlyRepayments = CarCost / 60;
            // adds insurance premium to the cost
            monthlyRepayments += estimatedInsurancePremium;

            return monthlyRepayments;
        }
    }
}
