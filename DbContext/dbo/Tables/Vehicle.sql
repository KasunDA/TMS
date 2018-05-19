CREATE TABLE [dbo].[Vehicle] (
    [Id]     INT         NOT NULL,
    [Number] VARCHAR (8) NOT NULL,
    [Driver] INT         NOT NULL,
    [Seats]  INT         NOT NULL,
    CONSTRAINT [VehicleDriver] FOREIGN KEY ([Driver]) REFERENCES [dbo].[Driver] ([Id]),
    CONSTRAINT [IX_Vehicle] UNIQUE NONCLUSTERED ([Id] ASC)
);

