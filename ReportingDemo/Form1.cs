using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = dialog.SelectedPath;
                textBox1.Text = folderPath;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void brionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Kier().Show();
            this.Hide();
        }

        private void reyesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Karl().Show();
            this.Hide();
        }

        private void violanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Lujelle().Show();
            this.Hide();
        }
    }
}
