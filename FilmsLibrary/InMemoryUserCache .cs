using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary
{
    interface InMemoryUserCache
    {
        IUserProfile TryGetUser(int userId);

        void SaveUser(IUserProfile userProfile);
    }

    public class InMemoryUserCache : IUserCache
    {
        public IUserProfile TryGetUser(int userId)
        {
            IUserProfile userProfile = null;
            _userCache.TryGetValue(userId, out userProfile);
            return userProfile;
        }
        public void SaveUser(IUserProfile userProfile)
        {
            if (userProfile == null)
            {
                return;
            }
            _userCache.Add(userProfile.Id, userProfile);
        }
        private Dictionary<int, IUserProfile> _userCache
    }
}
