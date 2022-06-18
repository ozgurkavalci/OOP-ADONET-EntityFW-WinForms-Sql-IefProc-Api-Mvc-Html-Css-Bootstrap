--sirket database kod ile
---personel   tabosu alter dogumtarýgý ,tcno ekle 
---           drop (3 veri at )
--personelno
--adsoyad
--yas
--mass
--adres
--il


--Fabrikalar
--fabrika no
--fabrikaadi
--fabrikayil
--fabrikail
--fabrikailce

create database Sirket
create table Personel
(
personelNo int,
adsoyad varchar(50),
yas int,
maas money,
adres varchar(100),
il varchar(20),


)

alter table Personel add dogumtarigi date
alter table Personel add tcNo char

alter table Personel drop column personelNo
alter table Personel drop column il
alter table Personel drop column adres