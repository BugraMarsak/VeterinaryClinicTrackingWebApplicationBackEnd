CREATE TABLE [dbo].[AnimalRace] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [AnimalKind] INT            NOT NULL,
    [RaceName]   NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

