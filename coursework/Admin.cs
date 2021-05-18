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

        public void Search(string nickname, string password, out User user, out string res)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].nickname == nickname)
                {
                    if (users[i].password == password)
                    {
                        user = users[i];
                        res = "found";
                        return;
                    }
                    else
                    {
                        user = users[i];
                        res = "wrong password";
                        return;
                    }
                }
            }
            res = "not found";
            user = null;
        }

        public bool CheckAdmin(string nickname, string password)
        {
            return (nickname == admin_name && password == admin_password);
        }
    }
}
