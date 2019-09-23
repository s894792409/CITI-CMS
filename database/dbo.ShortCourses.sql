CREATE TABLE [dbo].[ShortCourses] (
    [courseId]         INT           IDENTITY (1, 1) NOT NULL,
    [courseName]       VARCHAR (MAX) NULL,
    [courseSubject]    VARCHAR (MAX) NULL,
    [courseInstructor] VARCHAR (MAX) NULL,
    [courseVenue]      VARCHAR (MAX) NULL,
    [dateCreated]      DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([courseId] ASC)
);

