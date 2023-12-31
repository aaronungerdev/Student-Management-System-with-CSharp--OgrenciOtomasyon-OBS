USE [master]
GO
/****** Object:  Database [OgrenciOtomasyon]    Script Date: 6/16/2023 9:41:45 AM ******/
CREATE DATABASE [OgrenciOtomasyon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OgrenciOtomasyon', FILENAME = N'C:\Users\unger\OneDrive\Masaüstü\Veritabanı\OgrenciOtomasyon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OgrenciOtomasyon_log', FILENAME = N'C:\Users\unger\OneDrive\Masaüstü\Veritabanı\OgrenciOtomasyon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [OgrenciOtomasyon] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OgrenciOtomasyon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OgrenciOtomasyon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET ARITHABORT OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [OgrenciOtomasyon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OgrenciOtomasyon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OgrenciOtomasyon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OgrenciOtomasyon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OgrenciOtomasyon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET RECOVERY FULL 
GO
ALTER DATABASE [OgrenciOtomasyon] SET  MULTI_USER 
GO
ALTER DATABASE [OgrenciOtomasyon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OgrenciOtomasyon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OgrenciOtomasyon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OgrenciOtomasyon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OgrenciOtomasyon] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OgrenciOtomasyon] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [OgrenciOtomasyon] SET QUERY_STORE = OFF
GO
USE [OgrenciOtomasyon]
GO
/****** Object:  Table [dbo].[BolumTable]    Script Date: 6/16/2023 9:41:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BolumTable](
	[BolumID] [nchar](3) NOT NULL,
	[BolumAd] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BolumTable] PRIMARY KEY CLUSTERED 
(
	[BolumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DersTable]    Script Date: 6/16/2023 9:41:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DersTable](
	[DersID] [int] IDENTITY(1000,1) NOT NULL,
	[DersAdi] [nvarchar](50) NOT NULL,
	[DersKredi] [smallint] NOT NULL,
	[DersAKTS] [smallint] NOT NULL,
 CONSTRAINT [PK_DersTable] PRIMARY KEY CLUSTERED 
(
	[DersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemurTable]    Script Date: 6/16/2023 9:41:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemurTable](
	[MemurID] [int] IDENTITY(39060300,1) NOT NULL,
	[MemurAd] [nvarchar](50) NOT NULL,
	[MemurSoyad] [nvarchar](50) NOT NULL,
	[MemurTC] [char](11) NOT NULL,
	[MemurSifre] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotTable]    Script Date: 6/16/2023 9:41:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotTable](
	[NotID] [int] IDENTITY(55000,1) NOT NULL,
	[OgrenciDersID] [int] NOT NULL,
	[Vize] [tinyint] NULL,
	[Final] [tinyint] NULL,
	[Butunleme] [tinyint] NULL,
	[Gecme Notu] [tinyint] NULL,
	[Gecme Durumu] [nvarchar](50) NULL,
	[OgrenciDonem] [tinyint] NULL,
 CONSTRAINT [PK_NotTable] PRIMARY KEY CLUSTERED 
(
	[NotID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgrenciDersTable]    Script Date: 6/16/2023 9:41:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgrenciDersTable](
	[OgrenciDersID] [int] IDENTITY(98000,1) NOT NULL,
	[OgrenciNo] [int] NOT NULL,
	[DersID] [int] NOT NULL,
	[OgrenciDersDonem] [tinyint] NULL,
	[DanismanOnay] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_OgrenciDersTable] PRIMARY KEY CLUSTERED 
(
	[OgrenciDersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgrenciTable]    Script Date: 6/16/2023 9:41:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgrenciTable](
	[OgrenciNo] [int] IDENTITY(19060300,1) NOT NULL,
	[OgrenciAd] [nvarchar](50) NOT NULL,
	[OgrenciSoyad] [nvarchar](50) NOT NULL,
	[OgrenciTC] [char](11) NOT NULL,
	[OgrenciBolumID] [nchar](3) NULL,
	[OgrenciDonem] [tinyint] NULL,
	[OgrenciDanismanID] [int] NULL,
	[OgrenciSifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_OgrenciTable] PRIMARY KEY CLUSTERED 
(
	[OgrenciNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgretmenDersTable]    Script Date: 6/16/2023 9:41:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgretmenDersTable](
	[OgretmenDersID] [int] IDENTITY(19800,1) NOT NULL,
	[OgretmenID] [int] NOT NULL,
	[DersID] [int] NOT NULL,
 CONSTRAINT [PK_OgretmenDersTable] PRIMARY KEY CLUSTERED 
(
	[OgretmenDersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgretmenTable]    Script Date: 6/16/2023 9:41:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgretmenTable](
	[OgretmenID] [int] IDENTITY(29060300,1) NOT NULL,
	[OgretmenAd] [nvarchar](50) NOT NULL,
	[OgretmenSoyad] [nvarchar](50) NOT NULL,
	[OgretmenBolumID] [nchar](3) NOT NULL,
	[OgretmenTC] [char](11) NOT NULL,
	[OgretmenSifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_OgretmenTable] PRIMARY KEY CLUSTERED 
(
	[OgretmenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTable]    Script Date: 6/16/2023 9:41:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTable](
	[USERTC] [char](11) NOT NULL,
 CONSTRAINT [PK_UserTable] PRIMARY KEY CLUSTERED 
(
	[USERTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BolumTable] ([BolumID], [BolumAd]) VALUES (N'BIL', N'Bilgisayar Mühendisliği')
INSERT [dbo].[BolumTable] ([BolumID], [BolumAd]) VALUES (N'EDB', N'Edebiyat')
INSERT [dbo].[BolumTable] ([BolumID], [BolumAd]) VALUES (N'ELK', N'Elektrik-Elektronik Mühendisliği')
INSERT [dbo].[BolumTable] ([BolumID], [BolumAd]) VALUES (N'GRP', N'Grafik Tasarım')
INSERT [dbo].[BolumTable] ([BolumID], [BolumAd]) VALUES (N'İLH', N'İlahiyat Mühendisliği')
INSERT [dbo].[BolumTable] ([BolumID], [BolumAd]) VALUES (N'İNŞ', N'İnşaat')
INSERT [dbo].[BolumTable] ([BolumID], [BolumAd]) VALUES (N'MAK', N'Makine Mühendisliği')
INSERT [dbo].[BolumTable] ([BolumID], [BolumAd]) VALUES (N'MED', N'Tıp')
INSERT [dbo].[BolumTable] ([BolumID], [BolumAd]) VALUES (N'ZİR', N'Ziraat Mühendisliği')
GO
SET IDENTITY_INSERT [dbo].[DersTable] ON 

INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1001, N'Veritabanı ve Yönetimi', 5, 6)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1003, N'Matematik-1', 5, 6)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1004, N'Matematik-2', 5, 6)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1005, N'İnklap Tarihi ve Atatürkçülük', 6, 7)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1006, N'Nesne Tabanlı Programlama', 5, 6)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1007, N'C Programlama', 7, 8)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1008, N'Mesleki İngilizce', 4, 5)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1009, N'İşletme Yönetimi', 4, 5)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1010, N'Sistem Analiz ve Tasarımı', 6, 7)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1011, N'Delphi Programlama', 6, 7)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1012, N'Açık Kaynak İşletim Sistemi', 5, 6)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1013, N'Grafik ve Animasyon', 6, 7)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1014, N'İngilizce-1', 10, 15)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1015, N'İngilizce-2', 4, 5)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1016, N'Programlamaya Giriş', 6, 7)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1017, N'Algoritma Dersleri', 5, 6)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1018, N'Ofis Yazılımları', 6, 7)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1019, N'Web Editörü', 6, 7)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1020, N'İnternet Programcılığı', 5, 6)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1021, N'İletişim', 7, 8)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1022, N'Araştırma Yöntem ve Teknikleri', 6, 7)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1023, N'Türk Dili ve Edebiyatı', 8, 9)
INSERT [dbo].[DersTable] ([DersID], [DersAdi], [DersKredi], [DersAKTS]) VALUES (1024, N'Sunucu İşletim Sistemi', 4, 5)
SET IDENTITY_INSERT [dbo].[DersTable] OFF
GO
SET IDENTITY_INSERT [dbo].[MemurTable] ON 

INSERT [dbo].[MemurTable] ([MemurID], [MemurAd], [MemurSoyad], [MemurTC], [MemurSifre]) VALUES (39060305, N'Harun', N'Ünger', N'15975365498', N'123')
INSERT [dbo].[MemurTable] ([MemurID], [MemurAd], [MemurSoyad], [MemurTC], [MemurSifre]) VALUES (39060301, N'Berat', N'Erdem', N'11111111111', N'123')
INSERT [dbo].[MemurTable] ([MemurID], [MemurAd], [MemurSoyad], [MemurTC], [MemurSifre]) VALUES (39060303, N'Muhammed Mehdi ', N'Özmen', N'33333333333', N'123')
INSERT [dbo].[MemurTable] ([MemurID], [MemurAd], [MemurSoyad], [MemurTC], [MemurSifre]) VALUES (39060304, N'Ramazan', N'Taş', N'44444444444', N'123')
SET IDENTITY_INSERT [dbo].[MemurTable] OFF
GO
SET IDENTITY_INSERT [dbo].[NotTable] ON 

INSERT [dbo].[NotTable] ([NotID], [OgrenciDersID], [Vize], [Final], [Butunleme], [Gecme Notu], [Gecme Durumu], [OgrenciDonem]) VALUES (55029, 98051, 90, 100, 60, 72, N'Basarili', 1)
INSERT [dbo].[NotTable] ([NotID], [OgrenciDersID], [Vize], [Final], [Butunleme], [Gecme Notu], [Gecme Durumu], [OgrenciDonem]) VALUES (55030, 98052, 100, 60, 0, 76, N'Basarili', 1)
INSERT [dbo].[NotTable] ([NotID], [OgrenciDersID], [Vize], [Final], [Butunleme], [Gecme Notu], [Gecme Durumu], [OgrenciDonem]) VALUES (55031, 98053, 0, 0, 0, 0, N'Basarisiz', 1)
INSERT [dbo].[NotTable] ([NotID], [OgrenciDersID], [Vize], [Final], [Butunleme], [Gecme Notu], [Gecme Durumu], [OgrenciDonem]) VALUES (55032, 98048, 50, 70, 60, 62, N'Basarili', 1)
INSERT [dbo].[NotTable] ([NotID], [OgrenciDersID], [Vize], [Final], [Butunleme], [Gecme Notu], [Gecme Durumu], [OgrenciDonem]) VALUES (55033, 98049, 0, 0, 0, 0, NULL, 1)
INSERT [dbo].[NotTable] ([NotID], [OgrenciDersID], [Vize], [Final], [Butunleme], [Gecme Notu], [Gecme Durumu], [OgrenciDonem]) VALUES (55034, 98050, 10, 60, 50, 34, N'Basarisiz', 1)
INSERT [dbo].[NotTable] ([NotID], [OgrenciDersID], [Vize], [Final], [Butunleme], [Gecme Notu], [Gecme Durumu], [OgrenciDonem]) VALUES (55035, 98054, 60, 0, 0, 24, N'Basarisiz', 2)
INSERT [dbo].[NotTable] ([NotID], [OgrenciDersID], [Vize], [Final], [Butunleme], [Gecme Notu], [Gecme Durumu], [OgrenciDonem]) VALUES (55036, 98055, 100, 25, 60, 76, N'Basarili', 2)
INSERT [dbo].[NotTable] ([NotID], [OgrenciDersID], [Vize], [Final], [Butunleme], [Gecme Notu], [Gecme Durumu], [OgrenciDonem]) VALUES (55037, 98054, 70, 60, 100, 64, N'Basarili', 5)
INSERT [dbo].[NotTable] ([NotID], [OgrenciDersID], [Vize], [Final], [Butunleme], [Gecme Notu], [Gecme Durumu], [OgrenciDonem]) VALUES (55038, 98052, 35, 90, 0, 68, N'Basarili', 5)
INSERT [dbo].[NotTable] ([NotID], [OgrenciDersID], [Vize], [Final], [Butunleme], [Gecme Notu], [Gecme Durumu], [OgrenciDonem]) VALUES (55039, 98051, 70, 50, 100, 88, N'Basarili', 5)
SET IDENTITY_INSERT [dbo].[NotTable] OFF
GO
SET IDENTITY_INSERT [dbo].[OgrenciDersTable] ON 

INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98048, 19060321, 1001, NULL, N' Kesin Kayıt ')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98049, 19060321, 1003, NULL, N' Kesin Kayıt ')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98050, 19060321, 1004, NULL, N' Kesin Kayıt ')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98051, 19060320, 1001, NULL, N'Kesin Kayıt')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98052, 19060320, 1006, NULL, N'Onay Bekleniyor')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98053, 19060320, 1008, NULL, N' Kesin Kayıt ')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98054, 19060321, 1006, NULL, N'Kesin Kayıt')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98055, 19060321, 1007, NULL, N' Kesin Kayıt ')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98057, 19060320, 1008, NULL, N'Danışman Onay''a gönderilmeyi bekliyor')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98061, 19060321, 1010, NULL, N'Onay Bekleniyor')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98062, 19060321, 1001, NULL, N'Danışman Onay''a gönderilmeyi bekliyor')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98063, 19060321, 1001, NULL, N'Danışman Onay''a gönderilmeyi bekliyor')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98064, 19060321, 1001, NULL, N'Danışman Onay''a gönderilmeyi bekliyor')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98065, 19060321, 1010, NULL, N'Danışman Onay''a gönderilmeyi bekliyor')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98066, 19060321, 1009, NULL, N'Danışman Onay''a gönderilmeyi bekliyor')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98067, 19060320, 1016, NULL, N'Danışman Onay''a gönderilmeyi bekliyor')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98068, 19060320, 1001, NULL, N'Danışman Onay''a gönderilmeyi bekliyor')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98069, 19060320, 1001, NULL, N'Danışman Onay''a gönderilmeyi bekliyor')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98070, 19060320, 1001, NULL, N'Danışman Onay''a gönderilmeyi bekliyor')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98071, 19060320, 1001, NULL, N'Danışman Onay''a gönderilmeyi bekliyor')
INSERT [dbo].[OgrenciDersTable] ([OgrenciDersID], [OgrenciNo], [DersID], [OgrenciDersDonem], [DanismanOnay]) VALUES (98072, 19060320, 1001, NULL, N'Danışman Onay''a gönderilmeyi bekliyor')
SET IDENTITY_INSERT [dbo].[OgrenciDersTable] OFF
GO
SET IDENTITY_INSERT [dbo].[OgrenciTable] ON 

INSERT [dbo].[OgrenciTable] ([OgrenciNo], [OgrenciAd], [OgrenciSoyad], [OgrenciTC], [OgrenciBolumID], [OgrenciDonem], [OgrenciDanismanID], [OgrenciSifre]) VALUES (19060320, N'Kemal ', N'Sunal', N'98765432198', N'BIL', 5, 29060332, N'1234')
INSERT [dbo].[OgrenciTable] ([OgrenciNo], [OgrenciAd], [OgrenciSoyad], [OgrenciTC], [OgrenciBolumID], [OgrenciDonem], [OgrenciDanismanID], [OgrenciSifre]) VALUES (19060321, N'Adile', N'Naşit', N'12345678914', N'BIL', 5, 29060333, N'123')
INSERT [dbo].[OgrenciTable] ([OgrenciNo], [OgrenciAd], [OgrenciSoyad], [OgrenciTC], [OgrenciBolumID], [OgrenciDonem], [OgrenciDanismanID], [OgrenciSifre]) VALUES (19060322, N'Şener', N'Şen', N'12323232323', N'BIL', 4, 29060332, N'123')
INSERT [dbo].[OgrenciTable] ([OgrenciNo], [OgrenciAd], [OgrenciSoyad], [OgrenciTC], [OgrenciBolumID], [OgrenciDonem], [OgrenciDanismanID], [OgrenciSifre]) VALUES (19060323, N'İlyas', N'Salman', N'12345666666', N'BIL', 4, 29060332, N'123')
INSERT [dbo].[OgrenciTable] ([OgrenciNo], [OgrenciAd], [OgrenciSoyad], [OgrenciTC], [OgrenciBolumID], [OgrenciDonem], [OgrenciDanismanID], [OgrenciSifre]) VALUES (19060324, N'Ali', N'Şen', N'12345678915', N'BIL', 4, 29060332, N'123')
INSERT [dbo].[OgrenciTable] ([OgrenciNo], [OgrenciAd], [OgrenciSoyad], [OgrenciTC], [OgrenciBolumID], [OgrenciDonem], [OgrenciDanismanID], [OgrenciSifre]) VALUES (19060325, N'Kartal', N'Tibet', N'12366666666', N'BIL', 4, 29060333, N'123')
INSERT [dbo].[OgrenciTable] ([OgrenciNo], [OgrenciAd], [OgrenciSoyad], [OgrenciTC], [OgrenciBolumID], [OgrenciDonem], [OgrenciDanismanID], [OgrenciSifre]) VALUES (19060326, N'Yılmaz', N'Güney', N'12355777898', N'GRP', 4, 29060332, N'123')
INSERT [dbo].[OgrenciTable] ([OgrenciNo], [OgrenciAd], [OgrenciSoyad], [OgrenciTC], [OgrenciBolumID], [OgrenciDonem], [OgrenciDanismanID], [OgrenciSifre]) VALUES (19060327, N'Tarık', N'Akan', N'12322334455', N'BIL', 2, 29060333, N'123')
INSERT [dbo].[OgrenciTable] ([OgrenciNo], [OgrenciAd], [OgrenciSoyad], [OgrenciTC], [OgrenciBolumID], [OgrenciDonem], [OgrenciDanismanID], [OgrenciSifre]) VALUES (19060328, N'Ayşen', N'Gruda', N'26458965324', N'EDB', 1, 29060332, N'123')
SET IDENTITY_INSERT [dbo].[OgrenciTable] OFF
GO
SET IDENTITY_INSERT [dbo].[OgretmenDersTable] ON 

INSERT [dbo].[OgretmenDersTable] ([OgretmenDersID], [OgretmenID], [DersID]) VALUES (19825, 29060332, 1001)
INSERT [dbo].[OgretmenDersTable] ([OgretmenDersID], [OgretmenID], [DersID]) VALUES (19826, 29060333, 1004)
INSERT [dbo].[OgretmenDersTable] ([OgretmenDersID], [OgretmenID], [DersID]) VALUES (19827, 29060332, 1006)
INSERT [dbo].[OgretmenDersTable] ([OgretmenDersID], [OgretmenID], [DersID]) VALUES (19828, 29060334, 1007)
SET IDENTITY_INSERT [dbo].[OgretmenDersTable] OFF
GO
SET IDENTITY_INSERT [dbo].[OgretmenTable] ON 

INSERT [dbo].[OgretmenTable] ([OgretmenID], [OgretmenAd], [OgretmenSoyad], [OgretmenBolumID], [OgretmenTC], [OgretmenSifre]) VALUES (29060332, N'Meliha', N'Ünger', N'EDB', N'13131313131', N'123456')
INSERT [dbo].[OgretmenTable] ([OgretmenID], [OgretmenAd], [OgretmenSoyad], [OgretmenBolumID], [OgretmenTC], [OgretmenSifre]) VALUES (29060333, N'Steve', N'Jobs', N'BIL', N'12345678911', N'123')
INSERT [dbo].[OgretmenTable] ([OgretmenID], [OgretmenAd], [OgretmenSoyad], [OgretmenBolumID], [OgretmenTC], [OgretmenSifre]) VALUES (29060334, N'Bill', N'Gates', N'BIL', N'12345678955', N'123')
INSERT [dbo].[OgretmenTable] ([OgretmenID], [OgretmenAd], [OgretmenSoyad], [OgretmenBolumID], [OgretmenTC], [OgretmenSifre]) VALUES (29060335, N'Mark', N'Zuckerberg', N'BIL', N'12345454545', N'123')
INSERT [dbo].[OgretmenTable] ([OgretmenID], [OgretmenAd], [OgretmenSoyad], [OgretmenBolumID], [OgretmenTC], [OgretmenSifre]) VALUES (29060336, N'Frida', N'Kahlo', N'BIL', N'12323335555', N'123')
INSERT [dbo].[OgretmenTable] ([OgretmenID], [OgretmenAd], [OgretmenSoyad], [OgretmenBolumID], [OgretmenTC], [OgretmenSifre]) VALUES (29060337, N'Ludving Van', N'Beethoven', N'BIL', N'13236999999', N'123')
INSERT [dbo].[OgretmenTable] ([OgretmenID], [OgretmenAd], [OgretmenSoyad], [OgretmenBolumID], [OgretmenTC], [OgretmenSifre]) VALUES (29060338, N'Marie', N'Curie', N'BIL', N'12311223344', N'123')
INSERT [dbo].[OgretmenTable] ([OgretmenID], [OgretmenAd], [OgretmenSoyad], [OgretmenBolumID], [OgretmenTC], [OgretmenSifre]) VALUES (29060339, N'Albert ', N'Einstein', N'BIL', N'12312323344', N'123')
SET IDENTITY_INSERT [dbo].[OgretmenTable] OFF
GO
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'12311223344')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'12322334455')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'12323232323')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'12323335555')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'12345454545')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'12345666666')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'12345678911')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'12345678912')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'12345678914')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'12345678915')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'12345678955')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'12355777898')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'12366666666')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'13236999999')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'26458965324')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'45612345612')
INSERT [dbo].[UserTable] ([USERTC]) VALUES (N'98765432198')
GO
ALTER TABLE [dbo].[NotTable] ADD  CONSTRAINT [DF_NotTable_Vize]  DEFAULT ((0)) FOR [Vize]
GO
ALTER TABLE [dbo].[NotTable] ADD  CONSTRAINT [DF_NotTable_Final]  DEFAULT ((0)) FOR [Final]
GO
ALTER TABLE [dbo].[NotTable] ADD  CONSTRAINT [DF_NotTable_Butunleme]  DEFAULT ((0)) FOR [Butunleme]
GO
ALTER TABLE [dbo].[NotTable] ADD  CONSTRAINT [DF_NotTable_Gecme Notu]  DEFAULT ((0)) FOR [Gecme Notu]
GO
ALTER TABLE [dbo].[OgrenciDersTable] ADD  CONSTRAINT [DF_OgrenciDersTable_DanismanOnay]  DEFAULT (N'Danışman Onay''a gönderilmeyi bekliyor') FOR [DanismanOnay]
GO
ALTER TABLE [dbo].[OgrenciTable] ADD  CONSTRAINT [DF_OgrenciTable_OgrenciDonem]  DEFAULT ((1)) FOR [OgrenciDonem]
GO
ALTER TABLE [dbo].[NotTable]  WITH CHECK ADD  CONSTRAINT [FK_NotTable_OgrenciDersTable] FOREIGN KEY([OgrenciDersID])
REFERENCES [dbo].[OgrenciDersTable] ([OgrenciDersID])
GO
ALTER TABLE [dbo].[NotTable] CHECK CONSTRAINT [FK_NotTable_OgrenciDersTable]
GO
ALTER TABLE [dbo].[OgrenciDersTable]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDersTable_DersTable] FOREIGN KEY([DersID])
REFERENCES [dbo].[DersTable] ([DersID])
GO
ALTER TABLE [dbo].[OgrenciDersTable] CHECK CONSTRAINT [FK_OgrenciDersTable_DersTable]
GO
ALTER TABLE [dbo].[OgrenciDersTable]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDersTable_OgrenciTable] FOREIGN KEY([OgrenciNo])
REFERENCES [dbo].[OgrenciTable] ([OgrenciNo])
GO
ALTER TABLE [dbo].[OgrenciDersTable] CHECK CONSTRAINT [FK_OgrenciDersTable_OgrenciTable]
GO
ALTER TABLE [dbo].[OgrenciTable]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciTable_BolumTable] FOREIGN KEY([OgrenciBolumID])
REFERENCES [dbo].[BolumTable] ([BolumID])
GO
ALTER TABLE [dbo].[OgrenciTable] CHECK CONSTRAINT [FK_OgrenciTable_BolumTable]
GO
ALTER TABLE [dbo].[OgrenciTable]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciTable_OgretmenTable] FOREIGN KEY([OgrenciDanismanID])
REFERENCES [dbo].[OgretmenTable] ([OgretmenID])
GO
ALTER TABLE [dbo].[OgrenciTable] CHECK CONSTRAINT [FK_OgrenciTable_OgretmenTable]
GO
ALTER TABLE [dbo].[OgretmenDersTable]  WITH CHECK ADD  CONSTRAINT [FK_OgretmenDersTable_DersTable] FOREIGN KEY([DersID])
REFERENCES [dbo].[DersTable] ([DersID])
GO
ALTER TABLE [dbo].[OgretmenDersTable] CHECK CONSTRAINT [FK_OgretmenDersTable_DersTable]
GO
ALTER TABLE [dbo].[OgretmenDersTable]  WITH CHECK ADD  CONSTRAINT [FK_OgretmenDersTable_OgretmenTable1] FOREIGN KEY([OgretmenID])
REFERENCES [dbo].[OgretmenTable] ([OgretmenID])
GO
ALTER TABLE [dbo].[OgretmenDersTable] CHECK CONSTRAINT [FK_OgretmenDersTable_OgretmenTable1]
GO
ALTER TABLE [dbo].[OgretmenTable]  WITH CHECK ADD  CONSTRAINT [FK_OgretmenTable_BolumTable1] FOREIGN KEY([OgretmenBolumID])
REFERENCES [dbo].[BolumTable] ([BolumID])
GO
ALTER TABLE [dbo].[OgretmenTable] CHECK CONSTRAINT [FK_OgretmenTable_BolumTable1]
GO
ALTER TABLE [dbo].[NotTable]  WITH CHECK ADD  CONSTRAINT [CK_NotTable_Butunleme] CHECK  (([Butunleme]<(101)))
GO
ALTER TABLE [dbo].[NotTable] CHECK CONSTRAINT [CK_NotTable_Butunleme]
GO
ALTER TABLE [dbo].[NotTable]  WITH CHECK ADD  CONSTRAINT [CK_NotTable_Final] CHECK  (([Final]<(101)))
GO
ALTER TABLE [dbo].[NotTable] CHECK CONSTRAINT [CK_NotTable_Final]
GO
ALTER TABLE [dbo].[NotTable]  WITH CHECK ADD  CONSTRAINT [CK_NotTable_Gecme] CHECK  (([Gecme Notu]<(101)))
GO
ALTER TABLE [dbo].[NotTable] CHECK CONSTRAINT [CK_NotTable_Gecme]
GO
ALTER TABLE [dbo].[NotTable]  WITH CHECK ADD  CONSTRAINT [CK_NotTable_Sinif] CHECK  (([Vize]<(101)))
GO
ALTER TABLE [dbo].[NotTable] CHECK CONSTRAINT [CK_NotTable_Sinif]
GO
/****** Object:  StoredProcedure [dbo].[sp_MemurEkle]    Script Date: 6/16/2023 9:41:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_MemurEkle]
@ad nvarchar(50),
@soyad nvarchar(50),
@tc char(11)
as

insert into MemurTable (MemurAd,MemurSoyad,MemurTC) values (@ad,@soyad,@tc);
return select * from MemurTable;
GO
USE [master]
GO
ALTER DATABASE [OgrenciOtomasyon] SET  READ_WRITE 
GO
