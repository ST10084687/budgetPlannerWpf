using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetPlannerWPF
{
    class SavingsCalculations : Expense
    {
       public double savings()
        {
            //calculation to get the monthly repayments
            interestRate = interestRate / 100;
            monthlyRepayments = userAmountToSave / monthsToPay / interestRate;
            
            return monthlyRepayments;
        }
    }
}
