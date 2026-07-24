namespace Business_Layer.DTOs
{
    public class SimpleUserDto
    {
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public int Permmission { get; set; }
        public bool IsActive { get; set; }
    }
}
