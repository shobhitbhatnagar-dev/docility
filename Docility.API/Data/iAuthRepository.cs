using System.Threading.Tasks;
using Docility.API.Models;

namespace Docility.API.Data
{
    public interface iAuthRepository
    {
        Task<User> Register(User user, string password, string role);

        Task<User> Login(string username, string password);

        Task<bool> UserExsists(string username);
        
    }
}