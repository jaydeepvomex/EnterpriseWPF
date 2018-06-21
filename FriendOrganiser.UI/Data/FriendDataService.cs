using FriendOrganiser.DataAccess;
using FriendOrganiser.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FriendOrganiser.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrganiserDbContext> _contextCreator;

        public FriendDataService(Func<FriendOrganiserDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<Friend> GetByIdAsync(int friendId)
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking().SingleAsync(x => x.Id == friendId);
            }
        }
    }
}
