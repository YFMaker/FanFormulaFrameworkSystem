using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanFormulaFramework.Model
{
    /// <summary>
    /// Base_Sys_UserTable
    /// </summary>
    public partial class Base_Sys_UserTable
    {
        ///<summary>
        /// 表名
        ///</summary>
        [NonSerialized]
        public static string TableName = "Base_Sys_User";

        /// <summary>
        /// 业务服务名称
        /// </summary>
        [NonSerialized]
        public static string BusinessName = "";

        /// <summary>
        /// 主键
        /// </summary>
        [NonSerialized]
        public static string FiledID = "ID";

        ///<summary>
        /// 编号（内部）
        ///</summary>
        [NonSerialized]
        public static string FieldCode = "Code";

        /// <summary>
        /// 用户名称
        /// </summary>
        [NonSerialized]
        public static string FieldUserName = "UserName";

        /// <summary>
        /// 用户真实名称
        /// </summary>
        [NonSerialized]
        public static string FieldRealName = "RealName";

        /// <summary>
        /// 内部昵称
        /// </summary>
        [NonSerialized]
        public static string FieldNickName = "NickName";

        /// <summary>
        /// 快搜简称
        /// </summary>
        [NonSerialized]
        public static string FieldQuickQuery = "QuickQuery";

        /// <summary>
        /// 员工表ID
        /// </summary>
        [NonSerialized]
        public static string FieldRoleId = "RoleId";

        /// <summary>
        /// 公司表ID（一级公司）
        /// </summary>
        [NonSerialized]
        public static string FieldCompanyID = "CompanyID";

        /// <summary>
        /// 公司名称
        /// </summary>
        [NonSerialized]
        public static string FieldCompanyName = "CompanyName";

        /// <summary>
        /// 公司表ID（非一级公司）
        /// </summary>
        [NonSerialized]
        public static string FieldSubCompanyID = "SubCompanyID";

        /// <summary>
        /// 子公司名称
        /// </summary>
        [NonSerialized]
        public static string FieldSubCompanyName = "SubCompanyName";

        /// <summary>
        /// 所属部门ID
        /// </summary>
        [NonSerialized]
        public static string FieldDepartmentID = "DepartmentID";

        /// <summary>
        /// 所属部门名称
        /// </summary>
        [NonSerialized]
        public static string FieldDepartmentName = "DepartmentName";

        /// <summary>
        /// 性别
        /// </summary>
        [NonSerialized]
        public static string FieldGender = "Gender";

        /// <summary>
        /// 出生日期
        /// </summary>
        [NonSerialized]
        public static string FieldBirthday = "Birthday";

        /// <summary>
        /// ID卡号
        /// </summary>
        [NonSerialized]
        public static string FieldIDCardNum = "IDCardNum";

        /// <summary>
        /// 手机号
        /// </summary>
        [NonSerialized]
        public static string FieldTelePhone = "TelePhone";

        /// <summary>
        /// 用户密码
        /// </summary>
        [NonSerialized]
        public static string FieldUserPassWord = "UserPassWord";

        /// <summary>
        /// 主题
        /// </summary>
        [NonSerialized]
        public static string FieldTheme = "Theme";

        /// <summary>
        /// 是否员工
        /// </summary>
        [NonSerialized]
        public static string FieldIsStaff = "IsStaff";

        /// <summary>
        /// 是否查询
        /// </summary>
        [NonSerialized]
        public static string FieldIsVisibls = "IsVisibls";

        /// <summary>
        /// 是否离职
        /// </summary>
        [NonSerialized]
        public static string FieldIsDimission = "IsDimission";

        /// <summary>
        /// 离职时间
        /// </summary>
        [NonSerialized]
        public static string FieldDimissionTime = "DimissionTime";

        /// <summary>
        /// 离职原因
        /// </summary>
        [NonSerialized]
        public static string FieldDimissionWhither = "DimissionWhither";

        /// <summary>
        /// 是否显示
        /// </summary>
        [NonSerialized]
        public static string FieldIsEnabled = "IsEnabled";

        /// <summary>
        /// 是否删除
        /// </summary>
        [NonSerialized]
        public static string FieldIsDelete = "IsDelete";

        /// <summary>
        /// 创建时间
        /// </summary>
        [NonSerialized]
        public static string FieldCreateTime = "CreateTime";

        /// <summary>
        /// 创建人ID
        /// </summary>
        [NonSerialized]
        public static string FieldCreateUserId = "CreateUserId";

        /// <summary>
        /// 创建人
        /// </summary>
        [NonSerialized]
        public static string FieldCreateBy = "CreateBy";

        /// <summary>
        /// 编辑时间
        /// </summary>
        [NonSerialized]
        public static string FieldModifiedTime = "ModifiedTime";

        /// <summary>
        /// 编辑人ID
        /// </summary>
        [NonSerialized]
        public static string FieldModifiedUserId = "ModifiedUserId";

        /// <summary>
        /// 编辑人
        /// </summary>
        [NonSerialized]
        public static string FieldModifiedBy = "ModifiedBy";

    }
}
