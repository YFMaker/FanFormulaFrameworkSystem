#region
//*********************************************************
//
//本MODEL由 衣凡 生成器创建
//
//创建人：YF
//
//创建时间：2022-03-30 14:44:07
//*********************************************************
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FanFormulaFramework.Library;

namespace FanFormulaFramework.Model
{
    public partial class Base_Sys_UserEntity : BaseEntity
    {

        /// <summary>
        /// 构造函数
        /// </summary>
        public Base_Sys_UserEntity()
        {
        }

        private string _ID;
        /// <summary>
        /// 主键
        /// </summary>
        public string ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }

        private string _Code;
        /// <summary>
        /// 编号（内部）
        /// </summary>
        public string Code
        {
            get
            {
                return _Code;
            }
            set
            {
                _Code = value;
            }
        }

        private string _UserName;
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }

        private string _RealName;
        /// <summary>
        /// 用户真实名称
        /// </summary>
        public string RealName
        {
            get
            {
                return _RealName;
            }
            set
            {
                _RealName = value;
            }
        }

        private string _NickName;
        /// <summary>
        /// 内部昵称
        /// </summary>
        public string NickName
        {
            get
            {
                return _NickName;
            }
            set
            {
                _NickName = value;
            }
        }

        private string _QuickQuery;
        /// <summary>
        /// 快搜简称
        /// </summary>
        public string QuickQuery
        {
            get
            {
                return _QuickQuery;
            }
            set
            {
                _QuickQuery = value;
            }
        }

        private string _RoleId;
        /// <summary>
        /// 员工表ID
        /// </summary>
        public string RoleId
        {
            get
            {
                return _RoleId;
            }
            set
            {
                _RoleId = value;
            }
        }

        private string _CompanyID;
        /// <summary>
        /// 公司表ID（一级公司）
        /// </summary>
        public string CompanyID
        {
            get
            {
                return _CompanyID;
            }
            set
            {
                _CompanyID = value;
            }
        }

        private string _CompanyName;
        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName
        {
            get
            {
                return _CompanyName;
            }
            set
            {
                _CompanyName = value;
            }
        }

        private string _SubCompanyID;
        /// <summary>
        /// 公司表ID（非一级公司）
        /// </summary>
        public string SubCompanyID
        {
            get
            {
                return _SubCompanyID;
            }
            set
            {
                _SubCompanyID = value;
            }
        }

        private string _SubCompanyName;
        /// <summary>
        /// 子公司名称
        /// </summary>
        public string SubCompanyName
        {
            get
            {
                return _SubCompanyName;
            }
            set
            {
                _SubCompanyName = value;
            }
        }

        private string _DepartmentID;
        /// <summary>
        /// 所属部门ID
        /// </summary>
        public string DepartmentID
        {
            get
            {
                return _DepartmentID;
            }
            set
            {
                _DepartmentID = value;
            }
        }

        private string _DepartmentName;
        /// <summary>
        /// 所属部门名称
        /// </summary>
        public string DepartmentName
        {
            get
            {
                return _DepartmentName;
            }
            set
            {
                _DepartmentName = value;
            }
        }

        private string _Gender;
        /// <summary>
        /// 性别
        /// </summary>
        public string Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                _Gender = value;
            }
        }

        private DateTime _Birthday;
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthday
        {
            get
            {
                return _Birthday;
            }
            set
            {
                _Birthday = value;
            }
        }

        private string _IDCardNum;
        /// <summary>
        /// ID卡号
        /// </summary>
        public string IDCardNum
        {
            get
            {
                return _IDCardNum;
            }
            set
            {
                _IDCardNum = value;
            }
        }

        private string _TelePhone;
        /// <summary>
        /// 手机号
        /// </summary>
        public string TelePhone
        {
            get
            {
                return _TelePhone;
            }
            set
            {
                _TelePhone = value;
            }
        }

        private string _UserPassWord;
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPassWord
        {
            get
            {
                return _UserPassWord;
            }
            set
            {
                _UserPassWord = value;
            }
        }

        private string _Theme;
        /// <summary>
        /// 主题
        /// </summary>
        public string Theme
        {
            get
            {
                return _Theme;
            }
            set
            {
                _Theme = value;
            }
        }

        private int _IsStaff;
        /// <summary>
        /// 是否员工
        /// </summary>
        public int IsStaff
        {
            get
            {
                return _IsStaff;
            }
            set
            {
                _IsStaff = value;
            }
        }

        private int _IsVisibls;
        /// <summary>
        /// 是否查询

        /// </summary>
        public int IsVisibls
        {
            get
            {
                return _IsVisibls;
            }
            set
            {
                _IsVisibls = value;
            }
        }

        private int _IsDimission;
        /// <summary>
        /// 是否离职
        /// </summary>
        public int IsDimission
        {
            get
            {
                return _IsDimission;
            }
            set
            {
                _IsDimission = value;
            }
        }

        private DateTime _DimissionTime;
        /// <summary>
        /// 离职时间
        /// </summary>
        public DateTime DimissionTime
        {
            get
            {
                return _DimissionTime;
            }
            set
            {
                _DimissionTime = value;
            }
        }

        private string _DimissionWhither;
        /// <summary>
        /// 离职原因
        /// </summary>
        public string DimissionWhither
        {
            get
            {
                return _DimissionWhither;
            }
            set
            {
                _DimissionWhither = value;
            }
        }

        private int _IsEnabled;
        /// <summary>
        /// 是否显示
        /// </summary>
        public int IsEnabled
        {
            get
            {
                return _IsEnabled;
            }
            set
            {
                _IsEnabled = value;
            }
        }

        private int _IsDelete;
        /// <summary>
        /// 是否删除
        /// </summary>
        public int IsDelete
        {
            get
            {
                return _IsDelete;
            }
            set
            {
                _IsDelete = value;
            }
        }

        private DateTime _CreateTime;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            get
            {
                return _CreateTime;
            }
            set
            {
                _CreateTime = value;
            }
        }

        private string _CreateUserId;
        /// <summary>
        /// 创建人ID
        /// </summary>
        public string CreateUserId
        {
            get
            {
                return _CreateUserId;
            }
            set
            {
                _CreateUserId = value;
            }
        }

        private string _CreateBy;
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateBy
        {
            get
            {
                return _CreateBy;
            }
            set
            {
                _CreateBy = value;
            }
        }

        private DateTime _ModifiedTime;
        /// <summary>
        /// 编辑时间
        /// </summary>
        public DateTime ModifiedTime
        {
            get
            {
                return _ModifiedTime;
            }
            set
            {
                _ModifiedTime = value;
            }
        }

        private string _ModifiedUserId;
        /// <summary>
        /// 编辑人ID
        /// </summary>
        public string ModifiedUserId
        {
            get
            {
                return _ModifiedUserId;
            }
            set
            {
                _ModifiedUserId = value;
            }
        }

        private string _ModifiedBy;
        /// <summary>
        /// 编辑人
        /// </summary>
        public string ModifiedBy
        {
            get
            {
                return _ModifiedBy;
            }
            set
            {
                _ModifiedBy = value;
            }
        }



        /// <summary>
        /// 从数据行读取
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        protected override BaseEntity GetFrom(IDataRow dataRow)
        {
            this.ID = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldID]);
            this.Code = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldCode]);
            this.UserName = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldUserName]);
            this.RealName = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldRealName]);
            this.NickName = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldNickName]);
            this.QuickQuery = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldQuickQuery]);
            this.RoleId = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldRoleId]);
            this.CompanyID = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldCompanyID]);
            this.CompanyName = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldCompanyName]);
            this.SubCompanyID = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldSubCompanyID]);
            this.SubCompanyName = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldSubCompanyName]);
            this.DepartmentID = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldDepartmentID]);
            this.DepartmentName = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldDepartmentName]);
            this.Gender = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldGender]);
            this.Birthday = BusinessLogic.ConvertToDateTime(dataRow[Base_Sys_UserTable.FieldBirthday]);
            this.IDCardNum = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldIDCardNum]);
            this.TelePhone = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldTelePhone]);
            this.UserPassWord = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldUserPassWord]);
            this.Theme = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldTheme]);
            this.IsStaff = BusinessLogic.ConvertToInt(dataRow[Base_Sys_UserTable.FieldIsStaff]);
            this.IsVisibls = BusinessLogic.ConvertToInt(dataRow[Base_Sys_UserTable.FieldIsVisibls]);
            this.IsDimission = BusinessLogic.ConvertToInt(dataRow[Base_Sys_UserTable.FieldIsDimission]);
            this.DimissionTime = BusinessLogic.ConvertToDateTime(dataRow[Base_Sys_UserTable.FieldDimissionTime]);
            this.DimissionWhither = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldDimissionWhither]);
            this.IsEnabled = BusinessLogic.ConvertToInt(dataRow[Base_Sys_UserTable.FieldIsEnabled]);
            this.IsDelete = BusinessLogic.ConvertToInt(dataRow[Base_Sys_UserTable.FieldIsDelete]);
            this.CreateTime = BusinessLogic.ConvertToDateTime(dataRow[Base_Sys_UserTable.FieldCreateTime]);
            this.CreateUserId = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldCreateUserId]);
            this.CreateBy = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldCreateBy]);
            this.ModifiedTime = BusinessLogic.ConvertToDateTime(dataRow[Base_Sys_UserTable.FieldModifiedTime]);
            this.ModifiedUserId = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldModifiedUserId]);
            this.ModifiedBy = BusinessLogic.ConvertToString(dataRow[Base_Sys_UserTable.FieldModifiedBy]);

            return this;
        }
    }
}

