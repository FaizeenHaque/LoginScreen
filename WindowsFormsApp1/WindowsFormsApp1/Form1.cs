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

        private void label1_Click(object sender, EventArgs e)
        {
            //Title
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Username
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Password
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {
            //Exit button
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sign in button

            if (Username_fill.Text == "Admin" && Password_fill.Text == "Admin")
            {
                LoggedInpage.Visible = true;
                Logged_in.Visible = true;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            //Terms and Conditions button
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Username_textbox
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //password textbox
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Terms check box
            if (TermsCheck.Checked == false)
            {
                SignIn.Enabled = false;

            } else
            {
                SignIn.Enabled = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //Logged in text
            
                
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Logged in panel
            
        }


    }
}
