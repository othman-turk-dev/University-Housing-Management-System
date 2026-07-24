namespace Data_Access_Layer.Entities;

public class Room
{
    public int RoomId { get; set; }

    public string RoomLocation { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
