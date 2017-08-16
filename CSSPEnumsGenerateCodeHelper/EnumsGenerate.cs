using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSPEnumsGenerateCodeHelper
{
    public partial class EnumsGenerateCodeHelper
    {
        public void EnumsGenerate()
        {
            StringBuilder sb = new StringBuilder();
            FileInfo fiDLL = new FileInfo(enumsFiles.CSSPEnumsDLL);
            FileInfo fi = new FileInfo(enumsFiles.BaseDir + enumsFiles.EnumsGenerated);

            sb.AppendLine(@"using CSSPEnums;");
            sb.AppendLine(@"using CSSPEnums.Resources;");
            sb.AppendLine(@"using System;");
            sb.AppendLine(@"using System.Collections.Generic;");
            sb.AppendLine(@"using System.Globalization;");
            sb.AppendLine(@"using System.Linq;");
            sb.AppendLine(@"using System.Text;");
            sb.AppendLine(@"using System.Threading;");
            sb.AppendLine(@"using System.Threading.Tasks;");
            sb.AppendLine(@"");
            sb.AppendLine(@"namespace CSSPEnums");
            sb.AppendLine(@"{");
            sb.AppendLine(@"    public partial class Enums");
            sb.AppendLine(@"    {");
            sb.AppendLine(@"");

            // Doing Functions Get Enum Text
            sb.AppendLine(@"        #region Functions Get Enum Text");
            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.GetTypeInfo().BaseType == typeof(System.Enum))
                {
                    string enumName = type.Name;
                    if (enumName == "PolSourceObsInfoEnum")
                        continue;

                    sb.AppendLine(@"        private string GetEnumText_" + enumName + "(" + enumName + "? " + enumName.Substring(0, 1).ToLower() + enumName.Substring(1, enumName.Length - 5) + ")");
                    sb.AppendLine(@"        {");
                    sb.AppendLine(@"            if (" + enumName.Substring(0, 1).ToLower() + enumName.Substring(1, enumName.Length - 5) + " == null)");
                    sb.AppendLine(@"                return CSSPEnumsRes.Empty;");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"            switch (" + enumName.Substring(0, 1).ToLower() + enumName.Substring(1, enumName.Length - 5) + ")");
                    sb.AppendLine(@"            {");
                    foreach (FieldInfo fieldInfo in type.GetFields())
                    {
                        if (fieldInfo.FieldType.GetTypeInfo().BaseType == typeof(System.Enum))
                        {
                            string fName = fieldInfo.Name;
                            sb.AppendLine(@"                case " + enumName + "." + fName + ":");
                            if (fName == "Error")
                            {
                                sb.AppendLine(@"                    return CSSPEnumsRes.Empty;");
                            }
                            else
                            {
                                sb.AppendLine(@"                    return CSSPEnumsRes." + enumName + fName + ";");
                            }
                        }
                    }
                    sb.AppendLine(@"                default:");
                    sb.AppendLine(@"                    return CSSPEnumsRes.Empty;");
                    sb.AppendLine(@"            }");
                    sb.AppendLine(@"        }");
                }
            }
            sb.AppendLine(@"");
            sb.AppendLine(@"        #endregion Functions Get Enum Text");

            // doing Function Get Enum Text Ordered
            sb.AppendLine(@"");
            sb.AppendLine(@"        #region Function Get Enum Text Ordered");
            importAssembly = Assembly.LoadFile(fiDLL.FullName);
            types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.GetTypeInfo().BaseType == typeof(System.Enum))
                {
                    string enumName = type.Name;
                    //if (enumName == "PolSourceObsInfoEnum")
                    //    continue;

                    sb.AppendLine(@"        public List<" + enumName + "TextOrdered> Get" + enumName + "TextOrderedList()");
                    sb.AppendLine(@"        {");
                    sb.AppendLine(@"            List<" + enumName + "TextOrdered> " + enumName + "TextOrderedList = new List<" + enumName + "TextOrdered>();");
                    sb.AppendLine(@"");
                    if (enumName == "SampleTypeEnum")
                    {
                        sb.AppendLine(@"            for (int i = 101, count = Enum.GetNames(typeof(" + enumName + ")).Count() + 100; i < count; i++)");
                    }
                    else
                    {
                        sb.AppendLine(@"            for (int i = 1, count = Enum.GetNames(typeof(" + enumName + ")).Count(); i < count; i++)");
                    }
                    sb.AppendLine(@"            {");
                    sb.AppendLine(@"                " + enumName + "TextOrderedList.Add(new " + enumName + "TextOrdered() { " + enumName.Substring(0, enumName.Length - 4) + " = (" + enumName + ")i, " + enumName.Substring(0, enumName.Length - 4) + "Text = GetEnumText_" + enumName + "((" + enumName + ")i) });");
                    sb.AppendLine(@"            }");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"            " + enumName + "TextOrderedList = (from c in " + enumName + "TextOrderedList");
                    sb.AppendLine(@"                                              orderby c." + enumName.Substring(0, enumName.Length - 4) + "Text");
                    sb.AppendLine(@"                                              select c).ToList();");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"            return " + enumName + "TextOrderedList;");
                    sb.AppendLine(@"        }");
                }
            }
            sb.AppendLine(@"");
            sb.AppendLine(@"        #endregion Function Get Enum Text Ordered");


            // doing Enum CheckOK
            sb.AppendLine(@"");
            sb.AppendLine(@"        #region Enum CheckOK");
            importAssembly = Assembly.LoadFile(fiDLL.FullName);
            types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.GetTypeInfo().BaseType == typeof(System.Enum))
                {
                    string enumName = type.Name;
                    if (enumName == "PolSourceObsInfoEnum")
                        continue;

                    sb.AppendLine(@"        public string " + enumName.Substring(0, enumName.Length - 4) + "OK(" + enumName + "? " + enumName.Substring(0, 1).ToLower() + enumName.Substring(1, enumName.Length - 5) + ")");
                    sb.AppendLine(@"        {");
                    sb.AppendLine(@"            if (" + enumName.Substring(0, 1).ToLower() + enumName.Substring(1, enumName.Length - 5) + " == null)");
                    sb.AppendLine(@"                return """";");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"            switch ((" + enumName + ")" + enumName.Substring(0, 1).ToLower() + enumName.Substring(1, enumName.Length - 5) + ")");
                    sb.AppendLine(@"            {");
                    foreach (FieldInfo fieldInfo in type.GetFields())
                    {
                        if (fieldInfo.FieldType.GetTypeInfo().BaseType == typeof(System.Enum))
                        {
                            string fName = fieldInfo.Name;
                            sb.AppendLine(@"                case " + enumName + "." + fName + ":");
                        }
                    }
                    sb.AppendLine(@"                    return """";");
                    sb.AppendLine(@"                default:");
                    sb.AppendLine(@"                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes." + enumName.Substring(0, enumName.Length - 4) + ");");
                    sb.AppendLine(@"            }");
                    sb.AppendLine(@"        }");
                }
            }
            sb.AppendLine(@"");
            sb.AppendLine(@"        #endregion Enum CheckOK");
            sb.AppendLine(@"");
            sb.AppendLine(@"    }");
            sb.AppendLine(@"}");

            using (StreamWriter sw = fi.CreateText())
            {
                sw.Write(sb.ToString());
            }
            StatusEvent(new StatusEventArgs("Created [" + fi.FullName + "] ..."));
        }
    }
}
