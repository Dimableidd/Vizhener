using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caezar
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox3.Text = "";
            char [] Alphabet = {' ','A','B','C','D','E','F','G','H','I','J','K','L','M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int k = Convert.ToInt32(richTextBox2.Text);
            int c = -1, p = 0;
            for (int i = 0; i < richTextBox1.Text.Length ; i++)
            {
                for(int j=0; j<27;j++)
                {
                    if (richTextBox1.Text[i] == Alphabet[j]) c = j;
                }
                if (c == -1 || k < 1 || k > 26)
                {
                    MessageBox.Show("ОШИБКА ВВОДА", "ОШИБКА");
                    break;
                }
                p = c + k;
                if (p > 26)  p = p - 27;
                richTextBox3.Text += Convert.ToString(Alphabet[p]);
                p = 0;
                c = -1;
            }

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Open op = new Open();
            op.Show();
            this.Hide();
        }
    }
}
