﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if(this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form frm=Form as Form;
            frm.TopLevel = false;
            frm.Dock= DockStyle.Fill;   
            this.mainpanel.Controls.Add(frm);
            this.mainpanel.Tag = frm;
            frm.Show();

        }

        private void Play_Click(object sender, EventArgs e)
        {
            Form2 f2 =new Form2();
            f2.Hide();
            TRexForm1 f1 = new TRexForm1();
            f1.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}