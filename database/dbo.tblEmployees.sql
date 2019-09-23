CREATE TABLE [dbo].[tblEmployees] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Name]   NVARCHAR (50) NULL,
    [Gender] NVARCHAR (10) NULL,
    [Salary] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

