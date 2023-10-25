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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Items.Clear();
            comboBox3.Text = "";

            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    comboBox2.Items.AddRange(new object[] { "Karnataka", "Tamil Nadu", "Kerala" });
                    break;
                case 1:
                    comboBox2.Items.AddRange(new object[] { "California", "Texas", "New York" });
                    break;
                case 2:
                    comboBox2.Items.AddRange(new object[] { "Guangdong", "Sichuan", "Zhejiang" });
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            comboBox3.Items.Clear();
            switch(comboBox2.SelectedItem)
            {
                case "Karnataka":
                    comboBox3.Items.AddRange(new object[] { "Bengaluru", "Mysore", "Mangalore" });
                    break;
                case "Tamil Nadu":
                    comboBox3.Items.AddRange(new object[] { "Chennai", "Coimbatore", "Madurai" });
                    break;
                case "Kerala":
                    comboBox3.Items.AddRange(new object[] { "Thiruvananthapuram", "Kochi", "Kozhikode" });
                    break;

                    //==============================================================

                case "California":
                    comboBox3.Items.AddRange(new object[] { "Los Angeles","San Francisco","San Diego" });
                    break;
                case "Texas":
                    comboBox3.Items.AddRange(new object[] { "Houston","San Antonio","Dallas" });
                    break;
                case "New York":
                    comboBox3.Items.AddRange(new object[] { "New York City","Buffalo","Rochester" });
                    break; //==============================================================

                case "Guangdong":
                    comboBox3.Items.AddRange(new object[] { "Guangzhou", "Shenzhen", "Zhuhai" });
                    break;
                case "Sichuan":
                    comboBox3.Items.AddRange(new object[] { "Chengdu", "Mianyang", "Leshan" });
                    break;
                case "Zhejiang":
                    comboBox3.Items.AddRange(new object[] { "Hangzhou", "Ningbo", "Wenzhou" });
                    break;

            }
        }
    }
}
