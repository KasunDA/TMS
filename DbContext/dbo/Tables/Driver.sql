CREATE TABLE [dbo].[Driver] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [PersonId] INT          NOT NULL,
    [Licence]  VARCHAR (20) NOT NULL,
    [Cnic]     VARCHAR (16) NOT NULL,
    [Address]  TEXT         NOT NULL,
    CONSTRAINT [PK_Driver] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [PersonRelation] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([Id]),
    CONSTRAINT [IX_Driver] UNIQUE NONCLUSTERED ([Id] ASC)
);

