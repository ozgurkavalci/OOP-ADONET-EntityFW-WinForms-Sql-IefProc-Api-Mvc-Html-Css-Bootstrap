--tapular tablosundan konum ad� �stanbul olanlar�n vergi sicil nolar�n� desc s�rala

Select*from Tapular where KonumAdi='istanbul' order by VergiSicilNo desc

--vergiler tablosundan vergi adi binek ise ve vergi araci kamyon olanlar�n vergi dairelerini g�steren sorgu

Select*from Vergiler where VergiAdi='binek' and VergiAraci='kamyon'  order by VergiDairesi

--Vatandaslar tablosundan yas� 18 den kucuk olanlar�n tel ve maillerini getir

Select telefon,mail from Vatandaslar where yas<18 

--N�fuslar tablosundan medeni hali bekar olanlar�n seri numaralr�n� asc olarak s�ralayan sorgu
Select*from N�fus where medenihali='bekar' order by serino asc

--Vatandaslar tablosundan ad soyad i�erisinde nihal ge�enleri getiren sorgu
Select*from Vatandaslar where adsoyad='nihal'

--vergiler tablosundan vergi adi A ile F aras�nda ba�layan ve vergi dairesi A ile G aras�nda bitenleri getiren sorgu
Select*from Vergiler where VergiAdi='[a-f]%' and VergiDairesi='%[a-g]'

--N�fus tablosundan k�t��� sivas olanlar�n cilt nolar�n� iki adet artt�r

select ciltno from N�fus
Select ciltno+2 as ciltno  from N�fus

select yas from Personeller
select Adsoyad,yas+2 as yeniyas  from Personeller where yas<26
Select ciltno+2 as ciltno from N�fus where kutuk='sivas'

--Vergiler tablosundan vergi daire kolonu  bo� olanlar� ve vergi ad� kolonu dolu olanlar� getiren soru.

Select*from Vergiler where VergiDairesi is null and VergiAdi is not null