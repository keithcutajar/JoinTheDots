using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Event_Driven_Programming
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
            {
                Opacity += 0.05;
                progress.Value ++;
            }
            else
            {
                timer.Stop();
                this.Hide();
                Form1 newWindow = new Form1();
                newWindow.Show();
            }
        }
    }
}
