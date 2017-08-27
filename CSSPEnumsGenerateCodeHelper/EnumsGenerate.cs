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

            if (!fiDLL.Exists)
            {
                ErrorEvent(new ErrorEventArgs("File does not exist [" + fiDLL.FullName + "]"));
                return;
            }

            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();

            StringBuilder sbAllowableTypesText = new StringBuilder();
            foreach (Type type in types)
            {
                if (type.GetTypeInfo().BaseType == typeof(System.Enum))
                {
                    sbAllowableTypesText.Append("<c>[" + type.Name + "] (CSSPEnums." + type.Name + @".html)</c>, ");
                }
            }

            StringBuilder sbAllowablePolSourceObsInfoTypeEnumText = new StringBuilder();
            foreach (Type type in types)
            {
                if (type.GetTypeInfo().BaseType == typeof(System.Enum))
                {
                    if (type.Name == "PolSourceObsInfoTypeEnum")
                    {
                        foreach (FieldInfo fieldInfo in type.GetFields())
                        {
                            if (fieldInfo.FieldType.GetTypeInfo().BaseType == typeof(System.Enum))
                            {
                                sbAllowablePolSourceObsInfoTypeEnumText.Append(fieldInfo.Name + ",");
                            }
                        }
                    }
                }
            }

            sb.AppendLine(@"using CSSPEnums;");
            sb.AppendLine(@"using CSSPEnums.Resources;");
            sb.AppendLine(@"using System;");
            sb.AppendLine(@"using System.Collections.Generic;");
            sb.AppendLine(@"using System.Globalization;");
            sb.AppendLine(@"using System.Linq;");
            sb.AppendLine(@"using System.Net;");
            sb.AppendLine(@"using System.Text;");
            sb.AppendLine(@"using System.Threading;");
            sb.AppendLine(@"using System.Threading.Tasks;");
            sb.AppendLine(@"");
            sb.AppendLine(@"namespace CSSPEnums");
            sb.AppendLine(@"{");
            sb.AppendLine(@"    public partial class Enums");
            sb.AppendLine(@"    {");

            #region Doing Function public EnumTypeOK
            sb.AppendLine(@"        #region Enum Functions public");
            sb.AppendLine(@"        /// <summary>");
            sb.AppendLine(@"        /// <para>**Allowable types:** " + sbAllowableTypesText.ToString() + @"</para>");
            sb.AppendLine(@"        /// </summary>");
            sb.AppendLine(@"        /// <param name=""type"">One of the allowable types (Enum)</param>");
            sb.AppendLine(@"        /// <param name=""intList"">List of nullable IDs representing the enumeration values (int?)</param>");
            sb.AppendLine(@"        /// <returns>Will return empty string if OK otherwise will return the error message</returns>");
            sb.AppendLine(@"        public string EnumTypeListOK(Type type, List<int?> intList)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            string retStr = """";");
            sb.AppendLine(@"");
            sb.AppendLine(@"            foreach (int? ID in intList)");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                retStr = EnumTypeOK(type, ID);");
            sb.AppendLine(@"                if (!string.IsNullOrWhiteSpace(retStr))");
            sb.AppendLine(@"                {");
            sb.AppendLine(@"                    break;");
            sb.AppendLine(@"                }");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"");
            sb.AppendLine(@"            if (string.IsNullOrWhiteSpace(retStr))");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                return """";");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"");
            sb.AppendLine(@"            return string.Format(CSSPEnumsRes._IsRequired, type.Name);");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"        /// <summary>");
            sb.AppendLine(@"        /// <para>**Allowable types:** " + sbAllowableTypesText.ToString() + @"</para>");
            sb.AppendLine(@"        /// </summary>");
            sb.AppendLine(@"        /// <param name=""type"">One of the allowable types (Enum)</param>");
            sb.AppendLine(@"        /// <param name=""ID"">ID representing the enumeration values (int?)</param>");
            sb.AppendLine(@"        /// <returns>Will return empty string if OK otherwise will return the error message</returns>");
            sb.AppendLine(@"        public string EnumTypeOK(Type type, int? ID)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            if (ID == null)");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                return """";");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"");
            sb.AppendLine(@"            if (type.Name == ""BeaufortScaleEnum"")");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                for (int i = -1, count = Enum.GetNames(type).Count() - 1; i < count; i++)");
            sb.AppendLine(@"                {");
            sb.AppendLine(@"                    if (i == ID)");
            sb.AppendLine(@"                    {");
            sb.AppendLine(@"                        return """";");
            sb.AppendLine(@"                    }");
            sb.AppendLine(@"                }");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"            else if (type.Name == ""SampleTypeEnum"")");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                for (int i = 101, count = Enum.GetNames(type).Count() + 100; i < count; i++)");
            sb.AppendLine(@"                {");
            sb.AppendLine(@"                    if (i == ID)");
            sb.AppendLine(@"                    {");
            sb.AppendLine(@"                        return """";");
            sb.AppendLine(@"                    }");
            sb.AppendLine(@"                }");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"            else if (type.Name == ""TVTypeEnum"")");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                for (int i = 0, count = Enum.GetNames(type).Count() + 1; i < count; i++)");
            sb.AppendLine(@"                {");
            sb.AppendLine(@"                    if (i == 32)");
            sb.AppendLine(@"                    {");
            sb.AppendLine(@"                        continue;");
            sb.AppendLine(@"                    }");
            sb.AppendLine(@"                    if (i == ID)");
            sb.AppendLine(@"                    {");
            sb.AppendLine(@"                        return """";");
            sb.AppendLine(@"                    }");
            sb.AppendLine(@"                }");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"            else if (type.Name == ""PolSourceObsInfoEnum"")");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                List<int> PolSourceIntList = Enum.GetValues(typeof(PolSourceObsInfoEnum)).OfType<PolSourceObsInfoEnum>().Select(c => (int)c).ToList();");
            sb.AppendLine(@"                if (PolSourceIntList.Contains((int)ID))");
            sb.AppendLine(@"                {");
            sb.AppendLine(@"                    return """";");
            sb.AppendLine(@"                }");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"            else");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                for (int i = 0, count = Enum.GetNames(type).Count(); i < count; i++)");
            sb.AppendLine(@"                {");
            sb.AppendLine(@"                    if (i == ID)");
            sb.AppendLine(@"                    {");
            sb.AppendLine(@"                        return """";");
            sb.AppendLine(@"                    }");
            sb.AppendLine(@"                }");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"");
            sb.AppendLine(@"            return string.Format(CSSPEnumsRes._IsRequired, type.Name);");
            sb.AppendLine(@"        }");
            #endregion Doing Function public EnumTypeOK

            #region Doing Function public GetEnumTextOrderedList
            sb.AppendLine(@"        /// <summary>");
            sb.AppendLine(@"        /// <para>**Allowable types:** " + sbAllowableTypesText.ToString() + @"</para>");
            sb.AppendLine(@"        /// </summary>");
            sb.AppendLine(@"        /// <param name=""type"">One of the allowable types (Enum)</param>");
            sb.AppendLine(@"        /// <returns>Will return list of EnumIDAndText ordered by the Enum text for one of the allowable languages [en, fr]</returns>");
            sb.AppendLine(@"        public List<EnumIDAndText> GetEnumTextOrderedList(Type type)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            List<EnumIDAndText> enumTextOrderedList = new List<EnumIDAndText>();");
            sb.AppendLine(@"");
            sb.AppendLine(@"            if (type.Name == ""BeaufortScaleEnum"")");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                for (int i = 0, count = Enum.GetNames(type).Count() - 1; i < count; i++)");
            sb.AppendLine(@"                {");
            sb.AppendLine(@"                    enumTextOrderedList.Add(new EnumIDAndText() { EnumID = i, EnumText = GetResValueForTypeAndID(type, i) });");
            sb.AppendLine(@"                }");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"            else if (type.Name == ""SampleTypeEnum"")");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                for (int i = 101, count = Enum.GetNames(type).Count() + 101; i < count; i++)");
            sb.AppendLine(@"                {");
            sb.AppendLine(@"                    enumTextOrderedList.Add(new EnumIDAndText() { EnumID = i, EnumText = GetResValueForTypeAndID(type, i) });");
            sb.AppendLine(@"                }");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"            else");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                for (int i = 1, count = Enum.GetNames(type).Count(); i < count; i++)");
            sb.AppendLine(@"                {");
            sb.AppendLine(@"                    enumTextOrderedList.Add(new EnumIDAndText() { EnumID = i, EnumText = GetResValueForTypeAndID(type, i) });");
            sb.AppendLine(@"                }");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"");
            sb.AppendLine(@"            enumTextOrderedList = (from c in enumTextOrderedList");
            sb.AppendLine(@"                                   orderby c.EnumText");
            sb.AppendLine(@"                                   select c).ToList();");
            sb.AppendLine(@"");
            sb.AppendLine(@"            return enumTextOrderedList;");
            sb.AppendLine(@"        }");
            #endregion Doing Function public GetEnumTextOrderedList

            #region Doing Function public GetResValueForTypeID
            sb.AppendLine(@"        /// <summary>");
            sb.AppendLine(@"        /// <para>**Allowable types:** " + sbAllowableTypesText.ToString() + @"</para>");
            sb.AppendLine(@"        /// <para>**Allowable <c>[PolSourceObsInfoTypeEnum] (CSSPEnums.PolSourceObsInfoTypeEnum.html)</c>:** " + sbAllowablePolSourceObsInfoTypeEnumText.ToString() + @"</para>");
            sb.AppendLine(@"        /// </summary>");
            sb.AppendLine(@"        /// <param name=""type"">One of the allowable types (Enum)</param>");
            sb.AppendLine(@"        /// <param name=""ID"">ID representing the enumeration values (int?)</param>");
            sb.AppendLine(@"        /// <param name=""polSourceObsInfoTypeEnum"">Null or one of the allowable PolSourceObsInfoTypeEnum</param>");
            sb.AppendLine(@"        /// <returns>Will return list of EnumIDAndText ordered by the Enum text for one of the allowable languages [en, fr]</returns>");
            sb.AppendLine(@"        public string GetResValueForTypeAndID(Type type, int? ID, PolSourceObsInfoTypeEnum? polSourceObsInfoTypeEnum = PolSourceObsInfoTypeEnum.Error)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            if (LanguageRequest.ToString() != Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                if (LanguageRequest == LanguageEnum.fr)");
            sb.AppendLine(@"                {");
            sb.AppendLine(@"                    Thread.CurrentThread.CurrentCulture = new CultureInfo(""fr-CA"");");
            sb.AppendLine(@"                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(""fr-CA"");");
            sb.AppendLine(@"                }");
            sb.AppendLine(@"                else");
            sb.AppendLine(@"                {");
            sb.AppendLine(@"                    Thread.CurrentThread.CurrentCulture = new CultureInfo(""en-CA"");");
            sb.AppendLine(@"                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(""en-CA"");");
            sb.AppendLine(@"                }");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"");
            sb.AppendLine(@"            string enumName = type.Name;");
            sb.AppendLine(@"");
            sb.AppendLine(@"            switch (enumName)");
            sb.AppendLine(@"            {");
            foreach (Type type in types)
            {
                if (type.GetTypeInfo().BaseType == typeof(System.Enum))
                {
                    string enumName = type.Name;
                    if (enumName == "PolSourceObsInfoEnum")
                    {
                        sb.AppendLine(@"                case ""PolSourceObsInfoEnum"":");
                        sb.AppendLine(@"                {");
                        sb.AppendLine(@"                    switch (polSourceObsInfoTypeEnum)");
                        sb.AppendLine(@"                    {");
                        sb.AppendLine(@"                        case PolSourceObsInfoTypeEnum.Error:");
                        sb.AppendLine(@"                            return GetEnumText_PolSourceObsInfoEnum((ID == null ? null : (PolSourceObsInfoEnum?)ID));");
                        sb.AppendLine(@"                        case PolSourceObsInfoTypeEnum.Description:");
                        sb.AppendLine(@"                            return GetEnumText_PolSourceObsInfoDescEnum((ID == null ? null : (PolSourceObsInfoEnum?)ID));");
                        sb.AppendLine(@"                        case PolSourceObsInfoTypeEnum.Report:");
                        sb.AppendLine(@"                            return GetEnumText_PolSourceObsInfoReportEnum((ID == null ? null : (PolSourceObsInfoEnum?)ID));");
                        sb.AppendLine(@"                        case PolSourceObsInfoTypeEnum.Text:");
                        sb.AppendLine(@"                            return GetEnumText_PolSourceObsInfoTextEnum((ID == null ? null : (PolSourceObsInfoEnum?)ID));");
                        sb.AppendLine(@"                        case PolSourceObsInfoTypeEnum.Initial:");
                        sb.AppendLine(@"                            return GetEnumText_PolSourceObsInfoInitEnum((ID == null ? null : (PolSourceObsInfoEnum?)ID));");
                        sb.AppendLine(@"                        default:");
                        sb.AppendLine(@"                            return GetEnumText_PolSourceObsInfoEnum((ID == null ? null : (PolSourceObsInfoEnum?)ID));");
                        sb.AppendLine(@"                    }");
                        sb.AppendLine(@"                }");
                    }
                    else
                    {
                        sb.AppendLine(@"                case """ + enumName + @""":");
                        sb.AppendLine(@"                    return GetEnumText_" + enumName + @"((ID == null ? null : (" + enumName + @"?)ID));");
                    }
                }
            }
            sb.AppendLine(@"                default:");
            sb.AppendLine(@"                    return """";");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"        #endregion Function public");
            sb.AppendLine(@"");
            #endregion Doing Function public GetResValueForTypeAndID

            #region Doing Functions private
            sb.AppendLine(@"        #region Functions private");
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
            sb.AppendLine(@"        #endregion Functions private");
            #endregion Doing Functions private

            sb.AppendLine(@"    }");
            sb.AppendLine(@"}");

            using (StreamWriter sw = fi.CreateText())
            {
                sw.Write(sb.ToString());
            }
            StatusTempEvent(new StatusEventArgs("Created [" + fi.FullName + "] ..."));
        }
    }
}
