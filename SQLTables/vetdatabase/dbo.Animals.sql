CREATE TABLE [dbo].[Animals] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [AnimalKindName] NVARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

