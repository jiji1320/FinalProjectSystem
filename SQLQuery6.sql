CREATE TABLE [dbo].[Users] (
    [ID]       INT Identity (1,1)           NOT NULL,
    [Username] NVARCHAR (50) NOT NULL,
    [Password] TEXT NOT NULL,
    [Roles] NVARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([ID] ASC),
    UNIQUE NONCLUSTERED ([Username] ASC)
);

