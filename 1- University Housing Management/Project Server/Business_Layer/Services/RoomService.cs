using Business_Layer.DTOs;
using Business_Layer.Interfaces;
using Data_Access_Layer.Entities;
using Business_Layer.DTOs.Mappers;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Repository.Interfaces;

namespace Business_Layer.Services
{
    public class RoomService: IRoomService
    {

        private readonly IRoomRepositry _roomRepo;
        private readonly ISettingsService _settingsService;
        public RoomService(IRoomRepositry roomRepo, ISettingsService settingsService) 
        {
            
            _roomRepo = roomRepo;
            _settingsService = settingsService;
        }

        public async Task<RoomDto?> AddRoomAsync(RoomDto room)
        {
            Room newRoom = new Room
            {
                RoomLocation = room.RoomLocation
            };

            var addedRoom = await _roomRepo.AddRoomAsync(newRoom);
            
            if (addedRoom == null)
                return null;

            return RoomMapper.ToDto(addedRoom);
        }
        public async Task<RoomDto?> UpdateRoomAsync(RoomDto room)
        {

            var existing = await _roomRepo.GetRoomByIdAsync(room.RoomId);
            if (existing == null) 
                return null;

            existing.RoomLocation = room.RoomLocation;

            var updatedRoom = await _roomRepo.UpdateRoomAsync(existing);
            
            if (updatedRoom == null)
                return null;

            return RoomMapper.ToDto(updatedRoom);
        }
        public async Task<bool> DeleteRoomAsync(int roomId)
        {
            return await _roomRepo.DeleteRoomAsync(roomId);
        }
        public async Task<RoomDto?> GetRoomByIdAsync(int roomId)
        {

            var room = await _roomRepo.GetRoomByIdAsync(roomId);
            
            if (room == null)
                return null;

            return RoomMapper.ToDto(room);
        }
        public async Task<RoomDto?> GetRoomByLocationAsync(string roomLocation)
        {

            var room = await _roomRepo.GetRoomByLocationAsync(roomLocation);
            if (room == null)
                return null;

            return RoomMapper.ToDto(room);
        }
        public async Task<bool> IsRoomExistAsync(int roomId)
        {
            return await _roomRepo.IsRoomExistAsync(roomId);
        }
        public async Task<bool> IsRoomLocationExistAsync(string roomLocation)
        {
            return await _roomRepo.IsRoomLocationExistAsync(roomLocation);
        }

        public async Task<int> GetTolalRoomsNumberAsync()
        {
            return await _roomRepo.GetAllRooms()
                .AsNoTracking()
                .CountAsync();
        }
        public async Task<int> GetTolalRoomsNumberFullAsync()
        {

            var limit = await _settingsService.GetRoomCapacityAsync();

            return await _roomRepo.GetAllRooms()
                .AsNoTracking()
                .CountAsync(r => r.Students.Count == limit);
        }
        public async Task<int> GetTotalRoomsNumberAvailableAsync()
        {

            var limit = await _settingsService.GetRoomCapacityAsync();

            return await _roomRepo.GetAllRooms().
                AsNoTracking()
                .CountAsync(r => r.Students.Count < limit && r.Students.Count > 0);
        }

        public async Task<IEnumerable<string>> GetAllRoomsAvailableAsync()
        {

            var limit = await _settingsService.GetRoomCapacityAsync();

            return await _roomRepo.GetAllRooms()
                .AsNoTracking()
                .Where(r => r.Students.Count < limit)
                .Select(r => r.RoomLocation)
                .ToListAsync();
        }
        public async Task<IEnumerable<RoomStatusDto>> GetAllRoomsWithDetailsAsync()
        {

            var limit = await _settingsService.GetRoomCapacityAsync();

            return await _roomRepo.GetAllRooms()
                .AsNoTracking()
                .Select(r => new RoomStatusDto
                {
                    RoomId = r.RoomId,
                    RoomLocation = r.RoomLocation,
                    StudentsCount = r.Students.Count,

                    RoomState = r.Students.Count == 0 ? "Empty" :
                                r.Students.Count >= 1 && r.Students.Count <= limit - 1 ? "Available" :
                                "Full"
                })

                .OrderByDescending(r => r.StudentsCount)
                .ThenBy(r => r.RoomLocation)
                .ToListAsync();
        }
        public async Task<IEnumerable<string>> GetCurrentRoomAndAllRoomsAvailableAsync(string UniversityNumber)
        {

            var limit = await _settingsService.GetRoomCapacityAsync();

            var query = await _roomRepo.GetAllRooms()
                .AsNoTracking()
                .Where(r => r.Students.Count < limit ||
                      (r.Students.Any(s => s.UniversityNumber == UniversityNumber)))

                .Select(r => r.RoomLocation)
                .ToListAsync();

            return query;
        }

        public async Task<IEnumerable<RoomStatusDto>> RoomFilterAsync(RoomFilterDto roomFilter)
        {

            var roomCapacity = await _settingsService.GetRoomCapacityAsync();

            var query = _roomRepo.GetAllRooms();

            if (!string.IsNullOrWhiteSpace(roomFilter.RoomLocation))
                query = query.Where(r => r.RoomLocation.Contains(roomFilter.RoomLocation));

            if (!string.IsNullOrWhiteSpace(roomFilter.Floor) && roomFilter.Floor != "All")
                query = query.Where(r => r.RoomLocation.Contains(roomFilter.Floor));

            if (roomFilter.StudentsCount.HasValue)
                query = query.Where(r => r.Students.Count == roomFilter.StudentsCount.Value);

            if(!string.IsNullOrWhiteSpace(roomFilter.Status))
            {

                switch (roomFilter.Status)
                {

                    case "Empty":
                    {

                        query = query.Where(r => r.Students.Count == 0);
                        break;
                    }

                    case "Full":
                    {

                        query = query.Where(r => r.Students.Count == roomCapacity);
                        break;
                    }

                    case "Available":
                    {

                        query = query.Where(r => r.Students.Count < roomCapacity &&
                         r.Students.Count > 0);
                        
                        break;
                    }

                    default:
                        break;

                }

            }

            return await query.Select(r => new RoomStatusDto
            {
                RoomId = r.RoomId,
                RoomLocation = r.RoomLocation,
                StudentsCount = r.Students.Count,

                RoomState = r.Students.Count == 0 ? "Empty" :
                                r.Students.Count > 0 && r.Students.Count < roomCapacity ? "Available" :
                                "Full"
            })
            .ToListAsync();

        }
       

    }
}
