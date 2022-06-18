--Constraints(K�s�ltlamalar)

--Veri �zerindeki mant�ksa s�n�rlamara k�s�tlama ad� verilir
--K�s�tlar�n genel olmas� tercih edilen bir durumdur
--K�s�tlar,veri modellerinde b�t�nl�k sa�lamak i�in kullan�l�r
--K�s�tlamalar ;tablolar�n tan�mlanmas�yla beraber olu�an ��elerdir
--K�s�tlamalar ile Rule(kural) ve default lar�n (varsay�lan) yapabilece�i i�ler yapalabilir.
--Constraintler tablo olu�turulurken yani create table komutuyla tan�mlanabilir.Tablo olu�turulmu�sa
--alter tablo komutuyla  kullan�ld���nda s�t�nara girilen bilgilerin dikkate al�nmas� gerekir.





--K�s�tlamaalar 5 e ayr�l�r
--1)pk
--2)fl
--3)default constraint(varsay�lan de�er atamas�)
--4)check constraint (k�s�tlama ve ko�ul y)
--5)unique key : kolonun benzersiz olmas�n� sa�lar. (kolonda bir defaya mahsus bos b�rak�lmaya izin verir)

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

alter table OgretimBilgileri	add constraint df_Okul_OgretimOdeme    --(df yerine ck gelmeliydi yaz�m hatas�)
check (OgretimOdeme>122 and OgretimOdeme<16000)    --123 un alt�nda odeme bilgisi girilmesine izin verilmez.

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


