using System;
namespace postgresAPI.Services
{
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using HealthCareABApi.Data;
    using HealthCareABApi.Models;
    using postgresAPI.Data;
    using postgresAPI.Models;

    namespace HealthCareABApi.Services
    {
        public class UserService
        {
            private readonly ApplicationDbContext _context;

            public UserService(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<bool> ExistsByUsernameAsync(string username)
            {
                return await _context.Users.AnyAsync(u => u.Username == username);
            }

            public async Task<User> GetUserByUsernameAsync(string username)
            {
                return await _context.Users
                    .FirstOrDefaultAsync(u => u.Username == username);
            }

            public async Task CreateUserAsync(User user)
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
            }

            // Password hashing methods remain the same
            public string HashPassword(string password)
            {
                return BCrypt.Net.BCrypt.HashPassword(password);
            }

            public bool VerifyPassword(string enteredPassword, string storedHash)
            {
                return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);
            }
        }
    }

}

