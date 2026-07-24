namespace Business_Layer.DTOs
{
    public class RoomStatusDto
    {
        public int RoomId { get; set; }
        public string RoomLocation { get; set; } = null!;
        public int StudentsCount { get; set; }
        public string RoomState { get; set; } = null!;
    }
}