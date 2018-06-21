using System.Threading.Tasks;

namespace FriendOrganiser.UI.ViewModel
{
    public interface IFriendDetailViewModel
    {
        Task LoadAsync(int friendId);
    }
}