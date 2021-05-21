using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace coursework
{
    public partial class ChooseCollection : Form
    {
        User user;
        Film film;
        Admin admin;
        public ChooseCollection(User u, Film f, Admin a)
        {
            InitializeComponent();

            admin = a;
            user = u;
            film = f;
        }

        private void AddToFav_Click(object sender, EventArgs e)
        {
            user.favorites.Add(film);
            string file_name = "fav_" + user.nickname + ".json";
            File.WriteAllText(file_name, JsonConvert.SerializeObject(user.favorites));

            MessageBox.Show(
                           "The movie was added successfully",
                           "Well done!",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information
                           );

            this.Hide();
        }

        private void AddToLater_Click(object sender, EventArgs e)
        {
            user.laters.Add(film);
            string file_name = "later_" + user.nickname + ".json";
            File.WriteAllText(file_name, JsonConvert.SerializeObject(admin.users));

            MessageBox.Show(
                           "The movie was added successfully",
                           "Well done!",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information
                           );

            this.Hide();
        }
    }
}
