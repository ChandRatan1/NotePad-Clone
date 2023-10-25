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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sender is Button)
            {
               Button b = (Button)sender;
                if(b.Name=="button1")
                MessageBox.Show("Button1 is Clicked by user...");
                else if (b.Name == "button2")
                    MessageBox.Show("Button1 is Clicked by user...");
            }
            else if (sender is TextBox)
            {
                TextBox b = (TextBox)sender;
                if (b.Name == "textBox1")
                    MessageBox.Show("TextBox 1 is Clicked by user...");
                else if (b.Name == "textBox2")
                    MessageBox.Show("TextBox 2 is Clicked by user...");
            }
            else
            {
                Form f=(Form)sender;
                MessageBox.Show("Form 7 is clicked by user");
            }
        }
    }
}
