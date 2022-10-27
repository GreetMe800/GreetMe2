/* DROP WEXO_GREETME DATABASE */

USE [WEXO_GreetMe]
GO

--DROP FK's

ALTER TABLE [dbo].[view_layout_components] DROP CONSTRAINT [FK_view_layout_components_view_id]
GO
ALTER TABLE [dbo].[view_layout_components] DROP CONSTRAINT [FK_view_layout_components_layout_id]
GO
ALTER TABLE [dbo].[view_layout_components] DROP CONSTRAINT [FK_view_layout_components_component_id]
GO

--DROP TABLES
DROP TABLE [dbo].[menus]
GO
DROP TABLE [dbo].[view_layout_components]
GO
DROP TABLE [dbo].[components]
GO
DROP TABLE [dbo].[layouts]
GO
DROP TABLE [dbo].[views]
GO
DROP TABLE [dbo].[people]
GO

/* DROP WEXO_GREET_ME DATABASE */
DROP DATABASE [WEXO_GreetMe];
GO