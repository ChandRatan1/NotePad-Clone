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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    comboBox2.Items.AddRange(new object[] { "January", "February", "March" });
                    break;
                case 1:
                    comboBox2.Items.AddRange(new object[] { "April", "May", "June" });
                    break;
                case 2:
                    comboBox2.Items.AddRange(new object[] { "July", "August", "September" });
                    break;
                case 3:
                    comboBox2.Items.AddRange(new object[] { "October", "November", "December" });
                    break;

            }
        }
    }
}
