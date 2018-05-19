CREATE TABLE [dbo].[RouteTimeVehicle] (
    [Id]            INT      NOT NULL,
    [Route]         INT      NOT NULL,
    [Vehicle]       INT      NOT NULL,
    [DepartureTime] DATETIME NOT NULL,
    [ArrivalTime]   DATETIME NOT NULL,
    CONSTRAINT [PK_RouteTimeVehicle_1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_RouteTimeVehicle_Route] FOREIGN KEY ([Route]) REFERENCES [dbo].[Route] ([Id]),
    CONSTRAINT [FK_RouteTimeVehicle_Vehicle] FOREIGN KEY ([Vehicle]) REFERENCES [dbo].[Vehicle] ([Id])
);

