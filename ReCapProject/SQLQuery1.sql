USE [Recap]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 2/15/2021 3:29:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](20) NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 2/15/2021 3:29:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[Id] [int] NOT NULL,
	[Brand_Id] [int] NULL,
	[Color_Id] [int] NULL,
	[Model_Year] [int] NULL,
	[Daily_Price] [decimal](18, 0) NULL,
	[Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 2/15/2021 3:29:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](20) NULL,
 CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Brands] ([ID], [Name]) VALUES (10, N'Volvo')
INSERT [dbo].[Brands] ([ID], [Name]) VALUES (20, N'Opel')
INSERT [dbo].[Brands] ([ID], [Name]) VALUES (30, N'BMW')
INSERT [dbo].[Brands] ([ID], [Name]) VALUES (40, N'Mercedes')
INSERT [dbo].[Brands] ([ID], [Name]) VALUES (50, N'Audi')
GO
INSERT [dbo].[Cars] ([Id], [Brand_Id], [Color_Id], [Model_Year], [Daily_Price], [Description]) VALUES (1, 10, 100, 2020, CAST(500 AS Decimal(18, 0)), N'Volvo')
INSERT [dbo].[Cars] ([Id], [Brand_Id], [Color_Id], [Model_Year], [Daily_Price], [Description]) VALUES (2, 20, 200, 2001, CAST(150 AS Decimal(18, 0)), N'Opel')
INSERT [dbo].[Cars] ([Id], [Brand_Id], [Color_Id], [Model_Year], [Daily_Price], [Description]) VALUES (3, 30, 400, 2010, CAST(200 AS Decimal(18, 0)), N'Mercedes')
INSERT [dbo].[Cars] ([Id], [Brand_Id], [Color_Id], [Model_Year], [Daily_Price], [Description]) VALUES (4, 20, 400, 2015, CAST(250 AS Decimal(18, 0)), N'BMW')
INSERT [dbo].[Cars] ([Id], [Brand_Id], [Color_Id], [Model_Year], [Daily_Price], [Description]) VALUES (5, 50, 200, 2018, CAST(300 AS Decimal(18, 0)), N'Audi')
GO
INSERT [dbo].[Colors] ([ID], [Name]) VALUES (100, N'White')
INSERT [dbo].[Colors] ([ID], [Name]) VALUES (200, N'Black')
INSERT [dbo].[Colors] ([ID], [Name]) VALUES (300, N'Red')
INSERT [dbo].[Colors] ([ID], [Name]) VALUES (400, N'Blue')
INSERT [dbo].[Colors] ([ID], [Name]) VALUES (500, N'Orange')
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Brands] FOREIGN KEY([Brand_Id])
REFERENCES [dbo].[Brands] ([ID])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Brands]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Colors] FOREIGN KEY([Color_Id])
REFERENCES [dbo].[Colors] ([ID])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Colors]
GO
ALTER TABLE [dbo].[Colors]  WITH CHECK ADD  CONSTRAINT [FK_Colors_Colors] FOREIGN KEY([ID])
REFERENCES [dbo].[Colors] ([ID])
GO
ALTER TABLE [dbo].[Colors] CHECK CONSTRAINT [FK_Colors_Colors]
GO