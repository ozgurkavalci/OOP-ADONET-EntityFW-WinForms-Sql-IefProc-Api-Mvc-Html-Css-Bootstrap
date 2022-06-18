--Stored Procedure

--1.H�z
--Stored Procedure olu�turdu�umuzda bu sorguyu bir kere �al��t�rd���m�zda sistem bunu derler ve sonrakilerde tekrar tekrar �al��t�rmaz.
--Daha �nce �al��t�r�ld���nda  haf�zaya al�r ve oradan tekrar �al��t�r�r.
--Normal sorgu �al��t�rmak istedi�imizde ise bunu her seferinde ilk kez kar��la�m�� gibi yeniden �al��t�r�r.
--Bu da h�z a��s�ndan pek avantajl� de�ildir.



--2.Parametre Kullan�m�


--3.Esneklik

create proc Pekle     
@Adsoyad varchar(50),
@meslek varchar(50),
@yas int,
@maas money,
@prim money,
@memleket varchar(50)
as begin
insert into Personeller(Adsoyad,meslek,yas,maas,prim,memleket) 
values(@Adsoyad,@meslek,@yas,@maas,@prim,@memleket)
end

exec Pekle 'nihal �z','muhendis',32,50000,20000,'sivas'
select*from Personeller 



--Listeleme Sorgusu                    --Prosed�rler parametreli veya paremetresiz �ekilde yap�land�r�labilir.
create procedure VerileriCek
as begin
select*from Personeller
end
exec Verilericek


create proc AramaYap
@adsoyad varchar(50)
as begin
select*from Personeller where Adsoyad=@adsoyad
end

exec AramaYap 'nihal �z'



--yas� 25 den buyuk ve 30 dan kucuk olanlar� s�ralayan prosed�r

create proc YasSorgu2

as begin
select*from Personeller where yas>25 and yas<30  
end

exec YasSorgu2





--Yenileme proc

create proc Pyenile2
@PersonelNo int,
@Adsoyad varchar(50),
@meslek varchar(50),
@yas int,
@maas money,
@prim money,
@memleket varchar(50)
as begin 
update Personeller set Adsoyad=@Adsoyad,meslek=@meslek,yas=@yas,maas=@maas,prim=prim,memleket=@memleket where PersonelNo=@PersonelNo
end

exec Pyenile2 5,'babos �z','duz isci',36,5000,1000,'sivas'

select*from Personeller


create proc Psil 
@PersonelNo int
as begin
delete from Personeller where PersonelNo=@PersonelNo
end


exec Psil 5
select*from Personeller


