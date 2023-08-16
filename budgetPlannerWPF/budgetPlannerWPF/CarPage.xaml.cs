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
    /// Interaction logic for CarPage.xaml
    /// </summary>
    public partial class CarPage : Window
    {
        public CarPage()
        {
            InitializeComponent();
        }
        //created object so variables can be called
        carLoan car = new carLoan();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //boolean to see if its true
            Boolean buyCar = true;

            MessageBox.Show("Your information has been entered");

            //try and catch for exception handling
            try
            {
                //ghets the variable
                car.ModelAndMake = makeTb.Text;
            }
            catch (Exception)
            {
                //error message
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                //clears the textbox
                makeTb.Clear();
                //changes textbox background color
                makeTb.Background = Brushes.Gold;

            }
            try
            {
                car.Price = double.Parse(purchaseTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                purchaseTB.Clear();
                purchaseTB.Background = Brushes.Gold;

            }
            try
            {
                car.InterestRate = double.Parse(interestTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                interestTB.Clear();
                interestTB.Background = Brushes.Gold;

            }
            try
            {
                car.EstimatedInsurancePremium = double.Parse(insuranceTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                insuranceTB.Clear();
                insuranceTB.Background = Brushes.Gold;

            }
            //if statement to change it to the next screen
            if (buyCar == true)
            {

                Expenses expenses = new Expenses();
                expenses.Show();
                this.Close();
            }
        }
    }
}
