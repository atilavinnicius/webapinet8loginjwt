using loginwebapijwt.Models;
using loginwebapijwt.Models.DTO;

namespace loginwebapijwt.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<UserDTO> GetUsers();
        User GetUserByEmail(string email);
        User Login(string email, string password);
    }
}
