using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsProject
{
    public partial class Form9 : Form
    {
        
        public Form9()
        {
            InitializeComponent();
        }
        int Count = 0;
        private void CheckBox_CkeckedChange(object sender, EventArgs e)
        {
            
            CheckBox cb= sender as CheckBox;
            int amount=int.Parse(txtFees.Text);
            if (cb.Checked)
            {
                Count += 1;
                amount += Convert.ToInt32(cb.Tag);
            }
            else
            {
                Count -= 1;
                amount -= Convert.ToInt32(cb.Tag);
            }
            txtFees.Text=amount.ToString();
            
        }

        private void RadioButton_checkedChanged(object sender, EventArgs e)
        {
            rbNormal.Checked = true;

            int amt = int.Parse(txtFees.Text);
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
               
                amt += (Convert.ToInt32(rb.Tag) * Count);
            }
            else
            {
                amt -= (Convert.ToInt32(rb.Tag) * Count);
            }
            txtFees.Text=amt.ToString();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach(Control check in gbCources.Controls)
            {
                CheckBox cb= check as CheckBox;
                cb.Checked = false;
            }
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox tb = ctr as TextBox;
                    tb.Clear();
                }
            }
            txtFees.Text = "0";
            txtBoxName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr=MessageBox.Show("Are you sure to want close form","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr.ToString()=="Yes")
            this.Close();
        }
    }
}
