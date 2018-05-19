CREATE TABLE [dbo].[Booking] (
    [Id]               INT NOT NULL,
    [Customer]         INT NOT NULL,
    [RouteTimeVehicle] INT NOT NULL,
    [PaymentStatus]    BIT NOT NULL,
    CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Booking_Customer] FOREIGN KEY ([Customer]) REFERENCES [dbo].[Customer] ([Id]),
    CONSTRAINT [FK_Booking_RouteTimeVehicle] FOREIGN KEY ([RouteTimeVehicle]) REFERENCES [dbo].[RouteTimeVehicle] ([Id])
);

