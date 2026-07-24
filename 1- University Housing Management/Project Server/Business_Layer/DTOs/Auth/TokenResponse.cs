namespace Business_Layer.DTOs.Auth
{
    public class TokenResponse
    {
        public string AccessToken { get; set; } = null!;
        public string RefreshToken { get; set; } = null!;
        public DateTime? RefreshTokenExpiresAt { get; set; }

    }
}
