USE [Okul]
GO
/****** Object:  StoredProcedure [dbo].[OY]    Script Date: 22.04.2022 18:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[OY]
@OgrenciNo int,
@Adsoyad varchar(50),
@TcNo char(11),
@Telefon nchar(11),
@Mail varchar(50),
@Adres varchar(50)
as begin
update Ogrenciler set Adsoyad=@Adsoyad,TcNo=@TcNo,Telefon=@Telefon,Mail=@Mail,Adres=@Adres where 
OgrenciNo=@OgrenciNo
end