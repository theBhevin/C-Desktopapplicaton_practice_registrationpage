using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Registration1
{
    public partial class Registration : Form
    {
        private Boolean IsValidReg = false;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            

        }

        private void FullNametextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButton_MouseClick(object sender, MouseEventArgs e)
        {
            IsValidReg = true;
            String FullName = String.Empty;
            String Email = String.Empty;
            String Contact = String.Empty;
            String UserName = String.Empty;
            String PassWord = String.Empty;

            FullName = FullNametextBox1.Text.Trim();
            if (FullNametextBox1.TextLength == 0)
            {
                IsValidReg = false;
                RegiErrorProvider.SetError(FullNametextBox1, "Full Name can't be empty.!");

            }
            Email = EmailtextBox.Text.Trim();
            if (EmailtextBox.TextLength == 0)
            {
                IsValidReg = false;
                RegiErrorProvider.SetError(EmailtextBox, "Email can not be empty.!");

            }
            Contact = ContactNumbertextBox.Text.Trim();
            if (ContactNumbertextBox.Text.Length == 0)
            {
                IsValidReg = false;
                RegiErrorProvider.SetError(ContactNumbertextBox, "Contact Number can not be Empty!");

            }
            UserName = UserNametextBox.Text.Trim();
            if (UserName.Length == 0)
            {
                IsValidReg = false;
                RegiErrorProvider.SetError(UserNametextBox, "User name can't be empty.!");

            }
            PassWord = PasstextBox.Text.Trim();
            if (PassWord.Length == 0)
            {
                IsValidReg = false;
                RegiErrorProvider.SetError(PasstextBox, "Password can not be empty.!");

            }


            if (!AcceptCheckbox.Checked)
            {
                MessageBox.Show("Accept Terms and Conditions");
            }
             if (IsValidReg)
            
            {
               
            
                MessageBox.Show("Page Is Valid.");
            }
        }

        private void FullNametextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            RegiErrorProvider.Clear();
            RegiErrorProvider.Dispose();
        }

        private void EmailtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RegiErrorProvider.Clear();
            RegiErrorProvider.Dispose();
        }

        private void ContactNumbertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RegiErrorProvider.Clear();
            RegiErrorProvider.Dispose();
        }

        private void UserNametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RegiErrorProvider.Clear();
            RegiErrorProvider.Dispose();
        }

        private void PasstextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RegiErrorProvider.Clear();
            RegiErrorProvider.Dispose();
        }
    }
    }vv
    
   

