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
    
        public Main(User u)
        {
            user = u;
            user_page = new UserPage(user);
            
            InitializeComponent();

            //Login.admin.films = new List<Film>();
            collection = new FilmCollection();          
            Serializer.DeserealizeFilms(collection.films);
            LoadCatalog(collection) ;          

            /*if (Login.IsItAdmin == false)
            {
                AddFilm.Visible = false;
            }*/

            AddFilm.Visible = false;
        }

        public Main(Admin a)
        {
            admin = a;

            InitializeComponent();

            add = new Add_film(collection.films, admin);
        }

        private void Poster_Click1(object sender, EventArgs e)
        {
            this.Hide();
            PictureBox poster = (PictureBox)sender;
            //FilmPage film_page = new FilmPage(Film.Search(collection.films, poster.Name), user);
            if (admin == null)
            {
                film_page = new FilmPage(Film.Search(collection.films, poster.Name), user);
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

        private void LoadCatalog(FilmCollection films)
        {
            PictureBox p;
            int x = 40;
            int y = 40;
            for(int i = 0; i < collection.films.Count; i++)
            {
                if(x == 700)
                {
                    x = 40;
                    y = y + 200 + 60;
                }
                p = new PictureBox();
                p.Name = collection.films[i].film_name;
                p.Location = new Point(x,y);
                p.Size = new Size(180, 200);
                p.Image = ConvertImg.Base64ToImage(collection.films[i].poster);
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Cursor = Cursors.Hand;
                p.Click += Poster_Click1;

                TextBox title = new TextBox();
                title.Location = new Point(x, y + p.Height + 10);
                title.Multiline = true;
                title.Size = new Size(180, 25);
                title.Text = collection.films[i].film_name;
                title.BackColor = catalog.BackColor;
                title.BorderStyle = BorderStyle.None;
                title.ForeColor = Color.WhiteSmoke;
                float currentSize = title.Font.SizeInPoints;
                currentSize += 3;

                catalog.Controls.Add(p);
                catalog.Controls.Add(title);

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
            user_page.Show();
        }
    }
}
