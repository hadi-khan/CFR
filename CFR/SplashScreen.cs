﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFR
{
    public partial class SplashScreen : Form
    {
        //Use timer class
        Timer tmr;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();

            //set time interval 5 sec
            tmr.Interval = 5000;

            //starts the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)

        {

            //after 3 sec stop the timer
            tmr.Stop();

            //display mainform
            Form1 mf = new Form1();
            mf.Show();

            //hide this form
            this.Hide();

        }
    }
}