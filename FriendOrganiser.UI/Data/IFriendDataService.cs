using System.Collections.Generic;
using FriendOrganiser.Model;
using System.Threading.Tasks;

namespace FriendOrganiser.UI.Data
{
    public interface IFriendDataService
    {
        Task<Friend> GetByIdAsync(int friendId);
    }
}