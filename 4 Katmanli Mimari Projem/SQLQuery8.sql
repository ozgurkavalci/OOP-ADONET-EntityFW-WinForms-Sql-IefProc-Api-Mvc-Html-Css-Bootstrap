create proc SEkle
@StudyoAdi nvarchar(50),
@StudyoKurulusTarih date,
@StudyoMerkez nvarchar(50),
@StudyoNetDeger money
as begin
insert into Studios (StudyoAdi,StudyoKurulusTarih,StudyoMerkez,StudyoNetDeger)
values (@StudyoAdi,@StudyoKurulusTarih,@StudyoMerkez,@StudyoNetDeger)
end


create proc SG
@StudyoID int,
@StudyoAdi nvarchar(50),
@StudyoKurulusTarih date,
@StudyoMerkez nvarchar(50),
@StudyoNetDeger money
as begin
update Studios set  StudyoAdi=@StudyoAdi,StudyoKurulusTarih=@StudyoKurulusTarih,
StudyoMerkez=@StudyoMerkez,StudyoNetDeger=@StudyoNetDeger where StudyoID=@StudyoID
end

create proc SSil
@StudyoID int
as begin
delete from Studios where StudyoID=@StudyoID
end

create proc SListele
as begin
select*from Studios
end

create proc SArama
@StudyoID int
as begin
select*from Studios where StudyoID=@StudyoID
end


create proc SAdiArama
@StudyoAdi nvarchar(50)
as begin
select*from Studios where StudyoAdi=@StudyoAdi
end



create proc CEkle
@MerkezLokasyon nvarchar(50),
@MerkezKurulusTarihi date,
@MerkezCalisanSayisi int,
@MerkezYillikCiro money,
@StudyoID int,
@StudyoAdi nvarchar(50)
as begin
insert into Centers (MerkezLokasyon,MerkezKurulusTarihi,MerkezCalisanSayisi,MerkezYillikCiro,StudyoID,StudyoAdi)
values (@MerkezLokasyon,@MerkezKurulusTarihi,@MerkezCalisanSayisi,@MerkezYillikCiro,@StudyoID,@StudyoAdi)
end

create proc CG
@MerkezID int,
@MerkezLokasyon nvarchar(50),
@MerkezKurulusTarihi date,
@MerkezCalisanSayisi int,
@MerkezYillikCiro money,
@StudyoID int,
@StudyoAdi nvarchar(50)
as begin
update Centers set MerkezLokasyon=@MerkezLokasyon,MerkezKurulusTarihi=@MerkezKurulusTarihi,MerkezCalisanSayisi=@MerkezCalisanSayisi,
MerkezYillikCiro=@MerkezYillikCiro,StudyoID=@StudyoID,StudyoAdi=@StudyoAdi where MerkezID=@MerkezID
end

create proc CSil
@MerkezID int
as begin
delete from Centers where MerkezID=@MerkezID
end


create proc CListele
as begin
select*from Centers 
end

create proc CArama
@MerkezID int
as begin
select*from Centers where MerkezID=@MerkezID
end


create proc CLokasyonArama
@MerkezLokasyon nvarchar(50)
as begin
select*from Centers where MerkezLokasyon=@MerkezLokasyon
end






create proc DEkle
@AdSoyad nvarchar(50),
@Yas int,
@Cinsiyet nchar(10),
@Ulke nvarchar(50),
@IseBaslamaTarihi date,
@UzmanlikAlani nvarchar(50),
@MerkezID int
as begin
insert into Devs (AdSoyad,Yas,Cinsiyet,Ulke,IseBaslamaTarihi,UzmanlikAlani,MerkezID)
values (@AdSoyad,@Yas,@Cinsiyet,@Ulke,@IseBaslamaTarihi,@UzmanlikAlani,@MerkezID)
end


create proc DG
@DeveloperID int,
@AdSoyad nvarchar(50),
@Yas int,
@Cinsiyet nchar(10),
@Ulke nvarchar(50),
@IseBaslamaTarihi date,
@UzmanlikAlani nvarchar(50),
@MerkezID int
as begin
update Devs set AdSoyad=@AdSoyad,Yas=@Yas,Cinsiyet=@Cinsiyet,Ulke=@Ulke,IseBaslamaTarihi=@IseBaslamaTarihi,UzmanlikAlani=@UzmanlikAlani,
MerkezID=@MerkezID where DeveloperID=@DeveloperID 
end

create proc DSil
@DeveloperID int
as begin
delete from Devs where DeveloperID=@DeveloperID
end


create proc DListele
as begin
select*from Devs
end


create proc DArama
@DeveloperID int
as begin
select*from Devs where DeveloperID=@DeveloperID
end

create proc DAdArama
@AdSoyad nvarchar(50)
as begin
select*from Devs where AdSoyad like @AdSoyad
end



create proc GEkle
@OyunTuru nvarchar(50),
@OyunAdi nvarchar(50),
@OyunCikisTarihi date,
@OyunSatilanKopya int,
@AdSoyad nvarchar(50),
@StuyoAdi nvarchar(50)
as begin
insert into Games (OyunTuru,OyunAdi,OyunCikisTarihi,OyunSatilanKopya,AdSoyad,StudyoAdi)
values (@OyunTuru,@OyunAdi,@OyunCikisTarihi,@OyunSatilanKopya,@AdSoyad,@StuyoAdi)
end

create proc GG
@OyunID int,
@OyunTuru nvarchar(50),
@OyunAdi nvarchar(50),
@OyunCikisTarihi date,
@OyunSatilanKopya int,
@AdSoyad nvarchar(50),
@StuyoAdi nvarchar(50)
as begin
update Games set OyunTuru=@OyunTuru,OyunAdi=@OyunAdi,OyunCikisTarihi=@OyunCikisTarihi,OyunSatilanKopya=@OyunSatilanKopya,
AdSoyad=@AdSoyad,StudyoAdi=@StuyoAdi where OyunID=@OyunID 
end

create proc GSil
@OyunID int
as begin
delete from Games where OyunID=@OyunID
end


create proc GListele
as begin
select*from Games
end


create proc GArama
@OyunID int
as begin
select*from Games where OyunID=@OyunID
end


create proc GAdArama
@OyunAdi nvarchar(50)
as begin
select*from Games where OyunAdi=@OyunAdi
end






create proc UEkle
@UserName nvarchar(50),
@UserPw nvarchar(50),
@UserMail nvarchar(50)
as begin
insert into Users (UserName,UserPw,UserMail)
values(@UserName,@UserPw,@UserMail)
end

create proc UEkleKontrol
@UserName nvarchar(50),
@UserMail nvarchar(50)
as begin
select*from Users where UserName=@UserName or UserMail=@UserMail
end



create proc UArama
@UserName nvarchar(50),
@UserPw nvarchar(50)
as begin
select*from Users where UserName=@UserName and UserPw=@UserPw
end

