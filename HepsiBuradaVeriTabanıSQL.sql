--create database hepsiburada;
--use hepsiburada;


create table tblMusteri(
	MusteriID int identity(1,1) not null primary key,
	MusteriAdi varchar(30) not null,
	MusteriSoyadi varchar(20) not null,
	MusteriTelNo varchar(15) not null,
	MusteriAdres varchar(50) not null,
	MusteriMaili varchar(30) not null
);

create table tblUretici(
	UreticiID int identity(1,1) not null primary key,
	UreticiAdi varchar(40) not null,
	UreticiTelNo varchar(15) not null,
	UreticiMaili varchar(30) not null,
);

create table tblUrun(
	UrunID int identity(1,1) not null primary key,
	UrunAdi varchar(50) not null,
	UreticiID int not null foreign key references tblUretici(UreticiID)
);

create table tblTedarikci(
	TedarikciID int identity(1,1) not null primary key,
	TedarikciAdi varchar(30) not null,
	TedarikciTelNo varchar(15) not null,
	TedarikciAdres varchar(50) not null,
	TedarikciMaili varchar(30) not null,
	UreticiID int not null foreign key references tblUretici(UreticiID)
);

create table tblSatis(
	SatisID int identity(1,1) not null primary key,
	MusteriID int not null foreign key references tblMusteri(MusteriID),
	UrunID int not null foreign key references tblUrun(UrunID),
	TedarikciID int not null foreign key references tblTedarikci(TedarikciID),
	SatisTarihi datetime not null,
	SatýsDurumu varchar not null,
	Adet int not null,
);