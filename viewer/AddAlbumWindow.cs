﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewer
{
    public partial class AddAlbum : Form
    {
        public AddAlbum()
        {
            InitializeComponent();
            but_ok.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KO_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0)
            {
                but_ok.Enabled = true;
            }
            else
            {
                but_ok.Enabled = false;
            }
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            //creer album avec constructeur different enfonction de ce qui a été rempli
            Album alb = new Album(textBox1.Text.ToString());

            if (textBox2.Text.Trim().Length > 0) 
            {
                alb.SubTitle = textBox2.Text.ToString();
            }
            if (textBox3.Text.Trim().Length > 0)
            {
                alb.Date = textBox3.Text.ToString();
            }

            Album.Albums.Add(alb);
        }
    }
}
