CREATE TABLE [dbo].[VisitType] (
    [visitTypeId] INT  IDENTITY (1, 1) NOT NULL,
    [visitType]   TEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([visitTypeId] ASC)
);

