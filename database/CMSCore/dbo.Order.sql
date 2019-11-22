CREATE TABLE [dbo].[Order] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [AddedOn]     DATETIME      DEFAULT (getdate()) NOT NULL,
    [CourseId]    INT           NOT NULL,
    [UserId]      VARCHAR (50)  NOT NULL,
    [ValidatedBy] NVARCHAR (10) NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([Id] ASC)
);

