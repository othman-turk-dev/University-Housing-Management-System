using Data_Access_Layer.Data;
using Business_Layer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Business_Layer.Services
{
    public class SettingsService : ISettingsService
    {
        private readonly AppDbContext _context;

        public SettingsService(AppDbContext context) 
            => _context = context;

        public async Task<int> GetRoomCapacityAsync()
        {
            var value = await _context.Settings
                .Where(s => s.Key == "MaximumNumberOfStudentsInTheRoom")
                .Select(s => s.Value)
                .FirstOrDefaultAsync();

            if (!int.TryParse(value.ToString(), out int limit))
                limit = 4;

            return limit;
        }
    
    }
}
