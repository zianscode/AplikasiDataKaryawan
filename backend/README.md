# Backend API (.NET 8 + MySQL)

Backend REST API untuk mengelola data karyawan menggunakan .NET 8 dan MySQL.

---

## 🚀 Setup Cepat

1. Install **.NET 8 SDK**
2. Buat database MySQL:
CREATE DATABASE KaryawanDB;

markdown
Copy code
3. Install dependency:
dotnet restore

markdown
Copy code
4. Buat migrasi:
dotnet ef migrations add Init

markdown
Copy code
5. Update database:
dotnet ef database update

markdown
Copy code
6. Jalankan aplikasi:
dotnet run

yaml
Copy code

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

## 🌐 Port

- HTTP: `http://localhost:5086`

---

## 📁 Struktur Folder

Controllers/
└── KaryawanController.cs
Data/
└── ApplicationDbContext.cs
Models/
└── Karyawan.cs
appsettings.json
Program.cs

yaml
Copy code

---

## 🗄️ Koneksi Database

Edit file `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Port=3306;Database=KaryawanDB;User=root;Password=;"
}
⚠️ Troubleshooting
CORS Error
Pastikan app.UseCors("AllowAll") sudah ada di Program.cs

MySQL Error
Pastikan service MySQL berjalan dan credential benar

yaml
Copy code

---

### 📄 `frontend/README.md`

Frontend (HTML + Bootstrap 5)
Frontend aplikasi data karyawan menggunakan HTML, Bootstrap 5, dan JavaScript.

🚀 Setup Cepat
Masuk ke folder frontend

Jalankan dengan Live Server (VS Code)

Atau jalankan server lokal:

yaml
Copy code
python -m http.server 8000
📄 Halaman
index.html – Dashboard

monitoring.html – Tabel data karyawan

tambah.html – Form tambah data

edit.html – Form edit data

⚙️ Konfigurasi API
Edit file js/app.js jika port backend berbeda:

javascript
Copy code
const API_URL = 'http://localhost:5086/api';
🎯 Fitur
Responsive design

Validasi form

CRUD operations

Modal konfirmasi delete

Toggle view dan edit mode

🧱 Teknologi
HTML5

CSS3 + Bootstrap 5

JavaScript Vanilla

Bootstrap Icons

📝 Catatan
Pastikan backend berjalan di port 5086

Gunakan DevTools (F12) untuk cek error di browser

markdown
Copy code

Kalau mau:
- digabung jadi **1 README utama**
- atau disesuaikan buat **UKK / portfolio GitHub**
- atau full **English version**

tinggal bilang, aku rapihin sekalian 👍
