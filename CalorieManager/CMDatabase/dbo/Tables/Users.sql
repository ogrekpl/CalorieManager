CREATE TABLE [dbo].[Users] (
    [Id]            SMALLINT       IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (30)  NOT NULL,
    [Age]           SMALLINT       NOT NULL,
    [WeightHistory] DECIMAL (3, 3) NOT NULL,
    [Height]        DECIMAL (3, 1) NOT NULL,
    [KcalGoal]      SMALLINT       NOT NULL,
    [WeightGoal]    DECIMAL (3, 1) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

