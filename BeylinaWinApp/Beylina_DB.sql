CREATE DATABASE Beylina_DB
GO
USE Beylina_DB
GO
CREATE TABLE Calisan
(
	ID int IDENTITY (1,1),
	Isim NVARCHAR(100) NOT NULL,
	Soyisim NVARCHAR(100) NOT NULL,
	Mail NVARCHAR(100) NOT NULL,
	Sifre NVARCHAR(30) NOT NULL,
	CONSTRAINT pk_Calisan PRIMARY KEY(ID)
)
GO
INSERT INTO Calisan (Isim, Soyisim, Mail, Sifre)
VALUES ('Burak', 'SALCAN', 'deneme@deneme.com', '1234');
GO
INSERT INTO Calisan (Isim, Soyisim, Mail, Sifre)
VALUES ('Murtaza', 'ÞUAYÝPOÐLU', 'mur@mur.com', '1234');
GO
SELECT * FROM Calisan
GO
CREATE TABLE Uye
(
	ID int IDENTITY (1,1),
	Isim NVARCHAR(100) NOT NULL,
	Soyisim NVARCHAR(100) NOT NULL,
	Mail NVARCHAR(100) NOT NULL,
	Sifre NVARCHAR(30) NOT NULL,
	KartNo NVARCHAR(20) NOT NULL,
	CONSTRAINT pk_Uye PRIMARY KEY(ID)
)
GO
INSERT INTO Uye (Isim, Soyisim, Mail, Sifre, KartNo)
VALUES ('Ali', 'KAPTAN', 'ali@ali.com', '1234', '0000000000000000');
GO
INSERT INTO Uye (Isim, Soyisim, Mail, Sifre, KartNo)
VALUES ('Neþe', 'ÇAY', 'nese@nese.com', '1234', '1111111111111111');
GO
SELECT * FROM Calisan
GO
CREATE TABLE Kategori
(
	ID int IDENTITY (1,1),
	Isim NVARCHAR(100) NOT NULL,
	Aciklama NVARCHAR(500) NOT NULL,
	AktifMi bit,
	CONSTRAINT pk_Kategori PRIMARY KEY(ID)
)
GO
INSERT INTO Kategori (Isim, Aciklama, AktifMi)
VALUES ('Beyaz Eþya', 'Beyaz eþyalarýn yer aldýðý kategori', 1);
GO
INSERT INTO Kategori (Isim, Aciklama, AktifMi)
VALUES ('PC', 'Bilgisayarlarýn yer aldýðý kategori', 1);
GO
INSERT INTO Kategori (Isim, Aciklama, AktifMi)
VALUES ('Telefon', 'Telefonlarýn yer aldýðý kategori', 1);
GO
SELECT * FROM Kategori
GO
CREATE TABLE Alt_Kategori
(
	ID int IDENTITY (1,1),
	Isim NVARCHAR(100) NOT NULL,
	Kategori_ID int,
	CONSTRAINT pk_altKategori PRIMARY KEY(ID),
	CONSTRAINT fk_altKategori_KategoriID FOREIGN KEY(Kategori_ID) REFERENCES Kategori(ID)
)
GO
INSERT INTO Alt_Kategori (Isim, Kategori_ID)
VALUES ('Çamaþýr Makinesi', 1)
GO
INSERT INTO Alt_Kategori (Isim, Kategori_ID)
VALUES ('Dizüstü Bilgisayar', 2)
GO
INSERT INTO Alt_Kategori (Isim, Kategori_ID)
VALUES ('Cep Telefonu', 3)
GO
SELECT * FROM Alt_Kategori
GO
CREATE TABLE Urunler
(
	ID INT IDENTITY (1,1),
	Isim NVARCHAR(100) NOT NULL,
	Kategori_ID INT NOT NULL,
	AltKategori_ID INT NOT NULL,
	UrunGorseli NVARCHAR(255) NULL,  -- Görselin dosya yolunu saklar (isteðe baðlý)
	Marka NVARCHAR(100) NULL,       -- Marka isteðe baðlý olabilir
	Aciklama NVARCHAR(500) NULL,    -- Açýklama isteðe baðlý olabilir
	Fiyat DECIMAL(8,2) NOT NULL, 
	Stok INT NOT NULL,
	CONSTRAINT pk_Urunler PRIMARY KEY(ID),
	CONSTRAINT fk_urunlerKategoriID FOREIGN KEY(Kategori_ID) REFERENCES Kategori(ID),
	CONSTRAINT fk_urunlerAltKategoriID FOREIGN KEY(AltKategori_ID) REFERENCES Alt_Kategori(ID)
)
GO
INSERT INTO Urunler (Isim, Kategori_ID, AltKategori_ID, UrunGorseli, Marka, Aciklama, Fiyat, Stok)
VALUES 
('Çamaþýr Makinesi', 
 1,  -- Kategori_ID (Beyaz Eþya)
 1,  -- AltKategori_ID (Çamaþýr Makinesi)
 'C:/Users/burak/Desktop/Çetintaþ Staj/Çamaþýr Makinesi.jpg',  -- Görsel dosya yolu
 'BOSCH',  -- Marka
 'Çamaþýr makinesi, 7 kg kapasiteye sahip, enerji verimli. Bu cihaz çok iyi çamaþýr yýkar.',  -- Açýklama
 12999.99,  -- Fiyat
 50);  -- Stok
 GO
INSERT INTO Urunler (Isim, Kategori_ID, AltKategori_ID, UrunGorseli, Marka, Aciklama, Fiyat, Stok)
VALUES 
('Macbook Pro', 
 2,
 2,
 'C:/Users/burak/Desktop/Çetintaþ Staj/PC.jpeg',
 'Apple',  -- Marka
 'Her iyi yapabilen süper bir dizüstü pc.',
 85999.99,
 46);
 GO
INSERT INTO Urunler (Isim, Kategori_ID, AltKategori_ID, UrunGorseli, Marka, Aciklama, Fiyat, Stok)
VALUES 
('Samsung S24 Ultra', 
 3,
 3,
 'C:/Users/burak/Desktop/Çetintaþ Staj/Cep Tel.jpg',
 'Samsung',  -- Marka
 'Ýsviçre çakýsý gibi bir telefon.',
 64999.99,
 31);
 GO
 SELECT * FROM Urunler

