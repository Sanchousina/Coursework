using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace coursework
{
    public partial class Registration : Form
    {
        Admin admin;
        public Registration(Admin a)
        {
            InitializeComponent();

            admin = a;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Regist_Click(object sender, EventArgs e)
        {
            string nickname = nameField.Text;
            string password = passField.Text;
            string email = emailField.Text;
            int age = Convert.ToInt32(ageField.Value);
            string gender = genderField.Text;

            if(password.Length < 5)
            {
                MessageBox.Show(
                    "The length of the parrsword should be more than 5 characters. Try again",
                    "Data error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (nickname == "" || password == "" ||
                email == "" || age == 0 || gender == "")
                {
                    MessageBox.Show(
                        "Check if all data has been entered",
                        "Data error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                if (nickname != "" && password != "" &&
                    email != "" && age != 0 && gender != "")
                {
                    User user = new User(nickname, password, email, age, gender);
                    admin.users.Add(user);
                    Serializer.Serialize("users.json", admin.users);

                    MessageBox.Show(
                        "You have been successfully registered",
                        "Congratulations",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
    }
}
