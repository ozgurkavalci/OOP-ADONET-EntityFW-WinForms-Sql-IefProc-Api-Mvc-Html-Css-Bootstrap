create proc OAdd
@Adsoyad varchar(50),
@TcNo char(11),
@Telefon nchar(11),
@Mail varchar(50),
@Adres varchar(50),
@DersNo int
as begin
insert into Ogrenciler (Adsoyad,TcNo,Telefon,Mail,Adres,DersNo)
values(@Adsoyad,@TcNo,@Telefon,@Mail,@Adres,@DersNo)
end


exec OAdd 'behinur','1454545','54545','nurlugir@hotmail.com','þiþli',1


create proc OY
@OgrenciNo int,
@Adsoyad varchar(50),
@TcNo char(11),
@Telefon nchar(11),
@Mail varchar(50),
@Adres varchar(50),
@DersNo int
as begin
update Ogrenciler set Adsoyad=@Adsoyad,TcNo=@TcNo,Telefon=@Telefon,Mail=@Mail,Adres=@Adres,DersNo=@DersNo where 
OgrenciNo=@OgrenciNo
end

create proc OSL
@OgrenciNo int
as begin 
delete from Ogrenciler where OgrenciNo=@OgrenciNo
end


create proc OG
as begin
select*from Ogrenciler
end
