using Business_Layer.DTOs;

namespace Business_Layer.Interfaces
{
    public interface IRoomService
    {
        Task<RoomDto?> AddRoomAsync(RoomDto room);
        Task<RoomDto?> UpdateRoomAsync(RoomDto room);
        Task<bool> DeleteRoomAsync(int roomId);
        Task<RoomDto?> GetRoomByIdAsync(int roomId);
        Task<RoomDto?> GetRoomByLocationAsync(string roomLocation);
        Task<bool> IsRoomExistAsync(int roomId);
        Task<bool> IsRoomLocationExistAsync(string roomLocation);
        Task<int> GetTolalRoomsNumberAsync();
        Task<int> GetTolalRoomsNumberFullAsync();
        Task<int> GetTotalRoomsNumberAvailableAsync();

        Task<IEnumerable<RoomStatusDto>> RoomFilterAsync(RoomFilterDto roomFilter);
        Task<IEnumerable<string>> GetAllRoomsAvailableAsync();
        Task<IEnumerable<RoomStatusDto>> GetAllRoomsWithDetailsAsync();
        Task<IEnumerable<string>> GetCurrentRoomAndAllRoomsAvailableAsync(string UniversityNumber);

    }
}
