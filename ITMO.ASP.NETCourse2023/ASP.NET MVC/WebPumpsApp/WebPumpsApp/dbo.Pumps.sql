CREATE TABLE [dbo].[Pumps] (
    [PumpId]   INT            IDENTITY (1, 1) NOT NULL,
    [Head]     NVARCHAR (MAX) NOT NULL,
    [Flow]     INT            NOT NULL,
    [Pressure] INT            NOT NULL,
    [Power]    FLOAT (53)     NOT NULL,
    [IntDiam]  INT            NOT NULL,
    [OutdDiam] INT            NOT NULL,
    [Weight]   FLOAT (53)     NOT NULL,
    CONSTRAINT [PK_Pumps] PRIMARY KEY CLUSTERED ([PumpId] ASC)
);

