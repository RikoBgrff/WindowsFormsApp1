using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void CreateLabel()
        {
            Label label = new Label();
            Image image = Properties.Resources._2021_Jeep_Grand_Cherokee_hero_600x400;
            label.Size = new Size(image.Width, image.Height);
            label.Image = image;
            this.Controls.Add(label);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(usernameTxtbx.Text == "")
            {
                usernameTxtbx.Text = "username";
            }
        }




        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxtbx.Text != "admin")
            {
                this.label1.Text = "username is incorrect";
            }
            if (passwordTxtbx.Text != "admin")
            {
                this.label2.Text = "password is incorrect";
            }
            if (usernameTxtbx.Text == "admin")
            {
                if (passwordTxtbx.Text == "admin")
                {
                    MessageBox.Show("You Logged In Sucsessfully");
                }
            }
            
            if(usernameTxtbx.Text != "admin")
            {
                if(passwordTxtbx.Text == "admin")
                {
                    this.label1.Text = "username is incorrect";
                }
            }
           
            if(usernameTxtbx.Text == "admin")
            {
                if(passwordTxtbx.Text != "admin")
                {
                    this.label2.Text = "password is incorrect";
                }
            }
          
            if(usernameTxtbx.Text != "admin")
            {
                if(passwordTxtbx.Text != "admin")
                {
                    
                    this.label1.Text = "username is incorrect";
                    this.label2.Text = "password is incorrect";

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTxtbx_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxtbx.Text == "")
            {
                passwordTxtbx.Text = "password";
            }
        }
    }
}