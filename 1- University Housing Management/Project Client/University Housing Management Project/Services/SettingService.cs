using System.Threading.Tasks;

namespace University_Housing_Management_Project.Services
{
    public class SettingService
    {
        public async Task<int?> GetRoomCapacityAsync()
        {
            return await ApiClient.GetFromJsonAsync<int?>("Settings/RoomCapacity");
        }
    }
}