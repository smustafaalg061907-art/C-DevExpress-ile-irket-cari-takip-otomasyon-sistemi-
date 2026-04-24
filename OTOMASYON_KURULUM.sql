-- STOK OTOMASYON VERITABANI KURULUM SCRIPT
CREATE DATABASE STOK_OTOMASYON;
GO

USE STOK_OTOMASYON;
GO

-- 1. Stok Grupları
CREATE TABLE StokGruplari (
    GrupKodu NVARCHAR(20) PRIMARY KEY,
    GrupAdi NVARCHAR(100) NOT NULL
);

-- 2. Stoklar
CREATE TABLE Stoklar (
    StokKodu NVARCHAR(30) PRIMARY KEY,
    StokAdi NVARCHAR(200) NOT NULL,
    Barkod NVARCHAR(50),
    Birim NVARCHAR(10) DEFAULT 'ADET',
    AlisFiyati DECIMAL(18,2) DEFAULT 0,
    SatisFiyati DECIMAL(18,2) DEFAULT 0,
    AlisKdv INT DEFAULT 18,
    SatisKdv INT DEFAULT 18,
    GrupKodu NVARCHAR(20),
    CONSTRAINT FK_Stoklar_Grup FOREIGN KEY (GrupKodu) REFERENCES StokGruplari(GrupKodu)
);

-- 3. Cari Grupları
CREATE TABLE CariGruplari (
    GrupKodu NVARCHAR(20) PRIMARY KEY,
    GrupAdi NVARCHAR(100) NOT NULL
);

-- 4. Cariler
CREATE TABLE Cariler (
    CariKodu NVARCHAR(30) PRIMARY KEY,
    CariAdi NVARCHAR(200) NOT NULL,
    VergiDairesi NVARCHAR(100),
    VergiNo NVARCHAR(20),
    Telefon NVARCHAR(20),
    Adres NVARCHAR(MAX),
    GrupKodu NVARCHAR(20),
    CONSTRAINT FK_Cariler_Grup FOREIGN KEY (GrupKodu) REFERENCES CariGruplari(GrupKodu)
);

-- 5. Bankalar
CREATE TABLE Bankalar (
    BankaKodu NVARCHAR(20) PRIMARY KEY,
    BankaAdi NVARCHAR(100) NOT NULL,
    SubeAdi NVARCHAR(100),
    HesapNo NVARCHAR(50),
    IBAN NVARCHAR(50),
    DovizTipi NVARCHAR(10) DEFAULT 'TL',
    Bakiye DECIMAL(18,2) DEFAULT 0
);

-- 6. Kasalar
CREATE TABLE Kasalar (
    KasaKodu NVARCHAR(20) PRIMARY KEY,
    KasaAdi NVARCHAR(100) NOT NULL,
    DovizTipi NVARCHAR(10) DEFAULT 'TL',
    Bakiye DECIMAL(18,2) DEFAULT 0
);

-- 7. Faturalar
CREATE TABLE Faturalar (
    FaturaNo NVARCHAR(30) PRIMARY KEY,
    FaturaTipi NVARCHAR(20),
    CariKodu NVARCHAR(30),
    Tarih DATETIME DEFAULT GETDATE(),
    AraToplam DECIMAL(18,2),
    KdvToplam DECIMAL(18,2),
    GenelToplam DECIMAL(18,2),
    Aciklama NVARCHAR(500),
    CONSTRAINT FK_Fatura_Cari FOREIGN KEY (CariKodu) REFERENCES Cariler(CariKodu)
);

-- 8. Çekler
CREATE TABLE Cekler (
    CekNo NVARCHAR(50) PRIMARY KEY,
    CekTipi NVARCHAR(20),
    CariKodu NVARCHAR(30),
    Tarih DATETIME DEFAULT GETDATE(),
    VadeTarihi DATETIME,
    Tutar DECIMAL(18,2),
    BankaAdi NVARCHAR(100),
    Durumu NVARCHAR(50),
    CONSTRAINT FK_Cek_Cari FOREIGN KEY (CariKodu) REFERENCES Cariler(CariKodu)
);
GO
