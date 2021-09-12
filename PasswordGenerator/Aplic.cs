using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace PasswordGenerator
{
    public partial class Aplic : Form
    {
        private int lenght = 0;
        private String password;


        public Aplic()
        {
            InitializeComponent();
        }

        private void checkBoxRandomLenght_CheckedChanged(object sender, EventArgs e)
        {
            RandomLength();
        }

        private void RandomLength() 
        {

            if (checkBoxRandomLenght.Checked == true)
            {
                textBoxLenght.Enabled = false;
                Random rnd = new Random();

                int i = rnd.Next(8, 20);

                textBoxLenght.Text = i.ToString();

            }
            else
            {
                textBoxLenght.Enabled = true;
                
            }
        
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxLenght.Text == null) 
                {
                    textBoxLenght.Text = "0";
                }

                lenght = int.Parse(textBoxLenght.Text);

                if (lenght == 0 ) 
                {
                    checkBoxRandomLenght.Checked = true;
                    RandomLength();

                }

                
            }
            catch (Exception)
            {

                throw;
            }




            GeneratePassword();





        }

        private void GeneratePassword() 
        {
            PasswordContent pc = new PasswordContent(
                    lenght,
                    checkBoxUppercase.Checked,
                    checkBoxLowercase.Checked,
                    checkBoxDigits.Checked,
                    checkBoxSpecialCharacters.Checked);
             

            password = pc.GetPassword();

            labelPassword.Text = password;

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(password);
        }

        
    }
}
