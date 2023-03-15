using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class Form2 : Form
    {
        private readonly Form1 _parent;
        public bool readtng = false;
        Form3 form3;

        public Form2(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
            form3 = new Form3(this);

        }

        private void linkViewTerm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //either using this method to get path
            string basePath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)));

            string path = System.IO.Path.Combine(basePath, "Resources", "Terms.txt");

            //or just assign the path already like this
            // string path = "C:\Users\User\Desktop\worldskill\Session1\Session1\Resources";

            //MessageBox.Show(path);
            Process.Start("notepad.exe",path);
            readtng = true;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string fullname= txtFullName.Text;
            string password = txtPassword.Text;
            string repassword = txtRePassword.Text;
            string numFam = numFamMem.Value.ToString();
            string gender = "";
            string birthday = dtBirthday.Value.ToString("yyyy-MM-dd");

            if (rdMale.Checked == true)
            {
                gender = "1";
            }else if(rdFemale.Checked == true)
            {
                gender = "2";
            }

            if(username == "" || fullname == "" || password== "" || repassword == "" || numFam == "0" )
            {
                MessageBox.Show("fill in all input field");
            }else if (ckAgree.Checked != true)
            {
                MessageBox.Show("Please agree with the term and conditon");
            }else if(password != repassword)
            {
                MessageBox.Show("the password is not match");
            }else if(password.Length < 5 && repassword.Length < 5)
            {
                MessageBox.Show("password at least 5 characters");
            }
            else
            {
                bool isDup = DBCon.checkDuplicate(username, fullname, birthday, password, gender, numFam);

                if(isDup) {
                    MessageBox.Show("the data is duplicated");
                }
                else
                {
                    bool success = DBCon.register(username, fullname, birthday, password, gender, numFam);
                    if (success)
                    {
                        MessageBox.Show("Register successfully");
                        this.Hide();
                        form3.Closed += (s, args) => this.Close();
                        form3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Register unsuccessfully");
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void ckAgree_CheckedChanged(object sender, EventArgs e)
        {
            if(ckAgree.Checked == true)
            {
                if (readtng == false) {
                    MessageBox.Show("please read the term and conditions first");
                    ckAgree.Checked = false;
                }
            }
        }
    }
}
