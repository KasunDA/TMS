CREATE TABLE [dbo].[Person] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [FullName] VARCHAR (50) NOT NULL,
    [PhoneNo]  VARCHAR (11) NOT NULL,
    [Gender]   TINYINT      NOT NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([Id] ASC)
);

