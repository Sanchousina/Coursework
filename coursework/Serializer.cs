using System;
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

        public static void DeserealizeFav(User user, string file_name)
        {
            StreamReader str;
            FileStream fav;
            try
            {
                using(str = new StreamReader(file_name))
                {
                    JsonTextReader reader = new JsonTextReader(str);
                    reader.SupportMultipleContent = true;
                    while (true)
                    {
                        if (!reader.Read())
                        {
                            break;
                        }
                        JsonSerializer serializer = new JsonSerializer();
                        user.favorites = serializer.Deserialize<List<Film>>(reader);
                        /*Film newFilm = serializer.Deserialize<Film>(reader);
                        Login.admin.films.Add(newFilm);*/
                    }
                    reader.Close();
                }
            }
            catch (FileNotFoundException e)
            {
                fav = File.Create(file_name);
                fav.Close();
            }
        }

        public static void DeserealizeLater(User user, string file_name)
        {
            StreamReader str;
            FileStream lat;
            try
            {
                using (str = new StreamReader(file_name))
                {
                    JsonTextReader reader = new JsonTextReader(str);
                    reader.SupportMultipleContent = true;
                    while (true)
                    {
                        if (!reader.Read())
                        {
                            break;
                        }
                        JsonSerializer serializer = new JsonSerializer();
                        user.laters = serializer.Deserialize<List<Film>>(reader);
                        /*Film newFilm = serializer.Deserialize<Film>(reader);
                        Login.admin.films.Add(newFilm);*/
                    }
                    reader.Close();
                }
            }
            catch(FileNotFoundException e)
            {
                lat = File.Create(file_name);
                lat.Close();
            }        
        }

        public static void DeserealizeUsers(Admin admin)
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
                admin.users = serializer.Deserialize<List<User>>(reader);
                /*User newUser = serializer.Deserialize<User>(reader);
                users.Add(newUser);*/
            }

            reader.Close();
        }
        
        public static void Serialize(string file_name, Object obj)
        {
            File.WriteAllText(file_name, JsonConvert.SerializeObject(obj));
        }
    }
}
