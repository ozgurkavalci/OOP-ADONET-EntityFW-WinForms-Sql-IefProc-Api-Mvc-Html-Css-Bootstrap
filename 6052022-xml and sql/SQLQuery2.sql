CREATE TABLE [dbo].[TBL_GUID]
(
[ID] [UNIQUEIDENTIFIER] DEFAULT (newsequentialid()),
[Value] [varchar](10) NULL
)

INSERT INTO TBL_GUID(Value) values ('bekir') --128 bit 16 byte �ifreleme e��iz �ifreleme
--primary key kullan�lmad���nda kullan�l�r�

INSERT INTO TBL_GUID(Value) values ('�zg�r')
INSERT INTO TBL_GUID(Value) values ('bekir')

select*from TBL_GUID

CREATE TABLE [dbo].[TBL_GUID1]
(
[ID] [UNIQUEIDENTIFIER] DEFAULT (newid()),
[Value] [varchar](10) NULL
)

INSERT INTO TBL_GUID1(Value) values ('bet�l')

select*from TBL_GUID1