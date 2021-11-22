CREATE TABLE [dbo].[AnimalInformation] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [AnimalId]         INT           NOT NULL,
    [AnimalName]       NVARCHAR (50) NOT NULL,
    [AnimalKind]       NVARCHAR (50) NOT NULL,
    [AnimalRace]       NVARCHAR (50) NOT NULL,
    [Neutered]         BIT           NOT NULL,
    [AnimalColor]      NVARCHAR (20) NOT NULL,
    [OwnerPhoneNumber] NVARCHAR (50) NOT NULL,
    [OwnerName]        NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

