namespace bib
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
            a = new admin();
            b = new Biblioteka();
            b1 = new Biblioteka2();
            b.l = this;
            
           
            b.Closed += (s, args) => this.Close();
            b1.Closed += (s, args) => this.Close();
            a.Closed += (s, args) => this.Close();
        }

        
        Biblioteka b;
        Biblioteka2 b1;
        admin a;
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (log.Text == "Student1" && has.Text == "Student1")
            {
                b.nazwastudenta = log.Text;
                b.Show();
                this.Hide();
                
               

            }
            else if (log.Text == "Student2" && has.Text == "Student2")
            {
                b1.nazwastudenta = log.Text;
                b1.Show();
                this.Hide();

            }
            else if (log.Text == "admin" && has.Text == "admin")
            {
                a.nazwastudenta = log.Text;
                a.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Zly login lub haslo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void has_TextChanged(object sender, EventArgs e)
        {
            has.UseSystemPasswordChar= true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                has.UseSystemPasswordChar = false;
            }
            else
            {
                has.UseSystemPasswordChar = true;
            }
        }
    }
}