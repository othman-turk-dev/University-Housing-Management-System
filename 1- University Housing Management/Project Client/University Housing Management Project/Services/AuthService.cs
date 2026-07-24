using Newtonsoft.Json;
using System.Threading.Tasks;
using University_Housing_Management_Project.DTOs.Auth;

namespace University_Housing_Management_Project.Services
{
    public class AuthService
    {

        public async Task<TokenResponse> LoginAsync(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);

            var response = await ApiClient.PostAsync("Auth/login", json);

            if (!response.IsSuccessStatusCode)
                return null;

            var responseJson = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<TokenResponse>(responseJson);
        }
        public async Task<bool> LogoutAsync(LogoutRequest request)
        {
            var json = JsonConvert.SerializeObject(request);

            var response = await ApiClient.PostAsync("Auth/logout", json);

            return response.IsSuccessStatusCode;
        }

    }
}
