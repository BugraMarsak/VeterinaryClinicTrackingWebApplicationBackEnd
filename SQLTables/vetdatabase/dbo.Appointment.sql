CREATE TABLE [dbo].[Appointment] (
    [AppointmentId]   INT            IDENTITY (1, 1) NOT NULL,
    [AppointmentTime] DATETIME       NOT NULL,
    [UserId]          INT            NOT NULL,
    [AnimalId]        INT            NOT NULL,
    [AppointmentType] NVARCHAR (500) NOT NULL,
    PRIMARY KEY CLUSTERED ([AppointmentId] ASC)
);

