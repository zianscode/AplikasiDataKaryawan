# Backend API (.NET 8 + MySQL)

## Setup Cepat
1. Install .NET 8 SDK
2. Buat database: `CREATE DATABASE KaryawanDB;`
3. Install packages: `dotnet restore`
4. Migrasi: `dotnet ef migrations add Init`
5. Update DB: `dotnet ef database update`
6. Run: `dotnet run`

## API Endpoints
GET /api/karyawan # Semua data
GET /api/karyawan/{nik} # Data by NIK
POST /api/karyawan # Tambah data
PUT /api/karyawan/{nik} # Update data
DELETE /api/karyawan/{nik} # Hapus data

text

## Port
- HTTP: `http://localhost:5086`

## Struktur Folder
Controllers/KaryawanController.cs
Data/ApplicationDbContext.cs
Models/Karyawan.cs
appsettings.json
Program.cs

text

## Koneksi Database
Edit `appsettings.json`:
```json
"Server=localhost;Port=3306;Database=KaryawanDB;User=root;Password=;"
Troubleshooting
CORS error: Pastikan app.UseCors("AllowAll") di Program.cs

MySQL error: Cek service MySQL berjalan

text

---

# **Frontend README.md**

```markdown
# Frontend (HTML + Bootstrap 5)

## Setup Cepat
1. Buka folder `frontend`
2. Jalankan dengan Live Server (VS Code)
3. Atau: `python -m http.server 8000`

## Halaman
- `index.html` - Dashboard
- `monitoring.html` - Tabel data
- `tambah.html` - Form tambah
- `edit.html` - Form edit

## Konfigurasi
Edit `js/app.js` jika port backend berbeda:
```javascript
const API_URL = 'http://localhost:5086/api';
Fitur
Responsive design

Validasi form

CRUD operations

Modal konfirmasi delete

Toggle view/edit mode

Teknologi
HTML5

CSS3 + Bootstrap 5

JavaScript Vanilla

Bootstrap Icons

Catatan
Pastikan backend berjalan di port 5086

Buka DevTools (F12) jika ada error