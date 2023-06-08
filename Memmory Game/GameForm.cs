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
    public partial class GameForm : Form
    {
        public GameProps props_ { get; set; }
        public int count { get; set; }
        public int showtime { get; set; }
        public int defaultTiles { get; set; }
        public int defaultLives { get; set; }
        public GameForm(GameProps propss)
        {
            InitializeComponent();
            props_ = propss;

            Playerlab.Text = props_.Name_; //displaying the name of the user in the second form


            flowLayoutPanel1.Width = 120 * props_.BoardSize + props_.BoardSize * 20; //setting the layout of the flowLayoutPanel
            flowLayoutPanel1.Height = 120 * props_.BoardSize + props_.BoardSize * 20;
            this.Width = panel1.Width + flowLayoutPanel1.Width; //adjusting the size of the form according to the flowLayoutPanel size
            this.Height = flowLayoutPanel1.Height + props_.BoardSize * 10;
            panel1.Height = flowLayoutPanel1.Height;
            for (int i = 0; i < props_.BoardSize * props_.BoardSize; i++) //adding the labels to the 2nd form according to the users selection
            {
                Label l = addlabel(props_.BoardSize);
                flowLayoutPanel1.Controls.Add(l);
            }
            label5.Text = "";


            defaultTiles = props_.NumberTiles;
            defaultLives = props_.NumberLives;

            tileslab.Text = props_.NumberTiles.ToString();//displaying the lives and tiles left when the second form opens
            liveslab.Text = props_.NumberLives.ToString();
        }

        Label addlabel(int i)
        {
            //designing the label

            Label label = new Label();
            label.ForeColor = Color.Blue;
            label.BackColor = Color.Blue;
            label.Font = new Font("Calibri", 35, FontStyle.Italic);//setting the font style and font size of the text in the label
            label.Width = 120;
            label.Height = 120;
            label.Margin = new Padding(5);


            return label;
        }

        private List<int> RandomInt()
        {

            List<int> random_list = new List<int>();
            while (true)
            {
                if (random_list.Count >= props_.BoardSize * props_.BoardSize) //checks if number of generated numbers is equal to or greater than the total number of tiles
                {
                    break;
                }
                else
                {
                    Random random = new Random();
                    int uniquenumber = random.Next(1, props_.BoardSize * props_.BoardSize + 1); //generating random number between 1 and the total number of tiles in the game
                    if (!random_list.Contains(uniquenumber))
                    {
                        random_list.Add(uniquenumber);
                    }
                }
            }
            return random_list;
        }
        private void SetLabel() //assigning random numbers to the labels
        {
            List<int> randomlist = RandomInt();
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {

                flowLayoutPanel1.Controls[i].Text = randomlist[i].ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false; //not being able to click the labels and play before starting the game
            showtime = props_.ShowingTime * 3;
            timer1.Start();
            props_.NumberTiles = defaultTiles;
            props_.NumberLives = defaultLives;
            tileslab.Text = props_.NumberTiles.ToString();
            liveslab.Text = props_.NumberLives.ToString();
            count = 1;
            timer2_RunTime = 0; // Reset the running time of timer2
            timer2.Start(); //starting the timer 2 once the user clicks start
            SetLabel();

            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++) //iterating through the labels in the panel
            {
                Control c = flowLayoutPanel1.Controls[i];
                c.Click += label_Click;

                if (Convert.ToInt32(c.Text) <= defaultTiles)
                {
                    c.ForeColor = Color.Black;
                }
            }

        }


        private void label_Click(object sender, EventArgs e)
        {

            Label clickLabel = sender as Label;
            if (clickLabel.Text == count.ToString())
            {
                clickLabel.BackColor = Color.Green; //setting the label background color to green once the user clicks the correct label

                --props_.NumberTiles; //decreasing the number of tiles displayed once the user clicks the correct label
                tileslab.Text = props_.NumberTiles.ToString();
                ++count;
            }
            else
            {
                --props_.NumberLives; //decreasing the number of lives remaining if the user clicks the wrong label

                liveslab.Text = props_.NumberLives.ToString();

                clickLabel.BackColor = Color.Red; //displaying red color when the user makes a mistake in the labels
                clickLabel.ForeColor = Color.Red;

            }

            if (props_.NumberLives == 0) //displaying game over message when the user loses the game
            {
                MessageBox.Show("Game Over:(");
                GameOver();
            }
            if (props_.NumberTiles == 0)
            { 
                
                MessageBox.Show($"You won the game in {label5.Text} seconds!!"); //displaying message when the user wins the game
                GameOver();
            }

        }
        private void GameOver()
        {

            foreach (Control c in flowLayoutPanel1.Controls)
            {


                c.ForeColor = Color.Blue; //setting the color of the labels
                c.BackColor = Color.Blue;
                c.Click -= label_Click;

            }
            tileslab.Text = props_.NumberTiles.ToString(); //updating the lives left and tiles left when user restarts the game
            liveslab.Text = props_.NumberLives.ToString();
            button1.Enabled = true;
            timer2.Stop(); //stopping the timer once the game is over
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//going back to menu
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //event handling for the first timer
            showtime--;
            if (showtime < 0)
            {
                timer1.Stop();
                foreach (Control c in flowLayoutPanel1.Controls)
                {


                    c.ForeColor = Color.Blue;

                }
                timer2.Start();

            }
        }
        private int timer2_RunTime = 0; //setting initial value of the timer to 0


        private void timer2_Tick(object sender, EventArgs e)
        {

            timer2_RunTime++;
            label5.Text = timer2_RunTime.ToString(); //displaying the time in label 5 once the game begins


        }
    }
}
