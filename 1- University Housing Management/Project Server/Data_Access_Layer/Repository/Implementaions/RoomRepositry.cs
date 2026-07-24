using Data_Access_Layer.Data;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Repository.Interfaces;

namespace Data_Access_Layer.Repository.Implementaions
{
    public class RoomRepositry : IRoomRepositry
    {

        private readonly AppDbContext _context;
        public RoomRepositry(AppDbContext context) => _context = context;


        public async Task<Room> AddRoomAsync(Room room)
        {
            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();

            return room;
        }
        public async Task<Room> UpdateRoomAsync(Room room)
        {
            _context.Rooms.Update(room);
            await _context.SaveChangesAsync();

            return room;
        }
        public async Task<bool> DeleteRoomAsync(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null) return false;

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<Room?> GetRoomByIdAsync(int id)
        {
            return await _context.Rooms.FindAsync(id);
        }
        public async Task<Room?> GetRoomByLocationAsync(string roomLocation)
        {
            return await _context.Rooms.FirstOrDefaultAsync(x => x.RoomLocation == roomLocation);
        }
        public async Task<bool> IsRoomExistAsync(int roomId)
        {
            return await _context.Rooms.AsNoTracking()
                .AnyAsync(x => x.RoomId == roomId);
        }
        public async Task<bool> IsRoomLocationExistAsync(string roomLocation)
        {
            return await _context.Rooms.AsNoTracking()
                .AnyAsync(x => x.RoomLocation == roomLocation);
        }

        public IQueryable<Room> GetAllRooms()
        {
            return _context.Rooms.AsNoTracking();
        }

    }
}
