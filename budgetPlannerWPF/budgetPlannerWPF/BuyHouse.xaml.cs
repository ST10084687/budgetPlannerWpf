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
    /// Interaction logic for BuyHouse.xaml
    /// </summary>
    public partial class BuyHouse : Window
    {
        
        public BuyHouse()
        {
            InitializeComponent();
        }
        //created object for homeloan so variables can be called 
        HomeLoan loan = new HomeLoan();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //boolean used to continue to the next screen if its true 
            Boolean buyHouse = true;

            MessageBox.Show("Your information has been entered");

            //try and catch used for exception handling
            try
            {
                //calls variables from homeloan class
                loan.Price = double.Parse(purchaseTB.Text);
            }

            catch (Exception)
            {
                //error message
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                //clears the textbox
                purchaseTB.Clear();
                //chanfges textbox color
                purchaseTB.Background = Brushes.Gold;

            }
            try
            {
                loan.Deposit = double.Parse(depositTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                depositTB.Clear();
                depositTB.Background = Brushes.Gold;

            }
            try
            {
                loan.InterestRate = double.Parse(interestTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                interestTB.Clear();
                interestTB.Background = Brushes.Gold;

            }
            try
            {
                loan.MonthsToPay = double.Parse(monthsTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                monthsTB.Clear();
                monthsTB.Background = Brushes.Gold;

            }
            if ((loan.remainingIncome() / 3) < loan.houseMonthlyPayment())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                MessageBox.Show("ALERT!!! >>> THE APPROVAL OF THE LOAN IS UNLIKELY");
                Console.ForegroundColor = ConsoleColor.White;

                purchaseTB.Clear();
                depositTB.Clear();
                interestTB.Clear();
                monthsTB.Clear();

                buyHouse = false;

            }
            //if statement to go to the next screen 
            if (buyHouse == true)
            {
                chooseCar chooseCar = new chooseCar();
                chooseCar.Show();
                this.Close();
            }
        }
    }
}
