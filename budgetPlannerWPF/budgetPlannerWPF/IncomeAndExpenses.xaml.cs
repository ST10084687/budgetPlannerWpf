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
    /// Interaction logic for IncomeAndExpenses.xaml
    /// </summary>
    public partial class IncomeAndExpenses : Window
    {
        //created object to get the variables
        HomeLoan loan = new HomeLoan();

        public IncomeAndExpenses()
        {
            InitializeComponent();
        }
        //method for button 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           BuyHouse buyHouse = new BuyHouse();
            buyHouse.Show();
            this.Close();
        }
        //method for button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Rent rent = new Rent();
            rent.Show();
            this.Close();
        }
        //method for button
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your information has been entered");
            //try and catch used for eception handling
            try
            {
                //stores the varoiables 
                loan.GrossMonthlyIncome = double.Parse(grossIncomeTb.Text);
            }
            catch (Exception)
            {
                //error message 
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                //used to clear the textbox
                grossIncomeTb.Clear();
                //changes the background color of the textbox 
                grossIncomeTb.Background = Brushes.Gold;

            }
            try
            {
                loan.Expenses.Add(double.Parse(taxTB.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                taxTB.Clear();
                taxTB.Background = Brushes.Gold;

            }
            try
            {
                loan.Expenses.Add(double.Parse(otherTB.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                otherTB.Clear();
                otherTB.Background = Brushes.Gold;

            }
            try
            {
                loan.Expenses.Add(double.Parse(travelTB.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                travelTB.Clear();
                travelTB.Background = Brushes.Gold;

            }
            try
            {
                loan.Expenses.Add(double.Parse(cellTB.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                cellTB.Clear();
                cellTB.Background = Brushes.Gold;

            }
            try
            {
                loan.Expenses.Add(double.Parse(waterTB.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                waterTB.Clear();
                waterTB.Background = Brushes.Gold;

            }
            try
            {
                loan.Expenses.Add(double.Parse(groceriesTB.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                groceriesTB.Clear();
                groceriesTB.Background = Brushes.Gold;

            }
            
        }

        private void taxTB_TextChanged()
        {

        }
    }
}
