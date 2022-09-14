using EFDemo.Models;
using Microsoft.EntityFrameworkCore;



namespace EntityFramework.Models
{
    public class MicronContext : DbContext  // should contain atleast one constructor
    {
        public MicronContext() { }

        public MicronContext(DbContextOptions<MicronContext> builder) : base(builder)
        {
        }
        public DbSet<Visitor> Visitors { get; set; }
        protected internal virtual void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Visitor>().ToTable("Athithi");
            modelBuilder.Entity<Visitor>().Property(p => p.Name)
                .HasColumnType("varchar(50)");
            modelBuilder.Entity<Visitor>().Property(p => p.Company)
                .HasColumnType("varchar(50)");
            modelBuilder.Entity<Visitor>().Property(p => p.ContactPerson)
                .HasColumnType("varchar(50)");
        }
    }
}