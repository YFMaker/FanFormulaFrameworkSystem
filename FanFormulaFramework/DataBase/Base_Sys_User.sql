/*
 Navicat Premium Data Transfer

 Source Server         : 测试mysql
 Source Server Type    : MySQL
 Source Server Version : 80021
 Source Host           : 192.168.88.132:3306
 Source Schema         : Core

 Target Server Type    : MySQL
 Target Server Version : 80021
 File Encoding         : 65001

 Date: 09/03/2022 10:40:34
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for Base_Sys_User
-- ----------------------------
DROP TABLE IF EXISTS `Base_Sys_User`;
CREATE TABLE `Base_Sys_User`  (
  `ID` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '主键',
  `Code` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '编号（内部）',
  `UserName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '用户名称',
  `RealName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '用户真实名称',
  `NickName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '内部昵称',
  `QuickQuery` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '快搜简称',
  `RoleId` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '员工表ID',
  `CompanyID` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '公司表ID（一级公司）',
  `CompanyName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '公司名称',
  `SubCompanyID` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '公司表ID（非一级公司）',
  `SubCompanyName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '子公司名称',
  `DepartmentID` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '所属部门ID',
  `DepartmentName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '所属部门名称',
  `Gender` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '性别',
  `Birthday` datetime NOT NULL COMMENT '出生日期',
  `IDCardNum` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT 'ID卡号',
  `TelePhone` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '手机号',
  `UserPassWord` varchar(400) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '用户密码',
  `Theme` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '主题',
  `IsStaff` int(255) UNSIGNED ZEROFILL NOT NULL COMMENT '是否员工',
  `IsVisibls` int(255) UNSIGNED ZEROFILL NOT NULL COMMENT '是否查询\r\n',
  `IsDimission` int(255) UNSIGNED ZEROFILL NOT NULL COMMENT '是否离职',
  `DimissionTime` datetime NULL DEFAULT NULL COMMENT '离职时间',
  `DimissionWhither` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '离职原因',
  `IsEnabled` int(255) UNSIGNED ZEROFILL NOT NULL COMMENT '是否显示',
  `IsDelete` int(255) UNSIGNED ZEROFILL NOT NULL COMMENT '是否删除',
  `CreateTime` datetime NOT NULL COMMENT '创建时间',
  `CreateUserId` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '创建人ID',
  `CreateBy` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '创建人',
  `ModifiedTime` datetime NULL DEFAULT NULL COMMENT '编辑时间',
  `ModifiedUserId` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '编辑人ID',
  `ModifiedBy` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '编辑人',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
