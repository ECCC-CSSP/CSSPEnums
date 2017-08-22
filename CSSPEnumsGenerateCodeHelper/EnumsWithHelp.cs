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
            FileInfo fiCSSPEnumsDLL = new FileInfo(enumsFiles.CSSPEnumsDLL);
            FileInfo fi = new FileInfo(enumsFiles.BaseDir + @"CSSPEnums\CSSPEnums\EnumsWithHelp.cs");
            FileInfo fiCSSPModelsDLL = new FileInfo(enumsFiles.BaseDir + @"CSSPModels\CSSPModels\bin\Debug\CSSPModels.dll");
            FileInfo fiCSSPServicesDLL = new FileInfo(enumsFiles.BaseDir + @"CSSPServices\CSSPServices\bin\Debug\CSSPServices.dll");

            if (!fiCSSPEnumsDLL.Exists)
            {
                ErrorEvent(new ErrorEventArgs("File does not exist [" + fiCSSPEnumsDLL.FullName + "]"));
                return;
            }

            List<DLLTypeInfo> DLLTypeInfoCSSPEnumsList = new List<DLLTypeInfo>();
            if (FillDLLTypeInfoList(fiCSSPEnumsDLL, DLLTypeInfoCSSPEnumsList))
            {
                ErrorEvent(new ErrorEventArgs("Could not read the file [" + fiCSSPEnumsDLL.FullName + "]"));
                return;
            }

            if (!fiCSSPModelsDLL.Exists)
            {
                ErrorEvent(new ErrorEventArgs("File does not exist [" + fiCSSPModelsDLL.FullName + "]"));
                return;
            }
            List<DLLTypeInfo> DLLTypeInfoCSSPModelsList = new List<DLLTypeInfo>();
            if (FillDLLTypeInfoList(fiCSSPModelsDLL, DLLTypeInfoCSSPModelsList))
            {
                ErrorEvent(new ErrorEventArgs("Could not read the file [" + fiCSSPModelsDLL.FullName + "]"));
                return;
            }

            if (!fiCSSPServicesDLL.Exists)
            {
                ErrorEvent(new ErrorEventArgs("File does not exist [" + fiCSSPServicesDLL.FullName + "]"));
                return;
            }
            List<DLLTypeInfo> DLLTypeInfoCSSPServicesList = new List<DLLTypeInfo>();
            if (FillDLLTypeInfoList(fiCSSPServicesDLL, DLLTypeInfoCSSPServicesList))
            {
                ErrorEvent(new ErrorEventArgs("Could not read the file [" + fiCSSPServicesDLL.FullName + "]"));
                return;
            }

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
            sb.AppendLine(@"    /// Class holding all Enum used in CSSP applications and methods used to get text associated with the Enum in both languages [en, fr]");
            sb.AppendLine(@"    /// ");
            sb.AppendLine(@"    /// Used by ");
            sb.AppendLine(@"    /// * <c>[CSSPModels] (CSSPModels.html)</c>");
            sb.AppendLine(@"    /// * <c>[CSSPServices] (CSSPServices.html)</c>");
            sb.AppendLine(@"    /// </summary>");
            sb.AppendLine(@"    public partial class Enums");
            sb.AppendLine(@"    {");
            sb.AppendLine(@"        #region Variables");
            sb.AppendLine(@"        #endregion Variables");
            sb.AppendLine(@"");
            sb.AppendLine(@"        #region Properties");
            sb.AppendLine(@"        /// <summary>");
            sb.AppendLine(@"        /// Allowable values are [en, fr]");
            sb.AppendLine(@"        /// </summary>");
            sb.AppendLine(@"        public LanguageEnum LanguageRequest { get; set; }");
            sb.AppendLine(@"        #endregion Properties");
            sb.AppendLine(@"");
            sb.AppendLine(@"        #region Constructors");
            sb.AppendLine(@"        /// <summary>");
            sb.AppendLine(@"        /// <para>**using [en]**</para>");
            sb.AppendLine(@"        /// ");
            sb.AppendLine(@"        /// <para> <c>CurrentCulture = new CultureInfo(""en-CA"");</c></para>");
            sb.AppendLine(@"        /// ");
            sb.AppendLine(@"        /// <para> <c>CurrentUICulture = new CultureInfo(""en-CA"");</c></para>");
            sb.AppendLine(@"        /// ");
            sb.AppendLine(@"        /// <para>**using [fr]**</para>");
            sb.AppendLine(@"        /// ");
            sb.AppendLine(@"        /// <para> <c>CurrentCulture = new CultureInfo(""fr-CA"");</c></para>");
            sb.AppendLine(@"        /// ");
            sb.AppendLine(@"        /// <para> <c>CurrentUICulture = new CultureInfo(""fr-CA"");</c></para>");
            sb.AppendLine(@"        /// ");
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

            foreach (DLLTypeInfo dllTypeInfoEnums in DLLTypeInfoCSSPEnumsList)
            {
                StatusEvent(new StatusEventArgs("Doing [" + dllTypeInfoEnums.Name + "]"));
                if (dllTypeInfoEnums.IsEnum)
                {
                    if (dllTypeInfoEnums.Name == "PolSourceObsInfoEnum")
                        continue;

                    sb.AppendLine(@"    /// <summary>");

                    StringBuilder sbModels = new StringBuilder();

                    foreach (DLLTypeInfo dllTypeInfoModels in DLLTypeInfoCSSPModelsList)
                    {
                        StatusEvent(new StatusEventArgs("Doing [" + dllTypeInfoEnums.Name + "] [" + dllTypeInfoModels.Name + "]"));

                        foreach (DLLPropertyInfo dllPropertyInfo in dllTypeInfoModels.PropertyInfoList)
                        {
                            string PropTypeName = dllPropertyInfo.PropertyType.FullName;
                            if (PropTypeName.StartsWith("System.Nullable"))
                            {
                                PropTypeName = PropTypeName.Substring(PropTypeName.IndexOf("[[") + 2);
                                PropTypeName = PropTypeName.Substring(PropTypeName.IndexOf(".") + 1);
                                PropTypeName = PropTypeName.Substring(0, PropTypeName.IndexOf(","));
                            }
                            if (PropTypeName == dllTypeInfoEnums.Type.Name)
                            {
                                string TypeNameModels = dllTypeInfoModels.Name;
                                sbModels.Append(@"[" + dllTypeInfoModels.Name + "." + dllPropertyInfo.Name + "] (CSSPModels." + dllTypeInfoModels.Name + @".html#CSSPModels_" + dllTypeInfoModels.Name + "_" + dllPropertyInfo.Name + "), ");
                            }
                        }
                    }

                    if (sbModels.ToString().Length > 0)
                    {
                        sb.AppendLine(@"    /// <para>**Used by CSSPModels:** " + sbModels.ToString() + "</para>");
                    }

                    StringBuilder sbServices = new StringBuilder();

                    foreach (DLLTypeInfo dllTypeInfoServices in DLLTypeInfoCSSPServicesList)
                    {
                        StatusEvent(new StatusEventArgs("Doing [" + dllTypeInfoEnums.Type.Name + "] [" + dllTypeInfoServices.Name + "]"));

                        foreach (DLLMethodInfo dllMethodInfo in dllTypeInfoServices.MethodInfoList)
                        {
                            if (dllMethodInfo.DeclaringTypeName.StartsWith("CSSP"))
                            {
                                try
                                {
                                    StringBuilder sbParamTypeText = new StringBuilder();
                                    bool ShouldShowLink = false;
                                    foreach (DLLParameterInfo dllParameterInfo in dllMethodInfo.ParameterInfoList)
                                    {
                                        if (dllParameterInfo.Name == dllTypeInfoEnums.Name)
                                        {
                                            ShouldShowLink = true;
                                        }
                                        sbParamTypeText.Append(dllParameterInfo.Name + "_");
                                    }
                                    if (ShouldShowLink)
                                    {
                                        sbServices.Append(@"[" + dllTypeInfoServices.Name + "." + dllMethodInfo.Name + "] (CSSPServices." + dllTypeInfoServices.Name + @".html#CSSPServices_" + dllTypeInfoServices.Name + "_" + dllMethodInfo.Name + "_" + sbParamTypeText.ToString().Replace(".", "_").Replace("+", "_") + "), ");
                                    }
                                }
                                catch (Exception ex)
                                {
                                   // nothing
                                }
                            }
                        }
                    }

                    if (sbServices.ToString().Length > 0)
                    {
                        sb.AppendLine(@"    /// <para>**Used by CSSPServices:** " + sbServices.ToString() + "</para>");
                    }

                    sb.AppendLine(@"    /// </summary>");
                    sb.AppendLine(@"    /// <remarks>");
                    sb.AppendLine(@"    /// <code>");
                    sb.AppendLine(@"    ///     public enum " + dllTypeInfoEnums.Type.Name + "");
                    sb.AppendLine(@"    ///     {");
                    foreach (DLLFieldInfo dllFieldInfo in dllTypeInfoEnums.FieldInfoList)
                    {
                        if (dllTypeInfoEnums.IsEnum)
                        {
                            string fName = dllFieldInfo.Name;
                            sb.AppendLine(@"    ///         " + fName + " = " + ((int)dllFieldInfo.FieldInfo.GetValue(fName)).ToString() + ",");
                        }
                    }
                    sb.AppendLine(@"    ///     }");
                    sb.AppendLine(@"    /// </code>");
                    sb.AppendLine(@"    /// </remarks>");
                    sb.AppendLine(@"    public enum " + dllTypeInfoEnums.Type.Name);
                    sb.AppendLine(@"    {");
                    foreach (DLLFieldInfo dllFieldInfo in dllTypeInfoEnums.FieldInfoList)
                    {
                        if (dllTypeInfoEnums.IsEnum)
                        {
                            string fName = dllFieldInfo.Name;
                            int IntVal = (int)dllFieldInfo.FieldInfo.GetValue(dllFieldInfo.Name);

                            sb.AppendLine(@"        /// <summary>");
                            sb.AppendLine(@"        /// " + IntVal.ToString() + " -- en [" + enumsEn.GetResValueForTypeAndID(dllTypeInfoEnums.Type, IntVal) + "] ---- fr [" + enumsFr.GetResValueForTypeAndID(dllTypeInfoEnums.Type, IntVal) + "]");
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
