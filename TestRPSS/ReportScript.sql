USE [FullHouse]
GO
/****** Object:  StoredProcedure [dbo].[HousesBySellers]    Script Date: 11/24/2016 9:08:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HousesBySellers]
	@SellerName varchar(20) = NULL,
	@HouseCity varchar(20) = NULL,
	@HousePostCode int = NULL
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Title]
      ,[LongDescription] as Description
      ,[Price]
      ,[Size]
      ,[FullName] AS Representative
      ,ISNULL([Address1] + '' + [Address2], '') as FullAdrress
      ,[PostalCode]
      ,ISNULL([City] + ', ' + [State], '') as Location
  FROM [dbo].[Homes] as FHomes
  INNER JOIN [dbo].[Sellers] as FSellers ON FHomes.SellerId = FSellers.SellerId
  WHERE (FHomes.City = @HouseCity OR ISNULL(@HouseCity, '') = '') AND
        (FHomes.PostalCode = @HousePostCode OR ISNULL(@HousePostCode, 0) = 0) AND
		FSellers.FullName LIKE '%' + @SellerName + '%'

END

GO
/****** Object:  Table [dbo].[Homes]    Script Date: 11/24/2016 9:08:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Homes](
	[HomeId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[LongDescription] [nvarchar](200) NOT NULL,
	[Price] [bigint] NOT NULL,
	[Size] [int] NOT NULL,
	[SellerId] [int] NOT NULL,
	[Address1] [nvarchar](max) NULL,
	[Address2] [nvarchar](max) NULL,
	[PostalCode] [int] NOT NULL,
	[State] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Homes] PRIMARY KEY CLUSTERED 
(
	[HomeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sellers]    Script Date: 11/24/2016 9:08:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sellers](
	[SellerId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.Sellers] PRIMARY KEY CLUSTERED 
(
	[SellerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Homes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Home_dbo.Sellers_SellerId] FOREIGN KEY([SellerId])
REFERENCES [dbo].[Sellers] ([SellerId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Homes] CHECK CONSTRAINT [FK_dbo.Home_dbo.Sellers_SellerId]
GO
