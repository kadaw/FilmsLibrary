using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary
{
   public class UserProfile
    {
        public UserProfile(int id, string name)
        {
            id = id;
            name = name;
        }
        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}
