CREATE TABLE [dbo].[Meal] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)  NOT NULL,
    [Description] NVARCHAR (100) NOT NULL,
    [Kcal]        SMALLINT       NOT NULL,
    [Protein]     SMALLINT       NOT NULL,
    [Fat]         SMALLINT       NOT NULL,
    [Hydrocarbon] SMALLINT       NOT NULL,
    CONSTRAINT [PK_Meal] PRIMARY KEY CLUSTERED ([Id] ASC)
);

