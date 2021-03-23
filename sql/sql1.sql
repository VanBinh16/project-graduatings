create table nhanvien
(
manv nvarchar(10) primary key,
tennv nvarchar(30),
gioitinh bit,
ngaysinh date,
cmnd nvarchar(10),
sdt nvarchar(10),
email nvarchar(30),
diachi nvarchar(50),
ngaylam datetime,
ghichu nvarchar(20),
luong money,
chucvu int,
taikhoan int,
)
create table taikhoan
(
ma nvarchar (10)primary key,
tendangnhap nvarchar(20) ,
matkhau nvarchar(10),
loai int,
)
create table chucvu
(
loai int primary key, 
ten nvarchar(20),
)
create table khachhang
(
mankh nvarchar(10) primary key,
tenkh nvarchar(30),
gioitinh bit,
ngaysinh date,
sdt nvarchar(10),
email nvarchar(30),
diachi nvarchar(50),
)
create table DanhmucSP
(
madm nvarchar(10) primary key,
tendm nvarchar(30),
)
create table nhacc
(
mancc int primary key,
tenncc nvarchar(20),
email nvarchar(20),
sdt nvarchar(10),
diachi nvarchar(50),
)
create table sanpham
(
masp nvarchar(10) primary key,
tensp nvarchar(50),
giaban money,
madm nvarchar(10),
gianhap money, 
slton int ,
mota nvarchar(50),
hinh nvarchar(50),
)
create table hoadon
(
mahd nvarchar(10) primary key,
ngaylaphd datetime,
manv nvarchar(10),
giam nvarchar(10),
tongtienhd money,
)
create table chitiethoadon
(
mahd nvarchar(10),
masp nvarchar(10),
gia money,
soluong int,
tongtien money,
)
create table kho
(
makho nvarchar(10) primary key,
tenkho nvarchar(30),
diachi nvarchar(30),
)
create table phieunx
(
maphieu nvarchar(10) primary key,
ngaylap datetime,
tongtien money,
chietkhau nvarchar(10),
thanhtoan money,
manv nvarchar(10),
makho nvarchar(10),
)
create table chitieuphieu
(
maphieu nvarchar(10),
masp nvarchar(10),
soluong int, 
gia money,

)