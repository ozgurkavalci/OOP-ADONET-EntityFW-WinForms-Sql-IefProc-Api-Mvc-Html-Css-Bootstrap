--tapular tablosundan konum adý ýstanbul olanlarýn vergi sicil nolarýný desc sýrala

Select*from Tapular where KonumAdi='istanbul' order by VergiSicilNo desc

--vergiler tablosundan vergi adi binek ise ve vergi araci kamyon olanlarýn vergi dairelerini gösteren sorgu

Select*from Vergiler where VergiAdi='binek' and VergiAraci='kamyon'  order by VergiDairesi

--Vatandaslar tablosundan yasý 18 den kucuk olanlarýn tel ve maillerini getir

Select telefon,mail from Vatandaslar where yas<18 

--Nüfuslar tablosundan medeni hali bekar olanlarýn seri numaralrýný asc olarak sýralayan sorgu
Select*from Nüfus where medenihali='bekar' order by serino asc

--Vatandaslar tablosundan ad soyad içerisinde nihal geçenleri getiren sorgu
Select*from Vatandaslar where adsoyad='nihal'

--vergiler tablosundan vergi adi A ile F arasýnda baþlayan ve vergi dairesi A ile G arasýnda bitenleri getiren sorgu
Select*from Vergiler where VergiAdi='[a-f]%' and VergiDairesi='%[a-g]'

--Nüfus tablosundan kütüðü sivas olanlarýn cilt nolarýný iki adet arttýr

select ciltno from Nüfus
Select ciltno+2 as ciltno  from Nüfus

select yas from Personeller
select Adsoyad,yas+2 as yeniyas  from Personeller where yas<26
Select ciltno+2 as ciltno from Nüfus where kutuk='sivas'

--Vergiler tablosundan vergi daire kolonu  boþ olanlarý ve vergi adý kolonu dolu olanlarý getiren soru.

Select*from Vergiler where VergiDairesi is null and VergiAdi is not null