--musterilerle satýslar tablosunu býrbýrýne baðlýyoruz musteriadý,musteriýd,musterýunvaný           satýslardan ýse 
--odemetarihi,sevk tarihi,shipvia sý 

select MusteriAdi,MusteriUnvani,OdemeTarihi,SevkTarihi,ShipVia from Musteriler
inner join  Satislar on Satislar.MusteriID=Musteriler.MusteriID
