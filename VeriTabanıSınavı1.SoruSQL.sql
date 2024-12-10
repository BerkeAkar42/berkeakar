--create database ProjeBilgileri;
--use ProjeBilgileri;
create table tblCalisan
	(
		CalisanID int identity(1,1) not null primary key,
		CalisanAdi varchar(25) not null,
		CalisanPozisyonu varchar(50) not null,
		CalisanTelNo int not null,
		CalisanMaili varchar(40) not null
	);

create table tblSirket
	(
		SirketID int identity not null primary key,
		SirketAdi varchar(40) not null,
		SirketTelNo int not null,
		SirketMail varchar(40) not null
	);

create table tblProje
	(
		ProjeID int identity(1,1) not null primary key,
		ProjeAdi varchar(30) not null,
		ProjeBasTarihi datetime,
		ProjeBitisTarihi datetime,
		ProjeButce varchar,
		CalisanID int not null foreign key references tblCalisan(CalisanID),
		SirketID int not null foreign key references tblSirket(SirketID)
	);
