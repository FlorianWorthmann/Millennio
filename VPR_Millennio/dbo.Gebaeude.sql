CREATE TABLE [dbo].[Gebaeude] (
    [GID]                 VARCHAR (3) NOT NULL,
    [Gebaeudename]        CHAR (30)   NOT NULL,
    [Produktion]          VARCHAR (3) NOT NULL,
    [Tier_1]              INT NOT NULL,
    [Tier_2]              INT NOT NULL,
    [Tier_3]              INT NOT NULL,
    [Produktionsrate_1]   VARCHAR (3) NOT NULL,
    [Produktionsrate_2]   VARCHAR (3) NOT NULL,
    [Produktionsrate_3]   VARCHAR (3) NOT NULL,
    [Produktionskosten_1] VARCHAR (3) NULL,
    [Produktionskosten_2] VARCHAR (3) NULL,
    [Produktionskosten_3] VARCHAR (3) NULL,
    [Feld]                VARCHAR (3) NOT NULL,
    [Kategorie]           VARCHAR (3) NOT NULL,
    PRIMARY KEY CLUSTERED ([GID] ASC),
    FOREIGN KEY ([Produktion]) REFERENCES [dbo].[Ressourcen] ([RID]),
    FOREIGN KEY ([Feld]) REFERENCES [dbo].[Felder] ([FID]),
    FOREIGN KEY ([Kategorie]) REFERENCES [dbo].[PKategorien] ([KID])
);

