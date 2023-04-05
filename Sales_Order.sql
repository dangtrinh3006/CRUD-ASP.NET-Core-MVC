USE [master]
GO
CREATE DATABASE [SalesOrderDB]
GO
USE [SalesOrderDB]
GO
CREATE TABLE [dbo].[SalesOrderTable](
	[SalesOrder] [nvarchar](50) NULL,
	[SalesOrderItem] [nvarchar](50) NULL,
	[WorkOrder] [nvarchar](50) NULL,
	[ProductID] [nvarchar](50) NULL,
	[ProductDescription] [nvarchar](100) NULL,
	[OrderQuantity] [decimal](18, 2) NULL,
	[OrderStatus] [nvarchar](50) NULL,
	[Timestamp] [datetime] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
)

SET IDENTITY_INSERT [dbo].[SalesOrderTable] ON 

INSERT [dbo].[SalesOrderTable] ([SalesOrder], [SalesOrderItem], [WorkOrder], [ProductID], [ProductDescription], [OrderQuantity], [OrderStatus], [Timestamp], [ID]) VALUES (N'6604096600', N'300', N'6682432055', N'KB15_WE_G11', N'13A 250V 1 GANG SWITCHED SOCKET', CAST(1600.00 AS Decimal(18, 2)), N'Open', CAST(N'2021-05-11T15:56:00.000' AS DateTime), 7)
INSERT [dbo].[SalesOrderTable] ([SalesOrder], [SalesOrderItem], [WorkOrder], [ProductID], [ProductDescription], [OrderQuantity], [OrderStatus], [Timestamp], [ID]) VALUES (N'6604094574', N'3800', N'6682416525', N'3426UEST2MP', N'16A Twin 3Pin Uni So 3M Size Mod Push in', CAST(2400.00 AS Decimal(18, 2)), N'Open', CAST(N'2021-05-11T15:56:00.000' AS DateTime), 37)
INSERT [dbo].[SalesOrderTable] ([SalesOrder], [SalesOrderItem], [WorkOrder], [ProductID], [ProductDescription], [OrderQuantity], [OrderStatus], [Timestamp], [ID]) VALUES (N'6610002836', N'200', N'6682430487', N'41E2PBSWMZ-VW', N'Connected Switch 2AX 240V Zigbee VW', CAST(500.00 AS Decimal(18, 2)), N'Open', CAST(N'2023-04-05T15:36:12.357' AS DateTime), 29)
INSERT [dbo].[SalesOrderTable] ([SalesOrder], [SalesOrderItem], [WorkOrder], [ProductID], [ProductDescription], [OrderQuantity], [OrderStatus], [Timestamp], [ID]) VALUES (N'6604094765', N'100', N'6682418899', N'3426UEST2MP', N'16A Twin 3Pin Uni So 3M Size Mod Push in', CAST(600.00 AS Decimal(18, 2)), N'Open', CAST(N'2021-05-11T15:56:00.000' AS DateTime), 30)
INSERT [dbo].[SalesOrderTable] ([SalesOrder], [SalesOrderItem], [WorkOrder], [ProductID], [ProductDescription], [OrderQuantity], [OrderStatus], [Timestamp], [ID]) VALUES (N'6604094574', N'1800', N'6682429490', N'3426UEST2MP', N'16A Twin 3Pin Uni So 3M Size Mod Push in', CAST(2400.00 AS Decimal(18, 2)), N'Open', CAST(N'2021-05-11T15:56:00.000' AS DateTime), 31)
INSERT [dbo].[SalesOrderTable] ([SalesOrder], [SalesOrderItem], [WorkOrder], [ProductID], [ProductDescription], [OrderQuantity], [OrderStatus], [Timestamp], [ID]) VALUES (N'6604094576', N'100', N'6682429491', N'3426UEST2MP', N'16A Twin 3Pin Uni So 3M Size Mod Push in', CAST(1600.00 AS Decimal(18, 2)), N'Open', CAST(N'2021-05-11T15:56:00.000' AS DateTime), 32)
INSERT [dbo].[SalesOrderTable] ([SalesOrder], [SalesOrderItem], [WorkOrder], [ProductID], [ProductDescription], [OrderQuantity], [OrderStatus], [Timestamp], [ID]) VALUES (N'6604097026', N'300', N'6682429476', N'PDL395CSG', N'Grid Socket Connected Horiz Twin 10A250V 60', CAST(20.00 AS Decimal(18, 2)), N'Open', CAST(N'2023-04-05T15:36:15.167' AS DateTime), 33)
INSERT [dbo].[SalesOrderTable] ([SalesOrder], [SalesOrderItem], [WorkOrder], [ProductID], [ProductDescription], [OrderQuantity], [OrderStatus], [Timestamp], [ID]) VALUES (N'6604094115', N'300', N'6682414294', N'3025CSG', N'16A 250V 2G Universal Socket, GH', CAST(20.00 AS Decimal(18, 2)), N'Open', CAST(N'2021-05-11T15:56:00.000' AS DateTime), 34)
INSERT [dbo].[SalesOrderTable] ([SalesOrder], [SalesOrderItem], [WorkOrder], [ProductID], [ProductDescription], [OrderQuantity], [OrderStatus], [Timestamp], [ID]) VALUES (N'6604094735', N'100', N'6682416840', N'3025CSG', N'16A 250V 2G Universal Socket, GH', CAST(340.00 AS Decimal(18, 2)), N'Open', CAST(N'2021-05-11T15:56:00.000' AS DateTime), 35)
INSERT [dbo].[SalesOrderTable] ([SalesOrder], [SalesOrderItem], [WorkOrder], [ProductID], [ProductDescription], [OrderQuantity], [OrderStatus], [Timestamp], [ID]) VALUES (N'6604096402', N'200', N'6682426216', N'KB15_WE', N'13A 250V 1 GANG SWITCHED SOCKET', CAST(1600.00 AS Decimal(18, 2)), N'Open', CAST(N'2021-05-11T15:56:00.000' AS DateTime), 36)
SET IDENTITY_INSERT [dbo].[SalesOrderTable] OFF
GO

