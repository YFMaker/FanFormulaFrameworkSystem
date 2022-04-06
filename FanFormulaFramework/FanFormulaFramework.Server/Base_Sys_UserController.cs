#region
//*********************************************************
//
//本Controller由 衣凡 生成器创建
//
//创建人：YF
//
//创建时间：2022-03-30 15:19:56
//*********************************************************
#endregion

using FanFormulaFramework.Library;
using FanFormulaFramework.Model;
using FanFormulaFramework.Public;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YFMakeEncryption;

namespace FanFormulaFramework.Server
{
    public class Base_Sys_UserController : IControllers
    {
        public Base_Sys_UserController()
        {
            Logger = new ILoger<IControllers>();
        }

        [HttpGet]
        [ActionName("GetBaseUser")]//根据实际需要定义功能接口名称，防止action名称冲突
        public ActionResult<object> GetBase_Sys_UserTable()
        {
            string resule=PostUntil.PostPush(Base_Sys_UserTable.BusinessName, "select", "select * from " + Base_Sys_UserTable.TableName);

            return resule;
        }

        [HttpPost]
        [ActionName("RegisteredUser")]
        public ActionResult<object> InsertBase_Sys_UserTable()
        {
            Base_Sys_UserEntity entity = new Base_Sys_UserEntity();
            entity.ID = BusinessLogic.NewGuid();
            entity.Code = "root";
            entity.UserName = "Administrator";
            entity.RealName = "超级管理员";
            entity.NickName = "超级管理员";
            entity.QuickQuery = "超级管理员";
            entity.UserPassWord = PassWordUtil.DecryptInformation("Y950509f");
            entity.Gender = "男";
            entity.Theme = "无";
            entity.IsStaff = 0;
            entity.IsVisibls = 1;
            entity.IsEnabled = 1;
            entity.IsDelete = 0;
            entity.CreateBy = "root";
            entity.CreateTime = DateTimeUtil.Now();
            entity.CreateUserId = "root";
            string result = PostUntil.PostPush(Base_Sys_UserTable.BusinessName, "insert", "");
            return "";
        }

    }
}

