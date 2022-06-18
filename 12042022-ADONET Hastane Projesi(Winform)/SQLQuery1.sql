
create proc DEkle
@DoktorAd�veSoyad� varchar(50),
@DoktoTcNo nvarchar(11),
@Uzmanl�kAlan� nvarchar(50),
@Unvan� nvarchar(50),
@TelefonNumaras� nvarchar(11),
@Adres varchar(50),
@Do�umTarihi nvarchar(50),
@PoliklinikNo int
as begin
insert into Doktorlar (DoktorAd�veSoyad�,DoktorTcNo,Uzmanl�kAlan�,Unvan�,TelefonNumaras�,Adres,Do�umTarihi,PoliklinikNo)
values (@DoktorAd�veSoyad�,@DoktoTcNo,@Uzmanl�kAlan�,@Unvan�,@TelefonNumaras�,@Adres,@Do�umTarihi,@PoliklinikNo)
end

create proc DSil
@DoktorNo int
as begin
delete from Doktorlar where DoktorNo=@DoktorNo
end


create proc DG
@DoktorNo int,
@DoktorAd�veSoyad� varchar(50),
@DoktoTcNo nvarchar(11),
@Uzmanl�kAlan� nvarchar(50),
@Unvan� nvarchar(50),
@TelefonNumaras� nvarchar(11),
@Adres varchar(50),
@Do�umTarihi nvarchar(50),
@PoliklinikNo int
as begin
update Doktorlar set DoktorAd�veSoyad�=@DoktorAd�veSoyad�,DoktorTcNo=@DoktoTcNo,Uzmanl�kAlan�=@Uzmanl�kAlan�,Unvan�=@Unvan�,
TelefonNumaras�=@TelefonNumaras�,Adres=@Adres,Do�umTarihi=@Do�umTarihi,PoliklinikNo=@PoliklinikNo where DoktorNo=@DoktorNo
end

create proc DGor
@DoktorNo int,
@DoktorAd�veSoyad� varchar(50),
@DoktorTcNo nvarchar(11)
as begin
select*from Doktorlar where DoktorNo=@DoktorNo and DoktorAd�veSoyad�=@DoktorAd�veSoyad� and DoktorTcNo=@DoktorTcNo
end


create proc DGorDNo
@DoktorNo int
as begin
select*from Doktorlar where DoktorNo=@DoktorNo
end

create proc DGorDADS
@DoktorAd�veSoyad� varchar(50)
as begin
select*from Doktorlar where DoktorAd�veSoyad�=@DoktorAd�veSoyad�
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
select*from Doktorlar order by DoktorAd�veSoyad� asc
end

create proc DListeleZA
as begin
select*from Doktorlar order by DoktorAd�veSoyad� desc
end



--Hastalar

create proc HEkle
@HastaAd�veSoyad� varchar(50),
@HastaTcNo char(11),
@HastaDo�umTarihi nvarchar(50),
@HastaBoy varchar(50),
@HastaYa� int,
@HastaRe�ete nvarchar(50),
@HastaRaporDurumu nvarchar(50),
@HastaRandevuTarihi nvarchar(50),
@HastaTelefon nchar(10),
@HastaAdres varchar(50),
@HastaMail varchar(50),
@HizmetAld���B�l�m varchar(50),
@DoktorNo int
as begin
insert into Hastalar (HastaAd�veSoyad�,HastaTcNo,HastaDo�umTarihi,HastaBoy,HastaYa�,HastaRe�ete,HastaRaporDurumu,HastaRandevuTarihi,
HastaTelefon,HastaAdres,HastaMail,HizmetAld���B�l�m,DoktorNo)
values (@HastaAd�veSoyad�,@HastaTcNo,@HastaDo�umTarihi,@HastaBoy,@HastaYa�,@HastaRe�ete,@HastaRaporDurumu,@HastaRandevuTarihi,@HastaTelefon,
@HastaAdres,@HastaMail,@HizmetAld���B�l�m,@DoktorNo)
end


