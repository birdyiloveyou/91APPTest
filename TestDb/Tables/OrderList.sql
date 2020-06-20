CREATE TABLE [dbo].[OrderList]
(
	[orderId] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [orderItem] NVARCHAR(50) NOT NULL, 
    [price] INT NOT NULL, 
    [cost] INT NOT NULL, 
    [status] INT NOT NULL DEFAULT 1
)
