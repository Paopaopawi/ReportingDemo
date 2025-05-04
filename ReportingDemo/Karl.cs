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
    public partial class Karl : Form
    {
        public Karl()
        {
            InitializeComponent();
        }

        private void Karl_Load(object sender, EventArgs e)
        {
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = 100;
            hScrollBar1.Value = 50;

            helpProvider1.SetHelpString(textBox1, "Enter your first name here");
            helpProvider1.SetHelpString(textBox2, "Enter your last name here");

            helpProvider1.SetShowHelp(textBox1, true);
            helpProvider1.SetShowHelp(textBox2, true);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label3.Text = $"Scroll Value {hScrollBar1.Value}";
            this.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar1.Value, hScrollBar1.Value);
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
