namespace bib
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            b = new Biblioteka();
            b.l = this;
            
            b.Closed += (s, args) => this.Close();
        }
        Biblioteka b;

        private void button1_Click(object sender, EventArgs e)
        {
            if( log.Text=="Student1" && has.Text == "Student1" || log.Text == "Student2" && has.Text == "Student2" || log.Text == "Student3" && has.Text == "Student3")
            {
                
                
                b.Show();
                this.Hide();
            }
             
            else
            {
                MessageBox.Show("Zly login lub haslo");
            }
        }
    }
}