
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/21/2022 17:18:14
-- Generated from EDMX file: C:\Users\STUDENT2\Desktop\20042022-Model First Kitapçı\Kitapçı\BookStore.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyBookStore];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MusteriSube]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sube] DROP CONSTRAINT [FK_MusteriSube];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonelSube]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sube] DROP CONSTRAINT [FK_PersonelSube];
GO
IF OBJECT_ID(N'[dbo].[FK_UrunMusteri]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Musteri] DROP CONSTRAINT [FK_UrunMusteri];
GO
IF OBJECT_ID(N'[dbo].[FK_SubePersonel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personel] DROP CONSTRAINT [FK_SubePersonel];
GO
IF OBJECT_ID(N'[dbo].[FK_SubeUrun]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Urun] DROP CONSTRAINT [FK_SubeUrun];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Musteri]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Musteri];
GO
IF OBJECT_ID(N'[dbo].[Urun]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Urun];
GO
IF OBJECT_ID(N'[dbo].[Sube]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sube];
GO
IF OBJECT_ID(N'[dbo].[Personel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personel];
GO
IF OBJECT_ID(N'[dbo].[Kullanici]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kullanici];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Musteri'
CREATE TABLE [dbo].[Musteri] (
    [MusteriID] int IDENTITY(1,1) NOT NULL,
    [MusteriAdSoyad] nvarchar(max)  NOT NULL,
    [MusteriTcNO] nchar(11)  NOT NULL,
    [MusteriMail] nvarchar(max)  NOT NULL,
    [MusteriTelefon] nchar(10)  NOT NULL,
    [MusteriAdres] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Urun'
CREATE TABLE [dbo].[Urun] (
    [UrunID] int IDENTITY(1,1) NOT NULL,
    [UrunTuru] nvarchar(max)  NOT NULL,
    [UrunKategori] nvarchar(max)  NOT NULL,
    [UrunAdi] nvarchar(max)  NOT NULL,
    [UrunCikisYili] int  NOT NULL,
    [UrunYazarAdi] nvarchar(max)  NOT NULL,
    [UrunAdet] int  NOT NULL,
    [UrunFiyat] decimal(18,0)  NOT NULL,
    [MusteriMusteriID] int  NOT NULL
);
GO

-- Creating table 'Sube'
CREATE TABLE [dbo].[Sube] (
    [SubeID] int IDENTITY(1,1) NOT NULL,
    [SubeAdi] nvarchar(max)  NOT NULL,
    [SubeCiro] decimal(18,0)  NOT NULL,
    [SubePersonelSayisi] int  NOT NULL,
    [UrunUrunID] int  NOT NULL
);
GO

-- Creating table 'Personel'
CREATE TABLE [dbo].[Personel] (
    [PersonelID] int IDENTITY(1,1) NOT NULL,
    [PersonelAdSoyad] nvarchar(max)  NOT NULL,
    [PersonelTcNo] nchar(11)  NOT NULL,
    [PersonelYas] int  NOT NULL,
    [PersonelMail] nvarchar(max)  NOT NULL,
    [PersonelTelefon] nchar(10)  NOT NULL,
    [PersonelAdres] nvarchar(max)  NOT NULL,
    [SubeSubeID] int  NOT NULL
);
GO

-- Creating table 'Kullanici'
CREATE TABLE [dbo].[Kullanici] (
    [KullaniciID] int IDENTITY(1,1) NOT NULL,
    [KullaniciAdi] nvarchar(max)  NOT NULL,
    [KullaniciSifre] nvarchar(max)  NOT NULL,
    [KullaniciMail] nvarchar(max)  NOT NULL,
    [KulllaniciTelefon] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MusteriID] in table 'Musteri'
ALTER TABLE [dbo].[Musteri]
ADD CONSTRAINT [PK_Musteri]
    PRIMARY KEY CLUSTERED ([MusteriID] ASC);
GO

-- Creating primary key on [UrunID] in table 'Urun'
ALTER TABLE [dbo].[Urun]
ADD CONSTRAINT [PK_Urun]
    PRIMARY KEY CLUSTERED ([UrunID] ASC);
GO

-- Creating primary key on [SubeID] in table 'Sube'
ALTER TABLE [dbo].[Sube]
ADD CONSTRAINT [PK_Sube]
    PRIMARY KEY CLUSTERED ([SubeID] ASC);
GO

-- Creating primary key on [PersonelID] in table 'Personel'
ALTER TABLE [dbo].[Personel]
ADD CONSTRAINT [PK_Personel]
    PRIMARY KEY CLUSTERED ([PersonelID] ASC);
GO

-- Creating primary key on [KullaniciID] in table 'Kullanici'
ALTER TABLE [dbo].[Kullanici]
ADD CONSTRAINT [PK_Kullanici]
    PRIMARY KEY CLUSTERED ([KullaniciID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UrunUrunID] in table 'Sube'
ALTER TABLE [dbo].[Sube]
ADD CONSTRAINT [FK_UrunSube]
    FOREIGN KEY ([UrunUrunID])
    REFERENCES [dbo].[Urun]
        ([UrunID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UrunSube'
CREATE INDEX [IX_FK_UrunSube]
ON [dbo].[Sube]
    ([UrunUrunID]);
GO

-- Creating foreign key on [SubeSubeID] in table 'Personel'
ALTER TABLE [dbo].[Personel]
ADD CONSTRAINT [FK_SubePersonel]
    FOREIGN KEY ([SubeSubeID])
    REFERENCES [dbo].[Sube]
        ([SubeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SubePersonel'
CREATE INDEX [IX_FK_SubePersonel]
ON [dbo].[Personel]
    ([SubeSubeID]);
GO

-- Creating foreign key on [MusteriMusteriID] in table 'Urun'
ALTER TABLE [dbo].[Urun]
ADD CONSTRAINT [FK_MusteriUrun]
    FOREIGN KEY ([MusteriMusteriID])
    REFERENCES [dbo].[Musteri]
        ([MusteriID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MusteriUrun'
CREATE INDEX [IX_FK_MusteriUrun]
ON [dbo].[Urun]
    ([MusteriMusteriID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------