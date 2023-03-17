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
    public partial class Decryption : Form
    {
        public Decryption()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox3.Text = "";
            string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string B, C, D = "";
            B = richTextBox1.Text.Replace(" ", "");
            C = richTextBox2.Text.Replace(" ", "");

            for (int i = 0; i < B.Length; i++)
            {
                int q = -1;
                for (int j = 0; j < 26; j++)
                {
                    if (B[i] == Alphabet[j]) q = j;
                }
                if (q == -1)
                {
                    MessageBox.Show("ОШИБКА ВВОДА В СТРОКЕ //ОТКРЫТЫЙ ТЕКСТ//", "ОШИБКА");
                    return;
                }
            }
            for (int i = 0; i < C.Length; i++)
            {
                int q = -1;
                for (int j = 0; j < 26; j++)
                {
                    if (C[i] == Alphabet[j]) q = j;
                }
                if (q == -1)
                {
                    MessageBox.Show("ОШИБКА ВВОДА В СТРОКЕ //КЛЮЧ//", "ОШИБКА");
                    return;
                }
            }
            int[] F = new int[richTextBox1.Text.Length];
            int[] G = new int[richTextBox1.Text.Length];
            int c = C.Length;
            int b = B.Length;
            if (b >= c)
            {
                for (int i = 0; i < b / c; i++)
                {
                    D += C;
                }
                for (int i = 0; i < b % c; i++)
                {
                    D += C[i];
                }
            }
            else
            {
                for (int i = 0; i < b; i++)
                {
                    D = D + B[i];
                }
            }
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (B[i] == Alphabet[j])
                    {
                        F[i] = j;
                    }

                    if (D[i] == Alphabet[j])
                    {
                        G[i] = j;
                    }
                }
            }
            int k = 0;
            for (int i = 0; i < b; i++)
            {
                k = ((F[i] - G[i]) % 26);
                if (k < 0)
                    k += 26;
                richTextBox3.Text += Alphabet[k];
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
