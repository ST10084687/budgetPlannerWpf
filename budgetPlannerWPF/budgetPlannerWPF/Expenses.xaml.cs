using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace budgetPlannerWPF
{
    /// <summary>
    /// Interaction logic for Expenses.xaml
    /// </summary>
    public partial class Expenses : Window
    {
        HomeLoan loan = new HomeLoan();
        carLoan car = new carLoan();
        SavingsCalculations calculations = new SavingsCalculations();
        public delegate string expenseExceedingDelegate(string Notification);

        double finalAmount;
        public Expenses()
        {
            InitializeComponent();


            //if or else statements for whjat statements should be displayed
            if (loan.RentCosts > 0)
            {
                //variable message outputr if rent is greater than 0
                displayExpensesTextBlock.Text = "Monthly Rent Payment: " + loan.RentCosts;
                displayExpensesTextBlock.Text = "Monthly Rent Payment: " + loan.rentDeductions();

            }
            //if or else statements for whjat statements should be displayed
            else if (loan.houseMonthlyPayment() > 0)
            {
                //variable message outputr if rent is greater than 0
                displayExpensesTextBlock.Text = "Monthly Home Loan Payment: " + loan.houseMonthlyPayment();
                //displayExpensesTextBlock.Text = loan.homeLoanIncomeDeductions();
            }
            //if or else statements for whjat statements should be displayed
            if (car.totalCarMonthlyCost() > 0)
            {
                //variable message outputr if rent is greater than 0
                displayExpensesTextBlock.Text = "Monthly car payment for: " + car.ModelAndMake + "is: " + car.totalCarMonthlyCost();
                displayExpensesTextBlock.Text = car.totalCarMonthlyCost().ToString("A");
            }
            //if or else statements for whjat statements should be displayed
            if (calculations.savings() > 0)
            {
                //variable message outputr if rent is greater than 0
                displayExpensesTextBlock.Text = "Reason for savings: " + calculations.SavingReason;
                displayExpensesTextBlock.Text = "Savings: " + calculations.savings();
                displayExpensesTextBlock.Text = calculations.savings().ToString("A");
            }
            finalAmount = loan.rentDeductions() - car.totalCarMonthlyCost() - calculations.savings();
            displayExpensesTextBlock.Text = "Gross Monthly Income: " + finalAmount.ToString("A");
            //displayExpensesTextBlock.Text = loan.Expenses.Sum().ToString("A");
        }
        //method to get the delegate
        static void delegateMethod()
        {
            expenseExceedingDelegate abcd = (Notificaton) => { return Notificaton; };
            MessageBox.Show(abcd("YOU HAVE USED MORE THAN 75% OF YOUR EARNINGS"));
        } 
        //method for the button to get to the next page 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (finalAmount <= 0.75 * loan.GrossMonthlyIncome)
            { delegateMethod(); }
            this.Close();
        }

    }
}
