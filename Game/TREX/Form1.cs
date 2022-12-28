using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TREX
{
    public partial class TRexForm1 : Form
    {
        bool jump = false; // bool is used to check dino is jumping 
        int score = 0; //default score is 0
        int barrierspeed = 10;// set the default speed of barriers 
        int jumpspeed; /// set the default speed of runner 
        int force = 12; // default value of force for jump
        int position;
        bool GameOver = false;
        Random random = new Random();
        public TRexForm1()
        {
            InitializeComponent();
            GameRestart();
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            /// if jump is equal to false then player will press space button player move up 
            // and jump is true
            if (e.KeyCode == Keys.Space && jump == false)
            {
                jump = true;
            }
        }

        private void keyup(object sender, KeyEventArgs e)
        {
            //if jump bool is true after thah jump will be false when player release space button
            if (jump == true)
            {
                jump = false;
            }
            // Here when player touch the hardles game will over and by pressing Enter button
            // player can restart the game 
            if (e.KeyCode == Keys.Enter && GameOver == true)
            {
                GameRestart();
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            trex.Top += jumpspeed;
            Scoretext.Text = "Score: " + score;
            if (jump == true && force < 0)
            {
                jump = false;
            }
            if (jump == true)
            {
                jumpspeed = -12;
                force -= 1;

            }
            else
            {
                jumpspeed = 12;
            }
            if (trex.Top > 414 && jump == false)
            {
                force = 12;
                trex.Top = 415;
                jumpspeed = 0;

            }
            foreach (Control x in Controls)
            {
                
                if (x is PictureBox && (string)x.Tag =="Barriers")
                {
                    x.Left -= barrierspeed;
                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width+random.Next(200,500)+(x.Width*15);
                        score++;
                    }
                    if (trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        //when runner touch hardles game will stop and player will dead
                        GameEvent.Stop();
                        trex.Image = Properties.Resources.dead;
                        Scoretext.Text+= "";    // Here Score will show 
                        Hiscoretext.Text = "High Score="+score; // here High Score of the player will show 
                        MessageBox.Show("Press Enter To Restart the Game!");
                        GameOver = true;// when player press space button Game will restart 

                    }
                }
               
            }
        }
        /// <summary>
        /// this function will restart the game 
        /// </summary>
        private void GameRestart()
        {
            force = 12;
            jump = false;
            jumpspeed = 0;
            score = 0;
            barrierspeed = 10;
            Scoretext.Text = "Score: " + score;
            trex.Image = Properties.Resources.running;
            GameOver = false;
            trex.Top = 415;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Barriers")
                {
                    position = this.ClientSize.Width + random.Next(10, 100) + (x.Width * 10);
                    x.Left = position;
                }
            }
            GameEvent.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
