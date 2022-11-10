/* DROP WEXO_GREETME DATABASE */

USE [WEXO_GreetMe]
GO

--DROP FK's

ALTER TABLE [dbo].[layout_component_position] DROP CONSTRAINT [FK_layout_component_position_component_position_id]
GO
ALTER TABLE [dbo].[layout_component_position] DROP CONSTRAINT [FK_layout_component_position_layout_id]
GO
ALTER TABLE [dbo].[layout_component_position] DROP CONSTRAINT [PK_layout_component_position]
GO
ALTER TABLE [dbo].[component_view] DROP CONSTRAINT [PK_component_view]
GO
ALTER TABLE [dbo].[component_positions] DROP CONSTRAINT [FK_component_position_component_id]
GO
ALTER TABLE [dbo].[components] DROP CONSTRAINT [FK_view_layout_id]
GO

--DROP TABLES

DROP TABLE [dbo].[menus]
GO
DROP TABLE [dbo].[people]
GO
DROP TABLE [dbo].[layout_component_position]
GO
DROP TABLE [dbo].[component_positions]
GO
DROP TABLE [dbo].[components]
GO
DROP TABLE [dbo].[layouts]
GO
DROP TABLE [dbo].[views]
GO

/* DROP WEXO_GREET_ME DATABASE */
DROP DATABASE [WEXO_GreetMe];
GO