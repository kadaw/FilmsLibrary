using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary
{
  
        public interface IUserCache
        {
           UserProfile TryGetUser(int userId);

            void SaveUser(UserProfile userProfile);
        }

    
}
