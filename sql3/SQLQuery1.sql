--Stored Procedure

--1.Hız
--Stored Procedure oluşturduğumuzda bu sorguyu bir kere çalıştırdığımızda sistem bunu derler ve sonrakilerde tekrar tekrar çalıştırmaz.
--Daha önce çalıştırıldığında  hafızaya alır ve oradan tekrar çalıştırır.
--Normal sorgu çalıştırmak istediğimizde ise bunu her seferinde ilk kez karşılaşmış gibi yeniden çalıştırır.
--Bu da hız açısından pek avantajlı değildir.



--2.Parametre Kullanımı


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

exec Pekle 'nihal öz','muhendis',32,50000,20000,'sivas'
select*from Personeller 



--Listeleme Sorgusu                    --Prosedürler parametreli veya paremetresiz şekilde yapılandırılabilir.
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

exec AramaYap 'nihal öz'



--yası 25 den buyuk ve 30 dan kucuk olanları sıralayan prosedür

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

exec Pyenile2 5,'babos öz','duz isci',36,5000,1000,'sivas'

select*from Personeller


create proc Psil 
@PersonelNo int
as begin
delete from Personeller where PersonelNo=@PersonelNo
end


exec Psil 5
select*from Personeller


