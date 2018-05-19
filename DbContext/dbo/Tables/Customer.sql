CREATE TABLE [dbo].[Customer] (
    [Id]       INT          NOT NULL,
    [PersonId] INT          NOT NULL,
    [Username] VARCHAR (10) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    [Email]    VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CustomerPerson] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([Id])
);

