CREATE TABLE [dbo].[Bids] (
    [BidId]    INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NOT NULL,
    [PumpHead] NVARCHAR (MAX) NOT NULL,
    [bidDate]  DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_Bids] PRIMARY KEY CLUSTERED ([BidId] ASC)
);

