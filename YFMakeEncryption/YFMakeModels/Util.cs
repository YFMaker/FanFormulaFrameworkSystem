using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YFMakeModels
{
    public static class Util
    {
        public static string Typename(string name)
        {
            string csType = "";
            switch (Regex.Replace(name.Replace("（", "(").Replace("）", ")"), @"\([^\(]*\)", ""))
            {
                case "varchar":
                case "varchar2":
                case "nvarchar":
                case "nvarchar2":
                case "char":
                case "nchar":
                case "text":
                case "longtext":
                case "string":
                    csType = "string";
                    break;

                case "date":
                case "datetime":
                case "smalldatetime":
                case "timestamp":
                    csType = "DateTime";
                    break;

                case "int":
                case "number":
                case "smallint":
                case "int unsigned zerofill":
                case "integer":
                    csType = "int";
                    break;

                case "bigint":
                    csType = "Int64";
                    break;

                case "float":
                case "numeric":
                case "decimal":
                case "money":
                case "smallmoney":
                case "real":
                case "double":
                    csType = "decimal";
                    break;
                case "tinyint":
                case "bit":
                    csType = "bool";
                    break;

                case "binary":
                case "varbinary":
                case "image":
                case "raw":
                case "long":
                case "long raw":
                case "blob":
                case "bfile":
                    csType = "byte[]";
                    break;

                case "uniqueidentifier":
                    csType = "Guid";
                    break;

                case "xml":
                case "json":
                    csType = "string";
                    break;
                default:
                    csType = "object";
                    break;
            }

            return csType;
        }


        public static string TypeName(string name)
        {
            string csType = "";
            switch (Regex.Replace(name.Replace("（", "(").Replace("）", ")"), @"\([^\(]*\)", ""))
            {
                case "varchar":
                case "varchar2":
                case "nvarchar":
                case "nvarchar2":
                case "char":
                case "nchar":
                case "text":
                case "longtext":
                case "string":
                    csType = "String";
                    break;

                case "date":
                case "datetime":
                case "smalldatetime":
                case "timestamp":
                    csType = "DateTime";
                    break;

                case "int":
                case "number":
                case "smallint":
                case "int unsigned zerofill":
                case "integer":
                    csType = "Int";
                    break;

                case "bigint":
                    csType = "Int64";
                    break;

                case "float":
                case "numeric":
                case "decimal":
                case "money":
                case "smallmoney":
                case "real":
                case "double":
                    csType = "Decimal";
                    break;
                case "tinyint":
                case "bit":
                    csType = "Bool";
                    break;

                case "binary":
                case "varbinary":
                case "image":
                case "raw":
                case "long":
                case "long raw":
                case "blob":
                case "bfile":
                    csType = "Byte[]";
                    break;

                case "uniqueidentifier":
                    csType = "Guid";
                    break;

                case "xml":
                case "json":
                    csType = "String";
                    break;
                default:
                    csType = "Object";
                    break;
            }

            return csType;
        }
    }
}
