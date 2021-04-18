using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ti_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Encrypt(object sender, EventArgs e)
        {
            RSA rsa;
            if (comboBox.SelectedIndex == 0)
            {
                string Result;
                rsa = new RSA(false, 0, 0, 0);
                Result = rsa.Encrypt(textBoxInput.Text, rsa.e, rsa.r);

                while (Result == "Error")
                {
                    rsa = new RSA(false, 0, 0, 0);
                    Result = rsa.Encrypt(textBoxInput.Text, rsa.e, rsa.r);
                }

                textBoxOutput.Text = Result;
                textBoxP.Text = rsa.p.ToString();
                textBoxQ.Text = rsa.q.ToString();
                textBoxR.Text = rsa.r.ToString();
                textBoxKo.Text = rsa.e.ToString();
                textBoxKs.Text = rsa.d.ToString();
            }
            else
            {
                string Result;
                rsa = new RSA(true, GetSecretNumberP(), GetSecretNumberQ(), GetNumberE());
                Result = rsa.Encrypt(textBoxInput.Text, rsa.e, rsa.r);

                textBoxOutput.Text = Result;
                textBoxR.Text = rsa.r.ToString();
                textBoxKo.Text = rsa.e.ToString();
                textBoxKs.Text = rsa.d.ToString();
            }
        }

        private void Decrypt(object sender, EventArgs e)
        {
            RSA rsa = new RSA(true, GetSecretNumberP(), GetSecretNumberQ(), GetNumberE());
            string[] cipherText = textBoxInput.Text.Trim(' ').Split(' ');
            textBoxOutput.Text = rsa.Decrypt(cipherText, GetSecretNumberD(), rsa.r);
        }

        public long GetSecretNumberP()
        {
            return Convert.ToInt64(textBoxP.Text);
        }

        public long GetSecretNumberQ()
        {
            return Convert.ToInt64(textBoxQ.Text);
        }

        public long GetSecretNumberD()
        {
            return Convert.ToInt64(textBoxKs.Text);
        }

        public long GetNumberE()
        {
            return Convert.ToInt64(textBoxKo.Text);
        }

        private void InitializeComboBox()
        {
            comboBox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Decrypt(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnEncr_Click(object sender, EventArgs e)
        {
            Encrypt(sender, e);
        }
    }
}