GO
CREATE PROCEDURE [dbo].[sp_InsertSalesOrder]
    @SalesOrder nvarchar(50),
    @SalesOrderItem nvarchar(50),
    @WorkOrder nvarchar(50),
    @ProductID nvarchar(50),
    @ProductDescription nvarchar(100),
    @OrderQuantity decimal(18,2),
    @OrderStatus nvarchar(50)
AS
BEGIN
    INSERT INTO SalesOrderTable (SalesOrder, SalesOrderItem, WorkOrder, ProductID, ProductDescription, OrderQuantity, OrderStatus, Timestamp)
    VALUES (@SalesOrder, @SalesOrderItem, @WorkOrder, @ProductID, @ProductDescription, @OrderQuantity, @OrderStatus, GETDATE())
END
GO

/****** Object:  StoredProcedure [dbo].[sp_UpdateSalesOrder]    Script Date: 05/04/2023 4:26:50 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateSalesOrder]
	@ID int,
    @SalesOrder nvarchar(50),
    @SalesOrderItem nvarchar(50),
    @WorkOrder nvarchar(50),
    @ProductID nvarchar(50),
    @ProductDescription nvarchar(100),
    @OrderQuantity decimal(18,2),
    @OrderStatus nvarchar(50)
AS
BEGIN
    UPDATE SalesOrderTable
    SET 
		SalesOrder = @SalesOrder,
		SalesOrderItem = @SalesOrderItem,
        WorkOrder = @WorkOrder,
        ProductID = @ProductID,
        ProductDescription = @ProductDescription,
        OrderQuantity = @OrderQuantity,
        OrderStatus = @OrderStatus,
        Timestamp = GETDATE()
    WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ViewSalesOrders]    Script Date: 05/04/2023 4:26:50 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ViewSalesOrders]
AS
BEGIN
    SELECT *
    FROM SalesOrderTable
END

GO

CREATE PROCEDURE [dbo].[sp_DeleteSalesOrder]
    @ID int
AS
BEGIN
    DELETE FROM SalesOrderTable
    WHERE ID = @ID
END
GO