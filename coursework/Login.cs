using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace coursework
{
    public partial class Login : Form
    {
        //public static Admin admin;
        Admin admin;
        Main main;
        User user;

       // public static bool IsItAdmin;
        public Login()
        {
            InitializeComponent();

            admin = new Admin();

            admin.users = new List<User>();
            Serializer.DeserealizeUsers(admin);
            
            nameField.Text = "nickname";
            nameField.ForeColor = Color.Gray;
            passField.Text = "password";
            passField.ForeColor = Color.Gray;
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Width, this.nameField.Height);
        }

        private void nameField_Enter(object sender, EventArgs e)
        {
            if(nameField.Text == "nickname")
            {
                nameField.Text = "";
                nameField.ForeColor = Color.Black;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if(passField.Text == "password")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if(passField.Text == "")
            {
                passField.Text = "password";
                passField.ForeColor = Color.Gray;
            }
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            if(nameField.Text == "")
            {
                nameField.Text = "nickname";
                nameField.ForeColor = Color.Gray;
            }
        }

        private void registLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration(admin);
            registration.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string nickname = nameField.Text;
            string password = passField.Text;

            if(nickname == "" || password == "")
            {
                MessageBox.Show(
                    "Check if all data has been entered",
                    "Data error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if(nickname != "" || password != "")
            {
                if(nickname == "admin")
                {
                    if(admin.CheckAdmin(nickname, password))
                    {
                        //IsItAdmin = true;
                        this.Hide();
                        main = new Main(admin);
                        main.Show();
                    }
                }
                else
                {
                    
                    string res;
                    admin.Search(nickname, password, out user, out res);

                    if (res == "found" && user != null)
                    {
                        //IsItAdmin = false;
                        this.Hide();
                        main = new Main(user, admin);
                        main.Show();
                    }
                    else if (res == "wrong password")
                    {
                        MessageBox.Show(
                            "You entered a wrong password.Try again!",
                            "Data error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                    else if (res == "not found" && user == null)
                    {
                        MessageBox.Show(
                            "This account does not exist. Please, register",
                            "Data error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                }            
            }         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
