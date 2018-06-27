using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSISP_TASK_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\img.png";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var code = e.KeyCode;
            int distance = 20;
            switch (code)
            {
                case (Keys.Down):
                case (Keys.Up):
                    pictureBox1.Top += distance * (code == Keys.Down? 1: -1);
                    break;
                case (Keys.Left):
                case (Keys.Right):
                    pictureBox1.Left += distance * (code == Keys.Right ? 1 : -1);
                    break;
            }
        }
    }
}
