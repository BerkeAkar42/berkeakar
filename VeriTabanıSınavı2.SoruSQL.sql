--create database E_Ticaret
use E_Ticaret
create table tblMusteri
	(
		MusteriID int identity(1,1) not null primary key,
		MusteriAdi varchar(30) not null,
		MusteriTelNo int not null,
	);

create table tblTedarikci
	(
		TedarikciID int identity(1,1) not null primary key,
		TedarikciAdi varchar(30) not null,
		TedarikciTel decimal(11) not null,
		TedarikciMail varchar(40) not null,
	);

create table tblUrun
	(
		UrunID int identity(1,1) not null primary key,
		UrunAdi varchar(50) not null,
		UrunFiyat varchar(20) not null,
		UrunMikari int not null,
		TedarikciID int not null foreign key references tblTedarikci(TedarikciID)
	);

create table tblSatinAlma
	(
		SatinID int identity(1,1) not null primary key,
		OdemeDurumu varchar(15) not null,
		SatinAlmaTarihi datetime not null,
		UrunID int not null foreign key references tblUrun(UrunID),
		Adet int not null,
		SatisFiyati int not null,
		MusteriID int not null foreign key references tblMusteri(MusteriID)
	);