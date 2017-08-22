using CSSPEnums;
using CSSPEnums.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSSPEnums
{
    public partial class Enums
    {
        #region Enum Functions public
        /// <summary>
        /// <para>**Allowable types:** <c>[ActionDBTypeEnum] (CSSPEnums.ActionDBTypeEnum.html)</c>, <c>[AddressTypeEnum] (CSSPEnums.AddressTypeEnum.html)</c>, <c>[AerationTypeEnum] (CSSPEnums.AerationTypeEnum.html)</c>, <c>[AlarmSystemTypeEnum] (CSSPEnums.AlarmSystemTypeEnum.html)</c>, <c>[AnalyzeMethodEnum] (CSSPEnums.AnalyzeMethodEnum.html)</c>, <c>[AppTaskCommandEnum] (CSSPEnums.AppTaskCommandEnum.html)</c>, <c>[AppTaskStatusEnum] (CSSPEnums.AppTaskStatusEnum.html)</c>, <c>[BeaufortScaleEnum] (CSSPEnums.BeaufortScaleEnum.html)</c>, <c>[BoxModelResultTypeEnum] (CSSPEnums.BoxModelResultTypeEnum.html)</c>, <c>[CollectionSystemTypeEnum] (CSSPEnums.CollectionSystemTypeEnum.html)</c>, <c>[ContactTitleEnum] (CSSPEnums.ContactTitleEnum.html)</c>, <c>[CSSPWQInputSheetTypeEnum] (CSSPEnums.CSSPWQInputSheetTypeEnum.html)</c>, <c>[CSSPWQInputTypeEnum] (CSSPEnums.CSSPWQInputTypeEnum.html)</c>, <c>[DailyOrHourlyDataEnum] (CSSPEnums.DailyOrHourlyDataEnum.html)</c>, <c>[DatabaseTypeEnum] (CSSPEnums.DatabaseTypeEnum.html)</c>, <c>[DisinfectionTypeEnum] (CSSPEnums.DisinfectionTypeEnum.html)</c>, <c>[EmailTypeEnum] (CSSPEnums.EmailTypeEnum.html)</c>, <c>[FacilityTypeEnum] (CSSPEnums.FacilityTypeEnum.html)</c>, <c>[FilePurposeEnum] (CSSPEnums.FilePurposeEnum.html)</c>, <c>[FileStatusEnum] (CSSPEnums.FileStatusEnum.html)</c>, <c>[FileTypeEnum] (CSSPEnums.FileTypeEnum.html)</c>, <c>[InfrastructureTypeEnum] (CSSPEnums.InfrastructureTypeEnum.html)</c>, <c>[KMZActionEnum] (CSSPEnums.KMZActionEnum.html)</c>, <c>[LaboratoryEnum] (CSSPEnums.LaboratoryEnum.html)</c>, <c>[LabSheetStatusEnum] (CSSPEnums.LabSheetStatusEnum.html)</c>, <c>[LabSheetTypeEnum] (CSSPEnums.LabSheetTypeEnum.html)</c>, <c>[LanguageEnum] (CSSPEnums.LanguageEnum.html)</c>, <c>[LogCommandEnum] (CSSPEnums.LogCommandEnum.html)</c>, <c>[MapInfoDrawTypeEnum] (CSSPEnums.MapInfoDrawTypeEnum.html)</c>, <c>[MikeBoundaryConditionLevelOrVelocityEnum] (CSSPEnums.MikeBoundaryConditionLevelOrVelocityEnum.html)</c>, <c>[MikeScenarioSpecialResultKMLTypeEnum] (CSSPEnums.MikeScenarioSpecialResultKMLTypeEnum.html)</c>, <c>[MWQMSiteLatestClassificationEnum] (CSSPEnums.MWQMSiteLatestClassificationEnum.html)</c>, <c>[PolSourceInactiveReasonEnum] (CSSPEnums.PolSourceInactiveReasonEnum.html)</c>, <c>[PolSourceIssueRiskEnum] (CSSPEnums.PolSourceIssueRiskEnum.html)</c>, <c>[PolSourceObsInfoTypeEnum] (CSSPEnums.PolSourceObsInfoTypeEnum.html)</c>, <c>[PreliminaryTreatmentTypeEnum] (CSSPEnums.PreliminaryTreatmentTypeEnum.html)</c>, <c>[PrimaryTreatmentTypeEnum] (CSSPEnums.PrimaryTreatmentTypeEnum.html)</c>, <c>[ReportConditionEnum] (CSSPEnums.ReportConditionEnum.html)</c>, <c>[ReportFieldTypeEnum] (CSSPEnums.ReportFieldTypeEnum.html)</c>, <c>[ReportFileTypeEnum] (CSSPEnums.ReportFileTypeEnum.html)</c>, <c>[ReportFormatingDateEnum] (CSSPEnums.ReportFormatingDateEnum.html)</c>, <c>[ReportFormatingNumberEnum] (CSSPEnums.ReportFormatingNumberEnum.html)</c>, <c>[ReportSortingEnum] (CSSPEnums.ReportSortingEnum.html)</c>, <c>[ReportTreeNodeSubTypeEnum] (CSSPEnums.ReportTreeNodeSubTypeEnum.html)</c>, <c>[ReportTreeNodeTypeEnum] (CSSPEnums.ReportTreeNodeTypeEnum.html)</c>, <c>[SameDayNextDayEnum] (CSSPEnums.SameDayNextDayEnum.html)</c>, <c>[SampleMatrixEnum] (CSSPEnums.SampleMatrixEnum.html)</c>, <c>[SampleStatusEnum] (CSSPEnums.SampleStatusEnum.html)</c>, <c>[SampleTypeEnum] (CSSPEnums.SampleTypeEnum.html)</c>, <c>[SamplingPlanTypeEnum] (CSSPEnums.SamplingPlanTypeEnum.html)</c>, <c>[ScenarioStatusEnum] (CSSPEnums.ScenarioStatusEnum.html)</c>, <c>[SearchTagEnum] (CSSPEnums.SearchTagEnum.html)</c>, <c>[SecondaryTreatmentTypeEnum] (CSSPEnums.SecondaryTreatmentTypeEnum.html)</c>, <c>[SiteTypeEnum] (CSSPEnums.SiteTypeEnum.html)</c>, <c>[SpecialTableTypeEnum] (CSSPEnums.SpecialTableTypeEnum.html)</c>, <c>[StorageDataTypeEnum] (CSSPEnums.StorageDataTypeEnum.html)</c>, <c>[StreetTypeEnum] (CSSPEnums.StreetTypeEnum.html)</c>, <c>[TelTypeEnum] (CSSPEnums.TelTypeEnum.html)</c>, <c>[TertiaryTreatmentTypeEnum] (CSSPEnums.TertiaryTreatmentTypeEnum.html)</c>, <c>[TideDataTypeEnum] (CSSPEnums.TideDataTypeEnum.html)</c>, <c>[TideTextEnum] (CSSPEnums.TideTextEnum.html)</c>, <c>[TranslationStatusEnum] (CSSPEnums.TranslationStatusEnum.html)</c>, <c>[TreatmentTypeEnum] (CSSPEnums.TreatmentTypeEnum.html)</c>, <c>[TVAuthEnum] (CSSPEnums.TVAuthEnum.html)</c>, <c>[TVTypeEnum] (CSSPEnums.TVTypeEnum.html)</c>, <c>[WebTideDataSetEnum] (CSSPEnums.WebTideDataSetEnum.html)</c>, <c>[PolSourceObsInfoEnum] (CSSPEnums.PolSourceObsInfoEnum.html)</c>, </para>
        /// </summary>
        /// <param name="type">One of the allowable types (Enum)</param>
        /// <param name="intList">List of nullable IDs representing the enumeration values (int?)</param>
        /// <returns>Will return empty string if OK otherwise will return the error message</returns>
        public string EnumTypeListOK(Type type, List<int?> intList)
        {
            string retStr = "";

            foreach (int? ID in intList)
            {
                retStr = EnumTypeOK(type, ID);
                if (!string.IsNullOrWhiteSpace(retStr))
                {
                    break;
                }
            }

            if (string.IsNullOrWhiteSpace(retStr))
            {
                return "";
            }

            return string.Format(CSSPEnumsRes._IsRequired, type.Name);
        }
        /// <summary>
        /// <para>**Allowable types:** <c>[ActionDBTypeEnum] (CSSPEnums.ActionDBTypeEnum.html)</c>, <c>[AddressTypeEnum] (CSSPEnums.AddressTypeEnum.html)</c>, <c>[AerationTypeEnum] (CSSPEnums.AerationTypeEnum.html)</c>, <c>[AlarmSystemTypeEnum] (CSSPEnums.AlarmSystemTypeEnum.html)</c>, <c>[AnalyzeMethodEnum] (CSSPEnums.AnalyzeMethodEnum.html)</c>, <c>[AppTaskCommandEnum] (CSSPEnums.AppTaskCommandEnum.html)</c>, <c>[AppTaskStatusEnum] (CSSPEnums.AppTaskStatusEnum.html)</c>, <c>[BeaufortScaleEnum] (CSSPEnums.BeaufortScaleEnum.html)</c>, <c>[BoxModelResultTypeEnum] (CSSPEnums.BoxModelResultTypeEnum.html)</c>, <c>[CollectionSystemTypeEnum] (CSSPEnums.CollectionSystemTypeEnum.html)</c>, <c>[ContactTitleEnum] (CSSPEnums.ContactTitleEnum.html)</c>, <c>[CSSPWQInputSheetTypeEnum] (CSSPEnums.CSSPWQInputSheetTypeEnum.html)</c>, <c>[CSSPWQInputTypeEnum] (CSSPEnums.CSSPWQInputTypeEnum.html)</c>, <c>[DailyOrHourlyDataEnum] (CSSPEnums.DailyOrHourlyDataEnum.html)</c>, <c>[DatabaseTypeEnum] (CSSPEnums.DatabaseTypeEnum.html)</c>, <c>[DisinfectionTypeEnum] (CSSPEnums.DisinfectionTypeEnum.html)</c>, <c>[EmailTypeEnum] (CSSPEnums.EmailTypeEnum.html)</c>, <c>[FacilityTypeEnum] (CSSPEnums.FacilityTypeEnum.html)</c>, <c>[FilePurposeEnum] (CSSPEnums.FilePurposeEnum.html)</c>, <c>[FileStatusEnum] (CSSPEnums.FileStatusEnum.html)</c>, <c>[FileTypeEnum] (CSSPEnums.FileTypeEnum.html)</c>, <c>[InfrastructureTypeEnum] (CSSPEnums.InfrastructureTypeEnum.html)</c>, <c>[KMZActionEnum] (CSSPEnums.KMZActionEnum.html)</c>, <c>[LaboratoryEnum] (CSSPEnums.LaboratoryEnum.html)</c>, <c>[LabSheetStatusEnum] (CSSPEnums.LabSheetStatusEnum.html)</c>, <c>[LabSheetTypeEnum] (CSSPEnums.LabSheetTypeEnum.html)</c>, <c>[LanguageEnum] (CSSPEnums.LanguageEnum.html)</c>, <c>[LogCommandEnum] (CSSPEnums.LogCommandEnum.html)</c>, <c>[MapInfoDrawTypeEnum] (CSSPEnums.MapInfoDrawTypeEnum.html)</c>, <c>[MikeBoundaryConditionLevelOrVelocityEnum] (CSSPEnums.MikeBoundaryConditionLevelOrVelocityEnum.html)</c>, <c>[MikeScenarioSpecialResultKMLTypeEnum] (CSSPEnums.MikeScenarioSpecialResultKMLTypeEnum.html)</c>, <c>[MWQMSiteLatestClassificationEnum] (CSSPEnums.MWQMSiteLatestClassificationEnum.html)</c>, <c>[PolSourceInactiveReasonEnum] (CSSPEnums.PolSourceInactiveReasonEnum.html)</c>, <c>[PolSourceIssueRiskEnum] (CSSPEnums.PolSourceIssueRiskEnum.html)</c>, <c>[PolSourceObsInfoTypeEnum] (CSSPEnums.PolSourceObsInfoTypeEnum.html)</c>, <c>[PreliminaryTreatmentTypeEnum] (CSSPEnums.PreliminaryTreatmentTypeEnum.html)</c>, <c>[PrimaryTreatmentTypeEnum] (CSSPEnums.PrimaryTreatmentTypeEnum.html)</c>, <c>[ReportConditionEnum] (CSSPEnums.ReportConditionEnum.html)</c>, <c>[ReportFieldTypeEnum] (CSSPEnums.ReportFieldTypeEnum.html)</c>, <c>[ReportFileTypeEnum] (CSSPEnums.ReportFileTypeEnum.html)</c>, <c>[ReportFormatingDateEnum] (CSSPEnums.ReportFormatingDateEnum.html)</c>, <c>[ReportFormatingNumberEnum] (CSSPEnums.ReportFormatingNumberEnum.html)</c>, <c>[ReportSortingEnum] (CSSPEnums.ReportSortingEnum.html)</c>, <c>[ReportTreeNodeSubTypeEnum] (CSSPEnums.ReportTreeNodeSubTypeEnum.html)</c>, <c>[ReportTreeNodeTypeEnum] (CSSPEnums.ReportTreeNodeTypeEnum.html)</c>, <c>[SameDayNextDayEnum] (CSSPEnums.SameDayNextDayEnum.html)</c>, <c>[SampleMatrixEnum] (CSSPEnums.SampleMatrixEnum.html)</c>, <c>[SampleStatusEnum] (CSSPEnums.SampleStatusEnum.html)</c>, <c>[SampleTypeEnum] (CSSPEnums.SampleTypeEnum.html)</c>, <c>[SamplingPlanTypeEnum] (CSSPEnums.SamplingPlanTypeEnum.html)</c>, <c>[ScenarioStatusEnum] (CSSPEnums.ScenarioStatusEnum.html)</c>, <c>[SearchTagEnum] (CSSPEnums.SearchTagEnum.html)</c>, <c>[SecondaryTreatmentTypeEnum] (CSSPEnums.SecondaryTreatmentTypeEnum.html)</c>, <c>[SiteTypeEnum] (CSSPEnums.SiteTypeEnum.html)</c>, <c>[SpecialTableTypeEnum] (CSSPEnums.SpecialTableTypeEnum.html)</c>, <c>[StorageDataTypeEnum] (CSSPEnums.StorageDataTypeEnum.html)</c>, <c>[StreetTypeEnum] (CSSPEnums.StreetTypeEnum.html)</c>, <c>[TelTypeEnum] (CSSPEnums.TelTypeEnum.html)</c>, <c>[TertiaryTreatmentTypeEnum] (CSSPEnums.TertiaryTreatmentTypeEnum.html)</c>, <c>[TideDataTypeEnum] (CSSPEnums.TideDataTypeEnum.html)</c>, <c>[TideTextEnum] (CSSPEnums.TideTextEnum.html)</c>, <c>[TranslationStatusEnum] (CSSPEnums.TranslationStatusEnum.html)</c>, <c>[TreatmentTypeEnum] (CSSPEnums.TreatmentTypeEnum.html)</c>, <c>[TVAuthEnum] (CSSPEnums.TVAuthEnum.html)</c>, <c>[TVTypeEnum] (CSSPEnums.TVTypeEnum.html)</c>, <c>[WebTideDataSetEnum] (CSSPEnums.WebTideDataSetEnum.html)</c>, <c>[PolSourceObsInfoEnum] (CSSPEnums.PolSourceObsInfoEnum.html)</c>, </para>
        /// </summary>
        /// <param name="type">One of the allowable types (Enum)</param>
        /// <param name="ID">ID representing the enumeration values (int?)</param>
        /// <returns>Will return empty string if OK otherwise will return the error message</returns>
        public string EnumTypeOK(Type type, int? ID)
        {
            if (ID == null)
            {
                return "";
            }

            if (type.Name == "BeaufortScaleEnum")
            {
                for (int i = -1, count = Enum.GetNames(type).Count() - 1; i < count; i++)
                {
                    if (i == ID)
                    {
                        return "";
                    }
                }
            }
            else if (type.Name == "SampleTypeEnum")
            {
                for (int i = 101, count = Enum.GetNames(type).Count() + 100; i < count; i++)
                {
                    if (i == ID)
                    {
                        return "";
                    }
                }
            }
            else if (type.Name == "TVTypeEnum")
            {
                for (int i = 0, count = Enum.GetNames(type).Count() + 1; i < count; i++)
                {
                    if (i == 32)
                    {
                        continue;
                    }
                    if (i == ID)
                    {
                        return "";
                    }
                }
            }
            else if (type.Name == "PolSourceObsInfoEnum")
            {
                List<int> PolSourceIntList = Enum.GetValues(typeof(PolSourceObsInfoEnum)).OfType<PolSourceObsInfoEnum>().Select(c => (int)c).ToList();
                if (PolSourceIntList.Contains((int)ID))
                {
                    return "";
                }
            }
            else
            {
                for (int i = 0, count = Enum.GetNames(type).Count(); i < count; i++)
                {
                    if (i == ID)
                    {
                        return "";
                    }
                }
            }

            return string.Format(CSSPEnumsRes._IsRequired, type.Name);
        }
        /// <summary>
        /// <para>**Allowable types:** <c>[ActionDBTypeEnum] (CSSPEnums.ActionDBTypeEnum.html)</c>, <c>[AddressTypeEnum] (CSSPEnums.AddressTypeEnum.html)</c>, <c>[AerationTypeEnum] (CSSPEnums.AerationTypeEnum.html)</c>, <c>[AlarmSystemTypeEnum] (CSSPEnums.AlarmSystemTypeEnum.html)</c>, <c>[AnalyzeMethodEnum] (CSSPEnums.AnalyzeMethodEnum.html)</c>, <c>[AppTaskCommandEnum] (CSSPEnums.AppTaskCommandEnum.html)</c>, <c>[AppTaskStatusEnum] (CSSPEnums.AppTaskStatusEnum.html)</c>, <c>[BeaufortScaleEnum] (CSSPEnums.BeaufortScaleEnum.html)</c>, <c>[BoxModelResultTypeEnum] (CSSPEnums.BoxModelResultTypeEnum.html)</c>, <c>[CollectionSystemTypeEnum] (CSSPEnums.CollectionSystemTypeEnum.html)</c>, <c>[ContactTitleEnum] (CSSPEnums.ContactTitleEnum.html)</c>, <c>[CSSPWQInputSheetTypeEnum] (CSSPEnums.CSSPWQInputSheetTypeEnum.html)</c>, <c>[CSSPWQInputTypeEnum] (CSSPEnums.CSSPWQInputTypeEnum.html)</c>, <c>[DailyOrHourlyDataEnum] (CSSPEnums.DailyOrHourlyDataEnum.html)</c>, <c>[DatabaseTypeEnum] (CSSPEnums.DatabaseTypeEnum.html)</c>, <c>[DisinfectionTypeEnum] (CSSPEnums.DisinfectionTypeEnum.html)</c>, <c>[EmailTypeEnum] (CSSPEnums.EmailTypeEnum.html)</c>, <c>[FacilityTypeEnum] (CSSPEnums.FacilityTypeEnum.html)</c>, <c>[FilePurposeEnum] (CSSPEnums.FilePurposeEnum.html)</c>, <c>[FileStatusEnum] (CSSPEnums.FileStatusEnum.html)</c>, <c>[FileTypeEnum] (CSSPEnums.FileTypeEnum.html)</c>, <c>[InfrastructureTypeEnum] (CSSPEnums.InfrastructureTypeEnum.html)</c>, <c>[KMZActionEnum] (CSSPEnums.KMZActionEnum.html)</c>, <c>[LaboratoryEnum] (CSSPEnums.LaboratoryEnum.html)</c>, <c>[LabSheetStatusEnum] (CSSPEnums.LabSheetStatusEnum.html)</c>, <c>[LabSheetTypeEnum] (CSSPEnums.LabSheetTypeEnum.html)</c>, <c>[LanguageEnum] (CSSPEnums.LanguageEnum.html)</c>, <c>[LogCommandEnum] (CSSPEnums.LogCommandEnum.html)</c>, <c>[MapInfoDrawTypeEnum] (CSSPEnums.MapInfoDrawTypeEnum.html)</c>, <c>[MikeBoundaryConditionLevelOrVelocityEnum] (CSSPEnums.MikeBoundaryConditionLevelOrVelocityEnum.html)</c>, <c>[MikeScenarioSpecialResultKMLTypeEnum] (CSSPEnums.MikeScenarioSpecialResultKMLTypeEnum.html)</c>, <c>[MWQMSiteLatestClassificationEnum] (CSSPEnums.MWQMSiteLatestClassificationEnum.html)</c>, <c>[PolSourceInactiveReasonEnum] (CSSPEnums.PolSourceInactiveReasonEnum.html)</c>, <c>[PolSourceIssueRiskEnum] (CSSPEnums.PolSourceIssueRiskEnum.html)</c>, <c>[PolSourceObsInfoTypeEnum] (CSSPEnums.PolSourceObsInfoTypeEnum.html)</c>, <c>[PreliminaryTreatmentTypeEnum] (CSSPEnums.PreliminaryTreatmentTypeEnum.html)</c>, <c>[PrimaryTreatmentTypeEnum] (CSSPEnums.PrimaryTreatmentTypeEnum.html)</c>, <c>[ReportConditionEnum] (CSSPEnums.ReportConditionEnum.html)</c>, <c>[ReportFieldTypeEnum] (CSSPEnums.ReportFieldTypeEnum.html)</c>, <c>[ReportFileTypeEnum] (CSSPEnums.ReportFileTypeEnum.html)</c>, <c>[ReportFormatingDateEnum] (CSSPEnums.ReportFormatingDateEnum.html)</c>, <c>[ReportFormatingNumberEnum] (CSSPEnums.ReportFormatingNumberEnum.html)</c>, <c>[ReportSortingEnum] (CSSPEnums.ReportSortingEnum.html)</c>, <c>[ReportTreeNodeSubTypeEnum] (CSSPEnums.ReportTreeNodeSubTypeEnum.html)</c>, <c>[ReportTreeNodeTypeEnum] (CSSPEnums.ReportTreeNodeTypeEnum.html)</c>, <c>[SameDayNextDayEnum] (CSSPEnums.SameDayNextDayEnum.html)</c>, <c>[SampleMatrixEnum] (CSSPEnums.SampleMatrixEnum.html)</c>, <c>[SampleStatusEnum] (CSSPEnums.SampleStatusEnum.html)</c>, <c>[SampleTypeEnum] (CSSPEnums.SampleTypeEnum.html)</c>, <c>[SamplingPlanTypeEnum] (CSSPEnums.SamplingPlanTypeEnum.html)</c>, <c>[ScenarioStatusEnum] (CSSPEnums.ScenarioStatusEnum.html)</c>, <c>[SearchTagEnum] (CSSPEnums.SearchTagEnum.html)</c>, <c>[SecondaryTreatmentTypeEnum] (CSSPEnums.SecondaryTreatmentTypeEnum.html)</c>, <c>[SiteTypeEnum] (CSSPEnums.SiteTypeEnum.html)</c>, <c>[SpecialTableTypeEnum] (CSSPEnums.SpecialTableTypeEnum.html)</c>, <c>[StorageDataTypeEnum] (CSSPEnums.StorageDataTypeEnum.html)</c>, <c>[StreetTypeEnum] (CSSPEnums.StreetTypeEnum.html)</c>, <c>[TelTypeEnum] (CSSPEnums.TelTypeEnum.html)</c>, <c>[TertiaryTreatmentTypeEnum] (CSSPEnums.TertiaryTreatmentTypeEnum.html)</c>, <c>[TideDataTypeEnum] (CSSPEnums.TideDataTypeEnum.html)</c>, <c>[TideTextEnum] (CSSPEnums.TideTextEnum.html)</c>, <c>[TranslationStatusEnum] (CSSPEnums.TranslationStatusEnum.html)</c>, <c>[TreatmentTypeEnum] (CSSPEnums.TreatmentTypeEnum.html)</c>, <c>[TVAuthEnum] (CSSPEnums.TVAuthEnum.html)</c>, <c>[TVTypeEnum] (CSSPEnums.TVTypeEnum.html)</c>, <c>[WebTideDataSetEnum] (CSSPEnums.WebTideDataSetEnum.html)</c>, <c>[PolSourceObsInfoEnum] (CSSPEnums.PolSourceObsInfoEnum.html)</c>, </para>
        /// </summary>
        /// <param name="type">One of the allowable types (Enum)</param>
        /// <returns>Will return list of EnumIDAndText ordered by the Enum text for one of the allowable languages [en, fr]</returns>
        public List<EnumIDAndText> GetEnumTextOrderedList(Type type)
        {
            List<EnumIDAndText> enumTextOrderedList = new List<EnumIDAndText>();

            if (type.Name == "BeaufortScaleEnum")
            {
                for (int i = 0, count = Enum.GetNames(type).Count() - 1; i < count; i++)
                {
                    enumTextOrderedList.Add(new EnumIDAndText() { EnumID = i, EnumText = GetResValueForTypeAndID(type, i) });
                }
            }
            else if (type.Name == "SampleTypeEnum")
            {
                for (int i = 101, count = Enum.GetNames(type).Count() + 101; i < count; i++)
                {
                    enumTextOrderedList.Add(new EnumIDAndText() { EnumID = i, EnumText = GetResValueForTypeAndID(type, i) });
                }
            }
            else
            {
                for (int i = 1, count = Enum.GetNames(type).Count(); i < count; i++)
                {
                    enumTextOrderedList.Add(new EnumIDAndText() { EnumID = i, EnumText = GetResValueForTypeAndID(type, i) });
                }
            }

            enumTextOrderedList = (from c in enumTextOrderedList
                                   orderby c.EnumText
                                   select c).ToList();

            return enumTextOrderedList;
        }
        /// <summary>
        /// <para>**Allowable types:** <c>[ActionDBTypeEnum] (CSSPEnums.ActionDBTypeEnum.html)</c>, <c>[AddressTypeEnum] (CSSPEnums.AddressTypeEnum.html)</c>, <c>[AerationTypeEnum] (CSSPEnums.AerationTypeEnum.html)</c>, <c>[AlarmSystemTypeEnum] (CSSPEnums.AlarmSystemTypeEnum.html)</c>, <c>[AnalyzeMethodEnum] (CSSPEnums.AnalyzeMethodEnum.html)</c>, <c>[AppTaskCommandEnum] (CSSPEnums.AppTaskCommandEnum.html)</c>, <c>[AppTaskStatusEnum] (CSSPEnums.AppTaskStatusEnum.html)</c>, <c>[BeaufortScaleEnum] (CSSPEnums.BeaufortScaleEnum.html)</c>, <c>[BoxModelResultTypeEnum] (CSSPEnums.BoxModelResultTypeEnum.html)</c>, <c>[CollectionSystemTypeEnum] (CSSPEnums.CollectionSystemTypeEnum.html)</c>, <c>[ContactTitleEnum] (CSSPEnums.ContactTitleEnum.html)</c>, <c>[CSSPWQInputSheetTypeEnum] (CSSPEnums.CSSPWQInputSheetTypeEnum.html)</c>, <c>[CSSPWQInputTypeEnum] (CSSPEnums.CSSPWQInputTypeEnum.html)</c>, <c>[DailyOrHourlyDataEnum] (CSSPEnums.DailyOrHourlyDataEnum.html)</c>, <c>[DatabaseTypeEnum] (CSSPEnums.DatabaseTypeEnum.html)</c>, <c>[DisinfectionTypeEnum] (CSSPEnums.DisinfectionTypeEnum.html)</c>, <c>[EmailTypeEnum] (CSSPEnums.EmailTypeEnum.html)</c>, <c>[FacilityTypeEnum] (CSSPEnums.FacilityTypeEnum.html)</c>, <c>[FilePurposeEnum] (CSSPEnums.FilePurposeEnum.html)</c>, <c>[FileStatusEnum] (CSSPEnums.FileStatusEnum.html)</c>, <c>[FileTypeEnum] (CSSPEnums.FileTypeEnum.html)</c>, <c>[InfrastructureTypeEnum] (CSSPEnums.InfrastructureTypeEnum.html)</c>, <c>[KMZActionEnum] (CSSPEnums.KMZActionEnum.html)</c>, <c>[LaboratoryEnum] (CSSPEnums.LaboratoryEnum.html)</c>, <c>[LabSheetStatusEnum] (CSSPEnums.LabSheetStatusEnum.html)</c>, <c>[LabSheetTypeEnum] (CSSPEnums.LabSheetTypeEnum.html)</c>, <c>[LanguageEnum] (CSSPEnums.LanguageEnum.html)</c>, <c>[LogCommandEnum] (CSSPEnums.LogCommandEnum.html)</c>, <c>[MapInfoDrawTypeEnum] (CSSPEnums.MapInfoDrawTypeEnum.html)</c>, <c>[MikeBoundaryConditionLevelOrVelocityEnum] (CSSPEnums.MikeBoundaryConditionLevelOrVelocityEnum.html)</c>, <c>[MikeScenarioSpecialResultKMLTypeEnum] (CSSPEnums.MikeScenarioSpecialResultKMLTypeEnum.html)</c>, <c>[MWQMSiteLatestClassificationEnum] (CSSPEnums.MWQMSiteLatestClassificationEnum.html)</c>, <c>[PolSourceInactiveReasonEnum] (CSSPEnums.PolSourceInactiveReasonEnum.html)</c>, <c>[PolSourceIssueRiskEnum] (CSSPEnums.PolSourceIssueRiskEnum.html)</c>, <c>[PolSourceObsInfoTypeEnum] (CSSPEnums.PolSourceObsInfoTypeEnum.html)</c>, <c>[PreliminaryTreatmentTypeEnum] (CSSPEnums.PreliminaryTreatmentTypeEnum.html)</c>, <c>[PrimaryTreatmentTypeEnum] (CSSPEnums.PrimaryTreatmentTypeEnum.html)</c>, <c>[ReportConditionEnum] (CSSPEnums.ReportConditionEnum.html)</c>, <c>[ReportFieldTypeEnum] (CSSPEnums.ReportFieldTypeEnum.html)</c>, <c>[ReportFileTypeEnum] (CSSPEnums.ReportFileTypeEnum.html)</c>, <c>[ReportFormatingDateEnum] (CSSPEnums.ReportFormatingDateEnum.html)</c>, <c>[ReportFormatingNumberEnum] (CSSPEnums.ReportFormatingNumberEnum.html)</c>, <c>[ReportSortingEnum] (CSSPEnums.ReportSortingEnum.html)</c>, <c>[ReportTreeNodeSubTypeEnum] (CSSPEnums.ReportTreeNodeSubTypeEnum.html)</c>, <c>[ReportTreeNodeTypeEnum] (CSSPEnums.ReportTreeNodeTypeEnum.html)</c>, <c>[SameDayNextDayEnum] (CSSPEnums.SameDayNextDayEnum.html)</c>, <c>[SampleMatrixEnum] (CSSPEnums.SampleMatrixEnum.html)</c>, <c>[SampleStatusEnum] (CSSPEnums.SampleStatusEnum.html)</c>, <c>[SampleTypeEnum] (CSSPEnums.SampleTypeEnum.html)</c>, <c>[SamplingPlanTypeEnum] (CSSPEnums.SamplingPlanTypeEnum.html)</c>, <c>[ScenarioStatusEnum] (CSSPEnums.ScenarioStatusEnum.html)</c>, <c>[SearchTagEnum] (CSSPEnums.SearchTagEnum.html)</c>, <c>[SecondaryTreatmentTypeEnum] (CSSPEnums.SecondaryTreatmentTypeEnum.html)</c>, <c>[SiteTypeEnum] (CSSPEnums.SiteTypeEnum.html)</c>, <c>[SpecialTableTypeEnum] (CSSPEnums.SpecialTableTypeEnum.html)</c>, <c>[StorageDataTypeEnum] (CSSPEnums.StorageDataTypeEnum.html)</c>, <c>[StreetTypeEnum] (CSSPEnums.StreetTypeEnum.html)</c>, <c>[TelTypeEnum] (CSSPEnums.TelTypeEnum.html)</c>, <c>[TertiaryTreatmentTypeEnum] (CSSPEnums.TertiaryTreatmentTypeEnum.html)</c>, <c>[TideDataTypeEnum] (CSSPEnums.TideDataTypeEnum.html)</c>, <c>[TideTextEnum] (CSSPEnums.TideTextEnum.html)</c>, <c>[TranslationStatusEnum] (CSSPEnums.TranslationStatusEnum.html)</c>, <c>[TreatmentTypeEnum] (CSSPEnums.TreatmentTypeEnum.html)</c>, <c>[TVAuthEnum] (CSSPEnums.TVAuthEnum.html)</c>, <c>[TVTypeEnum] (CSSPEnums.TVTypeEnum.html)</c>, <c>[WebTideDataSetEnum] (CSSPEnums.WebTideDataSetEnum.html)</c>, <c>[PolSourceObsInfoEnum] (CSSPEnums.PolSourceObsInfoEnum.html)</c>, </para>
        /// <para>**Allowable <c>[PolSourceObsInfoTypeEnum] (CSSPEnums.PolSourceObsInfoTypeEnum.html)</c>:** Error,Description,Report,Text,Initial,</para>
        /// </summary>
        /// <param name="type">One of the allowable types (Enum)</param>
        /// <param name="ID">ID representing the enumeration values (int?)</param>
        /// <param name="polSourceObsInfoTypeEnum">One of the allowable PolSourceObsInfoTypeEnum</param>
        /// <returns>Will return list of EnumIDAndText ordered by the Enum text for one of the allowable languages [en, fr]</returns>
        public string GetResValueForTypeAndID(Type type, int? ID, PolSourceObsInfoTypeEnum? polSourceObsInfoTypeEnum = PolSourceObsInfoTypeEnum.Error)
        {
            if (LanguageRequest.ToString() != Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)
            {
                if (LanguageRequest == LanguageEnum.fr)
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CA");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-CA");
                }
                else
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-CA");
                }
            }

            string enumName = type.Name;

            switch (enumName)
            {
                case "ActionDBTypeEnum":
                    return GetEnumText_ActionDBTypeEnum((ID == null ? null : (ActionDBTypeEnum?)ID));
                case "AddressTypeEnum":
                    return GetEnumText_AddressTypeEnum((ID == null ? null : (AddressTypeEnum?)ID));
                case "AerationTypeEnum":
                    return GetEnumText_AerationTypeEnum((ID == null ? null : (AerationTypeEnum?)ID));
                case "AlarmSystemTypeEnum":
                    return GetEnumText_AlarmSystemTypeEnum((ID == null ? null : (AlarmSystemTypeEnum?)ID));
                case "AnalyzeMethodEnum":
                    return GetEnumText_AnalyzeMethodEnum((ID == null ? null : (AnalyzeMethodEnum?)ID));
                case "AppTaskCommandEnum":
                    return GetEnumText_AppTaskCommandEnum((ID == null ? null : (AppTaskCommandEnum?)ID));
                case "AppTaskStatusEnum":
                    return GetEnumText_AppTaskStatusEnum((ID == null ? null : (AppTaskStatusEnum?)ID));
                case "BeaufortScaleEnum":
                    return GetEnumText_BeaufortScaleEnum((ID == null ? null : (BeaufortScaleEnum?)ID));
                case "BoxModelResultTypeEnum":
                    return GetEnumText_BoxModelResultTypeEnum((ID == null ? null : (BoxModelResultTypeEnum?)ID));
                case "CollectionSystemTypeEnum":
                    return GetEnumText_CollectionSystemTypeEnum((ID == null ? null : (CollectionSystemTypeEnum?)ID));
                case "ContactTitleEnum":
                    return GetEnumText_ContactTitleEnum((ID == null ? null : (ContactTitleEnum?)ID));
                case "CSSPWQInputSheetTypeEnum":
                    return GetEnumText_CSSPWQInputSheetTypeEnum((ID == null ? null : (CSSPWQInputSheetTypeEnum?)ID));
                case "CSSPWQInputTypeEnum":
                    return GetEnumText_CSSPWQInputTypeEnum((ID == null ? null : (CSSPWQInputTypeEnum?)ID));
                case "DailyOrHourlyDataEnum":
                    return GetEnumText_DailyOrHourlyDataEnum((ID == null ? null : (DailyOrHourlyDataEnum?)ID));
                case "DatabaseTypeEnum":
                    return GetEnumText_DatabaseTypeEnum((ID == null ? null : (DatabaseTypeEnum?)ID));
                case "DisinfectionTypeEnum":
                    return GetEnumText_DisinfectionTypeEnum((ID == null ? null : (DisinfectionTypeEnum?)ID));
                case "EmailTypeEnum":
                    return GetEnumText_EmailTypeEnum((ID == null ? null : (EmailTypeEnum?)ID));
                case "FacilityTypeEnum":
                    return GetEnumText_FacilityTypeEnum((ID == null ? null : (FacilityTypeEnum?)ID));
                case "FilePurposeEnum":
                    return GetEnumText_FilePurposeEnum((ID == null ? null : (FilePurposeEnum?)ID));
                case "FileStatusEnum":
                    return GetEnumText_FileStatusEnum((ID == null ? null : (FileStatusEnum?)ID));
                case "FileTypeEnum":
                    return GetEnumText_FileTypeEnum((ID == null ? null : (FileTypeEnum?)ID));
                case "InfrastructureTypeEnum":
                    return GetEnumText_InfrastructureTypeEnum((ID == null ? null : (InfrastructureTypeEnum?)ID));
                case "KMZActionEnum":
                    return GetEnumText_KMZActionEnum((ID == null ? null : (KMZActionEnum?)ID));
                case "LaboratoryEnum":
                    return GetEnumText_LaboratoryEnum((ID == null ? null : (LaboratoryEnum?)ID));
                case "LabSheetStatusEnum":
                    return GetEnumText_LabSheetStatusEnum((ID == null ? null : (LabSheetStatusEnum?)ID));
                case "LabSheetTypeEnum":
                    return GetEnumText_LabSheetTypeEnum((ID == null ? null : (LabSheetTypeEnum?)ID));
                case "LanguageEnum":
                    return GetEnumText_LanguageEnum((ID == null ? null : (LanguageEnum?)ID));
                case "LogCommandEnum":
                    return GetEnumText_LogCommandEnum((ID == null ? null : (LogCommandEnum?)ID));
                case "MapInfoDrawTypeEnum":
                    return GetEnumText_MapInfoDrawTypeEnum((ID == null ? null : (MapInfoDrawTypeEnum?)ID));
                case "MikeBoundaryConditionLevelOrVelocityEnum":
                    return GetEnumText_MikeBoundaryConditionLevelOrVelocityEnum((ID == null ? null : (MikeBoundaryConditionLevelOrVelocityEnum?)ID));
                case "MikeScenarioSpecialResultKMLTypeEnum":
                    return GetEnumText_MikeScenarioSpecialResultKMLTypeEnum((ID == null ? null : (MikeScenarioSpecialResultKMLTypeEnum?)ID));
                case "MWQMSiteLatestClassificationEnum":
                    return GetEnumText_MWQMSiteLatestClassificationEnum((ID == null ? null : (MWQMSiteLatestClassificationEnum?)ID));
                case "PolSourceInactiveReasonEnum":
                    return GetEnumText_PolSourceInactiveReasonEnum((ID == null ? null : (PolSourceInactiveReasonEnum?)ID));
                case "PolSourceIssueRiskEnum":
                    return GetEnumText_PolSourceIssueRiskEnum((ID == null ? null : (PolSourceIssueRiskEnum?)ID));
                case "PolSourceObsInfoTypeEnum":
                    return GetEnumText_PolSourceObsInfoTypeEnum((ID == null ? null : (PolSourceObsInfoTypeEnum?)ID));
                case "PreliminaryTreatmentTypeEnum":
                    return GetEnumText_PreliminaryTreatmentTypeEnum((ID == null ? null : (PreliminaryTreatmentTypeEnum?)ID));
                case "PrimaryTreatmentTypeEnum":
                    return GetEnumText_PrimaryTreatmentTypeEnum((ID == null ? null : (PrimaryTreatmentTypeEnum?)ID));
                case "ReportConditionEnum":
                    return GetEnumText_ReportConditionEnum((ID == null ? null : (ReportConditionEnum?)ID));
                case "ReportFieldTypeEnum":
                    return GetEnumText_ReportFieldTypeEnum((ID == null ? null : (ReportFieldTypeEnum?)ID));
                case "ReportFileTypeEnum":
                    return GetEnumText_ReportFileTypeEnum((ID == null ? null : (ReportFileTypeEnum?)ID));
                case "ReportFormatingDateEnum":
                    return GetEnumText_ReportFormatingDateEnum((ID == null ? null : (ReportFormatingDateEnum?)ID));
                case "ReportFormatingNumberEnum":
                    return GetEnumText_ReportFormatingNumberEnum((ID == null ? null : (ReportFormatingNumberEnum?)ID));
                case "ReportSortingEnum":
                    return GetEnumText_ReportSortingEnum((ID == null ? null : (ReportSortingEnum?)ID));
                case "ReportTreeNodeSubTypeEnum":
                    return GetEnumText_ReportTreeNodeSubTypeEnum((ID == null ? null : (ReportTreeNodeSubTypeEnum?)ID));
                case "ReportTreeNodeTypeEnum":
                    return GetEnumText_ReportTreeNodeTypeEnum((ID == null ? null : (ReportTreeNodeTypeEnum?)ID));
                case "SameDayNextDayEnum":
                    return GetEnumText_SameDayNextDayEnum((ID == null ? null : (SameDayNextDayEnum?)ID));
                case "SampleMatrixEnum":
                    return GetEnumText_SampleMatrixEnum((ID == null ? null : (SampleMatrixEnum?)ID));
                case "SampleStatusEnum":
                    return GetEnumText_SampleStatusEnum((ID == null ? null : (SampleStatusEnum?)ID));
                case "SampleTypeEnum":
                    return GetEnumText_SampleTypeEnum((ID == null ? null : (SampleTypeEnum?)ID));
                case "SamplingPlanTypeEnum":
                    return GetEnumText_SamplingPlanTypeEnum((ID == null ? null : (SamplingPlanTypeEnum?)ID));
                case "ScenarioStatusEnum":
                    return GetEnumText_ScenarioStatusEnum((ID == null ? null : (ScenarioStatusEnum?)ID));
                case "SearchTagEnum":
                    return GetEnumText_SearchTagEnum((ID == null ? null : (SearchTagEnum?)ID));
                case "SecondaryTreatmentTypeEnum":
                    return GetEnumText_SecondaryTreatmentTypeEnum((ID == null ? null : (SecondaryTreatmentTypeEnum?)ID));
                case "SiteTypeEnum":
                    return GetEnumText_SiteTypeEnum((ID == null ? null : (SiteTypeEnum?)ID));
                case "SpecialTableTypeEnum":
                    return GetEnumText_SpecialTableTypeEnum((ID == null ? null : (SpecialTableTypeEnum?)ID));
                case "StorageDataTypeEnum":
                    return GetEnumText_StorageDataTypeEnum((ID == null ? null : (StorageDataTypeEnum?)ID));
                case "StreetTypeEnum":
                    return GetEnumText_StreetTypeEnum((ID == null ? null : (StreetTypeEnum?)ID));
                case "TelTypeEnum":
                    return GetEnumText_TelTypeEnum((ID == null ? null : (TelTypeEnum?)ID));
                case "TertiaryTreatmentTypeEnum":
                    return GetEnumText_TertiaryTreatmentTypeEnum((ID == null ? null : (TertiaryTreatmentTypeEnum?)ID));
                case "TideDataTypeEnum":
                    return GetEnumText_TideDataTypeEnum((ID == null ? null : (TideDataTypeEnum?)ID));
                case "TideTextEnum":
                    return GetEnumText_TideTextEnum((ID == null ? null : (TideTextEnum?)ID));
                case "TranslationStatusEnum":
                    return GetEnumText_TranslationStatusEnum((ID == null ? null : (TranslationStatusEnum?)ID));
                case "TreatmentTypeEnum":
                    return GetEnumText_TreatmentTypeEnum((ID == null ? null : (TreatmentTypeEnum?)ID));
                case "TVAuthEnum":
                    return GetEnumText_TVAuthEnum((ID == null ? null : (TVAuthEnum?)ID));
                case "TVTypeEnum":
                    return GetEnumText_TVTypeEnum((ID == null ? null : (TVTypeEnum?)ID));
                case "WebTideDataSetEnum":
                    return GetEnumText_WebTideDataSetEnum((ID == null ? null : (WebTideDataSetEnum?)ID));
                case "PolSourceObsInfoEnum":
                {
                    switch (polSourceObsInfoTypeEnum)
                    {
                        case PolSourceObsInfoTypeEnum.Error:
                            return GetEnumText_PolSourceObsInfoEnum((ID == null ? null : (PolSourceObsInfoEnum?)ID));
                        case PolSourceObsInfoTypeEnum.Description:
                            return GetEnumText_PolSourceObsInfoDescEnum((ID == null ? null : (PolSourceObsInfoEnum?)ID));
                        case PolSourceObsInfoTypeEnum.Report:
                            return GetEnumText_PolSourceObsInfoReportEnum((ID == null ? null : (PolSourceObsInfoEnum?)ID));
                        case PolSourceObsInfoTypeEnum.Text:
                            return GetEnumText_PolSourceObsInfoTextEnum((ID == null ? null : (PolSourceObsInfoEnum?)ID));
                        case PolSourceObsInfoTypeEnum.Initial:
                            return GetEnumText_PolSourceObsInfoInitEnum((ID == null ? null : (PolSourceObsInfoEnum?)ID));
                        default:
                            return GetEnumText_PolSourceObsInfoEnum((ID == null ? null : (PolSourceObsInfoEnum?)ID));
                    }
                }
                default:
                    return "";
            }
        }
        #endregion Function public

        #region Functions private
        private string GetEnumText_ActionDBTypeEnum(ActionDBTypeEnum? actionDBType)
        {
            if (actionDBType == null)
                return CSSPEnumsRes.Empty;

            switch (actionDBType)
            {
                case ActionDBTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case ActionDBTypeEnum.Create:
                    return CSSPEnumsRes.ActionDBTypeEnumCreate;
                case ActionDBTypeEnum.Read:
                    return CSSPEnumsRes.ActionDBTypeEnumRead;
                case ActionDBTypeEnum.Update:
                    return CSSPEnumsRes.ActionDBTypeEnumUpdate;
                case ActionDBTypeEnum.Delete:
                    return CSSPEnumsRes.ActionDBTypeEnumDelete;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_AddressTypeEnum(AddressTypeEnum? addressType)
        {
            if (addressType == null)
                return CSSPEnumsRes.Empty;

            switch (addressType)
            {
                case AddressTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case AddressTypeEnum.Mailing:
                    return CSSPEnumsRes.AddressTypeEnumMailing;
                case AddressTypeEnum.Shipping:
                    return CSSPEnumsRes.AddressTypeEnumShipping;
                case AddressTypeEnum.Civic:
                    return CSSPEnumsRes.AddressTypeEnumCivic;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_AerationTypeEnum(AerationTypeEnum? aerationType)
        {
            if (aerationType == null)
                return CSSPEnumsRes.Empty;

            switch (aerationType)
            {
                case AerationTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case AerationTypeEnum.Diffuser:
                    return CSSPEnumsRes.AerationTypeEnumDiffuser;
                case AerationTypeEnum.Surface:
                    return CSSPEnumsRes.AerationTypeEnumSurface;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_AlarmSystemTypeEnum(AlarmSystemTypeEnum? alarmSystemType)
        {
            if (alarmSystemType == null)
                return CSSPEnumsRes.Empty;

            switch (alarmSystemType)
            {
                case AlarmSystemTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case AlarmSystemTypeEnum.SCADA:
                    return CSSPEnumsRes.AlarmSystemTypeEnumSCADA;
                case AlarmSystemTypeEnum.None:
                    return CSSPEnumsRes.AlarmSystemTypeEnumNone;
                case AlarmSystemTypeEnum.OnlyVisualLight:
                    return CSSPEnumsRes.AlarmSystemTypeEnumOnlyVisualLight;
                case AlarmSystemTypeEnum.SCADAAndLight:
                    return CSSPEnumsRes.AlarmSystemTypeEnumSCADAAndLight;
                case AlarmSystemTypeEnum.PagerAndLight:
                    return CSSPEnumsRes.AlarmSystemTypeEnumPagerAndLight;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_AnalyzeMethodEnum(AnalyzeMethodEnum? analyzeMethod)
        {
            if (analyzeMethod == null)
                return CSSPEnumsRes.Empty;

            switch (analyzeMethod)
            {
                case AnalyzeMethodEnum.Error:
                    return CSSPEnumsRes.Empty;
                case AnalyzeMethodEnum.MF:
                    return CSSPEnumsRes.AnalyzeMethodEnumMF;
                case AnalyzeMethodEnum.ZZ_510Q:
                    return CSSPEnumsRes.AnalyzeMethodEnumZZ_510Q;
                case AnalyzeMethodEnum.ZZ_509Q:
                    return CSSPEnumsRes.AnalyzeMethodEnumZZ_509Q;
                case AnalyzeMethodEnum.ZZ_0:
                    return CSSPEnumsRes.AnalyzeMethodEnumZZ_0;
                case AnalyzeMethodEnum.ZZ_525Q:
                    return CSSPEnumsRes.AnalyzeMethodEnumZZ_525Q;
                case AnalyzeMethodEnum.MPN:
                    return CSSPEnumsRes.AnalyzeMethodEnumMPN;
                case AnalyzeMethodEnum.ZZ_0Q:
                    return CSSPEnumsRes.AnalyzeMethodEnumZZ_0Q;
                case AnalyzeMethodEnum.AnalyzeMethod8:
                    return CSSPEnumsRes.AnalyzeMethodEnumAnalyzeMethod8;
                case AnalyzeMethodEnum.AnalyzeMethod9:
                    return CSSPEnumsRes.AnalyzeMethodEnumAnalyzeMethod9;
                case AnalyzeMethodEnum.AnalyzeMethod10:
                    return CSSPEnumsRes.AnalyzeMethodEnumAnalyzeMethod10;
                case AnalyzeMethodEnum.AnalyzeMethod11:
                    return CSSPEnumsRes.AnalyzeMethodEnumAnalyzeMethod11;
                case AnalyzeMethodEnum.AnalyzeMethod12:
                    return CSSPEnumsRes.AnalyzeMethodEnumAnalyzeMethod12;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_AppTaskCommandEnum(AppTaskCommandEnum? appTaskCommand)
        {
            if (appTaskCommand == null)
                return CSSPEnumsRes.Empty;

            switch (appTaskCommand)
            {
                case AppTaskCommandEnum.Error:
                    return CSSPEnumsRes.Empty;
                case AppTaskCommandEnum.GenerateWebTide:
                    return CSSPEnumsRes.AppTaskCommandEnumGenerateWebTide;
                case AppTaskCommandEnum.MikeScenarioAskToRun:
                    return CSSPEnumsRes.AppTaskCommandEnumMikeScenarioAskToRun;
                case AppTaskCommandEnum.MikeScenarioImport:
                    return CSSPEnumsRes.AppTaskCommandEnumMikeScenarioImport;
                case AppTaskCommandEnum.MikeScenarioOtherFileImport:
                    return CSSPEnumsRes.AppTaskCommandEnumMikeScenarioOtherFileImport;
                case AppTaskCommandEnum.MikeScenarioRunning:
                    return CSSPEnumsRes.AppTaskCommandEnumMikeScenarioRunning;
                case AppTaskCommandEnum.MikeScenarioToCancel:
                    return CSSPEnumsRes.AppTaskCommandEnumMikeScenarioToCancel;
                case AppTaskCommandEnum.MikeScenarioWaitingToRun:
                    return CSSPEnumsRes.AppTaskCommandEnumMikeScenarioWaitingToRun;
                case AppTaskCommandEnum.SetupWebTide:
                    return CSSPEnumsRes.AppTaskCommandEnumSetupWebTide;
                case AppTaskCommandEnum.UpdateClimateSiteInformation:
                    return CSSPEnumsRes.AppTaskCommandEnumUpdateClimateSiteInformation;
                case AppTaskCommandEnum.UpdateClimateSiteDailyAndHourlyFromStartDateToEndDate:
                    return CSSPEnumsRes.AppTaskCommandEnumUpdateClimateSiteDailyAndHourlyFromStartDateToEndDate;
                case AppTaskCommandEnum.UpdateClimateSiteDailyAndHourlyForSubsectorFromStartDateToEndDate:
                    return CSSPEnumsRes.AppTaskCommandEnumUpdateClimateSiteDailyAndHourlyForSubsectorFromStartDateToEndDate;
                case AppTaskCommandEnum.CreateFCForm:
                    return CSSPEnumsRes.AppTaskCommandEnumCreateFCForm;
                case AppTaskCommandEnum.CreateSamplingPlanSamplingPlanTextFile:
                    return CSSPEnumsRes.AppTaskCommandEnumCreateSamplingPlanSamplingPlanTextFile;
                case AppTaskCommandEnum.CreateDocumentFromTemplate:
                    return CSSPEnumsRes.AppTaskCommandEnumCreateDocumentFromTemplate;
                case AppTaskCommandEnum.GetClimateSitesDataForRunsOfYear:
                    return CSSPEnumsRes.AppTaskCommandEnumGetClimateSitesDataForRunsOfYear;
                case AppTaskCommandEnum.CreateWebTideDataWLAtFirstNode:
                    return CSSPEnumsRes.AppTaskCommandEnumCreateWebTideDataWLAtFirstNode;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_AppTaskStatusEnum(AppTaskStatusEnum? appTaskStatus)
        {
            if (appTaskStatus == null)
                return CSSPEnumsRes.Empty;

            switch (appTaskStatus)
            {
                case AppTaskStatusEnum.Error:
                    return CSSPEnumsRes.Empty;
                case AppTaskStatusEnum.Created:
                    return CSSPEnumsRes.AppTaskStatusEnumCreated;
                case AppTaskStatusEnum.Running:
                    return CSSPEnumsRes.AppTaskStatusEnumRunning;
                case AppTaskStatusEnum.Completed:
                    return CSSPEnumsRes.AppTaskStatusEnumCompleted;
                case AppTaskStatusEnum.Cancelled:
                    return CSSPEnumsRes.AppTaskStatusEnumCancelled;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_BeaufortScaleEnum(BeaufortScaleEnum? beaufortScale)
        {
            if (beaufortScale == null)
                return CSSPEnumsRes.Empty;

            switch (beaufortScale)
            {
                case BeaufortScaleEnum.Error:
                    return CSSPEnumsRes.Empty;
                case BeaufortScaleEnum.Calm:
                    return CSSPEnumsRes.BeaufortScaleEnumCalm;
                case BeaufortScaleEnum.LightAir:
                    return CSSPEnumsRes.BeaufortScaleEnumLightAir;
                case BeaufortScaleEnum.LightBreeze:
                    return CSSPEnumsRes.BeaufortScaleEnumLightBreeze;
                case BeaufortScaleEnum.GentleBreeze:
                    return CSSPEnumsRes.BeaufortScaleEnumGentleBreeze;
                case BeaufortScaleEnum.ModerateBreeze:
                    return CSSPEnumsRes.BeaufortScaleEnumModerateBreeze;
                case BeaufortScaleEnum.FreshBreeze:
                    return CSSPEnumsRes.BeaufortScaleEnumFreshBreeze;
                case BeaufortScaleEnum.StrongBreeze:
                    return CSSPEnumsRes.BeaufortScaleEnumStrongBreeze;
                case BeaufortScaleEnum.HighWind_ModerateGale_NearGale:
                    return CSSPEnumsRes.BeaufortScaleEnumHighWind_ModerateGale_NearGale;
                case BeaufortScaleEnum.Gale_FreshGale:
                    return CSSPEnumsRes.BeaufortScaleEnumGale_FreshGale;
                case BeaufortScaleEnum.Strong_SevereGale:
                    return CSSPEnumsRes.BeaufortScaleEnumStrong_SevereGale;
                case BeaufortScaleEnum.Storm_WholeGale:
                    return CSSPEnumsRes.BeaufortScaleEnumStorm_WholeGale;
                case BeaufortScaleEnum.ViolentStorm:
                    return CSSPEnumsRes.BeaufortScaleEnumViolentStorm;
                case BeaufortScaleEnum.HurricaneForce:
                    return CSSPEnumsRes.BeaufortScaleEnumHurricaneForce;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_BoxModelResultTypeEnum(BoxModelResultTypeEnum? boxModelResultType)
        {
            if (boxModelResultType == null)
                return CSSPEnumsRes.Empty;

            switch (boxModelResultType)
            {
                case BoxModelResultTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case BoxModelResultTypeEnum.Dilution:
                    return CSSPEnumsRes.BoxModelResultTypeEnumDilution;
                case BoxModelResultTypeEnum.NoDecayUntreated:
                    return CSSPEnumsRes.BoxModelResultTypeEnumNoDecayUntreated;
                case BoxModelResultTypeEnum.NoDecayPreDisinfection:
                    return CSSPEnumsRes.BoxModelResultTypeEnumNoDecayPreDisinfection;
                case BoxModelResultTypeEnum.DecayUntreated:
                    return CSSPEnumsRes.BoxModelResultTypeEnumDecayUntreated;
                case BoxModelResultTypeEnum.DecayPreDisinfection:
                    return CSSPEnumsRes.BoxModelResultTypeEnumDecayPreDisinfection;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_CollectionSystemTypeEnum(CollectionSystemTypeEnum? collectionSystemType)
        {
            if (collectionSystemType == null)
                return CSSPEnumsRes.Empty;

            switch (collectionSystemType)
            {
                case CollectionSystemTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case CollectionSystemTypeEnum.CompletelySeparated:
                    return CSSPEnumsRes.CollectionSystemTypeEnumCompletelySeparated;
                case CollectionSystemTypeEnum.CompletelyCombined:
                    return CSSPEnumsRes.CollectionSystemTypeEnumCompletelyCombined;
                case CollectionSystemTypeEnum.Combined90Separated10:
                    return CSSPEnumsRes.CollectionSystemTypeEnumCombined90Separated10;
                case CollectionSystemTypeEnum.Combined80Separated20:
                    return CSSPEnumsRes.CollectionSystemTypeEnumCombined80Separated20;
                case CollectionSystemTypeEnum.Combined70Separated30:
                    return CSSPEnumsRes.CollectionSystemTypeEnumCombined70Separated30;
                case CollectionSystemTypeEnum.Combined60Separated40:
                    return CSSPEnumsRes.CollectionSystemTypeEnumCombined60Separated40;
                case CollectionSystemTypeEnum.Combined50Separated50:
                    return CSSPEnumsRes.CollectionSystemTypeEnumCombined50Separated50;
                case CollectionSystemTypeEnum.Combined40Separated60:
                    return CSSPEnumsRes.CollectionSystemTypeEnumCombined40Separated60;
                case CollectionSystemTypeEnum.Combined30Separated70:
                    return CSSPEnumsRes.CollectionSystemTypeEnumCombined30Separated70;
                case CollectionSystemTypeEnum.Combined20Separated80:
                    return CSSPEnumsRes.CollectionSystemTypeEnumCombined20Separated80;
                case CollectionSystemTypeEnum.Combined10Separated90:
                    return CSSPEnumsRes.CollectionSystemTypeEnumCombined10Separated90;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_ContactTitleEnum(ContactTitleEnum? contactTitle)
        {
            if (contactTitle == null)
                return CSSPEnumsRes.Empty;

            switch (contactTitle)
            {
                case ContactTitleEnum.Error:
                    return CSSPEnumsRes.Empty;
                case ContactTitleEnum.DirectorGeneral:
                    return CSSPEnumsRes.ContactTitleEnumDirectorGeneral;
                case ContactTitleEnum.DirectorPublicWorks:
                    return CSSPEnumsRes.ContactTitleEnumDirectorPublicWorks;
                case ContactTitleEnum.Superintendent:
                    return CSSPEnumsRes.ContactTitleEnumSuperintendent;
                case ContactTitleEnum.Engineer:
                    return CSSPEnumsRes.ContactTitleEnumEngineer;
                case ContactTitleEnum.Foreman:
                    return CSSPEnumsRes.ContactTitleEnumForeman;
                case ContactTitleEnum.Operator:
                    return CSSPEnumsRes.ContactTitleEnumOperator;
                case ContactTitleEnum.FacilitiesManager:
                    return CSSPEnumsRes.ContactTitleEnumFacilitiesManager;
                case ContactTitleEnum.Supervisor:
                    return CSSPEnumsRes.ContactTitleEnumSupervisor;
                case ContactTitleEnum.Technician:
                    return CSSPEnumsRes.ContactTitleEnumTechnician;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_CSSPWQInputSheetTypeEnum(CSSPWQInputSheetTypeEnum? cSSPWQInputSheetType)
        {
            if (cSSPWQInputSheetType == null)
                return CSSPEnumsRes.Empty;

            switch (cSSPWQInputSheetType)
            {
                case CSSPWQInputSheetTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case CSSPWQInputSheetTypeEnum.A1:
                    return CSSPEnumsRes.CSSPWQInputSheetTypeEnumA1;
                case CSSPWQInputSheetTypeEnum.LTB:
                    return CSSPEnumsRes.CSSPWQInputSheetTypeEnumLTB;
                case CSSPWQInputSheetTypeEnum.EC:
                    return CSSPEnumsRes.CSSPWQInputSheetTypeEnumEC;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_CSSPWQInputTypeEnum(CSSPWQInputTypeEnum? cSSPWQInputType)
        {
            if (cSSPWQInputType == null)
                return CSSPEnumsRes.Empty;

            switch (cSSPWQInputType)
            {
                case CSSPWQInputTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case CSSPWQInputTypeEnum.Subsector:
                    return CSSPEnumsRes.CSSPWQInputTypeEnumSubsector;
                case CSSPWQInputTypeEnum.Municipality:
                    return CSSPEnumsRes.CSSPWQInputTypeEnumMunicipality;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_DailyOrHourlyDataEnum(DailyOrHourlyDataEnum? dailyOrHourlyData)
        {
            if (dailyOrHourlyData == null)
                return CSSPEnumsRes.Empty;

            switch (dailyOrHourlyData)
            {
                case DailyOrHourlyDataEnum.Error:
                    return CSSPEnumsRes.Empty;
                case DailyOrHourlyDataEnum.Daily:
                    return CSSPEnumsRes.DailyOrHourlyDataEnumDaily;
                case DailyOrHourlyDataEnum.Hourly:
                    return CSSPEnumsRes.DailyOrHourlyDataEnumHourly;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_DatabaseTypeEnum(DatabaseTypeEnum? databaseType)
        {
            if (databaseType == null)
                return CSSPEnumsRes.Empty;

            switch (databaseType)
            {
                case DatabaseTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case DatabaseTypeEnum.MemoryCSSPWebToolsDB:
                    return CSSPEnumsRes.DatabaseTypeEnumMemoryCSSPWebToolsDB;
                case DatabaseTypeEnum.MemoryTestDB:
                    return CSSPEnumsRes.DatabaseTypeEnumMemoryTestDB;
                case DatabaseTypeEnum.SqlServerCSSPWebToolsDB:
                    return CSSPEnumsRes.DatabaseTypeEnumSqlServerCSSPWebToolsDB;
                case DatabaseTypeEnum.SqlServerTestDB:
                    return CSSPEnumsRes.DatabaseTypeEnumSqlServerTestDB;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_DisinfectionTypeEnum(DisinfectionTypeEnum? disinfectionType)
        {
            if (disinfectionType == null)
                return CSSPEnumsRes.Empty;

            switch (disinfectionType)
            {
                case DisinfectionTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case DisinfectionTypeEnum.None:
                    return CSSPEnumsRes.DisinfectionTypeEnumNone;
                case DisinfectionTypeEnum.UV:
                    return CSSPEnumsRes.DisinfectionTypeEnumUV;
                case DisinfectionTypeEnum.ChlorinationNoDechlorination:
                    return CSSPEnumsRes.DisinfectionTypeEnumChlorinationNoDechlorination;
                case DisinfectionTypeEnum.ChlorinationWithDechlorination:
                    return CSSPEnumsRes.DisinfectionTypeEnumChlorinationWithDechlorination;
                case DisinfectionTypeEnum.UVSeasonal:
                    return CSSPEnumsRes.DisinfectionTypeEnumUVSeasonal;
                case DisinfectionTypeEnum.ChlorinationNoDechlorinationSeasonal:
                    return CSSPEnumsRes.DisinfectionTypeEnumChlorinationNoDechlorinationSeasonal;
                case DisinfectionTypeEnum.ChlorinationWithDechlorinationSeasonal:
                    return CSSPEnumsRes.DisinfectionTypeEnumChlorinationWithDechlorinationSeasonal;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_EmailTypeEnum(EmailTypeEnum? emailType)
        {
            if (emailType == null)
                return CSSPEnumsRes.Empty;

            switch (emailType)
            {
                case EmailTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case EmailTypeEnum.Personal:
                    return CSSPEnumsRes.EmailTypeEnumPersonal;
                case EmailTypeEnum.Work:
                    return CSSPEnumsRes.EmailTypeEnumWork;
                case EmailTypeEnum.Personal2:
                    return CSSPEnumsRes.EmailTypeEnumPersonal2;
                case EmailTypeEnum.Work2:
                    return CSSPEnumsRes.EmailTypeEnumWork2;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_FacilityTypeEnum(FacilityTypeEnum? facilityType)
        {
            if (facilityType == null)
                return CSSPEnumsRes.Empty;

            switch (facilityType)
            {
                case FacilityTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case FacilityTypeEnum.Lagoon:
                    return CSSPEnumsRes.FacilityTypeEnumLagoon;
                case FacilityTypeEnum.Plant:
                    return CSSPEnumsRes.FacilityTypeEnumPlant;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_FilePurposeEnum(FilePurposeEnum? filePurpose)
        {
            if (filePurpose == null)
                return CSSPEnumsRes.Empty;

            switch (filePurpose)
            {
                case FilePurposeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case FilePurposeEnum.MikeInput:
                    return CSSPEnumsRes.FilePurposeEnumMikeInput;
                case FilePurposeEnum.MikeInputMDF:
                    return CSSPEnumsRes.FilePurposeEnumMikeInputMDF;
                case FilePurposeEnum.MikeResultDFSU:
                    return CSSPEnumsRes.FilePurposeEnumMikeResultDFSU;
                case FilePurposeEnum.MikeResultKMZ:
                    return CSSPEnumsRes.FilePurposeEnumMikeResultKMZ;
                case FilePurposeEnum.Information:
                    return CSSPEnumsRes.FilePurposeEnumInformation;
                case FilePurposeEnum.Image:
                    return CSSPEnumsRes.FilePurposeEnumImage;
                case FilePurposeEnum.Picture:
                    return CSSPEnumsRes.FilePurposeEnumPicture;
                case FilePurposeEnum.Reported:
                    return CSSPEnumsRes.FilePurposeEnumReported;
                case FilePurposeEnum.Generated:
                    return CSSPEnumsRes.FilePurposeEnumGenerated;
                case FilePurposeEnum.GeneratedFCForm:
                    return CSSPEnumsRes.FilePurposeEnumGeneratedFCForm;
                case FilePurposeEnum.Template:
                    return CSSPEnumsRes.FilePurposeEnumTemplate;
                case FilePurposeEnum.Map:
                    return CSSPEnumsRes.FilePurposeEnumMap;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_FileStatusEnum(FileStatusEnum? fileStatus)
        {
            if (fileStatus == null)
                return CSSPEnumsRes.Empty;

            switch (fileStatus)
            {
                case FileStatusEnum.Error:
                    return CSSPEnumsRes.Empty;
                case FileStatusEnum.Changed:
                    return CSSPEnumsRes.FileStatusEnumChanged;
                case FileStatusEnum.Sent:
                    return CSSPEnumsRes.FileStatusEnumSent;
                case FileStatusEnum.Accepted:
                    return CSSPEnumsRes.FileStatusEnumAccepted;
                case FileStatusEnum.Rejected:
                    return CSSPEnumsRes.FileStatusEnumRejected;
                case FileStatusEnum.Fail:
                    return CSSPEnumsRes.FileStatusEnumFail;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_FileTypeEnum(FileTypeEnum? fileType)
        {
            if (fileType == null)
                return CSSPEnumsRes.Empty;

            switch (fileType)
            {
                case FileTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case FileTypeEnum.DFS0:
                    return CSSPEnumsRes.FileTypeEnumDFS0;
                case FileTypeEnum.DFS1:
                    return CSSPEnumsRes.FileTypeEnumDFS1;
                case FileTypeEnum.DFSU:
                    return CSSPEnumsRes.FileTypeEnumDFSU;
                case FileTypeEnum.KMZ:
                    return CSSPEnumsRes.FileTypeEnumKMZ;
                case FileTypeEnum.LOG:
                    return CSSPEnumsRes.FileTypeEnumLOG;
                case FileTypeEnum.M21FM:
                    return CSSPEnumsRes.FileTypeEnumM21FM;
                case FileTypeEnum.M3FM:
                    return CSSPEnumsRes.FileTypeEnumM3FM;
                case FileTypeEnum.MDF:
                    return CSSPEnumsRes.FileTypeEnumMDF;
                case FileTypeEnum.MESH:
                    return CSSPEnumsRes.FileTypeEnumMESH;
                case FileTypeEnum.XLSX:
                    return CSSPEnumsRes.FileTypeEnumXLSX;
                case FileTypeEnum.DOCX:
                    return CSSPEnumsRes.FileTypeEnumDOCX;
                case FileTypeEnum.PDF:
                    return CSSPEnumsRes.FileTypeEnumPDF;
                case FileTypeEnum.JPG:
                    return CSSPEnumsRes.FileTypeEnumJPG;
                case FileTypeEnum.JPEG:
                    return CSSPEnumsRes.FileTypeEnumJPEG;
                case FileTypeEnum.GIF:
                    return CSSPEnumsRes.FileTypeEnumGIF;
                case FileTypeEnum.PNG:
                    return CSSPEnumsRes.FileTypeEnumPNG;
                case FileTypeEnum.HTML:
                    return CSSPEnumsRes.FileTypeEnumHTML;
                case FileTypeEnum.TXT:
                    return CSSPEnumsRes.FileTypeEnumTXT;
                case FileTypeEnum.XYZ:
                    return CSSPEnumsRes.FileTypeEnumXYZ;
                case FileTypeEnum.KML:
                    return CSSPEnumsRes.FileTypeEnumKML;
                case FileTypeEnum.CSV:
                    return CSSPEnumsRes.FileTypeEnumCSV;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_InfrastructureTypeEnum(InfrastructureTypeEnum? infrastructureType)
        {
            if (infrastructureType == null)
                return CSSPEnumsRes.Empty;

            switch (infrastructureType)
            {
                case InfrastructureTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case InfrastructureTypeEnum.WWTP:
                    return CSSPEnumsRes.InfrastructureTypeEnumWWTP;
                case InfrastructureTypeEnum.LiftStation:
                    return CSSPEnumsRes.InfrastructureTypeEnumLiftStation;
                case InfrastructureTypeEnum.Other:
                    return CSSPEnumsRes.InfrastructureTypeEnumOther;
                case InfrastructureTypeEnum.SeeOther:
                    return CSSPEnumsRes.InfrastructureTypeEnumSeeOther;
                case InfrastructureTypeEnum.LineOverflow:
                    return CSSPEnumsRes.InfrastructureTypeEnumLineOverflow;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_KMZActionEnum(KMZActionEnum? kMZAction)
        {
            if (kMZAction == null)
                return CSSPEnumsRes.Empty;

            switch (kMZAction)
            {
                case KMZActionEnum.Error:
                    return CSSPEnumsRes.Empty;
                case KMZActionEnum.DoNothing:
                    return CSSPEnumsRes.KMZActionEnumDoNothing;
                case KMZActionEnum.GenerateKMZContourAnimation:
                    return CSSPEnumsRes.KMZActionEnumGenerateKMZContourAnimation;
                case KMZActionEnum.GenerateKMZContourLimit:
                    return CSSPEnumsRes.KMZActionEnumGenerateKMZContourLimit;
                case KMZActionEnum.GenerateKMZCurrentAnimation:
                    return CSSPEnumsRes.KMZActionEnumGenerateKMZCurrentAnimation;
                case KMZActionEnum.GenerateKMZCurrentMaximum:
                    return CSSPEnumsRes.KMZActionEnumGenerateKMZCurrentMaximum;
                case KMZActionEnum.GenerateKMZMesh:
                    return CSSPEnumsRes.KMZActionEnumGenerateKMZMesh;
                case KMZActionEnum.GenerateKMZStudyArea:
                    return CSSPEnumsRes.KMZActionEnumGenerateKMZStudyArea;
                case KMZActionEnum.GenerateKMZBoundaryConditionNodes:
                    return CSSPEnumsRes.KMZActionEnumGenerateKMZBoundaryConditionNodes;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_LaboratoryEnum(LaboratoryEnum? laboratory)
        {
            if (laboratory == null)
                return CSSPEnumsRes.Empty;

            switch (laboratory)
            {
                case LaboratoryEnum.Error:
                    return CSSPEnumsRes.Empty;
                case LaboratoryEnum.ZZ_0:
                    return CSSPEnumsRes.LaboratoryEnumZZ_0;
                case LaboratoryEnum.ZZ_1:
                    return CSSPEnumsRes.LaboratoryEnumZZ_1;
                case LaboratoryEnum.ZZ_2:
                    return CSSPEnumsRes.LaboratoryEnumZZ_2;
                case LaboratoryEnum.ZZ_3:
                    return CSSPEnumsRes.LaboratoryEnumZZ_3;
                case LaboratoryEnum.ZZ_4:
                    return CSSPEnumsRes.LaboratoryEnumZZ_4;
                case LaboratoryEnum.ZZ_1Q:
                    return CSSPEnumsRes.LaboratoryEnumZZ_1Q;
                case LaboratoryEnum.ZZ_2Q:
                    return CSSPEnumsRes.LaboratoryEnumZZ_2Q;
                case LaboratoryEnum.ZZ_3Q:
                    return CSSPEnumsRes.LaboratoryEnumZZ_3Q;
                case LaboratoryEnum.ZZ_4Q:
                    return CSSPEnumsRes.LaboratoryEnumZZ_4Q;
                case LaboratoryEnum.ZZ_5Q:
                    return CSSPEnumsRes.LaboratoryEnumZZ_5Q;
                case LaboratoryEnum.ZZ_11BC:
                    return CSSPEnumsRes.LaboratoryEnumZZ_11BC;
                case LaboratoryEnum.ZZ_12BC:
                    return CSSPEnumsRes.LaboratoryEnumZZ_12BC;
                case LaboratoryEnum.ZZ_13BC:
                    return CSSPEnumsRes.LaboratoryEnumZZ_13BC;
                case LaboratoryEnum.ZZ_14BC:
                    return CSSPEnumsRes.LaboratoryEnumZZ_14BC;
                case LaboratoryEnum.ZZ_15BC:
                    return CSSPEnumsRes.LaboratoryEnumZZ_15BC;
                case LaboratoryEnum.ZZ_16BC:
                    return CSSPEnumsRes.LaboratoryEnumZZ_16BC;
                case LaboratoryEnum.ZZ_17BC:
                    return CSSPEnumsRes.LaboratoryEnumZZ_17BC;
                case LaboratoryEnum.ZZ_18BC:
                    return CSSPEnumsRes.LaboratoryEnumZZ_18BC;
                case LaboratoryEnum.MonctonEnvironmentCanada:
                    return CSSPEnumsRes.LaboratoryEnumMonctonEnvironmentCanada;
                case LaboratoryEnum.BIOEnvironmentCanada:
                    return CSSPEnumsRes.LaboratoryEnumBIOEnvironmentCanada;
                case LaboratoryEnum.EasternCharlotteWaterwayLaboratory:
                    return CSSPEnumsRes.LaboratoryEnumEasternCharlotteWaterwayLaboratory;
                case LaboratoryEnum.InstitutDeRechercheSurLesZonesCotieres:
                    return CSSPEnumsRes.LaboratoryEnumInstitutDeRechercheSurLesZonesCotieres;
                case LaboratoryEnum.CentreDeRechercheSurLesAliments:
                    return CSSPEnumsRes.LaboratoryEnumCentreDeRechercheSurLesAliments;
                case LaboratoryEnum.CaraquetMobileLaboratoryEnvironmentCanada:
                    return CSSPEnumsRes.LaboratoryEnumCaraquetMobileLaboratoryEnvironmentCanada;
                case LaboratoryEnum.MaxxamAnalyticsBedford:
                    return CSSPEnumsRes.LaboratoryEnumMaxxamAnalyticsBedford;
                case LaboratoryEnum.MaxxamAnalyticsSydney:
                    return CSSPEnumsRes.LaboratoryEnumMaxxamAnalyticsSydney;
                case LaboratoryEnum.PEIAnalyticalLaboratory:
                    return CSSPEnumsRes.LaboratoryEnumPEIAnalyticalLaboratory;
                case LaboratoryEnum.NLMobileLaboratory:
                    return CSSPEnumsRes.LaboratoryEnumNLMobileLaboratory;
                case LaboratoryEnum.PetroformaInc:
                    return CSSPEnumsRes.LaboratoryEnumPetroformaInc;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_LabSheetStatusEnum(LabSheetStatusEnum? labSheetStatus)
        {
            if (labSheetStatus == null)
                return CSSPEnumsRes.Empty;

            switch (labSheetStatus)
            {
                case LabSheetStatusEnum.Error:
                    return CSSPEnumsRes.Empty;
                case LabSheetStatusEnum.Created:
                    return CSSPEnumsRes.LabSheetStatusEnumCreated;
                case LabSheetStatusEnum.Transferred:
                    return CSSPEnumsRes.LabSheetStatusEnumTransferred;
                case LabSheetStatusEnum.Accepted:
                    return CSSPEnumsRes.LabSheetStatusEnumAccepted;
                case LabSheetStatusEnum.Rejected:
                    return CSSPEnumsRes.LabSheetStatusEnumRejected;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_LabSheetTypeEnum(LabSheetTypeEnum? labSheetType)
        {
            if (labSheetType == null)
                return CSSPEnumsRes.Empty;

            switch (labSheetType)
            {
                case LabSheetTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case LabSheetTypeEnum.A1:
                    return CSSPEnumsRes.LabSheetTypeEnumA1;
                case LabSheetTypeEnum.LTB:
                    return CSSPEnumsRes.LabSheetTypeEnumLTB;
                case LabSheetTypeEnum.EC:
                    return CSSPEnumsRes.LabSheetTypeEnumEC;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_LanguageEnum(LanguageEnum? language)
        {
            if (language == null)
                return CSSPEnumsRes.Empty;

            switch (language)
            {
                case LanguageEnum.Error:
                    return CSSPEnumsRes.Empty;
                case LanguageEnum.en:
                    return CSSPEnumsRes.LanguageEnumen;
                case LanguageEnum.fr:
                    return CSSPEnumsRes.LanguageEnumfr;
                case LanguageEnum.enAndfr:
                    return CSSPEnumsRes.LanguageEnumenAndfr;
                case LanguageEnum.es:
                    return CSSPEnumsRes.LanguageEnumes;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_LogCommandEnum(LogCommandEnum? logCommand)
        {
            if (logCommand == null)
                return CSSPEnumsRes.Empty;

            switch (logCommand)
            {
                case LogCommandEnum.Error:
                    return CSSPEnumsRes.Empty;
                case LogCommandEnum.Add:
                    return CSSPEnumsRes.LogCommandEnumAdd;
                case LogCommandEnum.Change:
                    return CSSPEnumsRes.LogCommandEnumChange;
                case LogCommandEnum.Delete:
                    return CSSPEnumsRes.LogCommandEnumDelete;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_MapInfoDrawTypeEnum(MapInfoDrawTypeEnum? mapInfoDrawType)
        {
            if (mapInfoDrawType == null)
                return CSSPEnumsRes.Empty;

            switch (mapInfoDrawType)
            {
                case MapInfoDrawTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case MapInfoDrawTypeEnum.Point:
                    return CSSPEnumsRes.MapInfoDrawTypeEnumPoint;
                case MapInfoDrawTypeEnum.Polyline:
                    return CSSPEnumsRes.MapInfoDrawTypeEnumPolyline;
                case MapInfoDrawTypeEnum.Polygon:
                    return CSSPEnumsRes.MapInfoDrawTypeEnumPolygon;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_MikeBoundaryConditionLevelOrVelocityEnum(MikeBoundaryConditionLevelOrVelocityEnum? mikeBoundaryConditionLevelOrVelocity)
        {
            if (mikeBoundaryConditionLevelOrVelocity == null)
                return CSSPEnumsRes.Empty;

            switch (mikeBoundaryConditionLevelOrVelocity)
            {
                case MikeBoundaryConditionLevelOrVelocityEnum.Error:
                    return CSSPEnumsRes.Empty;
                case MikeBoundaryConditionLevelOrVelocityEnum.Level:
                    return CSSPEnumsRes.MikeBoundaryConditionLevelOrVelocityEnumLevel;
                case MikeBoundaryConditionLevelOrVelocityEnum.Velocity:
                    return CSSPEnumsRes.MikeBoundaryConditionLevelOrVelocityEnumVelocity;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_MikeScenarioSpecialResultKMLTypeEnum(MikeScenarioSpecialResultKMLTypeEnum? mikeScenarioSpecialResultKMLType)
        {
            if (mikeScenarioSpecialResultKMLType == null)
                return CSSPEnumsRes.Empty;

            switch (mikeScenarioSpecialResultKMLType)
            {
                case MikeScenarioSpecialResultKMLTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case MikeScenarioSpecialResultKMLTypeEnum.Mesh:
                    return CSSPEnumsRes.MikeScenarioSpecialResultKMLTypeEnumMesh;
                case MikeScenarioSpecialResultKMLTypeEnum.StudyArea:
                    return CSSPEnumsRes.MikeScenarioSpecialResultKMLTypeEnumStudyArea;
                case MikeScenarioSpecialResultKMLTypeEnum.BoundaryConditions:
                    return CSSPEnumsRes.MikeScenarioSpecialResultKMLTypeEnumBoundaryConditions;
                case MikeScenarioSpecialResultKMLTypeEnum.PollutionLimit:
                    return CSSPEnumsRes.MikeScenarioSpecialResultKMLTypeEnumPollutionLimit;
                case MikeScenarioSpecialResultKMLTypeEnum.PollutionAnimation:
                    return CSSPEnumsRes.MikeScenarioSpecialResultKMLTypeEnumPollutionAnimation;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_MWQMSiteLatestClassificationEnum(MWQMSiteLatestClassificationEnum? mWQMSiteLatestClassification)
        {
            if (mWQMSiteLatestClassification == null)
                return CSSPEnumsRes.Empty;

            switch (mWQMSiteLatestClassification)
            {
                case MWQMSiteLatestClassificationEnum.Error:
                    return CSSPEnumsRes.Empty;
                case MWQMSiteLatestClassificationEnum.Approved:
                    return CSSPEnumsRes.MWQMSiteLatestClassificationEnumApproved;
                case MWQMSiteLatestClassificationEnum.ConditionallyApproved:
                    return CSSPEnumsRes.MWQMSiteLatestClassificationEnumConditionallyApproved;
                case MWQMSiteLatestClassificationEnum.Restricted:
                    return CSSPEnumsRes.MWQMSiteLatestClassificationEnumRestricted;
                case MWQMSiteLatestClassificationEnum.ConditionallyRestricted:
                    return CSSPEnumsRes.MWQMSiteLatestClassificationEnumConditionallyRestricted;
                case MWQMSiteLatestClassificationEnum.Prohibited:
                    return CSSPEnumsRes.MWQMSiteLatestClassificationEnumProhibited;
                case MWQMSiteLatestClassificationEnum.Unclassified:
                    return CSSPEnumsRes.MWQMSiteLatestClassificationEnumUnclassified;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_PolSourceInactiveReasonEnum(PolSourceInactiveReasonEnum? polSourceInactiveReason)
        {
            if (polSourceInactiveReason == null)
                return CSSPEnumsRes.Empty;

            switch (polSourceInactiveReason)
            {
                case PolSourceInactiveReasonEnum.Error:
                    return CSSPEnumsRes.Empty;
                case PolSourceInactiveReasonEnum.Abandoned:
                    return CSSPEnumsRes.PolSourceInactiveReasonEnumAbandoned;
                case PolSourceInactiveReasonEnum.Closed:
                    return CSSPEnumsRes.PolSourceInactiveReasonEnumClosed;
                case PolSourceInactiveReasonEnum.Removed:
                    return CSSPEnumsRes.PolSourceInactiveReasonEnumRemoved;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_PolSourceIssueRiskEnum(PolSourceIssueRiskEnum? polSourceIssueRisk)
        {
            if (polSourceIssueRisk == null)
                return CSSPEnumsRes.Empty;

            switch (polSourceIssueRisk)
            {
                case PolSourceIssueRiskEnum.Error:
                    return CSSPEnumsRes.Empty;
                case PolSourceIssueRiskEnum.LowRisk:
                    return CSSPEnumsRes.PolSourceIssueRiskEnumLowRisk;
                case PolSourceIssueRiskEnum.ModerateRisk:
                    return CSSPEnumsRes.PolSourceIssueRiskEnumModerateRisk;
                case PolSourceIssueRiskEnum.HighRisk:
                    return CSSPEnumsRes.PolSourceIssueRiskEnumHighRisk;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_PolSourceObsInfoTypeEnum(PolSourceObsInfoTypeEnum? polSourceObsInfoType)
        {
            if (polSourceObsInfoType == null)
                return CSSPEnumsRes.Empty;

            switch (polSourceObsInfoType)
            {
                case PolSourceObsInfoTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case PolSourceObsInfoTypeEnum.Description:
                    return CSSPEnumsRes.PolSourceObsInfoTypeEnumDescription;
                case PolSourceObsInfoTypeEnum.Report:
                    return CSSPEnumsRes.PolSourceObsInfoTypeEnumReport;
                case PolSourceObsInfoTypeEnum.Text:
                    return CSSPEnumsRes.PolSourceObsInfoTypeEnumText;
                case PolSourceObsInfoTypeEnum.Initial:
                    return CSSPEnumsRes.PolSourceObsInfoTypeEnumInitial;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_PreliminaryTreatmentTypeEnum(PreliminaryTreatmentTypeEnum? preliminaryTreatmentType)
        {
            if (preliminaryTreatmentType == null)
                return CSSPEnumsRes.Empty;

            switch (preliminaryTreatmentType)
            {
                case PreliminaryTreatmentTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case PreliminaryTreatmentTypeEnum.NotApplicable:
                    return CSSPEnumsRes.PreliminaryTreatmentTypeEnumNotApplicable;
                case PreliminaryTreatmentTypeEnum.BarScreen:
                    return CSSPEnumsRes.PreliminaryTreatmentTypeEnumBarScreen;
                case PreliminaryTreatmentTypeEnum.Grinder:
                    return CSSPEnumsRes.PreliminaryTreatmentTypeEnumGrinder;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_PrimaryTreatmentTypeEnum(PrimaryTreatmentTypeEnum? primaryTreatmentType)
        {
            if (primaryTreatmentType == null)
                return CSSPEnumsRes.Empty;

            switch (primaryTreatmentType)
            {
                case PrimaryTreatmentTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case PrimaryTreatmentTypeEnum.NotApplicable:
                    return CSSPEnumsRes.PrimaryTreatmentTypeEnumNotApplicable;
                case PrimaryTreatmentTypeEnum.Sedimentation:
                    return CSSPEnumsRes.PrimaryTreatmentTypeEnumSedimentation;
                case PrimaryTreatmentTypeEnum.ChemicalCoagulation:
                    return CSSPEnumsRes.PrimaryTreatmentTypeEnumChemicalCoagulation;
                case PrimaryTreatmentTypeEnum.Filtration:
                    return CSSPEnumsRes.PrimaryTreatmentTypeEnumFiltration;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_ReportConditionEnum(ReportConditionEnum? reportCondition)
        {
            if (reportCondition == null)
                return CSSPEnumsRes.Empty;

            switch (reportCondition)
            {
                case ReportConditionEnum.Error:
                    return CSSPEnumsRes.Empty;
                case ReportConditionEnum.ReportConditionTrue:
                    return CSSPEnumsRes.ReportConditionEnumReportConditionTrue;
                case ReportConditionEnum.ReportConditionFalse:
                    return CSSPEnumsRes.ReportConditionEnumReportConditionFalse;
                case ReportConditionEnum.ReportConditionContain:
                    return CSSPEnumsRes.ReportConditionEnumReportConditionContain;
                case ReportConditionEnum.ReportConditionStart:
                    return CSSPEnumsRes.ReportConditionEnumReportConditionStart;
                case ReportConditionEnum.ReportConditionEnd:
                    return CSSPEnumsRes.ReportConditionEnumReportConditionEnd;
                case ReportConditionEnum.ReportConditionBigger:
                    return CSSPEnumsRes.ReportConditionEnumReportConditionBigger;
                case ReportConditionEnum.ReportConditionSmaller:
                    return CSSPEnumsRes.ReportConditionEnumReportConditionSmaller;
                case ReportConditionEnum.ReportConditionEqual:
                    return CSSPEnumsRes.ReportConditionEnumReportConditionEqual;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_ReportFieldTypeEnum(ReportFieldTypeEnum? reportFieldType)
        {
            if (reportFieldType == null)
                return CSSPEnumsRes.Empty;

            switch (reportFieldType)
            {
                case ReportFieldTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case ReportFieldTypeEnum.NumberWhole:
                    return CSSPEnumsRes.ReportFieldTypeEnumNumberWhole;
                case ReportFieldTypeEnum.NumberWithDecimal:
                    return CSSPEnumsRes.ReportFieldTypeEnumNumberWithDecimal;
                case ReportFieldTypeEnum.DateAndTime:
                    return CSSPEnumsRes.ReportFieldTypeEnumDateAndTime;
                case ReportFieldTypeEnum.Text:
                    return CSSPEnumsRes.ReportFieldTypeEnumText;
                case ReportFieldTypeEnum.TrueOrFalse:
                    return CSSPEnumsRes.ReportFieldTypeEnumTrueOrFalse;
                case ReportFieldTypeEnum.FilePurpose:
                    return CSSPEnumsRes.ReportFieldTypeEnumFilePurpose;
                case ReportFieldTypeEnum.FileType:
                    return CSSPEnumsRes.ReportFieldTypeEnumFileType;
                case ReportFieldTypeEnum.TranslationStatus:
                    return CSSPEnumsRes.ReportFieldTypeEnumTranslationStatus;
                case ReportFieldTypeEnum.BoxModelResultType:
                    return CSSPEnumsRes.ReportFieldTypeEnumBoxModelResultType;
                case ReportFieldTypeEnum.InfrastructureType:
                    return CSSPEnumsRes.ReportFieldTypeEnumInfrastructureType;
                case ReportFieldTypeEnum.FacilityType:
                    return CSSPEnumsRes.ReportFieldTypeEnumFacilityType;
                case ReportFieldTypeEnum.AerationType:
                    return CSSPEnumsRes.ReportFieldTypeEnumAerationType;
                case ReportFieldTypeEnum.PreliminaryTreatmentType:
                    return CSSPEnumsRes.ReportFieldTypeEnumPreliminaryTreatmentType;
                case ReportFieldTypeEnum.PrimaryTreatmentType:
                    return CSSPEnumsRes.ReportFieldTypeEnumPrimaryTreatmentType;
                case ReportFieldTypeEnum.SecondaryTreatmentType:
                    return CSSPEnumsRes.ReportFieldTypeEnumSecondaryTreatmentType;
                case ReportFieldTypeEnum.TertiaryTreatmentType:
                    return CSSPEnumsRes.ReportFieldTypeEnumTertiaryTreatmentType;
                case ReportFieldTypeEnum.TreatmentType:
                    return CSSPEnumsRes.ReportFieldTypeEnumTreatmentType;
                case ReportFieldTypeEnum.DisinfectionType:
                    return CSSPEnumsRes.ReportFieldTypeEnumDisinfectionType;
                case ReportFieldTypeEnum.CollectionSystemType:
                    return CSSPEnumsRes.ReportFieldTypeEnumCollectionSystemType;
                case ReportFieldTypeEnum.AlarmSystemType:
                    return CSSPEnumsRes.ReportFieldTypeEnumAlarmSystemType;
                case ReportFieldTypeEnum.ScenarioStatus:
                    return CSSPEnumsRes.ReportFieldTypeEnumScenarioStatus;
                case ReportFieldTypeEnum.StorageDataType:
                    return CSSPEnumsRes.ReportFieldTypeEnumStorageDataType;
                case ReportFieldTypeEnum.Language:
                    return CSSPEnumsRes.ReportFieldTypeEnumLanguage;
                case ReportFieldTypeEnum.SampleType:
                    return CSSPEnumsRes.ReportFieldTypeEnumSampleType;
                case ReportFieldTypeEnum.BeaufortScale:
                    return CSSPEnumsRes.ReportFieldTypeEnumBeaufortScale;
                case ReportFieldTypeEnum.AnalyzeMethod:
                    return CSSPEnumsRes.ReportFieldTypeEnumAnalyzeMethod;
                case ReportFieldTypeEnum.SampleMatrix:
                    return CSSPEnumsRes.ReportFieldTypeEnumSampleMatrix;
                case ReportFieldTypeEnum.Laboratory:
                    return CSSPEnumsRes.ReportFieldTypeEnumLaboratory;
                case ReportFieldTypeEnum.SampleStatus:
                    return CSSPEnumsRes.ReportFieldTypeEnumSampleStatus;
                case ReportFieldTypeEnum.SamplingPlanType:
                    return CSSPEnumsRes.ReportFieldTypeEnumSamplingPlanType;
                case ReportFieldTypeEnum.LabSheetSampleType:
                    return CSSPEnumsRes.ReportFieldTypeEnumLabSheetSampleType;
                case ReportFieldTypeEnum.LabSheetType:
                    return CSSPEnumsRes.ReportFieldTypeEnumLabSheetType;
                case ReportFieldTypeEnum.LabSheetStatus:
                    return CSSPEnumsRes.ReportFieldTypeEnumLabSheetStatus;
                case ReportFieldTypeEnum.PolSourceInactiveReason:
                    return CSSPEnumsRes.ReportFieldTypeEnumPolSourceInactiveReason;
                case ReportFieldTypeEnum.PolSourceObsInfo:
                    return CSSPEnumsRes.ReportFieldTypeEnumPolSourceObsInfo;
                case ReportFieldTypeEnum.AddressType:
                    return CSSPEnumsRes.ReportFieldTypeEnumAddressType;
                case ReportFieldTypeEnum.StreetType:
                    return CSSPEnumsRes.ReportFieldTypeEnumStreetType;
                case ReportFieldTypeEnum.ContactTitle:
                    return CSSPEnumsRes.ReportFieldTypeEnumContactTitle;
                case ReportFieldTypeEnum.EmailType:
                    return CSSPEnumsRes.ReportFieldTypeEnumEmailType;
                case ReportFieldTypeEnum.TelType:
                    return CSSPEnumsRes.ReportFieldTypeEnumTelType;
                case ReportFieldTypeEnum.TideText:
                    return CSSPEnumsRes.ReportFieldTypeEnumTideText;
                case ReportFieldTypeEnum.TideDataType:
                    return CSSPEnumsRes.ReportFieldTypeEnumTideDataType;
                case ReportFieldTypeEnum.SpecialTableType:
                    return CSSPEnumsRes.ReportFieldTypeEnumSpecialTableType;
                case ReportFieldTypeEnum.MWQMSiteLatestClassification:
                    return CSSPEnumsRes.ReportFieldTypeEnumMWQMSiteLatestClassification;
                case ReportFieldTypeEnum.PolSourceIssueRisk:
                    return CSSPEnumsRes.ReportFieldTypeEnumPolSourceIssueRisk;
                case ReportFieldTypeEnum.MikeScenarioSpecialResultKMLType:
                    return CSSPEnumsRes.ReportFieldTypeEnumMikeScenarioSpecialResultKMLType;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_ReportFileTypeEnum(ReportFileTypeEnum? reportFileType)
        {
            if (reportFileType == null)
                return CSSPEnumsRes.Empty;

            switch (reportFileType)
            {
                case ReportFileTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case ReportFileTypeEnum.CSV:
                    return CSSPEnumsRes.ReportFileTypeEnumCSV;
                case ReportFileTypeEnum.Word:
                    return CSSPEnumsRes.ReportFileTypeEnumWord;
                case ReportFileTypeEnum.Excel:
                    return CSSPEnumsRes.ReportFileTypeEnumExcel;
                case ReportFileTypeEnum.KML:
                    return CSSPEnumsRes.ReportFileTypeEnumKML;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_ReportFormatingDateEnum(ReportFormatingDateEnum? reportFormatingDate)
        {
            if (reportFormatingDate == null)
                return CSSPEnumsRes.Empty;

            switch (reportFormatingDate)
            {
                case ReportFormatingDateEnum.Error:
                    return CSSPEnumsRes.Empty;
                case ReportFormatingDateEnum.ReportFormatingDateYearOnly:
                    return CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateYearOnly;
                case ReportFormatingDateEnum.ReportFormatingDateMonthDecimalOnly:
                    return CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateMonthDecimalOnly;
                case ReportFormatingDateEnum.ReportFormatingDateMonthShortTextOnly:
                    return CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateMonthShortTextOnly;
                case ReportFormatingDateEnum.ReportFormatingDateMonthFullTextOnly:
                    return CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateMonthFullTextOnly;
                case ReportFormatingDateEnum.ReportFormatingDateDayOnly:
                    return CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateDayOnly;
                case ReportFormatingDateEnum.ReportFormatingDateHourOnly:
                    return CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateHourOnly;
                case ReportFormatingDateEnum.ReportFormatingDateMinuteOnly:
                    return CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateMinuteOnly;
                case ReportFormatingDateEnum.ReportFormatingDateYearMonthDecimalDay:
                    return CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateYearMonthDecimalDay;
                case ReportFormatingDateEnum.ReportFormatingDateYearMonthShortTextDay:
                    return CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateYearMonthShortTextDay;
                case ReportFormatingDateEnum.ReportFormatingDateYearMonthFullTextDay:
                    return CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateYearMonthFullTextDay;
                case ReportFormatingDateEnum.ReportFormatingDateYearMonthDecimalDayHourMinute:
                    return CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateYearMonthDecimalDayHourMinute;
                case ReportFormatingDateEnum.ReportFormatingDateYearMonthShortTextDayHourMinute:
                    return CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateYearMonthShortTextDayHourMinute;
                case ReportFormatingDateEnum.ReportFormatingDateYearMonthFullTextDayHourMinute:
                    return CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateYearMonthFullTextDayHourMinute;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_ReportFormatingNumberEnum(ReportFormatingNumberEnum? reportFormatingNumber)
        {
            if (reportFormatingNumber == null)
                return CSSPEnumsRes.Empty;

            switch (reportFormatingNumber)
            {
                case ReportFormatingNumberEnum.Error:
                    return CSSPEnumsRes.Empty;
                case ReportFormatingNumberEnum.ReportFormatingNumber0Decimal:
                    return CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumber0Decimal;
                case ReportFormatingNumberEnum.ReportFormatingNumber1Decimal:
                    return CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumber1Decimal;
                case ReportFormatingNumberEnum.ReportFormatingNumber2Decimal:
                    return CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumber2Decimal;
                case ReportFormatingNumberEnum.ReportFormatingNumber3Decimal:
                    return CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumber3Decimal;
                case ReportFormatingNumberEnum.ReportFormatingNumber4Decimal:
                    return CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumber4Decimal;
                case ReportFormatingNumberEnum.ReportFormatingNumber5Decimal:
                    return CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumber5Decimal;
                case ReportFormatingNumberEnum.ReportFormatingNumber6Decimal:
                    return CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumber6Decimal;
                case ReportFormatingNumberEnum.ReportFormatingNumberScientific0Decimal:
                    return CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumberScientific0Decimal;
                case ReportFormatingNumberEnum.ReportFormatingNumberScientific1Decimal:
                    return CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumberScientific1Decimal;
                case ReportFormatingNumberEnum.ReportFormatingNumberScientific2Decimal:
                    return CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumberScientific2Decimal;
                case ReportFormatingNumberEnum.ReportFormatingNumberScientific3Decimal:
                    return CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumberScientific3Decimal;
                case ReportFormatingNumberEnum.ReportFormatingNumberScientific4Decimal:
                    return CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumberScientific4Decimal;
                case ReportFormatingNumberEnum.ReportFormatingNumberScientific5Decimal:
                    return CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumberScientific5Decimal;
                case ReportFormatingNumberEnum.ReportFormatingNumberScientific6Decimal:
                    return CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumberScientific6Decimal;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_ReportSortingEnum(ReportSortingEnum? reportSorting)
        {
            if (reportSorting == null)
                return CSSPEnumsRes.Empty;

            switch (reportSorting)
            {
                case ReportSortingEnum.Error:
                    return CSSPEnumsRes.Empty;
                case ReportSortingEnum.ReportSortingAscending:
                    return CSSPEnumsRes.ReportSortingEnumReportSortingAscending;
                case ReportSortingEnum.ReportSortingDescending:
                    return CSSPEnumsRes.ReportSortingEnumReportSortingDescending;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_ReportTreeNodeSubTypeEnum(ReportTreeNodeSubTypeEnum? reportTreeNodeSubType)
        {
            if (reportTreeNodeSubType == null)
                return CSSPEnumsRes.Empty;

            switch (reportTreeNodeSubType)
            {
                case ReportTreeNodeSubTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case ReportTreeNodeSubTypeEnum.TableSelectable:
                    return CSSPEnumsRes.ReportTreeNodeSubTypeEnumTableSelectable;
                case ReportTreeNodeSubTypeEnum.Field:
                    return CSSPEnumsRes.ReportTreeNodeSubTypeEnumField;
                case ReportTreeNodeSubTypeEnum.FieldsHolder:
                    return CSSPEnumsRes.ReportTreeNodeSubTypeEnumFieldsHolder;
                case ReportTreeNodeSubTypeEnum.TableNotSelectable:
                    return CSSPEnumsRes.ReportTreeNodeSubTypeEnumTableNotSelectable;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_ReportTreeNodeTypeEnum(ReportTreeNodeTypeEnum? reportTreeNodeType)
        {
            if (reportTreeNodeType == null)
                return CSSPEnumsRes.Empty;

            switch (reportTreeNodeType)
            {
                case ReportTreeNodeTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case ReportTreeNodeTypeEnum.ReportRootType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportRootType;
                case ReportTreeNodeTypeEnum.ReportCountryType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportCountryType;
                case ReportTreeNodeTypeEnum.ReportProvinceType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportProvinceType;
                case ReportTreeNodeTypeEnum.ReportAreaType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportAreaType;
                case ReportTreeNodeTypeEnum.ReportSectorType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSectorType;
                case ReportTreeNodeTypeEnum.ReportSubsectorType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorType;
                case ReportTreeNodeTypeEnum.ReportMWQMSiteType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMSiteType;
                case ReportTreeNodeTypeEnum.ReportMWQMRunType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMRunType;
                case ReportTreeNodeTypeEnum.ReportPolSourceSiteType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportPolSourceSiteType;
                case ReportTreeNodeTypeEnum.ReportMunicipalityType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMunicipalityType;
                case ReportTreeNodeTypeEnum.ReportRootFileType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportRootFileType;
                case ReportTreeNodeTypeEnum.ReportInfrastructureType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportInfrastructureType;
                case ReportTreeNodeTypeEnum.ReportBoxModelType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportBoxModelType;
                case ReportTreeNodeTypeEnum.ReportVisualPlumesScenarioType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportVisualPlumesScenarioType;
                case ReportTreeNodeTypeEnum.ReportMikeScenarioType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMikeScenarioType;
                case ReportTreeNodeTypeEnum.ReportMikeSourceType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMikeSourceType;
                case ReportTreeNodeTypeEnum.ReportMWQMSiteSampleType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMSiteSampleType;
                case ReportTreeNodeTypeEnum.ReportPolSourceSiteObsType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportPolSourceSiteObsType;
                case ReportTreeNodeTypeEnum.ReportPolSourceSiteObsIssueType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportPolSourceSiteObsIssueType;
                case ReportTreeNodeTypeEnum.ReportMikeScenarioGeneralParameterType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMikeScenarioGeneralParameterType;
                case ReportTreeNodeTypeEnum.ReportMunicipalityContactType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMunicipalityContactType;
                case ReportTreeNodeTypeEnum.ReportConditionType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportConditionType;
                case ReportTreeNodeTypeEnum.ReportStatisticType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportStatisticType;
                case ReportTreeNodeTypeEnum.ReportFieldsType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportFieldsType;
                case ReportTreeNodeTypeEnum.ReportFieldType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportFieldType;
                case ReportTreeNodeTypeEnum.ReportPolSourceSiteAddressType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportPolSourceSiteAddressType;
                case ReportTreeNodeTypeEnum.ReportMunicipalityContactTelType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMunicipalityContactTelType;
                case ReportTreeNodeTypeEnum.ReportMunicipalityContactEmailType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMunicipalityContactEmailType;
                case ReportTreeNodeTypeEnum.ReportBoxModelResultType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportBoxModelResultType;
                case ReportTreeNodeTypeEnum.ReportClimateSiteType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportClimateSiteType;
                case ReportTreeNodeTypeEnum.ReportClimateSiteDataType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportClimateSiteDataType;
                case ReportTreeNodeTypeEnum.ReportHydrometricSiteType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportHydrometricSiteType;
                case ReportTreeNodeTypeEnum.ReportHydrometricSiteDataType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportHydrometricSiteDataType;
                case ReportTreeNodeTypeEnum.ReportHydrometricSiteRatingCurveType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportHydrometricSiteRatingCurveType;
                case ReportTreeNodeTypeEnum.ReportHydrometricSiteRatingCurveValueType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportHydrometricSiteRatingCurveValueType;
                case ReportTreeNodeTypeEnum.ReportInfrastructureAddressType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportInfrastructureAddressType;
                case ReportTreeNodeTypeEnum.ReportSubsectorLabSheetType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorLabSheetType;
                case ReportTreeNodeTypeEnum.ReportSubsectorLabSheetDetailType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorLabSheetDetailType;
                case ReportTreeNodeTypeEnum.ReportSubsectorLabSheetTubeMPNDetailType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorLabSheetTubeMPNDetailType;
                case ReportTreeNodeTypeEnum.ReportMWQMRunSampleType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMRunSampleType;
                case ReportTreeNodeTypeEnum.ReportCountryFileType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportCountryFileType;
                case ReportTreeNodeTypeEnum.ReportProvinceFileType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportProvinceFileType;
                case ReportTreeNodeTypeEnum.ReportAreaFileType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportAreaFileType;
                case ReportTreeNodeTypeEnum.ReportSectorFileType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSectorFileType;
                case ReportTreeNodeTypeEnum.ReportSubsectorFileType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorFileType;
                case ReportTreeNodeTypeEnum.ReportMWQMSiteFileType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMSiteFileType;
                case ReportTreeNodeTypeEnum.ReportMWQMRunFileType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMRunFileType;
                case ReportTreeNodeTypeEnum.ReportPolSourceSiteFileType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportPolSourceSiteFileType;
                case ReportTreeNodeTypeEnum.ReportMunicipalityFileType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMunicipalityFileType;
                case ReportTreeNodeTypeEnum.ReportInfrastructureFileType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportInfrastructureFileType;
                case ReportTreeNodeTypeEnum.ReportMikeScenarioFileType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMikeScenarioFileType;
                case ReportTreeNodeTypeEnum.ReportMikeSourceStartEndType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMikeSourceStartEndType;
                case ReportTreeNodeTypeEnum.ReportMWQMRunLabSheetType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMRunLabSheetType;
                case ReportTreeNodeTypeEnum.ReportMWQMRunLabSheetDetailType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMRunLabSheetDetailType;
                case ReportTreeNodeTypeEnum.ReportMWQMRunLabSheetTubeMPNDetailType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMRunLabSheetTubeMPNDetailType;
                case ReportTreeNodeTypeEnum.ReportSamplingPlanLabSheetType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSamplingPlanLabSheetType;
                case ReportTreeNodeTypeEnum.ReportSamplingPlanLabSheetDetailType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSamplingPlanLabSheetDetailType;
                case ReportTreeNodeTypeEnum.ReportSamplingPlanLabSheetTubeMPNDetailType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSamplingPlanLabSheetTubeMPNDetailType;
                case ReportTreeNodeTypeEnum.ReportSamplingPlanType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSamplingPlanType;
                case ReportTreeNodeTypeEnum.ReportSamplingPlanSubsectorType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSamplingPlanSubsectorType;
                case ReportTreeNodeTypeEnum.ReportSamplingPlanSubsectorSiteType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSamplingPlanSubsectorSiteType;
                case ReportTreeNodeTypeEnum.ReportMikeBoundaryConditionType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMikeBoundaryConditionType;
                case ReportTreeNodeTypeEnum.ReportVisualPlumesScenarioAmbientType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportVisualPlumesScenarioAmbientType;
                case ReportTreeNodeTypeEnum.ReportVisualPlumesScenarioResultType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportVisualPlumesScenarioResultType;
                case ReportTreeNodeTypeEnum.ReportMPNLookupType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMPNLookupType;
                case ReportTreeNodeTypeEnum.ReportMWQMSiteStartAndEndType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMSiteStartAndEndType;
                case ReportTreeNodeTypeEnum.ReportSubsectorTideSiteType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorTideSiteType;
                case ReportTreeNodeTypeEnum.ReportSubsectorTideSiteDataType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorTideSiteDataType;
                case ReportTreeNodeTypeEnum.ReportOrderType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportOrderType;
                case ReportTreeNodeTypeEnum.ReportFormatType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportFormatType;
                case ReportTreeNodeTypeEnum.ReportMunicipalityContactAddressType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMunicipalityContactAddressType;
                case ReportTreeNodeTypeEnum.ReportSubsectorClimateSiteType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorClimateSiteType;
                case ReportTreeNodeTypeEnum.ReportSubsectorHydrometricSiteType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorHydrometricSiteType;
                case ReportTreeNodeTypeEnum.ReportSubsectorHydrometricSiteDataType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorHydrometricSiteDataType;
                case ReportTreeNodeTypeEnum.ReportSubsectorHydrometricSiteRatingCurveType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorHydrometricSiteRatingCurveType;
                case ReportTreeNodeTypeEnum.ReportSubsectorClimateSiteDataType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorClimateSiteDataType;
                case ReportTreeNodeTypeEnum.ReportSubsectorHydrometricSiteRatingCurveValueType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorHydrometricSiteRatingCurveValueType;
                case ReportTreeNodeTypeEnum.ReportSubsectorSpecialTableType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorSpecialTableType;
                case ReportTreeNodeTypeEnum.ReportMikeScenarioSpecialResultKMLType:
                    return CSSPEnumsRes.ReportTreeNodeTypeEnumReportMikeScenarioSpecialResultKMLType;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_SameDayNextDayEnum(SameDayNextDayEnum? sameDayNextDay)
        {
            if (sameDayNextDay == null)
                return CSSPEnumsRes.Empty;

            switch (sameDayNextDay)
            {
                case SameDayNextDayEnum.Error:
                    return CSSPEnumsRes.Empty;
                case SameDayNextDayEnum.SameDay:
                    return CSSPEnumsRes.SameDayNextDayEnumSameDay;
                case SameDayNextDayEnum.NextDay:
                    return CSSPEnumsRes.SameDayNextDayEnumNextDay;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_SampleMatrixEnum(SampleMatrixEnum? sampleMatrix)
        {
            if (sampleMatrix == null)
                return CSSPEnumsRes.Empty;

            switch (sampleMatrix)
            {
                case SampleMatrixEnum.Error:
                    return CSSPEnumsRes.Empty;
                case SampleMatrixEnum.W:
                    return CSSPEnumsRes.SampleMatrixEnumW;
                case SampleMatrixEnum.S:
                    return CSSPEnumsRes.SampleMatrixEnumS;
                case SampleMatrixEnum.B:
                    return CSSPEnumsRes.SampleMatrixEnumB;
                case SampleMatrixEnum.MPNQ:
                    return CSSPEnumsRes.SampleMatrixEnumMPNQ;
                case SampleMatrixEnum.SampleMatrix5:
                    return CSSPEnumsRes.SampleMatrixEnumSampleMatrix5;
                case SampleMatrixEnum.SampleMatrix6:
                    return CSSPEnumsRes.SampleMatrixEnumSampleMatrix6;
                case SampleMatrixEnum.Water:
                    return CSSPEnumsRes.SampleMatrixEnumWater;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_SampleStatusEnum(SampleStatusEnum? sampleStatus)
        {
            if (sampleStatus == null)
                return CSSPEnumsRes.Empty;

            switch (sampleStatus)
            {
                case SampleStatusEnum.Error:
                    return CSSPEnumsRes.Empty;
                case SampleStatusEnum.Active:
                    return CSSPEnumsRes.SampleStatusEnumActive;
                case SampleStatusEnum.Archived:
                    return CSSPEnumsRes.SampleStatusEnumArchived;
                case SampleStatusEnum.SampleStatus3:
                    return CSSPEnumsRes.SampleStatusEnumSampleStatus3;
                case SampleStatusEnum.SampleStatus4:
                    return CSSPEnumsRes.SampleStatusEnumSampleStatus4;
                case SampleStatusEnum.SampleStatus5:
                    return CSSPEnumsRes.SampleStatusEnumSampleStatus5;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_SampleTypeEnum(SampleTypeEnum? sampleType)
        {
            if (sampleType == null)
                return CSSPEnumsRes.Empty;

            switch (sampleType)
            {
                case SampleTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case SampleTypeEnum.DailyDuplicate:
                    return CSSPEnumsRes.SampleTypeEnumDailyDuplicate;
                case SampleTypeEnum.Infrastructure:
                    return CSSPEnumsRes.SampleTypeEnumInfrastructure;
                case SampleTypeEnum.IntertechDuplicate:
                    return CSSPEnumsRes.SampleTypeEnumIntertechDuplicate;
                case SampleTypeEnum.IntertechRead:
                    return CSSPEnumsRes.SampleTypeEnumIntertechRead;
                case SampleTypeEnum.RainCMPRoutine:
                    return CSSPEnumsRes.SampleTypeEnumRainCMPRoutine;
                case SampleTypeEnum.RainRun:
                    return CSSPEnumsRes.SampleTypeEnumRainRun;
                case SampleTypeEnum.ReopeningEmergencyRain:
                    return CSSPEnumsRes.SampleTypeEnumReopeningEmergencyRain;
                case SampleTypeEnum.ReopeningSpill:
                    return CSSPEnumsRes.SampleTypeEnumReopeningSpill;
                case SampleTypeEnum.Routine:
                    return CSSPEnumsRes.SampleTypeEnumRoutine;
                case SampleTypeEnum.Sanitary:
                    return CSSPEnumsRes.SampleTypeEnumSanitary;
                case SampleTypeEnum.Study:
                    return CSSPEnumsRes.SampleTypeEnumStudy;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_SamplingPlanTypeEnum(SamplingPlanTypeEnum? samplingPlanType)
        {
            if (samplingPlanType == null)
                return CSSPEnumsRes.Empty;

            switch (samplingPlanType)
            {
                case SamplingPlanTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case SamplingPlanTypeEnum.Subsector:
                    return CSSPEnumsRes.SamplingPlanTypeEnumSubsector;
                case SamplingPlanTypeEnum.Municipality:
                    return CSSPEnumsRes.SamplingPlanTypeEnumMunicipality;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_ScenarioStatusEnum(ScenarioStatusEnum? scenarioStatus)
        {
            if (scenarioStatus == null)
                return CSSPEnumsRes.Empty;

            switch (scenarioStatus)
            {
                case ScenarioStatusEnum.Error:
                    return CSSPEnumsRes.Empty;
                case ScenarioStatusEnum.Normal:
                    return CSSPEnumsRes.ScenarioStatusEnumNormal;
                case ScenarioStatusEnum.Copying:
                    return CSSPEnumsRes.ScenarioStatusEnumCopying;
                case ScenarioStatusEnum.Copied:
                    return CSSPEnumsRes.ScenarioStatusEnumCopied;
                case ScenarioStatusEnum.Changing:
                    return CSSPEnumsRes.ScenarioStatusEnumChanging;
                case ScenarioStatusEnum.Changed:
                    return CSSPEnumsRes.ScenarioStatusEnumChanged;
                case ScenarioStatusEnum.AskToRun:
                    return CSSPEnumsRes.ScenarioStatusEnumAskToRun;
                case ScenarioStatusEnum.Running:
                    return CSSPEnumsRes.ScenarioStatusEnumRunning;
                case ScenarioStatusEnum.Completed:
                    return CSSPEnumsRes.ScenarioStatusEnumCompleted;
                case ScenarioStatusEnum.Cancelled:
                    return CSSPEnumsRes.ScenarioStatusEnumCancelled;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_SearchTagEnum(SearchTagEnum? searchTag)
        {
            if (searchTag == null)
                return CSSPEnumsRes.Empty;

            switch (searchTag)
            {
                case SearchTagEnum.Error:
                    return CSSPEnumsRes.Empty;
                case SearchTagEnum.c:
                    return CSSPEnumsRes.SearchTagEnumc;
                case SearchTagEnum.e:
                    return CSSPEnumsRes.SearchTagEnume;
                case SearchTagEnum.t:
                    return CSSPEnumsRes.SearchTagEnumt;
                case SearchTagEnum.fi:
                    return CSSPEnumsRes.SearchTagEnumfi;
                case SearchTagEnum.fp:
                    return CSSPEnumsRes.SearchTagEnumfp;
                case SearchTagEnum.fr:
                    return CSSPEnumsRes.SearchTagEnumfr;
                case SearchTagEnum.fg:
                    return CSSPEnumsRes.SearchTagEnumfg;
                case SearchTagEnum.fpdf:
                    return CSSPEnumsRes.SearchTagEnumfpdf;
                case SearchTagEnum.fdocx:
                    return CSSPEnumsRes.SearchTagEnumfdocx;
                case SearchTagEnum.fxlsx:
                    return CSSPEnumsRes.SearchTagEnumfxlsx;
                case SearchTagEnum.fkmz:
                    return CSSPEnumsRes.SearchTagEnumfkmz;
                case SearchTagEnum.fxyz:
                    return CSSPEnumsRes.SearchTagEnumfxyz;
                case SearchTagEnum.fdfs:
                    return CSSPEnumsRes.SearchTagEnumfdfs;
                case SearchTagEnum.fmike:
                    return CSSPEnumsRes.SearchTagEnumfmike;
                case SearchTagEnum.fmdf:
                    return CSSPEnumsRes.SearchTagEnumfmdf;
                case SearchTagEnum.fm21fm:
                    return CSSPEnumsRes.SearchTagEnumfm21fm;
                case SearchTagEnum.fm3fm:
                    return CSSPEnumsRes.SearchTagEnumfm3fm;
                case SearchTagEnum.fmesh:
                    return CSSPEnumsRes.SearchTagEnumfmesh;
                case SearchTagEnum.flog:
                    return CSSPEnumsRes.SearchTagEnumflog;
                case SearchTagEnum.ftxt:
                    return CSSPEnumsRes.SearchTagEnumftxt;
                case SearchTagEnum.m:
                    return CSSPEnumsRes.SearchTagEnumm;
                case SearchTagEnum.p:
                    return CSSPEnumsRes.SearchTagEnump;
                case SearchTagEnum.ms:
                    return CSSPEnumsRes.SearchTagEnumms;
                case SearchTagEnum.cs:
                    return CSSPEnumsRes.SearchTagEnumcs;
                case SearchTagEnum.hs:
                    return CSSPEnumsRes.SearchTagEnumhs;
                case SearchTagEnum.ts:
                    return CSSPEnumsRes.SearchTagEnumts;
                case SearchTagEnum.ww:
                    return CSSPEnumsRes.SearchTagEnumww;
                case SearchTagEnum.ls:
                    return CSSPEnumsRes.SearchTagEnumls;
                case SearchTagEnum.st:
                    return CSSPEnumsRes.SearchTagEnumst;
                case SearchTagEnum.ps:
                    return CSSPEnumsRes.SearchTagEnumps;
                case SearchTagEnum.a:
                    return CSSPEnumsRes.SearchTagEnuma;
                case SearchTagEnum.s:
                    return CSSPEnumsRes.SearchTagEnums;
                case SearchTagEnum.ss:
                    return CSSPEnumsRes.SearchTagEnumss;
                case SearchTagEnum.u:
                    return CSSPEnumsRes.SearchTagEnumu;
                case SearchTagEnum.notag:
                    return CSSPEnumsRes.SearchTagEnumnotag;
                case SearchTagEnum.fcsv:
                    return CSSPEnumsRes.SearchTagEnumfcsv;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_SecondaryTreatmentTypeEnum(SecondaryTreatmentTypeEnum? secondaryTreatmentType)
        {
            if (secondaryTreatmentType == null)
                return CSSPEnumsRes.Empty;

            switch (secondaryTreatmentType)
            {
                case SecondaryTreatmentTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case SecondaryTreatmentTypeEnum.NotApplicable:
                    return CSSPEnumsRes.SecondaryTreatmentTypeEnumNotApplicable;
                case SecondaryTreatmentTypeEnum.RotatingBiologicalContactor:
                    return CSSPEnumsRes.SecondaryTreatmentTypeEnumRotatingBiologicalContactor;
                case SecondaryTreatmentTypeEnum.TricklingFilters:
                    return CSSPEnumsRes.SecondaryTreatmentTypeEnumTricklingFilters;
                case SecondaryTreatmentTypeEnum.SequencingBatchReator:
                    return CSSPEnumsRes.SecondaryTreatmentTypeEnumSequencingBatchReator;
                case SecondaryTreatmentTypeEnum.OxidationDitch:
                    return CSSPEnumsRes.SecondaryTreatmentTypeEnumOxidationDitch;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_SiteTypeEnum(SiteTypeEnum? siteType)
        {
            if (siteType == null)
                return CSSPEnumsRes.Empty;

            switch (siteType)
            {
                case SiteTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case SiteTypeEnum.Climate:
                    return CSSPEnumsRes.SiteTypeEnumClimate;
                case SiteTypeEnum.Hydrometric:
                    return CSSPEnumsRes.SiteTypeEnumHydrometric;
                case SiteTypeEnum.Tide:
                    return CSSPEnumsRes.SiteTypeEnumTide;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_SpecialTableTypeEnum(SpecialTableTypeEnum? specialTableType)
        {
            if (specialTableType == null)
                return CSSPEnumsRes.Empty;

            switch (specialTableType)
            {
                case SpecialTableTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case SpecialTableTypeEnum.FCDensitiesTable:
                    return CSSPEnumsRes.SpecialTableTypeEnumFCDensitiesTable;
                case SpecialTableTypeEnum.SalinityTable:
                    return CSSPEnumsRes.SpecialTableTypeEnumSalinityTable;
                case SpecialTableTypeEnum.TemperatureTable:
                    return CSSPEnumsRes.SpecialTableTypeEnumTemperatureTable;
                case SpecialTableTypeEnum.GeometricMeanTable:
                    return CSSPEnumsRes.SpecialTableTypeEnumGeometricMeanTable;
                case SpecialTableTypeEnum.MedianTable:
                    return CSSPEnumsRes.SpecialTableTypeEnumMedianTable;
                case SpecialTableTypeEnum.P90Table:
                    return CSSPEnumsRes.SpecialTableTypeEnumP90Table;
                case SpecialTableTypeEnum.PercentOver43Table:
                    return CSSPEnumsRes.SpecialTableTypeEnumPercentOver43Table;
                case SpecialTableTypeEnum.PercentOver260Table:
                    return CSSPEnumsRes.SpecialTableTypeEnumPercentOver260Table;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_StorageDataTypeEnum(StorageDataTypeEnum? storageDataType)
        {
            if (storageDataType == null)
                return CSSPEnumsRes.Empty;

            switch (storageDataType)
            {
                case StorageDataTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case StorageDataTypeEnum.Archived:
                    return CSSPEnumsRes.StorageDataTypeEnumArchived;
                case StorageDataTypeEnum.Forcasted:
                    return CSSPEnumsRes.StorageDataTypeEnumForcasted;
                case StorageDataTypeEnum.Observed:
                    return CSSPEnumsRes.StorageDataTypeEnumObserved;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_StreetTypeEnum(StreetTypeEnum? streetType)
        {
            if (streetType == null)
                return CSSPEnumsRes.Empty;

            switch (streetType)
            {
                case StreetTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case StreetTypeEnum.Street:
                    return CSSPEnumsRes.StreetTypeEnumStreet;
                case StreetTypeEnum.Road:
                    return CSSPEnumsRes.StreetTypeEnumRoad;
                case StreetTypeEnum.Avenue:
                    return CSSPEnumsRes.StreetTypeEnumAvenue;
                case StreetTypeEnum.Crescent:
                    return CSSPEnumsRes.StreetTypeEnumCrescent;
                case StreetTypeEnum.Court:
                    return CSSPEnumsRes.StreetTypeEnumCourt;
                case StreetTypeEnum.Alley:
                    return CSSPEnumsRes.StreetTypeEnumAlley;
                case StreetTypeEnum.Drive:
                    return CSSPEnumsRes.StreetTypeEnumDrive;
                case StreetTypeEnum.Blvd:
                    return CSSPEnumsRes.StreetTypeEnumBlvd;
                case StreetTypeEnum.Route:
                    return CSSPEnumsRes.StreetTypeEnumRoute;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_TelTypeEnum(TelTypeEnum? telType)
        {
            if (telType == null)
                return CSSPEnumsRes.Empty;

            switch (telType)
            {
                case TelTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case TelTypeEnum.Personal:
                    return CSSPEnumsRes.TelTypeEnumPersonal;
                case TelTypeEnum.Work:
                    return CSSPEnumsRes.TelTypeEnumWork;
                case TelTypeEnum.Mobile:
                    return CSSPEnumsRes.TelTypeEnumMobile;
                case TelTypeEnum.Personal2:
                    return CSSPEnumsRes.TelTypeEnumPersonal2;
                case TelTypeEnum.Work2:
                    return CSSPEnumsRes.TelTypeEnumWork2;
                case TelTypeEnum.Mobile2:
                    return CSSPEnumsRes.TelTypeEnumMobile2;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_TertiaryTreatmentTypeEnum(TertiaryTreatmentTypeEnum? tertiaryTreatmentType)
        {
            if (tertiaryTreatmentType == null)
                return CSSPEnumsRes.Empty;

            switch (tertiaryTreatmentType)
            {
                case TertiaryTreatmentTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case TertiaryTreatmentTypeEnum.NotApplicable:
                    return CSSPEnumsRes.TertiaryTreatmentTypeEnumNotApplicable;
                case TertiaryTreatmentTypeEnum.Adsorption:
                    return CSSPEnumsRes.TertiaryTreatmentTypeEnumAdsorption;
                case TertiaryTreatmentTypeEnum.Flocculation:
                    return CSSPEnumsRes.TertiaryTreatmentTypeEnumFlocculation;
                case TertiaryTreatmentTypeEnum.MembraneFiltration:
                    return CSSPEnumsRes.TertiaryTreatmentTypeEnumMembraneFiltration;
                case TertiaryTreatmentTypeEnum.IonExchange:
                    return CSSPEnumsRes.TertiaryTreatmentTypeEnumIonExchange;
                case TertiaryTreatmentTypeEnum.ReverseOsmosis:
                    return CSSPEnumsRes.TertiaryTreatmentTypeEnumReverseOsmosis;
                case TertiaryTreatmentTypeEnum.BiologicalNutrientRemoval:
                    return CSSPEnumsRes.TertiaryTreatmentTypeEnumBiologicalNutrientRemoval;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_TideDataTypeEnum(TideDataTypeEnum? tideDataType)
        {
            if (tideDataType == null)
                return CSSPEnumsRes.Empty;

            switch (tideDataType)
            {
                case TideDataTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case TideDataTypeEnum.Min15:
                    return CSSPEnumsRes.TideDataTypeEnumMin15;
                case TideDataTypeEnum.Min60:
                    return CSSPEnumsRes.TideDataTypeEnumMin60;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_TideTextEnum(TideTextEnum? tideText)
        {
            if (tideText == null)
                return CSSPEnumsRes.Empty;

            switch (tideText)
            {
                case TideTextEnum.Error:
                    return CSSPEnumsRes.Empty;
                case TideTextEnum.LowTide:
                    return CSSPEnumsRes.TideTextEnumLowTide;
                case TideTextEnum.LowTideFalling:
                    return CSSPEnumsRes.TideTextEnumLowTideFalling;
                case TideTextEnum.LowTideRising:
                    return CSSPEnumsRes.TideTextEnumLowTideRising;
                case TideTextEnum.MidTide:
                    return CSSPEnumsRes.TideTextEnumMidTide;
                case TideTextEnum.MidTideFalling:
                    return CSSPEnumsRes.TideTextEnumMidTideFalling;
                case TideTextEnum.MidTideRising:
                    return CSSPEnumsRes.TideTextEnumMidTideRising;
                case TideTextEnum.HighTide:
                    return CSSPEnumsRes.TideTextEnumHighTide;
                case TideTextEnum.HighTideFalling:
                    return CSSPEnumsRes.TideTextEnumHighTideFalling;
                case TideTextEnum.HighTideRising:
                    return CSSPEnumsRes.TideTextEnumHighTideRising;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_TranslationStatusEnum(TranslationStatusEnum? translationStatus)
        {
            if (translationStatus == null)
                return CSSPEnumsRes.Empty;

            switch (translationStatus)
            {
                case TranslationStatusEnum.Error:
                    return CSSPEnumsRes.Empty;
                case TranslationStatusEnum.NotTranslated:
                    return CSSPEnumsRes.TranslationStatusEnumNotTranslated;
                case TranslationStatusEnum.ElectronicallyTranslated:
                    return CSSPEnumsRes.TranslationStatusEnumElectronicallyTranslated;
                case TranslationStatusEnum.Translated:
                    return CSSPEnumsRes.TranslationStatusEnumTranslated;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_TreatmentTypeEnum(TreatmentTypeEnum? treatmentType)
        {
            if (treatmentType == null)
                return CSSPEnumsRes.Empty;

            switch (treatmentType)
            {
                case TreatmentTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case TreatmentTypeEnum.ActivatedSludge:
                    return CSSPEnumsRes.TreatmentTypeEnumActivatedSludge;
                case TreatmentTypeEnum.ActivatedSludgeWithBiofilter:
                    return CSSPEnumsRes.TreatmentTypeEnumActivatedSludgeWithBiofilter;
                case TreatmentTypeEnum.LagoonNoAeration1Cell:
                    return CSSPEnumsRes.TreatmentTypeEnumLagoonNoAeration1Cell;
                case TreatmentTypeEnum.LagoonNoAeration2Cell:
                    return CSSPEnumsRes.TreatmentTypeEnumLagoonNoAeration2Cell;
                case TreatmentTypeEnum.LagoonNoAeration3Cell:
                    return CSSPEnumsRes.TreatmentTypeEnumLagoonNoAeration3Cell;
                case TreatmentTypeEnum.LagoonNoAeration4Cell:
                    return CSSPEnumsRes.TreatmentTypeEnumLagoonNoAeration4Cell;
                case TreatmentTypeEnum.LagoonNoAeration5Cell:
                    return CSSPEnumsRes.TreatmentTypeEnumLagoonNoAeration5Cell;
                case TreatmentTypeEnum.LagoonWithAeration1Cell:
                    return CSSPEnumsRes.TreatmentTypeEnumLagoonWithAeration1Cell;
                case TreatmentTypeEnum.LagoonWithAeration2Cell:
                    return CSSPEnumsRes.TreatmentTypeEnumLagoonWithAeration2Cell;
                case TreatmentTypeEnum.LagoonWithAeration3Cell:
                    return CSSPEnumsRes.TreatmentTypeEnumLagoonWithAeration3Cell;
                case TreatmentTypeEnum.LagoonWithAeration4Cell:
                    return CSSPEnumsRes.TreatmentTypeEnumLagoonWithAeration4Cell;
                case TreatmentTypeEnum.LagoonWithAeration5Cell:
                    return CSSPEnumsRes.TreatmentTypeEnumLagoonWithAeration5Cell;
                case TreatmentTypeEnum.LagoonWithAeration6Cell:
                    return CSSPEnumsRes.TreatmentTypeEnumLagoonWithAeration6Cell;
                case TreatmentTypeEnum.StabalizingPondOnly:
                    return CSSPEnumsRes.TreatmentTypeEnumStabalizingPondOnly;
                case TreatmentTypeEnum.OxidationDitchOnly:
                    return CSSPEnumsRes.TreatmentTypeEnumOxidationDitchOnly;
                case TreatmentTypeEnum.CirculatingFluidizedBed:
                    return CSSPEnumsRes.TreatmentTypeEnumCirculatingFluidizedBed;
                case TreatmentTypeEnum.TricklingFilter:
                    return CSSPEnumsRes.TreatmentTypeEnumTricklingFilter;
                case TreatmentTypeEnum.RecirculatingSandFilter:
                    return CSSPEnumsRes.TreatmentTypeEnumRecirculatingSandFilter;
                case TreatmentTypeEnum.TrashRackRakeOnly:
                    return CSSPEnumsRes.TreatmentTypeEnumTrashRackRakeOnly;
                case TreatmentTypeEnum.SepticTank:
                    return CSSPEnumsRes.TreatmentTypeEnumSepticTank;
                case TreatmentTypeEnum.Secondary:
                    return CSSPEnumsRes.TreatmentTypeEnumSecondary;
                case TreatmentTypeEnum.Tertiary:
                    return CSSPEnumsRes.TreatmentTypeEnumTertiary;
                case TreatmentTypeEnum.VolumeFermenter:
                    return CSSPEnumsRes.TreatmentTypeEnumVolumeFermenter;
                case TreatmentTypeEnum.BioFilmReactor:
                    return CSSPEnumsRes.TreatmentTypeEnumBioFilmReactor;
                case TreatmentTypeEnum.BioGreen:
                    return CSSPEnumsRes.TreatmentTypeEnumBioGreen;
                case TreatmentTypeEnum.BioDisks:
                    return CSSPEnumsRes.TreatmentTypeEnumBioDisks;
                case TreatmentTypeEnum.ChemicalPrimary:
                    return CSSPEnumsRes.TreatmentTypeEnumChemicalPrimary;
                case TreatmentTypeEnum.Chromoglass:
                    return CSSPEnumsRes.TreatmentTypeEnumChromoglass;
                case TreatmentTypeEnum.Primary:
                    return CSSPEnumsRes.TreatmentTypeEnumPrimary;
                case TreatmentTypeEnum.SequencingBatchReactor:
                    return CSSPEnumsRes.TreatmentTypeEnumSequencingBatchReactor;
                case TreatmentTypeEnum.PeatSystem:
                    return CSSPEnumsRes.TreatmentTypeEnumPeatSystem;
                case TreatmentTypeEnum.Physicochimique:
                    return CSSPEnumsRes.TreatmentTypeEnumPhysicochimique;
                case TreatmentTypeEnum.RotatingBiologicalContactor:
                    return CSSPEnumsRes.TreatmentTypeEnumRotatingBiologicalContactor;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_TVAuthEnum(TVAuthEnum? tVAuth)
        {
            if (tVAuth == null)
                return CSSPEnumsRes.Empty;

            switch (tVAuth)
            {
                case TVAuthEnum.Error:
                    return CSSPEnumsRes.Empty;
                case TVAuthEnum.NoAccess:
                    return CSSPEnumsRes.TVAuthEnumNoAccess;
                case TVAuthEnum.Read:
                    return CSSPEnumsRes.TVAuthEnumRead;
                case TVAuthEnum.Write:
                    return CSSPEnumsRes.TVAuthEnumWrite;
                case TVAuthEnum.Create:
                    return CSSPEnumsRes.TVAuthEnumCreate;
                case TVAuthEnum.Delete:
                    return CSSPEnumsRes.TVAuthEnumDelete;
                case TVAuthEnum.Admin:
                    return CSSPEnumsRes.TVAuthEnumAdmin;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_TVTypeEnum(TVTypeEnum? tVType)
        {
            if (tVType == null)
                return CSSPEnumsRes.Empty;

            switch (tVType)
            {
                case TVTypeEnum.Error:
                    return CSSPEnumsRes.Empty;
                case TVTypeEnum.Root:
                    return CSSPEnumsRes.TVTypeEnumRoot;
                case TVTypeEnum.Address:
                    return CSSPEnumsRes.TVTypeEnumAddress;
                case TVTypeEnum.Area:
                    return CSSPEnumsRes.TVTypeEnumArea;
                case TVTypeEnum.ClimateSite:
                    return CSSPEnumsRes.TVTypeEnumClimateSite;
                case TVTypeEnum.Contact:
                    return CSSPEnumsRes.TVTypeEnumContact;
                case TVTypeEnum.Country:
                    return CSSPEnumsRes.TVTypeEnumCountry;
                case TVTypeEnum.Email:
                    return CSSPEnumsRes.TVTypeEnumEmail;
                case TVTypeEnum.File:
                    return CSSPEnumsRes.TVTypeEnumFile;
                case TVTypeEnum.HydrometricSite:
                    return CSSPEnumsRes.TVTypeEnumHydrometricSite;
                case TVTypeEnum.Infrastructure:
                    return CSSPEnumsRes.TVTypeEnumInfrastructure;
                case TVTypeEnum.MikeBoundaryConditionWebTide:
                    return CSSPEnumsRes.TVTypeEnumMikeBoundaryConditionWebTide;
                case TVTypeEnum.MikeBoundaryConditionMesh:
                    return CSSPEnumsRes.TVTypeEnumMikeBoundaryConditionMesh;
                case TVTypeEnum.MikeScenario:
                    return CSSPEnumsRes.TVTypeEnumMikeScenario;
                case TVTypeEnum.MikeSource:
                    return CSSPEnumsRes.TVTypeEnumMikeSource;
                case TVTypeEnum.Municipality:
                    return CSSPEnumsRes.TVTypeEnumMunicipality;
                case TVTypeEnum.MWQMSite:
                    return CSSPEnumsRes.TVTypeEnumMWQMSite;
                case TVTypeEnum.PolSourceSite:
                    return CSSPEnumsRes.TVTypeEnumPolSourceSite;
                case TVTypeEnum.Province:
                    return CSSPEnumsRes.TVTypeEnumProvince;
                case TVTypeEnum.Sector:
                    return CSSPEnumsRes.TVTypeEnumSector;
                case TVTypeEnum.Subsector:
                    return CSSPEnumsRes.TVTypeEnumSubsector;
                case TVTypeEnum.Tel:
                    return CSSPEnumsRes.TVTypeEnumTel;
                case TVTypeEnum.TideSite:
                    return CSSPEnumsRes.TVTypeEnumTideSite;
                case TVTypeEnum.MWQMSiteSample:
                    return CSSPEnumsRes.TVTypeEnumMWQMSiteSample;
                case TVTypeEnum.WasteWaterTreatmentPlant:
                    return CSSPEnumsRes.TVTypeEnumWasteWaterTreatmentPlant;
                case TVTypeEnum.LiftStation:
                    return CSSPEnumsRes.TVTypeEnumLiftStation;
                case TVTypeEnum.Spill:
                    return CSSPEnumsRes.TVTypeEnumSpill;
                case TVTypeEnum.BoxModel:
                    return CSSPEnumsRes.TVTypeEnumBoxModel;
                case TVTypeEnum.VisualPlumesScenario:
                    return CSSPEnumsRes.TVTypeEnumVisualPlumesScenario;
                case TVTypeEnum.Outfall:
                    return CSSPEnumsRes.TVTypeEnumOutfall;
                case TVTypeEnum.OtherInfrastructure:
                    return CSSPEnumsRes.TVTypeEnumOtherInfrastructure;
                case TVTypeEnum.MWQMRun:
                    return CSSPEnumsRes.TVTypeEnumMWQMRun;
                case TVTypeEnum.NoDepuration:
                    return CSSPEnumsRes.TVTypeEnumNoDepuration;
                case TVTypeEnum.Failed:
                    return CSSPEnumsRes.TVTypeEnumFailed;
                case TVTypeEnum.Passed:
                    return CSSPEnumsRes.TVTypeEnumPassed;
                case TVTypeEnum.NoData:
                    return CSSPEnumsRes.TVTypeEnumNoData;
                case TVTypeEnum.LessThan10:
                    return CSSPEnumsRes.TVTypeEnumLessThan10;
                case TVTypeEnum.MeshNode:
                    return CSSPEnumsRes.TVTypeEnumMeshNode;
                case TVTypeEnum.WebTideNode:
                    return CSSPEnumsRes.TVTypeEnumWebTideNode;
                case TVTypeEnum.SamplingPlan:
                    return CSSPEnumsRes.TVTypeEnumSamplingPlan;
                case TVTypeEnum.SeeOther:
                    return CSSPEnumsRes.TVTypeEnumSeeOther;
                case TVTypeEnum.LineOverflow:
                    return CSSPEnumsRes.TVTypeEnumLineOverflow;
                case TVTypeEnum.BoxModelInputs:
                    return CSSPEnumsRes.TVTypeEnumBoxModelInputs;
                case TVTypeEnum.BoxModelResults:
                    return CSSPEnumsRes.TVTypeEnumBoxModelResults;
                case TVTypeEnum.ClimateSiteInfo:
                    return CSSPEnumsRes.TVTypeEnumClimateSiteInfo;
                case TVTypeEnum.ClimateSiteData:
                    return CSSPEnumsRes.TVTypeEnumClimateSiteData;
                case TVTypeEnum.HydrometricSiteInfo:
                    return CSSPEnumsRes.TVTypeEnumHydrometricSiteInfo;
                case TVTypeEnum.HydrometricSiteData:
                    return CSSPEnumsRes.TVTypeEnumHydrometricSiteData;
                case TVTypeEnum.InfrastructureInfo:
                    return CSSPEnumsRes.TVTypeEnumInfrastructureInfo;
                case TVTypeEnum.LabSheetInfo:
                    return CSSPEnumsRes.TVTypeEnumLabSheetInfo;
                case TVTypeEnum.LabSheetDetailInfo:
                    return CSSPEnumsRes.TVTypeEnumLabSheetDetailInfo;
                case TVTypeEnum.MapInfo:
                    return CSSPEnumsRes.TVTypeEnumMapInfo;
                case TVTypeEnum.MapInfoPoint:
                    return CSSPEnumsRes.TVTypeEnumMapInfoPoint;
                case TVTypeEnum.MikeSourceStartEndInfo:
                    return CSSPEnumsRes.TVTypeEnumMikeSourceStartEndInfo;
                case TVTypeEnum.MWQMLookupMPNInfo:
                    return CSSPEnumsRes.TVTypeEnumMWQMLookupMPNInfo;
                case TVTypeEnum.SamplingPlanInfo:
                    return CSSPEnumsRes.TVTypeEnumSamplingPlanInfo;
                case TVTypeEnum.SamplingPlanSubsectorInfo:
                    return CSSPEnumsRes.TVTypeEnumSamplingPlanSubsectorInfo;
                case TVTypeEnum.SamplingPlanSubsectorSiteInfo:
                    return CSSPEnumsRes.TVTypeEnumSamplingPlanSubsectorSiteInfo;
                case TVTypeEnum.MWQMSiteStartEndInfo:
                    return CSSPEnumsRes.TVTypeEnumMWQMSiteStartEndInfo;
                case TVTypeEnum.MWQMSubsectorInfo:
                    return CSSPEnumsRes.TVTypeEnumMWQMSubsectorInfo;
                case TVTypeEnum.PolSourceSiteInfo:
                    return CSSPEnumsRes.TVTypeEnumPolSourceSiteInfo;
                case TVTypeEnum.PolSourceSiteObsInfo:
                    return CSSPEnumsRes.TVTypeEnumPolSourceSiteObsInfo;
                case TVTypeEnum.HydrometricRatingCurveInfo:
                    return CSSPEnumsRes.TVTypeEnumHydrometricRatingCurveInfo;
                case TVTypeEnum.HydrometricRatingCurveDataInfo:
                    return CSSPEnumsRes.TVTypeEnumHydrometricRatingCurveDataInfo;
                case TVTypeEnum.TideLocationInfo:
                    return CSSPEnumsRes.TVTypeEnumTideLocationInfo;
                case TVTypeEnum.TideSiteDataInfo:
                    return CSSPEnumsRes.TVTypeEnumTideSiteDataInfo;
                case TVTypeEnum.UseOfSite:
                    return CSSPEnumsRes.TVTypeEnumUseOfSite;
                case TVTypeEnum.VisualPlumesScenarioInfo:
                    return CSSPEnumsRes.TVTypeEnumVisualPlumesScenarioInfo;
                case TVTypeEnum.VisualPlumesScenarioAmbient:
                    return CSSPEnumsRes.TVTypeEnumVisualPlumesScenarioAmbient;
                case TVTypeEnum.VisualPlumesScenarioResults:
                    return CSSPEnumsRes.TVTypeEnumVisualPlumesScenarioResults;
                case TVTypeEnum.TotalFile:
                    return CSSPEnumsRes.TVTypeEnumTotalFile;
                case TVTypeEnum.MikeSourceIsRiver:
                    return CSSPEnumsRes.TVTypeEnumMikeSourceIsRiver;
                case TVTypeEnum.MikeSourceIncluded:
                    return CSSPEnumsRes.TVTypeEnumMikeSourceIncluded;
                case TVTypeEnum.MikeSourceNotIncluded:
                    return CSSPEnumsRes.TVTypeEnumMikeSourceNotIncluded;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }
        private string GetEnumText_WebTideDataSetEnum(WebTideDataSetEnum? webTideDataSet)
        {
            if (webTideDataSet == null)
                return CSSPEnumsRes.Empty;

            switch (webTideDataSet)
            {
                case WebTideDataSetEnum.Error:
                    return CSSPEnumsRes.Empty;
                case WebTideDataSetEnum.arctic9:
                    return CSSPEnumsRes.WebTideDataSetEnumarctic9;
                case WebTideDataSetEnum.brador:
                    return CSSPEnumsRes.WebTideDataSetEnumbrador;
                case WebTideDataSetEnum.HRglobal:
                    return CSSPEnumsRes.WebTideDataSetEnumHRglobal;
                case WebTideDataSetEnum.h3o:
                    return CSSPEnumsRes.WebTideDataSetEnumh3o;
                case WebTideDataSetEnum.hudson:
                    return CSSPEnumsRes.WebTideDataSetEnumhudson;
                case WebTideDataSetEnum.ne_pac4:
                    return CSSPEnumsRes.WebTideDataSetEnumne_pac4;
                case WebTideDataSetEnum.nwatl:
                    return CSSPEnumsRes.WebTideDataSetEnumnwatl;
                case WebTideDataSetEnum.QuatsinoModel14:
                    return CSSPEnumsRes.WebTideDataSetEnumQuatsinoModel14;
                case WebTideDataSetEnum.sshelf:
                    return CSSPEnumsRes.WebTideDataSetEnumsshelf;
                case WebTideDataSetEnum.flood:
                    return CSSPEnumsRes.WebTideDataSetEnumflood;
                case WebTideDataSetEnum.vigf8:
                    return CSSPEnumsRes.WebTideDataSetEnumvigf8;
                default:
                    return CSSPEnumsRes.Empty;
            }
        }

        #endregion Functions private
    }
}
