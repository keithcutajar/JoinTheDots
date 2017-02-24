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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //open a window dialog to choose a picture
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //save image and filename in dictionary
                pbx.Load(ofd.FileName);

                //add the filename to the list box
                lblUrl.Text = (ofd.FileName);
                pictureBox1.Visible = false;

            }
            else
            {
                pictureBox1.Visible = true;
            }
        }

    }
}
