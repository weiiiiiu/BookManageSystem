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

 Date: 03/05/2024 19:27:20
*/


-- ----------------------------
-- Table structure for T_User
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[T_User]') AND type IN ('U'))
	DROP TABLE [dbo].[T_User]
GO

CREATE TABLE [dbo].[T_User] (
  [Uid] int  NULL,
  [Uname] varchar(50) COLLATE Chinese_PRC_CI_AS  NULL,
  [Pwd] varchar(6) COLLATE Chinese_PRC_CI_AS  NULL,
  [Sex] varchar(2) COLLATE Chinese_PRC_CI_AS  NULL,
  [IdCard] varchar(18) COLLATE Chinese_PRC_CI_AS  NULL,
  [Tel] varchar(11) COLLATE Chinese_PRC_CI_AS  NULL,
  [Used] bit  NULL
)
GO

ALTER TABLE [dbo].[T_User] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of T_User
-- ----------------------------
INSERT INTO [dbo].[T_User] ([Uid], [Uname], [Pwd], [Sex], [IdCard], [Tel], [Used]) VALUES (N'769', N'林震南', N'123456', N'男', N'884444967208254469', N'15982169636', N'1')
GO

INSERT INTO [dbo].[T_User] ([Uid], [Uname], [Pwd], [Sex], [IdCard], [Tel], [Used]) VALUES (N'2', N'王二', N'123456', N'女', N'321283200208263013', N'17506111740', N'1')
GO

INSERT INTO [dbo].[T_User] ([Uid], [Uname], [Pwd], [Sex], [IdCard], [Tel], [Used]) VALUES (N'622', N'戴嘉伦', N'gAjrIn', N'男', N'521450304029850291', N'7609738212', N'1')
GO

INSERT INTO [dbo].[T_User] ([Uid], [Uname], [Pwd], [Sex], [IdCard], [Tel], [Used]) VALUES (N'819', N'姜晓明', N'hrGzn5', N'男', N'517882645052908935', N'19204733675', N'0')
GO

INSERT INTO [dbo].[T_User] ([Uid], [Uname], [Pwd], [Sex], [IdCard], [Tel], [Used]) VALUES (N'401', N'何安琪', N'bZQhGl', N'女', N'189620038141622717', N'210110808', N'0')
GO

INSERT INTO [dbo].[T_User] ([Uid], [Uname], [Pwd], [Sex], [IdCard], [Tel], [Used]) VALUES (N'627', N'江詩涵', N'rBmczO', N'女', N'993779117814170521', N'108353600', N'0')
GO

INSERT INTO [dbo].[T_User] ([Uid], [Uname], [Pwd], [Sex], [IdCard], [Tel], [Used]) VALUES (N'602', N'严宇宁', N'eEjmMf', N'男', N'552908266823505840', N'75539663944', N'0')
GO

INSERT INTO [dbo].[T_User] ([Uid], [Uname], [Pwd], [Sex], [IdCard], [Tel], [Used]) VALUES (N'486', N'徐睿', N'B3om1I', N'男', N'296614744373563996', N'17064939294', N'1')
GO

INSERT INTO [dbo].[T_User] ([Uid], [Uname], [Pwd], [Sex], [IdCard], [Tel], [Used]) VALUES (N'226', N'阎云熙', N'1OScrC', N'男', N'531798631639139942', N'14920847964', N'0')
GO

INSERT INTO [dbo].[T_User] ([Uid], [Uname], [Pwd], [Sex], [IdCard], [Tel], [Used]) VALUES (N'554', N'邵詩涵', N'x56q4L', N'女', N'415988490823787830', N'289011874', N'1')
GO

INSERT INTO [dbo].[T_User] ([Uid], [Uname], [Pwd], [Sex], [IdCard], [Tel], [Used]) VALUES (N'940', N'梁安琪', N'p636jn', N'女', N'281197591854869848', N'16289146424', N'1')
GO

