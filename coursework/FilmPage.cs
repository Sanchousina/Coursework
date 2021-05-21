using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace coursework
{
    public partial class FilmPage : Form
    {
        Main main;
        Film film;
        User user;
        Admin admin;
        List<Film> films;
        public FilmPage(Film f, User u, Admin a)
        {
            admin = a;
            film = f;
            user = u;

            InitializeComponent();

            DeleteFilm.Visible = false;
            ChangeInfo.Visible = false;

            title.Text = film.film_name;
            poster.Image = ConvertImg.Base64ToImage(film.poster);
            descriptionField.Text = film.description;
            year.Text = film.year;
            country.Text = film.country;
            director.Text = film.director;
            genre.Text = film.genre;
            castField.Text = film.cast;

            if(film.age_limit == true)
            {
                age_limit.Text = "18+";
                if(user.age < 18)
                {
                    //link.Cursor = Cursors.No;     //почему не меняется?
                    link.Enabled = false;
                }
            }
            else
            {
                age_limit.Text = "none";
            }
        }

        public FilmPage(Film f,List<Film> films, Admin a)
        {
            this.films = films;
            film = f;
            admin = a;

            InitializeComponent();

            AddUser.Visible = false;

            title.Text = film.film_name;
            poster.Image = ConvertImg.Base64ToImage(film.poster);
            descriptionField.Text = film.description;
            year.Text = film.year;
            country.Text = film.country;
            director.Text = film.director;
            genre.Text = film.genre;
            castField.Text = film.cast;

            if (film.age_limit == true)
            {
                age_limit.Text = "18+";
            }
            else
            {
                age_limit.Text = "none";
            }
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void poster_Click(object sender, EventArgs e)
        {

        }

        private void FilmPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (user != null)
            {
                main = new Main(user, admin);
            }
            else if (user == null)
            {
                main = new Main(admin);
            }
            main.Show();
        }

        private void DeleteFilm_Click(object sender, EventArgs e)
        {
            film.Delete(films);
            File.WriteAllText("films.json", JsonConvert.SerializeObject(films));

            MessageBox.Show(
                    "The film was successfully deleted",
                    "Film is deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            this.Hide();
            main = new Main(admin);
            main.Show();
        }

        private void ChangeInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_film change = new Add_film(films, film, admin);
            change.Show();
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Link l = new Link();
            l.Show();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            ChooseCollection choose = new ChooseCollection(user, film, admin);
            choose.Show();
        }
    }
}
