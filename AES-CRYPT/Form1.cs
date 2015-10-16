using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AES_CRYPT
{
    public partial class Form1 : Form
    {
        bool crpt = true;
        string ans = "";
        int pinter = 2;
        string hs = "SHA1";
        int siz = 256;
        string salted = "";
        string vec = "";

        public Form1()
        {
            InitializeComponent();
            cb1hash.SelectedIndex = 0;
            cb2len.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (texta.TextLength != 0)
            {
                if (pass1.TextLength != 0)
                {
                    if (maskedTextBox1.TextLength == 16)
                    {
                        if (crpt)
                        {
                            label1.Text = "Шифруем...";
                            ans = aes.Encrypt(texta.Text, pass1.Text, salt0.Text, hs, pinter, maskedTextBox1.Text, siz);
                            anstext.Text = ans;
                            label1.Text = "Готово!";
                        }
                        else
                        {
                            label1.Text = "Дешифруем...";
                            salted = Convert.ToString(salt0.Text);
                            vec = Convert.ToString(maskedTextBox1.Text);
                            ans = aes.Decrypt(texta.Text, pass1.Text, salted, hs, pinter, vec, siz);
                            anstext.Text = ans;
                            label1.Text = "Готово!";
                        }
                    }
                    else label1.Text = "Вектор должен быть 16 ASCII символов!";
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pinter = trackBar1.Value;
        }

        private void cb1hash_SelectedIndexChanged(object sender, EventArgs e)
        {
            hs = Convert.ToString(cb1hash.Items[cb1hash.SelectedIndex]);
        }

        private void cb2len_SelectedIndexChanged(object sender, EventArgs e)
        {
            siz = Convert.ToInt16(cb2len.Items[cb2len.SelectedIndex]);
        }
    }
    public class aes
    {
        public static string Encrypt(string plainText, string password, string salt = "salt", string hashAlgorithm = "SHA1", int passwordIterations = 2, string initialVector = "OFRna73m*aze01xY", int keySize = 256)
        {
            if (string.IsNullOrEmpty(plainText))
                return "";

            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes
             (password, saltValueBytes, hashAlgorithm, passwordIterations);

            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] cipherTextBytes = null;

            using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor
            (keyBytes, initialVectorBytes))
            {
                using (MemoryStream memStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream
                             (memStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memStream.ToArray();
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }

            symmetricKey.Clear();
            return Convert.ToBase64String(cipherTextBytes);
        }
        public static string Decrypt(string cipherText, string password, string salt = "salt", string hashAlgorithm = "SHA1", int passwordIterations = 2, string initialVector = "OFRna73m*aze01xY", int keySize = 256)
        {
            if (string.IsNullOrEmpty(cipherText))
                return "";

            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes
            (password, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int byteCount = 0;

            using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor
                     (keyBytes, initialVectorBytes))
            {
                using (MemoryStream memStream = new MemoryStream(cipherTextBytes))
                {
                    using (CryptoStream cryptoStream
                    = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read))
                    {
                        byteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }

            symmetricKey.Clear();
            return Encoding.UTF8.GetString(plainTextBytes, 0, byteCount);
        }
    }
}