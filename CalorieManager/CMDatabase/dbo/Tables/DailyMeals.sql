CREATE TABLE [dbo].[DailyMeals] (
    [Id]   SMALLINT NOT NULL,
    [Meal] INT      IDENTITY (1, 1) NOT NULL,
    [Date] DATE     NOT NULL,
    CONSTRAINT [PK_DailyMeals] PRIMARY KEY CLUSTERED ([Id] ASC)
);

