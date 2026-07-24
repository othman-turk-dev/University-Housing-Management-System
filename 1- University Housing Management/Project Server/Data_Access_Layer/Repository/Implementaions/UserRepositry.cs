using Data_Access_Layer.Data;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Repository.Interfaces;

namespace Data_Access_Layer.Repository.Implementaions
{
    public class UserRepositry : IUserRepositry
    {

        private readonly AppDbContext _context;
        public UserRepositry(AppDbContext context)
            => _context = context;


        public async Task<User> AddUserAsync(User user)
        {

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }
        public async Task<User> UpdateUserAsync(User user)
        {
            
            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return user;
        }
        public async Task<bool> DeleteUserAsync(int userId)
        {
            
            var user = await GetUserByIdAsync(userId);
            if (user == null) return false;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<User?> GetUserByIdAsync(int userId)
        {
            
            return await _context.Users.FindAsync(userId);
        }
        public async Task<User?> GetUserByUsernameAsync(string username)
        {

            return await _context.Users.
                FirstOrDefaultAsync(r => r.Username == username);
        }
        public async Task<bool> IsUserExistAsync(int userId)
        {
            
            return await _context.Users.AsNoTracking()
                .AnyAsync(u => u.UserId == userId);
        }
        public async Task<bool> IsUserExistAsync(string username)
        {

            return await _context.Users.AsNoTracking()
                .AnyAsync(u => u.Username == username);
        }

        public IQueryable<User> GetAll()
        {
            return _context.Users.AsNoTracking();
        }

    }
}
