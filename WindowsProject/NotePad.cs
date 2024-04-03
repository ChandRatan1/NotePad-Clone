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
using System.Xml.Linq;

namespace WindowsProject
{
    public partial class NotePad : Form
    {
        public NotePad()
        {
            InitializeComponent();
        }

        // implementation for New page  
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                DialogResult dr = MessageBox.Show("Doy you want to save ", "Question ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    richTextBox1.Clear();
                }
                else if (dr == DialogResult.No)
                {
                    richTextBox1.Clear();
                }
            }

        }
        //implementation for Open file diloug box

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Txt files|*.txt|All files|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                richTextBox1.Tag = openFileDialog1.FileName;
            }
        }

        // logic for implementing save as operation
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "*.txt";
            saveFileDialog1.Filter = "Txt Files|*.txt|all Files|*.*";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string filepath = saveFileDialog1.FileName;


                string fiepath = saveFileDialog1.FileName;
                richTextBox1.SaveFile(fiepath, RichTextBoxStreamType.PlainText);
                richTextBox1.Tag = fiepath;
            }
        }

        // Logic for exit the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                DialogResult dr = MessageBox.Show("Do You want to save !", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e); this.Close();
                }

                else
                    this.Close();

            }
            else
            {
                this.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                if(richTextBox1.Tag ==null)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
                else
                richTextBox1.SaveFile(richTextBox1.Tag.ToString(), RichTextBoxStreamType.PlainText);
            }
            else
            {
                saveToolStripMenuItem_Click(sender, e);
            }
            


        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusBarToolStripMenuItem.Checked)
                statusStrip1.Visible = true;
            else
            {
                statusStrip1.Visible = false;

            }
        }

        private void wordRapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordRapToolStripMenuItem.Checked)
                richTextBox1.WordWrap = true;
            else
                richTextBox1.WordWrap = false;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // richTextBox1.SizeChanged += zoomInToolStripMenuItem_Click;
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////richTextBox1.SizeChanged -= zoomOutToolStripMenuItem_Click;
            //richTextBox1.SizeChanged -= zoomOutToolStripMenuItem_Click;
        }
    }
}
