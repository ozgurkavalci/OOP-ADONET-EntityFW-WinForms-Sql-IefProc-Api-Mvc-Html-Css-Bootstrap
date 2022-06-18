select UrunID,UrunAdi,BirimFiyati from Urunler for xml auto
--tablo �c�ndek� verileri tek sat�rda xml format�na donusturdu auto=otomat�kten oldugu sekilde getir


select top 5 UrunID,UrunAdi,BirimFiyati from Urunler for xml auto,root('RootNode')  

select*from Urunler order by UrunAdi asc

select top 10 UrunID,UrunAdi,BirimFiyati,Tanimi from Urunler inner join Kategoriler on Urunler.KategoriID=Kategoriler.KategoriID
for xml auto,root('RootNode')

select top 10 UrunID,UrunAdi,BirimFiyati,Tanimi from Urunler


select top 5 UrunID,UrunAdi,BirimFiyati from Urunler for xml raw('Mam�ller'),root('RootNode')

--��kt�m�zda g�rd���m�z gibi Urunler olarak belirtti�imiz element ad� xml ��kt���m�zda g�r�nmektedir.
--E�er raw ifadesi ile beraber herhangi nir element ad� belirtilmezse sql server otomatik olarak bizim yerimize
--raw adl� elementini kullanacakt�r.


select UrunID,UrunAdi,BirimFiyati from Urunler for json auto

--sql hata yakalama

begin try
select a=5/0
select b=5
select c=3
end try
begin catch
print 'Hata Mesaj�'
end catch



begin try 
select sonuc=5/0
end try
begin catch
select[Hata_Satiri]=ERROR_LINE(),
[Hata_Sayisi]=ERROR_NUMBER(),
[Hata_Onemi]=ERROR_SEVERITY(),
[Hata_Durumu]=ERROR_STATE()
select [Hata_Mesaji]=ERROR_MESSAGE()
end catch

--catch blogunda kullan�lan fonksiyonlar ve ac�klamalar� s� sekilde;
--error number:olu�an hata numaras�,
--error message:Olu�an hataya a�t hata mesaj�


begin try
exec Ornek_Procedure
end try
begin catch
select Hata_Satiri=ERROR_LINE(),
Procedure_adi=ERROR_PROCEDURE()
select [Hata_Mresaji]=ERROR_MESSAGE()
end catch
