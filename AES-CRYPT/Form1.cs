using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_CRYPT
{
    public partial class Form1 : Form
    {
        bool crpt = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                if (textBox2.TextLength != 0)
                {
                    label1.Text = "Шифруем...";
                }
                else label1.Text = "Необходимо ввести пароль!";
            }
            else label1.Text = "Необходимо ввести текст!";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                crpt = false;
                label1.Text = "Введите текст и пароль для дешифрования";
                button1.Text = "Decrypt";
            }
            else
            {
                crpt = true;
                label1.Text = "Введите текст и пароль для шифрования";
                button1.Text = "Encrypt";
            }
        }
    }
}