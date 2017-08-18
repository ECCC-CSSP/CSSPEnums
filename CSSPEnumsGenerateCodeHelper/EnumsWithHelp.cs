using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSSPEnums;
using System.Net;

namespace CSSPEnumsGenerateCodeHelper
{
    public partial class EnumsGenerateCodeHelper
    {
        public void EnumsWithHelp()
        {
            Enums enumsEn = new Enums(LanguageEnum.en);
            Enums enumsFr = new Enums(LanguageEnum.fr);

            StringBuilder sb = new StringBuilder();
            FileInfo fiDLL = new FileInfo(enumsFiles.CSSPEnumsDLL);
            FileInfo fi = new FileInfo(enumsFiles.BaseDir + @"CSSPEnums\CSSPEnums\EnumsWithHelp.cs");
            FileInfo fiModels = new FileInfo(enumsFiles.BaseDir + @"CSSPModels\CSSPModels\bin\Debug\CSSPModels.dll");
            FileInfo fiServices = new FileInfo(enumsFiles.BaseDir + @"CSSPServices\CSSPServices\bin\Debug\CSSPServices.dll");

            if (!fiDLL.Exists)
            {
                ErrorEvent(new ErrorEventArgs("File does not exist [" + fiDLL.FullName + "]"));
                return;
            }
            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();

            if (!fiModels.Exists)
            {
                ErrorEvent(new ErrorEventArgs("File does not exist [" + fiModels.FullName + "]"));
                return;
            }
            var importAssemblyModels = Assembly.LoadFile(fiModels.FullName);
            Type[] typesModels = importAssemblyModels.GetTypes();

            if (!fiServices.Exists)
            {
                ErrorEvent(new ErrorEventArgs("File does not exist [" + fiServices.FullName + "]"));
                return;
            }
            var importAssemblyServices = Assembly.LoadFile(fiServices.FullName);
            Type[] typesServices = importAssemblyModels.GetTypes();

            #region Top part
            sb.AppendLine(@"using System;");
            sb.AppendLine(@"using System.Collections.Generic;");
            sb.AppendLine(@"using System.Linq;");
            sb.AppendLine(@"using System.Text;");
            sb.AppendLine(@"using System.Threading.Tasks;");
            sb.AppendLine(@"using System.Globalization;");
            sb.AppendLine(@"using System.Threading;");
            sb.AppendLine(@"using System.Net;");
            sb.AppendLine(@"");
            sb.AppendLine(@"namespace CSSPEnums");
            sb.AppendLine(@"{");
            sb.AppendLine(@"    /// <summary>");
            sb.AppendLine(@"    /// > Class holding all Enum used in CSSP applications and methods used to get text associated with the Enum in both languages [en, fr]");
            sb.AppendLine(@"    /// ");
            sb.AppendLine(@"    /// > Used by ");
            sb.AppendLine(@"    /// > * <c>[CSSPModels] (CSSPModels.html)</c>");
            sb.AppendLine(@"    /// > * <c>[CSSPServices] (CSSPServices.html)</c>");
            sb.AppendLine(@"    /// </summary>");
            sb.AppendLine(@"    public partial class Enums");
            sb.AppendLine(@"    {");
            sb.AppendLine(@"        #region Variables");
            sb.AppendLine(@"        #endregion Variables");
            sb.AppendLine(@"");
            sb.AppendLine(@"        #region Properties");
            sb.AppendLine(@"        /// <summary>");
            sb.AppendLine(@"        /// > Allowable values are [en, fr]");
            sb.AppendLine(@"        /// </summary>");
            sb.AppendLine(@"        public LanguageEnum LanguageRequest { get; set; }");
            sb.AppendLine(@"        #endregion Properties");
            sb.AppendLine(@"");
            sb.AppendLine(@"        #region Constructors");
            sb.AppendLine(@"        /// <summary>");
            sb.AppendLine(@"        /// > using [en]");
            sb.AppendLine(@"        /// >");
            sb.AppendLine(@"        /// > <c>CurrentCulture = new CultureInfo(""en-CA"");</c>");
            sb.AppendLine(@"        /// >   ");
            sb.AppendLine(@"        /// > <c>CurrentUICulture = new CultureInfo(""en-CA"");</c>");
            sb.AppendLine(@"        /// >");
            sb.AppendLine(@"        /// > using [fr]");
            sb.AppendLine(@"        /// >");
            sb.AppendLine(@"        /// > <c>CurrentCulture = new CultureInfo(""fr-CA"");</c>");
            sb.AppendLine(@"        /// > ");
            sb.AppendLine(@"        /// > <c>CurrentUICulture = new CultureInfo(""fr-CA"");</c>");
            sb.AppendLine(@"        /// >");
            sb.AppendLine(@"        /// </summary>");
            sb.AppendLine(@"        /// <param name=""LanguageRequest""></param>");
            sb.AppendLine(@"        public Enums(LanguageEnum LanguageRequest)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            this.LanguageRequest = LanguageRequest;");
            sb.AppendLine(@"            if (this.LanguageRequest == LanguageEnum.fr)");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                Thread.CurrentThread.CurrentCulture = new CultureInfo(""fr-CA"");");
            sb.AppendLine(@"                Thread.CurrentThread.CurrentUICulture = new CultureInfo(""fr-CA"");");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"            else");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                Thread.CurrentThread.CurrentCulture = new CultureInfo(""en-CA"");");
            sb.AppendLine(@"                Thread.CurrentThread.CurrentUICulture = new CultureInfo(""en-CA"");");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"        #endregion Construtors");
            sb.AppendLine(@"");
            sb.AppendLine(@"    }");
            #endregion Top part

