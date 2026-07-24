namespace Data_Access_Layer.Entities;

public class Student
{
    public string UniversityNumber { get; set; } = null!;

    public int RoomId { get; set; }

    public string FullName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string GuardiansNumber { get; set; } = null!;

    public string Address { get; set; } = null!;

    public byte AcademiclLevel { get; set; }

    public int SpecilizationId { get; set; }

    public string? Idphoto { get; set; }

    public string? UniversityCardPhoto { get; set; }

    public virtual Room Room { get; set; } = null!;

    public virtual Specialization Specilization { get; set; } = null!;

    public virtual ICollection<StudentSubscription> StudentSubscriptions { get; set; } = new List<StudentSubscription>();

    public virtual ICollection<Violation> Violations { get; set; } = new List<Violation>();
}
