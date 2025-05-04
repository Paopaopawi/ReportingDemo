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
    public partial class Kier : Form
    {
        public Kier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
                label2.Font = fontDialog1.Font;
            }
        }


        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void reyesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new Karl().Show();
            this.Hide();
        }

        private void violanteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new Lujelle().Show();
            this.Hide();
        }

        private void brionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new Kier().Show();
            this.Hide();
        }
    }
}
