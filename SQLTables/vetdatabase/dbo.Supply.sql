CREATE TABLE [dbo].[Supply] (
    [SupplyId]      INT            IDENTITY (1, 1) NOT NULL,
    [ProductName]   NVARCHAR (100) NOT NULL,
    [UnitInStock]   INT            NOT NULL,
    [PurchaseDate]  DATETIME       NOT NULL,
    [PurchasePrice] FLOAT (53)     NOT NULL,
    PRIMARY KEY CLUSTERED ([SupplyId] ASC)
);

