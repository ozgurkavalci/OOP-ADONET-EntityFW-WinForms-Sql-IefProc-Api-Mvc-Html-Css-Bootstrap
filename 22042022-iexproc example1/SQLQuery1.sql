--Constraints(Kýsýltlamalar)

--Veri Üzerindeki mantýksa sýnýrlamara kýsýtlama adý verilir
--Kýsýtlarýn genel olmasý tercih edilen bir durumdur
--Kýsýtlar,veri modellerinde bütünlük saðlamak için kullanýlýr
--Kýsýtlamalar ;tablolarýn tanýmlanmasýyla beraber oluþan öðelerdir
--Kýsýtlamalar ile Rule(kural) ve default larýn (varsayýlan) yapabileceði iþler yapalabilir.
--Constraintler tablo oluþturulurken yani create table komutuyla tanýmlanabilir.Tablo oluþturulmuþsa
--alter tablo komutuyla  kullanýldýðýnda sütünara girilen bilgilerin dikkate alýnmasý gerekir.





--Kýsýtlamaalar 5 e ayrýlýr
--1)pk
--2)fl
--3)default constraint(varsayýlan deðer atamasý)
--4)check constraint (kýsýtlama ve koþul y)
--5)unique key : kolonun benzersiz olmasýný saðlar. (kolonda bir defaya mahsus bos býrakýlmaya izin verir)

alter table OgretimBilgileri	add constraint df_Okul_OgretimSehir default 'ankara' for OgretimSehir

select*from OgretimBilgileri

insert into OgretimBilgileri(OgretimAdSoyad,OgretimTel,OgretimMail,OgretimTcNo,OgretimPuan,OgretimYas,OgretimOdeme,OgretimBolum)
values ('abuzer','5669878','sadasd@gmail.com','1588648997',45,21,5000,'hemsire')

alter table OgretimBilgileri	add constraint df_Okul_OgretimPuan default 75 for OgretimPuan


insert into OgretimBilgileri(OgretimAdSoyad,OgretimTel,OgretimMail,OgretimTcNo,OgretimYas,OgretimOdeme,OgretimBolum)
values ('hasan','5669878','sadasd@gmail.com','1588648997',21,5000,'sofor')

insert into OgretimBilgileri(OgretimAdSoyad,OgretimTel,OgretimMail,OgretimTcNo,OgretimYas,OgretimOdeme)
values ('asude','5669878','sadasd@gmail.com','1588648997',21,5000)



--check constraint

alter table OgretimBilgileri	add constraint df_Okul_OgretimOdeme    --(df yerine ck gelmeliydi yazým hatasý)
check (OgretimOdeme>122 and OgretimOdeme<16000)    --123 un altýnda odeme bilgisi girilmesine izin verilmez.

select*from OgretimBilgileri 


--insert into OgretimBilgileri(OgretimAdSoyad,OgretimTel,OgretimMail,OgretimTcNo,OgretimYas,OgretimOdeme)


alter table OgretimBilgileri add constraint UQ_Okul_OgretimTcNo
unique(OgretimTcNO)




--Kitaplar tablosu

alter table Kitaplar add constraint df_Kitaplar_KitapAdi default 'Vadideki Zambak' for KitapAdi


alter table Kitaplar add constraint df_Kitaplar_KitapYazarAdi default 'Balzac' for KitapYazarAdi

alter table Kitaplar add constraint UQ_Kitaplar_KitapBarkodNo 
unique(KitapBarkodNo)


alter table Kitaplar add constraint CK_Kitaplar_KitapPuan 
check(KitapPuan>3 and KitapPuan<11)


insert into Kitaplar(KitapYayinEvi,KitapBarkodNo,KitapYayinEviNo,KitapPuan,KitapFiyat)
values ('galaksi',1945,3923,9,150)

select*from Kitaplar


