using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace coursework
{
    public class Film
    {
        public string film_name;
        public string year;
        public string genre;   //может массив жанров? или оставить один
        public string country;
        public string director;
        public bool age_limit;
        public string description;
        public string cast;
        public int rating;
        public string poster; //base64

        public Film(string name, int year, string genre, string country, 
            string director, bool age_limit, string description, string cast, string poster) 
        {
            film_name = name;
            this.year = year.ToString();
            this.genre = genre;
            this.country = country;
            this.director = director;
            this.age_limit = age_limit;
            this.description = description;
            this.cast = cast;
            this.poster = poster;
        }

       public static Film Search(List<Film> films, string title)
       {
            Film res = films[0];
            for(int i = 0; i < films.Count; i++)
            {
                if(films[i].film_name == title)
                {
                    res = films[i];
                    break;
                }
            }
            return res;
       }

        public void Delete(List<Film> films)
        {
            films.Remove(this);
        }
    }
}
