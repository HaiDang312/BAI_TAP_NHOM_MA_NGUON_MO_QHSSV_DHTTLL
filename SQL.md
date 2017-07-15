# CODE XÂY DỰNG CƠ SỞ DỮ LIỆU

CREATE DATABASE QLHSSV_TTLL;

use QLHSSV_TTLL

go

	Create table DANGNHAP
	(
	id varchar(8) primary key not null,
	hoTen nvarchar(30) NOT NULL,
	tenDangNhap nvarchar(20) NOT NULL,
	matKhau nvarchar(20) NOT NULL,
	)

	Create table KHOA
	(
	MAKHOA	varchar(6)primary key not null,  
	TENKHOA	nvarchar(70)      NOT NULL,
	)


	Create table LOP
	(
	MALOP	varchar(6)primary key not null,
	TENLOP	nvarchar(70)         NOT NULL,
	MAKHOA varchar(6) not null FOREIGN KEY REFERENCES KHOA(MAKHOA) on delete cascade,
	)

	Create table CHUYENNGANH
	(
	MANGANH     varchar(8) primary key not null,   
	TENNGANH	nvarchar(70) NOT NULL,
	)

	Create table SINHVIEN
	(	
	MASV	    	varchar(13) primary key not null,
	HOSV        	nvarchar(15) not null,           
	TENSV	    	nvarchar(10)  NOT NULL,
	MALOP	    	varchar(6) not null FOREIGN KEY REFERENCES LOP(MALOP) on delete cascade,
	MAKHOA	    	varchar(6) not null FOREIGN KEY REFERENCES KHOA(MAKHOA),
	MANGANH    	varchar(8) not null FOREIGN KEY REFERENCES CHUYENNGANH(MANGANH) on delete cascade,
	NGAYSINH	date       NOT NULL,
	GIOITINH	bit       NOT NULL,
	DIACHI	    	nvarchar(100)       NOT NULL,
	DOANVIEN	bit        NOT NULL,
	NGAYVD	    	date        NOT NULL,
	NOIKETNAP	nvarchar(20) NOT NULL,
	SOCMND	    int         NOT NULL,
	NGAYCAP	    date            NOT NULL,
	NOICAP	    nvarchar(20)    NOT NULL,
	HEDAOTAO	nvarchar(10)    NOT NULL,
	NAMTUYENSINH	date        NOT NULL,
	DANTOC	    nvarchar(20)    NOT NULL,		
	)

	Create table HOCBONG
	(
	MAHB	varchar(8) not null FOREIGN KEY REFERENCES LOAIHOCBONG(MAHB) on delete cascade,      
	MASV	varchar(13)FOREIGN KEY REFERENCES SINHVIEN(MASV) on delete cascade   NOT NULL,
	HOCKY 	varchar(10)  not null,
	constraint PK primary key (MAHB, MASV, HOCKY),
	)

	Create table LOAIHOCBONG
	(
	MAHB	varchar(8) primary key not null,      
	MUCHB	varchar(13)  NOT NULL,
	SOTIEN varchar(10)  not null,
	TENHB nvarchar(30) not null,
	)

	Create table  DOITUONG
	(
	MADT	varchar(8) primary key not null,  
	TENDOITUONG	nvarchar(60)           NOT NULL,
	CHEDOMIENGIAM	nvarchar(100)         NOT NULL,
	)

	create table SV_DOITUONG
	(
	MASV	varchar(13) not null FOREIGN KEY REFERENCES SINHVIEN(MASV) on delete cascade,
	MADT	varchar(8) not null FOREIGN KEY REFERENCES DOITUONG(MADT) on delete cascade,
	constraint PK1 primary key (MASV, MADT),
	)

	create table KHENTHUONG
	(
	MAKT varchar(8) primary key not null,
	TENKT nvarchar(100) not null,
	GHICHU nvarchar(500) not null,
	)

	create table QTKHENTHUONG
	(
	MASV	varchar(13) not null FOREIGN KEY REFERENCES SINHVIEN(MASV) on delete cascade,
	MAKT varchar(8)  not null FOREIGN KEY REFERENCES KHENTHUONG(MAKT) on delete cascade,
	NGAYKT date not null,
	constraint PK2 primary key (MASV, MAKT, NGAYKT),
	)
	
	create table KYLUAT
	(
	MAKL varchar(8) primary key not null,
	TENKL nvarchar(100) not null,
	GHICHU nvarchar(500) not null,
	)

	create table QTKYLUAT
	(
	MASV	varchar(13) not null FOREIGN KEY REFERENCES SINHVIEN(MASV) on delete cascade,
	MAKL varchar(8)  not null FOREIGN KEY REFERENCES KYLUAT(MAKL) on delete cascade,
	NGAYKL date not null,
	NGAYHH date not null,
	constraint PK3 primary key (MASV, MAKL, NGAYKL),
	)

	create table MONHOC
	(
	MAMH varchar(6) primary key not null,
	TENMH nvarchar(50) not null,
	SOTIET int not null
	)
	
	create table DIEM
	(
	MASV varchar(13)  FOREIGN KEY REFERENCES SINHVIEN(MASV) on delete cascade  NOT NULL,
	MAMH varchar(6)  FOREIGN KEY REFERENCES MONHOC(MAMH) on delete cascade NOT NULL,
	HOCKY varchar(10) not null,
	DIEMCC decimal(10,2) not null,
	DIEMTX decimal(10,2) not null,
	DIEMGK decimal(10,2) not null,
	DIEMTHI decimal(10,2) not null,
	constraint PK4 primary key ( MASV, MAMH)
	)
