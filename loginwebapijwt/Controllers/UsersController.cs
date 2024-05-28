using loginwebapijwt.Data.Repositories.Interfaces;
using loginwebapijwt.Models;
using loginwebapijwt.Models.DTO;
using loginwebapijwt.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace loginwebapijwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly JwtTokenService _jwtTokenService;

        public UsersController(IUserRepository userRepository, JwtTokenService jwtTokenService)
        {
            _userRepository = userRepository;
            _jwtTokenService = jwtTokenService;
        }

        [HttpGet()]
        [Authorize]
        public ActionResult<IEnumerable<UserDTO>> GetAllUsers()
        {
            var users = _userRepository.GetUsers();
            return Ok(users);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            var user = _userRepository.Login(loginModel.email, loginModel.password);
            if (user == null)
            {
                return Unauthorized(new { message = "Email ou senha invalidos." });
            }

            var token = _jwtTokenService.GenerateToken(user);

            var userDto = new UserDTO
            {
                id = user.id,
                name = user.name,
                email = user.email,
                role = user.role.ToString(),
            };

            return Ok(new { Token = token, User = userDto });
        }

    }
}