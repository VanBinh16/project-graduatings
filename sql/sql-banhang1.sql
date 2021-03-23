create table NhanVien
(
MaNV nvarchar(10) primary key,
TenNV nvarchar(30),
GioiTinh bit,
NgaySinh date,
CMND nvarchar(10),
SDT nvarchar(10),
Email nvarchar(30),
DiaChi nvarchar(50),
NgayVaoLam datetime,
ChucVu int,
GhiChu nvarchar(20),
TrangThai bit,
)
create table TaiKhoan
(
SDT nvarchar(10) primary key,
MatKhau nvarchar(10),
TrangThai bit,
)
create table ChucVu
(
ChucVu int primary key, 
TenChucVu nvarchar(20),
TrangThai bit,
)
create table KhachHang(
MaKH nvarchar(10) primary key,
TenKH nvarchar(30),
GioiTinh bit,
NgaySinh date,
SDT nvarchar(10),
Email nvarchar(30),
DiaChi nvarchar(50),
TrangThai bit,
)
create table LoaiSanPham
(
Maloai nvarchar(10) primary key,
TenLoai nvarchar(30),
)
create table NhaCungCap
(
MaNhaCungCung int primary key,
MaSp nvarchar(10),
TenNhaCungCap nvarchar(20),
Email nvarchar(20),
SDT nvarchar(10),
DiaChi nvarchar(50),
TrangThai bit,
)
create table SanPham
(
MaSP nvarchar(10) primary key,
TenSP nvarchar(50),
DonGia money,
MaLoai nvarchar(10),
GiaNhap money, 
SLTon int ,
MoTa nvarchar(50),
HinhAnh nvarchar(50),
TrangThai bit,
)
create table HoaDon
(
MaHD nvarchar(10) primary key,
NgayLapHD datetime,
MaNV nvarchar(10),
MaKH nvarchar(10), 
TongTien money,
TrangThai bit,
)
create table CTHoaDon
(
MaHD nvarchar(10),
MaSP nvarchar(10),
GiaBan money,
SoLuong int,
TongTien money,
TrangThai bit,
)
create table Kho
(
MaKho nvarchar(10) primary key,
MaSP nvarchar(10),
TenKho nvarchar(30),
DiaChi nvarchar(30),
TrangThai bit,
)
create table PhieuNhap
(
MaPhieuNhap nvarchar(10) primary key,
NgayLap datetime,
TongTien money,
ChiecKhau nvarchar(10),
ThanhToan money,
MaNV nvarchar(10),
MaKho nvarchar(10),
TrangThai bit,
)
create table PhieuXuat
(
MaPhieuXuat nvarchar(10) primary key,
NgayLap datetime,
TongTien money,
ChiecKhau nvarchar(10),
ThanhToan money,
MaNV nvarchar(10),
MaKho nvarchar(10),
TrangThai bit,
)
create table CTPhieuNhap
(
MaPhieuNhap nvarchar(10),
MaSP nvarchar(10),
SoLuong int, 
GiaNhap money,
TrangThai bit,
)
create table CTPhieuXuat
(
MaPhieuXuat nvarchar(10),
MaSP nvarchar(10),
SoLuong int, 
GiaNhap money,
TrangThai bit,
)
ALTER TABLE NhanVien
ADD CONSTRAINT fk_nhanvien_taikhoan
  FOREIGN KEY (SDT)
  REFERENCES TaiKhoan (SDT);

  ALTER TABLE NhanVien
ADD CONSTRAINT fk_nhanvien_chucvu
  FOREIGN KEY (ChucVu)
  REFERENCES ChucVu (ChucVu);

  ALTER TABLE HoaDon
ADD CONSTRAINT fk_nhanvien_hoadon
  FOREIGN KEY (MaNV)
  REFERENCES NhanVien (MaNV);

ALTER TABLE KhachHang
ADD CONSTRAINT fk_khachhang_taikhoan
  FOREIGN KEY (SDT)
  REFERENCES TaiKhoan (SDT);
  ALTER TABLE HoaDon
ADD CONSTRAINT fk_khachhang_hoadon
  FOREIGN KEY (MaKH)
  REFERENCES KhachHang (MaKH);

 ALTER TABLE CTHoaDon
ADD CONSTRAINT fk_hoadon_cthoadon
  FOREIGN KEY (MaHD)
  REFERENCES HoaDon (MaHD);

   ALTER TABLE NhaCungCap
ADD CONSTRAINT fk_sanpham_nhacungcap
  FOREIGN KEY (MaSP)
  REFERENCES SanPham (MaSP);
  ALTER TABLE SanPham
ADD CONSTRAINT fk_sanpham_loaisanpham
  FOREIGN KEY (MaLoai)
  REFERENCES LoaiSanPham (MaLoai);

  ALTER TABLE Kho
ADD CONSTRAINT fk_kho_sanpham
  FOREIGN KEY (MaSP)
  REFERENCES SanPham (MaSP);
    ALTER TABLE PhieuNhap
ADD CONSTRAINT fk_kho_phieunhap
  FOREIGN KEY (MaKho)
  REFERENCES Kho (MaKho);
     ALTER TABLE PhieuXuat
ADD CONSTRAINT fk_kho_phieuxuat
  FOREIGN KEY (MaKho)
  REFERENCES Kho (MaKho);

     ALTER TABLE CTPhieuNhap
ADD CONSTRAINT fk_phieunhap_ctphieunhap
  FOREIGN KEY (MaPhieuNhap)
  REFERENCES PhieuNhap (MaPhieuNhap);
  ALTER TABLE CTPhieuXuat
ADD CONSTRAINT fk_phieunhap_ctphieuxuat
  FOREIGN KEY (MaPhieuXuat)
  REFERENCES PhieuXuat(MaPhieuXuat);

     ALTER TABLE CTHoaDon
ADD CONSTRAINT fk_sanpham_cthoadon
  FOREIGN KEY (MaSP)
  REFERENCES SanPham (MaSP);