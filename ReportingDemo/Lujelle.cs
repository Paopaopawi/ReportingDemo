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
    public partial class Lujelle : Form
    {
        public Lujelle()
        {
            InitializeComponent();
        }

        private void Lujelle_Load(object sender, EventArgs e)
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(150, 150);

            imageList.Images.Add(Image.FromFile("C:/Users/My Computer/source/repos/ReportingDemo/ReportingDemo/Image/images.jpg"));

            listView1.LargeImageList = imageList;
            listView1.View = View.LargeIcon;

            ListViewItem item1 = new ListViewItem("Item 1", 0);
            listView1.Items.Add("item1", 0);

            this.Controls.Add(listView1);
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void brionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new Kier().Show();
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
    }
}
