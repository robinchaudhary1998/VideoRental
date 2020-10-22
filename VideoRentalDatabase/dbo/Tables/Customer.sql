CREATE TABLE [dbo].[Customer] (
    [CustId]    INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (255) NULL,
    [LastName]  NVARCHAR (255) NULL,
    [Address]   NVARCHAR (255) NULL,
    [Phone]     NVARCHAR (50)  NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustId] ASC)
);

