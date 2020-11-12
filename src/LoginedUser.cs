using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApplication
{
    public class LoginedUser
    {
        private User user;

        private static LoginedUser loginedUser;

        public User User { get => user; set => user = value; }

        public static LoginedUser getInstance()
        {
            if (loginedUser == null)
            {
                loginedUser = new LoginedUser();
            }
            return loginedUser;
        }
    }
}
