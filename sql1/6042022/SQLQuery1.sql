--ORDER BY
--DESC-ASC  (descending-ascending)
--order by ile s�ralama yap�yoruz
--M��teriler tablosunda ad�n� desc sayesinde z'den a'ya s�ral�yoruz


select*from Musteriler order by MusteriAdi Desc --z den a ya


select*from Musteriler order by MusteriAdi ASC --a dan z ye


select MusteriAdi,MusteriUnvani from Musteriler order by MusteriUnvani desc


--sat�slar tablosudan  nakliye ucret� 100 un alt�nda olanlar�n sat�s tarihlerini desc olarak s�rala

select*from Satislar where NakliyeUcreti<100 order by  SatisTarihi desc

--Urunler tablosundan hedefstokduzey� 50 n�n alt�nda ve birim fiyat� 20 n�n ust�nde olanlar�n b�r�m f�r�m f�yatlar�n� asc s�rala

select*from Urunler  where HedefStokDuzeyi<50 and BirimFiyati>20 order by BirimFiyati asc


--LIKE--->arama yapma i�lemlerinde kullan�l�r

select*from Urunler where UrunAdi like '%C%'
--Urunad�nda �c�nde C harfi olanlar� g�ster

select*from Urunler where UrunAdi like 'A%'    --Urun ad�ndan bas harfi A olanlar� goster

--Urunad�nda s �le bitenleri getiren sorgu

select*from Urunler where UrunAdi like '%S'

select*from Urunler where UrunAdi like '_h_e'
-- Ad�n�n ikinci harfi h. 4 harfi e olanlar� g�ster

select*from Urunler where UrunAdi like '_o__u'
--Ad�n�n 2. harfi o 5. harfi u olan� g�ster.

select*from Urunler where  UrunAdi like '[a-t]%' and UrunAdi like '%a'
--Urun ad� a ile t harfleri aras�ndaki harfleri sec ve son harfi a olan� g�ster.


--sat�slar tablosunda  sat�sado a ile k aras�nda ba�layan ve sevk sehri ise e ile s aras�nda biten sorgu

select*from Satislar where SevkAdi like '[a-k]%' and SevkSehri like  '%[e-s]'


select KategoriAdi as Katalog,Tanimi as 'Katalog A��klamas�' from Kategoriler

--Kategorilerden kategori adini katalog yap tan�n�'m� katalog a��klamas� yap

--tek kelime oldugunda direk yazabiliyoruz birden �ok kelime t�rnak i�ine al�yoruz.
--Burda yapt���m�z ge�ici bir isim verir sadece g�r�nt� de�i�ir


select NakliyeUcreti as  'As�l Fiyat',NakliyeUcreti+1000 as 'Zaml� Fiyat' from Satislar

--Nakliye Ucretini ilk ba�ta As�l Fiyat olarak de�i�tirdi
--daha sonra nakliye �cretine 1000 ekleyerek nakliye �cretini zaml� fiyat olarak g�steriyor.



--BETWEEN(genelde say�sal ifadelerde kullan�l�r.)

select*from Urunler where UrunAdi between 'a' and 'f' --Ba� harfi a ve f aras�nda olanlar� g�ster.


select*from [Satis Detaylari] where Miktar between 10 and 100

--Sat�� Detaylar�ndan Miktari 10 ile 100 aras�nda olanlar� g�ster
--K��eli parantezi sat�s detaylar� aras�nda bo�luk oldugu i�in kullan�yoruz.



--TOP


select top 20* from Musteriler order by MusteriID asc
--ilk 20 m��teri �d yi k���kten b�y��e do�ru s�rala ve g�ster

select top 50 percent*from Musteriler where MusteriUnvani <> 'Owner' order by PostaKodu asc
--Posta koduna g�re s�rala M��teri �nvan� owner olanlar� tespit  et bulduklar�n� ��kar bulduklar�n�n da y�zde 50 sini g�ster
--<> bu i�aret olmayanlar� al demek

select top 20 percent*from Personeller where SoyAdi <> 'Fuller' order by PostaKodu
--Posta kodunu b�y�ktek k����e s�rala Soyadi F�ller  olmayanlar� bul ve bunlar�n y�zde 20 sini g�ster

select top 20 percent*from Urunler where UrunAdi <> 'Chai' order by BirimFiyati asc
--Urunadi chai olmayanlar� bul ve bunlar�n y�zde 20 sini rastgele g�ster.



--LEN(LENGTH)
select PersonelID,adi,len(adi) as '�sim uzunlu�u',SoyAdi,LEN(soyadi) as 'Soyisim uzunlu�u' from Personeller

--Personellerden adi2ni 'isim uzunlu�u' olarak soyad�n� 'Soyisim Uzunlu�u' olarak de�i�tir ve karakter say�n� bana g�ster.



--K�meleme Fonskiyonlar�(aggrreate)
--1)max():Se�ilen kolonun en b�y��� getirir.
--2)min():Se�ilen kolonun en k�����n� getiren sorgu
--3)sum():Se�ilen kolonun toplam�n� getiren sorgu
--4)avg():Se�ilen kolonun ortalamas�n� getiren sorgu
--5)count():se�ilen kolonun adetini getiren sorgu
--6)count(*):tum kolonun aded�n� getiren sorgu

select sum(BirimFiyati) as 'Fiyat Bedeli' from Urunler
select avg(HedefStokDuzeyi) from Urunler

select count(YeniSatis) from Urunler

select min(BirimFiyati) as 'Min F�yat' from Urunler
select max(BirimFiyati) as 'Max F�yat' from Urunler



--Group by: grupland�rma yapmak i�in kullan�l�r