create proc HSil
@HastaNo int
as begin
delete from Hastalar where HastaNo=@HastaNo
end


create proc HG
@HastaNo int,
@HastaAd�veSoyad� varchar(50),
@HastaTcNo char(11),
@HastaDo�umTarihi nvarchar(50),
@HastaBoy varchar(50),
@HastaYa� int,
@HastaRe�ete nvarchar(50),
@HastaRaporDurumu nvarchar(50),
@HastaRandevuTarihi nvarchar(50),
@HastaTelefon nchar(10),
@HastaAdres varchar(50),
@HastaMail varchar(50),
@HizmetAld���B�l�m varchar(50),
@DoktorNo int
as begin
update Hastalar set HastaAd�veSoyad�=@HastaAd�veSoyad�,HastaTcNo=@HastaTcNo,HastaDo�umTarihi=@HastaDo�umTarihi,HastaBoy=@HastaBoy,
HastaYa�=@HastaYa�,HastaRe�ete=@HastaRe�ete,HastaRaporDurumu=@HastaRaporDurumu,HastaRandevuTarihi=@HastaRandevuTarihi,
HastaTelefon=@HastaTelefon,HastaMail=@HastaMail,HizmetAld���B�l�m=@HizmetAld���B�l�m,DoktorNo=@DoktorNo where HastaNo=@HastaNo
end


create proc HGor
@HastaNo int,
@HastaAd�veSoyad� varchar(50),
@HastaTcNo int
as begin
select*from Hastalar where HastaNo=@HastaNo and HastaAd�veSoyad�=@HastaAd�veSoyad� and HastaTcNo=@HastaTcNo
end

create proc HGorHNo
@HastaNo int
as begin
select*from Hastalar where HastaNo=@HastaNo
end

create proc HGorHADS
@HastaAd�veSoyad� varchar(50)
as begin
select*from Hastalar where HastaAd�veSoyad�=@HastaAd�veSoyad�
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
select*from Hastalar order by HastaAd�veSoyad� asc
end

create proc HListeleZA
as begin
select*from Hastalar order by HastaAd�veSoyad� desc
end



--Poliklinik

create proc PEkle
@PoliklinikAd� varchar(50),
@PoliklinikUzmanSay�s� int,
@PoliklinikBa�kan� varchar(50),
@PoliklinikBa�Hem�ire varchar(50),
@YatakSay�s� int
as begin 
insert into Poliklinikler (PoliklinikAd�,PoliklinikUzmanSay�s�,PoliklinikBa�kan�,PoliklinikBa�Hem�ire,YatakSay�s�)
values (@PoliklinikAd�,@PoliklinikUzmanSay�s�,@PoliklinikBa�kan�,@PoliklinikBa�Hem�ire,@YatakSay�s�)
end

create proc PSil
@PoliklinikNo int
as begin
delete from Poliklinikler where PoliklinikNo=@PoliklinikNo
end


create proc PG
@PoliklinikNo int,
@PoliklinikAd� varchar(50),
@PoliklinikUzmanSay�s� int,
@PoliklinikBa�kan� varchar(50),
@PoliklinikBa�Hem�ire varchar(50),
@YatakSay�s� int
as begin
update Poliklinikler set PoliklinikAd�=@PoliklinikAd�,PoliklinikUzmanSay�s�=@PoliklinikUzmanSay�s�,PoliklinikBa�kan�=@PoliklinikBa�kan�,
PoliklinikBa�Hem�ire=@PoliklinikBa�Hem�ire,YatakSay�s�=@YatakSay�s� where PoliklinikNo=@PoliklinikNo
end

create proc PGor
@PoliklinikNo int,
@PoliklinikAd� varchar(50)
as begin
select*from Poliklinikler where PoliklinikNo=@PoliklinikNo and PoliklinikAd�=@PoliklinikAd�
end

create proc PGorPNo
@PoliklinikNo int
as begin
select*from Poliklinikler where PoliklinikNo=@PoliklinikNo
end

