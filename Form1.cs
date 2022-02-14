using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.White, 10);
            Point First = new Point(10000,200);
            Point Second = new Point(1,200);
            g.DrawLine(pen, First, Second);
            Rectangle rect = new Rectangle(260, 100, 200, 200);
            Pen p = new Pen(Color.White, 10);
            g.DrawEllipse(p, rect);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
