CREATE TABLE [dbo].[Personnel] (
    [PersonnelId]          INT            IDENTITY (1, 1) NOT NULL,
    [PersonnelFullName]    NVARCHAR (80)  NOT NULL,
    [PersonnelMail]        NCHAR (80)     NOT NULL,
    [PersonnelPhoneNumber] NVARCHAR (20)  NOT NULL,
    [PersonnelPhoto]       NVARCHAR (150) NOT NULL,
    [UserId]               INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([PersonnelId] ASC)
);

