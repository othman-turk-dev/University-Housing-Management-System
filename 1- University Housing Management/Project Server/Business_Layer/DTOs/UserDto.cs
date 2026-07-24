namespace Business_Layer.DTOs
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        //public string? RefreshToken { get; set; }
        //public DateTime? RefreshTokenExpiresAt { get; set; }
        //public DateTime? RefreshTokenRevokedAt { get; set; }
        public int Permmission { get; set; }
        public bool IsActive { get; set; }

    }
}
