insert into Bilgisayarlar(Marka,Adet,Fiyat,Ozellikleri,UretimTarihi,KategoriAdi,Model,UretimYeri)
values('Toshiba',250,15000,'i7','2020-12-27','Gaming','TG1','Japan')



insert into Bilgisayarlar(Marka,Adet,Fiyat,Ozellikleri,UretimTarihi,KategoriAdi,Model,UretimYeri)
values('Toshiba',500,25000,'i9','2020-12-27','WorkStation','TG1','Japan')


insert into Bilgisayarlar(Marka,Adet,Fiyat,Ozellikleri,UretimTarihi,KategoriAdi,Model,UretimYeri)
values('Toshiba',500,12000,'i5','2020-12-27','WorkStation','TG2','Japan')

insert into Bilgisayarlar(Marka,Adet,Fiyat,Ozellikleri,UretimTarihi,KategoriAdi,Model,UretimYeri)
values('Asus',750,11000,'i5','2021-12-27','Gaming','AG1','Korea')


insert into Bilgisayarlar(Marka,Adet,Fiyat,Ozellikleri,UretimTarihi,KategoriAdi,Model,UretimYeri)
values('Asus',750,16000,'i7','2019-12-27','Gaming','AG2','Korea')

insert into Bilgisayarlar(Marka,Adet,Fiyat,Ozellikleri,UretimTarihi,KategoriAdi,Model,UretimYeri)
values('Asus',750,25000,'i9','2022-03-27','Gaming','AWS1','Korea')




insert into Bilgisayarlar(Marka,Adet,Fiyat,Ozellikleri,UretimTarihi,KategoriAdi,Model,UretimYeri)
values('MSI',250,11000,'i5','2021-12-27','Gaming','MSIG1','China')


insert into Bilgisayarlar(Marka,Adet,Fiyat,Ozellikleri,UretimTarihi,KategoriAdi,Model,UretimYeri)
values('MSI',550,16000,'i7','2019-12-27','Gaming','MSIG2','China')

insert into Bilgisayarlar(Marka,Adet,Fiyat,Ozellikleri,UretimTarihi,KategoriAdi,Model,UretimYeri)
values('MSI',750,25000,'i9','2022-03-27','WorkStation','MSIWS1','China')



select top 20 percent*from Bilgisayarlar order by Fiyat desc

select Marka,min(Fiyat) as 'En Ucuz' from Bilgisayarlar group By Marka 

select top 5*from Bilgisayarlar where Marka <> 'MSI' order by Marka desc

select Marka,Fiyat+1500 as 'Zamlý Fiyat' from Bilgisayarlar

select Marka,Fiyat+1500 as 'Zamlý Fiyat' from Bilgisayarlar where  Marka='Asus' order by Fiyat 



create proc Bekle
@Marka varchar(50),
@Adet int,
@Fiyat money,
@Ozellikleri varchar(50),
@UretimTarihi