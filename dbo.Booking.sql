CREATE TABLE [dbo].[Booking] (
    [booking_Id]   INT             NOT NULL,
    [flight_Price] DECIMAL (10, 2) NOT NULL,
    [user_Id]      INT             NOT NULL,
    [flight_Id]    INT             NOT NULL,
    CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED ([booking_Id] ASC),
    CONSTRAINT [FK_Booking_Flight] FOREIGN KEY ([flight_Id]) REFERENCES [dbo].[Flight] ([flight_Id]),
    CONSTRAINT [FK_Booking_User] FOREIGN KEY ([user_Id]) REFERENCES [dbo].[User] ([user_Id])
);

