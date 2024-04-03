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
    public partial class MdiParent : Form
    {
        public MdiParent()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            
            f.MdiParent = this;
            f.Show();


        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.MdiParent = this;
            f.Show();
        }

        private void notePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotePad f = new NotePad();
            f.MdiParent = this;
            f.Show();
        }

        private void imageViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 f = new Form15();
            f.MdiParent = this;
            f.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
