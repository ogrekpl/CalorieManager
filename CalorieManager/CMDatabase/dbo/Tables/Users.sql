CREATE TABLE [dbo].[Users] (
    [Id]            INT       IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (30)  NOT NULL,
    [Age]           INT       NOT NULL,
    [Height]        DECIMAL (3, 1) NOT NULL,
    [KcalGoal]      INT       NOT NULL,
    [WeightGoal]    DECIMAL (3, 1) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

