CREATE TABLE [dbo].[Visits] (
    [VisitId]      INT           IDENTITY (1, 1) NOT NULL,
    [StartDate]    DATETIME      NULL,
    [EndDate]      DATETIME      NULL,
    [Name]         VARCHAR (MAX) NULL,
    [Pax]          INT           NULL,
    [SIC]          VARCHAR (MAX) NULL,
    [Host]         VARCHAR (MAX) NULL,
    [ForeignVisit] BIT           NULL,
    [dateCreated]  DATETIME      NULL,
    [No]           INT           NULL,
    PRIMARY KEY CLUSTERED ([VisitId] ASC)
);

