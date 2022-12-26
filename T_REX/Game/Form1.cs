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
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
