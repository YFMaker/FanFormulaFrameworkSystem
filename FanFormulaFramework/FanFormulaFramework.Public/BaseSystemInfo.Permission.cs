﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
    /// <summary>
    /// 系统信息组织架构类
    /// </summary>
    public partial class BaseSystemInfo
    {
        /// <summary>
        /// 采用角色组织关联关系
        /// </summary>
        public static bool UseRoleOrganize = false;

        /// <summary>
        /// 是否启用表格数据权限
        /// 启用分级管理范围权限设置，启用逐级授权
        /// </summary>
        public static bool UsePermissionScope = true;

        /// <summary>
        /// 启用授权范围（逐级授权）
        /// </summary>
        public static bool UseAuthorizationScope = false;

        /// <summary>
        /// 启用按用户权限
        /// </summary>
        public static bool UseUserPermission = true;

        /// <summary>
        /// 启用按组织机构权限
        /// </summary>
        public static bool UseOrganizePermission = false;

        /// <summary>
        /// 启用数据表的约束条件限制
        /// </summary>
        public static bool UseTableScopePermission = false;

        /// <summary>
        /// 启用数据表的列权限
        /// </summary>
        public static bool UseTableColumnPermission = false;

        /// <summary>
        /// 设置手写签名
        /// </summary>
        public static bool HandwrittenSignature = false;

        /// <summary>
        /// 登录历史纪录
        /// </summary>
        public static bool RecordLogOnLog = true;

        /// <summary>
        /// 是否进行日志记录
        /// </summary>
        public static bool RecordLog = true;

        /// <summary>
        /// 是否更新访问日期信息
        /// </summary>
        public static bool UpdateVisit = true;

        /// <summary>
        /// 同时在线用户数量限制
        /// </summary>
        public static int OnLineLimit = 0;

        /// <summary>
        /// 是否检查用户IP地址
        /// </summary>
        public static bool CheckIPAddress = false;

        /// <summary>
        /// 是否登记异常
        /// </summary>
        public static bool LogException = true;

        /// <summary>
        /// 是否登记数据库操作
        /// </summary>
        public static bool LogSQL = true;

        /// <summary>
        /// 是否登记到系统异常中
        /// </summary>
        public static bool EventLog = false;
    }
}
