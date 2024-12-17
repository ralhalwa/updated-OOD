CREATE TABLE [dbo].[Destination] (
    [destination_Id]      INT          IDENTITY (1, 1) NOT NULL,
    [destination_Name]    VARCHAR (50) NOT NULL,
    [destination_Country] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Destination] PRIMARY KEY CLUSTERED ([destination_Id] ASC)
);

