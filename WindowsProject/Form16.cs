using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProject
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
           
           
            if (dr == DialogResult.OK)
            {

                string folderPath = folderBrowserDialog1.SelectedPath;
                string[] files = Directory.GetFiles(folderPath,"*.jpg");

                listBox1.Tag = folderPath;
                listBox1.Items.Clear();
                foreach(string file in files)
                {
                    int lastindex = file.LastIndexOf("\\");
                    string imagepath = file.Substring(lastindex+1);

                    listBox1.Items.Add(imagepath);
                }

                listBox1.SelectedIndex = 0;


            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = listBox1.Tag + "\\" + listBox1.SelectedItem;
        }
    }
}
