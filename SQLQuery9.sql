CREATE TABLE [dbo].[TshirtsInventory] (
    [ProductID]   INT             IDENTITY (1, 1) NOT NULL,
    [ProductName] VARCHAR (50)    NOT NULL,
    [Color]       VARCHAR (20)    NOT NULL,
    [Price]       DECIMAL (10, 2) NOT NULL,
    [Quantity]    INT             NOT NULL,
    [StyleType]   NVARCHAR (50)   NOT NULL,
    [Size]        NVARCHAR (50)   NOT NULL,
    [Status] NVARCHAR(50) NOT NULL, 
);