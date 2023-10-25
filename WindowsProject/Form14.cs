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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = button1.BackColor;
            
           DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
               button1.BackColor= colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = button2.Font;
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                button2.Font= fontDialog1.Font;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "jpeg images|*.jpg|png Images|*.png|all files|*.*";

            DialogResult dr =openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = filepath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "*.jpg";
            saveFileDialog1.Filter= "jpeg images|*.jpg|png Images|*.png|all files|*.*";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                string filepath= saveFileDialog1.FileName;
                pictureBox1.Image.Save(filepath);
            }
        }
    }
}
