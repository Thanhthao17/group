create database Quanlysinhvien
go

use Quanlysinhvien
go

-- bảng: Đăng nhập
--thông tin
--danh mục các món ăn
--quản lý sinh viên
-- thông tin info : liên kết ddee tạo nhiều sinh viên trong danh mục

create table Thongtinnhom
(
	stt int identity,
	mssv int primary key not null,
	hovaten nvarchar(100) not null,
	lop nvarchar(10) not null
)
go

create table dangnhap
(
	
	username nvarchar(100) primary key,
	passlog nvarchar(1000) not null default 0
)
go

create table Danhmucmonan
(
	id int primary key,
	username nvarchar(100)	
)
go

create table quanlySV
(
	mssv int primary key,
	hosv nvarchar(100) not null,
	tensv nvarchar(100) not null,
	ngaysinh date not null,
	gioitinh nvarchar(10) not null,
	makhoa nvarchar(20) not null
)
go