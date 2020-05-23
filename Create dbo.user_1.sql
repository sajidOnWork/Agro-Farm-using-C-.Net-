USE [farm]
GO

/****** Object: Table [dbo].[user] Script Date: 7/28/2019 10:54:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[user] (
    [Uid]      INT           NOT NULL,
    [Uname]    NVARCHAR (50) NOT NULL,
    [Phone]    NVARCHAR (50) NOT NULL,
    [Email]    NVARCHAR (50) NOT NULL,
    [Address]  NVARCHAR (50) NOT NULL,
    [Password] NVARCHAR (50) NOT NULL,
    [Position] NVARCHAR (50) NOT NULL
);

SELECT Uname,Password FROM [dbo].[user]
order by Uname
COLLATE Latin1_General_CS_AS_KS_WS ASC;


