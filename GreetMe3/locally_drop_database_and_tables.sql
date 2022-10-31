/* DROP WEXO_GREETME DATABASE */

USE [WEXO_GreetMe]
GO

--DROP FK's

ALTER TABLE [dbo].[layouts] DROP CONSTRAINT [FK_component_component_positions_component_positions_id]
GO
ALTER TABLE [dbo].[component_positions] DROP CONSTRAINT [FK_component_component_positions_components_id]
GO
ALTER TABLE [dbo].[component_views] DROP CONSTRAINT [FK_component_views_views_id]
GO
ALTER TABLE [dbo].[component_views] DROP CONSTRAINT [FK_component_views_components_id]
GO
ALTER TABLE [dbo].[component_component_positions] DROP CONSTRAINT [FK_component_position_components_id]
GO
ALTER TABLE [dbo].[component_component_positions] DROP CONSTRAINT [FK_view_layout_id]
GO

--DROP TABLES
DROP TABLE [dbo].[views]
GO
DROP TABLE [dbo].[layouts]
GO
DROP TABLE [dbo].[components]
GO
DROP TABLE [dbo].[component_positions]
GO
DROP TABLE [dbo].[people]
GO
DROP TABLE [dbo].[menus]
GO

/* DROP WEXO_GREET_ME DATABASE */
DROP DATABASE [WEXO_GreetMe];
GO