CREATE TABLE [dbo].[SurgDones] (
    [SurgDoneId] INT            IDENTITY (1, 1) NOT NULL,
    [SurgTime]   DATETIME       NOT NULL,
    [SurgName]   NVARCHAR (100) NOT NULL,
    [DocName]    NVARCHAR (200) NOT NULL,
    [AnimalId]   INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([SurgDoneId] ASC)
);

