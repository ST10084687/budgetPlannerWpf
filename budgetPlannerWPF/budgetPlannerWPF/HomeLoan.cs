using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetPlannerWPF
{
    public class HomeLoan : Expense
    {
        
        public double houseMonthlyPayment()
        {
            totalAmount = price - deposit;
            interestRate = interestRate / 100;
            Years = monthsToPay / 12;

            //full calculation using formula
            housePrice = totalAmount * (1 + (interestRate * monthsToPay));

            //monthly repayments calculation
            monthlyRepayments = housePrice / monthsToPay;
            //rounds off to 2 decimals
            monthlyRepayments = Math.Round(monthlyRepayments, 2);




            return monthlyRepayments;
        }
        //method for calculation
        public double remainingIncome()
        {
            return grossMonthlyIncome - expenses.Sum();
        }
        //method for calculation
        public double rentDeductions()
        {
            return remainingIncome() - rentCosts;
        }
        //method for calculation
        public double homeLoanIncomeDeductions()
        {
            return remainingIncome() - houseMonthlyPayment();
        }
    }
}
