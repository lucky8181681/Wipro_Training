using Microsoft.AspNetCore.Mvc;
using Day10_SecureAuthAPI.Models;
using Day10_SecureAuthAPI.Helpers;

namespace Day10_SecureAuthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        static List<User> users = new List<User>();

        // 🔹 Register (US1 + US2)
        [HttpPost("register")]
        public IActionResult Register(string username, string password)
        {
            var hash = PasswordHelper.HashPassword(password);

            users.Add(new User
            {
                Username = username,
                PasswordHash = hash
            });

            return Ok("User registered successfully");
        }

        // 🔹 Login (US3)
        [HttpPost("login")]
        public IActionResult Login(string username, string password)
        {
            var user = users.FirstOrDefault(u => u.Username == username);

            if (user == null)
                return NotFound("User not found");

            var hash = PasswordHelper.HashPassword(password);

            if (hash == user.PasswordHash)
                return Ok("Login successful");
            else
                return Unauthorized("Invalid password");
        }
    }
}