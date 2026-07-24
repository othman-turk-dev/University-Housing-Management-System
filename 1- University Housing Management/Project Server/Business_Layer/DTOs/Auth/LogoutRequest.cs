namespace Business_Layer.DTOs.Auth
{
    public class LogoutRequest
    {

        public string Username { get; set; } = null!;
        public string RefreshToken { get; set; } = null!;
    
    }
}