create proc PGorPAd�
@PoliklinikAd� varchar(50)
as begin
select*from Poliklinikler where PoliklinikAd�=@PoliklinikAd�
end


create proc PGOSTER
as begin
select*from Poliklinikler
end

create proc PListeleAZ
as begin
select*from Poliklinikler order by PoliklinikAd� asc
end

create proc PListeleZA
as begin
select*from Poliklinikler order by PoliklinikAd� desc
end


--Te�hisler


create proc TEkle2
@HastaNo int,
@HastaAd�veSoyad� nvarchar(50),
@Te�hisiKoyanDoktorAd� varchar(50),
@Te�hisiKoyanDoktorNo int,
@Te�hisinKondu�uB�l�mAd� nvarchar(50),
@Te�hisinKondu�uB�l�mNo int,
@Te�hisTarihi nvarchar(50)
as begin
insert into Te�hisler (HastaNo,HastaAd�veSoyad�,Te�hisiKoyanDoktorAd�,Te�hisKoyanDoktorNo,Te�hisinKondu�uB�l�mAd�,Te�hisinKondu�uB�l�mNo,Te�hisTarihi)
values (@HastaNo,@HastaAd�veSoyad�,@Te�hisiKoyanDoktorAd�,@Te�hisiKoyanDoktorNo,@Te�hisinKondu�uB�l�mAd�,@Te�hisinKondu�uB�l�mNo,@Te�hisTarihi)
end

create proc TSil
@Te�hisNo int
as begin
delete from Te�hisler where Te�hisNo=@Te�hisNo
end


create proc TG2
@Te�hisNo int,
@HastaNo int,
@HastaAd�veSoyad� nvarchar(50),
@Te�hisiKoyanDoktorAd� varchar(50),
@Te�hisiKoyanDoktorNo int,
@Te�hisinKondu�uB�l�mAd� nvarchar(50),
@Te�hisinKondu�uB�l�mNo int,
@Te�hisTarihi nvarchar(50)
as begin
update Te�hisler set HastaNo=@HastaNo,HastaAd�veSoyad�=@HastaAd�veSoyad�,Te�hisiKoyanDoktorAd�=@Te�hisiKoyanDoktorAd�,Te�hisKoyanDoktorNo=@Te�hisiKoyanDoktorNo,
Te�hisinKondu�uB�l�mAd�=@Te�hisinKondu�uB�l�mAd�,Te�hisinKondu�uB�l�mNo=@Te�hisinKondu�uB�l�mNo,Te�hisTarihi=@Te�hisTarihi
where Te�hisNo=@Te�hisNo
end

create proc TGor
@Te�hisNo int,
@HastaNo int,
@Te�hisinKondu�uB�l�mNo int
as begin
select*from Te�hisler where Te�hisNo=@Te�hisNo and HastaNo=@HastaNo and Te�hisinKondu�uB�l�mNo=@Te�hisinKondu�uB�l�mNo
end

create proc TGorTNo
@Te�hisNo int
as begin
select*from Te�hisler where Te�hisNo=@Te�hisNo
end


create proc TGorTHNo
@HastaNo int
as begin
select*from Te�hisler where HastaNo=@HastaNo
end

create proc TGorTKBNo
@Te�hisinKondu�uB�l�mNo int
as begin
select*from Te�hisler where Te�hisinKondu�uB�l�mNo=@Te�hisinKondu�uB�l�mNo
end

create proc TGOSTER
as begin
select*from Te�hisler
end

create proc TListeleAZ
as begin
select*from Te�hisler order by HastaNo asc
end

create proc TListeleZA
as begin
select*from Te�hisler order by HastaNo desc
end



--Kullan�c�

create proc KEkle
@Kullan�c�Ad� nvarchar(50),
@Sifre nvarchar(50),
@Email nvarchar(50),
@Telefon nchar(10)
as begin
insert into Kullan�c� (Kullan�c�Ad�,Sifre,EMail,Telefon)
values (@Kullan�c�Ad�,@Sifre,@EMail,@Telefon)
end


