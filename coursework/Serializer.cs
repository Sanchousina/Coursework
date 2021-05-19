﻿using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace coursework
{
    public static class Serializer
    {
        public static void DeserealizeFilms(FilmCollection collection)
        {
            JsonTextReader reader = new JsonTextReader(new StreamReader("films.json"));
            reader.SupportMultipleContent = true;
            while (true)
            {
                if (!reader.Read())
                {
                    break;
                }
                JsonSerializer serializer = new JsonSerializer();
                collection.films = serializer.Deserialize<List<Film>>(reader);
                /*Film newFilm = serializer.Deserialize<Film>(reader);
                Login.admin.films.Add(newFilm);*/
            }
            reader.Close();
        }

        public static void DeserealizeUsers(List<User> users)
        {
            JsonTextReader reader = new JsonTextReader(new StreamReader("users.json"));
            reader.SupportMultipleContent = true;
            while (true)
            {
                if (!reader.Read())
                {
                    break;
                }
                JsonSerializer serializer = new JsonSerializer();
                User newUser = serializer.Deserialize<User>(reader);
                users.Add(newUser);
            }
        }
        
        public static void Serialize(string file_name, Object obj)
        {
            File.AppendAllText(file_name, JsonConvert.SerializeObject(obj));
        }
    }
}
