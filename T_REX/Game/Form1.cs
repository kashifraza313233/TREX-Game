using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        
        bool jump = false; // bool is used to check dino is jumping 
        int score = 0; //default score is 0
        int barrierspeed = 10;// set the default speed of barriers 
        int jumpspeed; /// set the default speed of runner 
        int force = 12; // default value of force for jump
        int position;
        bool GameOver = false;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            resetGame();/// restart game function
        }

        

        private void keydown(object sender, KeyEventArgs e)
        {

        }

        private void keyup(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void resetGame()
        {
            force = 12;
            jump = false;
            jumpspeed = 0;
            score = 0;
            barrierspeed = 10;
            Scoretext.Text = "Score" + score;
            trex.Image = Properties.Resources.dino;
            GameOver = false;
            trex.Top = 303;
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Barriers")
                {

                }
            }

        }

        
    }
}
