using Data_Access_Layer.Entities;

namespace Data_Access_Layer.Repository.Interfaces
{
    public interface IRoomRepositry
    {
        Task<Room> AddRoomAsync(Room room);
        Task<Room> UpdateRoomAsync(Room room);
        Task<bool> DeleteRoomAsync(int id);
        Task<Room?> GetRoomByIdAsync(int id);
        Task<Room?> GetRoomByLocationAsync(string roomLocation);
        Task<bool> IsRoomExistAsync(int roomId);
        Task<bool> IsRoomLocationExistAsync(string roomLocation);
        IQueryable<Room> GetAllRooms();

    }
}
