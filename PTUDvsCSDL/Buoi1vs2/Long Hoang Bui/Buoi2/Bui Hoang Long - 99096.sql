create database PTUDCSDLN01
USE PTUDCSDLN01

CREATE TABLE LoaiHang(
	MaLoaiHang varchar(3) primary key,
	TenLoaiHang nvarchar(30) not null unique
)
insert LoaiHang values
('SUA', N'Sữa'),
('BMI', N'Bánh mì'),
('KEM', N'Kem'),
('KMU', N'Kẹo mút'),
('BBI', N'Bim Bim')

CREATE TABLE DonViTInh (
    MaDonViTinh VARCHAR(3) PRIMARY KEY,
    TenDonViTinh NVARCHAR(30) NOT NULL UNIQUE,
    MaDonViTinhGoc VARCHAR(3),
    QuyDoi FLOAT NOT NULL DEFAULT 1,
    FOREIGN KEY (MaDonViTinhGoc) REFERENCES DonViTInh(MaDonViTinh)
);


INSERT DonViTInh VALUES
('HOP', N'Hộp', null, 1),
('LO4', N'Lốc 4', 'HOP', 4),
('LO8', N'Lốc 8', 'HOP', 8),
('T36', N'Thùng 36', 'HOP', 36),
('CAI', N'Cái', null, 1)


