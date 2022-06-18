select m.MusteriAdi,m.MusteriUnvani,s.SatisTarihi,s.NakliyeUcreti,p.Adi,p.SoyAdi from Musteriler m
inner join Satislar s on m.MusteriID=s.MusteriID join Personeller p  on s.PersonelID=p.PersonelID order by NakliyeUcreti desc

-- 3 lü join yaptýk.

--satýslar ve nakliyeciler tablolsunu baðla sonra satýslar ile personelleri baðla
--ise ilk baþlayan kiþinin ünvaný,iþe baþlama tarihi, sevkadi ve þirketadi ile tefonunu getiren sorgu
--nakliye ücreti 500 den büyük olanlar gelsin



select n.SirketAdi,s.SevkAdi,n.Telefon,p.IseBaslamaTarihi,p.Unvan  from Satislar s inner join Nakliyeciler n on s.ShipVia=n.NakliyeciID
join Personeller p on s.PersonelID=p.PersonelID where NakliyeUcreti>500 order by IseBaslamaTarihi asc


