CREATE TABLE [dbo].[Surgeries] (
    [SurgeryId]   INT           IDENTITY (1, 1) NOT NULL,
    [SurgeryName] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([SurgeryId] ASC)
);

