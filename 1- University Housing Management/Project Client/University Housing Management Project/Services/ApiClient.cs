using System;
using System.Net;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using University_Housing_Management_Project.Global;
using University_Housing_Management_Project.DTOs.Auth;

namespace University_Housing_Management_Project.Services
{
    public class ApiClient
    {
        public static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7282/api/")
        };

        public static void SetToken()
        {
            if (!string.IsNullOrWhiteSpace(CurrentUser.AccessToken))
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", CurrentUser.AccessToken);
            }
        }
        public static async Task<T> GetFromJsonAsync<T>(string url)
        {
            var response = await GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return default;

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }

        private static async Task<HttpResponseMessage> SendAsync(Func<Task<HttpResponseMessage>> sendRequest)
        {

            SetToken();

            var response = await sendRequest();

            if (response.StatusCode != HttpStatusCode.Unauthorized)
                return response;

            if (!await RefreshTokenAsync())
                return response; 

            return await sendRequest();
        }

        public static async Task<HttpResponseMessage> GetAsync(string url)
        {
            return await SendAsync(() => client.GetAsync(url));
        }
        public static async Task<HttpResponseMessage> PostAsync(string url, string json)
        {
            return await SendAsync(() =>
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                return client.PostAsync(url, content);
            });
        }
        public static async Task<HttpResponseMessage> PutAsync(string url, string json)
        {
            return await SendAsync(() =>
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                return client.PutAsync(url, content);
            });
        }
        public static async Task<HttpResponseMessage> DeleteAsync(string url)
        {
            return await SendAsync(() => client.DeleteAsync(url));
        }

        private static async Task<bool> RefreshTokenAsync()
        {
            try
            {
                var request = new RefreshRequest
                {
                    Username = CurrentUser.Username,
                    RefreshToken = CurrentUser.RefreshToken
                };

                var json = JsonConvert.SerializeObject(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("Auth/refresh", content);

                if (!response.IsSuccessStatusCode)
                    return false;

                var responseBody = await response.Content.ReadAsStringAsync();
                var token = JsonConvert.DeserializeObject<TokenResponse>(responseBody);

                CurrentUser.AccessToken = token.AccessToken;
                CurrentUser.RefreshToken = token.RefreshToken;
                CurrentUser.RefreshTokenExpiresAt = token.RefreshTokenExpiresAt;

                SetToken();

                return true;
            }
            catch
            {

                return false;
            }
        }

    }
}