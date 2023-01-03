USE [cargo_mgmt]
GO
/****** Object:  Table [dbo].[cust_details]    Script Date: 10-11-2022 12:51:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cust_details](
	[bill_nop] [int] IDENTITY(1,1) NOT NULL,
	[c_name] [varchar](50) NOT NULL,
	[c_id] [varchar](50) NOT NULL,
	[c_address] [varchar](50) NOT NULL,
	[c_city] [varchar](50) NOT NULL,
	[c_pincode] [varchar](50) NOT NULL,
	[c_ph_no] [varchar](50) NOT NULL,
	[r_name] [varchar](50) NOT NULL,
	[r_id] [varchar](50) NOT NULL,
	[r_address] [varchar](50) NOT NULL,
	[r_city] [varchar](50) NOT NULL,
	[r_pincode] [varchar](50) NOT NULL,
	[r_ph_no] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[trans_details]    Script Date: 10-11-2022 12:51:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trans_details](
	[c_id] [varchar](50) NULL,
	[bill_no] [varchar](50) NOT NULL,
	[c_name] [varchar](50) NOT NULL,
	[type_of_goods] [varchar](50) NOT NULL,
	[goods_code] [varchar](50) NOT NULL,
	[goods_qty] [varchar](50) NOT NULL,
	[mode_of_transfer] [varchar](50) NOT NULL,
	[trans_no] [varchar](50) NOT NULL,
	[trans_status] [varchar](50) NOT NULL,
	[goods_cost] [varchar](50) NOT NULL,
	[date_of_sending] [varchar](50) NOT NULL,
	[date_of_delivery] [varchar](50) NOT NULL,
	[service_charge] [varchar](50) NOT NULL,
	[advance] [varchar](50) NOT NULL,
	[bal] [varchar](50) NOT NULL,
	[Received_Place] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
