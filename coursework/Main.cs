using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Drawing;
using System.Windows.Forms;

namespace coursework
{
    public partial class Main : Form
    {
        FilmCollection collection;
        Add_film add;
        UserPage user_page;
        FilmPage film_page;
        User user;
        Admin admin;
    
        public Main(User u, Admin a)
        {
            admin = a;
            user = u;
            
            InitializeComponent();

            collection = new FilmCollection();          
            Serializer.DeserealizeFilms(collection);
            LoadCatalog(collection.films) ;          

            AddFilm.Visible = false;
        }

        public Main(Admin a)
        {
            admin = a;

            InitializeComponent();

            userPage.Enabled = false;

            collection = new FilmCollection();
            Serializer.DeserealizeFilms(collection);
            LoadCatalog(collection.films);

            add = new Add_film(collection, admin);
        }

        private void Poster_Click1(object sender, EventArgs e)
        {
            this.Hide();
            PictureBox poster = (PictureBox)sender;
            //FilmPage film_page = new FilmPage(Film.Search(collection.films, poster.Name), user);
            if (user != null)
            {
                film_page = new FilmPage(Film.Search(collection.films, poster.Name), user, admin);
            }
            else if(user == null)
            {
                film_page = new FilmPage(Film.Search(collection.films, poster.Name),collection.films, admin);
            }         
            film_page.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadCatalog(List<Film> films)
        {
            PictureBox p;
            int x = 40;
            int y = 40;
            for(int i = 0; i < films.Count; i++)
            {
                if(x == 700)
                {
                    x = 40;
                    y = y + 200 + 60 + 10;
                }
                p = new PictureBox();
                p.Name = films[i].film_name;
                p.Location = new Point(x,y);
                p.Size = new Size(180, 200);
                p.Image = ConvertImg.Base64ToImage(films[i].poster);
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Cursor = Cursors.Hand;
                p.Click += Poster_Click1;

                TextBox title = new TextBox();
                title.Location = new Point(x, y + p.Height + 10);
                title.Multiline = true;
                title.Size = new Size(180, 25);
                title.Text = films[i].film_name;
                title.BackColor = catalog.BackColor;
                title.BorderStyle = BorderStyle.None;
                title.ForeColor = Color.WhiteSmoke;
                float currentSize = title.Font.SizeInPoints;
                currentSize += 5;
                title.Font = new Font(title.Font.Name, currentSize, title.Font.Unit);

                Label info = new Label();
                info.Location = new Point(x, y + p.Height + 40);
                info.AutoSize = true;
                info.Text = films[i].country + ", " + films[i].year + ", " + films[i].genre;
                info.BackColor = catalog.BackColor;
                info.BorderStyle = BorderStyle.None;
                info.ForeColor = Color.WhiteSmoke;

                catalog.Controls.Add(p);
                catalog.Controls.Add(title);
                catalog.Controls.Add(info);

                x += p.Width+40;
            }
        }

        private void AddFilm_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            add.Show();
        }

        private void userPage_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            user_page = new UserPage(user, admin);
            user_page.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string f = searchField.Text;
            if(f == "")
            {
                catalog.Controls.Clear();
                LoadCatalog(collection.films);
            }
            else
            {
                List<Film> search_film = new List<Film>();
                Film film = Film.Search(collection.films, f);
                if (film != null)
                {
                    search_film.Add(film);
                    catalog.Controls.Clear();
                    LoadCatalog(search_film);
                }
                else
                {
                    catalog.Controls.Clear();

                    Label message = new Label();
                    message.Location = new Point(40, 40);
                    message.AutoSize = true;
                    message.Text = "no results were found for your search";
                    message.BackColor = catalog.BackColor;
                    message.BorderStyle = BorderStyle.None;
                    message.ForeColor = Color.WhiteSmoke;
                    float currentSize = message.Font.SizeInPoints;
                    currentSize += 15;
                    message.Font = new Font(message.Font.Name, currentSize, message.Font.Unit);

                    catalog.Controls.Add(message);
                }
            }
        }

        private void filter_Click(object sender, EventArgs e)
        {
            List<string> genres = new List<string>();
            if (drama.Checked)
            {
                genres.Add("drama");
            }
            if (comedy.Checked)
            {
                genres.Add("comedy");
            }
            if (horror.Checked)
            {
                genres.Add("horror");
            }
            if (detective.Checked)
            {
                genres.Add("detective");
            }
            if (romance.Checked)
            {
                genres.Add("romance");
            }
            if (fantasy.Checked)
            {
                genres.Add("fantasy");
            }
            if (family.Checked)
            {
                genres.Add("family");
            }
            if (history.Checked)
            {
                genres.Add("history");
            }

            string country = "";
            if (USA.Checked)
            {
                country = "USA";
            }
            if (France.Checked)
            {
                country = "France";
            }
            if (GreatBritain.Checked)
            {
                country = "Great Britain";
            }
            if (Italy.Checked)
            {
                country = "Italy";
            }
            if (SouthKorea.Checked)
            {
                country = "South Korea";
            }
            if (Japan.Checked)
            {
                country = "Japan";
            }
            if (Any.Checked)
            {
                country = "Any";
            }

            bool limit = false;
            if (age_limit.Text == "18+")
            {
                limit = true;
            }
            if (age_limit.Text == "none")
            {
                limit = false;
            }

            string release_year = year.Value.ToString();

            List<Film> result = Film.Filter(collection.films, genres, country, release_year, limit);

            catalog.Controls.Clear();

            if(result.Count == 0)
            {
                Label message = new Label();
                message.Location = new Point(40, 40);
                message.AutoSize = true;
                message.Text = "no results were found for your search";
                message.BackColor = catalog.BackColor;
                message.BorderStyle = BorderStyle.None;
                message.ForeColor = Color.WhiteSmoke;
                float currentSize = message.Font.SizeInPoints;
                currentSize += 15;
                message.Font = new Font(message.Font.Name, currentSize, message.Font.Unit);

                catalog.Controls.Add(message);
            }
            else
            {
                LoadCatalog(result);
            }
        }


    }
}
