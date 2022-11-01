/* DROP WEXO_GREETME DATABASE */

USE [WEXO_GreetMe]
GO

--DROP FK's

ALTER TABLE [dbo].[layouts_component_positions] DROP CONSTRAINT [FK_layouts_component_positions_component_positions_id]
GO
ALTER TABLE [dbo].[layouts_component_positions] DROP CONSTRAINT [FK_layouts_component_positions_components_id]
GO
ALTER TABLE [dbo].[views_components] DROP CONSTRAINT [views_components_view_id]
GO
ALTER TABLE [dbo].[views_components] DROP CONSTRAINT [views_components_component_id]
GO
ALTER TABLE [dbo].[component_positions] DROP CONSTRAINT [FK_component_positions_component_id]
GO
ALTER TABLE [dbo].[views] DROP CONSTRAINT [FK_views_layout_id]
GO

--DROP TABLES

DROP TABLE [dbo].[menus]
GO
DROP TABLE [dbo].[people]
GO
DROP TABLE [dbo].[component_positions]
GO
DROP TABLE [dbo].[components]
GO
DROP TABLE [dbo].[views]
GO
DROP TABLE [dbo].[layouts]
GO

/* DROP WEXO_GREET_ME DATABASE */
DROP DATABASE [WEXO_GreetMe];
GO