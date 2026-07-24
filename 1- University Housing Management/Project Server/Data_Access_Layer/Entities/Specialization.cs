namespace Data_Access_Layer.Entities;

public class Specialization
{
    public int SpecializationId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
