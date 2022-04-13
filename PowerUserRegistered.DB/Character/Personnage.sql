CREATE TABLE [dbo].[Personnage]
(
	[Id] INT NOT NULL IDENTITY,
	[FirstName] NVARCHAR (50) NOT NULL,--nvarchar prend en charge les caractere speciaux
	[LastName] NVARCHAR (50) NOT NULL,
	[BirthDate] DATE NOT NULL,
	[Pv] INT Default 0,
	[Level] INT Default 0,
	[Xp] INT Default 0,

	[Attack1] INT Default 0,
	[Attack2] INT Default 1,
	[Attack3] INT Default 2,
	[Attack4] INT Default 3,
	
	[Face] VARCHAR (50) Default 'perso1.png',
	[BackSprite] VARCHAR (50) Default 'rightbody.gif',
	[FrontSprite] VARCHAR (50) Default 'leftbody.gif',
	[BackAttackSprite] VARCHAR (50) Default 'Attack-back.gif',
	[FrontAttackSprite] VARCHAR (50) Default 'Attack-front.gif',
	[BackKnockBackSprite] VARCHAR (50) Default 'backKnockback.gif',
	[FrontKnockBackSprite] VARCHAR (50) Default 'frontKnockback.gif',

    CONSTRAINT PK_Personnage PRIMARY KEY([Id]),
    




)
