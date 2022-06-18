truncate table Esyalar    --(tablodaký verýlerý temýzler)



--KEYLER	

--*pk  (primary key birincil anahtar  )
-- secilen alanýn benzersiz olma þartý vardýr
--her tabloda sadece bir alan pk olanarak secilebilir



--*fk(foreign key -yabancý,ikincil key )
--iliþki tablolarýnda baðlantý kurmak icin yapýlýr.

--*uk(unique key -pk mantýgýnda calýsýr )
--birden fazla adette atanbilmesi özelliði ile pk dan ayrýlýr. Seçilen kolunu benzersiz yapar.


delete from Esyalar 



--Ýliþkiler

--1)Bire-Bir Ýliþliler(1-1 ) pk-pk
--2)Bire-Çok Ýliþki(1-n)pk-fk
--3)Çoka-çok iliþki(n-n) arada aracý bir tablo vardýr ve pk-fk (bire çok iliþki mantýðý ile yapýlýr.)



--Normalizasyon Kurallarý	:
--TABLO OLUÞTURULURKEN UYULMASI GEREKEN TEMEL KURALLAR

--1NF:Birincil Normalizasyon: Veri tekrarýr ,veri karmaþasý
--veri bütünlüðünü saðlamak için 1nf kuralý uygulanýr.

--2NF:1NF yi KAPSAR VE AYRIYETEN HER TABLODA PK OLAN BÝR ALAN OLMASINI HEDEFLER

--3NF:2NF YÝ KAPSAR . AYNI ZAMANDA TABLOLAR ARASINDA ÝLÝÞKÝ VE PK-FK BAÐLANTISININ OLMASINI ÝSTER



