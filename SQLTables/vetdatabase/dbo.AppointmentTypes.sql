CREATE TABLE [dbo].[AppointmentTypes] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [TypeName] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

