USE [KayyuTatilEviOtomasyon]
GO
/****** Object:  Table [dbo].[Adisyon]    Script Date: 12.04.2022 17:48:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adisyon](
	[adisyonID] [int] NOT NULL,
	[urunID] [int] NULL,
	[birimFiyat] [money] NULL,
	[alisTarihi] [datetime] NULL,
	[adet] [int] NULL,
	[rezervasyonID] [int] NULL,
 CONSTRAINT [PK_OdaAdisyon] PRIMARY KEY CLUSTERED 
(
	[adisyonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ev]    Script Date: 12.04.2022 17:48:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ev](
	[evID] [int] NOT NULL,
	[no] [int] NULL,
	[katNo] [int] NULL,
	[tekyatakSayi] [int] NULL,
	[ciftYatakSayi] [int] NULL,
	[fiyati] [money] NULL,
	[durum] [nchar](20) NULL,
 CONSTRAINT [PK_Ev] PRIMARY KEY CLUSTERED 
(
	[evID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 12.04.2022 17:48:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[kullaniciID] [int] NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[telefon] [char](10) NULL,
	[email] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
	[adres] [nvarchar](50) NULL,
	[dtarih] [datetime] NULL,
	[unvanAdi] [nvarchar](50) NULL,
	[tcNo] [char](11) NULL,
 CONSTRAINT [PK_Kullanicii] PRIMARY KEY CLUSTERED 
(
	[kullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 12.04.2022 17:48:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[musteriID] [int] NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[telefon] [char](10) NULL,
	[adres] [nvarchar](50) NULL,
	[kayitTarihi] [datetime] NULL,
	[kullaniciID] [int] NULL,
	[tcNo] [char](11) NULL,
 CONSTRAINT [PK_Musteri] PRIMARY KEY CLUSTERED 
(
	[musteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervasyon]    Script Date: 12.04.2022 17:48:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervasyon](
	[rezervasyonID] [int] NOT NULL,
	[baslangıcTarihi] [datetime] NULL,
	[bitisTarihi] [datetime] NULL,
	[musteriID] [int] NULL,
	[odemeTuru] [nvarchar](50) NULL,
	[tutar] [money] NULL,
	[aciklama] [nvarchar](50) NULL,
	[evID] [int] NULL,
 CONSTRAINT [PK_Rezervasyon] PRIMARY KEY CLUSTERED 
(
	[rezervasyonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stok]    Script Date: 12.04.2022 17:48:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stok](
	[stokID] [int] NOT NULL,
	[adet] [char](10) NULL,
	[alisFiyati] [money] NULL,
	[kullaniciID] [int] NULL,
	[alisTarihi] [datetime] NULL,
	[urunID] [int] NULL,
 CONSTRAINT [PK_Stok] PRIMARY KEY CLUSTERED 
(
	[stokID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urun]    Script Date: 12.04.2022 17:48:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urun](
	[urunID] [int] NOT NULL,
	[adi] [nvarchar](50) NULL,
	[fiyati] [money] NULL,
	[aciklama] [nvarchar](50) NULL,
 CONSTRAINT [PK_Urun] PRIMARY KEY CLUSTERED 
(
	[urunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Adisyon]  WITH CHECK ADD  CONSTRAINT [FK_OdaAdisyon_Rezervasyon] FOREIGN KEY([rezervasyonID])
REFERENCES [dbo].[Rezervasyon] ([rezervasyonID])
GO
ALTER TABLE [dbo].[Adisyon] CHECK CONSTRAINT [FK_OdaAdisyon_Rezervasyon]
GO
ALTER TABLE [dbo].[Adisyon]  WITH CHECK ADD  CONSTRAINT [FK_OdaAdisyon_Urun] FOREIGN KEY([urunID])
REFERENCES [dbo].[Urun] ([urunID])
GO
ALTER TABLE [dbo].[Adisyon] CHECK CONSTRAINT [FK_OdaAdisyon_Urun]
GO
ALTER TABLE [dbo].[Musteri]  WITH CHECK ADD  CONSTRAINT [FK_Musteri_Kullanicii] FOREIGN KEY([kullaniciID])
REFERENCES [dbo].[Kullanici] ([kullaniciID])
GO
ALTER TABLE [dbo].[Musteri] CHECK CONSTRAINT [FK_Musteri_Kullanicii]
GO
ALTER TABLE [dbo].[Rezervasyon]  WITH CHECK ADD  CONSTRAINT [FK_Rezervasyon_Ev] FOREIGN KEY([evID])
REFERENCES [dbo].[Ev] ([evID])
GO
ALTER TABLE [dbo].[Rezervasyon] CHECK CONSTRAINT [FK_Rezervasyon_Ev]
GO
ALTER TABLE [dbo].[Rezervasyon]  WITH CHECK ADD  CONSTRAINT [FK_Rezervasyon_Musteri] FOREIGN KEY([musteriID])
REFERENCES [dbo].[Musteri] ([musteriID])
GO
ALTER TABLE [dbo].[Rezervasyon] CHECK CONSTRAINT [FK_Rezervasyon_Musteri]
GO
ALTER TABLE [dbo].[Stok]  WITH CHECK ADD  CONSTRAINT [FK_Stok_Kullanicii] FOREIGN KEY([kullaniciID])
REFERENCES [dbo].[Kullanici] ([kullaniciID])
GO
ALTER TABLE [dbo].[Stok] CHECK CONSTRAINT [FK_Stok_Kullanicii]
GO
ALTER TABLE [dbo].[Stok]  WITH CHECK ADD  CONSTRAINT [FK_Stok_Urun] FOREIGN KEY([urunID])
REFERENCES [dbo].[Urun] ([urunID])
GO
ALTER TABLE [dbo].[Stok] CHECK CONSTRAINT [FK_Stok_Urun]
GO
