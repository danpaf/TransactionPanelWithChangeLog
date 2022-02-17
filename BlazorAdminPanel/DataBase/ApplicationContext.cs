using BlazorAdminPanel.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlazorAdminPanel.DataBase
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Type> Types { get; set; }

        private readonly IConfiguration _configuration;
        public ApplicationContext(IConfiguration configuration)
        {
            _configuration = configuration;
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration["PostgreConnectionString"]);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Uid).HasColumnName("uid");
                entity.Property(e => e.Age).HasColumnName("age");
                entity.Property(e => e.Password).HasColumnName("password");
                entity.Property(e => e.Email).HasColumnName("email");
                entity.Property(e => e.AddedDate).HasColumnName("added_date");
                entity.Property(e => e.StatusUid).HasColumnName("status_uid");
                
            });
            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Uid).HasColumnName("uid");
                entity.Property(e => e.Name).HasColumnName("name");

            });
            modelBuilder.Entity<Type>(entity =>
            {
                entity.Property(e => e.Uid).HasColumnName("uid");
                entity.Property(e => e.Name).HasColumnName("name");

            });
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.Property(e => e.Uid).HasColumnName("uid");
                entity.Property(e => e.Delta).HasColumnName("delta");
                entity.Property(e => e.AddedDate).HasColumnName("added_date");
                entity.Property(e => e.UserUid).HasColumnName("user_uid");
                entity.Property(e => e.TypeUid).HasColumnName("type_uid");
                entity.Property(e => e.Plus).HasColumnName("plus");
                entity.Property(e => e.Minus).HasColumnName("minus");
            });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}