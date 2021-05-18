using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace coursework
{
    public partial class Add_film : Form
    {
        Main main;
        Film film;
        public Add_film(Film f = null)
        {
            InitializeComponent();

            if(f != null)
            {
                film = f;

                filmNameField.Text = film.film_name;
                releaseYear.Value = Convert.ToInt32(film.year);
                countryField.Text = film.country;
                directorField.Text = film.director;
                genreField.Text = film.genre;
                castField.Text = film.cast;
                descriptionField.Text = film.description;
                picture.Image = ConvertImg.Base64ToImage(film.poster);

                if(film.age_limit == true)
                {
                    age_limit18.Checked = true;
                }
                else
                {
                    age_limit_none.Checked = true;
                }

                add_button.Visible = false;
                onloadPoster.Visible = false;
            }
            else
            {
                saveChanges.Visible = false;
            }          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void onloadPoster_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picture.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show(
                            "Unable to open the selected file",
                            "Picture error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string name = filmNameField.Text;
            int year = (int)releaseYear.Value;
            string country = countryField.Text;
            string director = directorField.Text;
            string genre = genreField.Text;
            bool age_limit = false;
            if (age_limit18.Checked)
            {
                age_limit = true;
            }
            if (age_limit_none.Checked)
            {
                age_limit = false;
            }
            string cast = castField.Text;
            string description = descriptionField.Text;           
            string poster = ConvertImg.ImageToBase64(picture.Image, ImageFormat.Bmp);
            
            Film film = new Film(name, year, genre, country, director, age_limit, description, cast, poster);
            Serializer.Serialize("films.json", film);

            MessageBox.Show(
                            "The movie was added successfully",
                            "Well done!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );

            this.Hide();
            main = new Main();
            main.Show();
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            film.film_name = filmNameField.Text;
            film.year = releaseYear.Value.ToString();
            film.country = countryField.Text;
            film.director = directorField.Text;
            film.genre = genreField.Text;
            film.cast = castField.Text;
            film.description = descriptionField.Text;
            //film.poster = ConvertImg.ImageToBase64(picture.Image, ImageFormat.Bmp);
            if (age_limit18.Checked)
            {
                film.age_limit = true;
            }
            else if(age_limit_none.Checked)
            {
                film.age_limit = false;
            }

            MessageBox.Show(
                            "The changes are saved",
                            "Updated info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );

            this.Hide();
            FilmPage update = new FilmPage(film);
            update.Show();
        }
    }
}
