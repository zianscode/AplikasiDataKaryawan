using Microsoft.EntityFrameworkCore;
using KaryawanAPI.Models;

namespace KaryawanAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Karyawan> Karyawans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Karyawan>()
                .HasKey(k => k.NIK);
        }
    }
}