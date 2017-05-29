CREATE TABLE CHUYENNGANH
(
MANGANH varchar(6) not null primary key,
TENNGANH nvarchar(30) not null,
)
CREATE TABLE MONHOC
(
MAMH varchar(6) not null primary key,
TENMH nvarchar(30) not null,
SOTIET int not null,
)
CREATE TABLE DIEM
(
MASV varchar(6) not null,
MAMH varchar(6) not null,
HOCKY int not null,
DIEM float not null,
primary key(MASV,MAMH),
)
CREATE TABLE HOCBONG
(
MAHB varchar(6) not null ,
MASV varchar(6) not null,
HOCKY int not null,
primary key (MAHB,MASV,HOCKY),
)
CREATE TABLE LOAIHOCBONG
(
MAHB varchar(6) not null primary key,
MUCHB nvarchar(20) not null,
SOTIEN varchar(10) not null,
TENHOCBONG nvarchar(30) not null,
)
