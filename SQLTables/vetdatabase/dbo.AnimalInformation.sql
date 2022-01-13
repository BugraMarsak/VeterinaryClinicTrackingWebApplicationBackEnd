CREATE TABLE [dbo].[AnimalInformation] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [AnimalId]         INT            NOT NULL,
    [AnimalName]       NVARCHAR (50)  NOT NULL,
    [AnimalKind]       NVARCHAR (50)  NOT NULL,
    [AnimalRace]       NVARCHAR (50)  NOT NULL,
    [Neutered]         BIT            NOT NULL,
    [AnimalColor]      NVARCHAR (20)  NOT NULL,
    [OwnerPhoneNumber] NVARCHAR (50)  NOT NULL,
    [OwnerName]        NVARCHAR (50)  NOT NULL,
    [UserId]           INT            NOT NULL,
    [AnimalPhoto]      NVARCHAR (500) NOT NULL,
    [Gender]           NVARCHAR (100) NOT NULL,
    [BirthDay]         DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

