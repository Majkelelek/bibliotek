using System;
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
    public partial class admin : Form
    {
        public string nazwastudenta { get; set; }
        public admin()
        {
            InitializeComponent();
        }
        public Login lo;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Zalogowano jako: " + nazwastudenta;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            lo = new Login();
            lo.Show();
            this.Hide();
        }
    }
    
}
