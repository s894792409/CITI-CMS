CREATE TABLE [dbo].[Student] (
    [studentAdmin]     VARCHAR (7)     NOT NULL,
    [studentName]      VARCHAR (MAX)   NULL,
    [projectId]        INT             NULL,
    [dateCreated]      DATETIME        NULL,
    [Photo]            VARBINARY (MAX) NULL,
    [PhotoType]        VARCHAR (50)    NULL,
    [studentBirthday]  DATETIME        NULL,
    [studentPortfolio] VARCHAR (MAX)   NULL,
    PRIMARY KEY CLUSTERED ([studentAdmin] ASC)
);

