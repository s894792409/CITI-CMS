CREATE TABLE [dbo].[CompanyType] (
    [companyTypeId] INT  IDENTITY (1, 1) NOT NULL,
    [companyType]   TEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([companyTypeId] ASC)
);

