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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to windows app. development");
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have clicked on the form");
        }
    }
}
