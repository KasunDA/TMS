CREATE TABLE [dbo].[Station] (
    [Id]      INT          NOT NULL,
    [Name]    VARCHAR (10) NOT NULL,
    [Address] TEXT         NOT NULL,
    CONSTRAINT [PK_Station] PRIMARY KEY CLUSTERED ([Id] ASC)
);

