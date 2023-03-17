namespace Caezar
{
    public partial class Open : Form
    {
        public Open()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Encryption encr = new Encryption();
            encr.Show();
            this.Hide();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Decryption decr = new Decryption();
            decr.Show();
            this.Hide();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}