CREATE TABLE [dbo].[WeightHistory] (
    [Id]     SMALLINT       IDENTITY (1, 1) NOT NULL,
    [Weight] DECIMAL (3, 3) NOT NULL,
    [Date]   DATE           NOT NULL,
    [UserId] INT NOT NULL, 
    CONSTRAINT [PK_WeightHistory] PRIMARY KEY CLUSTERED ([Id])
);

