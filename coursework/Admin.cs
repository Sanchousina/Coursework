using System;
using System.Collections.Generic;
using System.Text;

namespace coursework
{
    public class Admin
    {
        private string admin_name = "admin";
        private string admin_password = "password";

        public List<Film> films;
        public List<User> users;

        public string Search(string nickname, string password)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].nickname == nickname)
                {
                    if (users[i].password == password)
                    {
                        return "found";
                    }
                    else
                    {
                        return "wrong password";
                    }
                }
            }
            return "not found";
        }

        public bool CheckAdmin(string nickname, string password)
        {
            return (nickname == admin_name && password == admin_password);
        }
    }
}
