using Encrypter.classes;
using System;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace Encrypter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            Helper helper = new Helper();
            Hashtable ht = helper.GetHashTable();
            string[] Words = tbxInput.Text.Split(' ');

            foreach (string word in Words)
            {
                char[] WordArray = word.ToCharArray();
                string[] EncryptedWordArray = new string[WordArray.Length];

                int i = 0;
                foreach (char letter in WordArray)
                {
                    if (ht.Contains(letter))
                    {
                        EncryptedWordArray[i] =ht[letter].ToString();
                    }
                    i++;
                }
                sb.Append(String.Join("~", EncryptedWordArray));
                sb.Append("  ");
            }
            tbxOutput.Text = sb.ToString();
        }

    }

}

