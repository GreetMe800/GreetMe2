/* DROP TABLES */

USE [WEXO_GreetMe]
GO

--DROP FK's

	--DROP SCREENS
ALTER TABLE [dbo].[screens] DROP CONSTRAINT [FK_screens_views_id]
GO

--DROP TABLES
DROP TABLE [dbo].[people]
GO
DROP TABLE [dbo].[screens]
GO
DROP TABLE [dbo].[views]
GO

/* DROP WEXO_GREET_ME DATABASE */
DROP DATABASE [WEXO_GreetMe];
GO