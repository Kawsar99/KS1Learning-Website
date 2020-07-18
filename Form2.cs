using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form2 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        // Variables for operations
        public Form2()
        {
            InitializeComponent();

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            // This clears the annoying zero before the input and it allows you to still input zeros

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;

            // Buttons 1,2,3,4,5,6,7,8,9,0,dot(.) are assigned same event handler.

         
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            // Buttons(+, -, *,/) are assigned to another same event handler.
        }

        private void equals_click(object sender, EventArgs e)
        {
            switch (operation)
            {
                /* Switch statment is being used so when the equal button is pressed it
           gives the result for each artimetic operator used. */

                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            } // end of switch
            operation_pressed = false;

        }


        private void Clear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        } // This is for the Clear button which just clears the numbers inputted



        private void BacktoMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Menu = new Form1();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
            /* This code is for the 'Back to Menu' button which
            closes the Calculator Form and goes back to the Menu Form.*/
        }

    }
}