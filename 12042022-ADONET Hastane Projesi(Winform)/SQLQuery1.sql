
create proc DEkle
@DoktorAdýveSoyadý varchar(50),
@DoktoTcNo nvarchar(11),
@UzmanlýkAlaný nvarchar(50),
@Unvaný nvarchar(50),
@TelefonNumarasý nvarchar(11),
@Adres varchar(50),
@DoðumTarihi nvarchar(50),
@PoliklinikNo int
as begin
insert into Doktorlar (DoktorAdýveSoyadý,DoktorTcNo,UzmanlýkAlaný,Unvaný,TelefonNumarasý,Adres,DoðumTarihi,PoliklinikNo)
values (@DoktorAdýveSoyadý,@DoktoTcNo,@UzmanlýkAlaný,@Unvaný,@TelefonNumarasý,@Adres,@DoðumTarihi,@PoliklinikNo)
end

create proc DSil
@DoktorNo int
as begin
delete from Doktorlar where DoktorNo=@DoktorNo
end


create proc DG
@DoktorNo int,
@DoktorAdýveSoyadý varchar(50),
@DoktoTcNo nvarchar(11),
@UzmanlýkAlaný nvarchar(50),
@Unvaný nvarchar(50),
@TelefonNumarasý nvarchar(11),
@Adres varchar(50),
@DoðumTarihi nvarchar(50),
@PoliklinikNo int
as begin
update Doktorlar set DoktorAdýveSoyadý=@DoktorAdýveSoyadý,DoktorTcNo=@DoktoTcNo,UzmanlýkAlaný=@UzmanlýkAlaný,Unvaný=@Unvaný,
TelefonNumarasý=@TelefonNumarasý,Adres=@Adres,DoðumTarihi=@DoðumTarihi,PoliklinikNo=@PoliklinikNo where DoktorNo=@DoktorNo
end

create proc DGor
@DoktorNo int,
@DoktorAdýveSoyadý varchar(50),
@DoktorTcNo nvarchar(11)
as begin
select*from Doktorlar where DoktorNo=@DoktorNo and DoktorAdýveSoyadý=@DoktorAdýveSoyadý and DoktorTcNo=@DoktorTcNo
end


create proc DGorDNo
@DoktorNo int
as begin
select*from Doktorlar where DoktorNo=@DoktorNo
end

create proc DGorDADS
@DoktorAdýveSoyadý varchar(50)
as begin
select*from Doktorlar where DoktorAdýveSoyadý=@DoktorAdýveSoyadý
end

create proc DGorDTcNO
@DoktorTcNo nvarchar(11)
as begin
select*from Doktorlar where DoktorTcNo=@DoktorTcNo
end

create proc DGOSTER
as begin
select*from Doktorlar
end


create proc DListeleAZ
as begin
select*from Doktorlar order by DoktorAdýveSoyadý asc
end

create proc DListeleZA
as begin
select*from Doktorlar order by DoktorAdýveSoyadý desc
end



--Hastalar

create proc HEkle
@HastaAdýveSoyadý varchar(50),
@HastaTcNo char(11),
@HastaDoðumTarihi nvarchar(50),
@HastaBoy varchar(50),
@HastaYaþ int,
@HastaReçete nvarchar(50),
@HastaRaporDurumu nvarchar(50),
@HastaRandevuTarihi nvarchar(50),
@HastaTelefon nchar(10),
@HastaAdres varchar(50),
@HastaMail varchar(50),
@HizmetAldýðýBölüm varchar(50),
@DoktorNo int
as begin
insert into Hastalar (HastaAdýveSoyadý,HastaTcNo,HastaDoðumTarihi,HastaBoy,HastaYaþ,HastaReçete,HastaRaporDurumu,HastaRandevuTarihi,
HastaTelefon,HastaAdres,HastaMail,HizmetAldýðýBölüm,DoktorNo)
values (@HastaAdýveSoyadý,@HastaTcNo,@HastaDoðumTarihi,@HastaBoy,@HastaYaþ,@HastaReçete,@HastaRaporDurumu,@HastaRandevuTarihi,@HastaTelefon,
@HastaAdres,@HastaMail,@HizmetAldýðýBölüm,@DoktorNo)
end


