using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary
{
    public class NewUser
    {
        public string Nickname { get; private set; }
        public string Email { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public NewUser(string nickname, string email, string name, string surname)
        {
            Nickname = nickname;
            Email = email;
            Name = name;
            Surname = surname;
        }
      




    }
}
