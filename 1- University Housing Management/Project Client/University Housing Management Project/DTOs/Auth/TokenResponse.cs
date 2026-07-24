using System;

namespace University_Housing_Management_Project.DTOs.Auth
{
    public class TokenResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiresAt { get; set; }

    }
}
