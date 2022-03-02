using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.BusinessService.Models
{
    public static class OperationBaseUtil
    {
        /// <summary>
        /// 有效池
        /// </summary>
        private static Dictionary<int,string> InterFaceStateList=new Dictionary<int, string>();

        /// <summary>
        /// 池启动行为
        /// </summary>
        /// <param name="interfaceState"></param>
        public static void AddInterface(InterfaceState interfaceState)
        {
            if (!IsEnable(interfaceState.Businesskey))
            {
                //正式加池
                InterFaceStateList.Add(interfaceState.Businesskey, interfaceState.InterFaceName);
            }
            else
            {
                //无加池行为
            }
        }

        /// <summary>
        /// 池关闭行为
        /// </summary>
        /// <param name="businesskey"></param>
        public static void RemoveInterface(int businesskey)
        {
            if (IsEnable(businesskey))
            {
                //正式关池
                InterFaceStateList.Remove(businesskey);
            }
            else
            {
                //无关池行为
            }
        }

        /// <summary>
        /// 取池
        /// </summary>
        /// <param name="businessvalue"></param>
        /// <returns></returns>
        public static int GetInterface(string  businessvalue)
        {
            int result = 0;
            if (IsEnable(businessvalue))
            {
                result = IsContel(businessvalue);
                return result;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// 验证池中是否存在
        /// </summary>
        /// <param name="businesskey"></param>
        /// <returns></returns>
        private static bool IsEnable(int businesskey)
        {
            if (InterFaceStateList.ContainsKey(businesskey))
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        /// <summary>
        /// 验证池中是否存在
        /// </summary>
        /// <param name="businessvalue"></param>
        /// <returns></returns>
        private static bool IsEnable(string businessvalue)
        {
            if (InterFaceStateList.ContainsValue(businessvalue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 取池编号
        /// </summary>
        /// <param name="businessvalue"></param>
        /// <returns></returns>
        private static int IsContel(string businessvalue)
        {
            int result = -1;
            try
            {
                result = InterFaceStateList.First(kv => kv.Value == businessvalue).Key;
            }
            catch (Exception ex)
            {
                result = -1;
                Console.WriteLine(ex.Message);
            }
            return result;
        }

    }
}
