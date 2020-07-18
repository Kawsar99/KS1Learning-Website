using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; /* In order to use the open or save button we need to 
                    include the system input and output without it
                    the buttons won't work */
namespace App
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creating the open file dialogue
            OpenFileDialog open = new OpenFileDialog();


            open.Title = "Open File"; /* This will change the name from open to open file
                                         when selecting a file at the top of the screen*/

            open.Filter = "Text Files (*.txt)|*.txt"; /*Now, the only thing that can be opened and seen 
                                                        when opening a file are text files*/
                
         

            if (open.ShowDialog() == DialogResult.OK)
            { //This will check and make sure they hit the ok button after selecting a file
              // if it's true the system will execute the code if it's not true it won't execute the code.


                StreamReader read = new StreamReader(File.OpenRead(open.FileName));
                //The OpenRead function will allow us to see whatever file you open and the file


                txtArea.Text = read.ReadToEnd(); 
                //ReadToEnd will always read the entire binary text behind the scene inside the file

                read.Dispose();
                /*This code will destory the streamreader because if the user tries clicking
                 * the button twice they will get an error so we have to dispose of read. 
                 * This will make sure the when the code is excuted. */
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save File";
            save.Filter = "Text Files (*.txt)|*.txt";
            // Will save the passage of text as text file (txt file)

            if (save.ShowDialog() == DialogResult.OK) {

                //This will check and make sure they hit the ok button after selecting a file
                // if it's true the system will execute the code if it's not true it won't execute the code.

                StreamWriter write = new StreamWriter(File.Create(save.FileName));

                write.Write(txtArea.Text);
                write.Dispose();
                   //Creating a file and the user can name the file to save it    
            }
        }

        private void button3_Click(object sender, EventArgs e)

        {
            DialogResult fontResult = fontDialog1.ShowDialog();
            if (fontResult == DialogResult.OK)
            {
                txtArea.Font = fontDialog1.Font;
            } // This is for the font button allows to change font style and size
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult colorResult = colorDialog1.ShowDialog();
            if (colorResult == DialogResult.OK)
            {
                txtArea.ForeColor = colorDialog1.Color;
                // This is for the font colour button changes font colour
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult colorResult = colorDialog2.ShowDialog();
            if (colorResult == DialogResult.OK)
            {
                txtArea.BackColor = colorDialog2.Color;
            }
        }  // This is the background button which changes the passage entry colour 

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Menu = new Form1();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
            /* This code is for the Back to Menu button which
             closes the Writing Form and goes back to the Menu Form.*/ 
        }




    }
    }
