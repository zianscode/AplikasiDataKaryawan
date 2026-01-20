using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using KaryawanAPI.Models;
using System;
using System.Linq;

namespace KaryawanAPI.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Karyawans.Any())
                {
                    return; 
                }

                context.Karyawans.AddRange(
                    new Karyawan
                    {
                        NIK = "1234567890123456",
                        NamaLengkap = "Budi Santoso",
                        JenisKelamin = "Laki-laki",
                        TanggalLahir = new DateTime(1990, 5, 15),
                        Alamat = "Jl. Merdeka No. 123, Jakarta Pusat",
                        Negara = "Indonesia"
                    },
                    new Karyawan
                    {
                        NIK = "2345678901234567",
                        NamaLengkap = "Siti Aminah",
                        JenisKelamin = "Perempuan",
                        TanggalLahir = new DateTime(1992, 8, 25),
                        Alamat = "Jl. Sudirman Kav. 45, Jakarta Selatan",
                        Negara = "Indonesia"
                    },
                    new Karyawan
                    {
                        NIK = "3456789012345678",
                        NamaLengkap = "John Smith",
                        JenisKelamin = "Laki-laki",
                        TanggalLahir = new DateTime(1985, 3, 10),
                        Alamat = "123 Main Street, New York",
                        Negara = "Amerika Serikat"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}