namespace University_Housing_Management_Project.DTOs
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Permmission { get; set; }
        public bool IsActive { get; set; }
    }
}
