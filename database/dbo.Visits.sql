CREATE TABLE [dbo].[Visits] (
    [visitId ]      INT      IDENTITY (1, 1) NOT NULL,
    [companyName]   TEXT     NULL,
    [companyTypeId] INT      NULL,
    [noOfPax]       INT      NULL,
    [visitDate]     DATETIME NULL,
    [visitTypeId]   INT      NULL,
    [dateCreated]   DATETIME NULL,
    PRIMARY KEY CLUSTERED ([visitId ] ASC)
);

