using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memmory_Game
{
    public partial class Form1 : Form
    {
        public GameProps props_ { get; set; }
        public Form1()
        { //adding the information to the panel
            InitializeComponent();
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(numericUpDown4);
            panel1.Controls.Add(numericUpDown3);
            panel1.Controls.Add(numericUpDown1);
            props_ = new GameProps();

            // Not allowing the user to change the data in easy, medium, and hard difficulty options
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;

        }




        private void startbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("please enter your name");
            }

            // Making sure user enters information in all the controls

            else if (comboBox1.Text == "") // Check if no difficulty is selected
            {
                MessageBox.Show("Please select a difficulty");
            }
            else if (numericUpDown1.Value == 0) // Checking if number tiles are not selected
            {
                MessageBox.Show("board size cannot be empty");
            }
            else if (numericUpDown2.Value == 0) // Checking if board size is not selected
            {
                MessageBox.Show("number of lives cannot be empty");
            }
            else if (numericUpDown3.Value == 0) // Checking if showing time is not selected
            {
                MessageBox.Show("Showing time cannot be empty");
            }
            else if (numericUpDown4.Value == 0) // Checking if number of lives is not selected
            {
                MessageBox.Show("Number of tiles cannot be empty");
            }
            else if (numericUpDown1.Value < numericUpDown4.Value)
            {
                MessageBox.Show("Number Tiles cannot be greater than BoardSize.");  // BONUS POINT
            }
            else
            {
                props_.BoardSize = (int)numericUpDown1.Value;
                props_.NumberLives = (int)numericUpDown2.Value;
                props_.ShowingTime = (int)numericUpDown3.Value;
                props_.NumberTiles = (int)numericUpDown4.Value;
                props_.Name_ = textBox1.Text;

                GameForm game = new GameForm(props_);
                game.ShowDialog();
            }


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { //setting the values in the textboxes according to the users choice
            if (comboBox1.Text == "Easy")
            {
                numericUpDown1.Value = 3;
                numericUpDown2.Value = 5;
                numericUpDown3.Value = 5;
                numericUpDown4.Value = 3;
            }
            else if (comboBox1.Text == "Medium")
            {
                numericUpDown1.Value = 4;
                numericUpDown2.Value = 4;
                numericUpDown3.Value = 4;
                numericUpDown4.Value = 4;
            }
            else if (comboBox1.Text == "Hard")
            {
                numericUpDown1.Value = 5;
                numericUpDown2.Value = 3;
                numericUpDown3.Value = 3;
                numericUpDown4.Value = 5;
            }
            else
            {
                // Enabling the user to customize the board size, number of lives, showing time, and number of tiles.
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = true;

                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
                numericUpDown4.Value = 0;
            }

        }


    }
}
