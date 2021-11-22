CREATE TABLE [dbo].[VaccinationCard] (
    [VaccinationCardId] INT           IDENTITY (1, 1) NOT NULL,
    [VaccinationName]   NVARCHAR (50) NOT NULL,
    [AnimalId]          INT           NOT NULL,
    [Vaccinated]        BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([VaccinationCardId] ASC)
);

