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
    public partial class Form2 : Form
    {
        //whether program is in drawing modeor not
        bool drawingMode = false;

        //where we will store the drawing
        Bitmap drawing;

        Color c = Color.Black;



        public Form2()
        {
            InitializeComponent();

            drawing = new Bitmap(pnlDrawing.Width,
                                 pnlDrawing.Height,
                                 pnlDrawing.CreateGraphics());
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (clrDialog.ShowDialog() == DialogResult.OK)
            {
                c = clrDialog.Color;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                errorName.SetError(textBox1, "Name cannot be blank!");
            }
            else
            {
                saveDialog.FileName = textBox1.Text;
                saveDialog.Filter = "JPEG file | *.jpeg";

                //show the save dialog and checked if the user clicked ok
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    //create a new (empty) image file, with the same size as the panel
                    Bitmap bmp = new Bitmap(pnlDrawing.Width, pnlDrawing.Height);

                    //copy the contents of the panel to the nw image file
                    pnlDrawing.DrawToBitmap(bmp, new Rectangle(0, 0, pnlDrawing.Width, pnlDrawing.Height));

                    //finally, save the image file (jpg) in the path that the user has chosen
                    bmp.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void pnlDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingMode == true) //or just (drawingmode), means that its true
            {
                Graphics g = Graphics.FromImage(drawing);

                //create brush
                SolidBrush brush = new SolidBrush(c);

                //draw the circle
                g.FillEllipse(brush, e.X, e.Y, 8, 8);

                //update the panel with the new image
                pnlDrawing.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
            }
        }

        private void pnlDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            drawingMode = true;
        }

        private void pnlDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            drawingMode = false;
        }



        private void cmbDots_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(drawing);
            Random r = new Random();


            int dots = Convert.ToInt32(cmbDots.SelectedItem.ToString());

            switch (dots)
            {

                case 2:

                    for (int i = 0; i < 2; i++)
                    {
                        int randomX = r.Next(634);
                        int randomY = r.Next(321);

                        int randomR = r.Next(255);
                        int RandomG = r.Next(255);
                        int RandomB = r.Next(255);

                        //create the color
                        Color c = Color.FromArgb(randomR, RandomG, RandomB);
                        SolidBrush b1 = new SolidBrush(c);
                        g.FillEllipse(b1, randomX, randomY, 20, 20);
                    }
                    break;

                case 3:

                    for (int i = 0; i < 3; i++)
                    {
                        int randomX = r.Next(634);
                        int randomY = r.Next(321);

                        int randomR = r.Next(255);
                        int RandomG = r.Next(255);
                        int RandomB = r.Next(255);

                        //create the color
                        Color c = Color.FromArgb(randomR, RandomG, RandomB);
                        SolidBrush b1 = new SolidBrush(c);
                        g.FillEllipse(b1, randomX, randomY, 20, 20);
                    }
                    break;

                case 4:

                    for (int i = 0; i < 4; i++)
                    {
                        int randomX = r.Next(634);
                        int randomY = r.Next(321);

                        int randomR = r.Next(255);
                        int RandomG = r.Next(255);
                        int RandomB = r.Next(255);

                        //create the color
                        Color c = Color.FromArgb(randomR, RandomG, RandomB);
                        SolidBrush b1 = new SolidBrush(c);
                        g.FillEllipse(b1, randomX, randomY, 20, 20);
                    }
                    break;

                case 5: for (int i = 0; i < 5; i++)
                    {
                        int randomX = r.Next(634);
                        int randomY = r.Next(321);

                        int randomR = r.Next(255);
                        int RandomG = r.Next(255);
                        int RandomB = r.Next(255);

                        //create the color
                        Color c = Color.FromArgb(randomR, RandomG, RandomB);
                        SolidBrush b1 = new SolidBrush(c);
                        g.FillEllipse(b1, randomX, randomY, 20, 20);
                    }
                    break;

                case 6: for (int i = 0; i < 6; i++)
                    {
                        int randomX = r.Next(634);
                        int randomY = r.Next(321);

                        int randomR = r.Next(255);
                        int RandomG = r.Next(255);
                        int RandomB = r.Next(255);

                        //create the color
                        Color c = Color.FromArgb(randomR, RandomG, RandomB);
                        SolidBrush b1 = new SolidBrush(c);
                        g.FillEllipse(b1, randomX, randomY, 20, 20);
                    }
                    break;

                case 7: for (int i = 0; i < 7; i++)
                    {
                        int randomX = r.Next(634);
                        int randomY = r.Next(321);

                        int randomR = r.Next(255);
                        int RandomG = r.Next(255);
                        int RandomB = r.Next(255);

                        //create the color
                        Color c = Color.FromArgb(randomR, RandomG, RandomB);
                        SolidBrush b1 = new SolidBrush(c);
                        g.FillEllipse(b1, randomX, randomY, 20, 20);

                    }
                    break;

                case 8: for (int i = 0; i < 8; i++)
                    {
                        int randomX = r.Next(634);
                        int randomY = r.Next(321);

                        int randomR = r.Next(255);
                        int RandomG = r.Next(255);
                        int RandomB = r.Next(255);

                        //create the color
                        Color c = Color.FromArgb(randomR, RandomG, RandomB);
                        SolidBrush b1 = new SolidBrush(c);
                        g.FillEllipse(b1, randomX, randomY, 20, 20);

                    }
                    break;

                case 9: for (int i = 0; i < 9; i++)
                    {
                        int randomX = r.Next(634);
                        int randomY = r.Next(321);

                        int randomR = r.Next(255);
                        int RandomG = r.Next(255);
                        int RandomB = r.Next(255);

                        //create the color
                        Color c = Color.FromArgb(randomR, RandomG, RandomB);
                        SolidBrush b1 = new SolidBrush(c);
                        g.FillEllipse(b1, randomX, randomY, 20, 20);

                    }
                    break;

                case 10: for (int i = 0; i < 10; i++)
                    {
                        int randomX = r.Next(634);
                        int randomY = r.Next(321);

                        int randomR = r.Next(255);
                        int RandomG = r.Next(255);
                        int RandomB = r.Next(255);

                        //create the color
                        Color c = Color.FromArgb(randomR, RandomG, RandomB);
                        SolidBrush b1 = new SolidBrush(c);
                        g.FillEllipse(b1, randomX, randomY, 20, 20);

                    }
                    break;

                case 11: for (int i = 0; i < 11; i++)
                    {
                        int randomX = r.Next(634);
                        int randomY = r.Next(321);

                        int randomR = r.Next(255);
                        int RandomG = r.Next(255);
                        int RandomB = r.Next(255);

                        //create the color
                        Color c = Color.FromArgb(randomR, RandomG, RandomB);
                        SolidBrush b1 = new SolidBrush(c);
                        g.FillEllipse(b1, randomX, randomY, 20, 20);

                    }
                    break;

                case 12: for (int i = 0; i < 12; i++)
                    {
                        int randomX = r.Next(634);
                        int randomY = r.Next(321);

                        int randomR = r.Next(255);
                        int RandomG = r.Next(255);
                        int RandomB = r.Next(255);

                        //create the color
                        Color c = Color.FromArgb(randomR, RandomG, RandomB);
                        SolidBrush b1 = new SolidBrush(c);
                        g.FillEllipse(b1, randomX, randomY, 20, 20);

                    }
                    break;

                case 13: for (int i = 0; i < 13; i++)
                    {
                        int randomX = r.Next(634);
                        int randomY = r.Next(321);

                        int randomR = r.Next(255);
                        int RandomG = r.Next(255);
                        int RandomB = r.Next(255);

                        //create the color
                        Color c = Color.FromArgb(randomR, RandomG, RandomB);
                        SolidBrush b1 = new SolidBrush(c);
                        g.FillEllipse(b1, randomX, randomY, 20, 20);

                    }
                    break;

                case 14: for (int i = 0; i < 14; i++)
                    {
                        int randomX = r.Next(634);
                        int randomY = r.Next(321);

                        int randomR = r.Next(255);
                        int RandomG = r.Next(255);
                        int RandomB = r.Next(255);

                        //create the color
                        Color c = Color.FromArgb(randomR, RandomG, RandomB);
                        SolidBrush b1 = new SolidBrush(c);
                        g.FillEllipse(b1, randomX, randomY, 20, 20);

                    }
                    break;

                case 15: for (int i = 0; i < 15; i++)
                    {
                        int randomX = r.Next(634);
                        int randomY = r.Next(321);

                        int randomR = r.Next(255);
                        int RandomG = r.Next(255);
                        int RandomB = r.Next(255);

                        //create the color
                        Color c = Color.FromArgb(randomR, RandomG, RandomB);
                        SolidBrush b1 = new SolidBrush(c);
                        g.FillEllipse(b1, randomX, randomY, 20, 20);

                    }
                    break;

                    
            }
            pnlDrawing.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
        }

        private void pnlDrawing_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(drawing, new Point(0, 0));
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                errorName.SetError(textBox1, "Name cannot be blank!");
            }
            else
            {
                errorName.Clear();
            }
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

    }
}
