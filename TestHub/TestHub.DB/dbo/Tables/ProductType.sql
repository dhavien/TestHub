CREATE TABLE [dbo].[ProductType] (
    [ProductTypeID] INT            IDENTITY (1, 1) NOT NULL,
    [Description]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.ProductType] PRIMARY KEY CLUSTERED ([ProductTypeID] ASC)
);

