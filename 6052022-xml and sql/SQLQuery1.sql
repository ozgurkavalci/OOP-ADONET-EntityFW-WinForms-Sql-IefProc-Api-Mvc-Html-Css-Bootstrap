select UrunID,UrunAdi,BirimFiyati from Urunler for xml auto
--tablo ýcýndeký verileri tek satýrda xml formatýna donusturdu auto=otomatýkten oldugu sekilde getir


select top 5 UrunID,UrunAdi,BirimFiyati from Urunler for xml auto,root('RootNode')  

select*from Urunler order by UrunAdi asc

select top 10 UrunID,UrunAdi,BirimFiyati,Tanimi from Urunler inner join Kategoriler on Urunler.KategoriID=Kategoriler.KategoriID
for xml auto,root('RootNode')

select top 10 UrunID,UrunAdi,BirimFiyati,Tanimi from Urunler


select top 5 UrunID,UrunAdi,BirimFiyati from Urunler for xml raw('Mamüller'),root('RootNode')

--Çýktýmýzda gördüðümüz gibi Urunler olarak belirttiðimiz element adý xml çýktýðýmýzda görünmektedir.
--Eðer raw ifadesi ile beraber herhangi nir element adý belirtilmezse sql server otomatik olarak bizim yerimize
--raw adlý elementini kullanacaktýr.


select UrunID,UrunAdi,BirimFiyati from Urunler for json auto

--sql hata yakalama

begin try
select a=5/0
select b=5
select c=3
end try
begin catch
print 'Hata Mesajý'
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

--catch blogunda kullanýlan fonksiyonlar ve acýklamalarý sý sekilde;
--error number:oluþan hata numarasý,
--error message:Oluþan hataya aþt hata mesajý


begin try
exec Ornek_Procedure
end try
begin catch
select Hata_Satiri=ERROR_LINE(),
Procedure_adi=ERROR_PROCEDURE()
select [Hata_Mresaji]=ERROR_MESSAGE()
end catch
