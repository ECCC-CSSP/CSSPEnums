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
            sb.AppendLine(@"        #region Functions public");
            sb.AppendLine(@"        public string GetResValueForTypeAndField(Type type, FieldInfo fieldInfo)");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            string enumName = type.Name;");
            sb.AppendLine(@"");
            sb.AppendLine(@"            switch (enumName)");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                case ""ActionDBTypeEnum"":");
            sb.AppendLine(@"                    return WebUtility.HtmlEncode(GetEnumText_ActionDBTypeEnum(((ActionDBTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));");
            sb.AppendLine(@"                default:");
            sb.AppendLine(@"                    return """";");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"        #endregion Functions public");
            sb.AppendLine(@"");
            sb.AppendLine(@"    }");
            #endregion Top part

            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();
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
                                //CSSPModels.Address.html#CSSPModels_Address_AddressType
                            }
                        }
                    }

                    sb.AppendLine(@"    /// </summary>");
                    sb.AppendLine(@"    /// <remarks>");
                    sb.AppendLine(@"    /// <code>");
                    sb.AppendLine(@"    ///     public enum ActionDBTypeEnum");
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
                            sb.AppendLine(@"        /// <summary>");
                            sb.AppendLine(@"        /// " + ((int)fieldInfo.GetValue(fName)).ToString() + " -- en [" + enumsEn.GetResValueForTypeAndField(type, fieldInfo) + "] ---- fr [" + enumsFr.GetResValueForTypeAndField(type, fieldInfo) + "]");
                            sb.AppendLine(@"        /// </summary>");
                            sb.AppendLine(@"        " + fName + " = " + ((int)fieldInfo.GetValue(fName)).ToString() + ",");
                        }
                    }
                    sb.AppendLine(@"    }");
                }
            }
            sb.AppendLine(@"");
            sb.AppendLine(@"}");

            using (StreamWriter sw = fi.CreateText())
            {
                sw.Write(sb.ToString());
            }
            StatusEvent(new StatusEventArgs("Created [" + fi.FullName + "] ..."));
        }

        //public string GetResValueForTypeFieldAndLanguage(Type type, FieldInfo fieldInfo, LanguageEnum language)
        //{
        //    Enums enums = new Enums(language);
        //    string enumName = type.Name;

        //    switch (enumName)
        //    {
        //        case "ActionDBTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_ActionDBTypeEnum(((ActionDBTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "AddressTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_AddressTypeEnum(((AddressTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "AerationTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_AerationTypeEnum(((AerationTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "AlarmSystemTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_AlarmSystemTypeEnum(((AlarmSystemTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "AnalyzeMethodEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_AnalyzeMethodEnum(((AnalyzeMethodEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "AppTaskCommandEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_AppTaskCommandEnum(((AppTaskCommandEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "AppTaskStatusEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_AppTaskStatusEnum(((AppTaskStatusEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "BeaufortScaleEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_BeaufortScaleEnum(((BeaufortScaleEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "BoxModelResultTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_BoxModelResultTypeEnum(((BoxModelResultTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "CollectionSystemTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_CollectionSystemTypeEnum(((CollectionSystemTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "ContactTitleEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_ContactTitleEnum(((ContactTitleEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "CSSPWQInputSheetTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_CSSPWQInputSheetTypeEnum(((CSSPWQInputSheetTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "CSSPWQInputTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_CSSPWQInputTypeEnum(((CSSPWQInputTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "DailyOrHourlyDataEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_DailyOrHourlyDataEnum(((DailyOrHourlyDataEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "DatabaseTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_DatabaseTypeEnum(((DatabaseTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "DisinfectionTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_DisinfectionTypeEnum(((DisinfectionTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "EmailTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_EmailTypeEnum(((EmailTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "FacilityTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_FacilityTypeEnum(((FacilityTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "FilePurposeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_FilePurposeEnum(((FilePurposeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "FileStatusEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_FileStatusEnum(((FileStatusEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "FileTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_FileTypeEnum(((FileTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "InfrastructureTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_InfrastructureTypeEnum(((InfrastructureTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "KMZActionEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_KMZActionEnum(((KMZActionEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "LaboratoryEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_LaboratoryEnum(((LaboratoryEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "LabSheetStatusEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_LabSheetStatusEnum(((LabSheetStatusEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "LabSheetTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_LabSheetTypeEnum(((LabSheetTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "LanguageEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_LanguageEnum(((LanguageEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "LogCommandEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_LogCommandEnum(((LogCommandEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "MapInfoDrawTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_MapInfoDrawTypeEnum(((MapInfoDrawTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "MikeBoundaryConditionLevelOrVelocityEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_MikeBoundaryConditionLevelOrVelocityEnum(((MikeBoundaryConditionLevelOrVelocityEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "MikeScenarioSpecialResultKMLTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_MikeScenarioSpecialResultKMLTypeEnum(((MikeScenarioSpecialResultKMLTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "MWQMSiteLatestClassificationEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_MWQMSiteLatestClassificationEnum(((MWQMSiteLatestClassificationEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "PolSourceInactiveReasonEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_PolSourceInactiveReasonEnum(((PolSourceInactiveReasonEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "PolSourceIssueRiskEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_PolSourceIssueRiskEnum(((PolSourceIssueRiskEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "PreliminaryTreatmentTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_PreliminaryTreatmentTypeEnum(((PreliminaryTreatmentTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "PrimaryTreatmentTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_PrimaryTreatmentTypeEnum(((PrimaryTreatmentTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "ReportConditionEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_ReportConditionEnum(((ReportConditionEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "ReportFieldTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_ReportFieldTypeEnum(((ReportFieldTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "ReportFileTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_ReportFileTypeEnum(((ReportFileTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "ReportFormatingDateEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_ReportFormatingDateEnum(((ReportFormatingDateEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "ReportFormatingNumberEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_ReportFormatingNumberEnum(((ReportFormatingNumberEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "ReportSortingEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_ReportSortingEnum(((ReportSortingEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "ReportTreeNodeSubTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_ReportTreeNodeSubTypeEnum(((ReportTreeNodeSubTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "ReportTreeNodeTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_ReportTreeNodeTypeEnum(((ReportTreeNodeTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "SameDayNextDayEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_SameDayNextDayEnum(((SameDayNextDayEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "SampleMatrixEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_SampleMatrixEnum(((SampleMatrixEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "SampleStatusEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_SampleStatusEnum(((SampleStatusEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "SampleTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_SampleTypeEnum(((SampleTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "SamplingPlanTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_SamplingPlanTypeEnum(((SamplingPlanTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "ScenarioStatusEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_ScenarioStatusEnum(((ScenarioStatusEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "SearchTagEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_SearchTagEnum(((SearchTagEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "SecondaryTreatmentTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_SecondaryTreatmentTypeEnum(((SecondaryTreatmentTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "SiteTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_SiteTypeEnum(((SiteTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "SpecialTableTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_SpecialTableTypeEnum(((SpecialTableTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "StorageDataTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_StorageDataTypeEnum(((StorageDataTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "StreetTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_StreetTypeEnum(((StreetTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "TelTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_TelTypeEnum(((TelTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "TertiaryTreatmentTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_TertiaryTreatmentTypeEnum(((TertiaryTreatmentTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "TideDataTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_TideDataTypeEnum(((TideDataTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "TideTextEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_TideTextEnum(((TideTextEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "TranslationStatusEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_TranslationStatusEnum(((TranslationStatusEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "TreatmentTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_TreatmentTypeEnum(((TreatmentTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "TVAuthEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_TVAuthEnum(((TVAuthEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "TVTypeEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_TVTypeEnum(((TVTypeEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        case "WebTideDataSetEnum":
        //            return WebUtility.HtmlEncode(enums.GetEnumText_WebTideDataSetEnum(((WebTideDataSetEnum)(int)fieldInfo.GetValue(fieldInfo.Name))));
        //        default:
        //            return "";
        //    }
        //}
    }
}
