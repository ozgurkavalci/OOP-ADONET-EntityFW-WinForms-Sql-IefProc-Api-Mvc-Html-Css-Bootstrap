--K�meleme Fonskiyonlar�(aggrreate)
--1)max():Se�ilen kolonun en b�y��� getirir.
--2)min():Se�ilen kolonun en k�����n� getiren sorgu
--3)sum():Se�ilen kolonun toplam�n� getiren sorgu
--4)avg():Se�ilen kolonun ortalamas�n� getiren sorgu
--5)count():se�ilen kolonun adetini getiren sorgu
--6)count(*):tum kolonun aded�n� getiren sorgu

--Group by: grupland�rma yapmak i�in kullan�l�r


select meslek,avg(maas) as 'Maas Ortalamas�' from Personeller group by meslek
select*from Personeller
--Mesleklere gore grupland�rma yapan sorgu

select sigortadurumu,min(yas) as 'en kucuk ya�' from Personeller group by sigortadurumu
select*from Personeller


--Memlekete gore gurupland�rma yap�p maaslar�n toplam�n� veren sorgu
select memleket, sum(maas) as 'Maas Toplam�' from Personeller group by memleket