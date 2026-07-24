using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data_Access_Layer.Data;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public virtual DbSet<Bank> Banks { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Room> Rooms { get; set; }
    public virtual DbSet<Sale> Sales { get; set; }
    public virtual DbSet<SaleDetail> SaleDetails { get; set; }
    public virtual DbSet<Setting> Settings { get; set; }
    public virtual DbSet<Specialization> Specializations { get; set; }
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<StudentSubscription> StudentSubscriptions { get; set; }
    public virtual DbSet<Subscription> Subscriptions { get; set; }
    public virtual DbSet<SubscriptionType> SubscriptionTypes { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Violation> Violations { get; set; }
    public virtual DbSet<ViolationType> ViolationTypes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.UseCollation("Arabic_CI_AS");

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

}
