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
    /// Interaction logic for Rent.xaml
    /// </summary>
    public partial class Rent : Window
    {
        public Rent()
        {
            InitializeComponent();
        }
        //object used to get the variables 
        HomeLoan loan = new HomeLoan();
        //method created for button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your information has been entered");
            //try and catch used for exception handling 
            try
            {
                //stores the variable
                loan.RentCosts = double.Parse(rentTB.Text);
            }
            catch (Exception)
            {
                //error message 
                MessageBox.Show("ERROR!!!, REFER TO THE GOLD TEXTBOX AND ENTER A CORRECT VALUE");
                //clears the textbox
                rentTB.Clear();
                //changes the background color of the textbox 
                rentTB.Background = Brushes.Gold;

            }
            //changes the screen 
            chooseCar car = new chooseCar();
            car.Show();
            this.Close();
        }
    }
}
