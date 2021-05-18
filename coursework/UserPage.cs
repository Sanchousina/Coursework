using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace coursework
{
    public partial class UserPage : Form
    {
        User user;
        public UserPage(User u)
        {
            InitializeComponent();

            user = u;

            label1.Text = "Hello Dear " + user.nickname;
        }
    }
}
