using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ll_LAB_EXP_3B
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Wanted Design
        private void Form1_Load(object sender, EventArgs e)
        {
            CipherLabel.Visible = false;
            CipherTextBox.Visible = false;
            groupBox1.Visible = false;
        }
        //Encrypt given text source code from .pdf file
        public static void Encipher(char[] input, int key, bool success, Label SuccessLabel, string encryptedMessage)
        {
            encryptedMessage = string.Empty;
            if (input.Length < 2)
            {
                success = false;
                SuccessLabel.Text = "Failed";
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                Cipher(ch, key);
                encryptedMessage += ch;
            }
            success = true;
            SuccessLabel.Text = "Success";
           
        }
        //Ciphering algorithm from .pdf file
        public static void Cipher(char ch, int key)
        {
            if (char.IsLetter(ch))
            {
                char d = char.IsUpper(ch) ? 'A' : 'a';
                ch = (char)((ch + key - d) % 26 + d);
            }
        }






        //Only Showing Cipher Text Box and Label when Ceaser Cipher is selected
        private void radioButtonCeaser_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonCeaser.Checked)
            {
                CipherLabel.Visible = true;
                CipherTextBox.Visible = true;

            }
            else if (radioButtonCeaser.Checked == false)
            {
                CipherLabel.Visible = false;
                CipherTextBox.Visible = false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            groupBox1.Visible = true;
            if (radioButtonCeaser.Checked)
            {
                //Ceaser Cipher PasswordTextBox.Text default value is 4 when CipherTextBox.Text is empty
                int key = 4;
                if (CipherTextBox.Text != "")
                {
                    key = Convert.ToInt32(CipherTextBox.Text);
                }
                string encryptedMessage = string.Empty;
                bool success = false;
                Encipher(PasswordTextBox.Text.ToCharArray(), key, success, SuccessLabel, encryptedMessage);
                CipheredText.Text = encryptedMessage;
                SuccessLabel.BackColor = Color.Green;
            }
            else if (radioButtonRot3.Checked)
            {
                //Rot3 Cipher PasswordTextBox.Text default value is 3 as given in the .pdf file
                int key = 3; 
                string encryptedMessage = string.Empty;
                bool success = false;
                Encipher(PasswordTextBox.Text.ToCharArray(), key, success, SuccessLabel, encryptedMessage);
                CipheredText.Text = encryptedMessage;
                SuccessLabel.BackColor = Color.Green;
            }
            else
            {
                CipheredText.Text = "Please select a cipher method";
                SuccessLabel.Text = "Failed";
                SuccessLabel.BackColor = Color.Red;
            }
        }
    }
}
