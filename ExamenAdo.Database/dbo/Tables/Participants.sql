CREATE TABLE [dbo].[Participants] (
    [Id]              INT             NOT NULL,
    [Nom]             NVARCHAR (50)   NOT NULL,
    [Sexe]            NVARCHAR (10)   NOT NULL,
    [Age]             INT             NOT NULL,
    [Ville]           NVARCHAR (50)   NOT NULL,
    [DateInscription] DATETIME        NOT NULL,
    [photo]           VARBINARY (MAX) NOT NULL,
    CONSTRAINT [PK_Participants] PRIMARY KEY CLUSTERED ([Id] ASC)
);

