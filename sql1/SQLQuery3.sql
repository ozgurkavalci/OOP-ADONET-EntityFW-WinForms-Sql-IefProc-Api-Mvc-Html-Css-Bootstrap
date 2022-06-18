---2-DML (Data manipulation language -veri düzenleme komutlarý)
--Tablodaki verilerle ilgilenir.
--Komutlarý:
--*insert(ekleme iþlemi için)
--*update(yenile,güncelle)           -- her brinin adý CRUD olarak gecer(create,read,update,delete)bas harfleri
--*delete(sil)
--*select(seçmek,çaðýrmak)




insert into Malzemeler(malzemeno,MalzemeAdý,MalzemeFiyat,Tarih,Barkodkodu)
values(4,'odun',4500,'12.02.2010','4578')

--malzemeadý odun olanýn malzeme fýyatýný artýralým


update Malzemeler set MalzemeFiyat=MalzemeFiyat+5000

update Malzemeler set MalzemeFiyat+=100 where MalzemeAdý='telefon'



delete from Malzemeler where MalzemeAdý='odun'

