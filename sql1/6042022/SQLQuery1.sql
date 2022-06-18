--ORDER BY
--DESC-ASC  (descending-ascending)
--order by ile sýralama yapýyoruz
--Müþteriler tablosunda adýný desc sayesinde z'den a'ya sýralýyoruz


select*from Musteriler order by MusteriAdi Desc --z den a ya


select*from Musteriler order by MusteriAdi ASC --a dan z ye


select MusteriAdi,MusteriUnvani from Musteriler order by MusteriUnvani desc


--satýslar tablosudan  nakliye ucretý 100 un altýnda olanlarýn satýs tarihlerini desc olarak sýrala

select*from Satislar where NakliyeUcreti<100 order by  SatisTarihi desc

--Urunler tablosundan hedefstokduzeyý 50 nýn altýnda ve birim fiyatý 20 nýn ustýnde olanlarýn býrým fýrým fýyatlarýný asc sýrala

select*from Urunler  where HedefStokDuzeyi<50 and BirimFiyati>20 order by BirimFiyati asc


--LIKE--->arama yapma iþlemlerinde kullanýlýr

select*from Urunler where UrunAdi like '%C%'
--Urunadýnda ýcýnde C harfi olanlarý göster

select*from Urunler where UrunAdi like 'A%'    --Urun adýndan bas harfi A olanlarý goster

--Urunadýnda s ýle bitenleri getiren sorgu

select*from Urunler where UrunAdi like '%S'

select*from Urunler where UrunAdi like '_h_e'
-- Adýnýn ikinci harfi h. 4 harfi e olanlarý göster

select*from Urunler where UrunAdi like '_o__u'
--Adýnýn 2. harfi o 5. harfi u olaný göster.

select*from Urunler where  UrunAdi like '[a-t]%' and UrunAdi like '%a'
--Urun adý a ile t harfleri arasýndaki harfleri sec ve son harfi a olaný göster.


--satýslar tablosunda  satýsado a ile k arasýnda baþlayan ve sevk sehri ise e ile s arasýnda biten sorgu

select*from Satislar where SevkAdi like '[a-k]%' and SevkSehri like  '%[e-s]'


select KategoriAdi as Katalog,Tanimi as 'Katalog Açýklamasý' from Kategoriler

--Kategorilerden kategori adini katalog yap tanýný'mý katalog açýklamasý yap

--tek kelime oldugunda direk yazabiliyoruz birden çok kelime týrnak içine alýyoruz.
--Burda yaptýðýmýz geçici bir isim verir sadece görüntü deðiþir


select NakliyeUcreti as  'Asýl Fiyat',NakliyeUcreti+1000 as 'Zamlý Fiyat' from Satislar

--Nakliye Ucretini ilk baþta Asýl Fiyat olarak deðiþtirdi
--daha sonra nakliye ücretine 1000 ekleyerek nakliye ücretini zamlý fiyat olarak gösteriyor.



--BETWEEN(genelde sayýsal ifadelerde kullanýlýr.)

select*from Urunler where UrunAdi between 'a' and 'f' --Baþ harfi a ve f arasýnda olanlarý göster.


select*from [Satis Detaylari] where Miktar between 10 and 100

--Satýþ Detaylarýndan Miktari 10 ile 100 arasýnda olanlarý göster
--Köþeli parantezi satýs detaylarý arasýnda boþluk oldugu için kullanýyoruz.



--TOP


select top 20* from Musteriler order by MusteriID asc
--ilk 20 müþteri ýd yi küçükten büyüðe doðru sýrala ve göster

select top 50 percent*from Musteriler where MusteriUnvani <> 'Owner' order by PostaKodu asc
--Posta koduna göre sýrala Müþteri ünvaný owner olanlarý tespit  et bulduklarýný çýkar bulduklarýnýn da yüzde 50 sini göster
--<> bu iþaret olmayanlarý al demek

select top 20 percent*from Personeller where SoyAdi <> 'Fuller' order by PostaKodu
--Posta kodunu büyüktek küçüðe sýrala Soyadi Füller  olmayanlarý bul ve bunlarýn yüzde 20 sini göster

select top 20 percent*from Urunler where UrunAdi <> 'Chai' order by BirimFiyati asc
--Urunadi chai olmayanlarý bul ve bunlarýn yüzde 20 sini rastgele göster.



--LEN(LENGTH)
select PersonelID,adi,len(adi) as 'Ýsim uzunluðu',SoyAdi,LEN(soyadi) as 'Soyisim uzunluðu' from Personeller

--Personellerden adi2ni 'isim uzunluðu' olarak soyadýný 'Soyisim Uzunluðu' olarak deðiþtir ve karakter sayýný bana göster.



--Kümeleme Fonskiyonlarý(aggrreate)
--1)max():Seçilen kolonun en büyüðü getirir.
--2)min():Seçilen kolonun en küçüðünü getiren sorgu
--3)sum():Seçilen kolonun toplamýný getiren sorgu
--4)avg():Seçilen kolonun ortalamasýný getiren sorgu
--5)count():seçilen kolonun adetini getiren sorgu
--6)count(*):tum kolonun adedýný getiren sorgu

select sum(BirimFiyati) as 'Fiyat Bedeli' from Urunler
select avg(HedefStokDuzeyi) from Urunler

select count(YeniSatis) from Urunler

select min(BirimFiyati) as 'Min FÝyat' from Urunler
select max(BirimFiyati) as 'Max FÝyat' from Urunler



--Group by: gruplandýrma yapmak için kullanýlýr






