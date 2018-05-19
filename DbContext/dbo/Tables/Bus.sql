CREATE TABLE [dbo].[Bus] (
    [Conductor]      INT NOT NULL,
    [isAirCondition] BIT NOT NULL,
    CONSTRAINT [BusVehicle] FOREIGN KEY ([Conductor]) REFERENCES [dbo].[Conductor] ([Id])
);

