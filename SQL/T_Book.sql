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

 Date: 03/05/2024 19:27:11
*/


-- ----------------------------
-- Table structure for T_Book
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[T_Book]') AND type IN ('U'))
	DROP TABLE [dbo].[T_Book]
GO

CREATE TABLE [dbo].[T_Book] (
  [Bid] int  NOT NULL,
  [Bname] varchar(50) COLLATE Chinese_PRC_CI_AS  NULL,
  [Author] varchar(50) COLLATE Chinese_PRC_CI_AS  NULL,
  [Publisher] varchar(50) COLLATE Chinese_PRC_CI_AS  NULL,
  [Date] date  NULL,
  [Price] float(53)  NULL,
  [Num] int  NULL,
  [Introduce] varchar(200) COLLATE Chinese_PRC_CI_AS  NULL,
  [BorrowCount] int  NULL,
  [Type] varchar(50) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[T_Book] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'租借数量',
'SCHEMA', N'dbo',
'TABLE', N'T_Book',
'COLUMN', N'BorrowCount'
GO


-- ----------------------------
-- Records of T_Book
-- ----------------------------
INSERT INTO [dbo].[T_Book] ([Bid], [Bname], [Author], [Publisher], [Date], [Price], [Num], [Introduce], [BorrowCount], [Type]) VALUES (N'1', N'doc_103234.pdf', N'李子异', N'子韬系统有限责任公司', N'2020-12-31', N'414.02', N'263', N'xmfDfd6OYi', N'525', N'法律部')
GO

INSERT INTO [dbo].[T_Book] ([Bid], [Bname], [Author], [Publisher], [Date], [Price], [Num], [Introduce], [BorrowCount], [Type]) VALUES (N'2', N'data_391590.csv', N'邹詩涵', N'嘉伦食品有限责任公司', N'2021-08-08', N'20.8', N'335', N'oD1VrqYmMb', N'402', N'信息技术支持部')
GO

INSERT INTO [dbo].[T_Book] ([Bid], [Bname], [Author], [Publisher], [Date], [Price], [Num], [Introduce], [BorrowCount], [Type]) VALUES (N'3', N'doc_701515.docx', N'邹子韬', N'冯記玩具有限责任公司', N'2015-08-24', N'598.39', N'554', N'rvvAPqRWMJ', N'103', N'法律部')
GO

INSERT INTO [dbo].[T_Book] ([Bid], [Bname], [Author], [Publisher], [Date], [Price], [Num], [Introduce], [BorrowCount], [Type]) VALUES (N'4', N'text_450590.rtf', N'田璐', N'宇宁物业代理有限责任公司', N'2003-04-30', N'713.4', N'820', N'FgPYgClDHd', N'312', N'外销部')
GO

INSERT INTO [dbo].[T_Book] ([Bid], [Bname], [Author], [Publisher], [Date], [Price], [Num], [Introduce], [BorrowCount], [Type]) VALUES (N'5', N'img_506427.jpg', N'郭子韬', N'梁有限责任公司', N'2017-02-19', N'592.42', N'927', N'0yB8pM4Ktr', N'456', N'qq')
GO

INSERT INTO [dbo].[T_Book] ([Bid], [Bname], [Author], [Publisher], [Date], [Price], [Num], [Introduce], [BorrowCount], [Type]) VALUES (N'6', N'doc_408487.pdf', N'董云熙', N'杰宏发展贸易有限责任公司', N'2016-09-05', N'808.76', N'644', N'fhCos3TYiK', N'221', N'外销部')
GO

INSERT INTO [dbo].[T_Book] ([Bid], [Bname], [Author], [Publisher], [Date], [Price], [Num], [Introduce], [BorrowCount], [Type]) VALUES (N'7', N'doc_235414.docx', N'刘晓明', N'云熙制药有限责任公司', N'2012-03-29', N'609.06', N'223', N'dlMhw0Qd6j', N'492', N'jj')
GO

INSERT INTO [dbo].[T_Book] ([Bid], [Bname], [Author], [Publisher], [Date], [Price], [Num], [Introduce], [BorrowCount], [Type]) VALUES (N'8', N'data_132900.xlsx', N'于嘉伦', N'叶記技术有限责任公司', N'2002-10-23', N'675.18', N'257', N'n6iw3Zc1bL', N'456', N'研究及开发部')
GO

INSERT INTO [dbo].[T_Book] ([Bid], [Bname], [Author], [Publisher], [Date], [Price], [Num], [Introduce], [BorrowCount], [Type]) VALUES (N'9', N'zip_089234.zip', N'郑致远', N'子异通讯有限责任公司', N'2020-08-13', N'579.5', N'820', N'anSgMqRPoC', N'602', N'工程部')
GO

INSERT INTO [dbo].[T_Book] ([Bid], [Bname], [Author], [Publisher], [Date], [Price], [Num], [Introduce], [BorrowCount], [Type]) VALUES (N'10', N'img_193356.jpg', N'蒋璐', N'段贸易有限责任公司', N'2011-03-14', N'865.67', N'365', N'PmTU37Kptq', N'250', N'生产部')
GO


-- ----------------------------
-- Primary Key structure for table T_Book
-- ----------------------------
ALTER TABLE [dbo].[T_Book] ADD CONSTRAINT [PK__T_Book__C6D111C9B0BE7604] PRIMARY KEY CLUSTERED ([Bid])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

