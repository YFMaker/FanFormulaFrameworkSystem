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

        public ActionResult<object> InsertBase_Sys_UserTable()
        {
            Base_Sys_UserEntity entity = new Base_Sys_UserEntity();
            entity.ID = BusinessLogic.NewGuid();
            return "";
        }

    }
}

