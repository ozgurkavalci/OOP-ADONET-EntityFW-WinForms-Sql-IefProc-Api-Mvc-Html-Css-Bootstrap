USE [Okul]
GO
/****** Object:  StoredProcedure [dbo].[OAdd]    Script Date: 22.04.2022 18:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[OAdd]
@Adsoyad varchar(50),
@TcNo char(11),
@Telefon nchar(11),
@Mail varchar(50),
@Adres varchar(50),
as begin
insert into Ogrenciler (Adsoyad,TcNo,Telefon,Mail,Adres)
values(@Adsoyad,@TcNo,@Telefon,@Mail,@Adres)
end