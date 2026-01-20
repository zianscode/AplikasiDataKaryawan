Aplikasi Data Karyawan - Fullstack
📌 Deskripsi Aplikasi
Aplikasi web untuk mengelola data karyawan dengan fitur lengkap:

Backend: .NET 8 API + MySQL

Frontend: HTML + Bootstrap 5 + JavaScript

Database: MySQL dengan Entity Framework

🎯 Fitur Utama
✅ Tambah data karyawan baru
✅ Lihat semua data karyawan
✅ Edit data yang sudah ada
✅ Hapus data dengan konfirmasi
✅ Validasi input form
✅ Tampilan responsif
✅ Mode view/edit terpisah

📁 Struktur Project
text
PROJECT/
├── backend/          # API .NET 8
├── frontend/         # HTML/CSS/JS
└── database/         # Script SQL
⚡ Cara Pakai
Backend: cd backend/KaryawanAPI → dotnet run

Frontend: Buka frontend/index.html di browser

Database: Sudah otomatis dibuat saat pertama run

🔧 Teknologi yang Digunakan
Backend: .NET 8, Entity Framework, MySQL

Frontend: HTML5, CSS3, Bootstrap 5, JavaScript

Database: MySQL dengan migration otomatis

📞 API Endpoints
text
GET    /api/karyawan           → Ambil semua data
GET    /api/karyawan/{nik}     → Ambil data by NIK
POST   /api/karyawan           → Tambah data baru
PUT    /api/karyawan/{nik}     → Update data
DELETE /api/karyawan/{nik}     → Hapus data
🌐 URL Aplikasi
Backend: http://localhost:5086

Frontend (Live Server) atau buka file langsung

⚠️ Troubleshooting Singkat
CORS error → Pastikan dotnet run sudah jalan

Database error → Cek MySQL service berjalan

Form error → Cek console browser (F12)

📋 Data yang Disimpan
NIK (16 digit, unik)

Nama Lengkap

Jenis Kelamin

Tanggal Lahir

Alamat

Negara

🚀 Aplikasi siap digunakan!
Backend + Frontend sudah terintegrasi dengan database MySQL.