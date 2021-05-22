using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace coursework
{
    public partial class UserPage : Form
    {
        User user;
        Admin admin;
        Main main;
       /* FileStream fav;
        FileStream lat;*/

        public UserPage(User u, Admin a)
        {
            InitializeComponent();

            admin = a;
            user = u;

            username.Text = user.nickname;
            age.Text = user.age.ToString();
            gender.Text = user.gender;

            

            string file_name_fav = "fav_" + user.nickname + ".json";
            string file_name_later = "later_" + user.nickname + ".json";

            Serializer.DeserealizeFav(user, file_name_fav);
            Serializer.DeserealizeLater(user, file_name_later);


            LoadFavorites(user.favorites);
            LoadLaters(user.laters);
        }

        private void LoadFavorites(List<Film> films)
        {
            PictureBox p;
            int x = 20;
            int y = 20;
            for(int i = 0; i < films.Count; i++)
            {
                p = new PictureBox();
                p.Name = films[i].film_name;
                p.Location = new Point(x, y);
                p.Size = new Size(60, 70);
                p.Image = ConvertImg.Base64ToImage(films[i].poster);
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                /*p.Cursor = Cursors.Hand;
                p.Click += Poster_Click1;*/

                Label title = new Label();
                title.Location = new Point(x + p.Width + 20, y + p.Height/2);
                //title.Multiline = true;
                title.AutoSize = true;
                title.Text = films[i].film_name;
                title.BackColor = favorites.BackColor;
                title.BorderStyle = BorderStyle.None;
                title.ForeColor = Color.WhiteSmoke;
                float currentSize = title.Font.SizeInPoints;
                currentSize += 5;

                Button delete = new Button();
                delete.Name = films[i].film_name;
                delete.Text = "Delete";
                delete.Font = new Font(delete.Font, delete.Font.Style | FontStyle.Bold);
                delete.Size = new Size(70,30);
                delete.FlatStyle = FlatStyle.Flat;
                delete.FlatAppearance.BorderSize = 0; 
                delete.ForeColor = Color.WhiteSmoke;
                delete.BackColor = Color.FromArgb(209, 4, 4);
                delete.Location = new Point(230, y);
                delete.Cursor = Cursors.Hand;
                delete.Click += DeleteFav_Click;

                favorites.Controls.Add(p);
                favorites.Controls.Add(title);
                favorites.Controls.Add(delete);

                y += p.Height + 40;
            }
        }

        private void DeleteFav_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Film f = Film.Search(user.favorites, b.Name);

            user.favorites.Remove(f);
            string file_name_fav = "fav_" + user.nickname + ".json";

            File.WriteAllText(file_name_fav, JsonConvert.SerializeObject(user.favorites));

            MessageBox.Show(
                    "The film was successfully deleted",
                    "Film is deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            favorites.Controls.Clear();
            LoadFavorites(user.favorites);
        }

        private void LoadLaters(List<Film> films)
        {
            PictureBox p;
            int x = 20;
            int y = 20;
            for (int i = 0; i < films.Count; i++)
            {
                p = new PictureBox();
                p.Name = films[i].film_name;
                p.Location = new Point(x, y);
                p.Size = new Size(60, 70);
                p.Image = ConvertImg.Base64ToImage(films[i].poster);
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                /*p.Cursor = Cursors.Hand;
                p.Click += Poster_Click1;*/

                Label title = new Label();
                title.Location = new Point(x + p.Width + 20, y);
                //title.Multiline = true;
                title.AutoSize = true;
                title.Text = films[i].film_name;
                title.BackColor = later.BackColor;
                title.BorderStyle = BorderStyle.None;
                title.ForeColor = Color.WhiteSmoke;
                float currentSize = title.Font.SizeInPoints;
                currentSize += 5;

                Button delete = new Button();
                delete.Name = films[i].film_name;
                delete.Text = "Delete";
                delete.Font = new Font(delete.Font, delete.Font.Style | FontStyle.Bold);
                delete.Size = new Size(70, 30);
                delete.FlatStyle = FlatStyle.Flat;
                delete.FlatAppearance.BorderSize = 0;
                delete.ForeColor = Color.WhiteSmoke;
                delete.BackColor = Color.FromArgb(209, 4, 4);
                delete.Location = new Point(230, y + p.Height / 2);
                delete.Cursor = Cursors.Hand;
                delete.Click += DeleteLater_Click;

                later.Controls.Add(p);
                later.Controls.Add(title);
                later.Controls.Add(delete);

                y += p.Height + 40;
            }
        }

        private void DeleteLater_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Film f = Film.Search(user.laters, b.Name);

            user.laters.Remove(f);
            string file_name_later = "later_" + user.nickname + ".json";

            File.WriteAllText(file_name_later, JsonConvert.SerializeObject(user.laters));

            MessageBox.Show(
                    "The film was successfully deleted",
                    "Film is deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            later.Controls.Clear();
            LoadLaters(user.laters);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            main = new Main(user, admin);
            main.Show();
        }

        private void UserPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
