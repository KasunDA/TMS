CREATE TABLE [dbo].[Conductor] (
    [Id]       INT NOT NULL,
    [PersonId] INT NOT NULL,
    CONSTRAINT [PK_Conductor] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [ConductorPerson] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([Id])
);

