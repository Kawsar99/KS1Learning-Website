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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Calculator_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form2 = new Form2();
            Form2.Closed += (s, args) => this.Close();
            Form2.Show();
            /* This closes the Menu form and opens up the calculator form
              when the Calcultor button is clicked on */
        }

        private void Writing_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form3 = new Form3();
            Form3.Closed += (s, args) => this.Close();
            Form3.Show();
            /* When the Writing button is selected it closes the Menu
               and opens up the Writing form*/
        }

      
        private void Browser_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form4 = new Form4();
            Form4.Closed += (s, args) => this.Close();
            Form4.Show();
     // The code above closes the Menu form and opens the Browser when the button is selected

        }

       

           
    }
    }