using CSSPEnums;
using CSSPEnums.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSSPEnums
{
    public partial class Enums
    {

        #region Functions Get Enum Text
        public string GetEnumText_AddressTypeEnum(AddressTypeEnum? addressType)
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
        public string GetEnumText_ActionDBTypeEnum(ActionDBTypeEnum? actionDBType)
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
        public string GetEnumText_AerationTypeEnum(AerationTypeEnum? aerationType)
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
        public string GetEnumText_AlarmSystemTypeEnum(AlarmSystemTypeEnum? alarmSystemType)
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
        public string GetEnumText_AnalyzeMethodEnum(AnalyzeMethodEnum? analyzeMethod)
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
        public string GetEnumText_AppTaskCommandEnum(AppTaskCommandEnum? appTaskCommand)
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
        public string GetEnumText_AppTaskStatusEnum(AppTaskStatusEnum? appTaskStatus)
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
        public string GetEnumText_BeaufortScaleEnum(BeaufortScaleEnum? beaufortScale)
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
        public string GetEnumText_BoxModelResultTypeEnum(BoxModelResultTypeEnum? boxModelResultType)
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
        public string GetEnumText_CollectionSystemTypeEnum(CollectionSystemTypeEnum? collectionSystemType)
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
        public string GetEnumText_ContactTitleEnum(ContactTitleEnum? contactTitle)
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
        public string GetEnumText_CSSPWQInputSheetTypeEnum(CSSPWQInputSheetTypeEnum? cSSPWQInputSheetType)
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
        public string GetEnumText_CSSPWQInputTypeEnum(CSSPWQInputTypeEnum? cSSPWQInputType)
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
        public string GetEnumText_DailyOrHourlyDataEnum(DailyOrHourlyDataEnum? dailyOrHourlyData)
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
        public string GetEnumText_DatabaseTypeEnum(DatabaseTypeEnum? databaseType)
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
        public string GetEnumText_DisinfectionTypeEnum(DisinfectionTypeEnum? disinfectionType)
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
        public string GetEnumText_EmailTypeEnum(EmailTypeEnum? emailType)
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
        public string GetEnumText_FacilityTypeEnum(FacilityTypeEnum? facilityType)
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
        public string GetEnumText_FilePurposeEnum(FilePurposeEnum? filePurpose)
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
        public string GetEnumText_FileStatusEnum(FileStatusEnum? fileStatus)
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
        public string GetEnumText_FileTypeEnum(FileTypeEnum? fileType)
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
        public string GetEnumText_InfrastructureTypeEnum(InfrastructureTypeEnum? infrastructureType)
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
        public string GetEnumText_KMZActionEnum(KMZActionEnum? kMZAction)
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
        public string GetEnumText_LaboratoryEnum(LaboratoryEnum? laboratory)
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
        public string GetEnumText_LabSheetStatusEnum(LabSheetStatusEnum? labSheetStatus)
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
        public string GetEnumText_LabSheetTypeEnum(LabSheetTypeEnum? labSheetType)
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
        public string GetEnumText_LanguageEnum(LanguageEnum? language)
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
        public string GetEnumText_LogCommandEnum(LogCommandEnum? logCommand)
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
        public string GetEnumText_MapInfoDrawTypeEnum(MapInfoDrawTypeEnum? mapInfoDrawType)
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
        public string GetEnumText_MikeBoundaryConditionLevelOrVelocityEnum(MikeBoundaryConditionLevelOrVelocityEnum? mikeBoundaryConditionLevelOrVelocity)
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
        public string GetEnumText_MikeScenarioSpecialResultKMLTypeEnum(MikeScenarioSpecialResultKMLTypeEnum? mikeScenarioSpecialResultKMLType)
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
        public string GetEnumText_MWQMSiteLatestClassificationEnum(MWQMSiteLatestClassificationEnum? mWQMSiteLatestClassification)
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
        public string GetEnumText_PolSourceInactiveReasonEnum(PolSourceInactiveReasonEnum? polSourceInactiveReason)
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
        public string GetEnumText_PolSourceIssueRiskEnum(PolSourceIssueRiskEnum? polSourceIssueRisk)
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
        public string GetEnumText_PreliminaryTreatmentTypeEnum(PreliminaryTreatmentTypeEnum? preliminaryTreatmentType)
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
        public string GetEnumText_PrimaryTreatmentTypeEnum(PrimaryTreatmentTypeEnum? primaryTreatmentType)
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
        public string GetEnumText_ReportConditionEnum(ReportConditionEnum? reportCondition)
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
        public string GetEnumText_ReportFieldTypeEnum(ReportFieldTypeEnum? reportFieldType)
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
        public string GetEnumText_ReportFileTypeEnum(ReportFileTypeEnum? reportFileType)
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
        public string GetEnumText_ReportFormatingDateEnum(ReportFormatingDateEnum? reportFormatingDate)
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
        public string GetEnumText_ReportFormatingNumberEnum(ReportFormatingNumberEnum? reportFormatingNumber)
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
        public string GetEnumText_ReportSortingEnum(ReportSortingEnum? reportSorting)
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
        public string GetEnumText_ReportTreeNodeSubTypeEnum(ReportTreeNodeSubTypeEnum? reportTreeNodeSubType)
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
        public string GetEnumText_ReportTreeNodeTypeEnum(ReportTreeNodeTypeEnum? reportTreeNodeType)
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
        public string GetEnumText_SameDayNextDayEnum(SameDayNextDayEnum? sameDayNextDay)
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
        public string GetEnumText_SampleMatrixEnum(SampleMatrixEnum? sampleMatrix)
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
        public string GetEnumText_SampleStatusEnum(SampleStatusEnum? sampleStatus)
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
        public string GetEnumText_SampleTypeEnum(SampleTypeEnum? sampleType)
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
        public string GetEnumText_SamplingPlanTypeEnum(SamplingPlanTypeEnum? samplingPlanType)
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
        public string GetEnumText_ScenarioStatusEnum(ScenarioStatusEnum? scenarioStatus)
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
        public string GetEnumText_SearchTagEnum(SearchTagEnum? searchTag)
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
        public string GetEnumText_SecondaryTreatmentTypeEnum(SecondaryTreatmentTypeEnum? secondaryTreatmentType)
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
        public string GetEnumText_SiteTypeEnum(SiteTypeEnum? siteType)
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
        public string GetEnumText_SpecialTableTypeEnum(SpecialTableTypeEnum? specialTableType)
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
        public string GetEnumText_StorageDataTypeEnum(StorageDataTypeEnum? storageDataType)
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
        public string GetEnumText_StreetTypeEnum(StreetTypeEnum? streetType)
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
        public string GetEnumText_TelTypeEnum(TelTypeEnum? telType)
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
        public string GetEnumText_TertiaryTreatmentTypeEnum(TertiaryTreatmentTypeEnum? tertiaryTreatmentType)
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
        public string GetEnumText_TideDataTypeEnum(TideDataTypeEnum? tideDataType)
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
        public string GetEnumText_TideTextEnum(TideTextEnum? tideText)
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
        public string GetEnumText_TranslationStatusEnum(TranslationStatusEnum? translationStatus)
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
        public string GetEnumText_TreatmentTypeEnum(TreatmentTypeEnum? treatmentType)
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
        public string GetEnumText_TVAuthEnum(TVAuthEnum? tVAuth)
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
        public string GetEnumText_TVTypeEnum(TVTypeEnum? tVType)
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
        public string GetEnumText_WebTideDataSetEnum(WebTideDataSetEnum? webTideDataSet)
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

        #endregion Functions Get Enum Text

        #region Function Get Enum Text Ordered
        public List<AddressTypeEnumTextOrdered> GetAddressTypeEnumTextOrderedList()
        {
            List<AddressTypeEnumTextOrdered> AddressTypeEnumTextOrderedList = new List<AddressTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(AddressTypeEnum)).Count(); i < count; i++)
            {
                AddressTypeEnumTextOrderedList.Add(new AddressTypeEnumTextOrdered() { AddressType = (AddressTypeEnum)i, AddressTypeText = GetEnumText_AddressTypeEnum((AddressTypeEnum)i) });
            }

            AddressTypeEnumTextOrderedList = (from c in AddressTypeEnumTextOrderedList
                                              orderby c.AddressTypeText
                                              select c).ToList();

            return AddressTypeEnumTextOrderedList;
        }
        public List<ActionDBTypeEnumTextOrdered> GetActionDBTypeEnumTextOrderedList()
        {
            List<ActionDBTypeEnumTextOrdered> ActionDBTypeEnumTextOrderedList = new List<ActionDBTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(ActionDBTypeEnum)).Count(); i < count; i++)
            {
                ActionDBTypeEnumTextOrderedList.Add(new ActionDBTypeEnumTextOrdered() { ActionDBType = (ActionDBTypeEnum)i, ActionDBTypeText = GetEnumText_ActionDBTypeEnum((ActionDBTypeEnum)i) });
            }

            ActionDBTypeEnumTextOrderedList = (from c in ActionDBTypeEnumTextOrderedList
                                              orderby c.ActionDBTypeText
                                              select c).ToList();

            return ActionDBTypeEnumTextOrderedList;
        }
        public List<AerationTypeEnumTextOrdered> GetAerationTypeEnumTextOrderedList()
        {
            List<AerationTypeEnumTextOrdered> AerationTypeEnumTextOrderedList = new List<AerationTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(AerationTypeEnum)).Count(); i < count; i++)
            {
                AerationTypeEnumTextOrderedList.Add(new AerationTypeEnumTextOrdered() { AerationType = (AerationTypeEnum)i, AerationTypeText = GetEnumText_AerationTypeEnum((AerationTypeEnum)i) });
            }

            AerationTypeEnumTextOrderedList = (from c in AerationTypeEnumTextOrderedList
                                              orderby c.AerationTypeText
                                              select c).ToList();

            return AerationTypeEnumTextOrderedList;
        }
        public List<AlarmSystemTypeEnumTextOrdered> GetAlarmSystemTypeEnumTextOrderedList()
        {
            List<AlarmSystemTypeEnumTextOrdered> AlarmSystemTypeEnumTextOrderedList = new List<AlarmSystemTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(AlarmSystemTypeEnum)).Count(); i < count; i++)
            {
                AlarmSystemTypeEnumTextOrderedList.Add(new AlarmSystemTypeEnumTextOrdered() { AlarmSystemType = (AlarmSystemTypeEnum)i, AlarmSystemTypeText = GetEnumText_AlarmSystemTypeEnum((AlarmSystemTypeEnum)i) });
            }

            AlarmSystemTypeEnumTextOrderedList = (from c in AlarmSystemTypeEnumTextOrderedList
                                              orderby c.AlarmSystemTypeText
                                              select c).ToList();

            return AlarmSystemTypeEnumTextOrderedList;
        }
        public List<AnalyzeMethodEnumTextOrdered> GetAnalyzeMethodEnumTextOrderedList()
        {
            List<AnalyzeMethodEnumTextOrdered> AnalyzeMethodEnumTextOrderedList = new List<AnalyzeMethodEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(AnalyzeMethodEnum)).Count(); i < count; i++)
            {
                AnalyzeMethodEnumTextOrderedList.Add(new AnalyzeMethodEnumTextOrdered() { AnalyzeMethod = (AnalyzeMethodEnum)i, AnalyzeMethodText = GetEnumText_AnalyzeMethodEnum((AnalyzeMethodEnum)i) });
            }

            AnalyzeMethodEnumTextOrderedList = (from c in AnalyzeMethodEnumTextOrderedList
                                              orderby c.AnalyzeMethodText
                                              select c).ToList();

            return AnalyzeMethodEnumTextOrderedList;
        }
        public List<AppTaskCommandEnumTextOrdered> GetAppTaskCommandEnumTextOrderedList()
        {
            List<AppTaskCommandEnumTextOrdered> AppTaskCommandEnumTextOrderedList = new List<AppTaskCommandEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(AppTaskCommandEnum)).Count(); i < count; i++)
            {
                AppTaskCommandEnumTextOrderedList.Add(new AppTaskCommandEnumTextOrdered() { AppTaskCommand = (AppTaskCommandEnum)i, AppTaskCommandText = GetEnumText_AppTaskCommandEnum((AppTaskCommandEnum)i) });
            }

            AppTaskCommandEnumTextOrderedList = (from c in AppTaskCommandEnumTextOrderedList
                                              orderby c.AppTaskCommandText
                                              select c).ToList();

            return AppTaskCommandEnumTextOrderedList;
        }
        public List<AppTaskStatusEnumTextOrdered> GetAppTaskStatusEnumTextOrderedList()
        {
            List<AppTaskStatusEnumTextOrdered> AppTaskStatusEnumTextOrderedList = new List<AppTaskStatusEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(AppTaskStatusEnum)).Count(); i < count; i++)
            {
                AppTaskStatusEnumTextOrderedList.Add(new AppTaskStatusEnumTextOrdered() { AppTaskStatus = (AppTaskStatusEnum)i, AppTaskStatusText = GetEnumText_AppTaskStatusEnum((AppTaskStatusEnum)i) });
            }

            AppTaskStatusEnumTextOrderedList = (from c in AppTaskStatusEnumTextOrderedList
                                              orderby c.AppTaskStatusText
                                              select c).ToList();

            return AppTaskStatusEnumTextOrderedList;
        }
        public List<BeaufortScaleEnumTextOrdered> GetBeaufortScaleEnumTextOrderedList()
        {
            List<BeaufortScaleEnumTextOrdered> BeaufortScaleEnumTextOrderedList = new List<BeaufortScaleEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(BeaufortScaleEnum)).Count(); i < count; i++)
            {
                BeaufortScaleEnumTextOrderedList.Add(new BeaufortScaleEnumTextOrdered() { BeaufortScale = (BeaufortScaleEnum)i, BeaufortScaleText = GetEnumText_BeaufortScaleEnum((BeaufortScaleEnum)i) });
            }

            BeaufortScaleEnumTextOrderedList = (from c in BeaufortScaleEnumTextOrderedList
                                              orderby c.BeaufortScaleText
                                              select c).ToList();

            return BeaufortScaleEnumTextOrderedList;
        }
        public List<BoxModelResultTypeEnumTextOrdered> GetBoxModelResultTypeEnumTextOrderedList()
        {
            List<BoxModelResultTypeEnumTextOrdered> BoxModelResultTypeEnumTextOrderedList = new List<BoxModelResultTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(BoxModelResultTypeEnum)).Count(); i < count; i++)
            {
                BoxModelResultTypeEnumTextOrderedList.Add(new BoxModelResultTypeEnumTextOrdered() { BoxModelResultType = (BoxModelResultTypeEnum)i, BoxModelResultTypeText = GetEnumText_BoxModelResultTypeEnum((BoxModelResultTypeEnum)i) });
            }

            BoxModelResultTypeEnumTextOrderedList = (from c in BoxModelResultTypeEnumTextOrderedList
                                              orderby c.BoxModelResultTypeText
                                              select c).ToList();

            return BoxModelResultTypeEnumTextOrderedList;
        }
        public List<CollectionSystemTypeEnumTextOrdered> GetCollectionSystemTypeEnumTextOrderedList()
        {
            List<CollectionSystemTypeEnumTextOrdered> CollectionSystemTypeEnumTextOrderedList = new List<CollectionSystemTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(CollectionSystemTypeEnum)).Count(); i < count; i++)
            {
                CollectionSystemTypeEnumTextOrderedList.Add(new CollectionSystemTypeEnumTextOrdered() { CollectionSystemType = (CollectionSystemTypeEnum)i, CollectionSystemTypeText = GetEnumText_CollectionSystemTypeEnum((CollectionSystemTypeEnum)i) });
            }

            CollectionSystemTypeEnumTextOrderedList = (from c in CollectionSystemTypeEnumTextOrderedList
                                              orderby c.CollectionSystemTypeText
                                              select c).ToList();

            return CollectionSystemTypeEnumTextOrderedList;
        }
        public List<ContactTitleEnumTextOrdered> GetContactTitleEnumTextOrderedList()
        {
            List<ContactTitleEnumTextOrdered> ContactTitleEnumTextOrderedList = new List<ContactTitleEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(ContactTitleEnum)).Count(); i < count; i++)
            {
                ContactTitleEnumTextOrderedList.Add(new ContactTitleEnumTextOrdered() { ContactTitle = (ContactTitleEnum)i, ContactTitleText = GetEnumText_ContactTitleEnum((ContactTitleEnum)i) });
            }

            ContactTitleEnumTextOrderedList = (from c in ContactTitleEnumTextOrderedList
                                              orderby c.ContactTitleText
                                              select c).ToList();

            return ContactTitleEnumTextOrderedList;
        }
        public List<CSSPWQInputSheetTypeEnumTextOrdered> GetCSSPWQInputSheetTypeEnumTextOrderedList()
        {
            List<CSSPWQInputSheetTypeEnumTextOrdered> CSSPWQInputSheetTypeEnumTextOrderedList = new List<CSSPWQInputSheetTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(CSSPWQInputSheetTypeEnum)).Count(); i < count; i++)
            {
                CSSPWQInputSheetTypeEnumTextOrderedList.Add(new CSSPWQInputSheetTypeEnumTextOrdered() { CSSPWQInputSheetType = (CSSPWQInputSheetTypeEnum)i, CSSPWQInputSheetTypeText = GetEnumText_CSSPWQInputSheetTypeEnum((CSSPWQInputSheetTypeEnum)i) });
            }

            CSSPWQInputSheetTypeEnumTextOrderedList = (from c in CSSPWQInputSheetTypeEnumTextOrderedList
                                              orderby c.CSSPWQInputSheetTypeText
                                              select c).ToList();

            return CSSPWQInputSheetTypeEnumTextOrderedList;
        }
        public List<CSSPWQInputTypeEnumTextOrdered> GetCSSPWQInputTypeEnumTextOrderedList()
        {
            List<CSSPWQInputTypeEnumTextOrdered> CSSPWQInputTypeEnumTextOrderedList = new List<CSSPWQInputTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(CSSPWQInputTypeEnum)).Count(); i < count; i++)
            {
                CSSPWQInputTypeEnumTextOrderedList.Add(new CSSPWQInputTypeEnumTextOrdered() { CSSPWQInputType = (CSSPWQInputTypeEnum)i, CSSPWQInputTypeText = GetEnumText_CSSPWQInputTypeEnum((CSSPWQInputTypeEnum)i) });
            }

            CSSPWQInputTypeEnumTextOrderedList = (from c in CSSPWQInputTypeEnumTextOrderedList
                                              orderby c.CSSPWQInputTypeText
                                              select c).ToList();

            return CSSPWQInputTypeEnumTextOrderedList;
        }
        public List<DailyOrHourlyDataEnumTextOrdered> GetDailyOrHourlyDataEnumTextOrderedList()
        {
            List<DailyOrHourlyDataEnumTextOrdered> DailyOrHourlyDataEnumTextOrderedList = new List<DailyOrHourlyDataEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(DailyOrHourlyDataEnum)).Count(); i < count; i++)
            {
                DailyOrHourlyDataEnumTextOrderedList.Add(new DailyOrHourlyDataEnumTextOrdered() { DailyOrHourlyData = (DailyOrHourlyDataEnum)i, DailyOrHourlyDataText = GetEnumText_DailyOrHourlyDataEnum((DailyOrHourlyDataEnum)i) });
            }

            DailyOrHourlyDataEnumTextOrderedList = (from c in DailyOrHourlyDataEnumTextOrderedList
                                              orderby c.DailyOrHourlyDataText
                                              select c).ToList();

            return DailyOrHourlyDataEnumTextOrderedList;
        }
        public List<DatabaseTypeEnumTextOrdered> GetDatabaseTypeEnumTextOrderedList()
        {
            List<DatabaseTypeEnumTextOrdered> DatabaseTypeEnumTextOrderedList = new List<DatabaseTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(DatabaseTypeEnum)).Count(); i < count; i++)
            {
                DatabaseTypeEnumTextOrderedList.Add(new DatabaseTypeEnumTextOrdered() { DatabaseType = (DatabaseTypeEnum)i, DatabaseTypeText = GetEnumText_DatabaseTypeEnum((DatabaseTypeEnum)i) });
            }

            DatabaseTypeEnumTextOrderedList = (from c in DatabaseTypeEnumTextOrderedList
                                              orderby c.DatabaseTypeText
                                              select c).ToList();

            return DatabaseTypeEnumTextOrderedList;
        }
        public List<DisinfectionTypeEnumTextOrdered> GetDisinfectionTypeEnumTextOrderedList()
        {
            List<DisinfectionTypeEnumTextOrdered> DisinfectionTypeEnumTextOrderedList = new List<DisinfectionTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(DisinfectionTypeEnum)).Count(); i < count; i++)
            {
                DisinfectionTypeEnumTextOrderedList.Add(new DisinfectionTypeEnumTextOrdered() { DisinfectionType = (DisinfectionTypeEnum)i, DisinfectionTypeText = GetEnumText_DisinfectionTypeEnum((DisinfectionTypeEnum)i) });
            }

            DisinfectionTypeEnumTextOrderedList = (from c in DisinfectionTypeEnumTextOrderedList
                                              orderby c.DisinfectionTypeText
                                              select c).ToList();

            return DisinfectionTypeEnumTextOrderedList;
        }
        public List<EmailTypeEnumTextOrdered> GetEmailTypeEnumTextOrderedList()
        {
            List<EmailTypeEnumTextOrdered> EmailTypeEnumTextOrderedList = new List<EmailTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(EmailTypeEnum)).Count(); i < count; i++)
            {
                EmailTypeEnumTextOrderedList.Add(new EmailTypeEnumTextOrdered() { EmailType = (EmailTypeEnum)i, EmailTypeText = GetEnumText_EmailTypeEnum((EmailTypeEnum)i) });
            }

            EmailTypeEnumTextOrderedList = (from c in EmailTypeEnumTextOrderedList
                                              orderby c.EmailTypeText
                                              select c).ToList();

            return EmailTypeEnumTextOrderedList;
        }
        public List<FacilityTypeEnumTextOrdered> GetFacilityTypeEnumTextOrderedList()
        {
            List<FacilityTypeEnumTextOrdered> FacilityTypeEnumTextOrderedList = new List<FacilityTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(FacilityTypeEnum)).Count(); i < count; i++)
            {
                FacilityTypeEnumTextOrderedList.Add(new FacilityTypeEnumTextOrdered() { FacilityType = (FacilityTypeEnum)i, FacilityTypeText = GetEnumText_FacilityTypeEnum((FacilityTypeEnum)i) });
            }

            FacilityTypeEnumTextOrderedList = (from c in FacilityTypeEnumTextOrderedList
                                              orderby c.FacilityTypeText
                                              select c).ToList();

            return FacilityTypeEnumTextOrderedList;
        }
        public List<FilePurposeEnumTextOrdered> GetFilePurposeEnumTextOrderedList()
        {
            List<FilePurposeEnumTextOrdered> FilePurposeEnumTextOrderedList = new List<FilePurposeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(FilePurposeEnum)).Count(); i < count; i++)
            {
                FilePurposeEnumTextOrderedList.Add(new FilePurposeEnumTextOrdered() { FilePurpose = (FilePurposeEnum)i, FilePurposeText = GetEnumText_FilePurposeEnum((FilePurposeEnum)i) });
            }

            FilePurposeEnumTextOrderedList = (from c in FilePurposeEnumTextOrderedList
                                              orderby c.FilePurposeText
                                              select c).ToList();

            return FilePurposeEnumTextOrderedList;
        }
        public List<FileStatusEnumTextOrdered> GetFileStatusEnumTextOrderedList()
        {
            List<FileStatusEnumTextOrdered> FileStatusEnumTextOrderedList = new List<FileStatusEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(FileStatusEnum)).Count(); i < count; i++)
            {
                FileStatusEnumTextOrderedList.Add(new FileStatusEnumTextOrdered() { FileStatus = (FileStatusEnum)i, FileStatusText = GetEnumText_FileStatusEnum((FileStatusEnum)i) });
            }

            FileStatusEnumTextOrderedList = (from c in FileStatusEnumTextOrderedList
                                              orderby c.FileStatusText
                                              select c).ToList();

            return FileStatusEnumTextOrderedList;
        }
        public List<FileTypeEnumTextOrdered> GetFileTypeEnumTextOrderedList()
        {
            List<FileTypeEnumTextOrdered> FileTypeEnumTextOrderedList = new List<FileTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(FileTypeEnum)).Count(); i < count; i++)
            {
                FileTypeEnumTextOrderedList.Add(new FileTypeEnumTextOrdered() { FileType = (FileTypeEnum)i, FileTypeText = GetEnumText_FileTypeEnum((FileTypeEnum)i) });
            }

            FileTypeEnumTextOrderedList = (from c in FileTypeEnumTextOrderedList
                                              orderby c.FileTypeText
                                              select c).ToList();

            return FileTypeEnumTextOrderedList;
        }
        public List<InfrastructureTypeEnumTextOrdered> GetInfrastructureTypeEnumTextOrderedList()
        {
            List<InfrastructureTypeEnumTextOrdered> InfrastructureTypeEnumTextOrderedList = new List<InfrastructureTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(InfrastructureTypeEnum)).Count(); i < count; i++)
            {
                InfrastructureTypeEnumTextOrderedList.Add(new InfrastructureTypeEnumTextOrdered() { InfrastructureType = (InfrastructureTypeEnum)i, InfrastructureTypeText = GetEnumText_InfrastructureTypeEnum((InfrastructureTypeEnum)i) });
            }

            InfrastructureTypeEnumTextOrderedList = (from c in InfrastructureTypeEnumTextOrderedList
                                              orderby c.InfrastructureTypeText
                                              select c).ToList();

            return InfrastructureTypeEnumTextOrderedList;
        }
        public List<KMZActionEnumTextOrdered> GetKMZActionEnumTextOrderedList()
        {
            List<KMZActionEnumTextOrdered> KMZActionEnumTextOrderedList = new List<KMZActionEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(KMZActionEnum)).Count(); i < count; i++)
            {
                KMZActionEnumTextOrderedList.Add(new KMZActionEnumTextOrdered() { KMZAction = (KMZActionEnum)i, KMZActionText = GetEnumText_KMZActionEnum((KMZActionEnum)i) });
            }

            KMZActionEnumTextOrderedList = (from c in KMZActionEnumTextOrderedList
                                              orderby c.KMZActionText
                                              select c).ToList();

            return KMZActionEnumTextOrderedList;
        }
        public List<LaboratoryEnumTextOrdered> GetLaboratoryEnumTextOrderedList()
        {
            List<LaboratoryEnumTextOrdered> LaboratoryEnumTextOrderedList = new List<LaboratoryEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(LaboratoryEnum)).Count(); i < count; i++)
            {
                LaboratoryEnumTextOrderedList.Add(new LaboratoryEnumTextOrdered() { Laboratory = (LaboratoryEnum)i, LaboratoryText = GetEnumText_LaboratoryEnum((LaboratoryEnum)i) });
            }

            LaboratoryEnumTextOrderedList = (from c in LaboratoryEnumTextOrderedList
                                              orderby c.LaboratoryText
                                              select c).ToList();

            return LaboratoryEnumTextOrderedList;
        }
        public List<LabSheetStatusEnumTextOrdered> GetLabSheetStatusEnumTextOrderedList()
        {
            List<LabSheetStatusEnumTextOrdered> LabSheetStatusEnumTextOrderedList = new List<LabSheetStatusEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(LabSheetStatusEnum)).Count(); i < count; i++)
            {
                LabSheetStatusEnumTextOrderedList.Add(new LabSheetStatusEnumTextOrdered() { LabSheetStatus = (LabSheetStatusEnum)i, LabSheetStatusText = GetEnumText_LabSheetStatusEnum((LabSheetStatusEnum)i) });
            }

            LabSheetStatusEnumTextOrderedList = (from c in LabSheetStatusEnumTextOrderedList
                                              orderby c.LabSheetStatusText
                                              select c).ToList();

            return LabSheetStatusEnumTextOrderedList;
        }
        public List<LabSheetTypeEnumTextOrdered> GetLabSheetTypeEnumTextOrderedList()
        {
            List<LabSheetTypeEnumTextOrdered> LabSheetTypeEnumTextOrderedList = new List<LabSheetTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(LabSheetTypeEnum)).Count(); i < count; i++)
            {
                LabSheetTypeEnumTextOrderedList.Add(new LabSheetTypeEnumTextOrdered() { LabSheetType = (LabSheetTypeEnum)i, LabSheetTypeText = GetEnumText_LabSheetTypeEnum((LabSheetTypeEnum)i) });
            }

            LabSheetTypeEnumTextOrderedList = (from c in LabSheetTypeEnumTextOrderedList
                                              orderby c.LabSheetTypeText
                                              select c).ToList();

            return LabSheetTypeEnumTextOrderedList;
        }
        public List<LanguageEnumTextOrdered> GetLanguageEnumTextOrderedList()
        {
            List<LanguageEnumTextOrdered> LanguageEnumTextOrderedList = new List<LanguageEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(LanguageEnum)).Count(); i < count; i++)
            {
                LanguageEnumTextOrderedList.Add(new LanguageEnumTextOrdered() { Language = (LanguageEnum)i, LanguageText = GetEnumText_LanguageEnum((LanguageEnum)i) });
            }

            LanguageEnumTextOrderedList = (from c in LanguageEnumTextOrderedList
                                              orderby c.LanguageText
                                              select c).ToList();

            return LanguageEnumTextOrderedList;
        }
        public List<LogCommandEnumTextOrdered> GetLogCommandEnumTextOrderedList()
        {
            List<LogCommandEnumTextOrdered> LogCommandEnumTextOrderedList = new List<LogCommandEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(LogCommandEnum)).Count(); i < count; i++)
            {
                LogCommandEnumTextOrderedList.Add(new LogCommandEnumTextOrdered() { LogCommand = (LogCommandEnum)i, LogCommandText = GetEnumText_LogCommandEnum((LogCommandEnum)i) });
            }

            LogCommandEnumTextOrderedList = (from c in LogCommandEnumTextOrderedList
                                              orderby c.LogCommandText
                                              select c).ToList();

            return LogCommandEnumTextOrderedList;
        }
        public List<MapInfoDrawTypeEnumTextOrdered> GetMapInfoDrawTypeEnumTextOrderedList()
        {
            List<MapInfoDrawTypeEnumTextOrdered> MapInfoDrawTypeEnumTextOrderedList = new List<MapInfoDrawTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(MapInfoDrawTypeEnum)).Count(); i < count; i++)
            {
                MapInfoDrawTypeEnumTextOrderedList.Add(new MapInfoDrawTypeEnumTextOrdered() { MapInfoDrawType = (MapInfoDrawTypeEnum)i, MapInfoDrawTypeText = GetEnumText_MapInfoDrawTypeEnum((MapInfoDrawTypeEnum)i) });
            }

            MapInfoDrawTypeEnumTextOrderedList = (from c in MapInfoDrawTypeEnumTextOrderedList
                                              orderby c.MapInfoDrawTypeText
                                              select c).ToList();

            return MapInfoDrawTypeEnumTextOrderedList;
        }
        public List<MikeBoundaryConditionLevelOrVelocityEnumTextOrdered> GetMikeBoundaryConditionLevelOrVelocityEnumTextOrderedList()
        {
            List<MikeBoundaryConditionLevelOrVelocityEnumTextOrdered> MikeBoundaryConditionLevelOrVelocityEnumTextOrderedList = new List<MikeBoundaryConditionLevelOrVelocityEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(MikeBoundaryConditionLevelOrVelocityEnum)).Count(); i < count; i++)
            {
                MikeBoundaryConditionLevelOrVelocityEnumTextOrderedList.Add(new MikeBoundaryConditionLevelOrVelocityEnumTextOrdered() { MikeBoundaryConditionLevelOrVelocity = (MikeBoundaryConditionLevelOrVelocityEnum)i, MikeBoundaryConditionLevelOrVelocityText = GetEnumText_MikeBoundaryConditionLevelOrVelocityEnum((MikeBoundaryConditionLevelOrVelocityEnum)i) });
            }

            MikeBoundaryConditionLevelOrVelocityEnumTextOrderedList = (from c in MikeBoundaryConditionLevelOrVelocityEnumTextOrderedList
                                              orderby c.MikeBoundaryConditionLevelOrVelocityText
                                              select c).ToList();

            return MikeBoundaryConditionLevelOrVelocityEnumTextOrderedList;
        }
        public List<MikeScenarioSpecialResultKMLTypeEnumTextOrdered> GetMikeScenarioSpecialResultKMLTypeEnumTextOrderedList()
        {
            List<MikeScenarioSpecialResultKMLTypeEnumTextOrdered> MikeScenarioSpecialResultKMLTypeEnumTextOrderedList = new List<MikeScenarioSpecialResultKMLTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(MikeScenarioSpecialResultKMLTypeEnum)).Count(); i < count; i++)
            {
                MikeScenarioSpecialResultKMLTypeEnumTextOrderedList.Add(new MikeScenarioSpecialResultKMLTypeEnumTextOrdered() { MikeScenarioSpecialResultKMLType = (MikeScenarioSpecialResultKMLTypeEnum)i, MikeScenarioSpecialResultKMLTypeText = GetEnumText_MikeScenarioSpecialResultKMLTypeEnum((MikeScenarioSpecialResultKMLTypeEnum)i) });
            }

            MikeScenarioSpecialResultKMLTypeEnumTextOrderedList = (from c in MikeScenarioSpecialResultKMLTypeEnumTextOrderedList
                                              orderby c.MikeScenarioSpecialResultKMLTypeText
                                              select c).ToList();

            return MikeScenarioSpecialResultKMLTypeEnumTextOrderedList;
        }
        public List<MWQMSiteLatestClassificationEnumTextOrdered> GetMWQMSiteLatestClassificationEnumTextOrderedList()
        {
            List<MWQMSiteLatestClassificationEnumTextOrdered> MWQMSiteLatestClassificationEnumTextOrderedList = new List<MWQMSiteLatestClassificationEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(MWQMSiteLatestClassificationEnum)).Count(); i < count; i++)
            {
                MWQMSiteLatestClassificationEnumTextOrderedList.Add(new MWQMSiteLatestClassificationEnumTextOrdered() { MWQMSiteLatestClassification = (MWQMSiteLatestClassificationEnum)i, MWQMSiteLatestClassificationText = GetEnumText_MWQMSiteLatestClassificationEnum((MWQMSiteLatestClassificationEnum)i) });
            }

            MWQMSiteLatestClassificationEnumTextOrderedList = (from c in MWQMSiteLatestClassificationEnumTextOrderedList
                                              orderby c.MWQMSiteLatestClassificationText
                                              select c).ToList();

            return MWQMSiteLatestClassificationEnumTextOrderedList;
        }
        public List<PolSourceInactiveReasonEnumTextOrdered> GetPolSourceInactiveReasonEnumTextOrderedList()
        {
            List<PolSourceInactiveReasonEnumTextOrdered> PolSourceInactiveReasonEnumTextOrderedList = new List<PolSourceInactiveReasonEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(PolSourceInactiveReasonEnum)).Count(); i < count; i++)
            {
                PolSourceInactiveReasonEnumTextOrderedList.Add(new PolSourceInactiveReasonEnumTextOrdered() { PolSourceInactiveReason = (PolSourceInactiveReasonEnum)i, PolSourceInactiveReasonText = GetEnumText_PolSourceInactiveReasonEnum((PolSourceInactiveReasonEnum)i) });
            }

            PolSourceInactiveReasonEnumTextOrderedList = (from c in PolSourceInactiveReasonEnumTextOrderedList
                                              orderby c.PolSourceInactiveReasonText
                                              select c).ToList();

            return PolSourceInactiveReasonEnumTextOrderedList;
        }
        public List<PolSourceIssueRiskEnumTextOrdered> GetPolSourceIssueRiskEnumTextOrderedList()
        {
            List<PolSourceIssueRiskEnumTextOrdered> PolSourceIssueRiskEnumTextOrderedList = new List<PolSourceIssueRiskEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(PolSourceIssueRiskEnum)).Count(); i < count; i++)
            {
                PolSourceIssueRiskEnumTextOrderedList.Add(new PolSourceIssueRiskEnumTextOrdered() { PolSourceIssueRisk = (PolSourceIssueRiskEnum)i, PolSourceIssueRiskText = GetEnumText_PolSourceIssueRiskEnum((PolSourceIssueRiskEnum)i) });
            }

            PolSourceIssueRiskEnumTextOrderedList = (from c in PolSourceIssueRiskEnumTextOrderedList
                                              orderby c.PolSourceIssueRiskText
                                              select c).ToList();

            return PolSourceIssueRiskEnumTextOrderedList;
        }
        public List<PreliminaryTreatmentTypeEnumTextOrdered> GetPreliminaryTreatmentTypeEnumTextOrderedList()
        {
            List<PreliminaryTreatmentTypeEnumTextOrdered> PreliminaryTreatmentTypeEnumTextOrderedList = new List<PreliminaryTreatmentTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(PreliminaryTreatmentTypeEnum)).Count(); i < count; i++)
            {
                PreliminaryTreatmentTypeEnumTextOrderedList.Add(new PreliminaryTreatmentTypeEnumTextOrdered() { PreliminaryTreatmentType = (PreliminaryTreatmentTypeEnum)i, PreliminaryTreatmentTypeText = GetEnumText_PreliminaryTreatmentTypeEnum((PreliminaryTreatmentTypeEnum)i) });
            }

            PreliminaryTreatmentTypeEnumTextOrderedList = (from c in PreliminaryTreatmentTypeEnumTextOrderedList
                                              orderby c.PreliminaryTreatmentTypeText
                                              select c).ToList();

            return PreliminaryTreatmentTypeEnumTextOrderedList;
        }
        public List<PrimaryTreatmentTypeEnumTextOrdered> GetPrimaryTreatmentTypeEnumTextOrderedList()
        {
            List<PrimaryTreatmentTypeEnumTextOrdered> PrimaryTreatmentTypeEnumTextOrderedList = new List<PrimaryTreatmentTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(PrimaryTreatmentTypeEnum)).Count(); i < count; i++)
            {
                PrimaryTreatmentTypeEnumTextOrderedList.Add(new PrimaryTreatmentTypeEnumTextOrdered() { PrimaryTreatmentType = (PrimaryTreatmentTypeEnum)i, PrimaryTreatmentTypeText = GetEnumText_PrimaryTreatmentTypeEnum((PrimaryTreatmentTypeEnum)i) });
            }

            PrimaryTreatmentTypeEnumTextOrderedList = (from c in PrimaryTreatmentTypeEnumTextOrderedList
                                              orderby c.PrimaryTreatmentTypeText
                                              select c).ToList();

            return PrimaryTreatmentTypeEnumTextOrderedList;
        }
        public List<ReportConditionEnumTextOrdered> GetReportConditionEnumTextOrderedList()
        {
            List<ReportConditionEnumTextOrdered> ReportConditionEnumTextOrderedList = new List<ReportConditionEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(ReportConditionEnum)).Count(); i < count; i++)
            {
                ReportConditionEnumTextOrderedList.Add(new ReportConditionEnumTextOrdered() { ReportCondition = (ReportConditionEnum)i, ReportConditionText = GetEnumText_ReportConditionEnum((ReportConditionEnum)i) });
            }

            ReportConditionEnumTextOrderedList = (from c in ReportConditionEnumTextOrderedList
                                              orderby c.ReportConditionText
                                              select c).ToList();

            return ReportConditionEnumTextOrderedList;
        }
        public List<ReportFieldTypeEnumTextOrdered> GetReportFieldTypeEnumTextOrderedList()
        {
            List<ReportFieldTypeEnumTextOrdered> ReportFieldTypeEnumTextOrderedList = new List<ReportFieldTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(ReportFieldTypeEnum)).Count(); i < count; i++)
            {
                ReportFieldTypeEnumTextOrderedList.Add(new ReportFieldTypeEnumTextOrdered() { ReportFieldType = (ReportFieldTypeEnum)i, ReportFieldTypeText = GetEnumText_ReportFieldTypeEnum((ReportFieldTypeEnum)i) });
            }

            ReportFieldTypeEnumTextOrderedList = (from c in ReportFieldTypeEnumTextOrderedList
                                              orderby c.ReportFieldTypeText
                                              select c).ToList();

            return ReportFieldTypeEnumTextOrderedList;
        }
        public List<ReportFileTypeEnumTextOrdered> GetReportFileTypeEnumTextOrderedList()
        {
            List<ReportFileTypeEnumTextOrdered> ReportFileTypeEnumTextOrderedList = new List<ReportFileTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(ReportFileTypeEnum)).Count(); i < count; i++)
            {
                ReportFileTypeEnumTextOrderedList.Add(new ReportFileTypeEnumTextOrdered() { ReportFileType = (ReportFileTypeEnum)i, ReportFileTypeText = GetEnumText_ReportFileTypeEnum((ReportFileTypeEnum)i) });
            }

            ReportFileTypeEnumTextOrderedList = (from c in ReportFileTypeEnumTextOrderedList
                                              orderby c.ReportFileTypeText
                                              select c).ToList();

            return ReportFileTypeEnumTextOrderedList;
        }
        public List<ReportFormatingDateEnumTextOrdered> GetReportFormatingDateEnumTextOrderedList()
        {
            List<ReportFormatingDateEnumTextOrdered> ReportFormatingDateEnumTextOrderedList = new List<ReportFormatingDateEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(ReportFormatingDateEnum)).Count(); i < count; i++)
            {
                ReportFormatingDateEnumTextOrderedList.Add(new ReportFormatingDateEnumTextOrdered() { ReportFormatingDate = (ReportFormatingDateEnum)i, ReportFormatingDateText = GetEnumText_ReportFormatingDateEnum((ReportFormatingDateEnum)i) });
            }

            ReportFormatingDateEnumTextOrderedList = (from c in ReportFormatingDateEnumTextOrderedList
                                              orderby c.ReportFormatingDateText
                                              select c).ToList();

            return ReportFormatingDateEnumTextOrderedList;
        }
        public List<ReportFormatingNumberEnumTextOrdered> GetReportFormatingNumberEnumTextOrderedList()
        {
            List<ReportFormatingNumberEnumTextOrdered> ReportFormatingNumberEnumTextOrderedList = new List<ReportFormatingNumberEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(ReportFormatingNumberEnum)).Count(); i < count; i++)
            {
                ReportFormatingNumberEnumTextOrderedList.Add(new ReportFormatingNumberEnumTextOrdered() { ReportFormatingNumber = (ReportFormatingNumberEnum)i, ReportFormatingNumberText = GetEnumText_ReportFormatingNumberEnum((ReportFormatingNumberEnum)i) });
            }

            ReportFormatingNumberEnumTextOrderedList = (from c in ReportFormatingNumberEnumTextOrderedList
                                              orderby c.ReportFormatingNumberText
                                              select c).ToList();

            return ReportFormatingNumberEnumTextOrderedList;
        }
        public List<ReportSortingEnumTextOrdered> GetReportSortingEnumTextOrderedList()
        {
            List<ReportSortingEnumTextOrdered> ReportSortingEnumTextOrderedList = new List<ReportSortingEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(ReportSortingEnum)).Count(); i < count; i++)
            {
                ReportSortingEnumTextOrderedList.Add(new ReportSortingEnumTextOrdered() { ReportSorting = (ReportSortingEnum)i, ReportSortingText = GetEnumText_ReportSortingEnum((ReportSortingEnum)i) });
            }

            ReportSortingEnumTextOrderedList = (from c in ReportSortingEnumTextOrderedList
                                              orderby c.ReportSortingText
                                              select c).ToList();

            return ReportSortingEnumTextOrderedList;
        }
        public List<ReportTreeNodeSubTypeEnumTextOrdered> GetReportTreeNodeSubTypeEnumTextOrderedList()
        {
            List<ReportTreeNodeSubTypeEnumTextOrdered> ReportTreeNodeSubTypeEnumTextOrderedList = new List<ReportTreeNodeSubTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(ReportTreeNodeSubTypeEnum)).Count(); i < count; i++)
            {
                ReportTreeNodeSubTypeEnumTextOrderedList.Add(new ReportTreeNodeSubTypeEnumTextOrdered() { ReportTreeNodeSubType = (ReportTreeNodeSubTypeEnum)i, ReportTreeNodeSubTypeText = GetEnumText_ReportTreeNodeSubTypeEnum((ReportTreeNodeSubTypeEnum)i) });
            }

            ReportTreeNodeSubTypeEnumTextOrderedList = (from c in ReportTreeNodeSubTypeEnumTextOrderedList
                                              orderby c.ReportTreeNodeSubTypeText
                                              select c).ToList();

            return ReportTreeNodeSubTypeEnumTextOrderedList;
        }
        public List<ReportTreeNodeTypeEnumTextOrdered> GetReportTreeNodeTypeEnumTextOrderedList()
        {
            List<ReportTreeNodeTypeEnumTextOrdered> ReportTreeNodeTypeEnumTextOrderedList = new List<ReportTreeNodeTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(ReportTreeNodeTypeEnum)).Count(); i < count; i++)
            {
                ReportTreeNodeTypeEnumTextOrderedList.Add(new ReportTreeNodeTypeEnumTextOrdered() { ReportTreeNodeType = (ReportTreeNodeTypeEnum)i, ReportTreeNodeTypeText = GetEnumText_ReportTreeNodeTypeEnum((ReportTreeNodeTypeEnum)i) });
            }

            ReportTreeNodeTypeEnumTextOrderedList = (from c in ReportTreeNodeTypeEnumTextOrderedList
                                              orderby c.ReportTreeNodeTypeText
                                              select c).ToList();

            return ReportTreeNodeTypeEnumTextOrderedList;
        }
        public List<SameDayNextDayEnumTextOrdered> GetSameDayNextDayEnumTextOrderedList()
        {
            List<SameDayNextDayEnumTextOrdered> SameDayNextDayEnumTextOrderedList = new List<SameDayNextDayEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(SameDayNextDayEnum)).Count(); i < count; i++)
            {
                SameDayNextDayEnumTextOrderedList.Add(new SameDayNextDayEnumTextOrdered() { SameDayNextDay = (SameDayNextDayEnum)i, SameDayNextDayText = GetEnumText_SameDayNextDayEnum((SameDayNextDayEnum)i) });
            }

            SameDayNextDayEnumTextOrderedList = (from c in SameDayNextDayEnumTextOrderedList
                                              orderby c.SameDayNextDayText
                                              select c).ToList();

            return SameDayNextDayEnumTextOrderedList;
        }
        public List<SampleMatrixEnumTextOrdered> GetSampleMatrixEnumTextOrderedList()
        {
            List<SampleMatrixEnumTextOrdered> SampleMatrixEnumTextOrderedList = new List<SampleMatrixEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(SampleMatrixEnum)).Count(); i < count; i++)
            {
                SampleMatrixEnumTextOrderedList.Add(new SampleMatrixEnumTextOrdered() { SampleMatrix = (SampleMatrixEnum)i, SampleMatrixText = GetEnumText_SampleMatrixEnum((SampleMatrixEnum)i) });
            }

            SampleMatrixEnumTextOrderedList = (from c in SampleMatrixEnumTextOrderedList
                                              orderby c.SampleMatrixText
                                              select c).ToList();

            return SampleMatrixEnumTextOrderedList;
        }
        public List<SampleStatusEnumTextOrdered> GetSampleStatusEnumTextOrderedList()
        {
            List<SampleStatusEnumTextOrdered> SampleStatusEnumTextOrderedList = new List<SampleStatusEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(SampleStatusEnum)).Count(); i < count; i++)
            {
                SampleStatusEnumTextOrderedList.Add(new SampleStatusEnumTextOrdered() { SampleStatus = (SampleStatusEnum)i, SampleStatusText = GetEnumText_SampleStatusEnum((SampleStatusEnum)i) });
            }

            SampleStatusEnumTextOrderedList = (from c in SampleStatusEnumTextOrderedList
                                              orderby c.SampleStatusText
                                              select c).ToList();

            return SampleStatusEnumTextOrderedList;
        }
        public List<SampleTypeEnumTextOrdered> GetSampleTypeEnumTextOrderedList()
        {
            List<SampleTypeEnumTextOrdered> SampleTypeEnumTextOrderedList = new List<SampleTypeEnumTextOrdered>();

            for (int i = 101, count = Enum.GetNames(typeof(SampleTypeEnum)).Count() + 100; i < count; i++)
            {
                SampleTypeEnumTextOrderedList.Add(new SampleTypeEnumTextOrdered() { SampleType = (SampleTypeEnum)i, SampleTypeText = GetEnumText_SampleTypeEnum((SampleTypeEnum)i) });
            }

            SampleTypeEnumTextOrderedList = (from c in SampleTypeEnumTextOrderedList
                                              orderby c.SampleTypeText
                                              select c).ToList();

            return SampleTypeEnumTextOrderedList;
        }
        public List<SamplingPlanTypeEnumTextOrdered> GetSamplingPlanTypeEnumTextOrderedList()
        {
            List<SamplingPlanTypeEnumTextOrdered> SamplingPlanTypeEnumTextOrderedList = new List<SamplingPlanTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(SamplingPlanTypeEnum)).Count(); i < count; i++)
            {
                SamplingPlanTypeEnumTextOrderedList.Add(new SamplingPlanTypeEnumTextOrdered() { SamplingPlanType = (SamplingPlanTypeEnum)i, SamplingPlanTypeText = GetEnumText_SamplingPlanTypeEnum((SamplingPlanTypeEnum)i) });
            }

            SamplingPlanTypeEnumTextOrderedList = (from c in SamplingPlanTypeEnumTextOrderedList
                                              orderby c.SamplingPlanTypeText
                                              select c).ToList();

            return SamplingPlanTypeEnumTextOrderedList;
        }
        public List<ScenarioStatusEnumTextOrdered> GetScenarioStatusEnumTextOrderedList()
        {
            List<ScenarioStatusEnumTextOrdered> ScenarioStatusEnumTextOrderedList = new List<ScenarioStatusEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(ScenarioStatusEnum)).Count(); i < count; i++)
            {
                ScenarioStatusEnumTextOrderedList.Add(new ScenarioStatusEnumTextOrdered() { ScenarioStatus = (ScenarioStatusEnum)i, ScenarioStatusText = GetEnumText_ScenarioStatusEnum((ScenarioStatusEnum)i) });
            }

            ScenarioStatusEnumTextOrderedList = (from c in ScenarioStatusEnumTextOrderedList
                                              orderby c.ScenarioStatusText
                                              select c).ToList();

            return ScenarioStatusEnumTextOrderedList;
        }
        public List<SearchTagEnumTextOrdered> GetSearchTagEnumTextOrderedList()
        {
            List<SearchTagEnumTextOrdered> SearchTagEnumTextOrderedList = new List<SearchTagEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(SearchTagEnum)).Count(); i < count; i++)
            {
                SearchTagEnumTextOrderedList.Add(new SearchTagEnumTextOrdered() { SearchTag = (SearchTagEnum)i, SearchTagText = GetEnumText_SearchTagEnum((SearchTagEnum)i) });
            }

            SearchTagEnumTextOrderedList = (from c in SearchTagEnumTextOrderedList
                                              orderby c.SearchTagText
                                              select c).ToList();

            return SearchTagEnumTextOrderedList;
        }
        public List<SecondaryTreatmentTypeEnumTextOrdered> GetSecondaryTreatmentTypeEnumTextOrderedList()
        {
            List<SecondaryTreatmentTypeEnumTextOrdered> SecondaryTreatmentTypeEnumTextOrderedList = new List<SecondaryTreatmentTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(SecondaryTreatmentTypeEnum)).Count(); i < count; i++)
            {
                SecondaryTreatmentTypeEnumTextOrderedList.Add(new SecondaryTreatmentTypeEnumTextOrdered() { SecondaryTreatmentType = (SecondaryTreatmentTypeEnum)i, SecondaryTreatmentTypeText = GetEnumText_SecondaryTreatmentTypeEnum((SecondaryTreatmentTypeEnum)i) });
            }

            SecondaryTreatmentTypeEnumTextOrderedList = (from c in SecondaryTreatmentTypeEnumTextOrderedList
                                              orderby c.SecondaryTreatmentTypeText
                                              select c).ToList();

            return SecondaryTreatmentTypeEnumTextOrderedList;
        }
        public List<SiteTypeEnumTextOrdered> GetSiteTypeEnumTextOrderedList()
        {
            List<SiteTypeEnumTextOrdered> SiteTypeEnumTextOrderedList = new List<SiteTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(SiteTypeEnum)).Count(); i < count; i++)
            {
                SiteTypeEnumTextOrderedList.Add(new SiteTypeEnumTextOrdered() { SiteType = (SiteTypeEnum)i, SiteTypeText = GetEnumText_SiteTypeEnum((SiteTypeEnum)i) });
            }

            SiteTypeEnumTextOrderedList = (from c in SiteTypeEnumTextOrderedList
                                              orderby c.SiteTypeText
                                              select c).ToList();

            return SiteTypeEnumTextOrderedList;
        }
        public List<SpecialTableTypeEnumTextOrdered> GetSpecialTableTypeEnumTextOrderedList()
        {
            List<SpecialTableTypeEnumTextOrdered> SpecialTableTypeEnumTextOrderedList = new List<SpecialTableTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(SpecialTableTypeEnum)).Count(); i < count; i++)
            {
                SpecialTableTypeEnumTextOrderedList.Add(new SpecialTableTypeEnumTextOrdered() { SpecialTableType = (SpecialTableTypeEnum)i, SpecialTableTypeText = GetEnumText_SpecialTableTypeEnum((SpecialTableTypeEnum)i) });
            }

            SpecialTableTypeEnumTextOrderedList = (from c in SpecialTableTypeEnumTextOrderedList
                                              orderby c.SpecialTableTypeText
                                              select c).ToList();

            return SpecialTableTypeEnumTextOrderedList;
        }
        public List<StorageDataTypeEnumTextOrdered> GetStorageDataTypeEnumTextOrderedList()
        {
            List<StorageDataTypeEnumTextOrdered> StorageDataTypeEnumTextOrderedList = new List<StorageDataTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(StorageDataTypeEnum)).Count(); i < count; i++)
            {
                StorageDataTypeEnumTextOrderedList.Add(new StorageDataTypeEnumTextOrdered() { StorageDataType = (StorageDataTypeEnum)i, StorageDataTypeText = GetEnumText_StorageDataTypeEnum((StorageDataTypeEnum)i) });
            }

            StorageDataTypeEnumTextOrderedList = (from c in StorageDataTypeEnumTextOrderedList
                                              orderby c.StorageDataTypeText
                                              select c).ToList();

            return StorageDataTypeEnumTextOrderedList;
        }
        public List<StreetTypeEnumTextOrdered> GetStreetTypeEnumTextOrderedList()
        {
            List<StreetTypeEnumTextOrdered> StreetTypeEnumTextOrderedList = new List<StreetTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(StreetTypeEnum)).Count(); i < count; i++)
            {
                StreetTypeEnumTextOrderedList.Add(new StreetTypeEnumTextOrdered() { StreetType = (StreetTypeEnum)i, StreetTypeText = GetEnumText_StreetTypeEnum((StreetTypeEnum)i) });
            }

            StreetTypeEnumTextOrderedList = (from c in StreetTypeEnumTextOrderedList
                                              orderby c.StreetTypeText
                                              select c).ToList();

            return StreetTypeEnumTextOrderedList;
        }
        public List<TelTypeEnumTextOrdered> GetTelTypeEnumTextOrderedList()
        {
            List<TelTypeEnumTextOrdered> TelTypeEnumTextOrderedList = new List<TelTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(TelTypeEnum)).Count(); i < count; i++)
            {
                TelTypeEnumTextOrderedList.Add(new TelTypeEnumTextOrdered() { TelType = (TelTypeEnum)i, TelTypeText = GetEnumText_TelTypeEnum((TelTypeEnum)i) });
            }

            TelTypeEnumTextOrderedList = (from c in TelTypeEnumTextOrderedList
                                              orderby c.TelTypeText
                                              select c).ToList();

            return TelTypeEnumTextOrderedList;
        }
        public List<TertiaryTreatmentTypeEnumTextOrdered> GetTertiaryTreatmentTypeEnumTextOrderedList()
        {
            List<TertiaryTreatmentTypeEnumTextOrdered> TertiaryTreatmentTypeEnumTextOrderedList = new List<TertiaryTreatmentTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(TertiaryTreatmentTypeEnum)).Count(); i < count; i++)
            {
                TertiaryTreatmentTypeEnumTextOrderedList.Add(new TertiaryTreatmentTypeEnumTextOrdered() { TertiaryTreatmentType = (TertiaryTreatmentTypeEnum)i, TertiaryTreatmentTypeText = GetEnumText_TertiaryTreatmentTypeEnum((TertiaryTreatmentTypeEnum)i) });
            }

            TertiaryTreatmentTypeEnumTextOrderedList = (from c in TertiaryTreatmentTypeEnumTextOrderedList
                                              orderby c.TertiaryTreatmentTypeText
                                              select c).ToList();

            return TertiaryTreatmentTypeEnumTextOrderedList;
        }
        public List<TideDataTypeEnumTextOrdered> GetTideDataTypeEnumTextOrderedList()
        {
            List<TideDataTypeEnumTextOrdered> TideDataTypeEnumTextOrderedList = new List<TideDataTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(TideDataTypeEnum)).Count(); i < count; i++)
            {
                TideDataTypeEnumTextOrderedList.Add(new TideDataTypeEnumTextOrdered() { TideDataType = (TideDataTypeEnum)i, TideDataTypeText = GetEnumText_TideDataTypeEnum((TideDataTypeEnum)i) });
            }

            TideDataTypeEnumTextOrderedList = (from c in TideDataTypeEnumTextOrderedList
                                              orderby c.TideDataTypeText
                                              select c).ToList();

            return TideDataTypeEnumTextOrderedList;
        }
        public List<TideTextEnumTextOrdered> GetTideTextEnumTextOrderedList()
        {
            List<TideTextEnumTextOrdered> TideTextEnumTextOrderedList = new List<TideTextEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(TideTextEnum)).Count(); i < count; i++)
            {
                TideTextEnumTextOrderedList.Add(new TideTextEnumTextOrdered() { TideText = (TideTextEnum)i, TideTextText = GetEnumText_TideTextEnum((TideTextEnum)i) });
            }

            TideTextEnumTextOrderedList = (from c in TideTextEnumTextOrderedList
                                              orderby c.TideTextText
                                              select c).ToList();

            return TideTextEnumTextOrderedList;
        }
        public List<TranslationStatusEnumTextOrdered> GetTranslationStatusEnumTextOrderedList()
        {
            List<TranslationStatusEnumTextOrdered> TranslationStatusEnumTextOrderedList = new List<TranslationStatusEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(TranslationStatusEnum)).Count(); i < count; i++)
            {
                TranslationStatusEnumTextOrderedList.Add(new TranslationStatusEnumTextOrdered() { TranslationStatus = (TranslationStatusEnum)i, TranslationStatusText = GetEnumText_TranslationStatusEnum((TranslationStatusEnum)i) });
            }

            TranslationStatusEnumTextOrderedList = (from c in TranslationStatusEnumTextOrderedList
                                              orderby c.TranslationStatusText
                                              select c).ToList();

            return TranslationStatusEnumTextOrderedList;
        }
        public List<TreatmentTypeEnumTextOrdered> GetTreatmentTypeEnumTextOrderedList()
        {
            List<TreatmentTypeEnumTextOrdered> TreatmentTypeEnumTextOrderedList = new List<TreatmentTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(TreatmentTypeEnum)).Count(); i < count; i++)
            {
                TreatmentTypeEnumTextOrderedList.Add(new TreatmentTypeEnumTextOrdered() { TreatmentType = (TreatmentTypeEnum)i, TreatmentTypeText = GetEnumText_TreatmentTypeEnum((TreatmentTypeEnum)i) });
            }

            TreatmentTypeEnumTextOrderedList = (from c in TreatmentTypeEnumTextOrderedList
                                              orderby c.TreatmentTypeText
                                              select c).ToList();

            return TreatmentTypeEnumTextOrderedList;
        }
        public List<TVAuthEnumTextOrdered> GetTVAuthEnumTextOrderedList()
        {
            List<TVAuthEnumTextOrdered> TVAuthEnumTextOrderedList = new List<TVAuthEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(TVAuthEnum)).Count(); i < count; i++)
            {
                TVAuthEnumTextOrderedList.Add(new TVAuthEnumTextOrdered() { TVAuth = (TVAuthEnum)i, TVAuthText = GetEnumText_TVAuthEnum((TVAuthEnum)i) });
            }

            TVAuthEnumTextOrderedList = (from c in TVAuthEnumTextOrderedList
                                              orderby c.TVAuthText
                                              select c).ToList();

            return TVAuthEnumTextOrderedList;
        }
        public List<TVTypeEnumTextOrdered> GetTVTypeEnumTextOrderedList()
        {
            List<TVTypeEnumTextOrdered> TVTypeEnumTextOrderedList = new List<TVTypeEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(TVTypeEnum)).Count(); i < count; i++)
            {
                TVTypeEnumTextOrderedList.Add(new TVTypeEnumTextOrdered() { TVType = (TVTypeEnum)i, TVTypeText = GetEnumText_TVTypeEnum((TVTypeEnum)i) });
            }

            TVTypeEnumTextOrderedList = (from c in TVTypeEnumTextOrderedList
                                              orderby c.TVTypeText
                                              select c).ToList();

            return TVTypeEnumTextOrderedList;
        }
        public List<WebTideDataSetEnumTextOrdered> GetWebTideDataSetEnumTextOrderedList()
        {
            List<WebTideDataSetEnumTextOrdered> WebTideDataSetEnumTextOrderedList = new List<WebTideDataSetEnumTextOrdered>();

            for (int i = 1, count = Enum.GetNames(typeof(WebTideDataSetEnum)).Count(); i < count; i++)
            {
                WebTideDataSetEnumTextOrderedList.Add(new WebTideDataSetEnumTextOrdered() { WebTideDataSet = (WebTideDataSetEnum)i, WebTideDataSetText = GetEnumText_WebTideDataSetEnum((WebTideDataSetEnum)i) });
            }

            WebTideDataSetEnumTextOrderedList = (from c in WebTideDataSetEnumTextOrderedList
                                              orderby c.WebTideDataSetText
                                              select c).ToList();

            return WebTideDataSetEnumTextOrderedList;
        }

        #endregion Function Get Enum Text Ordered

        #region Enum CheckOK
        public string AddressTypeOK(AddressTypeEnum? addressType)
        {
            if (addressType == null)
                return "";

            switch ((AddressTypeEnum)addressType)
            {
                case AddressTypeEnum.Error:
                case AddressTypeEnum.Mailing:
                case AddressTypeEnum.Shipping:
                case AddressTypeEnum.Civic:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.AddressType);
            }
        }
        public string ActionDBTypeOK(ActionDBTypeEnum? actionDBType)
        {
            if (actionDBType == null)
                return "";

            switch ((ActionDBTypeEnum)actionDBType)
            {
                case ActionDBTypeEnum.Error:
                case ActionDBTypeEnum.Create:
                case ActionDBTypeEnum.Read:
                case ActionDBTypeEnum.Update:
                case ActionDBTypeEnum.Delete:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ActionDBType);
            }
        }
        public string AerationTypeOK(AerationTypeEnum? aerationType)
        {
            if (aerationType == null)
                return "";

            switch ((AerationTypeEnum)aerationType)
            {
                case AerationTypeEnum.Error:
                case AerationTypeEnum.Diffuser:
                case AerationTypeEnum.Surface:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.AerationType);
            }
        }
        public string AlarmSystemTypeOK(AlarmSystemTypeEnum? alarmSystemType)
        {
            if (alarmSystemType == null)
                return "";

            switch ((AlarmSystemTypeEnum)alarmSystemType)
            {
                case AlarmSystemTypeEnum.Error:
                case AlarmSystemTypeEnum.SCADA:
                case AlarmSystemTypeEnum.None:
                case AlarmSystemTypeEnum.OnlyVisualLight:
                case AlarmSystemTypeEnum.SCADAAndLight:
                case AlarmSystemTypeEnum.PagerAndLight:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.AlarmSystemType);
            }
        }
        public string AnalyzeMethodOK(AnalyzeMethodEnum? analyzeMethod)
        {
            if (analyzeMethod == null)
                return "";

            switch ((AnalyzeMethodEnum)analyzeMethod)
            {
                case AnalyzeMethodEnum.Error:
                case AnalyzeMethodEnum.MF:
                case AnalyzeMethodEnum.ZZ_510Q:
                case AnalyzeMethodEnum.ZZ_509Q:
                case AnalyzeMethodEnum.ZZ_0:
                case AnalyzeMethodEnum.ZZ_525Q:
                case AnalyzeMethodEnum.MPN:
                case AnalyzeMethodEnum.ZZ_0Q:
                case AnalyzeMethodEnum.AnalyzeMethod8:
                case AnalyzeMethodEnum.AnalyzeMethod9:
                case AnalyzeMethodEnum.AnalyzeMethod10:
                case AnalyzeMethodEnum.AnalyzeMethod11:
                case AnalyzeMethodEnum.AnalyzeMethod12:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.AnalyzeMethod);
            }
        }
        public string AppTaskCommandOK(AppTaskCommandEnum? appTaskCommand)
        {
            if (appTaskCommand == null)
                return "";

            switch ((AppTaskCommandEnum)appTaskCommand)
            {
                case AppTaskCommandEnum.Error:
                case AppTaskCommandEnum.GenerateWebTide:
                case AppTaskCommandEnum.MikeScenarioAskToRun:
                case AppTaskCommandEnum.MikeScenarioImport:
                case AppTaskCommandEnum.MikeScenarioOtherFileImport:
                case AppTaskCommandEnum.MikeScenarioRunning:
                case AppTaskCommandEnum.MikeScenarioToCancel:
                case AppTaskCommandEnum.MikeScenarioWaitingToRun:
                case AppTaskCommandEnum.SetupWebTide:
                case AppTaskCommandEnum.UpdateClimateSiteInformation:
                case AppTaskCommandEnum.UpdateClimateSiteDailyAndHourlyFromStartDateToEndDate:
                case AppTaskCommandEnum.UpdateClimateSiteDailyAndHourlyForSubsectorFromStartDateToEndDate:
                case AppTaskCommandEnum.CreateFCForm:
                case AppTaskCommandEnum.CreateSamplingPlanSamplingPlanTextFile:
                case AppTaskCommandEnum.CreateDocumentFromTemplate:
                case AppTaskCommandEnum.GetClimateSitesDataForRunsOfYear:
                case AppTaskCommandEnum.CreateWebTideDataWLAtFirstNode:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.AppTaskCommand);
            }
        }
        public string AppTaskStatusOK(AppTaskStatusEnum? appTaskStatus)
        {
            if (appTaskStatus == null)
                return "";

            switch ((AppTaskStatusEnum)appTaskStatus)
            {
                case AppTaskStatusEnum.Error:
                case AppTaskStatusEnum.Created:
                case AppTaskStatusEnum.Running:
                case AppTaskStatusEnum.Completed:
                case AppTaskStatusEnum.Cancelled:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.AppTaskStatus);
            }
        }
        public string BeaufortScaleOK(BeaufortScaleEnum? beaufortScale)
        {
            if (beaufortScale == null)
                return "";

            switch ((BeaufortScaleEnum)beaufortScale)
            {
                case BeaufortScaleEnum.Error:
                case BeaufortScaleEnum.Calm:
                case BeaufortScaleEnum.LightAir:
                case BeaufortScaleEnum.LightBreeze:
                case BeaufortScaleEnum.GentleBreeze:
                case BeaufortScaleEnum.ModerateBreeze:
                case BeaufortScaleEnum.FreshBreeze:
                case BeaufortScaleEnum.StrongBreeze:
                case BeaufortScaleEnum.HighWind_ModerateGale_NearGale:
                case BeaufortScaleEnum.Gale_FreshGale:
                case BeaufortScaleEnum.Strong_SevereGale:
                case BeaufortScaleEnum.Storm_WholeGale:
                case BeaufortScaleEnum.ViolentStorm:
                case BeaufortScaleEnum.HurricaneForce:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.BeaufortScale);
            }
        }
        public string BoxModelResultTypeOK(BoxModelResultTypeEnum? boxModelResultType)
        {
            if (boxModelResultType == null)
                return "";

            switch ((BoxModelResultTypeEnum)boxModelResultType)
            {
                case BoxModelResultTypeEnum.Error:
                case BoxModelResultTypeEnum.Dilution:
                case BoxModelResultTypeEnum.NoDecayUntreated:
                case BoxModelResultTypeEnum.NoDecayPreDisinfection:
                case BoxModelResultTypeEnum.DecayUntreated:
                case BoxModelResultTypeEnum.DecayPreDisinfection:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.BoxModelResultType);
            }
        }
        public string CollectionSystemTypeOK(CollectionSystemTypeEnum? collectionSystemType)
        {
            if (collectionSystemType == null)
                return "";

            switch ((CollectionSystemTypeEnum)collectionSystemType)
            {
                case CollectionSystemTypeEnum.Error:
                case CollectionSystemTypeEnum.CompletelySeparated:
                case CollectionSystemTypeEnum.CompletelyCombined:
                case CollectionSystemTypeEnum.Combined90Separated10:
                case CollectionSystemTypeEnum.Combined80Separated20:
                case CollectionSystemTypeEnum.Combined70Separated30:
                case CollectionSystemTypeEnum.Combined60Separated40:
                case CollectionSystemTypeEnum.Combined50Separated50:
                case CollectionSystemTypeEnum.Combined40Separated60:
                case CollectionSystemTypeEnum.Combined30Separated70:
                case CollectionSystemTypeEnum.Combined20Separated80:
                case CollectionSystemTypeEnum.Combined10Separated90:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.CollectionSystemType);
            }
        }
        public string ContactTitleOK(ContactTitleEnum? contactTitle)
        {
            if (contactTitle == null)
                return "";

            switch ((ContactTitleEnum)contactTitle)
            {
                case ContactTitleEnum.Error:
                case ContactTitleEnum.DirectorGeneral:
                case ContactTitleEnum.DirectorPublicWorks:
                case ContactTitleEnum.Superintendent:
                case ContactTitleEnum.Engineer:
                case ContactTitleEnum.Foreman:
                case ContactTitleEnum.Operator:
                case ContactTitleEnum.FacilitiesManager:
                case ContactTitleEnum.Supervisor:
                case ContactTitleEnum.Technician:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ContactTitle);
            }
        }
        public string CSSPWQInputSheetTypeOK(CSSPWQInputSheetTypeEnum? cSSPWQInputSheetType)
        {
            if (cSSPWQInputSheetType == null)
                return "";

            switch ((CSSPWQInputSheetTypeEnum)cSSPWQInputSheetType)
            {
                case CSSPWQInputSheetTypeEnum.Error:
                case CSSPWQInputSheetTypeEnum.A1:
                case CSSPWQInputSheetTypeEnum.LTB:
                case CSSPWQInputSheetTypeEnum.EC:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.CSSPWQInputSheetType);
            }
        }
        public string CSSPWQInputTypeOK(CSSPWQInputTypeEnum? cSSPWQInputType)
        {
            if (cSSPWQInputType == null)
                return "";

            switch ((CSSPWQInputTypeEnum)cSSPWQInputType)
            {
                case CSSPWQInputTypeEnum.Error:
                case CSSPWQInputTypeEnum.Subsector:
                case CSSPWQInputTypeEnum.Municipality:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.CSSPWQInputType);
            }
        }
        public string DailyOrHourlyDataOK(DailyOrHourlyDataEnum? dailyOrHourlyData)
        {
            if (dailyOrHourlyData == null)
                return "";

            switch ((DailyOrHourlyDataEnum)dailyOrHourlyData)
            {
                case DailyOrHourlyDataEnum.Error:
                case DailyOrHourlyDataEnum.Daily:
                case DailyOrHourlyDataEnum.Hourly:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.DailyOrHourlyData);
            }
        }
        public string DatabaseTypeOK(DatabaseTypeEnum? databaseType)
        {
            if (databaseType == null)
                return "";

            switch ((DatabaseTypeEnum)databaseType)
            {
                case DatabaseTypeEnum.Error:
                case DatabaseTypeEnum.MemoryCSSPWebToolsDB:
                case DatabaseTypeEnum.MemoryTestDB:
                case DatabaseTypeEnum.SqlServerCSSPWebToolsDB:
                case DatabaseTypeEnum.SqlServerTestDB:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.DatabaseType);
            }
        }
        public string DisinfectionTypeOK(DisinfectionTypeEnum? disinfectionType)
        {
            if (disinfectionType == null)
                return "";

            switch ((DisinfectionTypeEnum)disinfectionType)
            {
                case DisinfectionTypeEnum.Error:
                case DisinfectionTypeEnum.None:
                case DisinfectionTypeEnum.UV:
                case DisinfectionTypeEnum.ChlorinationNoDechlorination:
                case DisinfectionTypeEnum.ChlorinationWithDechlorination:
                case DisinfectionTypeEnum.UVSeasonal:
                case DisinfectionTypeEnum.ChlorinationNoDechlorinationSeasonal:
                case DisinfectionTypeEnum.ChlorinationWithDechlorinationSeasonal:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.DisinfectionType);
            }
        }
        public string EmailTypeOK(EmailTypeEnum? emailType)
        {
            if (emailType == null)
                return "";

            switch ((EmailTypeEnum)emailType)
            {
                case EmailTypeEnum.Error:
                case EmailTypeEnum.Personal:
                case EmailTypeEnum.Work:
                case EmailTypeEnum.Personal2:
                case EmailTypeEnum.Work2:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.EmailType);
            }
        }
        public string FacilityTypeOK(FacilityTypeEnum? facilityType)
        {
            if (facilityType == null)
                return "";

            switch ((FacilityTypeEnum)facilityType)
            {
                case FacilityTypeEnum.Error:
                case FacilityTypeEnum.Lagoon:
                case FacilityTypeEnum.Plant:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.FacilityType);
            }
        }
        public string FilePurposeOK(FilePurposeEnum? filePurpose)
        {
            if (filePurpose == null)
                return "";

            switch ((FilePurposeEnum)filePurpose)
            {
                case FilePurposeEnum.Error:
                case FilePurposeEnum.MikeInput:
                case FilePurposeEnum.MikeInputMDF:
                case FilePurposeEnum.MikeResultDFSU:
                case FilePurposeEnum.MikeResultKMZ:
                case FilePurposeEnum.Information:
                case FilePurposeEnum.Image:
                case FilePurposeEnum.Picture:
                case FilePurposeEnum.Reported:
                case FilePurposeEnum.Generated:
                case FilePurposeEnum.GeneratedFCForm:
                case FilePurposeEnum.Template:
                case FilePurposeEnum.Map:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.FilePurpose);
            }
        }
        public string FileStatusOK(FileStatusEnum? fileStatus)
        {
            if (fileStatus == null)
                return "";

            switch ((FileStatusEnum)fileStatus)
            {
                case FileStatusEnum.Error:
                case FileStatusEnum.Changed:
                case FileStatusEnum.Sent:
                case FileStatusEnum.Accepted:
                case FileStatusEnum.Rejected:
                case FileStatusEnum.Fail:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.FileStatus);
            }
        }
        public string FileTypeOK(FileTypeEnum? fileType)
        {
            if (fileType == null)
                return "";

            switch ((FileTypeEnum)fileType)
            {
                case FileTypeEnum.Error:
                case FileTypeEnum.DFS0:
                case FileTypeEnum.DFS1:
                case FileTypeEnum.DFSU:
                case FileTypeEnum.KMZ:
                case FileTypeEnum.LOG:
                case FileTypeEnum.M21FM:
                case FileTypeEnum.M3FM:
                case FileTypeEnum.MDF:
                case FileTypeEnum.MESH:
                case FileTypeEnum.XLSX:
                case FileTypeEnum.DOCX:
                case FileTypeEnum.PDF:
                case FileTypeEnum.JPG:
                case FileTypeEnum.JPEG:
                case FileTypeEnum.GIF:
                case FileTypeEnum.PNG:
                case FileTypeEnum.HTML:
                case FileTypeEnum.TXT:
                case FileTypeEnum.XYZ:
                case FileTypeEnum.KML:
                case FileTypeEnum.CSV:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.FileType);
            }
        }
        public string InfrastructureTypeOK(InfrastructureTypeEnum? infrastructureType)
        {
            if (infrastructureType == null)
                return "";

            switch ((InfrastructureTypeEnum)infrastructureType)
            {
                case InfrastructureTypeEnum.Error:
                case InfrastructureTypeEnum.WWTP:
                case InfrastructureTypeEnum.LiftStation:
                case InfrastructureTypeEnum.Other:
                case InfrastructureTypeEnum.SeeOther:
                case InfrastructureTypeEnum.LineOverflow:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.InfrastructureType);
            }
        }
        public string KMZActionOK(KMZActionEnum? kMZAction)
        {
            if (kMZAction == null)
                return "";

            switch ((KMZActionEnum)kMZAction)
            {
                case KMZActionEnum.Error:
                case KMZActionEnum.DoNothing:
                case KMZActionEnum.GenerateKMZContourAnimation:
                case KMZActionEnum.GenerateKMZContourLimit:
                case KMZActionEnum.GenerateKMZCurrentAnimation:
                case KMZActionEnum.GenerateKMZCurrentMaximum:
                case KMZActionEnum.GenerateKMZMesh:
                case KMZActionEnum.GenerateKMZStudyArea:
                case KMZActionEnum.GenerateKMZBoundaryConditionNodes:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.KMZAction);
            }
        }
        public string LaboratoryOK(LaboratoryEnum? laboratory)
        {
            if (laboratory == null)
                return "";

            switch ((LaboratoryEnum)laboratory)
            {
                case LaboratoryEnum.Error:
                case LaboratoryEnum.ZZ_0:
                case LaboratoryEnum.ZZ_1:
                case LaboratoryEnum.ZZ_2:
                case LaboratoryEnum.ZZ_3:
                case LaboratoryEnum.ZZ_4:
                case LaboratoryEnum.ZZ_1Q:
                case LaboratoryEnum.ZZ_2Q:
                case LaboratoryEnum.ZZ_3Q:
                case LaboratoryEnum.ZZ_4Q:
                case LaboratoryEnum.ZZ_5Q:
                case LaboratoryEnum.ZZ_11BC:
                case LaboratoryEnum.ZZ_12BC:
                case LaboratoryEnum.ZZ_13BC:
                case LaboratoryEnum.ZZ_14BC:
                case LaboratoryEnum.ZZ_15BC:
                case LaboratoryEnum.ZZ_16BC:
                case LaboratoryEnum.ZZ_17BC:
                case LaboratoryEnum.ZZ_18BC:
                case LaboratoryEnum.MonctonEnvironmentCanada:
                case LaboratoryEnum.BIOEnvironmentCanada:
                case LaboratoryEnum.EasternCharlotteWaterwayLaboratory:
                case LaboratoryEnum.InstitutDeRechercheSurLesZonesCotieres:
                case LaboratoryEnum.CentreDeRechercheSurLesAliments:
                case LaboratoryEnum.CaraquetMobileLaboratoryEnvironmentCanada:
                case LaboratoryEnum.MaxxamAnalyticsBedford:
                case LaboratoryEnum.MaxxamAnalyticsSydney:
                case LaboratoryEnum.PEIAnalyticalLaboratory:
                case LaboratoryEnum.NLMobileLaboratory:
                case LaboratoryEnum.PetroformaInc:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.Laboratory);
            }
        }
        public string LabSheetStatusOK(LabSheetStatusEnum? labSheetStatus)
        {
            if (labSheetStatus == null)
                return "";

            switch ((LabSheetStatusEnum)labSheetStatus)
            {
                case LabSheetStatusEnum.Error:
                case LabSheetStatusEnum.Created:
                case LabSheetStatusEnum.Transferred:
                case LabSheetStatusEnum.Accepted:
                case LabSheetStatusEnum.Rejected:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.LabSheetStatus);
            }
        }
        public string LabSheetTypeOK(LabSheetTypeEnum? labSheetType)
        {
            if (labSheetType == null)
                return "";

            switch ((LabSheetTypeEnum)labSheetType)
            {
                case LabSheetTypeEnum.Error:
                case LabSheetTypeEnum.A1:
                case LabSheetTypeEnum.LTB:
                case LabSheetTypeEnum.EC:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.LabSheetType);
            }
        }
        public string LanguageOK(LanguageEnum? language)
        {
            if (language == null)
                return "";

            switch ((LanguageEnum)language)
            {
                case LanguageEnum.Error:
                case LanguageEnum.en:
                case LanguageEnum.fr:
                case LanguageEnum.enAndfr:
                case LanguageEnum.es:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.Language);
            }
        }
        public string LogCommandOK(LogCommandEnum? logCommand)
        {
            if (logCommand == null)
                return "";

            switch ((LogCommandEnum)logCommand)
            {
                case LogCommandEnum.Error:
                case LogCommandEnum.Add:
                case LogCommandEnum.Change:
                case LogCommandEnum.Delete:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.LogCommand);
            }
        }
        public string MapInfoDrawTypeOK(MapInfoDrawTypeEnum? mapInfoDrawType)
        {
            if (mapInfoDrawType == null)
                return "";

            switch ((MapInfoDrawTypeEnum)mapInfoDrawType)
            {
                case MapInfoDrawTypeEnum.Error:
                case MapInfoDrawTypeEnum.Point:
                case MapInfoDrawTypeEnum.Polyline:
                case MapInfoDrawTypeEnum.Polygon:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.MapInfoDrawType);
            }
        }
        public string MikeBoundaryConditionLevelOrVelocityOK(MikeBoundaryConditionLevelOrVelocityEnum? mikeBoundaryConditionLevelOrVelocity)
        {
            if (mikeBoundaryConditionLevelOrVelocity == null)
                return "";

            switch ((MikeBoundaryConditionLevelOrVelocityEnum)mikeBoundaryConditionLevelOrVelocity)
            {
                case MikeBoundaryConditionLevelOrVelocityEnum.Error:
                case MikeBoundaryConditionLevelOrVelocityEnum.Level:
                case MikeBoundaryConditionLevelOrVelocityEnum.Velocity:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.MikeBoundaryConditionLevelOrVelocity);
            }
        }
        public string MikeScenarioSpecialResultKMLTypeOK(MikeScenarioSpecialResultKMLTypeEnum? mikeScenarioSpecialResultKMLType)
        {
            if (mikeScenarioSpecialResultKMLType == null)
                return "";

            switch ((MikeScenarioSpecialResultKMLTypeEnum)mikeScenarioSpecialResultKMLType)
            {
                case MikeScenarioSpecialResultKMLTypeEnum.Error:
                case MikeScenarioSpecialResultKMLTypeEnum.Mesh:
                case MikeScenarioSpecialResultKMLTypeEnum.StudyArea:
                case MikeScenarioSpecialResultKMLTypeEnum.BoundaryConditions:
                case MikeScenarioSpecialResultKMLTypeEnum.PollutionLimit:
                case MikeScenarioSpecialResultKMLTypeEnum.PollutionAnimation:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.MikeScenarioSpecialResultKMLType);
            }
        }
        public string MWQMSiteLatestClassificationOK(MWQMSiteLatestClassificationEnum? mWQMSiteLatestClassification)
        {
            if (mWQMSiteLatestClassification == null)
                return "";

            switch ((MWQMSiteLatestClassificationEnum)mWQMSiteLatestClassification)
            {
                case MWQMSiteLatestClassificationEnum.Error:
                case MWQMSiteLatestClassificationEnum.Approved:
                case MWQMSiteLatestClassificationEnum.ConditionallyApproved:
                case MWQMSiteLatestClassificationEnum.Restricted:
                case MWQMSiteLatestClassificationEnum.ConditionallyRestricted:
                case MWQMSiteLatestClassificationEnum.Prohibited:
                case MWQMSiteLatestClassificationEnum.Unclassified:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.MWQMSiteLatestClassification);
            }
        }
        public string PolSourceInactiveReasonOK(PolSourceInactiveReasonEnum? polSourceInactiveReason)
        {
            if (polSourceInactiveReason == null)
                return "";

            switch ((PolSourceInactiveReasonEnum)polSourceInactiveReason)
            {
                case PolSourceInactiveReasonEnum.Error:
                case PolSourceInactiveReasonEnum.Abandoned:
                case PolSourceInactiveReasonEnum.Closed:
                case PolSourceInactiveReasonEnum.Removed:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.PolSourceInactiveReason);
            }
        }
        public string PolSourceIssueRiskOK(PolSourceIssueRiskEnum? polSourceIssueRisk)
        {
            if (polSourceIssueRisk == null)
                return "";

            switch ((PolSourceIssueRiskEnum)polSourceIssueRisk)
            {
                case PolSourceIssueRiskEnum.Error:
                case PolSourceIssueRiskEnum.LowRisk:
                case PolSourceIssueRiskEnum.ModerateRisk:
                case PolSourceIssueRiskEnum.HighRisk:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.PolSourceIssueRisk);
            }
        }
        public string PreliminaryTreatmentTypeOK(PreliminaryTreatmentTypeEnum? preliminaryTreatmentType)
        {
            if (preliminaryTreatmentType == null)
                return "";

            switch ((PreliminaryTreatmentTypeEnum)preliminaryTreatmentType)
            {
                case PreliminaryTreatmentTypeEnum.Error:
                case PreliminaryTreatmentTypeEnum.NotApplicable:
                case PreliminaryTreatmentTypeEnum.BarScreen:
                case PreliminaryTreatmentTypeEnum.Grinder:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.PreliminaryTreatmentType);
            }
        }
        public string PrimaryTreatmentTypeOK(PrimaryTreatmentTypeEnum? primaryTreatmentType)
        {
            if (primaryTreatmentType == null)
                return "";

            switch ((PrimaryTreatmentTypeEnum)primaryTreatmentType)
            {
                case PrimaryTreatmentTypeEnum.Error:
                case PrimaryTreatmentTypeEnum.NotApplicable:
                case PrimaryTreatmentTypeEnum.Sedimentation:
                case PrimaryTreatmentTypeEnum.ChemicalCoagulation:
                case PrimaryTreatmentTypeEnum.Filtration:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.PrimaryTreatmentType);
            }
        }
        public string ReportConditionOK(ReportConditionEnum? reportCondition)
        {
            if (reportCondition == null)
                return "";

            switch ((ReportConditionEnum)reportCondition)
            {
                case ReportConditionEnum.Error:
                case ReportConditionEnum.ReportConditionTrue:
                case ReportConditionEnum.ReportConditionFalse:
                case ReportConditionEnum.ReportConditionContain:
                case ReportConditionEnum.ReportConditionStart:
                case ReportConditionEnum.ReportConditionEnd:
                case ReportConditionEnum.ReportConditionBigger:
                case ReportConditionEnum.ReportConditionSmaller:
                case ReportConditionEnum.ReportConditionEqual:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportCondition);
            }
        }
        public string ReportFieldTypeOK(ReportFieldTypeEnum? reportFieldType)
        {
            if (reportFieldType == null)
                return "";

            switch ((ReportFieldTypeEnum)reportFieldType)
            {
                case ReportFieldTypeEnum.Error:
                case ReportFieldTypeEnum.NumberWhole:
                case ReportFieldTypeEnum.NumberWithDecimal:
                case ReportFieldTypeEnum.DateAndTime:
                case ReportFieldTypeEnum.Text:
                case ReportFieldTypeEnum.TrueOrFalse:
                case ReportFieldTypeEnum.FilePurpose:
                case ReportFieldTypeEnum.FileType:
                case ReportFieldTypeEnum.TranslationStatus:
                case ReportFieldTypeEnum.BoxModelResultType:
                case ReportFieldTypeEnum.InfrastructureType:
                case ReportFieldTypeEnum.FacilityType:
                case ReportFieldTypeEnum.AerationType:
                case ReportFieldTypeEnum.PreliminaryTreatmentType:
                case ReportFieldTypeEnum.PrimaryTreatmentType:
                case ReportFieldTypeEnum.SecondaryTreatmentType:
                case ReportFieldTypeEnum.TertiaryTreatmentType:
                case ReportFieldTypeEnum.TreatmentType:
                case ReportFieldTypeEnum.DisinfectionType:
                case ReportFieldTypeEnum.CollectionSystemType:
                case ReportFieldTypeEnum.AlarmSystemType:
                case ReportFieldTypeEnum.ScenarioStatus:
                case ReportFieldTypeEnum.StorageDataType:
                case ReportFieldTypeEnum.Language:
                case ReportFieldTypeEnum.SampleType:
                case ReportFieldTypeEnum.BeaufortScale:
                case ReportFieldTypeEnum.AnalyzeMethod:
                case ReportFieldTypeEnum.SampleMatrix:
                case ReportFieldTypeEnum.Laboratory:
                case ReportFieldTypeEnum.SampleStatus:
                case ReportFieldTypeEnum.SamplingPlanType:
                case ReportFieldTypeEnum.LabSheetSampleType:
                case ReportFieldTypeEnum.LabSheetType:
                case ReportFieldTypeEnum.LabSheetStatus:
                case ReportFieldTypeEnum.PolSourceInactiveReason:
                case ReportFieldTypeEnum.PolSourceObsInfo:
                case ReportFieldTypeEnum.AddressType:
                case ReportFieldTypeEnum.StreetType:
                case ReportFieldTypeEnum.ContactTitle:
                case ReportFieldTypeEnum.EmailType:
                case ReportFieldTypeEnum.TelType:
                case ReportFieldTypeEnum.TideText:
                case ReportFieldTypeEnum.TideDataType:
                case ReportFieldTypeEnum.SpecialTableType:
                case ReportFieldTypeEnum.MWQMSiteLatestClassification:
                case ReportFieldTypeEnum.PolSourceIssueRisk:
                case ReportFieldTypeEnum.MikeScenarioSpecialResultKMLType:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportFieldType);
            }
        }
        public string ReportFileTypeOK(ReportFileTypeEnum? reportFileType)
        {
            if (reportFileType == null)
                return "";

            switch ((ReportFileTypeEnum)reportFileType)
            {
                case ReportFileTypeEnum.Error:
                case ReportFileTypeEnum.CSV:
                case ReportFileTypeEnum.Word:
                case ReportFileTypeEnum.Excel:
                case ReportFileTypeEnum.KML:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportFileType);
            }
        }
        public string ReportFormatingDateOK(ReportFormatingDateEnum? reportFormatingDate)
        {
            if (reportFormatingDate == null)
                return "";

            switch ((ReportFormatingDateEnum)reportFormatingDate)
            {
                case ReportFormatingDateEnum.Error:
                case ReportFormatingDateEnum.ReportFormatingDateYearOnly:
                case ReportFormatingDateEnum.ReportFormatingDateMonthDecimalOnly:
                case ReportFormatingDateEnum.ReportFormatingDateMonthShortTextOnly:
                case ReportFormatingDateEnum.ReportFormatingDateMonthFullTextOnly:
                case ReportFormatingDateEnum.ReportFormatingDateDayOnly:
                case ReportFormatingDateEnum.ReportFormatingDateHourOnly:
                case ReportFormatingDateEnum.ReportFormatingDateMinuteOnly:
                case ReportFormatingDateEnum.ReportFormatingDateYearMonthDecimalDay:
                case ReportFormatingDateEnum.ReportFormatingDateYearMonthShortTextDay:
                case ReportFormatingDateEnum.ReportFormatingDateYearMonthFullTextDay:
                case ReportFormatingDateEnum.ReportFormatingDateYearMonthDecimalDayHourMinute:
                case ReportFormatingDateEnum.ReportFormatingDateYearMonthShortTextDayHourMinute:
                case ReportFormatingDateEnum.ReportFormatingDateYearMonthFullTextDayHourMinute:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportFormatingDate);
            }
        }
        public string ReportFormatingNumberOK(ReportFormatingNumberEnum? reportFormatingNumber)
        {
            if (reportFormatingNumber == null)
                return "";

            switch ((ReportFormatingNumberEnum)reportFormatingNumber)
            {
                case ReportFormatingNumberEnum.Error:
                case ReportFormatingNumberEnum.ReportFormatingNumber0Decimal:
                case ReportFormatingNumberEnum.ReportFormatingNumber1Decimal:
                case ReportFormatingNumberEnum.ReportFormatingNumber2Decimal:
                case ReportFormatingNumberEnum.ReportFormatingNumber3Decimal:
                case ReportFormatingNumberEnum.ReportFormatingNumber4Decimal:
                case ReportFormatingNumberEnum.ReportFormatingNumber5Decimal:
                case ReportFormatingNumberEnum.ReportFormatingNumber6Decimal:
                case ReportFormatingNumberEnum.ReportFormatingNumberScientific0Decimal:
                case ReportFormatingNumberEnum.ReportFormatingNumberScientific1Decimal:
                case ReportFormatingNumberEnum.ReportFormatingNumberScientific2Decimal:
                case ReportFormatingNumberEnum.ReportFormatingNumberScientific3Decimal:
                case ReportFormatingNumberEnum.ReportFormatingNumberScientific4Decimal:
                case ReportFormatingNumberEnum.ReportFormatingNumberScientific5Decimal:
                case ReportFormatingNumberEnum.ReportFormatingNumberScientific6Decimal:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportFormatingNumber);
            }
        }
        public string ReportSortingOK(ReportSortingEnum? reportSorting)
        {
            if (reportSorting == null)
                return "";

            switch ((ReportSortingEnum)reportSorting)
            {
                case ReportSortingEnum.Error:
                case ReportSortingEnum.ReportSortingAscending:
                case ReportSortingEnum.ReportSortingDescending:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportSorting);
            }
        }
        public string ReportTreeNodeSubTypeOK(ReportTreeNodeSubTypeEnum? reportTreeNodeSubType)
        {
            if (reportTreeNodeSubType == null)
                return "";

            switch ((ReportTreeNodeSubTypeEnum)reportTreeNodeSubType)
            {
                case ReportTreeNodeSubTypeEnum.Error:
                case ReportTreeNodeSubTypeEnum.TableSelectable:
                case ReportTreeNodeSubTypeEnum.Field:
                case ReportTreeNodeSubTypeEnum.FieldsHolder:
                case ReportTreeNodeSubTypeEnum.TableNotSelectable:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportTreeNodeSubType);
            }
        }
        public string ReportTreeNodeTypeOK(ReportTreeNodeTypeEnum? reportTreeNodeType)
        {
            if (reportTreeNodeType == null)
                return "";

            switch ((ReportTreeNodeTypeEnum)reportTreeNodeType)
            {
                case ReportTreeNodeTypeEnum.Error:
                case ReportTreeNodeTypeEnum.ReportRootType:
                case ReportTreeNodeTypeEnum.ReportCountryType:
                case ReportTreeNodeTypeEnum.ReportProvinceType:
                case ReportTreeNodeTypeEnum.ReportAreaType:
                case ReportTreeNodeTypeEnum.ReportSectorType:
                case ReportTreeNodeTypeEnum.ReportSubsectorType:
                case ReportTreeNodeTypeEnum.ReportMWQMSiteType:
                case ReportTreeNodeTypeEnum.ReportMWQMRunType:
                case ReportTreeNodeTypeEnum.ReportPolSourceSiteType:
                case ReportTreeNodeTypeEnum.ReportMunicipalityType:
                case ReportTreeNodeTypeEnum.ReportRootFileType:
                case ReportTreeNodeTypeEnum.ReportInfrastructureType:
                case ReportTreeNodeTypeEnum.ReportBoxModelType:
                case ReportTreeNodeTypeEnum.ReportVisualPlumesScenarioType:
                case ReportTreeNodeTypeEnum.ReportMikeScenarioType:
                case ReportTreeNodeTypeEnum.ReportMikeSourceType:
                case ReportTreeNodeTypeEnum.ReportMWQMSiteSampleType:
                case ReportTreeNodeTypeEnum.ReportPolSourceSiteObsType:
                case ReportTreeNodeTypeEnum.ReportPolSourceSiteObsIssueType:
                case ReportTreeNodeTypeEnum.ReportMikeScenarioGeneralParameterType:
                case ReportTreeNodeTypeEnum.ReportMunicipalityContactType:
                case ReportTreeNodeTypeEnum.ReportConditionType:
                case ReportTreeNodeTypeEnum.ReportStatisticType:
                case ReportTreeNodeTypeEnum.ReportFieldsType:
                case ReportTreeNodeTypeEnum.ReportFieldType:
                case ReportTreeNodeTypeEnum.ReportPolSourceSiteAddressType:
                case ReportTreeNodeTypeEnum.ReportMunicipalityContactTelType:
                case ReportTreeNodeTypeEnum.ReportMunicipalityContactEmailType:
                case ReportTreeNodeTypeEnum.ReportBoxModelResultType:
                case ReportTreeNodeTypeEnum.ReportClimateSiteType:
                case ReportTreeNodeTypeEnum.ReportClimateSiteDataType:
                case ReportTreeNodeTypeEnum.ReportHydrometricSiteType:
                case ReportTreeNodeTypeEnum.ReportHydrometricSiteDataType:
                case ReportTreeNodeTypeEnum.ReportHydrometricSiteRatingCurveType:
                case ReportTreeNodeTypeEnum.ReportHydrometricSiteRatingCurveValueType:
                case ReportTreeNodeTypeEnum.ReportInfrastructureAddressType:
                case ReportTreeNodeTypeEnum.ReportSubsectorLabSheetType:
                case ReportTreeNodeTypeEnum.ReportSubsectorLabSheetDetailType:
                case ReportTreeNodeTypeEnum.ReportSubsectorLabSheetTubeMPNDetailType:
                case ReportTreeNodeTypeEnum.ReportMWQMRunSampleType:
                case ReportTreeNodeTypeEnum.ReportCountryFileType:
                case ReportTreeNodeTypeEnum.ReportProvinceFileType:
                case ReportTreeNodeTypeEnum.ReportAreaFileType:
                case ReportTreeNodeTypeEnum.ReportSectorFileType:
                case ReportTreeNodeTypeEnum.ReportSubsectorFileType:
                case ReportTreeNodeTypeEnum.ReportMWQMSiteFileType:
                case ReportTreeNodeTypeEnum.ReportMWQMRunFileType:
                case ReportTreeNodeTypeEnum.ReportPolSourceSiteFileType:
                case ReportTreeNodeTypeEnum.ReportMunicipalityFileType:
                case ReportTreeNodeTypeEnum.ReportInfrastructureFileType:
                case ReportTreeNodeTypeEnum.ReportMikeScenarioFileType:
                case ReportTreeNodeTypeEnum.ReportMikeSourceStartEndType:
                case ReportTreeNodeTypeEnum.ReportMWQMRunLabSheetType:
                case ReportTreeNodeTypeEnum.ReportMWQMRunLabSheetDetailType:
                case ReportTreeNodeTypeEnum.ReportMWQMRunLabSheetTubeMPNDetailType:
                case ReportTreeNodeTypeEnum.ReportSamplingPlanLabSheetType:
                case ReportTreeNodeTypeEnum.ReportSamplingPlanLabSheetDetailType:
                case ReportTreeNodeTypeEnum.ReportSamplingPlanLabSheetTubeMPNDetailType:
                case ReportTreeNodeTypeEnum.ReportSamplingPlanType:
                case ReportTreeNodeTypeEnum.ReportSamplingPlanSubsectorType:
                case ReportTreeNodeTypeEnum.ReportSamplingPlanSubsectorSiteType:
                case ReportTreeNodeTypeEnum.ReportMikeBoundaryConditionType:
                case ReportTreeNodeTypeEnum.ReportVisualPlumesScenarioAmbientType:
                case ReportTreeNodeTypeEnum.ReportVisualPlumesScenarioResultType:
                case ReportTreeNodeTypeEnum.ReportMPNLookupType:
                case ReportTreeNodeTypeEnum.ReportMWQMSiteStartAndEndType:
                case ReportTreeNodeTypeEnum.ReportSubsectorTideSiteType:
                case ReportTreeNodeTypeEnum.ReportSubsectorTideSiteDataType:
                case ReportTreeNodeTypeEnum.ReportOrderType:
                case ReportTreeNodeTypeEnum.ReportFormatType:
                case ReportTreeNodeTypeEnum.ReportMunicipalityContactAddressType:
                case ReportTreeNodeTypeEnum.ReportSubsectorClimateSiteType:
                case ReportTreeNodeTypeEnum.ReportSubsectorHydrometricSiteType:
                case ReportTreeNodeTypeEnum.ReportSubsectorHydrometricSiteDataType:
                case ReportTreeNodeTypeEnum.ReportSubsectorHydrometricSiteRatingCurveType:
                case ReportTreeNodeTypeEnum.ReportSubsectorClimateSiteDataType:
                case ReportTreeNodeTypeEnum.ReportSubsectorHydrometricSiteRatingCurveValueType:
                case ReportTreeNodeTypeEnum.ReportSubsectorSpecialTableType:
                case ReportTreeNodeTypeEnum.ReportMikeScenarioSpecialResultKMLType:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportTreeNodeType);
            }
        }
        public string SameDayNextDayOK(SameDayNextDayEnum? sameDayNextDay)
        {
            if (sameDayNextDay == null)
                return "";

            switch ((SameDayNextDayEnum)sameDayNextDay)
            {
                case SameDayNextDayEnum.Error:
                case SameDayNextDayEnum.SameDay:
                case SameDayNextDayEnum.NextDay:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SameDayNextDay);
            }
        }
        public string SampleMatrixOK(SampleMatrixEnum? sampleMatrix)
        {
            if (sampleMatrix == null)
                return "";

            switch ((SampleMatrixEnum)sampleMatrix)
            {
                case SampleMatrixEnum.Error:
                case SampleMatrixEnum.W:
                case SampleMatrixEnum.S:
                case SampleMatrixEnum.B:
                case SampleMatrixEnum.MPNQ:
                case SampleMatrixEnum.SampleMatrix5:
                case SampleMatrixEnum.SampleMatrix6:
                case SampleMatrixEnum.Water:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SampleMatrix);
            }
        }
        public string SampleStatusOK(SampleStatusEnum? sampleStatus)
        {
            if (sampleStatus == null)
                return "";

            switch ((SampleStatusEnum)sampleStatus)
            {
                case SampleStatusEnum.Error:
                case SampleStatusEnum.Active:
                case SampleStatusEnum.Archived:
                case SampleStatusEnum.SampleStatus3:
                case SampleStatusEnum.SampleStatus4:
                case SampleStatusEnum.SampleStatus5:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SampleStatus);
            }
        }
        public string SampleTypeOK(SampleTypeEnum? sampleType)
        {
            if (sampleType == null)
                return "";

            switch ((SampleTypeEnum)sampleType)
            {
                case SampleTypeEnum.Error:
                case SampleTypeEnum.DailyDuplicate:
                case SampleTypeEnum.Infrastructure:
                case SampleTypeEnum.IntertechDuplicate:
                case SampleTypeEnum.IntertechRead:
                case SampleTypeEnum.RainCMPRoutine:
                case SampleTypeEnum.RainRun:
                case SampleTypeEnum.ReopeningEmergencyRain:
                case SampleTypeEnum.ReopeningSpill:
                case SampleTypeEnum.Routine:
                case SampleTypeEnum.Sanitary:
                case SampleTypeEnum.Study:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SampleType);
            }
        }
        public string SamplingPlanTypeOK(SamplingPlanTypeEnum? samplingPlanType)
        {
            if (samplingPlanType == null)
                return "";

            switch ((SamplingPlanTypeEnum)samplingPlanType)
            {
                case SamplingPlanTypeEnum.Error:
                case SamplingPlanTypeEnum.Subsector:
                case SamplingPlanTypeEnum.Municipality:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SamplingPlanType);
            }
        }
        public string ScenarioStatusOK(ScenarioStatusEnum? scenarioStatus)
        {
            if (scenarioStatus == null)
                return "";

            switch ((ScenarioStatusEnum)scenarioStatus)
            {
                case ScenarioStatusEnum.Error:
                case ScenarioStatusEnum.Normal:
                case ScenarioStatusEnum.Copying:
                case ScenarioStatusEnum.Copied:
                case ScenarioStatusEnum.Changing:
                case ScenarioStatusEnum.Changed:
                case ScenarioStatusEnum.AskToRun:
                case ScenarioStatusEnum.Running:
                case ScenarioStatusEnum.Completed:
                case ScenarioStatusEnum.Cancelled:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ScenarioStatus);
            }
        }
        public string SearchTagOK(SearchTagEnum? searchTag)
        {
            if (searchTag == null)
                return "";

            switch ((SearchTagEnum)searchTag)
            {
                case SearchTagEnum.Error:
                case SearchTagEnum.c:
                case SearchTagEnum.e:
                case SearchTagEnum.t:
                case SearchTagEnum.fi:
                case SearchTagEnum.fp:
                case SearchTagEnum.fr:
                case SearchTagEnum.fg:
                case SearchTagEnum.fpdf:
                case SearchTagEnum.fdocx:
                case SearchTagEnum.fxlsx:
                case SearchTagEnum.fkmz:
                case SearchTagEnum.fxyz:
                case SearchTagEnum.fdfs:
                case SearchTagEnum.fmike:
                case SearchTagEnum.fmdf:
                case SearchTagEnum.fm21fm:
                case SearchTagEnum.fm3fm:
                case SearchTagEnum.fmesh:
                case SearchTagEnum.flog:
                case SearchTagEnum.ftxt:
                case SearchTagEnum.m:
                case SearchTagEnum.p:
                case SearchTagEnum.ms:
                case SearchTagEnum.cs:
                case SearchTagEnum.hs:
                case SearchTagEnum.ts:
                case SearchTagEnum.ww:
                case SearchTagEnum.ls:
                case SearchTagEnum.st:
                case SearchTagEnum.ps:
                case SearchTagEnum.a:
                case SearchTagEnum.s:
                case SearchTagEnum.ss:
                case SearchTagEnum.u:
                case SearchTagEnum.notag:
                case SearchTagEnum.fcsv:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SearchTag);
            }
        }
        public string SecondaryTreatmentTypeOK(SecondaryTreatmentTypeEnum? secondaryTreatmentType)
        {
            if (secondaryTreatmentType == null)
                return "";

            switch ((SecondaryTreatmentTypeEnum)secondaryTreatmentType)
            {
                case SecondaryTreatmentTypeEnum.Error:
                case SecondaryTreatmentTypeEnum.NotApplicable:
                case SecondaryTreatmentTypeEnum.RotatingBiologicalContactor:
                case SecondaryTreatmentTypeEnum.TricklingFilters:
                case SecondaryTreatmentTypeEnum.SequencingBatchReator:
                case SecondaryTreatmentTypeEnum.OxidationDitch:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SecondaryTreatmentType);
            }
        }
        public string SiteTypeOK(SiteTypeEnum? siteType)
        {
            if (siteType == null)
                return "";

            switch ((SiteTypeEnum)siteType)
            {
                case SiteTypeEnum.Error:
                case SiteTypeEnum.Climate:
                case SiteTypeEnum.Hydrometric:
                case SiteTypeEnum.Tide:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SiteType);
            }
        }
        public string SpecialTableTypeOK(SpecialTableTypeEnum? specialTableType)
        {
            if (specialTableType == null)
                return "";

            switch ((SpecialTableTypeEnum)specialTableType)
            {
                case SpecialTableTypeEnum.Error:
                case SpecialTableTypeEnum.FCDensitiesTable:
                case SpecialTableTypeEnum.SalinityTable:
                case SpecialTableTypeEnum.TemperatureTable:
                case SpecialTableTypeEnum.GeometricMeanTable:
                case SpecialTableTypeEnum.MedianTable:
                case SpecialTableTypeEnum.P90Table:
                case SpecialTableTypeEnum.PercentOver43Table:
                case SpecialTableTypeEnum.PercentOver260Table:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SpecialTableType);
            }
        }
        public string StorageDataTypeOK(StorageDataTypeEnum? storageDataType)
        {
            if (storageDataType == null)
                return "";

            switch ((StorageDataTypeEnum)storageDataType)
            {
                case StorageDataTypeEnum.Error:
                case StorageDataTypeEnum.Archived:
                case StorageDataTypeEnum.Forcasted:
                case StorageDataTypeEnum.Observed:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.StorageDataType);
            }
        }
        public string StreetTypeOK(StreetTypeEnum? streetType)
        {
            if (streetType == null)
                return "";

            switch ((StreetTypeEnum)streetType)
            {
                case StreetTypeEnum.Error:
                case StreetTypeEnum.Street:
                case StreetTypeEnum.Road:
                case StreetTypeEnum.Avenue:
                case StreetTypeEnum.Crescent:
                case StreetTypeEnum.Court:
                case StreetTypeEnum.Alley:
                case StreetTypeEnum.Drive:
                case StreetTypeEnum.Blvd:
                case StreetTypeEnum.Route:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.StreetType);
            }
        }
        public string TelTypeOK(TelTypeEnum? telType)
        {
            if (telType == null)
                return "";

            switch ((TelTypeEnum)telType)
            {
                case TelTypeEnum.Error:
                case TelTypeEnum.Personal:
                case TelTypeEnum.Work:
                case TelTypeEnum.Mobile:
                case TelTypeEnum.Personal2:
                case TelTypeEnum.Work2:
                case TelTypeEnum.Mobile2:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TelType);
            }
        }
        public string TertiaryTreatmentTypeOK(TertiaryTreatmentTypeEnum? tertiaryTreatmentType)
        {
            if (tertiaryTreatmentType == null)
                return "";

            switch ((TertiaryTreatmentTypeEnum)tertiaryTreatmentType)
            {
                case TertiaryTreatmentTypeEnum.Error:
                case TertiaryTreatmentTypeEnum.NotApplicable:
                case TertiaryTreatmentTypeEnum.Adsorption:
                case TertiaryTreatmentTypeEnum.Flocculation:
                case TertiaryTreatmentTypeEnum.MembraneFiltration:
                case TertiaryTreatmentTypeEnum.IonExchange:
                case TertiaryTreatmentTypeEnum.ReverseOsmosis:
                case TertiaryTreatmentTypeEnum.BiologicalNutrientRemoval:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TertiaryTreatmentType);
            }
        }
        public string TideDataTypeOK(TideDataTypeEnum? tideDataType)
        {
            if (tideDataType == null)
                return "";

            switch ((TideDataTypeEnum)tideDataType)
            {
                case TideDataTypeEnum.Error:
                case TideDataTypeEnum.Min15:
                case TideDataTypeEnum.Min60:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TideDataType);
            }
        }
        public string TideTextOK(TideTextEnum? tideText)
        {
            if (tideText == null)
                return "";

            switch ((TideTextEnum)tideText)
            {
                case TideTextEnum.Error:
                case TideTextEnum.LowTide:
                case TideTextEnum.LowTideFalling:
                case TideTextEnum.LowTideRising:
                case TideTextEnum.MidTide:
                case TideTextEnum.MidTideFalling:
                case TideTextEnum.MidTideRising:
                case TideTextEnum.HighTide:
                case TideTextEnum.HighTideFalling:
                case TideTextEnum.HighTideRising:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TideText);
            }
        }
        public string TranslationStatusOK(TranslationStatusEnum? translationStatus)
        {
            if (translationStatus == null)
                return "";

            switch ((TranslationStatusEnum)translationStatus)
            {
                case TranslationStatusEnum.Error:
                case TranslationStatusEnum.NotTranslated:
                case TranslationStatusEnum.ElectronicallyTranslated:
                case TranslationStatusEnum.Translated:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TranslationStatus);
            }
        }
        public string TreatmentTypeOK(TreatmentTypeEnum? treatmentType)
        {
            if (treatmentType == null)
                return "";

            switch ((TreatmentTypeEnum)treatmentType)
            {
                case TreatmentTypeEnum.Error:
                case TreatmentTypeEnum.ActivatedSludge:
                case TreatmentTypeEnum.ActivatedSludgeWithBiofilter:
                case TreatmentTypeEnum.LagoonNoAeration1Cell:
                case TreatmentTypeEnum.LagoonNoAeration2Cell:
                case TreatmentTypeEnum.LagoonNoAeration3Cell:
                case TreatmentTypeEnum.LagoonNoAeration4Cell:
                case TreatmentTypeEnum.LagoonNoAeration5Cell:
                case TreatmentTypeEnum.LagoonWithAeration1Cell:
                case TreatmentTypeEnum.LagoonWithAeration2Cell:
                case TreatmentTypeEnum.LagoonWithAeration3Cell:
                case TreatmentTypeEnum.LagoonWithAeration4Cell:
                case TreatmentTypeEnum.LagoonWithAeration5Cell:
                case TreatmentTypeEnum.LagoonWithAeration6Cell:
                case TreatmentTypeEnum.StabalizingPondOnly:
                case TreatmentTypeEnum.OxidationDitchOnly:
                case TreatmentTypeEnum.CirculatingFluidizedBed:
                case TreatmentTypeEnum.TricklingFilter:
                case TreatmentTypeEnum.RecirculatingSandFilter:
                case TreatmentTypeEnum.TrashRackRakeOnly:
                case TreatmentTypeEnum.SepticTank:
                case TreatmentTypeEnum.Secondary:
                case TreatmentTypeEnum.Tertiary:
                case TreatmentTypeEnum.VolumeFermenter:
                case TreatmentTypeEnum.BioFilmReactor:
                case TreatmentTypeEnum.BioGreen:
                case TreatmentTypeEnum.BioDisks:
                case TreatmentTypeEnum.ChemicalPrimary:
                case TreatmentTypeEnum.Chromoglass:
                case TreatmentTypeEnum.Primary:
                case TreatmentTypeEnum.SequencingBatchReactor:
                case TreatmentTypeEnum.PeatSystem:
                case TreatmentTypeEnum.Physicochimique:
                case TreatmentTypeEnum.RotatingBiologicalContactor:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TreatmentType);
            }
        }
        public string TVAuthOK(TVAuthEnum? tVAuth)
        {
            if (tVAuth == null)
                return "";

            switch ((TVAuthEnum)tVAuth)
            {
                case TVAuthEnum.Error:
                case TVAuthEnum.NoAccess:
                case TVAuthEnum.Read:
                case TVAuthEnum.Write:
                case TVAuthEnum.Create:
                case TVAuthEnum.Delete:
                case TVAuthEnum.Admin:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TVAuth);
            }
        }
        public string TVTypeOK(TVTypeEnum? tVType)
        {
            if (tVType == null)
                return "";

            switch ((TVTypeEnum)tVType)
            {
                case TVTypeEnum.Error:
                case TVTypeEnum.Root:
                case TVTypeEnum.Address:
                case TVTypeEnum.Area:
                case TVTypeEnum.ClimateSite:
                case TVTypeEnum.Contact:
                case TVTypeEnum.Country:
                case TVTypeEnum.Email:
                case TVTypeEnum.File:
                case TVTypeEnum.HydrometricSite:
                case TVTypeEnum.Infrastructure:
                case TVTypeEnum.MikeBoundaryConditionWebTide:
                case TVTypeEnum.MikeBoundaryConditionMesh:
                case TVTypeEnum.MikeScenario:
                case TVTypeEnum.MikeSource:
                case TVTypeEnum.Municipality:
                case TVTypeEnum.MWQMSite:
                case TVTypeEnum.PolSourceSite:
                case TVTypeEnum.Province:
                case TVTypeEnum.Sector:
                case TVTypeEnum.Subsector:
                case TVTypeEnum.Tel:
                case TVTypeEnum.TideSite:
                case TVTypeEnum.MWQMSiteSample:
                case TVTypeEnum.WasteWaterTreatmentPlant:
                case TVTypeEnum.LiftStation:
                case TVTypeEnum.Spill:
                case TVTypeEnum.BoxModel:
                case TVTypeEnum.VisualPlumesScenario:
                case TVTypeEnum.Outfall:
                case TVTypeEnum.OtherInfrastructure:
                case TVTypeEnum.MWQMRun:
                case TVTypeEnum.NoDepuration:
                case TVTypeEnum.Failed:
                case TVTypeEnum.Passed:
                case TVTypeEnum.NoData:
                case TVTypeEnum.LessThan10:
                case TVTypeEnum.MeshNode:
                case TVTypeEnum.WebTideNode:
                case TVTypeEnum.SamplingPlan:
                case TVTypeEnum.SeeOther:
                case TVTypeEnum.LineOverflow:
                case TVTypeEnum.BoxModelInputs:
                case TVTypeEnum.BoxModelResults:
                case TVTypeEnum.ClimateSiteInfo:
                case TVTypeEnum.ClimateSiteData:
                case TVTypeEnum.HydrometricSiteInfo:
                case TVTypeEnum.HydrometricSiteData:
                case TVTypeEnum.InfrastructureInfo:
                case TVTypeEnum.LabSheetInfo:
                case TVTypeEnum.LabSheetDetailInfo:
                case TVTypeEnum.MapInfo:
                case TVTypeEnum.MapInfoPoint:
                case TVTypeEnum.MikeSourceStartEndInfo:
                case TVTypeEnum.MWQMLookupMPNInfo:
                case TVTypeEnum.SamplingPlanInfo:
                case TVTypeEnum.SamplingPlanSubsectorInfo:
                case TVTypeEnum.SamplingPlanSubsectorSiteInfo:
                case TVTypeEnum.MWQMSiteStartEndInfo:
                case TVTypeEnum.MWQMSubsectorInfo:
                case TVTypeEnum.PolSourceSiteInfo:
                case TVTypeEnum.PolSourceSiteObsInfo:
                case TVTypeEnum.HydrometricRatingCurveInfo:
                case TVTypeEnum.HydrometricRatingCurveDataInfo:
                case TVTypeEnum.TideLocationInfo:
                case TVTypeEnum.TideSiteDataInfo:
                case TVTypeEnum.UseOfSite:
                case TVTypeEnum.VisualPlumesScenarioInfo:
                case TVTypeEnum.VisualPlumesScenarioAmbient:
                case TVTypeEnum.VisualPlumesScenarioResults:
                case TVTypeEnum.TotalFile:
                case TVTypeEnum.MikeSourceIsRiver:
                case TVTypeEnum.MikeSourceIncluded:
                case TVTypeEnum.MikeSourceNotIncluded:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TVType);
            }
        }
        public string WebTideDataSetOK(WebTideDataSetEnum? webTideDataSet)
        {
            if (webTideDataSet == null)
                return "";

            switch ((WebTideDataSetEnum)webTideDataSet)
            {
                case WebTideDataSetEnum.Error:
                case WebTideDataSetEnum.arctic9:
                case WebTideDataSetEnum.brador:
                case WebTideDataSetEnum.HRglobal:
                case WebTideDataSetEnum.h3o:
                case WebTideDataSetEnum.hudson:
                case WebTideDataSetEnum.ne_pac4:
                case WebTideDataSetEnum.nwatl:
                case WebTideDataSetEnum.QuatsinoModel14:
                case WebTideDataSetEnum.sshelf:
                case WebTideDataSetEnum.flood:
                case WebTideDataSetEnum.vigf8:
                    return "";
                default:
                    return string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.WebTideDataSet);
            }
        }

        #endregion Enum CheckOK

    }
}
