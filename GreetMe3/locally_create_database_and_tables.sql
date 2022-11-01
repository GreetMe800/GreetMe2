/* CREATE WEXO_GREETME DATABASE */

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'WEXO_GreetMe')
	BEGIN
		CREATE DATABASE [WEXO_GreetMe];
	END;
GO

/* CREATE TABELS */

USE [WEXO_GreetMe]
GO

CREATE TABLE [dbo].[layouts](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[layout_name] [nvarchar](50) NOT NULL
	)
GO

CREATE TABLE [dbo].[views](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[view_name] [nvarchar](50) NOT NULL,
	[layout_id] [int] NOT NULL,

	CONSTRAINT [FK_views_layout_id] FOREIGN KEY (layout_id) REFERENCES [layouts] (id)
	)
GO

CREATE TABLE [dbo].[components](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[component_name] [nvarchar](50) NOT NULL
)
GO

CREATE TABLE [dbo].[component_positions](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[component_name] [nvarchar](50) NOT NULL,
	[component_id] [int] NOT NULL,

	CONSTRAINT [FK_component_positions_component_id] FOREIGN KEY (component_id) REFERENCES [components] (id)
)
GO

CREATE TABLE [dbo].[component_view](
	[component_id] [int] NOT NULL,
	[view_id] [int] NOT NULL,

	CONSTRAINT [view_component_component_id] FOREIGN KEY (component_id) REFERENCES [components] (id),
	CONSTRAINT [view_component_view_id] FOREIGN KEY (view_id) REFERENCES [views] (id)
)
GO

CREATE TABLE [dbo].[layout_component_position](
	[component_id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[component_position_id] [int] NOT NULL,

	CONSTRAINT [FK_layout_component_position_components_id] FOREIGN KEY (component_id) REFERENCES [components] (id),
	CONSTRAINT [FK_layout_component_position_component_positions_id] FOREIGN KEY (component_position_id) REFERENCES [component_positions] (id)
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

CREATE TABLE [dbo].[menus](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[menu_name] [nvarchar](50) NOT NULL,
	[start_date] [date] NOT NULL,
	[end_date] [date] NULL,
	[description] [nvarchar](50) NOT NULL
)
GO