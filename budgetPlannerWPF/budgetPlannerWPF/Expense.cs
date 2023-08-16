using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetPlannerWPF
{
    public abstract class Expense
    {

        // variables used in the calculations and to store information

        //used to store the price
        public static double price; 
        // used to store the deposit
        public static double deposit; 
        //used to store interest rate
        public static double interestRate; 
        //used to store months
        public static double monthsToPay; 
        //used to store monthly repayments
        public static double monthlyRepayments; 

        public static double totalAmount; 

        public static double grossMonthlyIncome; 

        public static double monthlyTaxDeducted;
        //array used top store expenses
        public static List<double> expenses = new List<double>(); 

        public static double rentCosts;

        public static double availableMonthlyMoney;

        public static string modelAndMake;

        public static double carCost;

        public static double estimatedInsurancePremium; 

        public static double initialAmount;

        public static string savingReason; 

        public static double userAmountToSave;
        
        public static double housePrice;

        public static double years;

        //gets and sets for the variables 
        public double Years { get => years; set => years = value; }
        public double Price { get => price; set => price = value; }
        public double Deposit { get => deposit; set => deposit = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        public double MonthsToPay { get => monthsToPay; set => monthsToPay = value; }
        public double HomeLoanRepayments { get => monthlyRepayments; set => monthlyRepayments = value; }
        public double TotalAmount { get => totalAmount; set => totalAmount = value; }
        public double GrossMonthlyIncome { get => grossMonthlyIncome; set => grossMonthlyIncome = value; }
        public double MonthlyTaxDeducted { get => monthlyTaxDeducted; set => monthlyTaxDeducted = value; }
        public List<double> Expenses { get => expenses; set => expenses = value; }
        public double RentCosts { get => rentCosts; set => rentCosts = value; }
        public double AvailableMonthlyMoney { get => availableMonthlyMoney; set => availableMonthlyMoney = value; }
        public string ModelAndMake { get => modelAndMake; set => modelAndMake = value; }
        
        public double EstimatedInsurancePremium { get => estimatedInsurancePremium; set => estimatedInsurancePremium = value; }
        
        public string SavingReason { get => savingReason; set => savingReason = value; }
        public double UserAmountToSave { get => userAmountToSave; set => userAmountToSave = value; }
        public double InitialAmount { get => initialAmount; set => initialAmount = value; }
        public double CarCost { get => carCost; set => carCost = value; }
        public double HousePrice { get => housePrice; set => housePrice = value; }
    }
}
