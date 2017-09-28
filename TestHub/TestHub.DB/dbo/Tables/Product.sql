CREATE TABLE [dbo].[Product] (
    [ProductID]     INT             IDENTITY (1, 1) NOT NULL,
    [ProductName]   NVARCHAR (MAX)  NULL,
    [UPC]           NVARCHAR (MAX)  NULL,
    [Description]   NVARCHAR (MAX)  NULL,
    [Price]         DECIMAL (18, 2) NOT NULL,
    [ProductTypeID] INT             NULL,
    CONSTRAINT [PK_dbo.Product] PRIMARY KEY CLUSTERED ([ProductID] ASC),
    CONSTRAINT [FK_dbo.Product_dbo.ProductType_ProductTypeID] FOREIGN KEY ([ProductTypeID]) REFERENCES [dbo].[ProductType] ([ProductTypeID])
);


GO
CREATE NONCLUSTERED INDEX [IX_ProductTypeID]
    ON [dbo].[Product]([ProductTypeID] ASC);

