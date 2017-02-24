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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                errorUsername.SetError(txtUsername, "Username cannot be blank!");
            }
            else if (txtUsername.Text != "designer")
            {
                errorUsername.SetError(txtUsername, "Wrong Username");
            }

            if (txtPassword.Text.Length == 0)
            {
                errorPassword.SetError(txtPassword, "Password cannot be blank!");
            }
            else if (txtPassword.Text != "123")
            {
                errorPassword.SetError(txtPassword, "Wrong Password");
            }

            if (txtName.Text.Length == 0)
            {
                errorName.SetError(txtName, "Name and Surname cannot be blank!");
            }
            else if (!txtName.Text.All(Char.IsLetter))
            {
                errorName.SetError(txtName,"Name must only contain letters!");
            }

            if (txtUsername.Text == "designer" && txtPassword.Text == "123" && txtName.Text.All(Char.IsLetter))
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Text = txtName.Text;
                f2.ShowDialog();
            }

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                errorName.SetError(txtName, "Name and Surname cannot be blank!");
            }
            else
            {
                errorName.Clear();
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                errorUsername.SetError(txtUsername, "Username cannot be blank!");
            }
            else
            {
                errorUsername.Clear();
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                errorPassword.SetError(txtPassword, "Password cannot be blank!");
            }
            else
            {
                errorPassword.Clear();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.BackColor = System.Drawing.Color.Orange;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.BackColor = System.Drawing.Color.Orange;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.BackColor = System.Drawing.Color.Orange;
        }

      


    }   
}
