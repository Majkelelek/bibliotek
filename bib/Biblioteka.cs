﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bib
{
    public partial class Biblioteka : Form
    {
        public Biblioteka()
        {
            InitializeComponent();
            
            
        }

        public Login l;

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            l.Show();
            this.Hide();
        }

        
    }
}
