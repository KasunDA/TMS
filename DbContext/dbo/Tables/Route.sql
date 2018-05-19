CREATE TABLE [dbo].[Route] (
    [Id]   INT NOT NULL,
    [From] INT NOT NULL,
    [To]   INT NOT NULL,
    CONSTRAINT [PK_Route] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Route_Station] FOREIGN KEY ([From]) REFERENCES [dbo].[Station] ([Id]),
    CONSTRAINT [FK_Route_Station1] FOREIGN KEY ([To]) REFERENCES [dbo].[Station] ([Id])
);

