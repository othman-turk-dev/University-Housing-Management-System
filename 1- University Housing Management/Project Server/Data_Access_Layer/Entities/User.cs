namespace Data_Access_Layer.Entities;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiresAt { get; set; }
    public DateTime? RefreshTokenRevokedAt { get; set; }
    public int Permmission { get; set; }
    public bool IsActive { get; set; }

    public virtual ICollection<Bank> Banks { get; set; } = new List<Bank>();
    public virtual ICollection<Product> ProductCreateByUsers { get; set; } = new List<Product>();
    public virtual ICollection<Product> ProductLastModifiedByUsers { get; set; } = new List<Product>();
    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
    public virtual ICollection<Violation> Violations { get; set; } = new List<Violation>();
}
