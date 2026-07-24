using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;

namespace University_Housing_Management_Project.Services
{
    public class UserService
    {
        
        public async Task<UserDto> AddUser(UserDto user)
        {
            var json = JsonConvert.SerializeObject(user);

            var response = await ApiClient.PostAsync("Users", json);

            if (!response.IsSuccessStatusCode)
                return null;

            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UserDto>(result);
        }
        public async Task<SimpleUserDto> UpdateUser(SimpleUserDto simpleUser)
        {
            var json = JsonConvert.SerializeObject(simpleUser);

            var response = await ApiClient.PutAsync("Users", json);

            if (!response.IsSuccessStatusCode)
                return null;

            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SimpleUserDto>(result);
        }
        public async Task<bool> ChangePassword(ChangePasswordDto dto)
        {
            var json = JsonConvert.SerializeObject(dto);

            var response = await ApiClient.PutAsync("Users/ChangePassword", json);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> SetActive(int id)
        {
            var response = await ApiClient.PutAsync($"Users/SetActive/{id}", "");

            return response.IsSuccessStatusCode;
        }
        public async Task<bool> SetInActive(int id)
        {
            var response = await ApiClient.PutAsync($"Users/SetInActive/{id}", "");

            return response.IsSuccessStatusCode;
        }

        public async Task<CurrentUserDto> GetCurrentUserAsync()
        {
            return await ApiClient.GetFromJsonAsync<CurrentUserDto>("Users/CurrentUser");
        }
        public async Task<SimpleUserDto> FindUserById(int userId)
        {
            return await ApiClient.GetFromJsonAsync<SimpleUserDto>($"Users/{userId}");
        }
        public async Task<bool> IsUserExist(string username)
        {
            return await ApiClient.GetFromJsonAsync<bool>($"Users/IsExist/Username/{username}");
        }
        public async Task<bool> IsUserExist(int userId)
        {
            return await ApiClient.GetFromJsonAsync<bool>($"Users/IsExist/{userId}");
        }

        public async Task<List<CustomUserDto>> GetAllUsers()
        {
            return await ApiClient.GetFromJsonAsync<List<CustomUserDto>>("Users");
        }
        public async Task<List<CustomUserDto>> UsersFilter(string Username)
        {
            string query = new QueryBuilder()
                .Add("Username", Username)
                .Build();

            return await ApiClient.GetFromJsonAsync<List<CustomUserDto>>($"Users/Filter{query}");
        }

    }
}