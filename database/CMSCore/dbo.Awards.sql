CREATE TABLE [dbo].[Awards] (
    [awardId]        INT           IDENTITY (1, 1) NOT NULL,
    [awardName]      VARCHAR (MAX) NULL,
    [awardLevel]     VARCHAR (MAX) NULL,
    [noOfRecipients] INT           NULL,
    [awardType]      VARCHAR (MAX) NULL,
    [dateCreated]    DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([awardId] ASC)
);

