﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavedenie_Milen
{
    public partial class poruchka : Form
    {
        public poruchka()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         Form1 form1 = new Form1();
            poruchka ceni= new poruchka();
            ceni.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
