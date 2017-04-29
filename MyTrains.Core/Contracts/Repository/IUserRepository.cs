using MyTrains.Core.Models;
using System.Threading.Tasks;

namespace MyTrains.Core.Contracts.Repository
{
    public interface IUserRepository
    {
        Task<User> SearchUser(string userName);
        Task<User> Login(string userName, string password);
    }
}
