CREATE TABLE [dbo].[Student] (
    [studentAdmin] VARCHAR (7)   NOT NULL,
    [studentName]  VARCHAR (MAX) NULL,
    [projectId]    INT           NULL,
    [studentYear]  INT           NULL,
    [dateCreated]  DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([studentAdmin] ASC)
);

