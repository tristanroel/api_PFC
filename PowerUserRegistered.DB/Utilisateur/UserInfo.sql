CREATE TABLE [dbo].[UserInfo]
(
	[Id] INT NOT NULL IDENTITY, --identity permet l'incrementation automatique de l'Id
	[Pseudo] NVARCHAR(50) NOT NULL,
	[Email] NVARCHAR(255) NOT NULL,
	[PassWord] NVARCHAR(255) NOT NULL,
    CONSTRAINT PK_User PRIMARY KEY([Id]),

)
