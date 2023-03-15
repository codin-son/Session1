using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Session1
{
    public partial class Form1 : Form
    {
        Form2 form2;
        Form3 form3;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            form3 = new Form3(this);
        }

        private void ckShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = ckShowPassword.Checked ? '\0' : '*';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtEmployee.Text != string.Empty && txtUser.Text != string.Empty)
            {
                MessageBox.Show("please fill in only one username input");
            }
            else
            {
                string role = txtUser.Text == "" ? "1" : "2";
                //1 for employee, 2 for user

                string username = role == "1" ? txtEmployee.Text : txtUser.Text;

                int success = DBCon.Login(username, txtPassword.Text, role);

                if (success == 1)
                {
                    this.Hide();
                    form3.Closed += (s, args) => this.Close();
                    form3.Show();
                }
            }

        }

        private void ckKeepSignIn_CheckedChanged(object sender, EventArgs e)
        {
            if(ckKeepSignIn.Checked == true)
            {
                Properties.Settings.Default.username = txtUser.Text;
                Properties.Settings.Default.password = txtPassword.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            Form3 fom3 = new Form3();
            if (Properties.Settings.Default.username != string.Empty)
            {
                string isEmp = DBCon.Login(Properties.Settings.Default.username, Properties.Settings.Default.password);
                if (isEmp != string.Empty)
                {
                    this.Hide();
                    fom3.Closed += (s, args) => this.Close();
                    fom3.Show();
                }
            }
            

        }

        private void txtEmployee_KeyUp(object sender, KeyEventArgs e)
        {
            if(ckKeepSignIn.Checked == true)
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.username = txtEmployee.Text;
                Properties.Settings.Default.Save();
            }

        }

        private void txtEmployee_TextAlignChanged(object sender, EventArgs e)
        {
            //takguna
        }

        private void txtEmployee_TextChanged(object sender, EventArgs e)
        {
            //takguna
        }

        private void txtEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            //takguna
        }

        private void txtUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (ckKeepSignIn.Checked == true)
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.username = txtEmployee.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (ckKeepSignIn.Checked == true)
            {
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.password = txtPassword.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}
