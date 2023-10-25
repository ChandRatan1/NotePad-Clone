using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProject
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Radio Button 1 is checked");
            else if (radioButton2.Checked)
                MessageBox.Show("Radio Button 2 is Checked");
            else if (radioButton3.Checked)
                MessageBox.Show("Radio Button 3 is checked");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                MessageBox.Show("Checkbox 1 is checked");
            if (checkBox2.Checked)
                MessageBox.Show("Checkbox 2 is checked");
            if (checkBox3.Checked)
                MessageBox.Show("Checkbox 3 is checked");


        }
    }
}
