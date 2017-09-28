CREATE TABLE [dbo].[User] (
    [UserID]             INT                IDENTITY (1, 1) NOT NULL,
    [FirstName]          NVARCHAR (MAX)     NULL,
    [LastName]           NVARCHAR (MAX)     NULL,
    [Username]           NVARCHAR (MAX)     NULL,
    [Email]              NVARCHAR (100)     NOT NULL,
    [PasswordHash]       NVARCHAR (MAX)     NULL,
    [PasswordSalt]       NVARCHAR (MAX)     NULL,
    [PhoneNumber]        NVARCHAR (MAX)     NULL,
    [City]               NVARCHAR (MAX)     NULL,
    [TempPassword]       NVARCHAR (MAX)     NULL,
    [ExpirationDate]     DATETIMEOFFSET (7) NOT NULL,
    [TempExpirationDate] DATETIMEOFFSET (7) NOT NULL,
    [LastUpdated]        DATETIMEOFFSET (7) NOT NULL,
    [LastLogin]          DATETIMEOFFSET (7) NOT NULL,
    CONSTRAINT [PK_dbo.User] PRIMARY KEY CLUSTERED ([UserID] ASC)
);


GO
CREATE NONCLUSTERED INDEX [EmailIndex]
    ON [dbo].[User]([Email] ASC);

