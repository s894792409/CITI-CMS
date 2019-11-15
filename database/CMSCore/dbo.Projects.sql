CREATE TABLE [dbo].[Projects] (
    [projectId]    INT           IDENTITY (1, 1) NOT NULL,
    [projectName]  VARCHAR (MAX) NULL,
    [projectState] VARCHAR (MAX) NULL,
    [noOfStudents] INT           NULL,
    [dateCreated]  DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([projectId] ASC)
);

