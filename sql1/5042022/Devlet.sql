USE [master]
GO
/****** Object:  Database [Devlet]    Script Date: 5.04.2022 18:27:13 ******/
CREATE DATABASE [Devlet]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Devlet', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Devlet.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Devlet_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Devlet_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Devlet] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Devlet].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Devlet] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Devlet] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Devlet] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Devlet] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Devlet] SET ARITHABORT OFF 
GO
ALTER DATABASE [Devlet] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Devlet] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Devlet] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Devlet] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Devlet] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Devlet] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Devlet] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Devlet] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Devlet] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Devlet] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Devlet] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Devlet] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Devlet] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Devlet] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Devlet] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Devlet] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Devlet] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Devlet] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Devlet] SET  MULTI_USER 
GO
ALTER DATABASE [Devlet] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Devlet] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Devlet] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Devlet] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Devlet] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Devlet] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Devlet] SET QUERY_STORE = OFF
GO
USE [Devlet]
GO
/****** Object:  Table [dbo].[Nüfus]    Script Date: 5.04.2022 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nüfus](
	[vNo] [int] NOT NULL,
	[ailesirano] [int] NULL,
	[ciltno] [int] NULL,
	[serino] [char](9) NULL,
	[kutuk] [varchar](50) NULL,
	[medenihali] [varchar](50) NULL,
	[kangrubu] [varchar](50) NULL,
 CONSTRAINT [PK_Nüfus] PRIMARY KEY CLUSTERED 
(
	[vNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tapular]    Script Date: 5.04.2022 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tapular](
	[TapuNo] [int] NOT NULL,
	[ParselNo] [int] NULL,
	[AdaNo] [int] NULL,
	[KonumAdi] [varchar](50) NULL,
	[VergiSicilNo] [int] NULL,
 CONSTRAINT [PK_Tapular] PRIMARY KEY CLUSTERED 
(
	[TapuNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vatandaslar]    Script Date: 5.04.2022 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vatandaslar](
	[vatandasno] [int] IDENTITY(1,1) NOT NULL,
	[adsoyad] [varchar](50) NOT NULL,
	[yas] [int] NOT NULL,
	[telefon] [char](11) NOT NULL,
	[mail] [varchar](50) NOT NULL,
 CONSTRAINT [PK_vatandaslar] PRIMARY KEY CLUSTERED 
(
	[vatandasno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vergiler]    Script Date: 5.04.2022 18:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vergiler](
	[VergisicilNo] [int] NOT NULL,
	[VergiAdi] [varchar](50) NULL,
	[Vno] [int] NULL,
	[VergiAraci] [varchar](50) NULL,
	[VergiDairesi] [varchar](50) NULL,
 CONSTRAINT [PK_Vergiler] PRIMARY KEY CLUSTERED 
(
	[VergisicilNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Nüfus] ([vNo], [ailesirano], [ciltno], [serino], [kutuk], [medenihali], [kangrubu]) VALUES (1, 48, 484, N'4848     ', N'48484', N'4848', N'484')
INSERT [dbo].[Nüfus] ([vNo], [ailesirano], [ciltno], [serino], [kutuk], [medenihali], [kangrubu]) VALUES (2, 5654, 5879, N'try56    ', N'sivas', N'evli', N'0rh-')
INSERT [dbo].[Nüfus] ([vNo], [ailesirano], [ciltno], [serino], [kutuk], [medenihali], [kangrubu]) VALUES (4, 548, 8484, N'844      ', N'84', N'84', N'488')
GO
SET IDENTITY_INSERT [dbo].[vatandaslar] ON 

INSERT [dbo].[vatandaslar] ([vatandasno], [adsoyad], [yas], [telefon], [mail]) VALUES (1, N'ibrahim zengin', 29, N'05346987652', N'zenginibrarhim@gmail.com')
INSERT [dbo].[vatandaslar] ([vatandasno], [adsoyad], [yas], [telefon], [mail]) VALUES (2, N'behnur ', 26, N'05429876532', N'nur@gmail.com')
INSERT [dbo].[vatandaslar] ([vatandasno], [adsoyad], [yas], [telefon], [mail]) VALUES (4, N'özgür leş ', 41, N'02163456897', N'asdassd@gmail.com')
SET IDENTITY_INSERT [dbo].[vatandaslar] OFF
GO
ALTER TABLE [dbo].[Nüfus]  WITH CHECK ADD  CONSTRAINT [FK_Nüfus_vatandaslar] FOREIGN KEY([vNo])
REFERENCES [dbo].[vatandaslar] ([vatandasno])
GO
ALTER TABLE [dbo].[Nüfus] CHECK CONSTRAINT [FK_Nüfus_vatandaslar]
GO
ALTER TABLE [dbo].[Tapular]  WITH CHECK ADD  CONSTRAINT [FK_Tapular_Vergiler] FOREIGN KEY([VergiSicilNo])
REFERENCES [dbo].[Vergiler] ([VergisicilNo])
GO
ALTER TABLE [dbo].[Tapular] CHECK CONSTRAINT [FK_Tapular_Vergiler]
GO
ALTER TABLE [dbo].[Vergiler]  WITH CHECK ADD  CONSTRAINT [FK_Vergiler_Nüfus] FOREIGN KEY([Vno])
REFERENCES [dbo].[Nüfus] ([vNo])
GO
ALTER TABLE [dbo].[Vergiler] CHECK CONSTRAINT [FK_Vergiler_Nüfus]
GO
USE [master]
GO
ALTER DATABASE [Devlet] SET  READ_WRITE 
GO
