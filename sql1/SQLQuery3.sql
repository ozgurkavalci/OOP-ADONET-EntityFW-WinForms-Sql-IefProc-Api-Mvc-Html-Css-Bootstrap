---2-DML (Data manipulation language -veri d�zenleme komutlar�)
--Tablodaki verilerle ilgilenir.
--Komutlar�:
--*insert(ekleme i�lemi i�in)
--*update(yenile,g�ncelle)           -- her brinin ad� CRUD olarak gecer(create,read,update,delete)bas harfleri
--*delete(sil)
--*select(se�mek,�a��rmak)




insert into Malzemeler(malzemeno,MalzemeAd�,MalzemeFiyat,Tarih,Barkodkodu)
values(4,'odun',4500,'12.02.2010','4578')

--malzemead� odun olan�n malzeme f�yat�n� art�ral�m


update Malzemeler set MalzemeFiyat=MalzemeFiyat+5000

update Malzemeler set MalzemeFiyat+=100 where MalzemeAd�='telefon'



delete from Malzemeler where MalzemeAd�='odun'

