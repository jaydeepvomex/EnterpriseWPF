using System.Collections.Generic;
using System.Threading.Tasks;
using FriendOrganiser.Model;

namespace FriendOrganiser.UI.Data
{
    public interface IFriendLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetFriendLookupAsync();
    }
}