create proc HSil
@HastaNo int
as begin
delete from Hastalar where HastaNo=@HastaNo
end


create proc HG
@HastaNo int,
@HastaAdýveSoyadý varchar(50),
@HastaTcNo char(11),
@HastaDoðumTarihi nvarchar(50),
@HastaBoy varchar(50),
@HastaYaþ int,
@HastaReçete nvarchar(50),
@HastaRaporDurumu nvarchar(50),
@HastaRandevuTarihi nvarchar(50),
@HastaTelefon nchar(10),
@HastaAdres varchar(50),
@HastaMail varchar(50),
@HizmetAldýðýBölüm varchar(50),
@DoktorNo int
as begin
update Hastalar set HastaAdýveSoyadý=@HastaAdýveSoyadý,HastaTcNo=@HastaTcNo,HastaDoðumTarihi=@HastaDoðumTarihi,HastaBoy=@HastaBoy,
HastaYaþ=@HastaYaþ,HastaReçete=@HastaReçete,HastaRaporDurumu=@HastaRaporDurumu,HastaRandevuTarihi=@HastaRandevuTarihi,
HastaTelefon=@HastaTelefon,HastaMail=@HastaMail,HizmetAldýðýBölüm=@HizmetAldýðýBölüm,DoktorNo=@DoktorNo where HastaNo=@HastaNo
end


create proc HGor
@HastaNo int,
@HastaAdýveSoyadý varchar(50),
@HastaTcNo int
as begin
select*from Hastalar where HastaNo=@HastaNo and HastaAdýveSoyadý=@HastaAdýveSoyadý and HastaTcNo=@HastaTcNo
end

create proc HGorHNo
@HastaNo int
as begin
select*from Hastalar where HastaNo=@HastaNo
end

create proc HGorHADS
@HastaAdýveSoyadý varchar(50)
as begin
select*from Hastalar where HastaAdýveSoyadý=@HastaAdýveSoyadý
end

create proc HGorHTcNo
@HastaTcNO char(11)
as begin
select*from Hastalar where HastaTcNo=@HastaTcNO
end

create proc HGOSTER
as begin
select*from Hastalar 
end


create proc HListeleAZ
as begin
select*from Hastalar order by HastaAdýveSoyadý asc
end

create proc HListeleZA
as begin
select*from Hastalar order by HastaAdýveSoyadý desc
end



--Poliklinik

create proc PEkle
@PoliklinikAdý varchar(50),
@PoliklinikUzmanSayýsý int,
@PoliklinikBaþkaný varchar(50),
@PoliklinikBaþHemþire varchar(50),
@YatakSayýsý int
as begin 
insert into Poliklinikler (PoliklinikAdý,PoliklinikUzmanSayýsý,PoliklinikBaþkaný,PoliklinikBaþHemþire,YatakSayýsý)
values (@PoliklinikAdý,@PoliklinikUzmanSayýsý,@PoliklinikBaþkaný,@PoliklinikBaþHemþire,@YatakSayýsý)
end

create proc PSil
@PoliklinikNo int
as begin
delete from Poliklinikler where PoliklinikNo=@PoliklinikNo
end


create proc PG
@PoliklinikNo int,
@PoliklinikAdý varchar(50),
@PoliklinikUzmanSayýsý int,
@PoliklinikBaþkaný varchar(50),
@PoliklinikBaþHemþire varchar(50),
@YatakSayýsý int
as begin
update Poliklinikler set PoliklinikAdý=@PoliklinikAdý,PoliklinikUzmanSayýsý=@PoliklinikUzmanSayýsý,PoliklinikBaþkaný=@PoliklinikBaþkaný,
PoliklinikBaþHemþire=@PoliklinikBaþHemþire,YatakSayýsý=@YatakSayýsý where PoliklinikNo=@PoliklinikNo
end

create proc PGor
@PoliklinikNo int,
@PoliklinikAdý varchar(50)
as begin
select*from Poliklinikler where PoliklinikNo=@PoliklinikNo and PoliklinikAdý=@PoliklinikAdý
end

