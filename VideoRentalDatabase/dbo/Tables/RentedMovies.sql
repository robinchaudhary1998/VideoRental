CREATE TABLE [dbo].[RentedMovies] (
    [RentedMovieId] INT      IDENTITY (1, 1) NOT NULL,
    [MovieId]       INT      NULL,
    [CustId]        INT      NULL,
    [DateRented]    DATETIME NULL,
    [DateReturned]  DATETIME NULL,
    CONSTRAINT [PK_RentedMovies] PRIMARY KEY CLUSTERED ([RentedMovieId] ASC),
    CONSTRAINT [FK_RentedMovies_RentedMovies] FOREIGN KEY ([RentedMovieId]) REFERENCES [dbo].[RentedMovies] ([RentedMovieId])
);

