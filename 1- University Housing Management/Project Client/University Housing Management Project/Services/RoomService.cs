using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;

namespace University_Housing_Management_Project.Services
{
    public class RoomService
    {
        public async Task<RoomDto> AddRoom(RoomDto room)
        {
            var json = JsonConvert.SerializeObject(room);

            var response = await ApiClient.PostAsync("Rooms", json);

            if (!response.IsSuccessStatusCode)
                return null;

            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<RoomDto>(result);
        }
        public async Task<RoomDto> UpdateRoom(RoomDto room)
        {
            var json = JsonConvert.SerializeObject(room);

            var response = await ApiClient.PutAsync("Rooms", json);

            if (!response.IsSuccessStatusCode)
                return null;

            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<RoomDto>(result);
        }
        public async Task<bool> DeleteRoom(int Id)
        {
            var response = await ApiClient.DeleteAsync($"Rooms/{Id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<RoomDto> GetRoomById(int Id)
        {
            return await ApiClient.GetFromJsonAsync<RoomDto>($"Rooms/{Id}");
        }
        public async Task<RoomDto> GetRoomByRoomLocation(string RoomLocation)
        {
            return await ApiClient.GetFromJsonAsync<RoomDto>($"Rooms/location/{RoomLocation}");
        }
        public async Task<bool> IsRoomExist(int Id)
        {
            return await ApiClient.GetFromJsonAsync<bool>($"Rooms/IsExist/Id/{Id}");
        }
        public async Task<bool> IsRoomLocationExist(string RoomLocation)
        {
            return await ApiClient.GetFromJsonAsync<bool>($"Rooms/IsExist/RoomLocation/{RoomLocation}");
        }
        
        public async Task<int?> GetTotalRoomsAsync()
        {
            return await ApiClient.GetFromJsonAsync<int?>("Rooms/TotalNumber");
        }
        public async Task<int?> GetTotalAvailableRoomsAsync()
        {
            return await ApiClient.GetFromJsonAsync<int?>("Rooms/TotalNumberAvailable");
        }
        public async Task<int?> GetTotalRoomsFillAsync()
        {
            return await ApiClient.GetFromJsonAsync<int?>("Rooms/TotalNumberFull");
        }

        public async Task<List<string>> GetAllAvailableRoomAsync()
        {
            return await ApiClient.GetFromJsonAsync<List<string>>("Rooms/AllAvailable");
        }
        public async Task<List<RoomStatusDto>> GetAllRoomsWithDetails()
        {
            return await ApiClient.GetFromJsonAsync<List<RoomStatusDto>>("Rooms/AllWithDetails");
        }
        public async Task<List<RoomStatusDto>> RoomFilter(RoomFilterDto filterDto)
        {
            string query = new QueryBuilder()
                .Add("Floor", filterDto.Floor)
                .Add("RoomLocation", filterDto.RoomLocation)
                .Add("Status", filterDto.Status)
                .Add("StudentsCount", filterDto.StudentsCount)
                .Build();

            return await ApiClient.GetFromJsonAsync<List<RoomStatusDto>>($"Rooms/Filter/{query}");
        }
        public async Task<List<StudentWithDetailsDto>> GetAllStudentsInThisRoom(int roomId)
        {
            return await ApiClient.GetFromJsonAsync<List<StudentWithDetailsDto>>($"Students/Room/{roomId}");
        }
        public async Task<List<string>> GetCurrentAndAllAvailableRoomAsync(string UniversityNumber)
        {
            return await ApiClient.GetFromJsonAsync<List<string>>($"Rooms/CurrentAndAllAvailable/{UniversityNumber}");
        }

    }
}