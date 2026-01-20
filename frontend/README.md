# Frontend Aplikasi Data Karyawan

## Cara Jalankan
1. Buka folder `frontend`
2. Double-click `index.html`
3. Atau jalankan di VS Code dengan Live Server

## File Penting
- `index.html` = Dashboard
- `monitoring.html` = Tampil data
- `tambah.html` = Form tambah data
- `edit.html` = Form edit data
- `css/style.css` = Styling
- `js/app.js` = Kode JavaScript

## Koneksi ke Backend
Ubah di `js/app.js` jika perlu:
```javascript
const API_URL = 'http://localhost:5086/api';
Kebutuhan
Browser modern (Chrome/Firefox)

Backend harus sudah running

Jika Error
Pastikan backend jalan (dotnet run)

Cek console browser (F12)

Ubah port jika perlu di js/app.js