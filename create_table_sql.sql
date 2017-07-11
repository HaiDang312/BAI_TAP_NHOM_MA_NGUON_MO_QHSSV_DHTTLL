create table KHENTHUONG
(

	MAKT varchar(8) primary key not null,
	TENKT nvarchar(8) not null,
	GHICHU nvarchar(100) not null,

)

create table QTKHENTHUONG
(

	MASV	varchar(13) FOREIGN KEY REFERENCES SINHVIEN(MASV) on delete cascade on update cascade  NOT NULL ,
	MAKT varchar(8)  FOREIGN KEY REFERENCES KHENTHUONG(MAKT) on delete cascade on update cascade  NOT NULL ,
	NGAYKT date not null,
	constraint PK2 primary key (MASV, MAKT, NGAYKT),
)

create table KYLUAT
(

	MAKL varchar(8) primary key not null,
	TENKL nvarchar(8) not null,
	GHICHU nvarchar(100) not null,

)

create table QTKYLUAT
(

	MASV	varchar(13) FOREIGN KEY REFERENCES SINHVIEN(MASV) on delete cascade on update cascade  NOT NULL ,
	MAKL varchar(8)  FOREIGN KEY REFERENCES KYLUAT(MAKL) on delete cascade on update cascade  NOT NULL ,
	NGAYKL date not null,
	NGAYHH date not null,
	constraint PK3 primary key (MASV, MAKL, NGAYKL),
)