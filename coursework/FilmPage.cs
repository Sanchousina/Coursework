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
        public FilmPage(Film f)
        {
            film = f;

            InitializeComponent();

            if (Login.IsItAdmin == false)
            {
                DeleteFilm.Visible = false;
                ChangeInfo.Visible = false;
            }

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
            main = new Main();
            main.Show();
        }

        private void DeleteFilm_Click(object sender, EventArgs e)
        {
            film.Delete(Login.admin.films);
            File.WriteAllText("films.json", JsonConvert.SerializeObject(Login.admin.films));

            MessageBox.Show(
                    "The film was successfully deleted",
                    "Film is deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            this.Hide();
            main = new Main();
            main.Show();
        }

        private void ChangeInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_film change = new Add_film(film);
            change.Show();
        }
    }
}
