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
    /// Interaction logic for chooseCar.xaml
    /// </summary>
    public partial class chooseCar : Window
    {
        public chooseCar()
        {
            InitializeComponent();
            //created object so variables can be called 
            HomeLoan homeLoan = new HomeLoan();

            //if or else statements for whjat statements should be displayed
                if (homeLoan.RentCosts > 0)
            {
                //variable message outputr if rent is greater than 0
                carTextBlock.Text = "Monthly Rent Payment: " + homeLoan.RentCosts;
                carTextBlock.Text = "Monthly Income Balance: " + homeLoan.rentDeductions();

            }
            //if or else statements for whjat statements should be displayed
            else if (homeLoan.houseMonthlyPayment() > 0)
            {
                //variable message outputr if rent is greater than 0
                carTextBlock.Text = "Monthly Home Loan Repayment: " + homeLoan.houseMonthlyPayment();
                carTextBlock.Text = "Monthly Income Balance: " + homeLoan.homeLoanIncomeDeductions();
            }
            carTextBlock.Text = "Monthly Income Before House Deductions: " + homeLoan.remainingIncome();
        }

        //button method to get to the next page
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CarPage carPage = new CarPage();
            carPage.Show();
            this.Close();
        }
        //button method to get to the next page
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Savings savings = new Savings();
            savings.Show();
            this.Close();
        }
        //button method to get to the next page
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.Show();
            this.Close();
        }
    }
}
