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
    public partial class Biblioteka : Form
    {
        
        public Login l;
        
        public string nazwastudenta { get ; set; } 
        
        public Biblioteka()
        {
            InitializeComponent();
             
           
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            Login l = new Login();
            l.Show();
            this.Hide();
            
        }

        private void Biblioteka_Load(object sender, EventArgs e)
        {
            label1.Text = "Zalogowano jako: "+ nazwastudenta;
        }
        
    }
}
