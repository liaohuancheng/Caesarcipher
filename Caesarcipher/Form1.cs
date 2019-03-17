using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesarcipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEncrypt.Clear();
            if (String.IsNullOrEmpty(txtOrigin.Text))
            {
                MessageBox.Show("请输入原文");
            }
            else if (String.IsNullOrEmpty(txtShift.Text))
            {
                MessageBox.Show("请输入转移量");
            }
            String origin = this.txtOrigin.Text;
            string strShift = this.txtShift.Text;
            int shift = int.Parse(strShift);
            if (shift > 24|| shift < 0)
                shift %= 24;
            char encrypt;
            foreach(char c in origin)
            {
                if (c != 32)
                {
                    if (!char.IsUpper(c))
                    {
                        if (c + shift > 122)
                        {
                            int a1 = c + shift - 122;
                            encrypt = Convert.ToChar(96 + a1);


                        }
                        else
                        {
                            encrypt = Convert.ToChar(c + shift);
                        }
                        txtEncrypt.AppendText(encrypt.ToString());
                    }
                }
                if (char.IsUpper(c))
                {
                    if (c + shift > 90)
                    {
                        int a1 = c + shift - 90;
                        encrypt = Convert.ToChar(64 + a1);


                    }
                    else
                    {
                        encrypt = Convert.ToChar(c + shift);
                    }
                    txtEncrypt.AppendText(encrypt.ToString());
                }   
            }
        }
    }
}
