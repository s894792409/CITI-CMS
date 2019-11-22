CREATE TABLE [dbo].[ImportInfo] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [StartDate]    DATETIME      NULL,
    [EndDate]      DATETIME      NULL,
    [Name]         VARCHAR (MAX) NULL,
    [Pax]          INT           NULL,
    [SIC]          VARCHAR (MAX) NULL,
    [Host]         VARCHAR (MAX) NULL,
    [ForeignVisit] BIT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

