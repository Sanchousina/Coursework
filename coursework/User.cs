using System;
using System.Collections.Generic;
using System.Text;

namespace coursework
{
    public class User
    {
        public string nickname { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string email { get; set; }

        public List<Film> favorites { get; set; }
        public List<Film> laters { get; set; }

        public User(string nickname, string password, string email, int age, string gender)
        {
            this.nickname = nickname;
            this.password = password;
            this.email = email;
            this.age = age;
            this.gender = gender;

            favorites = new List<Film>();
            laters = new List<Film>();
        }

        
    }
}
