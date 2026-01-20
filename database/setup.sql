-- ============================================
-- SETUP DATABASE KARYAWAN
-- Untuk Aplikasi Data Pribadi Karyawan
-- ============================================

-- 1. CREATE DATABASE
CREATE DATABASE IF NOT EXISTS KaryawanDB;
USE KaryawanDB;

-- 2. CREATE TABLE Karyawans
CREATE TABLE IF NOT EXISTS Karyawans (
    NIK VARCHAR(16) PRIMARY KEY,
    NamaLengkap VARCHAR(100) NOT NULL,
    JenisKelamin VARCHAR(10) NOT NULL,
    TanggalLahir DATE NOT NULL,
    Alamat VARCHAR(500) NOT NULL,
    Negara VARCHAR(50) NOT NULL,
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 3. CREATE INDEXES untuk performa
CREATE INDEX idx_nama ON Karyawans(NamaLengkap);
CREATE INDEX idx_negara ON Karyawans(Negara);
CREATE INDEX idx_tanggal_lahir ON Karyawans(TanggalLahir);

-- 4. INSERT SAMPLE DATA (Optional)
INSERT INTO Karyawans (NIK, NamaLengkap, JenisKelamin, TanggalLahir, Alamat, Negara) VALUES
('1234567890123456', 'Budi Santoso', 'Laki-laki', '1990-05-15', 'Jl. Merdeka No. 123, Jakarta Pusat', 'Indonesia'),
('2345678901234567', 'Siti Aminah', 'Perempuan', '1992-08-25', 'Jl. Sudirman Kav. 45, Jakarta Selatan', 'Indonesia'),
('3456789012345678', 'John Smith', 'Laki-laki', '1985-03-10', '123 Main Street, New York', 'Amerika Serikat'),
('4567890123456789', 'Maria Garcia', 'Perempuan', '1988-11-30', 'Avenida de la Luz 45, Madrid', 'Spanyol'),
('5678901234567890', 'Tanaka Kenji', 'Laki-laki', '1991-07-22', '1-2-3 Shibuya, Tokyo', 'Jepang');

-- 5. SHOW RESULT
SELECT '=== DATABASE SETUP COMPLETE ===' AS Message;
SELECT COUNT(*) AS 'Total Data' FROM Karyawans;
SELECT * FROM Karyawans;

-- 6. SHOW TABLE STRUCTURE
DESC Karyawans;