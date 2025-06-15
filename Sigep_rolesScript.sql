USE [SIGEP]

Go

INSERT INTO [dbo].[AspNetRoles]
			([Id]
			,[Name])
		VALUES
			(NEWID()
			,'Administrador')
Go


INSERT INTO [dbo].[AspNetRoles]
			([Id]
			,[Name])
		VALUES
			(NEWID()
			,'Estudiante')

Go


INSERT INTO [dbo].[AspNetRoles]
			([Id]
			,[Name])
		VALUES
			(NEWID()
			,'Profesor')