using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Virus.ClassA;

namespace Virus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclickhere_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Thread.Sleep(70);
                Random rand = new Random();
                int xInt = rand.Next(0,1000);
                int yInt = rand.Next(0,1000);
                Win32.POINT p = new Win32.POINT(xInt, yInt);
                Win32.ClientToScreen(this.Handle, ref p);
                Win32.SetCursorPos(p.x, p.y);
            }
        }
    }
}
