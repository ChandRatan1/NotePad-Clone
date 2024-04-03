using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProject
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Connect to data base
            MessageBox.Show("Data has been saved into DataBase", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Want to Close ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            foreach(Control ctr in this.Controls )
            {
                if (ctr is TextBoxBase)
                {
                    ctr.CausesValidation = false;
                }
            }
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox tb = (TextBox)ctr;
                    tb.Clear();
                    txtPwd.Enabled = true;
                    txtCPwd.Enabled = true;
                    txtName.Focus();
                }
                if (ctr is MaskedTextBox)
                {
                    MaskedTextBox tb = (MaskedTextBox)ctr;
                    tb.Clear();


                }
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            //This validation applies to User Name and Password Textbox's
            
            if (tb.Text.Trim().Length == 0)
            {
                MessageBox.Show("You can't leave the field empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            //This validation applies only to Password Textbox's

            if (tb.Name != "txtName")
            {
                if (tb.Text.Trim().Length < 8)
                {
                    MessageBox.Show("Password should between 8 to 16 chars.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
                //Check confirm password to be matching with password
                //This validation applies only to Confirm Password Textbox


                if (tb.Name != "txtPwd")
                {
                    Regex pwd = new Regex((@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$"));
                    if (!pwd.IsMatch(txtPwd.Text))
                    {
                        MessageBox.Show("Please Enter Valid Email Id", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    if (txtCPwd.Text != txtPwd.Text)
                    {
                        DialogResult dr = MessageBox.Show("Confirm Password Should be match With password\n\nDo you remember the \r\npassword?\r\n", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dr == DialogResult.Yes)
                        {
                            txtCPwd.Clear();
                            txtCPwd.Focus();

                        }
                        if (dr == DialogResult.No)
                        {
                            txtCPwd.Clear();
                            txtPwd.Clear();
                            txtPwd.Focus();
                        }
                        return;

                    }

                    if (txtPwd.Text == txtCPwd.Text)
                    {
                        txtCPwd.Enabled = false;
                        txtPwd.Enabled = false;
                    }



                }



            }



        }

        private void mtxtDOB_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {

            if (mtbDOB.Text.Replace("/", "").Trim().Length == 0)
            {

                MessageBox.Show("Date of birth field is mandatory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }
            bool status = DateTime.TryParseExact(mtbDOB.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime dt);
            if (status)
            {

                if (dt > DateTime.Now.AddYears(-18))
                {
                    MessageBox.Show("Minimum 18 years of age is required for registration.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }

            }
            else
            {
                MessageBox.Show("Date should be DD/MM/YYYY formate", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }



        }


        //  6.	Check Mobile TextBox accepts numeric and back spaces only and Mobile No.
        //  should start with digits 6 or 7 or 8 or 9 and should be minimum 10 and maximum 10 digits,
        //  but not mandatory field.

        private void txtMobile_Validating(object sender, CancelEventArgs e)
        {
            if (tbMobile.Text.Length > 0)
            {
                Regex rg = new Regex(@"^[6-9]\d{9}|^0[6-9]\d{9}$");
                if(!rg.IsMatch(tbMobile.Text))
                {

                    MessageBox.Show("Please Enter valid Mobile Number","Mobile Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    e.Cancel= true;
                }
               
            }

        }

        private void tbMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (char.IsDigit(e.KeyChar)==false&&Convert.ToInt32(e.KeyChar)!=8)
            {
                MessageBox.Show("Please Enter Numaric Only","Numaric Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Handled = true;
               
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Length > 0)
            {
                Regex email_validation = new Regex((@"^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$"));
                if (!email_validation.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Please Enter Valid Email Id","Email Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    e.Cancel= true;
                }
            }
        }
    }
}
