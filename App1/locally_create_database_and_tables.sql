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
	[has_current_datetime] [bit] NOT NULL,
	[has_birthday] [bit] NOT NULL,
	[has_anniversary] [bit] NOT NULL,
	[has_menu] [bit] NOT NULL
	)
GO

CREATE TABLE [dbo].[screens](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[screen_name] [nvarchar](50) NOT NULL,
	[view_id] [int] NULL,
	CONSTRAINT [FK_screens_views_id] FOREIGN KEY (view_id) REFERENCES [views] (id)
	)
GO

CREATE TABLE [dbo].[people](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[full_name] [nvarchar](50) NOT NULL,
	[date_of_birth] [date] NOT NULL,
	[hiring_date] [date] NOT NULL,
	[email] [nvarchar](50) UNIQUE NOT NULL
	)
GO