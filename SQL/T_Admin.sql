/*
 Navicat Premium Data Transfer

 Source Server         : sql server
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : localhost:1433
 Source Catalog        : stduentsdb
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 03/05/2024 19:26:31
*/


-- ----------------------------
-- Table structure for T_Admin
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[T_Admin]') AND type IN ('U'))
	DROP TABLE [dbo].[T_Admin]
GO

CREATE TABLE [dbo].[T_Admin] (
  [AdminId] int  NOT NULL,
  [Pwd] varchar(6) COLLATE Chinese_PRC_CI_AS  NULL,
  [Name] varchar(50) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[T_Admin] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of T_Admin
-- ----------------------------
INSERT INTO [dbo].[T_Admin] ([AdminId], [Pwd], [Name]) VALUES (N'1', N'123456', N'韩璐')
GO

INSERT INTO [dbo].[T_Admin] ([AdminId], [Pwd], [Name]) VALUES (N'2', N'MJtD3i', N'田宇宁')
GO

INSERT INTO [dbo].[T_Admin] ([AdminId], [Pwd], [Name]) VALUES (N'3', N'YPOGCa', N'向云熙')
GO

INSERT INTO [dbo].[T_Admin] ([AdminId], [Pwd], [Name]) VALUES (N'4', N'QjBC5k', N'袁晓明')
GO

INSERT INTO [dbo].[T_Admin] ([AdminId], [Pwd], [Name]) VALUES (N'5', N'27SPIQ', N'孔震南')
GO

INSERT INTO [dbo].[T_Admin] ([AdminId], [Pwd], [Name]) VALUES (N'6', N'LYzEfQ', N'丁杰宏')
GO

INSERT INTO [dbo].[T_Admin] ([AdminId], [Pwd], [Name]) VALUES (N'7', N'yAEKF8', N'孟安琪')
GO

INSERT INTO [dbo].[T_Admin] ([AdminId], [Pwd], [Name]) VALUES (N'8', N'oOwQp1', N'潘安琪')
GO

INSERT INTO [dbo].[T_Admin] ([AdminId], [Pwd], [Name]) VALUES (N'9', N'3mHMhj', N'孔杰宏')
GO

INSERT INTO [dbo].[T_Admin] ([AdminId], [Pwd], [Name]) VALUES (N'10', N'IpXQzd', N'陈宇宁')
GO


-- ----------------------------
-- Primary Key structure for table T_Admin
-- ----------------------------
ALTER TABLE [dbo].[T_Admin] ADD CONSTRAINT [PK_T_Admin] PRIMARY KEY CLUSTERED ([AdminId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