create proc PGorPNo
@PoliklinikNo int
as begin
select*from Poliklinikler where PoliklinikNo=@PoliklinikNo
end

create proc PGorPAdý
@PoliklinikAdý varchar(50)
as begin
select*from Poliklinikler where PoliklinikAdý=@PoliklinikAdý
end


create proc PGOSTER
as begin
select*from Poliklinikler
end

create proc PListeleAZ
as begin
select*from Poliklinikler order by PoliklinikAdý asc
end

create proc PListeleZA
as begin
select*from Poliklinikler order by PoliklinikAdý desc
end


--Teþhisler


create proc TEkle2
@HastaNo int,
@HastaAdýveSoyadý nvarchar(50),
@TeþhisiKoyanDoktorAdý varchar(50),
@TeþhisiKoyanDoktorNo int,
@TeþhisinKonduðuBölümAdý nvarchar(50),
@TeþhisinKonduðuBölümNo int,
@TeþhisTarihi nvarchar(50)
as begin
insert into Teþhisler (HastaNo,HastaAdýveSoyadý,TeþhisiKoyanDoktorAdý,TeþhisKoyanDoktorNo,TeþhisinKonduðuBölümAdý,TeþhisinKonduðuBölümNo,TeþhisTarihi)
values (@HastaNo,@HastaAdýveSoyadý,@TeþhisiKoyanDoktorAdý,@TeþhisiKoyanDoktorNo,@TeþhisinKonduðuBölümAdý,@TeþhisinKonduðuBölümNo,@TeþhisTarihi)
end

create proc TSil
@TeþhisNo int
as begin
delete from Teþhisler where TeþhisNo=@TeþhisNo
end


create proc TG2
@TeþhisNo int,
@HastaNo int,
@HastaAdýveSoyadý nvarchar(50),
@TeþhisiKoyanDoktorAdý varchar(50),
@TeþhisiKoyanDoktorNo int,
@TeþhisinKonduðuBölümAdý nvarchar(50),
@TeþhisinKonduðuBölümNo int,
@TeþhisTarihi nvarchar(50)
as begin
update Teþhisler set HastaNo=@HastaNo,HastaAdýveSoyadý=@HastaAdýveSoyadý,TeþhisiKoyanDoktorAdý=@TeþhisiKoyanDoktorAdý,TeþhisKoyanDoktorNo=@TeþhisiKoyanDoktorNo,
TeþhisinKonduðuBölümAdý=@TeþhisinKonduðuBölümAdý,TeþhisinKonduðuBölümNo=@TeþhisinKonduðuBölümNo,TeþhisTarihi=@TeþhisTarihi
where TeþhisNo=@TeþhisNo
end

create proc TGor
@TeþhisNo int,
@HastaNo int,
@TeþhisinKonduðuBölümNo int
as begin
select*from Teþhisler where TeþhisNo=@TeþhisNo and HastaNo=@HastaNo and TeþhisinKonduðuBölümNo=@TeþhisinKonduðuBölümNo
end

create proc TGorTNo
@TeþhisNo int
as begin
select*from Teþhisler where TeþhisNo=@TeþhisNo
end


create proc TGorTHNo
@HastaNo int
as begin
select*from Teþhisler where HastaNo=@HastaNo
end

create proc TGorTKBNo
@TeþhisinKonduðuBölümNo int
as begin
select*from Teþhisler where TeþhisinKonduðuBölümNo=@TeþhisinKonduðuBölümNo
end

create proc TGOSTER
as begin
select*from Teþhisler
end

create proc TListeleAZ
as begin
select*from Teþhisler order by HastaNo asc
end

create proc TListeleZA
as begin
select*from Teþhisler order by HastaNo desc
end



--Kullanýcý

create proc KEkle
@KullanýcýAdý nvarchar(50),
@Sifre nvarchar(50),
@Email nvarchar(50),
@Telefon nchar(10)
as begin
insert into Kullanýcý (KullanýcýAdý,Sifre,EMail,Telefon)
values (@KullanýcýAdý,@Sifre,@EMail,@Telefon)
end


