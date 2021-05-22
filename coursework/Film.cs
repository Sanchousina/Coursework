﻿using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace coursework
{
    public class Film
    {
        public string film_name;
        public int year;
        public string genre;   
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
            this.year = year;
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
            Film res = null;
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

        
        public static List<Film> Filter(List<Film> films, List<string> genres,
            string country, int from, int to, bool age_limit)
        {
            List<Film> res = new List<Film>();
            bool check = false;
            for(int i = 0; i < films.Count; i++)
            {  
                if(genres.Count == 0)
                {
                    check = true;
                }
                else
                {
                    for (int j = 0; j < genres.Count; j++)
                    {
                        if (films[i].genre == genres[j])
                        {
                            check = true;
                            break;
                        }
                    }
                }
                if(country != "Any")
                {
                    if (films[i].country != country)
                    {
                        check = false;
                    }
                }
                if(films[i].year < from || films[i].year > to)
                {
                    check = false;
                }
                if(films[i].age_limit != age_limit)
                {
                    check = false;
                }
                if(check == true)
                {
                    res.Add(films[i]);
                    check = false;
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
