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
    public partial class Form11cs : Form
    {
        public Form11cs()
        {
            InitializeComponent();
        }

        private void Form11cs_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Uttar Pradesh");
            listBox1.Items.Add("Kerala");
            listBox1.Items.Add("Odisha");
            listBox1.Items.Add("Karnataka");
            listBox1.Items.Add("Telangana");
            listBox1.Items.Add("Tamilnadu");
            listBox1.Items.Add("Andhra Pradesh");

            string[] city =  { "Delhi", "Kolkata", "Mumbai", "Chennai", "Bengaluru", "Hyderabad" };
            foreach(Control ctr in this.Controls)
            {
                checkedListBox1.Items.AddRange(city);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Country =>> "+comboBox1.Text);
            MessageBox.Show("Selected Country =>>"+comboBox1.SelectedItem);
            MessageBox.Show("Selected Country =>>" + comboBox1.SelectedIndex);

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (comboBox1.FindStringExact(comboBox1.Text)==-1 )
                {
                    comboBox1.Items.Add(comboBox1.Text);
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          foreach(object obj in listBox1.SelectedItems)
            {
                MessageBox.Show("Selected State =>> " + obj);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach(object obj in checkedListBox1.CheckedItems)
            {
                str += obj.ToString()+", ";
            }

            if (checkedListBox1.CheckedItems.Count > 0)
            {
                str = str.Remove(str.LastIndexOf(","));
                int lastCommaIndex = str.LastIndexOf(",");
                if (lastCommaIndex != -1)
                {
                    str = str.Remove(lastCommaIndex, 1);
                    str = str.Insert(lastCommaIndex, " and");
                }
                MessageBox.Show("Selected Cities: " + str);
            }

        }
    }
}
