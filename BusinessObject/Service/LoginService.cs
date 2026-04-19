using BusinessObject.Interface;
using DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace BusinessObject.Service
{
    public class LoginService : ILoginService
    {
        // =====================================================
        // 🏗️ DEPENDENCY INJECTION
        // =====================================================
        // - CMSDbContext is used for database access
        private readonly CMSDbContext _context;

        public LoginService(CMSDbContext context)
        {
            _context = context;
        }

        // =====================================================
        // 🔐 1. USER VALIDATION (LOGIN CHECK)
        // =====================================================
        public async Task<User?> ValidateUserAsync(string email, string password)
        {
            // 🔍 Purpose:
            // - Check if user exists in database
            // - Match email + password

            // ⚠️ NOTE:
            // - Currently using plain password comparison
            // - In production, use HASHED password (BCrypt / Identity)

            var user = await _context.User
                .FirstOrDefaultAsync(u =>
                    u.EmailAddress == email &&
                    u.Password == password
                );

            // 📌 Return:
            // - User object if found
            // - NULL if invalid credentials

            return user;
        }
    }
}