            foreach (Type type in types)
            {
                if (type.GetTypeInfo().BaseType == typeof(System.Enum))
                {
                    string enumName = type.Name;
                    if (enumName == "PolSourceObsInfoEnum")
                        continue;

                    sb.AppendLine(@"    /// <summary>");

                    foreach (Type typeModels in typesModels)
                    {
                        foreach (PropertyInfo propertyInfo in typeModels.GetProperties())
                        {
                            string PropTypeName = propertyInfo.PropertyType.FullName;
                            if (PropTypeName.StartsWith("System.Nullable"))
                            {
                                PropTypeName = PropTypeName.Substring(PropTypeName.IndexOf("[[") + 2);
                                PropTypeName = PropTypeName.Substring(PropTypeName.IndexOf(".") + 1);
                                PropTypeName = PropTypeName.Substring(0, PropTypeName.IndexOf(","));
                            }
                            if (PropTypeName == type.Name)
                            {
                                string TypeNameModels = typeModels.Name;
                                sb.AppendLine(@"    /// > Used by: <c>[CSSPModels." + typeModels.Name + "." + propertyInfo.Name + "] (CSSPModels." + typeModels.Name + @".html#CSSPModels_" + typeModels.Name + "_" + propertyInfo.Name + ") </c>");
                                sb.AppendLine(@"    /// >");
                            }
                        }
                    }

                    sb.AppendLine(@"    /// </summary>");
                    sb.AppendLine(@"    /// <remarks>");
                    sb.AppendLine(@"    /// <code>");
                    sb.AppendLine(@"    ///     public enum " + enumName + "");
                    sb.AppendLine(@"    ///     {");
                    foreach (FieldInfo fieldInfo in type.GetFields())
                    {
                        if (fieldInfo.FieldType.GetTypeInfo().BaseType == typeof(System.Enum))
                        {
                            string fName = fieldInfo.Name;
                            sb.AppendLine(@"    ///         " + fName + " = " + ((int)fieldInfo.GetValue(fName)).ToString() + ",");
                        }
                    }
                    sb.AppendLine(@"    ///     }");
                    sb.AppendLine(@"    /// </code>");
                    sb.AppendLine(@"    /// </remarks>");
                    sb.AppendLine(@"    public enum " + enumName);
                    sb.AppendLine(@"    {");
                    foreach (FieldInfo fieldInfo in type.GetFields())
                    {
                        if (fieldInfo.FieldType.GetTypeInfo().BaseType == typeof(System.Enum))
                        {
                            string fName = fieldInfo.Name;
                            int IntVal = (int)fieldInfo.GetValue(fieldInfo.Name);

                            sb.AppendLine(@"        /// <summary>");
                            sb.AppendLine(@"        /// " + IntVal.ToString() + " -- en [" + enumsEn.GetResValueForTypeAndField(type, IntVal) + "] ---- fr [" + enumsFr.GetResValueForTypeAndField(type, IntVal) + "]");
                            sb.AppendLine(@"        /// </summary>");
                            sb.AppendLine(@"        " + fName + " = " + IntVal.ToString() + ",");
                        }
                    }
                    sb.AppendLine(@"    }");
                }
            }
            sb.AppendLine(@"");
            sb.AppendLine(@"    /// <summary>");
            sb.AppendLine(@"    /// Class representing the Enumeration ID and Text in allowable languages [en, fr]");
            sb.AppendLine(@"    /// </summary>");
            sb.AppendLine(@"    public class EnumIDAndText");
            sb.AppendLine(@"    {");
            sb.AppendLine(@"        /// <summary>");
            sb.AppendLine(@"        /// Enumeration ID");
            sb.AppendLine(@"        /// </summary>");
            sb.AppendLine(@"        public int EnumID { get; set; }");
            sb.AppendLine(@"        /// <summary>");
            sb.AppendLine(@"        /// Enumeration Text in allowable languages [en, fr]");
            sb.AppendLine(@"        /// </summary>");
            sb.AppendLine(@"        public string EnumText { get; set; }");
            sb.AppendLine(@"    }");
            sb.AppendLine(@"");
            sb.AppendLine(@"}");

            using (StreamWriter sw = fi.CreateText())
            {
                sw.Write(sb.ToString());
            }
            StatusEvent(new StatusEventArgs("Created [" + fi.FullName + "] ..."));
        }
    }
}
