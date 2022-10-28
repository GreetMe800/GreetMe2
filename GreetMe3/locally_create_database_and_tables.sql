/* CREATE WEXO_GREETME DATABASE */

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'WEXO_GreetMe')
	BEGIN
		CREATE DATABASE [WEXO_GreetMe];
	END;
GO

/* CREATE TABELS */

USE [WEXO_GreetMe]
GO

CREATE TABLE [dbo].[people](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[full_name] [nvarchar](50) NOT NULL,
	[date_of_birth] [date] NOT NULL,
	[hiring_date] [date] NOT NULL,
	[email] [nvarchar](50) UNIQUE NOT NULL
	)
GO

CREATE TABLE [dbo].[views](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[view_name] [nvarchar](50) NOT NULL
	)
GO

CREATE TABLE [dbo].[layouts](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[layout_name] [nvarchar](50) NOT NULL
	)
GO

CREATE TABLE [dbo].[components](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[component_name] [nvarchar](50) NOT NULL
)
GO

CREATE TABLE [dbo].[view_layout_components](
	[view_id] [int] NOT NULL,
	[layout_id] [int] NOT NULL,
	[component_id] [int] NOT NULL,
	[component_position] [int] NOT NULL,

	CONSTRAINT [FK_view_layout_components_view_id] FOREIGN KEY (view_id) REFERENCES [views] (id),
	CONSTRAINT [FK_view_layout_components_layout_id] FOREIGN KEY (layout_id) REFERENCES [layouts] (id),
	CONSTRAINT [FK_view_layout_components_component_id] FOREIGN KEY (component_id) REFERENCES [components] (id)
)
GO

CREATE TABLE [dbo].[menus](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[menu_name] [nvarchar](50) NOT NULL,
	[start_date] [date] NOT NULL,
	[end_date] [date] NULL,
	[description] [nvarchar](50) NOT NULL
)
GO