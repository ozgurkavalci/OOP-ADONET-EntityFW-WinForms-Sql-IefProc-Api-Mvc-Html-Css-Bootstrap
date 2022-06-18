truncate table Esyalar    --(tablodak� ver�ler� tem�zler)



--KEYLER	

--*pk  (primary key birincil anahtar  )
-- secilen alan�n benzersiz olma �art� vard�r
--her tabloda sadece bir alan pk olanarak secilebilir



--*fk(foreign key -yabanc�,ikincil key )
--ili�ki tablolar�nda ba�lant� kurmak icin yap�l�r.

--*uk(unique key -pk mant�g�nda cal�s�r )
--birden fazla adette atanbilmesi �zelli�i ile pk dan ayr�l�r. Se�ilen kolunu benzersiz yapar.


delete from Esyalar 



--�li�kiler

--1)Bire-Bir �li�liler(1-1 ) pk-pk
--2)Bire-�ok �li�ki(1-n)pk-fk
--3)�oka-�ok ili�ki(n-n) arada arac� bir tablo vard�r ve pk-fk (bire �ok ili�ki mant��� ile yap�l�r.)



--Normalizasyon Kurallar�	:
--TABLO OLU�TURULURKEN UYULMASI GEREKEN TEMEL KURALLAR

--1NF:Birincil Normalizasyon: Veri tekrar�r ,veri karma�as�
--veri b�t�nl���n� sa�lamak i�in 1nf kural� uygulan�r.

--2NF:1NF yi KAPSAR VE AYRIYETEN HER TABLODA PK OLAN B�R ALAN OLMASINI HEDEFLER

--3NF:2NF Y� KAPSAR . AYNI ZAMANDA TABLOLAR ARASINDA �L��K� VE PK-FK BA�LANTISININ OLMASINI �STER



