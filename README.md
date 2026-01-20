# Aplikasi Data Karyawan – Fullstack

Aplikasi web fullstack untuk mengelola data karyawan dengan fitur CRUD lengkap.  
Backend menggunakan .NET 8 API dan MySQL, frontend menggunakan HTML, Bootstrap 5, dan JavaScript.

---

## 📌 Deskripsi Aplikasi

Aplikasi ini dibuat untuk mengelola data karyawan secara terstruktur dan mudah digunakan.  
Backend dan frontend sudah terintegrasi langsung dengan database MySQL menggunakan Entity Framework.

---

## 🎯 Fitur Utama

- Tambah data karyawan baru
- Lihat semua data karyawan
- Edit data karyawan
- Hapus data dengan konfirmasi
- Validasi input form
- Tampilan responsif
- Mode view dan edit terpisah

---

## 🧱 Teknologi yang Digunakan

### Backend
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- MySQL
- Migration otomatis

### Frontend
- HTML5
- CSS3
- Bootstrap 5
- JavaScript

### Database
- MySQL

---

## ⚡ Cara Menjalankan Aplikasi

### Backend

Pastikan .NET 8 SDK dan MySQL sudah terinstall.

- cd backend/KaryawanAPI
dotnet run

- Backend berjalan di:
http://localhost:5086

Database akan otomatis dibuat saat pertama kali aplikasi dijalankan.

---

### Frontend

- Buka file `frontend/index.html` langsung di browser  
atau  
- Jalankan menggunakan Live Server

---

## 📞 API Endpoints

- GET `/api/karyawan`  
  Ambil semua data karyawan

- GET `/api/karyawan/{nik}`  
  Ambil data karyawan berdasarkan NIK

- POST `/api/karyawan`  
  Tambah data karyawan baru

- PUT `/api/karyawan/{nik}`  
  Update data karyawan

- DELETE `/api/karyawan/{nik}`  
  Hapus data karyawan

---

## 📋 Data yang Disimpan

- NIK (16 digit, unik)
- Nama Lengkap
- Jenis Kelamin
- Tanggal Lahir
- Alamat
- Negara

---

## ⚠️ Troubleshooting

- **CORS Error**  
  Pastikan backend (`dotnet run`) sudah berjalan

- **Database Error**  
  Pastikan service MySQL aktif

- **Form Error**  
  Cek console browser (F12)

---

## 🚀 Status

Aplikasi siap digunakan.  
Backend, frontend, dan database sudah terintegrasi dengan MySQL.




