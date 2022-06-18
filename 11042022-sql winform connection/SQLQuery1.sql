select m.MusteriAdi,m.MusteriUnvani,s.SatisTarihi,s.NakliyeUcreti,p.Adi,p.SoyAdi from Musteriler m
inner join Satislar s on m.MusteriID=s.MusteriID join Personeller p  on s.PersonelID=p.PersonelID order by NakliyeUcreti desc

-- 3 l� join yapt�k.

--sat�slar ve nakliyeciler tablolsunu ba�la sonra sat�slar ile personelleri ba�la
--ise ilk ba�layan ki�inin �nvan�,i�e ba�lama tarihi, sevkadi ve �irketadi ile tefonunu getiren sorgu
--nakliye �creti 500 den b�y�k olanlar gelsin



select n.SirketAdi,s.SevkAdi,n.Telefon,p.IseBaslamaTarihi,p.Unvan  from Satislar s inner join Nakliyeciler n on s.ShipVia=n.NakliyeciID
join Personeller p on s.PersonelID=p.PersonelID where NakliyeUcreti>500 order by IseBaslamaTarihi asc


