using System;
using System.ComponentModel.DataAnnotations;

namespace KaryawanAPI.Models
{
    public class Karyawan
    {
        [Key]
        [Required(ErrorMessage = "NIK wajib diisi")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "NIK harus 16 digit")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "NIK harus angka")]
        public string NIK { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nama Lengkap wajib diisi")]
        [StringLength(100, ErrorMessage = "Nama maksimal 100 karakter")]
        public string NamaLengkap { get; set; } = string.Empty;

        [Required(ErrorMessage = "Jenis Kelamin wajib dipilih")]
        public string JenisKelamin { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tanggal Lahir wajib diisi")]
        public DateTime TanggalLahir { get; set; }

        [Required(ErrorMessage = "Alamat wajib diisi")]
        [StringLength(500, ErrorMessage = "Alamat maksimal 500 karakter")]
        public string Alamat { get; set; } = string.Empty;

        [Required(ErrorMessage = "Negara wajib dipilih")]
        public string Negara { get; set; } = string.Empty;
    }
}