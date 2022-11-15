/* CREATE WEXO_GREETME DATABASE */

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'WEXO_GreetMe')
	BEGIN
		CREATE DATABASE [WEXO_GreetMe];
	END;
GO

/* CREATE TABELS */

USE [WEXO_GreetMe]
GO

CREATE TABLE [dbo].[views](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[view_name] [nvarchar](50) NOT NULL,
	[has_birthday] [bit] NOT NULL,
	[has_anniversary] [bit] NOT NULL
	)
GO

CREATE TABLE [dbo].[people](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[full_name] [nvarchar](50) NOT NULL,
	[date_of_birth] [date] NOT NULL,
	[hiring_date] [date] NOT NULL,
	[email] [nvarchar](50) UNIQUE NOT NULL,
	)
GO

CREATE TABLE [dbo].[menus](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[menu_name] [nvarchar](50) NOT NULL,
	[start_date] [date] NOT NULL,
	[end_date] [date] NULL,
	[description] [nvarchar](1000) NOT NULL
)
GO