using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Enums;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUser()
        {
            var user = await _context.Users
            .OrderByDescending(u => u.Orders.Count)
            .FirstOrDefaultAsync();

            return user;
        }

        public async Task<List<User>> GetUsers()
        {
            var users = await _context.Users.Where(i => i.Status == UserStatus.Inactive).ToListAsync();
            if (users == null || users.Count < 1)
            {
                return null;
            }

            return users;
        }
    }
}