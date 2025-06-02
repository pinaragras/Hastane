USE [MarmaraDB]
GO

/****** Object:  Table [dbo].[Brans] ******/
CREATE TABLE [dbo].[Brans](
	[BransId] [int] IDENTITY(1,1) NOT NULL,
	[BransAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Brans] PRIMARY KEY CLUSTERED 
(
	[BransId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Doktor] ******/
CREATE TABLE [dbo].[Doktor](
	[D_KimlikId] [bigint] NOT NULL,
	[Unvan] [nvarchar](50) NULL,
	[D_Ad] [nvarchar](50) NULL,
	[D_Soyad] [nvarchar](50) NULL,
	[D_Cinsiyet] [nvarchar](50) NULL,
	[BransId] [int] NOT NULL,
	[Sifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Doktor] PRIMARY KEY CLUSTERED 
(
	[D_KimlikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[Doktor]  WITH CHECK ADD  CONSTRAINT [FK_Doktor_Brans] FOREIGN KEY([BransId])
REFERENCES [dbo].[Brans] ([BransId])

ALTER TABLE [dbo].[Doktor] CHECK CONSTRAINT [FK_Doktor_Brans]

/****** Object:  Table [dbo].[Hasta] ******/
CREATE TABLE [dbo].[Hasta](
	[H_KimlikId] [bigint] NOT NULL,
	[H_Ad] [nvarchar](50) NULL,
	[H_Soyad] [nvarchar](50) NULL,
	[H_Cinsiyet] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Hasta] PRIMARY KEY CLUSTERED 
(
	[H_KimlikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[DoktorHasta] ******/
CREATE TABLE [dbo].[DoktorHasta](
	[D_KimlikId] [bigint] NOT NULL,
	[H_KimlikId] [bigint] NOT NULL,
 CONSTRAINT [PK_DoktorHasta] PRIMARY KEY CLUSTERED 
(
	[D_KimlikId] ASC,
	[H_KimlikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[DoktorHasta]  WITH CHECK ADD  CONSTRAINT [FK_DoktorHasta_Doktor] FOREIGN KEY([D_KimlikId])
REFERENCES [dbo].[Doktor] ([D_KimlikId])

ALTER TABLE [dbo].[DoktorHasta] CHECK CONSTRAINT [FK_DoktorHasta_Doktor]

ALTER TABLE [dbo].[DoktorHasta]  WITH CHECK ADD  CONSTRAINT [FK_DoktorHasta_Hasta] FOREIGN KEY([H_KimlikId])
REFERENCES [dbo].[Hasta] ([H_KimlikId])

ALTER TABLE [dbo].[DoktorHasta] CHECK CONSTRAINT [FK_DoktorHasta_Hasta]

/****** Object:  Table [dbo].[Randevu] ******/
CREATE TABLE [dbo].[Randevu](
	[RandevuId] [int] IDENTITY(1,1) NOT NULL,
	[Tarih] [date] NULL,
	[Saat] [time](7) NULL,
	[D_KimlikId] [bigint] NULL,
	[H_KimlikId] [bigint] NULL,
	[Sikayet] [nvarchar](max) NULL,
	[Durum] [bit] NOT NULL,
 CONSTRAINT [PK_Randevu] PRIMARY KEY CLUSTERED 
(
	[RandevuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

ALTER TABLE [dbo].[Randevu] ADD  CONSTRAINT [DF_Randevu_isActive]  DEFAULT ((1)) FOR [Durum]

ALTER TABLE [dbo].[Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Randevu_Doktor] FOREIGN KEY([D_KimlikId])
REFERENCES [dbo].[Doktor] ([D_KimlikId])

ALTER TABLE [dbo].[Randevu] CHECK CONSTRAINT [FK_Randevu_Doktor]
GO

ALTER TABLE [dbo].[Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Randevu_Hasta] FOREIGN KEY([H_KimlikId])
REFERENCES [dbo].[Hasta] ([H_KimlikId])

ALTER TABLE [dbo].[Randevu] CHECK CONSTRAINT [FK_Randevu_Hasta]

/****** Object:  Table [dbo].[Sekreter] ******/
CREATE TABLE [dbo].[Sekreter](
	[S_KimlikId] [bigint] NOT NULL,
	[S_Ad] [nvarchar](50) NULL,
	[S_Soyad] [nvarchar](50) NULL,
	[S_Cinsiyet] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Sekreter] PRIMARY KEY CLUSTERED 
(
	[S_KimlikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[SekreterRandevu] ******/
CREATE TABLE [dbo].[SekreterRandevu](
	[S_KimlikId] [bigint] NOT NULL,
	[RandevuId] [int] NOT NULL,
 CONSTRAINT [PK_SekreterRandevu] PRIMARY KEY CLUSTERED 
(
	[S_KimlikId] ASC,
	[RandevuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[SekreterRandevu]  WITH CHECK ADD  CONSTRAINT [FK_SekreterRandevu_Randevu] FOREIGN KEY([RandevuId])
REFERENCES [dbo].[Randevu] ([RandevuId])

ALTER TABLE [dbo].[SekreterRandevu] CHECK CONSTRAINT [FK_SekreterRandevu_Randevu]

ALTER TABLE [dbo].[SekreterRandevu]  WITH CHECK ADD  CONSTRAINT [FK_SekreterRandevu_Sekreter] FOREIGN KEY([S_KimlikId])
REFERENCES [dbo].[Sekreter] ([S_KimlikId])

ALTER TABLE [dbo].[SekreterRandevu] CHECK CONSTRAINT [FK_SekreterRandevu_Sekreter]