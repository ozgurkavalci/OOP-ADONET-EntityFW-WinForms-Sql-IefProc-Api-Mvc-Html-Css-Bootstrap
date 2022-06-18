
create proc HArama
@HizmetNo int
as begin
select*from Hizmetler where HizmetNo=@HizmetNo
end

create proc HEkle
@HizmetAdi varchar(50),
@HizmetTanimi varchar(50),
@HizmetFiyat money
as begin 
insert into Hizmetler(HizmetAdi,HizmetTanimi,HizmetFiyat)
values (@HizmetAdi,@HizmetTanimi,@HizmetFiyat)
end



create proc HGor
as begin
select*from Hizmetler
end



create proc HG
@HizmetNo int,
@HizmetAdi varchar(50),
@HizmetTanimi varchar(50),
@HizmetFiyat money
as begin 
update Hizmetler set HizmetAdi=@HizmetAdi,HizmetTanimi=@HizmetTanimi,HizmetFiyat=@HizmetFiyat where HizmetNo=@HizmetNo
end


create proc HSil
@HizmetNo int
as begin 
delete from Hizmetler where HizmetNo=@HizmetNo
end


create proc HOEkle
@HizmetOzellikHizmetNo int,
@HizmetAciklama nvarchar(50),
@HizmetOzellikEkstra nvarchar(50)
as begin
insert into HizmetOzellikler(HizmetOzellikHizmetNo,HizmetAciklama,HizmetOzellikEkstra)
values (@HizmetOzellikHizmetNo,@HizmetAciklama,@HizmetOzellikEkstra)
end

create proc HOGor
as begin
select*from HizmetOzellikler
end

create proc HOG
@HizmetOzellikNo int,
@HizmetOzellikHizmetNo int,
@HizmetAciklama nvarchar(50),
@HizmetOzellikEkstra nvarchar(50)
as begin
update HizmetOzellikler set HizmetOzellikHizmetNo=@HizmetOzellikHizmetNo,HizmetAciklama=@HizmetAciklama,HizmetOzellikEkstra=@HizmetOzellikEkstra 
where HizmetOzellikNo=@HizmetOzellikNo
end

create proc HOSil
@HizmetOzellikNo int
as begin 
delete from HizmetOzellikler where HizmetOzellikNo=@HizmetOzellikNo
end


create proc SEkle
@SiparisAdi nvarchar(50),
@SiparisMusteriNo int,
@SiparisAdres nvarchar(50),
@SiparisAciklama nvarchar(50)
as begin
insert into Siparisler (SiparisAdi,SiparisMusteriNo,SiparisAdres,SiparisAciklama)
values (@SiparisAdi,@SiparisMusteriNo,@SiparisAdres,@SiparisAciklama)
end

create proc SGor
as begin
select*from Siparisler
end


create proc SG
@SiparisNo int,
@SiparisAdi nvarchar(50),
@SiparisMusteriNo int,
@SiparisAdres nvarchar(50),
@SiparisAciklama nvarchar(50)
as begin
update Siparisler set SiparisAdi=@SiparisAdi,SiparisMusteriNo=@SiparisMusteriNo,SiparisAdres=@SiparisAdres,
SiparisAciklama=@SiparisAciklama where SiparisNo=@SiparisNo
end

create proc SSil
@SiparisNo int
as begin 
delete from Siparisler where SiparisNo=@SiparisNo
end


create proc MEkle
@MusteriAdSoyad nvarchar(50),
@MusteriCinsiyet nchar(10),
@MusteriTelefon char(10),
@MusteriTcNo char(11),
@MusteriAdres nvarchar(50),
@MusteriHizmetNo int,
@MusteriMail nvarchar(50)
as begin
insert into Musteriler(MusteriAdSoyad,MusteriCinsiyet,MusteriTelefon,MusteriTcNo,MusteriAdres,MusteriHizmetNo,MusteriMail)
values (@MusteriAdSoyad,@MusteriCinsiyet,@MusteriTelefon,@MusteriTcNo,@MusteriAdres,@MusteriHizmetNo,@MusteriMail)
end


create proc MGor
as begin
select*from Musteriler
end


create proc MG
@MusteriNo int,
@MusteriAdSoyad nvarchar(50),
@MusteriCinsiyet nchar(10),
@MusteriTelefon char(10),
@MusteriTcNo char(11),
@MusteriAdres nvarchar(50),
@MusteriHizmetNo int,
@MusteriMail nvarchar(50)
as begin
update Musteriler set MusteriAdSoyad=@MusteriAdSoyad,MusteriCinsiyet=@MusteriCinsiyet,
MusteriTelefon=@MusteriTelefon,MusteriTcNo=@MusteriTcNo,MusteriAdres=@MusteriAdres,MusteriHizmetNo=@MusteriHizmetNo,MusteriMail=@MusteriMail
where MusteriNo=@MusteriNo
end


create proc MSil
@MusteriNo int
as begin
delete from Musteriler where MusteriNo=@MusteriNo
end