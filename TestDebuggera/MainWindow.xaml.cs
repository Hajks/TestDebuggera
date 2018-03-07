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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace TestDebuggera
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //Testing how operators work and how variable change while program is working(By using debugger)
            //

            int number = 15;        //Starting from variable which is equal 15
            number = number + 10;   //Adding 10 by using operator "+", current value should be equal 25
            number = 36 * 15;       //Multiply by 36 using operator "*", current value should be equal 540
            number = 12 - (42 / 7); //Using operators minus("-") and divide("/"), current value should be equal 6
            number += 10; // Variable number is increased by 10, current value should be equal 16
            number *= 3;  // Variable number is multiplied by 3, current value 48
            number = 71 / 3; // Using operator ("/"), current value should be around 23.666666, but because we used variable int instead of float/double current value is cut off to 23.

            int count = 0; //New variable which is equal 0
            count++; // Variable increased by 1. Used operator "++"
            count--; // Variable reduced by 1. Used operator "--"

            string result = "cześć"; // Variable string which is used to keep string of characters.
            result += " i znowu " + result; // Increasing variable by "i znowu " + result", final message should look like "cześć i znowu cześć"
            output.Text = result; //After clicking button our textblock should display variable result
            result = "wartość wynosi: " + count; //Variable result currently looks like "wartość wynosi: 0";
            result = " "; //Cleaning variable result

            bool yesNo = false; //New variable bool yesNo which can return only true or false value, currently set to false
            bool anotherBool = true; // Like above but variable set to true
            yesNo = !anotherBool; // Used operator "!" which change true to false and vice versa. 
        }
    }
}
