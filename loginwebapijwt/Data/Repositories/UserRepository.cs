using loginwebapijwt.Data.Repositories.Interfaces;
using loginwebapijwt.Models;
using loginwebapijwt.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace loginwebapijwt.Data.Repositories
{
    public class UserRepository : IUserRepository
    { 

    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }


        public IEnumerable<UserDTO> GetUsers()
        {
            return _context.Users.Select(user => new UserDTO
            {
                id = user.id,
                name = user.name,
                email = user.email,
                role = user.role.ToString()
            }).ToList();
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.email == email);
        }

        public User Login(string email, string password)
        {
            var user = GetUserByEmail(email);
            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.password))
            {

                return user;
            }
            return null;
        }
    }
}