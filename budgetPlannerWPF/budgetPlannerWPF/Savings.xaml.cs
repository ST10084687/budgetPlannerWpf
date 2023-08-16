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
    /// Interaction logic for Savings.xaml
    /// </summary>
    public partial class Savings : Window
    {
        public Savings()
        {
            InitializeComponent();
        }
        //created object to access the variables 
        SavingsCalculations calculations = new SavingsCalculations();

        //button method created 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            MessageBox.Show("Your information has been entered");
           
            //try and catch used for exception handling 
            try
            {
                //stores the variable 
                calculations.UserAmountToSave = double.Parse(userAmountTB.Text);
            }
            catch (Exception)
            {
                //error message 
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                //clears thhe screen
                userAmountTB.Clear();
                //changes the background color of the textbox
                userAmountTB.Background = Brushes.Gold;

            }
            try
            {
                calculations.InterestRate = double.Parse(interestTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                interestTB.Clear();
                interestTB.Background = Brushes.Gold;

            }
            try
            {
                calculations.MonthsToPay = double.Parse(monthsTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                monthsTB.Clear();
                monthsTB.Background = Brushes.Gold;

            }

            calculations.SavingReason = userReasonTB.Text;

            Expenses expenses = new Expenses();
            expenses.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your information has been entered");

            try
            {
                calculations.UserAmountToSave = double.Parse(userAmountTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                userAmountTB.Clear();
                userAmountTB.Background = Brushes.Gold;

            }
            try
            {
                calculations.InterestRate = double.Parse(interestTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                interestTB.Clear();
                interestTB.Background = Brushes.Gold;

            }
            try
            {
                calculations.MonthsToPay = double.Parse(monthsTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                monthsTB.Clear();
                monthsTB.Background = Brushes.Gold;

            }

            calculations.SavingReason = userReasonTB.Text;
        
            CarPage carPage = new CarPage();
            carPage.Show();
            this.Close();
        }
    }
}
