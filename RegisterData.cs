using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class RegisterData
    {
        public string username;
        public string password;
        public string lastname;
        public string name;

        public RegisterData(string username, string password, string lastname, string name)
        {
            this.username = username;
            this.password = password;
            this.lastname = lastname;
            this.name = name;
        }
    }
}
