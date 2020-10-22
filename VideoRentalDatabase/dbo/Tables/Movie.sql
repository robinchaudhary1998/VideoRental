CREATE TABLE [dbo].[Movie] (
    [MovieId]     INT             IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (255)  NULL,
    [ReleaseDate] DATETIME        NULL,
    [RentalCost]  DECIMAL (18, 2) NULL,
    [Genre]       NVARCHAR (255)  NULL,
    [Plot]        NVARCHAR (255)  NULL,
    CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED ([MovieId] ASC)
);

