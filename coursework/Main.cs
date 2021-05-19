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
        Add_film add;
        UserPage user_page;
        User user;
    
        public Main(User u = null)
        {
            if(u != null)
            {
                user = u;
                user_page = new UserPage(user);
            }
            

            InitializeComponent();

            Login.admin.films = new List<Film>();
           
            Serializer.DeserealizeFilms();

            LoadCatalog(Login.admin.films) ;
            
            add = new Add_film();
            
            if (Login.IsItAdmin == false)
            {
                AddFilm.Visible = false;
            }
        }

        private void Poster_Click1(object sender, EventArgs e)
        {
            this.Hide();
            PictureBox poster = (PictureBox)sender;
            FilmPage film_page = new FilmPage(Film.Search(Login.admin.films, poster.Name), user);
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
                    y = y + 200 + 60;
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
