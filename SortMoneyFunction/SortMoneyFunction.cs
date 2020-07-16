using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortMoneyFunction
{
    public partial class SortMoneyFunction : Form
    {
        public SortMoneyFunction()
        {
            InitializeComponent();
        }

        private void SortMoneyBTN_Click(object sender, EventArgs e) 
        {

            int money1 = 0; // sort money
            int money2 = 0; // left over money

            // get total amount of money
            int totalMoney = Convert.ToInt32(textBox8.Text);

           
            Remainder(totalMoney, 100, out money1, out money2); //sort the money
            textBox1.Text = money1.ToString();  // display sorted money
            totalMoney = money2; // reduce the total amount of money

            Remainder(totalMoney, 50, out money1, out money2); //sort the money
            textBox2.Text = money1.ToString(); // display sorted money
            totalMoney = money2;   // reduce the total amount of money

            Remainder(totalMoney, 20, out money1, out money2);//sort the money
            textBox3.Text = money1.ToString(); // display sorted money
            totalMoney = money2; // reduce the total amount of money

            Remainder(totalMoney, 10, out money1, out money2); //sort the money
            textBox4.Text = money1.ToString(); // display sorted money
            totalMoney = money2; // reduce the total amount of money

            Remainder(totalMoney, 5, out money1, out money2); //sort the money
            textBox5.Text = money1.ToString(); // display sorted money
            totalMoney = money2; // reduce the total amount of money

            Remainder(totalMoney, 2, out money1, out money2); //sort the money
            textBox6.Text = money1.ToString(); // display sorted money
            totalMoney = money2; // reduce the total amount of money

            Remainder(totalMoney, 1, out money1, out money2); //sort the money
            textBox7.Text = money1.ToString(); // display sorted money

        }

        // a function that returns two values.
        public static void Remainder( int money, int size, out int money1, out int money2) {
            // sort the money and work out how much of the total amount of the money is left
            money1 = money / size;
            money2 = money - (money1 * size);
        }
    }
}
