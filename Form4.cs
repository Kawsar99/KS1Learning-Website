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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        } // This button will allow the user to go back to the previous page

        private void Forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        } // This button will allow the user to go forward to the next page

        private void Go_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(URL.Text))
             webBrowser1.Navigate(URL.Text);

        } // This button will allow the user to be able to submit the search 

        private void URL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                webBrowser1.Navigate(URL.Text);
        } // This button will allow the user to be able to search

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Menu = new Form1();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
            /* This code is for the 'Back to Menu' button which
            closes the Browser Form and goes back to the Menu Form.*/
        }

        private void NewRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }   /* This is for the refresh button which gives you the most updated verison
               of the page your viewing. */

    }
    }
    
