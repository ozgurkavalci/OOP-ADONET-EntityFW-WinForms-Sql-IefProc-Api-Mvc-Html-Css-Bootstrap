--musterilerle sat�slar tablosunu b�rb�r�ne ba�l�yoruz musteriad�,musteri�d,muster�unvan�           sat�slardan �se 
--odemetarihi,sevk tarihi,shipvia s� 

select MusteriAdi,MusteriUnvani,OdemeTarihi,SevkTarihi,ShipVia from Musteriler
inner join  Satislar on Satislar.MusteriID=Musteriler.MusteriID
