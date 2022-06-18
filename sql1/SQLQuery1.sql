--alter var olan tabloda degisiklik yapar.

alter table Hocalar add Adres varchar(50)
alter table Hocalar add Yas int 

alter table Hocalar drop column isegiris

drop table Ogrenciler


insert into Hocalar(HocaNo,adsoyad)
values(15,'ahmet kamil')

update Hocalar set Yas+=10 where Yas=25
delete from Hocalar where adsoyad='ahmet kamil'
update Hocalar set maas+=1500 where maas=5000
update Hocalar set HocaNo+=10 where hocaNo<=15

delete from Hocalar where HocaNo=15	
