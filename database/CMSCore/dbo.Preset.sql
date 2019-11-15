CREATE TABLE [dbo].[Preset] (
    [presetId]    INT      IDENTITY (1, 1) NOT NULL,
    [dateCreated] DATETIME NULL,
    [themeId]     INT      NULL,
    [visitId]     INT      NULL,
    PRIMARY KEY CLUSTERED ([presetId] ASC)
);

