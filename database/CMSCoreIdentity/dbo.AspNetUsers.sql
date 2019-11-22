CREATE TABLE [dbo].[AspNetUsers] (
    [Id]                   NVARCHAR (450)     NOT NULL,
    [AccessFailedCount]    INT                NULL,
    [Age]                  INT                NULL,
    [ConcurrencyStamp]     NVARCHAR (MAX)     NULL,
    [Country]              INT                NULL,
    [Email]                NVARCHAR (256)     NULL,
    [EmailConfirmed]       BIT                NULL,
    [LockoutEnabled]       BIT                NULL,
    [LockoutEnd]           DATETIMEOFFSET (7) NULL,
    [NormalizedEmail]      NVARCHAR (256)     NULL,
    [NormalizedUserName]   NVARCHAR (256)     NULL,
    [PasswordHash]         NVARCHAR (MAX)     NULL,
    [PhoneNumber]          NVARCHAR (MAX)     NULL,
    [PhoneNumberConfirmed] BIT                NULL,
    [SecurityStamp]        NVARCHAR (MAX)     NULL,
    [TwoFactorEnabled]     BIT                NULL,
    [UserName]             NVARCHAR (256)     NULL,
    [Admin]                BIT                CONSTRAINT [DF_AspNetUsers_Admin] DEFAULT ((0)) NULL,
    [UserKey]              VARCHAR (MAX)      NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [EmailIndex]
    ON [dbo].[AspNetUsers]([NormalizedEmail] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex]
    ON [dbo].[AspNetUsers]([NormalizedUserName] ASC) WHERE ([NormalizedUserName] IS NOT NULL);

