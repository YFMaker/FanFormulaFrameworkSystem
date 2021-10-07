using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
    /// <summary>
    /// 系统核心信息工作流
    /// </summary>
    public partial class BaseSystemInfo
    {
        /// <summary>
        /// 是否启用工作流
        /// </summary>
        public static bool UseWorkFlow = false;

        /// <summary>
        /// 简易消息提醒
        /// </summary>
        public static bool SimpleReminders = false;

        /// <summary>
        /// 待审核包含被驳回单据
        /// </summary>
        public static bool DocumentsToBeReviewedIncludeRejectedDocuments = true;
    }
}
