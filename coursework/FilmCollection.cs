using System;
using System.Collections.Generic;
using System.Text;

namespace coursework
{
    public class FilmCollection
    {
        public List<Film> films { get; set; }

        public FilmCollection()
        {
            films = new List<Film>();
        }
    }
}
