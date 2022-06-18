--Kümeleme Fonskiyonlarý(aggrreate)
--1)max():Seçilen kolonun en büyüðü getirir.
--2)min():Seçilen kolonun en küçüðünü getiren sorgu
--3)sum():Seçilen kolonun toplamýný getiren sorgu
--4)avg():Seçilen kolonun ortalamasýný getiren sorgu
--5)count():seçilen kolonun adetini getiren sorgu
--6)count(*):tum kolonun adedýný getiren sorgu

--Group by: gruplandýrma yapmak için kullanýlýr


select meslek,avg(maas) as 'Maas Ortalamasý' from Personeller group by meslek
select*from Personeller
--Mesleklere gore gruplandýrma yapan sorgu

select sigortadurumu,min(yas) as 'en kucuk yaþ' from Personeller group by sigortadurumu
select*from Personeller


--Memlekete gore guruplandýrma yapýp maaslarýn toplamýný veren sorgu
select memleket, sum(maas) as 'Maas Toplamý' from Personeller group by memleket