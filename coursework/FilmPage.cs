using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace coursework
{
    public partial class FilmPage : Form
    {
        public FilmPage(Film film)
        {
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
    }
}
