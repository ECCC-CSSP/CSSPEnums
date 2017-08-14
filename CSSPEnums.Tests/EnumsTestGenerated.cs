using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSSPEnums.Tests;
using System.Globalization;
using System.Threading;
using CSSPEnums;
using CSSPEnums.Resources;
using System.Linq;

namespace CSSPEnums.Tests
{
    public partial class EnumsTest : SetupData
    {

        #region Testing Methods GetEnumText public
        [TestMethod]
        public void Enums_GetEnumText_ActionDBTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_ActionDBTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(ActionDBTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_ActionDBTypeEnum((ActionDBTypeEnum)i);
        
                    switch ((ActionDBTypeEnum)i)
                    {
                        case ActionDBTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case ActionDBTypeEnum.Create:
                            Assert.AreEqual(CSSPEnumsRes.ActionDBTypeEnumCreate, retStr);
                            break;
                        case ActionDBTypeEnum.Read:
                            Assert.AreEqual(CSSPEnumsRes.ActionDBTypeEnumRead, retStr);
                            break;
                        case ActionDBTypeEnum.Update:
                            Assert.AreEqual(CSSPEnumsRes.ActionDBTypeEnumUpdate, retStr);
                            break;
                        case ActionDBTypeEnum.Delete:
                            Assert.AreEqual(CSSPEnumsRes.ActionDBTypeEnumDelete, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_AddressTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_AddressTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(AddressTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_AddressTypeEnum((AddressTypeEnum)i);
        
                    switch ((AddressTypeEnum)i)
                    {
                        case AddressTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case AddressTypeEnum.Mailing:
                            Assert.AreEqual(CSSPEnumsRes.AddressTypeEnumMailing, retStr);
                            break;
                        case AddressTypeEnum.Shipping:
                            Assert.AreEqual(CSSPEnumsRes.AddressTypeEnumShipping, retStr);
                            break;
                        case AddressTypeEnum.Civic:
                            Assert.AreEqual(CSSPEnumsRes.AddressTypeEnumCivic, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_AerationTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_AerationTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(AerationTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_AerationTypeEnum((AerationTypeEnum)i);
        
                    switch ((AerationTypeEnum)i)
                    {
                        case AerationTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case AerationTypeEnum.Diffuser:
                            Assert.AreEqual(CSSPEnumsRes.AerationTypeEnumDiffuser, retStr);
                            break;
                        case AerationTypeEnum.Surface:
                            Assert.AreEqual(CSSPEnumsRes.AerationTypeEnumSurface, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_AlarmSystemTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_AlarmSystemTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(AlarmSystemTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_AlarmSystemTypeEnum((AlarmSystemTypeEnum)i);
        
                    switch ((AlarmSystemTypeEnum)i)
                    {
                        case AlarmSystemTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case AlarmSystemTypeEnum.SCADA:
                            Assert.AreEqual(CSSPEnumsRes.AlarmSystemTypeEnumSCADA, retStr);
                            break;
                        case AlarmSystemTypeEnum.None:
                            Assert.AreEqual(CSSPEnumsRes.AlarmSystemTypeEnumNone, retStr);
                            break;
                        case AlarmSystemTypeEnum.OnlyVisualLight:
                            Assert.AreEqual(CSSPEnumsRes.AlarmSystemTypeEnumOnlyVisualLight, retStr);
                            break;
                        case AlarmSystemTypeEnum.SCADAAndLight:
                            Assert.AreEqual(CSSPEnumsRes.AlarmSystemTypeEnumSCADAAndLight, retStr);
                            break;
                        case AlarmSystemTypeEnum.PagerAndLight:
                            Assert.AreEqual(CSSPEnumsRes.AlarmSystemTypeEnumPagerAndLight, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_AnalyzeMethodEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_AnalyzeMethodEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(AnalyzeMethodEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_AnalyzeMethodEnum((AnalyzeMethodEnum)i);
        
                    switch ((AnalyzeMethodEnum)i)
                    {
                        case AnalyzeMethodEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case AnalyzeMethodEnum.MF:
                            Assert.AreEqual(CSSPEnumsRes.AnalyzeMethodEnumMF, retStr);
                            break;
                        case AnalyzeMethodEnum.ZZ_510Q:
                            Assert.AreEqual(CSSPEnumsRes.AnalyzeMethodEnumZZ_510Q, retStr);
                            break;
                        case AnalyzeMethodEnum.ZZ_509Q:
                            Assert.AreEqual(CSSPEnumsRes.AnalyzeMethodEnumZZ_509Q, retStr);
                            break;
                        case AnalyzeMethodEnum.ZZ_0:
                            Assert.AreEqual(CSSPEnumsRes.AnalyzeMethodEnumZZ_0, retStr);
                            break;
                        case AnalyzeMethodEnum.ZZ_525Q:
                            Assert.AreEqual(CSSPEnumsRes.AnalyzeMethodEnumZZ_525Q, retStr);
                            break;
                        case AnalyzeMethodEnum.MPN:
                            Assert.AreEqual(CSSPEnumsRes.AnalyzeMethodEnumMPN, retStr);
                            break;
                        case AnalyzeMethodEnum.ZZ_0Q:
                            Assert.AreEqual(CSSPEnumsRes.AnalyzeMethodEnumZZ_0Q, retStr);
                            break;
                        case AnalyzeMethodEnum.AnalyzeMethod8:
                            Assert.AreEqual(CSSPEnumsRes.AnalyzeMethodEnumAnalyzeMethod8, retStr);
                            break;
                        case AnalyzeMethodEnum.AnalyzeMethod9:
                            Assert.AreEqual(CSSPEnumsRes.AnalyzeMethodEnumAnalyzeMethod9, retStr);
                            break;
                        case AnalyzeMethodEnum.AnalyzeMethod10:
                            Assert.AreEqual(CSSPEnumsRes.AnalyzeMethodEnumAnalyzeMethod10, retStr);
                            break;
                        case AnalyzeMethodEnum.AnalyzeMethod11:
                            Assert.AreEqual(CSSPEnumsRes.AnalyzeMethodEnumAnalyzeMethod11, retStr);
                            break;
                        case AnalyzeMethodEnum.AnalyzeMethod12:
                            Assert.AreEqual(CSSPEnumsRes.AnalyzeMethodEnumAnalyzeMethod12, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_AppTaskCommandEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_AppTaskCommandEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(AppTaskCommandEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_AppTaskCommandEnum((AppTaskCommandEnum)i);
        
                    switch ((AppTaskCommandEnum)i)
                    {
                        case AppTaskCommandEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case AppTaskCommandEnum.GenerateWebTide:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumGenerateWebTide, retStr);
                            break;
                        case AppTaskCommandEnum.MikeScenarioAskToRun:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumMikeScenarioAskToRun, retStr);
                            break;
                        case AppTaskCommandEnum.MikeScenarioImport:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumMikeScenarioImport, retStr);
                            break;
                        case AppTaskCommandEnum.MikeScenarioOtherFileImport:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumMikeScenarioOtherFileImport, retStr);
                            break;
                        case AppTaskCommandEnum.MikeScenarioRunning:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumMikeScenarioRunning, retStr);
                            break;
                        case AppTaskCommandEnum.MikeScenarioToCancel:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumMikeScenarioToCancel, retStr);
                            break;
                        case AppTaskCommandEnum.MikeScenarioWaitingToRun:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumMikeScenarioWaitingToRun, retStr);
                            break;
                        case AppTaskCommandEnum.SetupWebTide:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumSetupWebTide, retStr);
                            break;
                        case AppTaskCommandEnum.UpdateClimateSiteInformation:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumUpdateClimateSiteInformation, retStr);
                            break;
                        case AppTaskCommandEnum.UpdateClimateSiteDailyAndHourlyFromStartDateToEndDate:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumUpdateClimateSiteDailyAndHourlyFromStartDateToEndDate, retStr);
                            break;
                        case AppTaskCommandEnum.UpdateClimateSiteDailyAndHourlyForSubsectorFromStartDateToEndDate:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumUpdateClimateSiteDailyAndHourlyForSubsectorFromStartDateToEndDate, retStr);
                            break;
                        case AppTaskCommandEnum.CreateFCForm:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumCreateFCForm, retStr);
                            break;
                        case AppTaskCommandEnum.CreateSamplingPlanSamplingPlanTextFile:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumCreateSamplingPlanSamplingPlanTextFile, retStr);
                            break;
                        case AppTaskCommandEnum.CreateDocumentFromTemplate:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumCreateDocumentFromTemplate, retStr);
                            break;
                        case AppTaskCommandEnum.GetClimateSitesDataForRunsOfYear:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumGetClimateSitesDataForRunsOfYear, retStr);
                            break;
                        case AppTaskCommandEnum.CreateWebTideDataWLAtFirstNode:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskCommandEnumCreateWebTideDataWLAtFirstNode, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_AppTaskStatusEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_AppTaskStatusEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(AppTaskStatusEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_AppTaskStatusEnum((AppTaskStatusEnum)i);
        
                    switch ((AppTaskStatusEnum)i)
                    {
                        case AppTaskStatusEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case AppTaskStatusEnum.Created:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskStatusEnumCreated, retStr);
                            break;
                        case AppTaskStatusEnum.Running:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskStatusEnumRunning, retStr);
                            break;
                        case AppTaskStatusEnum.Completed:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskStatusEnumCompleted, retStr);
                            break;
                        case AppTaskStatusEnum.Cancelled:
                            Assert.AreEqual(CSSPEnumsRes.AppTaskStatusEnumCancelled, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_BeaufortScaleEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_BeaufortScaleEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = -1, count = Enum.GetNames(typeof(BeaufortScaleEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_BeaufortScaleEnum((BeaufortScaleEnum)i);
        
                    switch ((BeaufortScaleEnum)i)
                    {
                        case BeaufortScaleEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case BeaufortScaleEnum.Calm:
                            Assert.AreEqual(CSSPEnumsRes.BeaufortScaleEnumCalm, retStr);
                            break;
                        case BeaufortScaleEnum.LightAir:
                            Assert.AreEqual(CSSPEnumsRes.BeaufortScaleEnumLightAir, retStr);
                            break;
                        case BeaufortScaleEnum.LightBreeze:
                            Assert.AreEqual(CSSPEnumsRes.BeaufortScaleEnumLightBreeze, retStr);
                            break;
                        case BeaufortScaleEnum.GentleBreeze:
                            Assert.AreEqual(CSSPEnumsRes.BeaufortScaleEnumGentleBreeze, retStr);
                            break;
                        case BeaufortScaleEnum.ModerateBreeze:
                            Assert.AreEqual(CSSPEnumsRes.BeaufortScaleEnumModerateBreeze, retStr);
                            break;
                        case BeaufortScaleEnum.FreshBreeze:
                            Assert.AreEqual(CSSPEnumsRes.BeaufortScaleEnumFreshBreeze, retStr);
                            break;
                        case BeaufortScaleEnum.StrongBreeze:
                            Assert.AreEqual(CSSPEnumsRes.BeaufortScaleEnumStrongBreeze, retStr);
                            break;
                        case BeaufortScaleEnum.HighWind_ModerateGale_NearGale:
                            Assert.AreEqual(CSSPEnumsRes.BeaufortScaleEnumHighWind_ModerateGale_NearGale, retStr);
                            break;
                        case BeaufortScaleEnum.Gale_FreshGale:
                            Assert.AreEqual(CSSPEnumsRes.BeaufortScaleEnumGale_FreshGale, retStr);
                            break;
                        case BeaufortScaleEnum.Strong_SevereGale:
                            Assert.AreEqual(CSSPEnumsRes.BeaufortScaleEnumStrong_SevereGale, retStr);
                            break;
                        case BeaufortScaleEnum.Storm_WholeGale:
                            Assert.AreEqual(CSSPEnumsRes.BeaufortScaleEnumStorm_WholeGale, retStr);
                            break;
                        case BeaufortScaleEnum.ViolentStorm:
                            Assert.AreEqual(CSSPEnumsRes.BeaufortScaleEnumViolentStorm, retStr);
                            break;
                        case BeaufortScaleEnum.HurricaneForce:
                            Assert.AreEqual(CSSPEnumsRes.BeaufortScaleEnumHurricaneForce, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_BoxModelResultTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_BoxModelResultTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(BoxModelResultTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_BoxModelResultTypeEnum((BoxModelResultTypeEnum)i);
        
                    switch ((BoxModelResultTypeEnum)i)
                    {
                        case BoxModelResultTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case BoxModelResultTypeEnum.Dilution:
                            Assert.AreEqual(CSSPEnumsRes.BoxModelResultTypeEnumDilution, retStr);
                            break;
                        case BoxModelResultTypeEnum.NoDecayUntreated:
                            Assert.AreEqual(CSSPEnumsRes.BoxModelResultTypeEnumNoDecayUntreated, retStr);
                            break;
                        case BoxModelResultTypeEnum.NoDecayPreDisinfection:
                            Assert.AreEqual(CSSPEnumsRes.BoxModelResultTypeEnumNoDecayPreDisinfection, retStr);
                            break;
                        case BoxModelResultTypeEnum.DecayUntreated:
                            Assert.AreEqual(CSSPEnumsRes.BoxModelResultTypeEnumDecayUntreated, retStr);
                            break;
                        case BoxModelResultTypeEnum.DecayPreDisinfection:
                            Assert.AreEqual(CSSPEnumsRes.BoxModelResultTypeEnumDecayPreDisinfection, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_CollectionSystemTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_CollectionSystemTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(CollectionSystemTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_CollectionSystemTypeEnum((CollectionSystemTypeEnum)i);
        
                    switch ((CollectionSystemTypeEnum)i)
                    {
                        case CollectionSystemTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case CollectionSystemTypeEnum.CompletelySeparated:
                            Assert.AreEqual(CSSPEnumsRes.CollectionSystemTypeEnumCompletelySeparated, retStr);
                            break;
                        case CollectionSystemTypeEnum.CompletelyCombined:
                            Assert.AreEqual(CSSPEnumsRes.CollectionSystemTypeEnumCompletelyCombined, retStr);
                            break;
                        case CollectionSystemTypeEnum.Combined90Separated10:
                            Assert.AreEqual(CSSPEnumsRes.CollectionSystemTypeEnumCombined90Separated10, retStr);
                            break;
                        case CollectionSystemTypeEnum.Combined80Separated20:
                            Assert.AreEqual(CSSPEnumsRes.CollectionSystemTypeEnumCombined80Separated20, retStr);
                            break;
                        case CollectionSystemTypeEnum.Combined70Separated30:
                            Assert.AreEqual(CSSPEnumsRes.CollectionSystemTypeEnumCombined70Separated30, retStr);
                            break;
                        case CollectionSystemTypeEnum.Combined60Separated40:
                            Assert.AreEqual(CSSPEnumsRes.CollectionSystemTypeEnumCombined60Separated40, retStr);
                            break;
                        case CollectionSystemTypeEnum.Combined50Separated50:
                            Assert.AreEqual(CSSPEnumsRes.CollectionSystemTypeEnumCombined50Separated50, retStr);
                            break;
                        case CollectionSystemTypeEnum.Combined40Separated60:
                            Assert.AreEqual(CSSPEnumsRes.CollectionSystemTypeEnumCombined40Separated60, retStr);
                            break;
                        case CollectionSystemTypeEnum.Combined30Separated70:
                            Assert.AreEqual(CSSPEnumsRes.CollectionSystemTypeEnumCombined30Separated70, retStr);
                            break;
                        case CollectionSystemTypeEnum.Combined20Separated80:
                            Assert.AreEqual(CSSPEnumsRes.CollectionSystemTypeEnumCombined20Separated80, retStr);
                            break;
                        case CollectionSystemTypeEnum.Combined10Separated90:
                            Assert.AreEqual(CSSPEnumsRes.CollectionSystemTypeEnumCombined10Separated90, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_ContactTitleEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_ContactTitleEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(ContactTitleEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_ContactTitleEnum((ContactTitleEnum)i);
        
                    switch ((ContactTitleEnum)i)
                    {
                        case ContactTitleEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case ContactTitleEnum.DirectorGeneral:
                            Assert.AreEqual(CSSPEnumsRes.ContactTitleEnumDirectorGeneral, retStr);
                            break;
                        case ContactTitleEnum.DirectorPublicWorks:
                            Assert.AreEqual(CSSPEnumsRes.ContactTitleEnumDirectorPublicWorks, retStr);
                            break;
                        case ContactTitleEnum.Superintendent:
                            Assert.AreEqual(CSSPEnumsRes.ContactTitleEnumSuperintendent, retStr);
                            break;
                        case ContactTitleEnum.Engineer:
                            Assert.AreEqual(CSSPEnumsRes.ContactTitleEnumEngineer, retStr);
                            break;
                        case ContactTitleEnum.Foreman:
                            Assert.AreEqual(CSSPEnumsRes.ContactTitleEnumForeman, retStr);
                            break;
                        case ContactTitleEnum.Operator:
                            Assert.AreEqual(CSSPEnumsRes.ContactTitleEnumOperator, retStr);
                            break;
                        case ContactTitleEnum.FacilitiesManager:
                            Assert.AreEqual(CSSPEnumsRes.ContactTitleEnumFacilitiesManager, retStr);
                            break;
                        case ContactTitleEnum.Supervisor:
                            Assert.AreEqual(CSSPEnumsRes.ContactTitleEnumSupervisor, retStr);
                            break;
                        case ContactTitleEnum.Technician:
                            Assert.AreEqual(CSSPEnumsRes.ContactTitleEnumTechnician, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_CSSPWQInputSheetTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_CSSPWQInputSheetTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(CSSPWQInputSheetTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_CSSPWQInputSheetTypeEnum((CSSPWQInputSheetTypeEnum)i);
        
                    switch ((CSSPWQInputSheetTypeEnum)i)
                    {
                        case CSSPWQInputSheetTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case CSSPWQInputSheetTypeEnum.A1:
                            Assert.AreEqual(CSSPEnumsRes.CSSPWQInputSheetTypeEnumA1, retStr);
                            break;
                        case CSSPWQInputSheetTypeEnum.LTB:
                            Assert.AreEqual(CSSPEnumsRes.CSSPWQInputSheetTypeEnumLTB, retStr);
                            break;
                        case CSSPWQInputSheetTypeEnum.EC:
                            Assert.AreEqual(CSSPEnumsRes.CSSPWQInputSheetTypeEnumEC, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_CSSPWQInputTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_CSSPWQInputTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(CSSPWQInputTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_CSSPWQInputTypeEnum((CSSPWQInputTypeEnum)i);
        
                    switch ((CSSPWQInputTypeEnum)i)
                    {
                        case CSSPWQInputTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case CSSPWQInputTypeEnum.Subsector:
                            Assert.AreEqual(CSSPEnumsRes.CSSPWQInputTypeEnumSubsector, retStr);
                            break;
                        case CSSPWQInputTypeEnum.Municipality:
                            Assert.AreEqual(CSSPEnumsRes.CSSPWQInputTypeEnumMunicipality, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_DailyOrHourlyDataEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_DailyOrHourlyDataEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(DailyOrHourlyDataEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_DailyOrHourlyDataEnum((DailyOrHourlyDataEnum)i);
        
                    switch ((DailyOrHourlyDataEnum)i)
                    {
                        case DailyOrHourlyDataEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case DailyOrHourlyDataEnum.Daily:
                            Assert.AreEqual(CSSPEnumsRes.DailyOrHourlyDataEnumDaily, retStr);
                            break;
                        case DailyOrHourlyDataEnum.Hourly:
                            Assert.AreEqual(CSSPEnumsRes.DailyOrHourlyDataEnumHourly, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_DatabaseTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_DatabaseTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(DatabaseTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_DatabaseTypeEnum((DatabaseTypeEnum)i);
        
                    switch ((DatabaseTypeEnum)i)
                    {
                        case DatabaseTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case DatabaseTypeEnum.MemoryCSSPWebToolsDB:
                            Assert.AreEqual(CSSPEnumsRes.DatabaseTypeEnumMemoryCSSPWebToolsDB, retStr);
                            break;
                        case DatabaseTypeEnum.MemoryTestDB:
                            Assert.AreEqual(CSSPEnumsRes.DatabaseTypeEnumMemoryTestDB, retStr);
                            break;
                        case DatabaseTypeEnum.SqlServerCSSPWebToolsDB:
                            Assert.AreEqual(CSSPEnumsRes.DatabaseTypeEnumSqlServerCSSPWebToolsDB, retStr);
                            break;
                        case DatabaseTypeEnum.SqlServerTestDB:
                            Assert.AreEqual(CSSPEnumsRes.DatabaseTypeEnumSqlServerTestDB, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_DisinfectionTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_DisinfectionTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(DisinfectionTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_DisinfectionTypeEnum((DisinfectionTypeEnum)i);
        
                    switch ((DisinfectionTypeEnum)i)
                    {
                        case DisinfectionTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case DisinfectionTypeEnum.None:
                            Assert.AreEqual(CSSPEnumsRes.DisinfectionTypeEnumNone, retStr);
                            break;
                        case DisinfectionTypeEnum.UV:
                            Assert.AreEqual(CSSPEnumsRes.DisinfectionTypeEnumUV, retStr);
                            break;
                        case DisinfectionTypeEnum.ChlorinationNoDechlorination:
                            Assert.AreEqual(CSSPEnumsRes.DisinfectionTypeEnumChlorinationNoDechlorination, retStr);
                            break;
                        case DisinfectionTypeEnum.ChlorinationWithDechlorination:
                            Assert.AreEqual(CSSPEnumsRes.DisinfectionTypeEnumChlorinationWithDechlorination, retStr);
                            break;
                        case DisinfectionTypeEnum.UVSeasonal:
                            Assert.AreEqual(CSSPEnumsRes.DisinfectionTypeEnumUVSeasonal, retStr);
                            break;
                        case DisinfectionTypeEnum.ChlorinationNoDechlorinationSeasonal:
                            Assert.AreEqual(CSSPEnumsRes.DisinfectionTypeEnumChlorinationNoDechlorinationSeasonal, retStr);
                            break;
                        case DisinfectionTypeEnum.ChlorinationWithDechlorinationSeasonal:
                            Assert.AreEqual(CSSPEnumsRes.DisinfectionTypeEnumChlorinationWithDechlorinationSeasonal, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_EmailTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_EmailTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(EmailTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_EmailTypeEnum((EmailTypeEnum)i);
        
                    switch ((EmailTypeEnum)i)
                    {
                        case EmailTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case EmailTypeEnum.Personal:
                            Assert.AreEqual(CSSPEnumsRes.EmailTypeEnumPersonal, retStr);
                            break;
                        case EmailTypeEnum.Work:
                            Assert.AreEqual(CSSPEnumsRes.EmailTypeEnumWork, retStr);
                            break;
                        case EmailTypeEnum.Personal2:
                            Assert.AreEqual(CSSPEnumsRes.EmailTypeEnumPersonal2, retStr);
                            break;
                        case EmailTypeEnum.Work2:
                            Assert.AreEqual(CSSPEnumsRes.EmailTypeEnumWork2, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_FacilityTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_FacilityTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(FacilityTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_FacilityTypeEnum((FacilityTypeEnum)i);
        
                    switch ((FacilityTypeEnum)i)
                    {
                        case FacilityTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case FacilityTypeEnum.Lagoon:
                            Assert.AreEqual(CSSPEnumsRes.FacilityTypeEnumLagoon, retStr);
                            break;
                        case FacilityTypeEnum.Plant:
                            Assert.AreEqual(CSSPEnumsRes.FacilityTypeEnumPlant, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_FilePurposeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_FilePurposeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(FilePurposeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_FilePurposeEnum((FilePurposeEnum)i);
        
                    switch ((FilePurposeEnum)i)
                    {
                        case FilePurposeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case FilePurposeEnum.MikeInput:
                            Assert.AreEqual(CSSPEnumsRes.FilePurposeEnumMikeInput, retStr);
                            break;
                        case FilePurposeEnum.MikeInputMDF:
                            Assert.AreEqual(CSSPEnumsRes.FilePurposeEnumMikeInputMDF, retStr);
                            break;
                        case FilePurposeEnum.MikeResultDFSU:
                            Assert.AreEqual(CSSPEnumsRes.FilePurposeEnumMikeResultDFSU, retStr);
                            break;
                        case FilePurposeEnum.MikeResultKMZ:
                            Assert.AreEqual(CSSPEnumsRes.FilePurposeEnumMikeResultKMZ, retStr);
                            break;
                        case FilePurposeEnum.Information:
                            Assert.AreEqual(CSSPEnumsRes.FilePurposeEnumInformation, retStr);
                            break;
                        case FilePurposeEnum.Image:
                            Assert.AreEqual(CSSPEnumsRes.FilePurposeEnumImage, retStr);
                            break;
                        case FilePurposeEnum.Picture:
                            Assert.AreEqual(CSSPEnumsRes.FilePurposeEnumPicture, retStr);
                            break;
                        case FilePurposeEnum.Reported:
                            Assert.AreEqual(CSSPEnumsRes.FilePurposeEnumReported, retStr);
                            break;
                        case FilePurposeEnum.Generated:
                            Assert.AreEqual(CSSPEnumsRes.FilePurposeEnumGenerated, retStr);
                            break;
                        case FilePurposeEnum.GeneratedFCForm:
                            Assert.AreEqual(CSSPEnumsRes.FilePurposeEnumGeneratedFCForm, retStr);
                            break;
                        case FilePurposeEnum.Template:
                            Assert.AreEqual(CSSPEnumsRes.FilePurposeEnumTemplate, retStr);
                            break;
                        case FilePurposeEnum.Map:
                            Assert.AreEqual(CSSPEnumsRes.FilePurposeEnumMap, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_FileStatusEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_FileStatusEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(FileStatusEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_FileStatusEnum((FileStatusEnum)i);
        
                    switch ((FileStatusEnum)i)
                    {
                        case FileStatusEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case FileStatusEnum.Changed:
                            Assert.AreEqual(CSSPEnumsRes.FileStatusEnumChanged, retStr);
                            break;
                        case FileStatusEnum.Sent:
                            Assert.AreEqual(CSSPEnumsRes.FileStatusEnumSent, retStr);
                            break;
                        case FileStatusEnum.Accepted:
                            Assert.AreEqual(CSSPEnumsRes.FileStatusEnumAccepted, retStr);
                            break;
                        case FileStatusEnum.Rejected:
                            Assert.AreEqual(CSSPEnumsRes.FileStatusEnumRejected, retStr);
                            break;
                        case FileStatusEnum.Fail:
                            Assert.AreEqual(CSSPEnumsRes.FileStatusEnumFail, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_FileTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_FileTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(FileTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_FileTypeEnum((FileTypeEnum)i);
        
                    switch ((FileTypeEnum)i)
                    {
                        case FileTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case FileTypeEnum.DFS0:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumDFS0, retStr);
                            break;
                        case FileTypeEnum.DFS1:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumDFS1, retStr);
                            break;
                        case FileTypeEnum.DFSU:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumDFSU, retStr);
                            break;
                        case FileTypeEnum.KMZ:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumKMZ, retStr);
                            break;
                        case FileTypeEnum.LOG:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumLOG, retStr);
                            break;
                        case FileTypeEnum.M21FM:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumM21FM, retStr);
                            break;
                        case FileTypeEnum.M3FM:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumM3FM, retStr);
                            break;
                        case FileTypeEnum.MDF:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumMDF, retStr);
                            break;
                        case FileTypeEnum.MESH:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumMESH, retStr);
                            break;
                        case FileTypeEnum.XLSX:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumXLSX, retStr);
                            break;
                        case FileTypeEnum.DOCX:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumDOCX, retStr);
                            break;
                        case FileTypeEnum.PDF:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumPDF, retStr);
                            break;
                        case FileTypeEnum.JPG:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumJPG, retStr);
                            break;
                        case FileTypeEnum.JPEG:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumJPEG, retStr);
                            break;
                        case FileTypeEnum.GIF:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumGIF, retStr);
                            break;
                        case FileTypeEnum.PNG:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumPNG, retStr);
                            break;
                        case FileTypeEnum.HTML:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumHTML, retStr);
                            break;
                        case FileTypeEnum.TXT:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumTXT, retStr);
                            break;
                        case FileTypeEnum.XYZ:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumXYZ, retStr);
                            break;
                        case FileTypeEnum.KML:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumKML, retStr);
                            break;
                        case FileTypeEnum.CSV:
                            Assert.AreEqual(CSSPEnumsRes.FileTypeEnumCSV, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_InfrastructureTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_InfrastructureTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(InfrastructureTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_InfrastructureTypeEnum((InfrastructureTypeEnum)i);
        
                    switch ((InfrastructureTypeEnum)i)
                    {
                        case InfrastructureTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case InfrastructureTypeEnum.WWTP:
                            Assert.AreEqual(CSSPEnumsRes.InfrastructureTypeEnumWWTP, retStr);
                            break;
                        case InfrastructureTypeEnum.LiftStation:
                            Assert.AreEqual(CSSPEnumsRes.InfrastructureTypeEnumLiftStation, retStr);
                            break;
                        case InfrastructureTypeEnum.Other:
                            Assert.AreEqual(CSSPEnumsRes.InfrastructureTypeEnumOther, retStr);
                            break;
                        case InfrastructureTypeEnum.SeeOther:
                            Assert.AreEqual(CSSPEnumsRes.InfrastructureTypeEnumSeeOther, retStr);
                            break;
                        case InfrastructureTypeEnum.LineOverflow:
                            Assert.AreEqual(CSSPEnumsRes.InfrastructureTypeEnumLineOverflow, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_KMZActionEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_KMZActionEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(KMZActionEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_KMZActionEnum((KMZActionEnum)i);
        
                    switch ((KMZActionEnum)i)
                    {
                        case KMZActionEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case KMZActionEnum.DoNothing:
                            Assert.AreEqual(CSSPEnumsRes.KMZActionEnumDoNothing, retStr);
                            break;
                        case KMZActionEnum.GenerateKMZContourAnimation:
                            Assert.AreEqual(CSSPEnumsRes.KMZActionEnumGenerateKMZContourAnimation, retStr);
                            break;
                        case KMZActionEnum.GenerateKMZContourLimit:
                            Assert.AreEqual(CSSPEnumsRes.KMZActionEnumGenerateKMZContourLimit, retStr);
                            break;
                        case KMZActionEnum.GenerateKMZCurrentAnimation:
                            Assert.AreEqual(CSSPEnumsRes.KMZActionEnumGenerateKMZCurrentAnimation, retStr);
                            break;
                        case KMZActionEnum.GenerateKMZCurrentMaximum:
                            Assert.AreEqual(CSSPEnumsRes.KMZActionEnumGenerateKMZCurrentMaximum, retStr);
                            break;
                        case KMZActionEnum.GenerateKMZMesh:
                            Assert.AreEqual(CSSPEnumsRes.KMZActionEnumGenerateKMZMesh, retStr);
                            break;
                        case KMZActionEnum.GenerateKMZStudyArea:
                            Assert.AreEqual(CSSPEnumsRes.KMZActionEnumGenerateKMZStudyArea, retStr);
                            break;
                        case KMZActionEnum.GenerateKMZBoundaryConditionNodes:
                            Assert.AreEqual(CSSPEnumsRes.KMZActionEnumGenerateKMZBoundaryConditionNodes, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_LaboratoryEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_LaboratoryEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(LaboratoryEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_LaboratoryEnum((LaboratoryEnum)i);
        
                    switch ((LaboratoryEnum)i)
                    {
                        case LaboratoryEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case LaboratoryEnum.ZZ_0:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_0, retStr);
                            break;
                        case LaboratoryEnum.ZZ_1:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_1, retStr);
                            break;
                        case LaboratoryEnum.ZZ_2:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_2, retStr);
                            break;
                        case LaboratoryEnum.ZZ_3:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_3, retStr);
                            break;
                        case LaboratoryEnum.ZZ_4:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_4, retStr);
                            break;
                        case LaboratoryEnum.ZZ_1Q:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_1Q, retStr);
                            break;
                        case LaboratoryEnum.ZZ_2Q:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_2Q, retStr);
                            break;
                        case LaboratoryEnum.ZZ_3Q:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_3Q, retStr);
                            break;
                        case LaboratoryEnum.ZZ_4Q:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_4Q, retStr);
                            break;
                        case LaboratoryEnum.ZZ_5Q:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_5Q, retStr);
                            break;
                        case LaboratoryEnum.ZZ_11BC:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_11BC, retStr);
                            break;
                        case LaboratoryEnum.ZZ_12BC:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_12BC, retStr);
                            break;
                        case LaboratoryEnum.ZZ_13BC:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_13BC, retStr);
                            break;
                        case LaboratoryEnum.ZZ_14BC:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_14BC, retStr);
                            break;
                        case LaboratoryEnum.ZZ_15BC:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_15BC, retStr);
                            break;
                        case LaboratoryEnum.ZZ_16BC:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_16BC, retStr);
                            break;
                        case LaboratoryEnum.ZZ_17BC:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_17BC, retStr);
                            break;
                        case LaboratoryEnum.ZZ_18BC:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumZZ_18BC, retStr);
                            break;
                        case LaboratoryEnum.MonctonEnvironmentCanada:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumMonctonEnvironmentCanada, retStr);
                            break;
                        case LaboratoryEnum.BIOEnvironmentCanada:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumBIOEnvironmentCanada, retStr);
                            break;
                        case LaboratoryEnum.EasternCharlotteWaterwayLaboratory:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumEasternCharlotteWaterwayLaboratory, retStr);
                            break;
                        case LaboratoryEnum.InstitutDeRechercheSurLesZonesCotieres:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumInstitutDeRechercheSurLesZonesCotieres, retStr);
                            break;
                        case LaboratoryEnum.CentreDeRechercheSurLesAliments:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumCentreDeRechercheSurLesAliments, retStr);
                            break;
                        case LaboratoryEnum.CaraquetMobileLaboratoryEnvironmentCanada:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumCaraquetMobileLaboratoryEnvironmentCanada, retStr);
                            break;
                        case LaboratoryEnum.MaxxamAnalyticsBedford:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumMaxxamAnalyticsBedford, retStr);
                            break;
                        case LaboratoryEnum.MaxxamAnalyticsSydney:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumMaxxamAnalyticsSydney, retStr);
                            break;
                        case LaboratoryEnum.PEIAnalyticalLaboratory:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumPEIAnalyticalLaboratory, retStr);
                            break;
                        case LaboratoryEnum.NLMobileLaboratory:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumNLMobileLaboratory, retStr);
                            break;
                        case LaboratoryEnum.PetroformaInc:
                            Assert.AreEqual(CSSPEnumsRes.LaboratoryEnumPetroformaInc, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_LabSheetStatusEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_LabSheetStatusEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(LabSheetStatusEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_LabSheetStatusEnum((LabSheetStatusEnum)i);
        
                    switch ((LabSheetStatusEnum)i)
                    {
                        case LabSheetStatusEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case LabSheetStatusEnum.Created:
                            Assert.AreEqual(CSSPEnumsRes.LabSheetStatusEnumCreated, retStr);
                            break;
                        case LabSheetStatusEnum.Transferred:
                            Assert.AreEqual(CSSPEnumsRes.LabSheetStatusEnumTransferred, retStr);
                            break;
                        case LabSheetStatusEnum.Accepted:
                            Assert.AreEqual(CSSPEnumsRes.LabSheetStatusEnumAccepted, retStr);
                            break;
                        case LabSheetStatusEnum.Rejected:
                            Assert.AreEqual(CSSPEnumsRes.LabSheetStatusEnumRejected, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_LabSheetTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_LabSheetTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(LabSheetTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_LabSheetTypeEnum((LabSheetTypeEnum)i);
        
                    switch ((LabSheetTypeEnum)i)
                    {
                        case LabSheetTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case LabSheetTypeEnum.A1:
                            Assert.AreEqual(CSSPEnumsRes.LabSheetTypeEnumA1, retStr);
                            break;
                        case LabSheetTypeEnum.LTB:
                            Assert.AreEqual(CSSPEnumsRes.LabSheetTypeEnumLTB, retStr);
                            break;
                        case LabSheetTypeEnum.EC:
                            Assert.AreEqual(CSSPEnumsRes.LabSheetTypeEnumEC, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_LanguageEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_LanguageEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(LanguageEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_LanguageEnum((LanguageEnum)i);
        
                    switch ((LanguageEnum)i)
                    {
                        case LanguageEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case LanguageEnum.en:
                            Assert.AreEqual(CSSPEnumsRes.LanguageEnumen, retStr);
                            break;
                        case LanguageEnum.fr:
                            Assert.AreEqual(CSSPEnumsRes.LanguageEnumfr, retStr);
                            break;
                        case LanguageEnum.enAndfr:
                            Assert.AreEqual(CSSPEnumsRes.LanguageEnumenAndfr, retStr);
                            break;
                        case LanguageEnum.es:
                            Assert.AreEqual(CSSPEnumsRes.LanguageEnumes, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_LogCommandEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_LogCommandEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(LogCommandEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_LogCommandEnum((LogCommandEnum)i);
        
                    switch ((LogCommandEnum)i)
                    {
                        case LogCommandEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case LogCommandEnum.Add:
                            Assert.AreEqual(CSSPEnumsRes.LogCommandEnumAdd, retStr);
                            break;
                        case LogCommandEnum.Change:
                            Assert.AreEqual(CSSPEnumsRes.LogCommandEnumChange, retStr);
                            break;
                        case LogCommandEnum.Delete:
                            Assert.AreEqual(CSSPEnumsRes.LogCommandEnumDelete, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_MapInfoDrawTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_MapInfoDrawTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(MapInfoDrawTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_MapInfoDrawTypeEnum((MapInfoDrawTypeEnum)i);
        
                    switch ((MapInfoDrawTypeEnum)i)
                    {
                        case MapInfoDrawTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case MapInfoDrawTypeEnum.Point:
                            Assert.AreEqual(CSSPEnumsRes.MapInfoDrawTypeEnumPoint, retStr);
                            break;
                        case MapInfoDrawTypeEnum.Polyline:
                            Assert.AreEqual(CSSPEnumsRes.MapInfoDrawTypeEnumPolyline, retStr);
                            break;
                        case MapInfoDrawTypeEnum.Polygon:
                            Assert.AreEqual(CSSPEnumsRes.MapInfoDrawTypeEnumPolygon, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_MikeBoundaryConditionLevelOrVelocityEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_MikeBoundaryConditionLevelOrVelocityEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(MikeBoundaryConditionLevelOrVelocityEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_MikeBoundaryConditionLevelOrVelocityEnum((MikeBoundaryConditionLevelOrVelocityEnum)i);
        
                    switch ((MikeBoundaryConditionLevelOrVelocityEnum)i)
                    {
                        case MikeBoundaryConditionLevelOrVelocityEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case MikeBoundaryConditionLevelOrVelocityEnum.Level:
                            Assert.AreEqual(CSSPEnumsRes.MikeBoundaryConditionLevelOrVelocityEnumLevel, retStr);
                            break;
                        case MikeBoundaryConditionLevelOrVelocityEnum.Velocity:
                            Assert.AreEqual(CSSPEnumsRes.MikeBoundaryConditionLevelOrVelocityEnumVelocity, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_MikeScenarioSpecialResultKMLTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_MikeScenarioSpecialResultKMLTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(MikeScenarioSpecialResultKMLTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_MikeScenarioSpecialResultKMLTypeEnum((MikeScenarioSpecialResultKMLTypeEnum)i);
        
                    switch ((MikeScenarioSpecialResultKMLTypeEnum)i)
                    {
                        case MikeScenarioSpecialResultKMLTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case MikeScenarioSpecialResultKMLTypeEnum.Mesh:
                            Assert.AreEqual(CSSPEnumsRes.MikeScenarioSpecialResultKMLTypeEnumMesh, retStr);
                            break;
                        case MikeScenarioSpecialResultKMLTypeEnum.StudyArea:
                            Assert.AreEqual(CSSPEnumsRes.MikeScenarioSpecialResultKMLTypeEnumStudyArea, retStr);
                            break;
                        case MikeScenarioSpecialResultKMLTypeEnum.BoundaryConditions:
                            Assert.AreEqual(CSSPEnumsRes.MikeScenarioSpecialResultKMLTypeEnumBoundaryConditions, retStr);
                            break;
                        case MikeScenarioSpecialResultKMLTypeEnum.PollutionLimit:
                            Assert.AreEqual(CSSPEnumsRes.MikeScenarioSpecialResultKMLTypeEnumPollutionLimit, retStr);
                            break;
                        case MikeScenarioSpecialResultKMLTypeEnum.PollutionAnimation:
                            Assert.AreEqual(CSSPEnumsRes.MikeScenarioSpecialResultKMLTypeEnumPollutionAnimation, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_MWQMSiteLatestClassificationEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_MWQMSiteLatestClassificationEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(MWQMSiteLatestClassificationEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_MWQMSiteLatestClassificationEnum((MWQMSiteLatestClassificationEnum)i);
        
                    switch ((MWQMSiteLatestClassificationEnum)i)
                    {
                        case MWQMSiteLatestClassificationEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case MWQMSiteLatestClassificationEnum.Approved:
                            Assert.AreEqual(CSSPEnumsRes.MWQMSiteLatestClassificationEnumApproved, retStr);
                            break;
                        case MWQMSiteLatestClassificationEnum.ConditionallyApproved:
                            Assert.AreEqual(CSSPEnumsRes.MWQMSiteLatestClassificationEnumConditionallyApproved, retStr);
                            break;
                        case MWQMSiteLatestClassificationEnum.Restricted:
                            Assert.AreEqual(CSSPEnumsRes.MWQMSiteLatestClassificationEnumRestricted, retStr);
                            break;
                        case MWQMSiteLatestClassificationEnum.ConditionallyRestricted:
                            Assert.AreEqual(CSSPEnumsRes.MWQMSiteLatestClassificationEnumConditionallyRestricted, retStr);
                            break;
                        case MWQMSiteLatestClassificationEnum.Prohibited:
                            Assert.AreEqual(CSSPEnumsRes.MWQMSiteLatestClassificationEnumProhibited, retStr);
                            break;
                        case MWQMSiteLatestClassificationEnum.Unclassified:
                            Assert.AreEqual(CSSPEnumsRes.MWQMSiteLatestClassificationEnumUnclassified, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_PolSourceInactiveReasonEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_PolSourceInactiveReasonEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(PolSourceInactiveReasonEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_PolSourceInactiveReasonEnum((PolSourceInactiveReasonEnum)i);
        
                    switch ((PolSourceInactiveReasonEnum)i)
                    {
                        case PolSourceInactiveReasonEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case PolSourceInactiveReasonEnum.Abandoned:
                            Assert.AreEqual(CSSPEnumsRes.PolSourceInactiveReasonEnumAbandoned, retStr);
                            break;
                        case PolSourceInactiveReasonEnum.Closed:
                            Assert.AreEqual(CSSPEnumsRes.PolSourceInactiveReasonEnumClosed, retStr);
                            break;
                        case PolSourceInactiveReasonEnum.Removed:
                            Assert.AreEqual(CSSPEnumsRes.PolSourceInactiveReasonEnumRemoved, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_PolSourceIssueRiskEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_PolSourceIssueRiskEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(PolSourceIssueRiskEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_PolSourceIssueRiskEnum((PolSourceIssueRiskEnum)i);
        
                    switch ((PolSourceIssueRiskEnum)i)
                    {
                        case PolSourceIssueRiskEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case PolSourceIssueRiskEnum.LowRisk:
                            Assert.AreEqual(CSSPEnumsRes.PolSourceIssueRiskEnumLowRisk, retStr);
                            break;
                        case PolSourceIssueRiskEnum.ModerateRisk:
                            Assert.AreEqual(CSSPEnumsRes.PolSourceIssueRiskEnumModerateRisk, retStr);
                            break;
                        case PolSourceIssueRiskEnum.HighRisk:
                            Assert.AreEqual(CSSPEnumsRes.PolSourceIssueRiskEnumHighRisk, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_PreliminaryTreatmentTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_PreliminaryTreatmentTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(PreliminaryTreatmentTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_PreliminaryTreatmentTypeEnum((PreliminaryTreatmentTypeEnum)i);
        
                    switch ((PreliminaryTreatmentTypeEnum)i)
                    {
                        case PreliminaryTreatmentTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case PreliminaryTreatmentTypeEnum.NotApplicable:
                            Assert.AreEqual(CSSPEnumsRes.PreliminaryTreatmentTypeEnumNotApplicable, retStr);
                            break;
                        case PreliminaryTreatmentTypeEnum.BarScreen:
                            Assert.AreEqual(CSSPEnumsRes.PreliminaryTreatmentTypeEnumBarScreen, retStr);
                            break;
                        case PreliminaryTreatmentTypeEnum.Grinder:
                            Assert.AreEqual(CSSPEnumsRes.PreliminaryTreatmentTypeEnumGrinder, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_PrimaryTreatmentTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_PrimaryTreatmentTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(PrimaryTreatmentTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_PrimaryTreatmentTypeEnum((PrimaryTreatmentTypeEnum)i);
        
                    switch ((PrimaryTreatmentTypeEnum)i)
                    {
                        case PrimaryTreatmentTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case PrimaryTreatmentTypeEnum.NotApplicable:
                            Assert.AreEqual(CSSPEnumsRes.PrimaryTreatmentTypeEnumNotApplicable, retStr);
                            break;
                        case PrimaryTreatmentTypeEnum.Sedimentation:
                            Assert.AreEqual(CSSPEnumsRes.PrimaryTreatmentTypeEnumSedimentation, retStr);
                            break;
                        case PrimaryTreatmentTypeEnum.ChemicalCoagulation:
                            Assert.AreEqual(CSSPEnumsRes.PrimaryTreatmentTypeEnumChemicalCoagulation, retStr);
                            break;
                        case PrimaryTreatmentTypeEnum.Filtration:
                            Assert.AreEqual(CSSPEnumsRes.PrimaryTreatmentTypeEnumFiltration, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_ReportConditionEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_ReportConditionEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(ReportConditionEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_ReportConditionEnum((ReportConditionEnum)i);
        
                    switch ((ReportConditionEnum)i)
                    {
                        case ReportConditionEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case ReportConditionEnum.ReportConditionTrue:
                            Assert.AreEqual(CSSPEnumsRes.ReportConditionEnumReportConditionTrue, retStr);
                            break;
                        case ReportConditionEnum.ReportConditionFalse:
                            Assert.AreEqual(CSSPEnumsRes.ReportConditionEnumReportConditionFalse, retStr);
                            break;
                        case ReportConditionEnum.ReportConditionContain:
                            Assert.AreEqual(CSSPEnumsRes.ReportConditionEnumReportConditionContain, retStr);
                            break;
                        case ReportConditionEnum.ReportConditionStart:
                            Assert.AreEqual(CSSPEnumsRes.ReportConditionEnumReportConditionStart, retStr);
                            break;
                        case ReportConditionEnum.ReportConditionEnd:
                            Assert.AreEqual(CSSPEnumsRes.ReportConditionEnumReportConditionEnd, retStr);
                            break;
                        case ReportConditionEnum.ReportConditionBigger:
                            Assert.AreEqual(CSSPEnumsRes.ReportConditionEnumReportConditionBigger, retStr);
                            break;
                        case ReportConditionEnum.ReportConditionSmaller:
                            Assert.AreEqual(CSSPEnumsRes.ReportConditionEnumReportConditionSmaller, retStr);
                            break;
                        case ReportConditionEnum.ReportConditionEqual:
                            Assert.AreEqual(CSSPEnumsRes.ReportConditionEnumReportConditionEqual, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_ReportFieldTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_ReportFieldTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(ReportFieldTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_ReportFieldTypeEnum((ReportFieldTypeEnum)i);
        
                    switch ((ReportFieldTypeEnum)i)
                    {
                        case ReportFieldTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case ReportFieldTypeEnum.NumberWhole:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumNumberWhole, retStr);
                            break;
                        case ReportFieldTypeEnum.NumberWithDecimal:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumNumberWithDecimal, retStr);
                            break;
                        case ReportFieldTypeEnum.DateAndTime:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumDateAndTime, retStr);
                            break;
                        case ReportFieldTypeEnum.Text:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumText, retStr);
                            break;
                        case ReportFieldTypeEnum.TrueOrFalse:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumTrueOrFalse, retStr);
                            break;
                        case ReportFieldTypeEnum.FilePurpose:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumFilePurpose, retStr);
                            break;
                        case ReportFieldTypeEnum.FileType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumFileType, retStr);
                            break;
                        case ReportFieldTypeEnum.TranslationStatus:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumTranslationStatus, retStr);
                            break;
                        case ReportFieldTypeEnum.BoxModelResultType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumBoxModelResultType, retStr);
                            break;
                        case ReportFieldTypeEnum.InfrastructureType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumInfrastructureType, retStr);
                            break;
                        case ReportFieldTypeEnum.FacilityType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumFacilityType, retStr);
                            break;
                        case ReportFieldTypeEnum.AerationType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumAerationType, retStr);
                            break;
                        case ReportFieldTypeEnum.PreliminaryTreatmentType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumPreliminaryTreatmentType, retStr);
                            break;
                        case ReportFieldTypeEnum.PrimaryTreatmentType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumPrimaryTreatmentType, retStr);
                            break;
                        case ReportFieldTypeEnum.SecondaryTreatmentType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumSecondaryTreatmentType, retStr);
                            break;
                        case ReportFieldTypeEnum.TertiaryTreatmentType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumTertiaryTreatmentType, retStr);
                            break;
                        case ReportFieldTypeEnum.TreatmentType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumTreatmentType, retStr);
                            break;
                        case ReportFieldTypeEnum.DisinfectionType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumDisinfectionType, retStr);
                            break;
                        case ReportFieldTypeEnum.CollectionSystemType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumCollectionSystemType, retStr);
                            break;
                        case ReportFieldTypeEnum.AlarmSystemType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumAlarmSystemType, retStr);
                            break;
                        case ReportFieldTypeEnum.ScenarioStatus:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumScenarioStatus, retStr);
                            break;
                        case ReportFieldTypeEnum.StorageDataType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumStorageDataType, retStr);
                            break;
                        case ReportFieldTypeEnum.Language:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumLanguage, retStr);
                            break;
                        case ReportFieldTypeEnum.SampleType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumSampleType, retStr);
                            break;
                        case ReportFieldTypeEnum.BeaufortScale:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumBeaufortScale, retStr);
                            break;
                        case ReportFieldTypeEnum.AnalyzeMethod:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumAnalyzeMethod, retStr);
                            break;
                        case ReportFieldTypeEnum.SampleMatrix:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumSampleMatrix, retStr);
                            break;
                        case ReportFieldTypeEnum.Laboratory:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumLaboratory, retStr);
                            break;
                        case ReportFieldTypeEnum.SampleStatus:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumSampleStatus, retStr);
                            break;
                        case ReportFieldTypeEnum.SamplingPlanType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumSamplingPlanType, retStr);
                            break;
                        case ReportFieldTypeEnum.LabSheetSampleType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumLabSheetSampleType, retStr);
                            break;
                        case ReportFieldTypeEnum.LabSheetType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumLabSheetType, retStr);
                            break;
                        case ReportFieldTypeEnum.LabSheetStatus:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumLabSheetStatus, retStr);
                            break;
                        case ReportFieldTypeEnum.PolSourceInactiveReason:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumPolSourceInactiveReason, retStr);
                            break;
                        case ReportFieldTypeEnum.PolSourceObsInfo:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumPolSourceObsInfo, retStr);
                            break;
                        case ReportFieldTypeEnum.AddressType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumAddressType, retStr);
                            break;
                        case ReportFieldTypeEnum.StreetType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumStreetType, retStr);
                            break;
                        case ReportFieldTypeEnum.ContactTitle:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumContactTitle, retStr);
                            break;
                        case ReportFieldTypeEnum.EmailType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumEmailType, retStr);
                            break;
                        case ReportFieldTypeEnum.TelType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumTelType, retStr);
                            break;
                        case ReportFieldTypeEnum.TideText:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumTideText, retStr);
                            break;
                        case ReportFieldTypeEnum.TideDataType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumTideDataType, retStr);
                            break;
                        case ReportFieldTypeEnum.SpecialTableType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumSpecialTableType, retStr);
                            break;
                        case ReportFieldTypeEnum.MWQMSiteLatestClassification:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumMWQMSiteLatestClassification, retStr);
                            break;
                        case ReportFieldTypeEnum.PolSourceIssueRisk:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumPolSourceIssueRisk, retStr);
                            break;
                        case ReportFieldTypeEnum.MikeScenarioSpecialResultKMLType:
                            Assert.AreEqual(CSSPEnumsRes.ReportFieldTypeEnumMikeScenarioSpecialResultKMLType, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_ReportFileTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_ReportFileTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(ReportFileTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_ReportFileTypeEnum((ReportFileTypeEnum)i);
        
                    switch ((ReportFileTypeEnum)i)
                    {
                        case ReportFileTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case ReportFileTypeEnum.CSV:
                            Assert.AreEqual(CSSPEnumsRes.ReportFileTypeEnumCSV, retStr);
                            break;
                        case ReportFileTypeEnum.Word:
                            Assert.AreEqual(CSSPEnumsRes.ReportFileTypeEnumWord, retStr);
                            break;
                        case ReportFileTypeEnum.Excel:
                            Assert.AreEqual(CSSPEnumsRes.ReportFileTypeEnumExcel, retStr);
                            break;
                        case ReportFileTypeEnum.KML:
                            Assert.AreEqual(CSSPEnumsRes.ReportFileTypeEnumKML, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_ReportFormatingDateEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_ReportFormatingDateEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(ReportFormatingDateEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_ReportFormatingDateEnum((ReportFormatingDateEnum)i);
        
                    switch ((ReportFormatingDateEnum)i)
                    {
                        case ReportFormatingDateEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case ReportFormatingDateEnum.ReportFormatingDateYearOnly:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateYearOnly, retStr);
                            break;
                        case ReportFormatingDateEnum.ReportFormatingDateMonthDecimalOnly:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateMonthDecimalOnly, retStr);
                            break;
                        case ReportFormatingDateEnum.ReportFormatingDateMonthShortTextOnly:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateMonthShortTextOnly, retStr);
                            break;
                        case ReportFormatingDateEnum.ReportFormatingDateMonthFullTextOnly:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateMonthFullTextOnly, retStr);
                            break;
                        case ReportFormatingDateEnum.ReportFormatingDateDayOnly:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateDayOnly, retStr);
                            break;
                        case ReportFormatingDateEnum.ReportFormatingDateHourOnly:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateHourOnly, retStr);
                            break;
                        case ReportFormatingDateEnum.ReportFormatingDateMinuteOnly:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateMinuteOnly, retStr);
                            break;
                        case ReportFormatingDateEnum.ReportFormatingDateYearMonthDecimalDay:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateYearMonthDecimalDay, retStr);
                            break;
                        case ReportFormatingDateEnum.ReportFormatingDateYearMonthShortTextDay:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateYearMonthShortTextDay, retStr);
                            break;
                        case ReportFormatingDateEnum.ReportFormatingDateYearMonthFullTextDay:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateYearMonthFullTextDay, retStr);
                            break;
                        case ReportFormatingDateEnum.ReportFormatingDateYearMonthDecimalDayHourMinute:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateYearMonthDecimalDayHourMinute, retStr);
                            break;
                        case ReportFormatingDateEnum.ReportFormatingDateYearMonthShortTextDayHourMinute:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateYearMonthShortTextDayHourMinute, retStr);
                            break;
                        case ReportFormatingDateEnum.ReportFormatingDateYearMonthFullTextDayHourMinute:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingDateEnumReportFormatingDateYearMonthFullTextDayHourMinute, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_ReportFormatingNumberEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_ReportFormatingNumberEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(ReportFormatingNumberEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_ReportFormatingNumberEnum((ReportFormatingNumberEnum)i);
        
                    switch ((ReportFormatingNumberEnum)i)
                    {
                        case ReportFormatingNumberEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case ReportFormatingNumberEnum.ReportFormatingNumber0Decimal:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumber0Decimal, retStr);
                            break;
                        case ReportFormatingNumberEnum.ReportFormatingNumber1Decimal:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumber1Decimal, retStr);
                            break;
                        case ReportFormatingNumberEnum.ReportFormatingNumber2Decimal:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumber2Decimal, retStr);
                            break;
                        case ReportFormatingNumberEnum.ReportFormatingNumber3Decimal:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumber3Decimal, retStr);
                            break;
                        case ReportFormatingNumberEnum.ReportFormatingNumber4Decimal:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumber4Decimal, retStr);
                            break;
                        case ReportFormatingNumberEnum.ReportFormatingNumber5Decimal:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumber5Decimal, retStr);
                            break;
                        case ReportFormatingNumberEnum.ReportFormatingNumber6Decimal:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumber6Decimal, retStr);
                            break;
                        case ReportFormatingNumberEnum.ReportFormatingNumberScientific0Decimal:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumberScientific0Decimal, retStr);
                            break;
                        case ReportFormatingNumberEnum.ReportFormatingNumberScientific1Decimal:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumberScientific1Decimal, retStr);
                            break;
                        case ReportFormatingNumberEnum.ReportFormatingNumberScientific2Decimal:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumberScientific2Decimal, retStr);
                            break;
                        case ReportFormatingNumberEnum.ReportFormatingNumberScientific3Decimal:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumberScientific3Decimal, retStr);
                            break;
                        case ReportFormatingNumberEnum.ReportFormatingNumberScientific4Decimal:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumberScientific4Decimal, retStr);
                            break;
                        case ReportFormatingNumberEnum.ReportFormatingNumberScientific5Decimal:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumberScientific5Decimal, retStr);
                            break;
                        case ReportFormatingNumberEnum.ReportFormatingNumberScientific6Decimal:
                            Assert.AreEqual(CSSPEnumsRes.ReportFormatingNumberEnumReportFormatingNumberScientific6Decimal, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_ReportSortingEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_ReportSortingEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(ReportSortingEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_ReportSortingEnum((ReportSortingEnum)i);
        
                    switch ((ReportSortingEnum)i)
                    {
                        case ReportSortingEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case ReportSortingEnum.ReportSortingAscending:
                            Assert.AreEqual(CSSPEnumsRes.ReportSortingEnumReportSortingAscending, retStr);
                            break;
                        case ReportSortingEnum.ReportSortingDescending:
                            Assert.AreEqual(CSSPEnumsRes.ReportSortingEnumReportSortingDescending, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_ReportTreeNodeSubTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_ReportTreeNodeSubTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(ReportTreeNodeSubTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_ReportTreeNodeSubTypeEnum((ReportTreeNodeSubTypeEnum)i);
        
                    switch ((ReportTreeNodeSubTypeEnum)i)
                    {
                        case ReportTreeNodeSubTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case ReportTreeNodeSubTypeEnum.TableSelectable:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeSubTypeEnumTableSelectable, retStr);
                            break;
                        case ReportTreeNodeSubTypeEnum.Field:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeSubTypeEnumField, retStr);
                            break;
                        case ReportTreeNodeSubTypeEnum.FieldsHolder:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeSubTypeEnumFieldsHolder, retStr);
                            break;
                        case ReportTreeNodeSubTypeEnum.TableNotSelectable:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeSubTypeEnumTableNotSelectable, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_ReportTreeNodeTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_ReportTreeNodeTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(ReportTreeNodeTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_ReportTreeNodeTypeEnum((ReportTreeNodeTypeEnum)i);
        
                    switch ((ReportTreeNodeTypeEnum)i)
                    {
                        case ReportTreeNodeTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportRootType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportRootType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportCountryType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportCountryType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportProvinceType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportProvinceType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportAreaType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportAreaType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSectorType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSectorType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSubsectorType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMWQMSiteType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMSiteType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMWQMRunType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMRunType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportPolSourceSiteType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportPolSourceSiteType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMunicipalityType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMunicipalityType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportRootFileType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportRootFileType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportInfrastructureType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportInfrastructureType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportBoxModelType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportBoxModelType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportVisualPlumesScenarioType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportVisualPlumesScenarioType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMikeScenarioType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMikeScenarioType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMikeSourceType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMikeSourceType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMWQMSiteSampleType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMSiteSampleType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportPolSourceSiteObsType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportPolSourceSiteObsType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportPolSourceSiteObsIssueType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportPolSourceSiteObsIssueType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMikeScenarioGeneralParameterType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMikeScenarioGeneralParameterType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMunicipalityContactType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMunicipalityContactType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportConditionType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportConditionType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportStatisticType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportStatisticType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportFieldsType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportFieldsType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportFieldType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportFieldType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportPolSourceSiteAddressType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportPolSourceSiteAddressType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMunicipalityContactTelType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMunicipalityContactTelType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMunicipalityContactEmailType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMunicipalityContactEmailType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportBoxModelResultType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportBoxModelResultType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportClimateSiteType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportClimateSiteType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportClimateSiteDataType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportClimateSiteDataType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportHydrometricSiteType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportHydrometricSiteType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportHydrometricSiteDataType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportHydrometricSiteDataType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportHydrometricSiteRatingCurveType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportHydrometricSiteRatingCurveType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportHydrometricSiteRatingCurveValueType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportHydrometricSiteRatingCurveValueType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportInfrastructureAddressType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportInfrastructureAddressType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSubsectorLabSheetType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorLabSheetType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSubsectorLabSheetDetailType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorLabSheetDetailType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSubsectorLabSheetTubeMPNDetailType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorLabSheetTubeMPNDetailType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMWQMRunSampleType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMRunSampleType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportCountryFileType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportCountryFileType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportProvinceFileType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportProvinceFileType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportAreaFileType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportAreaFileType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSectorFileType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSectorFileType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSubsectorFileType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorFileType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMWQMSiteFileType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMSiteFileType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMWQMRunFileType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMRunFileType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportPolSourceSiteFileType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportPolSourceSiteFileType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMunicipalityFileType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMunicipalityFileType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportInfrastructureFileType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportInfrastructureFileType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMikeScenarioFileType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMikeScenarioFileType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMikeSourceStartEndType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMikeSourceStartEndType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMWQMRunLabSheetType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMRunLabSheetType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMWQMRunLabSheetDetailType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMRunLabSheetDetailType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMWQMRunLabSheetTubeMPNDetailType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMRunLabSheetTubeMPNDetailType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSamplingPlanLabSheetType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSamplingPlanLabSheetType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSamplingPlanLabSheetDetailType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSamplingPlanLabSheetDetailType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSamplingPlanLabSheetTubeMPNDetailType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSamplingPlanLabSheetTubeMPNDetailType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSamplingPlanType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSamplingPlanType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSamplingPlanSubsectorType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSamplingPlanSubsectorType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSamplingPlanSubsectorSiteType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSamplingPlanSubsectorSiteType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMikeBoundaryConditionType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMikeBoundaryConditionType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportVisualPlumesScenarioAmbientType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportVisualPlumesScenarioAmbientType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportVisualPlumesScenarioResultType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportVisualPlumesScenarioResultType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMPNLookupType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMPNLookupType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMWQMSiteStartAndEndType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMWQMSiteStartAndEndType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSubsectorTideSiteType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorTideSiteType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSubsectorTideSiteDataType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorTideSiteDataType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportOrderType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportOrderType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportFormatType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportFormatType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMunicipalityContactAddressType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMunicipalityContactAddressType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSubsectorClimateSiteType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorClimateSiteType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSubsectorHydrometricSiteType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorHydrometricSiteType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSubsectorHydrometricSiteDataType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorHydrometricSiteDataType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSubsectorHydrometricSiteRatingCurveType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorHydrometricSiteRatingCurveType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSubsectorClimateSiteDataType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorClimateSiteDataType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSubsectorHydrometricSiteRatingCurveValueType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorHydrometricSiteRatingCurveValueType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportSubsectorSpecialTableType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportSubsectorSpecialTableType, retStr);
                            break;
                        case ReportTreeNodeTypeEnum.ReportMikeScenarioSpecialResultKMLType:
                            Assert.AreEqual(CSSPEnumsRes.ReportTreeNodeTypeEnumReportMikeScenarioSpecialResultKMLType, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_SameDayNextDayEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_SameDayNextDayEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(SameDayNextDayEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_SameDayNextDayEnum((SameDayNextDayEnum)i);
        
                    switch ((SameDayNextDayEnum)i)
                    {
                        case SameDayNextDayEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case SameDayNextDayEnum.SameDay:
                            Assert.AreEqual(CSSPEnumsRes.SameDayNextDayEnumSameDay, retStr);
                            break;
                        case SameDayNextDayEnum.NextDay:
                            Assert.AreEqual(CSSPEnumsRes.SameDayNextDayEnumNextDay, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_SampleMatrixEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_SampleMatrixEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(SampleMatrixEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_SampleMatrixEnum((SampleMatrixEnum)i);
        
                    switch ((SampleMatrixEnum)i)
                    {
                        case SampleMatrixEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case SampleMatrixEnum.W:
                            Assert.AreEqual(CSSPEnumsRes.SampleMatrixEnumW, retStr);
                            break;
                        case SampleMatrixEnum.S:
                            Assert.AreEqual(CSSPEnumsRes.SampleMatrixEnumS, retStr);
                            break;
                        case SampleMatrixEnum.B:
                            Assert.AreEqual(CSSPEnumsRes.SampleMatrixEnumB, retStr);
                            break;
                        case SampleMatrixEnum.MPNQ:
                            Assert.AreEqual(CSSPEnumsRes.SampleMatrixEnumMPNQ, retStr);
                            break;
                        case SampleMatrixEnum.SampleMatrix5:
                            Assert.AreEqual(CSSPEnumsRes.SampleMatrixEnumSampleMatrix5, retStr);
                            break;
                        case SampleMatrixEnum.SampleMatrix6:
                            Assert.AreEqual(CSSPEnumsRes.SampleMatrixEnumSampleMatrix6, retStr);
                            break;
                        case SampleMatrixEnum.Water:
                            Assert.AreEqual(CSSPEnumsRes.SampleMatrixEnumWater, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_SampleStatusEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_SampleStatusEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(SampleStatusEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_SampleStatusEnum((SampleStatusEnum)i);
        
                    switch ((SampleStatusEnum)i)
                    {
                        case SampleStatusEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case SampleStatusEnum.Active:
                            Assert.AreEqual(CSSPEnumsRes.SampleStatusEnumActive, retStr);
                            break;
                        case SampleStatusEnum.Archived:
                            Assert.AreEqual(CSSPEnumsRes.SampleStatusEnumArchived, retStr);
                            break;
                        case SampleStatusEnum.SampleStatus3:
                            Assert.AreEqual(CSSPEnumsRes.SampleStatusEnumSampleStatus3, retStr);
                            break;
                        case SampleStatusEnum.SampleStatus4:
                            Assert.AreEqual(CSSPEnumsRes.SampleStatusEnumSampleStatus4, retStr);
                            break;
                        case SampleStatusEnum.SampleStatus5:
                            Assert.AreEqual(CSSPEnumsRes.SampleStatusEnumSampleStatus5, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_SampleTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_SampleTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(SampleTypeEnum)).Length + 101; i < count; i++)
                {
                    retStr = enums.GetEnumText_SampleTypeEnum((SampleTypeEnum)i);
        
                    switch ((SampleTypeEnum)i)
                    {
                        case SampleTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case SampleTypeEnum.DailyDuplicate:
                            Assert.AreEqual(CSSPEnumsRes.SampleTypeEnumDailyDuplicate, retStr);
                            break;
                        case SampleTypeEnum.Infrastructure:
                            Assert.AreEqual(CSSPEnumsRes.SampleTypeEnumInfrastructure, retStr);
                            break;
                        case SampleTypeEnum.IntertechDuplicate:
                            Assert.AreEqual(CSSPEnumsRes.SampleTypeEnumIntertechDuplicate, retStr);
                            break;
                        case SampleTypeEnum.IntertechRead:
                            Assert.AreEqual(CSSPEnumsRes.SampleTypeEnumIntertechRead, retStr);
                            break;
                        case SampleTypeEnum.RainCMPRoutine:
                            Assert.AreEqual(CSSPEnumsRes.SampleTypeEnumRainCMPRoutine, retStr);
                            break;
                        case SampleTypeEnum.RainRun:
                            Assert.AreEqual(CSSPEnumsRes.SampleTypeEnumRainRun, retStr);
                            break;
                        case SampleTypeEnum.ReopeningEmergencyRain:
                            Assert.AreEqual(CSSPEnumsRes.SampleTypeEnumReopeningEmergencyRain, retStr);
                            break;
                        case SampleTypeEnum.ReopeningSpill:
                            Assert.AreEqual(CSSPEnumsRes.SampleTypeEnumReopeningSpill, retStr);
                            break;
                        case SampleTypeEnum.Routine:
                            Assert.AreEqual(CSSPEnumsRes.SampleTypeEnumRoutine, retStr);
                            break;
                        case SampleTypeEnum.Sanitary:
                            Assert.AreEqual(CSSPEnumsRes.SampleTypeEnumSanitary, retStr);
                            break;
                        case SampleTypeEnum.Study:
                            Assert.AreEqual(CSSPEnumsRes.SampleTypeEnumStudy, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                    if (i == 0)
                    {
                        i = 100;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_SamplingPlanTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_SamplingPlanTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(SamplingPlanTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_SamplingPlanTypeEnum((SamplingPlanTypeEnum)i);
        
                    switch ((SamplingPlanTypeEnum)i)
                    {
                        case SamplingPlanTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case SamplingPlanTypeEnum.Subsector:
                            Assert.AreEqual(CSSPEnumsRes.SamplingPlanTypeEnumSubsector, retStr);
                            break;
                        case SamplingPlanTypeEnum.Municipality:
                            Assert.AreEqual(CSSPEnumsRes.SamplingPlanTypeEnumMunicipality, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_ScenarioStatusEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_ScenarioStatusEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(ScenarioStatusEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_ScenarioStatusEnum((ScenarioStatusEnum)i);
        
                    switch ((ScenarioStatusEnum)i)
                    {
                        case ScenarioStatusEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case ScenarioStatusEnum.Normal:
                            Assert.AreEqual(CSSPEnumsRes.ScenarioStatusEnumNormal, retStr);
                            break;
                        case ScenarioStatusEnum.Copying:
                            Assert.AreEqual(CSSPEnumsRes.ScenarioStatusEnumCopying, retStr);
                            break;
                        case ScenarioStatusEnum.Copied:
                            Assert.AreEqual(CSSPEnumsRes.ScenarioStatusEnumCopied, retStr);
                            break;
                        case ScenarioStatusEnum.Changing:
                            Assert.AreEqual(CSSPEnumsRes.ScenarioStatusEnumChanging, retStr);
                            break;
                        case ScenarioStatusEnum.Changed:
                            Assert.AreEqual(CSSPEnumsRes.ScenarioStatusEnumChanged, retStr);
                            break;
                        case ScenarioStatusEnum.AskToRun:
                            Assert.AreEqual(CSSPEnumsRes.ScenarioStatusEnumAskToRun, retStr);
                            break;
                        case ScenarioStatusEnum.Running:
                            Assert.AreEqual(CSSPEnumsRes.ScenarioStatusEnumRunning, retStr);
                            break;
                        case ScenarioStatusEnum.Completed:
                            Assert.AreEqual(CSSPEnumsRes.ScenarioStatusEnumCompleted, retStr);
                            break;
                        case ScenarioStatusEnum.Cancelled:
                            Assert.AreEqual(CSSPEnumsRes.ScenarioStatusEnumCancelled, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_SearchTagEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_SearchTagEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(SearchTagEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_SearchTagEnum((SearchTagEnum)i);
        
                    switch ((SearchTagEnum)i)
                    {
                        case SearchTagEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case SearchTagEnum.c:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumc, retStr);
                            break;
                        case SearchTagEnum.e:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnume, retStr);
                            break;
                        case SearchTagEnum.t:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumt, retStr);
                            break;
                        case SearchTagEnum.fi:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfi, retStr);
                            break;
                        case SearchTagEnum.fp:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfp, retStr);
                            break;
                        case SearchTagEnum.fr:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfr, retStr);
                            break;
                        case SearchTagEnum.fg:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfg, retStr);
                            break;
                        case SearchTagEnum.fpdf:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfpdf, retStr);
                            break;
                        case SearchTagEnum.fdocx:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfdocx, retStr);
                            break;
                        case SearchTagEnum.fxlsx:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfxlsx, retStr);
                            break;
                        case SearchTagEnum.fkmz:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfkmz, retStr);
                            break;
                        case SearchTagEnum.fxyz:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfxyz, retStr);
                            break;
                        case SearchTagEnum.fdfs:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfdfs, retStr);
                            break;
                        case SearchTagEnum.fmike:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfmike, retStr);
                            break;
                        case SearchTagEnum.fmdf:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfmdf, retStr);
                            break;
                        case SearchTagEnum.fm21fm:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfm21fm, retStr);
                            break;
                        case SearchTagEnum.fm3fm:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfm3fm, retStr);
                            break;
                        case SearchTagEnum.fmesh:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfmesh, retStr);
                            break;
                        case SearchTagEnum.flog:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumflog, retStr);
                            break;
                        case SearchTagEnum.ftxt:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumftxt, retStr);
                            break;
                        case SearchTagEnum.m:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumm, retStr);
                            break;
                        case SearchTagEnum.p:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnump, retStr);
                            break;
                        case SearchTagEnum.ms:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumms, retStr);
                            break;
                        case SearchTagEnum.cs:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumcs, retStr);
                            break;
                        case SearchTagEnum.hs:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumhs, retStr);
                            break;
                        case SearchTagEnum.ts:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumts, retStr);
                            break;
                        case SearchTagEnum.ww:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumww, retStr);
                            break;
                        case SearchTagEnum.ls:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumls, retStr);
                            break;
                        case SearchTagEnum.st:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumst, retStr);
                            break;
                        case SearchTagEnum.ps:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumps, retStr);
                            break;
                        case SearchTagEnum.a:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnuma, retStr);
                            break;
                        case SearchTagEnum.s:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnums, retStr);
                            break;
                        case SearchTagEnum.ss:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumss, retStr);
                            break;
                        case SearchTagEnum.u:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumu, retStr);
                            break;
                        case SearchTagEnum.notag:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumnotag, retStr);
                            break;
                        case SearchTagEnum.fcsv:
                            Assert.AreEqual(CSSPEnumsRes.SearchTagEnumfcsv, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_SecondaryTreatmentTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_SecondaryTreatmentTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(SecondaryTreatmentTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_SecondaryTreatmentTypeEnum((SecondaryTreatmentTypeEnum)i);
        
                    switch ((SecondaryTreatmentTypeEnum)i)
                    {
                        case SecondaryTreatmentTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case SecondaryTreatmentTypeEnum.NotApplicable:
                            Assert.AreEqual(CSSPEnumsRes.SecondaryTreatmentTypeEnumNotApplicable, retStr);
                            break;
                        case SecondaryTreatmentTypeEnum.RotatingBiologicalContactor:
                            Assert.AreEqual(CSSPEnumsRes.SecondaryTreatmentTypeEnumRotatingBiologicalContactor, retStr);
                            break;
                        case SecondaryTreatmentTypeEnum.TricklingFilters:
                            Assert.AreEqual(CSSPEnumsRes.SecondaryTreatmentTypeEnumTricklingFilters, retStr);
                            break;
                        case SecondaryTreatmentTypeEnum.SequencingBatchReator:
                            Assert.AreEqual(CSSPEnumsRes.SecondaryTreatmentTypeEnumSequencingBatchReator, retStr);
                            break;
                        case SecondaryTreatmentTypeEnum.OxidationDitch:
                            Assert.AreEqual(CSSPEnumsRes.SecondaryTreatmentTypeEnumOxidationDitch, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_SiteTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_SiteTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(SiteTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_SiteTypeEnum((SiteTypeEnum)i);
        
                    switch ((SiteTypeEnum)i)
                    {
                        case SiteTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case SiteTypeEnum.Climate:
                            Assert.AreEqual(CSSPEnumsRes.SiteTypeEnumClimate, retStr);
                            break;
                        case SiteTypeEnum.Hydrometric:
                            Assert.AreEqual(CSSPEnumsRes.SiteTypeEnumHydrometric, retStr);
                            break;
                        case SiteTypeEnum.Tide:
                            Assert.AreEqual(CSSPEnumsRes.SiteTypeEnumTide, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_SpecialTableTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_SpecialTableTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(SpecialTableTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_SpecialTableTypeEnum((SpecialTableTypeEnum)i);
        
                    switch ((SpecialTableTypeEnum)i)
                    {
                        case SpecialTableTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case SpecialTableTypeEnum.FCDensitiesTable:
                            Assert.AreEqual(CSSPEnumsRes.SpecialTableTypeEnumFCDensitiesTable, retStr);
                            break;
                        case SpecialTableTypeEnum.SalinityTable:
                            Assert.AreEqual(CSSPEnumsRes.SpecialTableTypeEnumSalinityTable, retStr);
                            break;
                        case SpecialTableTypeEnum.TemperatureTable:
                            Assert.AreEqual(CSSPEnumsRes.SpecialTableTypeEnumTemperatureTable, retStr);
                            break;
                        case SpecialTableTypeEnum.GeometricMeanTable:
                            Assert.AreEqual(CSSPEnumsRes.SpecialTableTypeEnumGeometricMeanTable, retStr);
                            break;
                        case SpecialTableTypeEnum.MedianTable:
                            Assert.AreEqual(CSSPEnumsRes.SpecialTableTypeEnumMedianTable, retStr);
                            break;
                        case SpecialTableTypeEnum.P90Table:
                            Assert.AreEqual(CSSPEnumsRes.SpecialTableTypeEnumP90Table, retStr);
                            break;
                        case SpecialTableTypeEnum.PercentOver43Table:
                            Assert.AreEqual(CSSPEnumsRes.SpecialTableTypeEnumPercentOver43Table, retStr);
                            break;
                        case SpecialTableTypeEnum.PercentOver260Table:
                            Assert.AreEqual(CSSPEnumsRes.SpecialTableTypeEnumPercentOver260Table, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_StorageDataTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_StorageDataTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(StorageDataTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_StorageDataTypeEnum((StorageDataTypeEnum)i);
        
                    switch ((StorageDataTypeEnum)i)
                    {
                        case StorageDataTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case StorageDataTypeEnum.Archived:
                            Assert.AreEqual(CSSPEnumsRes.StorageDataTypeEnumArchived, retStr);
                            break;
                        case StorageDataTypeEnum.Forcasted:
                            Assert.AreEqual(CSSPEnumsRes.StorageDataTypeEnumForcasted, retStr);
                            break;
                        case StorageDataTypeEnum.Observed:
                            Assert.AreEqual(CSSPEnumsRes.StorageDataTypeEnumObserved, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_StreetTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_StreetTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(StreetTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_StreetTypeEnum((StreetTypeEnum)i);
        
                    switch ((StreetTypeEnum)i)
                    {
                        case StreetTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case StreetTypeEnum.Street:
                            Assert.AreEqual(CSSPEnumsRes.StreetTypeEnumStreet, retStr);
                            break;
                        case StreetTypeEnum.Road:
                            Assert.AreEqual(CSSPEnumsRes.StreetTypeEnumRoad, retStr);
                            break;
                        case StreetTypeEnum.Avenue:
                            Assert.AreEqual(CSSPEnumsRes.StreetTypeEnumAvenue, retStr);
                            break;
                        case StreetTypeEnum.Crescent:
                            Assert.AreEqual(CSSPEnumsRes.StreetTypeEnumCrescent, retStr);
                            break;
                        case StreetTypeEnum.Court:
                            Assert.AreEqual(CSSPEnumsRes.StreetTypeEnumCourt, retStr);
                            break;
                        case StreetTypeEnum.Alley:
                            Assert.AreEqual(CSSPEnumsRes.StreetTypeEnumAlley, retStr);
                            break;
                        case StreetTypeEnum.Drive:
                            Assert.AreEqual(CSSPEnumsRes.StreetTypeEnumDrive, retStr);
                            break;
                        case StreetTypeEnum.Blvd:
                            Assert.AreEqual(CSSPEnumsRes.StreetTypeEnumBlvd, retStr);
                            break;
                        case StreetTypeEnum.Route:
                            Assert.AreEqual(CSSPEnumsRes.StreetTypeEnumRoute, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_TelTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_TelTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(TelTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_TelTypeEnum((TelTypeEnum)i);
        
                    switch ((TelTypeEnum)i)
                    {
                        case TelTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case TelTypeEnum.Personal:
                            Assert.AreEqual(CSSPEnumsRes.TelTypeEnumPersonal, retStr);
                            break;
                        case TelTypeEnum.Work:
                            Assert.AreEqual(CSSPEnumsRes.TelTypeEnumWork, retStr);
                            break;
                        case TelTypeEnum.Mobile:
                            Assert.AreEqual(CSSPEnumsRes.TelTypeEnumMobile, retStr);
                            break;
                        case TelTypeEnum.Personal2:
                            Assert.AreEqual(CSSPEnumsRes.TelTypeEnumPersonal2, retStr);
                            break;
                        case TelTypeEnum.Work2:
                            Assert.AreEqual(CSSPEnumsRes.TelTypeEnumWork2, retStr);
                            break;
                        case TelTypeEnum.Mobile2:
                            Assert.AreEqual(CSSPEnumsRes.TelTypeEnumMobile2, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_TertiaryTreatmentTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_TertiaryTreatmentTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(TertiaryTreatmentTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_TertiaryTreatmentTypeEnum((TertiaryTreatmentTypeEnum)i);
        
                    switch ((TertiaryTreatmentTypeEnum)i)
                    {
                        case TertiaryTreatmentTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case TertiaryTreatmentTypeEnum.NotApplicable:
                            Assert.AreEqual(CSSPEnumsRes.TertiaryTreatmentTypeEnumNotApplicable, retStr);
                            break;
                        case TertiaryTreatmentTypeEnum.Adsorption:
                            Assert.AreEqual(CSSPEnumsRes.TertiaryTreatmentTypeEnumAdsorption, retStr);
                            break;
                        case TertiaryTreatmentTypeEnum.Flocculation:
                            Assert.AreEqual(CSSPEnumsRes.TertiaryTreatmentTypeEnumFlocculation, retStr);
                            break;
                        case TertiaryTreatmentTypeEnum.MembraneFiltration:
                            Assert.AreEqual(CSSPEnumsRes.TertiaryTreatmentTypeEnumMembraneFiltration, retStr);
                            break;
                        case TertiaryTreatmentTypeEnum.IonExchange:
                            Assert.AreEqual(CSSPEnumsRes.TertiaryTreatmentTypeEnumIonExchange, retStr);
                            break;
                        case TertiaryTreatmentTypeEnum.ReverseOsmosis:
                            Assert.AreEqual(CSSPEnumsRes.TertiaryTreatmentTypeEnumReverseOsmosis, retStr);
                            break;
                        case TertiaryTreatmentTypeEnum.BiologicalNutrientRemoval:
                            Assert.AreEqual(CSSPEnumsRes.TertiaryTreatmentTypeEnumBiologicalNutrientRemoval, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_TideDataTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_TideDataTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(TideDataTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_TideDataTypeEnum((TideDataTypeEnum)i);
        
                    switch ((TideDataTypeEnum)i)
                    {
                        case TideDataTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case TideDataTypeEnum.Min15:
                            Assert.AreEqual(CSSPEnumsRes.TideDataTypeEnumMin15, retStr);
                            break;
                        case TideDataTypeEnum.Min60:
                            Assert.AreEqual(CSSPEnumsRes.TideDataTypeEnumMin60, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_TideTextEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_TideTextEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(TideTextEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_TideTextEnum((TideTextEnum)i);
        
                    switch ((TideTextEnum)i)
                    {
                        case TideTextEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case TideTextEnum.LowTide:
                            Assert.AreEqual(CSSPEnumsRes.TideTextEnumLowTide, retStr);
                            break;
                        case TideTextEnum.LowTideFalling:
                            Assert.AreEqual(CSSPEnumsRes.TideTextEnumLowTideFalling, retStr);
                            break;
                        case TideTextEnum.LowTideRising:
                            Assert.AreEqual(CSSPEnumsRes.TideTextEnumLowTideRising, retStr);
                            break;
                        case TideTextEnum.MidTide:
                            Assert.AreEqual(CSSPEnumsRes.TideTextEnumMidTide, retStr);
                            break;
                        case TideTextEnum.MidTideFalling:
                            Assert.AreEqual(CSSPEnumsRes.TideTextEnumMidTideFalling, retStr);
                            break;
                        case TideTextEnum.MidTideRising:
                            Assert.AreEqual(CSSPEnumsRes.TideTextEnumMidTideRising, retStr);
                            break;
                        case TideTextEnum.HighTide:
                            Assert.AreEqual(CSSPEnumsRes.TideTextEnumHighTide, retStr);
                            break;
                        case TideTextEnum.HighTideFalling:
                            Assert.AreEqual(CSSPEnumsRes.TideTextEnumHighTideFalling, retStr);
                            break;
                        case TideTextEnum.HighTideRising:
                            Assert.AreEqual(CSSPEnumsRes.TideTextEnumHighTideRising, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_TranslationStatusEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_TranslationStatusEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(TranslationStatusEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_TranslationStatusEnum((TranslationStatusEnum)i);
        
                    switch ((TranslationStatusEnum)i)
                    {
                        case TranslationStatusEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case TranslationStatusEnum.NotTranslated:
                            Assert.AreEqual(CSSPEnumsRes.TranslationStatusEnumNotTranslated, retStr);
                            break;
                        case TranslationStatusEnum.ElectronicallyTranslated:
                            Assert.AreEqual(CSSPEnumsRes.TranslationStatusEnumElectronicallyTranslated, retStr);
                            break;
                        case TranslationStatusEnum.Translated:
                            Assert.AreEqual(CSSPEnumsRes.TranslationStatusEnumTranslated, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_TreatmentTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_TreatmentTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(TreatmentTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_TreatmentTypeEnum((TreatmentTypeEnum)i);
        
                    switch ((TreatmentTypeEnum)i)
                    {
                        case TreatmentTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case TreatmentTypeEnum.ActivatedSludge:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumActivatedSludge, retStr);
                            break;
                        case TreatmentTypeEnum.ActivatedSludgeWithBiofilter:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumActivatedSludgeWithBiofilter, retStr);
                            break;
                        case TreatmentTypeEnum.LagoonNoAeration1Cell:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumLagoonNoAeration1Cell, retStr);
                            break;
                        case TreatmentTypeEnum.LagoonNoAeration2Cell:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumLagoonNoAeration2Cell, retStr);
                            break;
                        case TreatmentTypeEnum.LagoonNoAeration3Cell:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumLagoonNoAeration3Cell, retStr);
                            break;
                        case TreatmentTypeEnum.LagoonNoAeration4Cell:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumLagoonNoAeration4Cell, retStr);
                            break;
                        case TreatmentTypeEnum.LagoonNoAeration5Cell:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumLagoonNoAeration5Cell, retStr);
                            break;
                        case TreatmentTypeEnum.LagoonWithAeration1Cell:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumLagoonWithAeration1Cell, retStr);
                            break;
                        case TreatmentTypeEnum.LagoonWithAeration2Cell:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumLagoonWithAeration2Cell, retStr);
                            break;
                        case TreatmentTypeEnum.LagoonWithAeration3Cell:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumLagoonWithAeration3Cell, retStr);
                            break;
                        case TreatmentTypeEnum.LagoonWithAeration4Cell:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumLagoonWithAeration4Cell, retStr);
                            break;
                        case TreatmentTypeEnum.LagoonWithAeration5Cell:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumLagoonWithAeration5Cell, retStr);
                            break;
                        case TreatmentTypeEnum.LagoonWithAeration6Cell:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumLagoonWithAeration6Cell, retStr);
                            break;
                        case TreatmentTypeEnum.StabalizingPondOnly:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumStabalizingPondOnly, retStr);
                            break;
                        case TreatmentTypeEnum.OxidationDitchOnly:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumOxidationDitchOnly, retStr);
                            break;
                        case TreatmentTypeEnum.CirculatingFluidizedBed:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumCirculatingFluidizedBed, retStr);
                            break;
                        case TreatmentTypeEnum.TricklingFilter:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumTricklingFilter, retStr);
                            break;
                        case TreatmentTypeEnum.RecirculatingSandFilter:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumRecirculatingSandFilter, retStr);
                            break;
                        case TreatmentTypeEnum.TrashRackRakeOnly:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumTrashRackRakeOnly, retStr);
                            break;
                        case TreatmentTypeEnum.SepticTank:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumSepticTank, retStr);
                            break;
                        case TreatmentTypeEnum.Secondary:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumSecondary, retStr);
                            break;
                        case TreatmentTypeEnum.Tertiary:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumTertiary, retStr);
                            break;
                        case TreatmentTypeEnum.VolumeFermenter:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumVolumeFermenter, retStr);
                            break;
                        case TreatmentTypeEnum.BioFilmReactor:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumBioFilmReactor, retStr);
                            break;
                        case TreatmentTypeEnum.BioGreen:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumBioGreen, retStr);
                            break;
                        case TreatmentTypeEnum.BioDisks:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumBioDisks, retStr);
                            break;
                        case TreatmentTypeEnum.ChemicalPrimary:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumChemicalPrimary, retStr);
                            break;
                        case TreatmentTypeEnum.Chromoglass:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumChromoglass, retStr);
                            break;
                        case TreatmentTypeEnum.Primary:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumPrimary, retStr);
                            break;
                        case TreatmentTypeEnum.SequencingBatchReactor:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumSequencingBatchReactor, retStr);
                            break;
                        case TreatmentTypeEnum.PeatSystem:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumPeatSystem, retStr);
                            break;
                        case TreatmentTypeEnum.Physicochimique:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumPhysicochimique, retStr);
                            break;
                        case TreatmentTypeEnum.RotatingBiologicalContactor:
                            Assert.AreEqual(CSSPEnumsRes.TreatmentTypeEnumRotatingBiologicalContactor, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_TVAuthEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_TVAuthEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(TVAuthEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_TVAuthEnum((TVAuthEnum)i);
        
                    switch ((TVAuthEnum)i)
                    {
                        case TVAuthEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case TVAuthEnum.NoAccess:
                            Assert.AreEqual(CSSPEnumsRes.TVAuthEnumNoAccess, retStr);
                            break;
                        case TVAuthEnum.Read:
                            Assert.AreEqual(CSSPEnumsRes.TVAuthEnumRead, retStr);
                            break;
                        case TVAuthEnum.Write:
                            Assert.AreEqual(CSSPEnumsRes.TVAuthEnumWrite, retStr);
                            break;
                        case TVAuthEnum.Create:
                            Assert.AreEqual(CSSPEnumsRes.TVAuthEnumCreate, retStr);
                            break;
                        case TVAuthEnum.Delete:
                            Assert.AreEqual(CSSPEnumsRes.TVAuthEnumDelete, retStr);
                            break;
                        case TVAuthEnum.Admin:
                            Assert.AreEqual(CSSPEnumsRes.TVAuthEnumAdmin, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_TVTypeEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_TVTypeEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(TVTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_TVTypeEnum((TVTypeEnum)i);
        
                    switch ((TVTypeEnum)i)
                    {
                        case TVTypeEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case TVTypeEnum.Root:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumRoot, retStr);
                            break;
                        case TVTypeEnum.Address:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumAddress, retStr);
                            break;
                        case TVTypeEnum.Area:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumArea, retStr);
                            break;
                        case TVTypeEnum.ClimateSite:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumClimateSite, retStr);
                            break;
                        case TVTypeEnum.Contact:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumContact, retStr);
                            break;
                        case TVTypeEnum.Country:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumCountry, retStr);
                            break;
                        case TVTypeEnum.Email:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumEmail, retStr);
                            break;
                        case TVTypeEnum.File:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumFile, retStr);
                            break;
                        case TVTypeEnum.HydrometricSite:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumHydrometricSite, retStr);
                            break;
                        case TVTypeEnum.Infrastructure:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumInfrastructure, retStr);
                            break;
                        case TVTypeEnum.MikeBoundaryConditionWebTide:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMikeBoundaryConditionWebTide, retStr);
                            break;
                        case TVTypeEnum.MikeBoundaryConditionMesh:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMikeBoundaryConditionMesh, retStr);
                            break;
                        case TVTypeEnum.MikeScenario:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMikeScenario, retStr);
                            break;
                        case TVTypeEnum.MikeSource:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMikeSource, retStr);
                            break;
                        case TVTypeEnum.Municipality:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMunicipality, retStr);
                            break;
                        case TVTypeEnum.MWQMSite:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMWQMSite, retStr);
                            break;
                        case TVTypeEnum.PolSourceSite:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumPolSourceSite, retStr);
                            break;
                        case TVTypeEnum.Province:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumProvince, retStr);
                            break;
                        case TVTypeEnum.Sector:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumSector, retStr);
                            break;
                        case TVTypeEnum.Subsector:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumSubsector, retStr);
                            break;
                        case TVTypeEnum.Tel:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumTel, retStr);
                            break;
                        case TVTypeEnum.TideSite:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumTideSite, retStr);
                            break;
                        case TVTypeEnum.MWQMSiteSample:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMWQMSiteSample, retStr);
                            break;
                        case TVTypeEnum.WasteWaterTreatmentPlant:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumWasteWaterTreatmentPlant, retStr);
                            break;
                        case TVTypeEnum.LiftStation:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumLiftStation, retStr);
                            break;
                        case TVTypeEnum.Spill:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumSpill, retStr);
                            break;
                        case TVTypeEnum.BoxModel:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumBoxModel, retStr);
                            break;
                        case TVTypeEnum.VisualPlumesScenario:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumVisualPlumesScenario, retStr);
                            break;
                        case TVTypeEnum.Outfall:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumOutfall, retStr);
                            break;
                        case TVTypeEnum.OtherInfrastructure:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumOtherInfrastructure, retStr);
                            break;
                        case TVTypeEnum.MWQMRun:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMWQMRun, retStr);
                            break;
                        case TVTypeEnum.NoDepuration:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumNoDepuration, retStr);
                            break;
                        case TVTypeEnum.Failed:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumFailed, retStr);
                            break;
                        case TVTypeEnum.Passed:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumPassed, retStr);
                            break;
                        case TVTypeEnum.NoData:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumNoData, retStr);
                            break;
                        case TVTypeEnum.LessThan10:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumLessThan10, retStr);
                            break;
                        case TVTypeEnum.MeshNode:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMeshNode, retStr);
                            break;
                        case TVTypeEnum.WebTideNode:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumWebTideNode, retStr);
                            break;
                        case TVTypeEnum.SamplingPlan:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumSamplingPlan, retStr);
                            break;
                        case TVTypeEnum.SeeOther:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumSeeOther, retStr);
                            break;
                        case TVTypeEnum.LineOverflow:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumLineOverflow, retStr);
                            break;
                        case TVTypeEnum.BoxModelInputs:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumBoxModelInputs, retStr);
                            break;
                        case TVTypeEnum.BoxModelResults:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumBoxModelResults, retStr);
                            break;
                        case TVTypeEnum.ClimateSiteInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumClimateSiteInfo, retStr);
                            break;
                        case TVTypeEnum.ClimateSiteData:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumClimateSiteData, retStr);
                            break;
                        case TVTypeEnum.HydrometricSiteInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumHydrometricSiteInfo, retStr);
                            break;
                        case TVTypeEnum.HydrometricSiteData:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumHydrometricSiteData, retStr);
                            break;
                        case TVTypeEnum.InfrastructureInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumInfrastructureInfo, retStr);
                            break;
                        case TVTypeEnum.LabSheetInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumLabSheetInfo, retStr);
                            break;
                        case TVTypeEnum.LabSheetDetailInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumLabSheetDetailInfo, retStr);
                            break;
                        case TVTypeEnum.MapInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMapInfo, retStr);
                            break;
                        case TVTypeEnum.MapInfoPoint:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMapInfoPoint, retStr);
                            break;
                        case TVTypeEnum.MikeSourceStartEndInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMikeSourceStartEndInfo, retStr);
                            break;
                        case TVTypeEnum.MWQMLookupMPNInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMWQMLookupMPNInfo, retStr);
                            break;
                        case TVTypeEnum.SamplingPlanInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumSamplingPlanInfo, retStr);
                            break;
                        case TVTypeEnum.SamplingPlanSubsectorInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumSamplingPlanSubsectorInfo, retStr);
                            break;
                        case TVTypeEnum.SamplingPlanSubsectorSiteInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumSamplingPlanSubsectorSiteInfo, retStr);
                            break;
                        case TVTypeEnum.MWQMSiteStartEndInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMWQMSiteStartEndInfo, retStr);
                            break;
                        case TVTypeEnum.MWQMSubsectorInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMWQMSubsectorInfo, retStr);
                            break;
                        case TVTypeEnum.PolSourceSiteInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumPolSourceSiteInfo, retStr);
                            break;
                        case TVTypeEnum.PolSourceSiteObsInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumPolSourceSiteObsInfo, retStr);
                            break;
                        case TVTypeEnum.HydrometricRatingCurveInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumHydrometricRatingCurveInfo, retStr);
                            break;
                        case TVTypeEnum.HydrometricRatingCurveDataInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumHydrometricRatingCurveDataInfo, retStr);
                            break;
                        case TVTypeEnum.TideLocationInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumTideLocationInfo, retStr);
                            break;
                        case TVTypeEnum.TideSiteDataInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumTideSiteDataInfo, retStr);
                            break;
                        case TVTypeEnum.UseOfSite:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumUseOfSite, retStr);
                            break;
                        case TVTypeEnum.VisualPlumesScenarioInfo:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumVisualPlumesScenarioInfo, retStr);
                            break;
                        case TVTypeEnum.VisualPlumesScenarioAmbient:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumVisualPlumesScenarioAmbient, retStr);
                            break;
                        case TVTypeEnum.VisualPlumesScenarioResults:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumVisualPlumesScenarioResults, retStr);
                            break;
                        case TVTypeEnum.TotalFile:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumTotalFile, retStr);
                            break;
                        case TVTypeEnum.MikeSourceIsRiver:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMikeSourceIsRiver, retStr);
                            break;
                        case TVTypeEnum.MikeSourceIncluded:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMikeSourceIncluded, retStr);
                            break;
                        case TVTypeEnum.MikeSourceNotIncluded:
                            Assert.AreEqual(CSSPEnumsRes.TVTypeEnumMikeSourceNotIncluded, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_GetEnumText_WebTideDataSetEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);
        
                string retStr = enums.GetEnumText_WebTideDataSetEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
        
                for (int i = 0, count = Enum.GetNames(typeof(WebTideDataSetEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.GetEnumText_WebTideDataSetEnum((WebTideDataSetEnum)i);
        
                    switch ((WebTideDataSetEnum)i)
                    {
                        case WebTideDataSetEnum.Error:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                        case WebTideDataSetEnum.arctic9:
                            Assert.AreEqual(CSSPEnumsRes.WebTideDataSetEnumarctic9, retStr);
                            break;
                        case WebTideDataSetEnum.brador:
                            Assert.AreEqual(CSSPEnumsRes.WebTideDataSetEnumbrador, retStr);
                            break;
                        case WebTideDataSetEnum.HRglobal:
                            Assert.AreEqual(CSSPEnumsRes.WebTideDataSetEnumHRglobal, retStr);
                            break;
                        case WebTideDataSetEnum.h3o:
                            Assert.AreEqual(CSSPEnumsRes.WebTideDataSetEnumh3o, retStr);
                            break;
                        case WebTideDataSetEnum.hudson:
                            Assert.AreEqual(CSSPEnumsRes.WebTideDataSetEnumhudson, retStr);
                            break;
                        case WebTideDataSetEnum.ne_pac4:
                            Assert.AreEqual(CSSPEnumsRes.WebTideDataSetEnumne_pac4, retStr);
                            break;
                        case WebTideDataSetEnum.nwatl:
                            Assert.AreEqual(CSSPEnumsRes.WebTideDataSetEnumnwatl, retStr);
                            break;
                        case WebTideDataSetEnum.QuatsinoModel14:
                            Assert.AreEqual(CSSPEnumsRes.WebTideDataSetEnumQuatsinoModel14, retStr);
                            break;
                        case WebTideDataSetEnum.sshelf:
                            Assert.AreEqual(CSSPEnumsRes.WebTideDataSetEnumsshelf, retStr);
                            break;
                        case WebTideDataSetEnum.flood:
                            Assert.AreEqual(CSSPEnumsRes.WebTideDataSetEnumflood, retStr);
                            break;
                        case WebTideDataSetEnum.vigf8:
                            Assert.AreEqual(CSSPEnumsRes.WebTideDataSetEnumvigf8, retStr);
                            break;
                        default:
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                            break;
                    }
                }
            }
        }

        #endregion Testing Methods GetEnumText public

        #region Testing Methods Check OK public
        [TestMethod]
        public void Enums_ActionDBTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.ActionDBTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(ActionDBTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.ActionDBTypeOK((ActionDBTypeEnum)i);

                    switch ((ActionDBTypeEnum)i)
                    {
                        case ActionDBTypeEnum.Error:
                        case ActionDBTypeEnum.Create:
                        case ActionDBTypeEnum.Read:
                        case ActionDBTypeEnum.Update:
                        case ActionDBTypeEnum.Delete:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ActionDBType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_AddressTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.AddressTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(AddressTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.AddressTypeOK((AddressTypeEnum)i);

                    switch ((AddressTypeEnum)i)
                    {
                        case AddressTypeEnum.Error:
                        case AddressTypeEnum.Mailing:
                        case AddressTypeEnum.Shipping:
                        case AddressTypeEnum.Civic:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.AddressType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_AerationTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.AerationTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(AerationTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.AerationTypeOK((AerationTypeEnum)i);

                    switch ((AerationTypeEnum)i)
                    {
                        case AerationTypeEnum.Error:
                        case AerationTypeEnum.Diffuser:
                        case AerationTypeEnum.Surface:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.AerationType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_AlarmSystemTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.AlarmSystemTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(AlarmSystemTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.AlarmSystemTypeOK((AlarmSystemTypeEnum)i);

                    switch ((AlarmSystemTypeEnum)i)
                    {
                        case AlarmSystemTypeEnum.Error:
                        case AlarmSystemTypeEnum.SCADA:
                        case AlarmSystemTypeEnum.None:
                        case AlarmSystemTypeEnum.OnlyVisualLight:
                        case AlarmSystemTypeEnum.SCADAAndLight:
                        case AlarmSystemTypeEnum.PagerAndLight:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.AlarmSystemType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_AnalyzeMethodOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.AnalyzeMethodOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(AnalyzeMethodEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.AnalyzeMethodOK((AnalyzeMethodEnum)i);

                    switch ((AnalyzeMethodEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.AnalyzeMethod), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_AppTaskCommandOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.AppTaskCommandOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(AppTaskCommandEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.AppTaskCommandOK((AppTaskCommandEnum)i);

                    switch ((AppTaskCommandEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.AppTaskCommand), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_AppTaskStatusOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.AppTaskStatusOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(AppTaskStatusEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.AppTaskStatusOK((AppTaskStatusEnum)i);

                    switch ((AppTaskStatusEnum)i)
                    {
                        case AppTaskStatusEnum.Error:
                        case AppTaskStatusEnum.Created:
                        case AppTaskStatusEnum.Running:
                        case AppTaskStatusEnum.Completed:
                        case AppTaskStatusEnum.Cancelled:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.AppTaskStatus), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_BeaufortScaleOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.BeaufortScaleOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(BeaufortScaleEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.BeaufortScaleOK((BeaufortScaleEnum)i);

                    switch ((BeaufortScaleEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.BeaufortScale), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_BoxModelResultTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.BoxModelResultTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(BoxModelResultTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.BoxModelResultTypeOK((BoxModelResultTypeEnum)i);

                    switch ((BoxModelResultTypeEnum)i)
                    {
                        case BoxModelResultTypeEnum.Error:
                        case BoxModelResultTypeEnum.Dilution:
                        case BoxModelResultTypeEnum.NoDecayUntreated:
                        case BoxModelResultTypeEnum.NoDecayPreDisinfection:
                        case BoxModelResultTypeEnum.DecayUntreated:
                        case BoxModelResultTypeEnum.DecayPreDisinfection:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.BoxModelResultType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_CollectionSystemTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.CollectionSystemTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(CollectionSystemTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.CollectionSystemTypeOK((CollectionSystemTypeEnum)i);

                    switch ((CollectionSystemTypeEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.CollectionSystemType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_ContactTitleOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.ContactTitleOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(ContactTitleEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.ContactTitleOK((ContactTitleEnum)i);

                    switch ((ContactTitleEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ContactTitle), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_CSSPWQInputSheetTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.CSSPWQInputSheetTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(CSSPWQInputSheetTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.CSSPWQInputSheetTypeOK((CSSPWQInputSheetTypeEnum)i);

                    switch ((CSSPWQInputSheetTypeEnum)i)
                    {
                        case CSSPWQInputSheetTypeEnum.Error:
                        case CSSPWQInputSheetTypeEnum.A1:
                        case CSSPWQInputSheetTypeEnum.LTB:
                        case CSSPWQInputSheetTypeEnum.EC:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.CSSPWQInputSheetType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_CSSPWQInputTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.CSSPWQInputTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(CSSPWQInputTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.CSSPWQInputTypeOK((CSSPWQInputTypeEnum)i);

                    switch ((CSSPWQInputTypeEnum)i)
                    {
                        case CSSPWQInputTypeEnum.Error:
                        case CSSPWQInputTypeEnum.Subsector:
                        case CSSPWQInputTypeEnum.Municipality:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.CSSPWQInputType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_DailyOrHourlyDataOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.DailyOrHourlyDataOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(DailyOrHourlyDataEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.DailyOrHourlyDataOK((DailyOrHourlyDataEnum)i);

                    switch ((DailyOrHourlyDataEnum)i)
                    {
                        case DailyOrHourlyDataEnum.Error:
                        case DailyOrHourlyDataEnum.Daily:
                        case DailyOrHourlyDataEnum.Hourly:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.DailyOrHourlyData), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_DatabaseTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.DatabaseTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(DatabaseTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.DatabaseTypeOK((DatabaseTypeEnum)i);

                    switch ((DatabaseTypeEnum)i)
                    {
                        case DatabaseTypeEnum.Error:
                        case DatabaseTypeEnum.MemoryCSSPWebToolsDB:
                        case DatabaseTypeEnum.MemoryTestDB:
                        case DatabaseTypeEnum.SqlServerCSSPWebToolsDB:
                        case DatabaseTypeEnum.SqlServerTestDB:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.DatabaseType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_DisinfectionTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.DisinfectionTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(DisinfectionTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.DisinfectionTypeOK((DisinfectionTypeEnum)i);

                    switch ((DisinfectionTypeEnum)i)
                    {
                        case DisinfectionTypeEnum.Error:
                        case DisinfectionTypeEnum.None:
                        case DisinfectionTypeEnum.UV:
                        case DisinfectionTypeEnum.ChlorinationNoDechlorination:
                        case DisinfectionTypeEnum.ChlorinationWithDechlorination:
                        case DisinfectionTypeEnum.UVSeasonal:
                        case DisinfectionTypeEnum.ChlorinationNoDechlorinationSeasonal:
                        case DisinfectionTypeEnum.ChlorinationWithDechlorinationSeasonal:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.DisinfectionType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_EmailTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.EmailTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(EmailTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.EmailTypeOK((EmailTypeEnum)i);

                    switch ((EmailTypeEnum)i)
                    {
                        case EmailTypeEnum.Error:
                        case EmailTypeEnum.Personal:
                        case EmailTypeEnum.Work:
                        case EmailTypeEnum.Personal2:
                        case EmailTypeEnum.Work2:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.EmailType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_FacilityTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.FacilityTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(FacilityTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.FacilityTypeOK((FacilityTypeEnum)i);

                    switch ((FacilityTypeEnum)i)
                    {
                        case FacilityTypeEnum.Error:
                        case FacilityTypeEnum.Lagoon:
                        case FacilityTypeEnum.Plant:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.FacilityType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_FilePurposeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.FilePurposeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(FilePurposeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.FilePurposeOK((FilePurposeEnum)i);

                    switch ((FilePurposeEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.FilePurpose), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_FileStatusOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.FileStatusOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(FileStatusEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.FileStatusOK((FileStatusEnum)i);

                    switch ((FileStatusEnum)i)
                    {
                        case FileStatusEnum.Error:
                        case FileStatusEnum.Changed:
                        case FileStatusEnum.Sent:
                        case FileStatusEnum.Accepted:
                        case FileStatusEnum.Rejected:
                        case FileStatusEnum.Fail:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.FileStatus), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_FileTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.FileTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(FileTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.FileTypeOK((FileTypeEnum)i);

                    switch ((FileTypeEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.FileType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_InfrastructureTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.InfrastructureTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(InfrastructureTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.InfrastructureTypeOK((InfrastructureTypeEnum)i);

                    switch ((InfrastructureTypeEnum)i)
                    {
                        case InfrastructureTypeEnum.Error:
                        case InfrastructureTypeEnum.WWTP:
                        case InfrastructureTypeEnum.LiftStation:
                        case InfrastructureTypeEnum.Other:
                        case InfrastructureTypeEnum.SeeOther:
                        case InfrastructureTypeEnum.LineOverflow:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.InfrastructureType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_KMZActionOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.KMZActionOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(KMZActionEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.KMZActionOK((KMZActionEnum)i);

                    switch ((KMZActionEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.KMZAction), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_LaboratoryOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.LaboratoryOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(LaboratoryEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.LaboratoryOK((LaboratoryEnum)i);

                    switch ((LaboratoryEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.Laboratory), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_LabSheetStatusOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.LabSheetStatusOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(LabSheetStatusEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.LabSheetStatusOK((LabSheetStatusEnum)i);

                    switch ((LabSheetStatusEnum)i)
                    {
                        case LabSheetStatusEnum.Error:
                        case LabSheetStatusEnum.Created:
                        case LabSheetStatusEnum.Transferred:
                        case LabSheetStatusEnum.Accepted:
                        case LabSheetStatusEnum.Rejected:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.LabSheetStatus), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_LabSheetTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.LabSheetTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(LabSheetTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.LabSheetTypeOK((LabSheetTypeEnum)i);

                    switch ((LabSheetTypeEnum)i)
                    {
                        case LabSheetTypeEnum.Error:
                        case LabSheetTypeEnum.A1:
                        case LabSheetTypeEnum.LTB:
                        case LabSheetTypeEnum.EC:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.LabSheetType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_LanguageOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.LanguageOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(LanguageEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.LanguageOK((LanguageEnum)i);

                    switch ((LanguageEnum)i)
                    {
                        case LanguageEnum.Error:
                        case LanguageEnum.en:
                        case LanguageEnum.fr:
                        case LanguageEnum.enAndfr:
                        case LanguageEnum.es:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.Language), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_LogCommandOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.LogCommandOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(LogCommandEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.LogCommandOK((LogCommandEnum)i);

                    switch ((LogCommandEnum)i)
                    {
                        case LogCommandEnum.Error:
                        case LogCommandEnum.Add:
                        case LogCommandEnum.Change:
                        case LogCommandEnum.Delete:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.LogCommand), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_MapInfoDrawTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.MapInfoDrawTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(MapInfoDrawTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.MapInfoDrawTypeOK((MapInfoDrawTypeEnum)i);

                    switch ((MapInfoDrawTypeEnum)i)
                    {
                        case MapInfoDrawTypeEnum.Error:
                        case MapInfoDrawTypeEnum.Point:
                        case MapInfoDrawTypeEnum.Polyline:
                        case MapInfoDrawTypeEnum.Polygon:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.MapInfoDrawType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_MikeBoundaryConditionLevelOrVelocityOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.MikeBoundaryConditionLevelOrVelocityOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(MikeBoundaryConditionLevelOrVelocityEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.MikeBoundaryConditionLevelOrVelocityOK((MikeBoundaryConditionLevelOrVelocityEnum)i);

                    switch ((MikeBoundaryConditionLevelOrVelocityEnum)i)
                    {
                        case MikeBoundaryConditionLevelOrVelocityEnum.Error:
                        case MikeBoundaryConditionLevelOrVelocityEnum.Level:
                        case MikeBoundaryConditionLevelOrVelocityEnum.Velocity:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.MikeBoundaryConditionLevelOrVelocity), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_MikeScenarioSpecialResultKMLTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.MikeScenarioSpecialResultKMLTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(MikeScenarioSpecialResultKMLTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.MikeScenarioSpecialResultKMLTypeOK((MikeScenarioSpecialResultKMLTypeEnum)i);

                    switch ((MikeScenarioSpecialResultKMLTypeEnum)i)
                    {
                        case MikeScenarioSpecialResultKMLTypeEnum.Error:
                        case MikeScenarioSpecialResultKMLTypeEnum.Mesh:
                        case MikeScenarioSpecialResultKMLTypeEnum.StudyArea:
                        case MikeScenarioSpecialResultKMLTypeEnum.BoundaryConditions:
                        case MikeScenarioSpecialResultKMLTypeEnum.PollutionLimit:
                        case MikeScenarioSpecialResultKMLTypeEnum.PollutionAnimation:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.MikeScenarioSpecialResultKMLType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_MWQMSiteLatestClassificationOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.MWQMSiteLatestClassificationOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(MWQMSiteLatestClassificationEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.MWQMSiteLatestClassificationOK((MWQMSiteLatestClassificationEnum)i);

                    switch ((MWQMSiteLatestClassificationEnum)i)
                    {
                        case MWQMSiteLatestClassificationEnum.Error:
                        case MWQMSiteLatestClassificationEnum.Approved:
                        case MWQMSiteLatestClassificationEnum.ConditionallyApproved:
                        case MWQMSiteLatestClassificationEnum.Restricted:
                        case MWQMSiteLatestClassificationEnum.ConditionallyRestricted:
                        case MWQMSiteLatestClassificationEnum.Prohibited:
                        case MWQMSiteLatestClassificationEnum.Unclassified:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.MWQMSiteLatestClassification), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_PolSourceInactiveReasonOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.PolSourceInactiveReasonOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(PolSourceInactiveReasonEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.PolSourceInactiveReasonOK((PolSourceInactiveReasonEnum)i);

                    switch ((PolSourceInactiveReasonEnum)i)
                    {
                        case PolSourceInactiveReasonEnum.Error:
                        case PolSourceInactiveReasonEnum.Abandoned:
                        case PolSourceInactiveReasonEnum.Closed:
                        case PolSourceInactiveReasonEnum.Removed:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.PolSourceInactiveReason), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_PolSourceIssueRiskOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.PolSourceIssueRiskOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(PolSourceIssueRiskEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.PolSourceIssueRiskOK((PolSourceIssueRiskEnum)i);

                    switch ((PolSourceIssueRiskEnum)i)
                    {
                        case PolSourceIssueRiskEnum.Error:
                        case PolSourceIssueRiskEnum.LowRisk:
                        case PolSourceIssueRiskEnum.ModerateRisk:
                        case PolSourceIssueRiskEnum.HighRisk:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.PolSourceIssueRisk), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_PreliminaryTreatmentTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.PreliminaryTreatmentTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(PreliminaryTreatmentTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.PreliminaryTreatmentTypeOK((PreliminaryTreatmentTypeEnum)i);

                    switch ((PreliminaryTreatmentTypeEnum)i)
                    {
                        case PreliminaryTreatmentTypeEnum.Error:
                        case PreliminaryTreatmentTypeEnum.NotApplicable:
                        case PreliminaryTreatmentTypeEnum.BarScreen:
                        case PreliminaryTreatmentTypeEnum.Grinder:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.PreliminaryTreatmentType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_PrimaryTreatmentTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.PrimaryTreatmentTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(PrimaryTreatmentTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.PrimaryTreatmentTypeOK((PrimaryTreatmentTypeEnum)i);

                    switch ((PrimaryTreatmentTypeEnum)i)
                    {
                        case PrimaryTreatmentTypeEnum.Error:
                        case PrimaryTreatmentTypeEnum.NotApplicable:
                        case PrimaryTreatmentTypeEnum.Sedimentation:
                        case PrimaryTreatmentTypeEnum.ChemicalCoagulation:
                        case PrimaryTreatmentTypeEnum.Filtration:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.PrimaryTreatmentType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_ReportConditionOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.ReportConditionOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(ReportConditionEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.ReportConditionOK((ReportConditionEnum)i);

                    switch ((ReportConditionEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportCondition), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_ReportFieldTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.ReportFieldTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(ReportFieldTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.ReportFieldTypeOK((ReportFieldTypeEnum)i);

                    switch ((ReportFieldTypeEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportFieldType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_ReportFileTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.ReportFileTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(ReportFileTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.ReportFileTypeOK((ReportFileTypeEnum)i);

                    switch ((ReportFileTypeEnum)i)
                    {
                        case ReportFileTypeEnum.Error:
                        case ReportFileTypeEnum.CSV:
                        case ReportFileTypeEnum.Word:
                        case ReportFileTypeEnum.Excel:
                        case ReportFileTypeEnum.KML:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportFileType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_ReportFormatingDateOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.ReportFormatingDateOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(ReportFormatingDateEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.ReportFormatingDateOK((ReportFormatingDateEnum)i);

                    switch ((ReportFormatingDateEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportFormatingDate), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_ReportFormatingNumberOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.ReportFormatingNumberOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(ReportFormatingNumberEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.ReportFormatingNumberOK((ReportFormatingNumberEnum)i);

                    switch ((ReportFormatingNumberEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportFormatingNumber), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_ReportSortingOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.ReportSortingOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(ReportSortingEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.ReportSortingOK((ReportSortingEnum)i);

                    switch ((ReportSortingEnum)i)
                    {
                        case ReportSortingEnum.Error:
                        case ReportSortingEnum.ReportSortingAscending:
                        case ReportSortingEnum.ReportSortingDescending:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportSorting), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_ReportTreeNodeSubTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.ReportTreeNodeSubTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(ReportTreeNodeSubTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.ReportTreeNodeSubTypeOK((ReportTreeNodeSubTypeEnum)i);

                    switch ((ReportTreeNodeSubTypeEnum)i)
                    {
                        case ReportTreeNodeSubTypeEnum.Error:
                        case ReportTreeNodeSubTypeEnum.TableSelectable:
                        case ReportTreeNodeSubTypeEnum.Field:
                        case ReportTreeNodeSubTypeEnum.FieldsHolder:
                        case ReportTreeNodeSubTypeEnum.TableNotSelectable:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportTreeNodeSubType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_ReportTreeNodeTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.ReportTreeNodeTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(ReportTreeNodeTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.ReportTreeNodeTypeOK((ReportTreeNodeTypeEnum)i);

                    switch ((ReportTreeNodeTypeEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ReportTreeNodeType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_SameDayNextDayOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.SameDayNextDayOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(SameDayNextDayEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.SameDayNextDayOK((SameDayNextDayEnum)i);

                    switch ((SameDayNextDayEnum)i)
                    {
                        case SameDayNextDayEnum.Error:
                        case SameDayNextDayEnum.SameDay:
                        case SameDayNextDayEnum.NextDay:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SameDayNextDay), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_SampleMatrixOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.SampleMatrixOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(SampleMatrixEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.SampleMatrixOK((SampleMatrixEnum)i);

                    switch ((SampleMatrixEnum)i)
                    {
                        case SampleMatrixEnum.Error:
                        case SampleMatrixEnum.W:
                        case SampleMatrixEnum.S:
                        case SampleMatrixEnum.B:
                        case SampleMatrixEnum.MPNQ:
                        case SampleMatrixEnum.SampleMatrix5:
                        case SampleMatrixEnum.SampleMatrix6:
                        case SampleMatrixEnum.Water:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SampleMatrix), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_SampleStatusOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.SampleStatusOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(SampleStatusEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.SampleStatusOK((SampleStatusEnum)i);

                    switch ((SampleStatusEnum)i)
                    {
                        case SampleStatusEnum.Error:
                        case SampleStatusEnum.Active:
                        case SampleStatusEnum.Archived:
                        case SampleStatusEnum.SampleStatus3:
                        case SampleStatusEnum.SampleStatus4:
                        case SampleStatusEnum.SampleStatus5:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SampleStatus), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_SampleTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.SampleTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(SampleTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.SampleTypeOK((SampleTypeEnum)i);

                    switch ((SampleTypeEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SampleType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_SamplingPlanTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.SamplingPlanTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(SamplingPlanTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.SamplingPlanTypeOK((SamplingPlanTypeEnum)i);

                    switch ((SamplingPlanTypeEnum)i)
                    {
                        case SamplingPlanTypeEnum.Error:
                        case SamplingPlanTypeEnum.Subsector:
                        case SamplingPlanTypeEnum.Municipality:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SamplingPlanType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_ScenarioStatusOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.ScenarioStatusOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(ScenarioStatusEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.ScenarioStatusOK((ScenarioStatusEnum)i);

                    switch ((ScenarioStatusEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.ScenarioStatus), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_SearchTagOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.SearchTagOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(SearchTagEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.SearchTagOK((SearchTagEnum)i);

                    switch ((SearchTagEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SearchTag), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_SecondaryTreatmentTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.SecondaryTreatmentTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(SecondaryTreatmentTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.SecondaryTreatmentTypeOK((SecondaryTreatmentTypeEnum)i);

                    switch ((SecondaryTreatmentTypeEnum)i)
                    {
                        case SecondaryTreatmentTypeEnum.Error:
                        case SecondaryTreatmentTypeEnum.NotApplicable:
                        case SecondaryTreatmentTypeEnum.RotatingBiologicalContactor:
                        case SecondaryTreatmentTypeEnum.TricklingFilters:
                        case SecondaryTreatmentTypeEnum.SequencingBatchReator:
                        case SecondaryTreatmentTypeEnum.OxidationDitch:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SecondaryTreatmentType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_SiteTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.SiteTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(SiteTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.SiteTypeOK((SiteTypeEnum)i);

                    switch ((SiteTypeEnum)i)
                    {
                        case SiteTypeEnum.Error:
                        case SiteTypeEnum.Climate:
                        case SiteTypeEnum.Hydrometric:
                        case SiteTypeEnum.Tide:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SiteType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_SpecialTableTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.SpecialTableTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(SpecialTableTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.SpecialTableTypeOK((SpecialTableTypeEnum)i);

                    switch ((SpecialTableTypeEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.SpecialTableType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_StorageDataTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.StorageDataTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(StorageDataTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.StorageDataTypeOK((StorageDataTypeEnum)i);

                    switch ((StorageDataTypeEnum)i)
                    {
                        case StorageDataTypeEnum.Error:
                        case StorageDataTypeEnum.Archived:
                        case StorageDataTypeEnum.Forcasted:
                        case StorageDataTypeEnum.Observed:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.StorageDataType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_StreetTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.StreetTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(StreetTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.StreetTypeOK((StreetTypeEnum)i);

                    switch ((StreetTypeEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.StreetType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_TelTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.TelTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(TelTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.TelTypeOK((TelTypeEnum)i);

                    switch ((TelTypeEnum)i)
                    {
                        case TelTypeEnum.Error:
                        case TelTypeEnum.Personal:
                        case TelTypeEnum.Work:
                        case TelTypeEnum.Mobile:
                        case TelTypeEnum.Personal2:
                        case TelTypeEnum.Work2:
                        case TelTypeEnum.Mobile2:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TelType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_TertiaryTreatmentTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.TertiaryTreatmentTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(TertiaryTreatmentTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.TertiaryTreatmentTypeOK((TertiaryTreatmentTypeEnum)i);

                    switch ((TertiaryTreatmentTypeEnum)i)
                    {
                        case TertiaryTreatmentTypeEnum.Error:
                        case TertiaryTreatmentTypeEnum.NotApplicable:
                        case TertiaryTreatmentTypeEnum.Adsorption:
                        case TertiaryTreatmentTypeEnum.Flocculation:
                        case TertiaryTreatmentTypeEnum.MembraneFiltration:
                        case TertiaryTreatmentTypeEnum.IonExchange:
                        case TertiaryTreatmentTypeEnum.ReverseOsmosis:
                        case TertiaryTreatmentTypeEnum.BiologicalNutrientRemoval:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TertiaryTreatmentType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_TideDataTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.TideDataTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(TideDataTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.TideDataTypeOK((TideDataTypeEnum)i);

                    switch ((TideDataTypeEnum)i)
                    {
                        case TideDataTypeEnum.Error:
                        case TideDataTypeEnum.Min15:
                        case TideDataTypeEnum.Min60:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TideDataType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_TideTextOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.TideTextOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(TideTextEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.TideTextOK((TideTextEnum)i);

                    switch ((TideTextEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TideText), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_TranslationStatusOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.TranslationStatusOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(TranslationStatusEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.TranslationStatusOK((TranslationStatusEnum)i);

                    switch ((TranslationStatusEnum)i)
                    {
                        case TranslationStatusEnum.Error:
                        case TranslationStatusEnum.NotTranslated:
                        case TranslationStatusEnum.ElectronicallyTranslated:
                        case TranslationStatusEnum.Translated:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TranslationStatus), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_TreatmentTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.TreatmentTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(TreatmentTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.TreatmentTypeOK((TreatmentTypeEnum)i);

                    switch ((TreatmentTypeEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TreatmentType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_TVAuthOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.TVAuthOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(TVAuthEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.TVAuthOK((TVAuthEnum)i);

                    switch ((TVAuthEnum)i)
                    {
                        case TVAuthEnum.Error:
                        case TVAuthEnum.NoAccess:
                        case TVAuthEnum.Read:
                        case TVAuthEnum.Write:
                        case TVAuthEnum.Create:
                        case TVAuthEnum.Delete:
                        case TVAuthEnum.Admin:
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TVAuth), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_TVTypeOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.TVTypeOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(TVTypeEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.TVTypeOK((TVTypeEnum)i);

                    switch ((TVTypeEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.TVType), retStr);
                            break;
                    }
                }
            }
        }
        [TestMethod]
        public void Enums_WebTideDataSetOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.WebTideDataSetOK(null);
                Assert.AreEqual("", retStr);

                for (int i = 0, count = Enum.GetNames(typeof(WebTideDataSetEnum)).Length + 1; i < count; i++)
                {
                    retStr = enums.WebTideDataSetOK((WebTideDataSetEnum)i);

                    switch ((WebTideDataSetEnum)i)
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
                            Assert.AreEqual("", retStr);
                            break;
                        default:
                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes.WebTideDataSet), retStr);
                            break;
                    }
                }
            }
        }

        #endregion Testing Methods Check OK public
        #region Testing Methods TextOrdered public
        [TestMethod]
        public void Enums_ActionDBTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<ActionDBTypeEnumTextOrdered> ActionDBTypeEnumList = new List<ActionDBTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(ActionDBTypeEnum)).Length; i < count; i++)
                {
                    ActionDBTypeEnumList.Add(new ActionDBTypeEnumTextOrdered() { ActionDBType = (ActionDBTypeEnum)i, ActionDBTypeText = enums.GetEnumText_ActionDBTypeEnum((ActionDBTypeEnum)i) });
                }
                ActionDBTypeEnumList = ActionDBTypeEnumList.OrderBy(c => c.ActionDBTypeText).ToList();

                List<ActionDBTypeEnumTextOrdered> ActionDBTypeEnumTextOrderedList = enums.GetActionDBTypeEnumTextOrderedList();
                Assert.AreEqual(ActionDBTypeEnumList.Count, ActionDBTypeEnumTextOrderedList.Count);

                ActionDBTypeEnumTextOrdered ActionDBTypeEnumTextOrdered = new ActionDBTypeEnumTextOrdered();
                Assert.IsNotNull(ActionDBTypeEnumTextOrdered);

                for (int i = 0, count = ActionDBTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(ActionDBTypeEnumList[i].ActionDBTypeText, ActionDBTypeEnumTextOrderedList[i].ActionDBTypeText);
                    Assert.AreEqual(ActionDBTypeEnumList[i].ActionDBType, ActionDBTypeEnumTextOrderedList[i].ActionDBType);
                }
            }
        }
        [TestMethod]
        public void Enums_AddressTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<AddressTypeEnumTextOrdered> AddressTypeEnumList = new List<AddressTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(AddressTypeEnum)).Length; i < count; i++)
                {
                    AddressTypeEnumList.Add(new AddressTypeEnumTextOrdered() { AddressType = (AddressTypeEnum)i, AddressTypeText = enums.GetEnumText_AddressTypeEnum((AddressTypeEnum)i) });
                }
                AddressTypeEnumList = AddressTypeEnumList.OrderBy(c => c.AddressTypeText).ToList();

                List<AddressTypeEnumTextOrdered> AddressTypeEnumTextOrderedList = enums.GetAddressTypeEnumTextOrderedList();
                Assert.AreEqual(AddressTypeEnumList.Count, AddressTypeEnumTextOrderedList.Count);

                AddressTypeEnumTextOrdered AddressTypeEnumTextOrdered = new AddressTypeEnumTextOrdered();
                Assert.IsNotNull(AddressTypeEnumTextOrdered);

                for (int i = 0, count = AddressTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(AddressTypeEnumList[i].AddressTypeText, AddressTypeEnumTextOrderedList[i].AddressTypeText);
                    Assert.AreEqual(AddressTypeEnumList[i].AddressType, AddressTypeEnumTextOrderedList[i].AddressType);
                }
            }
        }
        [TestMethod]
        public void Enums_AerationTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<AerationTypeEnumTextOrdered> AerationTypeEnumList = new List<AerationTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(AerationTypeEnum)).Length; i < count; i++)
                {
                    AerationTypeEnumList.Add(new AerationTypeEnumTextOrdered() { AerationType = (AerationTypeEnum)i, AerationTypeText = enums.GetEnumText_AerationTypeEnum((AerationTypeEnum)i) });
                }
                AerationTypeEnumList = AerationTypeEnumList.OrderBy(c => c.AerationTypeText).ToList();

                List<AerationTypeEnumTextOrdered> AerationTypeEnumTextOrderedList = enums.GetAerationTypeEnumTextOrderedList();
                Assert.AreEqual(AerationTypeEnumList.Count, AerationTypeEnumTextOrderedList.Count);

                AerationTypeEnumTextOrdered AerationTypeEnumTextOrdered = new AerationTypeEnumTextOrdered();
                Assert.IsNotNull(AerationTypeEnumTextOrdered);

                for (int i = 0, count = AerationTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(AerationTypeEnumList[i].AerationTypeText, AerationTypeEnumTextOrderedList[i].AerationTypeText);
                    Assert.AreEqual(AerationTypeEnumList[i].AerationType, AerationTypeEnumTextOrderedList[i].AerationType);
                }
            }
        }
        [TestMethod]
        public void Enums_AlarmSystemTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<AlarmSystemTypeEnumTextOrdered> AlarmSystemTypeEnumList = new List<AlarmSystemTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(AlarmSystemTypeEnum)).Length; i < count; i++)
                {
                    AlarmSystemTypeEnumList.Add(new AlarmSystemTypeEnumTextOrdered() { AlarmSystemType = (AlarmSystemTypeEnum)i, AlarmSystemTypeText = enums.GetEnumText_AlarmSystemTypeEnum((AlarmSystemTypeEnum)i) });
                }
                AlarmSystemTypeEnumList = AlarmSystemTypeEnumList.OrderBy(c => c.AlarmSystemTypeText).ToList();

                List<AlarmSystemTypeEnumTextOrdered> AlarmSystemTypeEnumTextOrderedList = enums.GetAlarmSystemTypeEnumTextOrderedList();
                Assert.AreEqual(AlarmSystemTypeEnumList.Count, AlarmSystemTypeEnumTextOrderedList.Count);

                AlarmSystemTypeEnumTextOrdered AlarmSystemTypeEnumTextOrdered = new AlarmSystemTypeEnumTextOrdered();
                Assert.IsNotNull(AlarmSystemTypeEnumTextOrdered);

                for (int i = 0, count = AlarmSystemTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(AlarmSystemTypeEnumList[i].AlarmSystemTypeText, AlarmSystemTypeEnumTextOrderedList[i].AlarmSystemTypeText);
                    Assert.AreEqual(AlarmSystemTypeEnumList[i].AlarmSystemType, AlarmSystemTypeEnumTextOrderedList[i].AlarmSystemType);
                }
            }
        }
        [TestMethod]
        public void Enums_AnalyzeMethodEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<AnalyzeMethodEnumTextOrdered> AnalyzeMethodEnumList = new List<AnalyzeMethodEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(AnalyzeMethodEnum)).Length; i < count; i++)
                {
                    AnalyzeMethodEnumList.Add(new AnalyzeMethodEnumTextOrdered() { AnalyzeMethod = (AnalyzeMethodEnum)i, AnalyzeMethodText = enums.GetEnumText_AnalyzeMethodEnum((AnalyzeMethodEnum)i) });
                }
                AnalyzeMethodEnumList = AnalyzeMethodEnumList.OrderBy(c => c.AnalyzeMethodText).ToList();

                List<AnalyzeMethodEnumTextOrdered> AnalyzeMethodEnumTextOrderedList = enums.GetAnalyzeMethodEnumTextOrderedList();
                Assert.AreEqual(AnalyzeMethodEnumList.Count, AnalyzeMethodEnumTextOrderedList.Count);

                AnalyzeMethodEnumTextOrdered AnalyzeMethodEnumTextOrdered = new AnalyzeMethodEnumTextOrdered();
                Assert.IsNotNull(AnalyzeMethodEnumTextOrdered);

                for (int i = 0, count = AnalyzeMethodEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(AnalyzeMethodEnumList[i].AnalyzeMethodText, AnalyzeMethodEnumTextOrderedList[i].AnalyzeMethodText);
                    Assert.AreEqual(AnalyzeMethodEnumList[i].AnalyzeMethod, AnalyzeMethodEnumTextOrderedList[i].AnalyzeMethod);
                }
            }
        }
        [TestMethod]
        public void Enums_AppTaskCommandEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<AppTaskCommandEnumTextOrdered> AppTaskCommandEnumList = new List<AppTaskCommandEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(AppTaskCommandEnum)).Length; i < count; i++)
                {
                    AppTaskCommandEnumList.Add(new AppTaskCommandEnumTextOrdered() { AppTaskCommand = (AppTaskCommandEnum)i, AppTaskCommandText = enums.GetEnumText_AppTaskCommandEnum((AppTaskCommandEnum)i) });
                }
                AppTaskCommandEnumList = AppTaskCommandEnumList.OrderBy(c => c.AppTaskCommandText).ToList();

                List<AppTaskCommandEnumTextOrdered> AppTaskCommandEnumTextOrderedList = enums.GetAppTaskCommandEnumTextOrderedList();
                Assert.AreEqual(AppTaskCommandEnumList.Count, AppTaskCommandEnumTextOrderedList.Count);

                AppTaskCommandEnumTextOrdered AppTaskCommandEnumTextOrdered = new AppTaskCommandEnumTextOrdered();
                Assert.IsNotNull(AppTaskCommandEnumTextOrdered);

                for (int i = 0, count = AppTaskCommandEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(AppTaskCommandEnumList[i].AppTaskCommandText, AppTaskCommandEnumTextOrderedList[i].AppTaskCommandText);
                    Assert.AreEqual(AppTaskCommandEnumList[i].AppTaskCommand, AppTaskCommandEnumTextOrderedList[i].AppTaskCommand);
                }
            }
        }
        [TestMethod]
        public void Enums_AppTaskStatusEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<AppTaskStatusEnumTextOrdered> AppTaskStatusEnumList = new List<AppTaskStatusEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(AppTaskStatusEnum)).Length; i < count; i++)
                {
                    AppTaskStatusEnumList.Add(new AppTaskStatusEnumTextOrdered() { AppTaskStatus = (AppTaskStatusEnum)i, AppTaskStatusText = enums.GetEnumText_AppTaskStatusEnum((AppTaskStatusEnum)i) });
                }
                AppTaskStatusEnumList = AppTaskStatusEnumList.OrderBy(c => c.AppTaskStatusText).ToList();

                List<AppTaskStatusEnumTextOrdered> AppTaskStatusEnumTextOrderedList = enums.GetAppTaskStatusEnumTextOrderedList();
                Assert.AreEqual(AppTaskStatusEnumList.Count, AppTaskStatusEnumTextOrderedList.Count);

                AppTaskStatusEnumTextOrdered AppTaskStatusEnumTextOrdered = new AppTaskStatusEnumTextOrdered();
                Assert.IsNotNull(AppTaskStatusEnumTextOrdered);

                for (int i = 0, count = AppTaskStatusEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(AppTaskStatusEnumList[i].AppTaskStatusText, AppTaskStatusEnumTextOrderedList[i].AppTaskStatusText);
                    Assert.AreEqual(AppTaskStatusEnumList[i].AppTaskStatus, AppTaskStatusEnumTextOrderedList[i].AppTaskStatus);
                }
            }
        }
        [TestMethod]
        public void Enums_BeaufortScaleEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<BeaufortScaleEnumTextOrdered> BeaufortScaleEnumList = new List<BeaufortScaleEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(BeaufortScaleEnum)).Length; i < count; i++)
                {
                    BeaufortScaleEnumList.Add(new BeaufortScaleEnumTextOrdered() { BeaufortScale = (BeaufortScaleEnum)i, BeaufortScaleText = enums.GetEnumText_BeaufortScaleEnum((BeaufortScaleEnum)i) });
                }
                BeaufortScaleEnumList = BeaufortScaleEnumList.OrderBy(c => c.BeaufortScaleText).ToList();

                List<BeaufortScaleEnumTextOrdered> BeaufortScaleEnumTextOrderedList = enums.GetBeaufortScaleEnumTextOrderedList();
                Assert.AreEqual(BeaufortScaleEnumList.Count, BeaufortScaleEnumTextOrderedList.Count);

                BeaufortScaleEnumTextOrdered BeaufortScaleEnumTextOrdered = new BeaufortScaleEnumTextOrdered();
                Assert.IsNotNull(BeaufortScaleEnumTextOrdered);

                for (int i = 0, count = BeaufortScaleEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(BeaufortScaleEnumList[i].BeaufortScaleText, BeaufortScaleEnumTextOrderedList[i].BeaufortScaleText);
                    Assert.AreEqual(BeaufortScaleEnumList[i].BeaufortScale, BeaufortScaleEnumTextOrderedList[i].BeaufortScale);
                }
            }
        }
        [TestMethod]
        public void Enums_BoxModelResultTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<BoxModelResultTypeEnumTextOrdered> BoxModelResultTypeEnumList = new List<BoxModelResultTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(BoxModelResultTypeEnum)).Length; i < count; i++)
                {
                    BoxModelResultTypeEnumList.Add(new BoxModelResultTypeEnumTextOrdered() { BoxModelResultType = (BoxModelResultTypeEnum)i, BoxModelResultTypeText = enums.GetEnumText_BoxModelResultTypeEnum((BoxModelResultTypeEnum)i) });
                }
                BoxModelResultTypeEnumList = BoxModelResultTypeEnumList.OrderBy(c => c.BoxModelResultTypeText).ToList();

                List<BoxModelResultTypeEnumTextOrdered> BoxModelResultTypeEnumTextOrderedList = enums.GetBoxModelResultTypeEnumTextOrderedList();
                Assert.AreEqual(BoxModelResultTypeEnumList.Count, BoxModelResultTypeEnumTextOrderedList.Count);

                BoxModelResultTypeEnumTextOrdered BoxModelResultTypeEnumTextOrdered = new BoxModelResultTypeEnumTextOrdered();
                Assert.IsNotNull(BoxModelResultTypeEnumTextOrdered);

                for (int i = 0, count = BoxModelResultTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(BoxModelResultTypeEnumList[i].BoxModelResultTypeText, BoxModelResultTypeEnumTextOrderedList[i].BoxModelResultTypeText);
                    Assert.AreEqual(BoxModelResultTypeEnumList[i].BoxModelResultType, BoxModelResultTypeEnumTextOrderedList[i].BoxModelResultType);
                }
            }
        }
        [TestMethod]
        public void Enums_CollectionSystemTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<CollectionSystemTypeEnumTextOrdered> CollectionSystemTypeEnumList = new List<CollectionSystemTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(CollectionSystemTypeEnum)).Length; i < count; i++)
                {
                    CollectionSystemTypeEnumList.Add(new CollectionSystemTypeEnumTextOrdered() { CollectionSystemType = (CollectionSystemTypeEnum)i, CollectionSystemTypeText = enums.GetEnumText_CollectionSystemTypeEnum((CollectionSystemTypeEnum)i) });
                }
                CollectionSystemTypeEnumList = CollectionSystemTypeEnumList.OrderBy(c => c.CollectionSystemTypeText).ToList();

                List<CollectionSystemTypeEnumTextOrdered> CollectionSystemTypeEnumTextOrderedList = enums.GetCollectionSystemTypeEnumTextOrderedList();
                Assert.AreEqual(CollectionSystemTypeEnumList.Count, CollectionSystemTypeEnumTextOrderedList.Count);

                CollectionSystemTypeEnumTextOrdered CollectionSystemTypeEnumTextOrdered = new CollectionSystemTypeEnumTextOrdered();
                Assert.IsNotNull(CollectionSystemTypeEnumTextOrdered);

                for (int i = 0, count = CollectionSystemTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(CollectionSystemTypeEnumList[i].CollectionSystemTypeText, CollectionSystemTypeEnumTextOrderedList[i].CollectionSystemTypeText);
                    Assert.AreEqual(CollectionSystemTypeEnumList[i].CollectionSystemType, CollectionSystemTypeEnumTextOrderedList[i].CollectionSystemType);
                }
            }
        }
        [TestMethod]
        public void Enums_ContactTitleEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<ContactTitleEnumTextOrdered> ContactTitleEnumList = new List<ContactTitleEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(ContactTitleEnum)).Length; i < count; i++)
                {
                    ContactTitleEnumList.Add(new ContactTitleEnumTextOrdered() { ContactTitle = (ContactTitleEnum)i, ContactTitleText = enums.GetEnumText_ContactTitleEnum((ContactTitleEnum)i) });
                }
                ContactTitleEnumList = ContactTitleEnumList.OrderBy(c => c.ContactTitleText).ToList();

                List<ContactTitleEnumTextOrdered> ContactTitleEnumTextOrderedList = enums.GetContactTitleEnumTextOrderedList();
                Assert.AreEqual(ContactTitleEnumList.Count, ContactTitleEnumTextOrderedList.Count);

                ContactTitleEnumTextOrdered ContactTitleEnumTextOrdered = new ContactTitleEnumTextOrdered();
                Assert.IsNotNull(ContactTitleEnumTextOrdered);

                for (int i = 0, count = ContactTitleEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(ContactTitleEnumList[i].ContactTitleText, ContactTitleEnumTextOrderedList[i].ContactTitleText);
                    Assert.AreEqual(ContactTitleEnumList[i].ContactTitle, ContactTitleEnumTextOrderedList[i].ContactTitle);
                }
            }
        }
        [TestMethod]
        public void Enums_CSSPWQInputSheetTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<CSSPWQInputSheetTypeEnumTextOrdered> CSSPWQInputSheetTypeEnumList = new List<CSSPWQInputSheetTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(CSSPWQInputSheetTypeEnum)).Length; i < count; i++)
                {
                    CSSPWQInputSheetTypeEnumList.Add(new CSSPWQInputSheetTypeEnumTextOrdered() { CSSPWQInputSheetType = (CSSPWQInputSheetTypeEnum)i, CSSPWQInputSheetTypeText = enums.GetEnumText_CSSPWQInputSheetTypeEnum((CSSPWQInputSheetTypeEnum)i) });
                }
                CSSPWQInputSheetTypeEnumList = CSSPWQInputSheetTypeEnumList.OrderBy(c => c.CSSPWQInputSheetTypeText).ToList();

                List<CSSPWQInputSheetTypeEnumTextOrdered> CSSPWQInputSheetTypeEnumTextOrderedList = enums.GetCSSPWQInputSheetTypeEnumTextOrderedList();
                Assert.AreEqual(CSSPWQInputSheetTypeEnumList.Count, CSSPWQInputSheetTypeEnumTextOrderedList.Count);

                CSSPWQInputSheetTypeEnumTextOrdered CSSPWQInputSheetTypeEnumTextOrdered = new CSSPWQInputSheetTypeEnumTextOrdered();
                Assert.IsNotNull(CSSPWQInputSheetTypeEnumTextOrdered);

                for (int i = 0, count = CSSPWQInputSheetTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(CSSPWQInputSheetTypeEnumList[i].CSSPWQInputSheetTypeText, CSSPWQInputSheetTypeEnumTextOrderedList[i].CSSPWQInputSheetTypeText);
                    Assert.AreEqual(CSSPWQInputSheetTypeEnumList[i].CSSPWQInputSheetType, CSSPWQInputSheetTypeEnumTextOrderedList[i].CSSPWQInputSheetType);
                }
            }
        }
        [TestMethod]
        public void Enums_CSSPWQInputTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<CSSPWQInputTypeEnumTextOrdered> CSSPWQInputTypeEnumList = new List<CSSPWQInputTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(CSSPWQInputTypeEnum)).Length; i < count; i++)
                {
                    CSSPWQInputTypeEnumList.Add(new CSSPWQInputTypeEnumTextOrdered() { CSSPWQInputType = (CSSPWQInputTypeEnum)i, CSSPWQInputTypeText = enums.GetEnumText_CSSPWQInputTypeEnum((CSSPWQInputTypeEnum)i) });
                }
                CSSPWQInputTypeEnumList = CSSPWQInputTypeEnumList.OrderBy(c => c.CSSPWQInputTypeText).ToList();

                List<CSSPWQInputTypeEnumTextOrdered> CSSPWQInputTypeEnumTextOrderedList = enums.GetCSSPWQInputTypeEnumTextOrderedList();
                Assert.AreEqual(CSSPWQInputTypeEnumList.Count, CSSPWQInputTypeEnumTextOrderedList.Count);

                CSSPWQInputTypeEnumTextOrdered CSSPWQInputTypeEnumTextOrdered = new CSSPWQInputTypeEnumTextOrdered();
                Assert.IsNotNull(CSSPWQInputTypeEnumTextOrdered);

                for (int i = 0, count = CSSPWQInputTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(CSSPWQInputTypeEnumList[i].CSSPWQInputTypeText, CSSPWQInputTypeEnumTextOrderedList[i].CSSPWQInputTypeText);
                    Assert.AreEqual(CSSPWQInputTypeEnumList[i].CSSPWQInputType, CSSPWQInputTypeEnumTextOrderedList[i].CSSPWQInputType);
                }
            }
        }
        [TestMethod]
        public void Enums_DailyOrHourlyDataEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<DailyOrHourlyDataEnumTextOrdered> DailyOrHourlyDataEnumList = new List<DailyOrHourlyDataEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(DailyOrHourlyDataEnum)).Length; i < count; i++)
                {
                    DailyOrHourlyDataEnumList.Add(new DailyOrHourlyDataEnumTextOrdered() { DailyOrHourlyData = (DailyOrHourlyDataEnum)i, DailyOrHourlyDataText = enums.GetEnumText_DailyOrHourlyDataEnum((DailyOrHourlyDataEnum)i) });
                }
                DailyOrHourlyDataEnumList = DailyOrHourlyDataEnumList.OrderBy(c => c.DailyOrHourlyDataText).ToList();

                List<DailyOrHourlyDataEnumTextOrdered> DailyOrHourlyDataEnumTextOrderedList = enums.GetDailyOrHourlyDataEnumTextOrderedList();
                Assert.AreEqual(DailyOrHourlyDataEnumList.Count, DailyOrHourlyDataEnumTextOrderedList.Count);

                DailyOrHourlyDataEnumTextOrdered DailyOrHourlyDataEnumTextOrdered = new DailyOrHourlyDataEnumTextOrdered();
                Assert.IsNotNull(DailyOrHourlyDataEnumTextOrdered);

                for (int i = 0, count = DailyOrHourlyDataEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(DailyOrHourlyDataEnumList[i].DailyOrHourlyDataText, DailyOrHourlyDataEnumTextOrderedList[i].DailyOrHourlyDataText);
                    Assert.AreEqual(DailyOrHourlyDataEnumList[i].DailyOrHourlyData, DailyOrHourlyDataEnumTextOrderedList[i].DailyOrHourlyData);
                }
            }
        }
        [TestMethod]
        public void Enums_DatabaseTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<DatabaseTypeEnumTextOrdered> DatabaseTypeEnumList = new List<DatabaseTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(DatabaseTypeEnum)).Length; i < count; i++)
                {
                    DatabaseTypeEnumList.Add(new DatabaseTypeEnumTextOrdered() { DatabaseType = (DatabaseTypeEnum)i, DatabaseTypeText = enums.GetEnumText_DatabaseTypeEnum((DatabaseTypeEnum)i) });
                }
                DatabaseTypeEnumList = DatabaseTypeEnumList.OrderBy(c => c.DatabaseTypeText).ToList();

                List<DatabaseTypeEnumTextOrdered> DatabaseTypeEnumTextOrderedList = enums.GetDatabaseTypeEnumTextOrderedList();
                Assert.AreEqual(DatabaseTypeEnumList.Count, DatabaseTypeEnumTextOrderedList.Count);

                DatabaseTypeEnumTextOrdered DatabaseTypeEnumTextOrdered = new DatabaseTypeEnumTextOrdered();
                Assert.IsNotNull(DatabaseTypeEnumTextOrdered);

                for (int i = 0, count = DatabaseTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(DatabaseTypeEnumList[i].DatabaseTypeText, DatabaseTypeEnumTextOrderedList[i].DatabaseTypeText);
                    Assert.AreEqual(DatabaseTypeEnumList[i].DatabaseType, DatabaseTypeEnumTextOrderedList[i].DatabaseType);
                }
            }
        }
        [TestMethod]
        public void Enums_DisinfectionTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<DisinfectionTypeEnumTextOrdered> DisinfectionTypeEnumList = new List<DisinfectionTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(DisinfectionTypeEnum)).Length; i < count; i++)
                {
                    DisinfectionTypeEnumList.Add(new DisinfectionTypeEnumTextOrdered() { DisinfectionType = (DisinfectionTypeEnum)i, DisinfectionTypeText = enums.GetEnumText_DisinfectionTypeEnum((DisinfectionTypeEnum)i) });
                }
                DisinfectionTypeEnumList = DisinfectionTypeEnumList.OrderBy(c => c.DisinfectionTypeText).ToList();

                List<DisinfectionTypeEnumTextOrdered> DisinfectionTypeEnumTextOrderedList = enums.GetDisinfectionTypeEnumTextOrderedList();
                Assert.AreEqual(DisinfectionTypeEnumList.Count, DisinfectionTypeEnumTextOrderedList.Count);

                DisinfectionTypeEnumTextOrdered DisinfectionTypeEnumTextOrdered = new DisinfectionTypeEnumTextOrdered();
                Assert.IsNotNull(DisinfectionTypeEnumTextOrdered);

                for (int i = 0, count = DisinfectionTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(DisinfectionTypeEnumList[i].DisinfectionTypeText, DisinfectionTypeEnumTextOrderedList[i].DisinfectionTypeText);
                    Assert.AreEqual(DisinfectionTypeEnumList[i].DisinfectionType, DisinfectionTypeEnumTextOrderedList[i].DisinfectionType);
                }
            }
        }
        [TestMethod]
        public void Enums_EmailTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<EmailTypeEnumTextOrdered> EmailTypeEnumList = new List<EmailTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(EmailTypeEnum)).Length; i < count; i++)
                {
                    EmailTypeEnumList.Add(new EmailTypeEnumTextOrdered() { EmailType = (EmailTypeEnum)i, EmailTypeText = enums.GetEnumText_EmailTypeEnum((EmailTypeEnum)i) });
                }
                EmailTypeEnumList = EmailTypeEnumList.OrderBy(c => c.EmailTypeText).ToList();

                List<EmailTypeEnumTextOrdered> EmailTypeEnumTextOrderedList = enums.GetEmailTypeEnumTextOrderedList();
                Assert.AreEqual(EmailTypeEnumList.Count, EmailTypeEnumTextOrderedList.Count);

                EmailTypeEnumTextOrdered EmailTypeEnumTextOrdered = new EmailTypeEnumTextOrdered();
                Assert.IsNotNull(EmailTypeEnumTextOrdered);

                for (int i = 0, count = EmailTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(EmailTypeEnumList[i].EmailTypeText, EmailTypeEnumTextOrderedList[i].EmailTypeText);
                    Assert.AreEqual(EmailTypeEnumList[i].EmailType, EmailTypeEnumTextOrderedList[i].EmailType);
                }
            }
        }
        [TestMethod]
        public void Enums_FacilityTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<FacilityTypeEnumTextOrdered> FacilityTypeEnumList = new List<FacilityTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(FacilityTypeEnum)).Length; i < count; i++)
                {
                    FacilityTypeEnumList.Add(new FacilityTypeEnumTextOrdered() { FacilityType = (FacilityTypeEnum)i, FacilityTypeText = enums.GetEnumText_FacilityTypeEnum((FacilityTypeEnum)i) });
                }
                FacilityTypeEnumList = FacilityTypeEnumList.OrderBy(c => c.FacilityTypeText).ToList();

                List<FacilityTypeEnumTextOrdered> FacilityTypeEnumTextOrderedList = enums.GetFacilityTypeEnumTextOrderedList();
                Assert.AreEqual(FacilityTypeEnumList.Count, FacilityTypeEnumTextOrderedList.Count);

                FacilityTypeEnumTextOrdered FacilityTypeEnumTextOrdered = new FacilityTypeEnumTextOrdered();
                Assert.IsNotNull(FacilityTypeEnumTextOrdered);

                for (int i = 0, count = FacilityTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(FacilityTypeEnumList[i].FacilityTypeText, FacilityTypeEnumTextOrderedList[i].FacilityTypeText);
                    Assert.AreEqual(FacilityTypeEnumList[i].FacilityType, FacilityTypeEnumTextOrderedList[i].FacilityType);
                }
            }
        }
        [TestMethod]
        public void Enums_FilePurposeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<FilePurposeEnumTextOrdered> FilePurposeEnumList = new List<FilePurposeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(FilePurposeEnum)).Length; i < count; i++)
                {
                    FilePurposeEnumList.Add(new FilePurposeEnumTextOrdered() { FilePurpose = (FilePurposeEnum)i, FilePurposeText = enums.GetEnumText_FilePurposeEnum((FilePurposeEnum)i) });
                }
                FilePurposeEnumList = FilePurposeEnumList.OrderBy(c => c.FilePurposeText).ToList();

                List<FilePurposeEnumTextOrdered> FilePurposeEnumTextOrderedList = enums.GetFilePurposeEnumTextOrderedList();
                Assert.AreEqual(FilePurposeEnumList.Count, FilePurposeEnumTextOrderedList.Count);

                FilePurposeEnumTextOrdered FilePurposeEnumTextOrdered = new FilePurposeEnumTextOrdered();
                Assert.IsNotNull(FilePurposeEnumTextOrdered);

                for (int i = 0, count = FilePurposeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(FilePurposeEnumList[i].FilePurposeText, FilePurposeEnumTextOrderedList[i].FilePurposeText);
                    Assert.AreEqual(FilePurposeEnumList[i].FilePurpose, FilePurposeEnumTextOrderedList[i].FilePurpose);
                }
            }
        }
        [TestMethod]
        public void Enums_FileStatusEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<FileStatusEnumTextOrdered> FileStatusEnumList = new List<FileStatusEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(FileStatusEnum)).Length; i < count; i++)
                {
                    FileStatusEnumList.Add(new FileStatusEnumTextOrdered() { FileStatus = (FileStatusEnum)i, FileStatusText = enums.GetEnumText_FileStatusEnum((FileStatusEnum)i) });
                }
                FileStatusEnumList = FileStatusEnumList.OrderBy(c => c.FileStatusText).ToList();

                List<FileStatusEnumTextOrdered> FileStatusEnumTextOrderedList = enums.GetFileStatusEnumTextOrderedList();
                Assert.AreEqual(FileStatusEnumList.Count, FileStatusEnumTextOrderedList.Count);

                FileStatusEnumTextOrdered FileStatusEnumTextOrdered = new FileStatusEnumTextOrdered();
                Assert.IsNotNull(FileStatusEnumTextOrdered);

                for (int i = 0, count = FileStatusEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(FileStatusEnumList[i].FileStatusText, FileStatusEnumTextOrderedList[i].FileStatusText);
                    Assert.AreEqual(FileStatusEnumList[i].FileStatus, FileStatusEnumTextOrderedList[i].FileStatus);
                }
            }
        }
        [TestMethod]
        public void Enums_FileTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<FileTypeEnumTextOrdered> FileTypeEnumList = new List<FileTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(FileTypeEnum)).Length; i < count; i++)
                {
                    FileTypeEnumList.Add(new FileTypeEnumTextOrdered() { FileType = (FileTypeEnum)i, FileTypeText = enums.GetEnumText_FileTypeEnum((FileTypeEnum)i) });
                }
                FileTypeEnumList = FileTypeEnumList.OrderBy(c => c.FileTypeText).ToList();

                List<FileTypeEnumTextOrdered> FileTypeEnumTextOrderedList = enums.GetFileTypeEnumTextOrderedList();
                Assert.AreEqual(FileTypeEnumList.Count, FileTypeEnumTextOrderedList.Count);

                FileTypeEnumTextOrdered FileTypeEnumTextOrdered = new FileTypeEnumTextOrdered();
                Assert.IsNotNull(FileTypeEnumTextOrdered);

                for (int i = 0, count = FileTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(FileTypeEnumList[i].FileTypeText, FileTypeEnumTextOrderedList[i].FileTypeText);
                    Assert.AreEqual(FileTypeEnumList[i].FileType, FileTypeEnumTextOrderedList[i].FileType);
                }
            }
        }
        [TestMethod]
        public void Enums_InfrastructureTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<InfrastructureTypeEnumTextOrdered> InfrastructureTypeEnumList = new List<InfrastructureTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(InfrastructureTypeEnum)).Length; i < count; i++)
                {
                    InfrastructureTypeEnumList.Add(new InfrastructureTypeEnumTextOrdered() { InfrastructureType = (InfrastructureTypeEnum)i, InfrastructureTypeText = enums.GetEnumText_InfrastructureTypeEnum((InfrastructureTypeEnum)i) });
                }
                InfrastructureTypeEnumList = InfrastructureTypeEnumList.OrderBy(c => c.InfrastructureTypeText).ToList();

                List<InfrastructureTypeEnumTextOrdered> InfrastructureTypeEnumTextOrderedList = enums.GetInfrastructureTypeEnumTextOrderedList();
                Assert.AreEqual(InfrastructureTypeEnumList.Count, InfrastructureTypeEnumTextOrderedList.Count);

                InfrastructureTypeEnumTextOrdered InfrastructureTypeEnumTextOrdered = new InfrastructureTypeEnumTextOrdered();
                Assert.IsNotNull(InfrastructureTypeEnumTextOrdered);

                for (int i = 0, count = InfrastructureTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(InfrastructureTypeEnumList[i].InfrastructureTypeText, InfrastructureTypeEnumTextOrderedList[i].InfrastructureTypeText);
                    Assert.AreEqual(InfrastructureTypeEnumList[i].InfrastructureType, InfrastructureTypeEnumTextOrderedList[i].InfrastructureType);
                }
            }
        }
        [TestMethod]
        public void Enums_KMZActionEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<KMZActionEnumTextOrdered> KMZActionEnumList = new List<KMZActionEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(KMZActionEnum)).Length; i < count; i++)
                {
                    KMZActionEnumList.Add(new KMZActionEnumTextOrdered() { KMZAction = (KMZActionEnum)i, KMZActionText = enums.GetEnumText_KMZActionEnum((KMZActionEnum)i) });
                }
                KMZActionEnumList = KMZActionEnumList.OrderBy(c => c.KMZActionText).ToList();

                List<KMZActionEnumTextOrdered> KMZActionEnumTextOrderedList = enums.GetKMZActionEnumTextOrderedList();
                Assert.AreEqual(KMZActionEnumList.Count, KMZActionEnumTextOrderedList.Count);

                KMZActionEnumTextOrdered KMZActionEnumTextOrdered = new KMZActionEnumTextOrdered();
                Assert.IsNotNull(KMZActionEnumTextOrdered);

                for (int i = 0, count = KMZActionEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(KMZActionEnumList[i].KMZActionText, KMZActionEnumTextOrderedList[i].KMZActionText);
                    Assert.AreEqual(KMZActionEnumList[i].KMZAction, KMZActionEnumTextOrderedList[i].KMZAction);
                }
            }
        }
        [TestMethod]
        public void Enums_LaboratoryEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<LaboratoryEnumTextOrdered> LaboratoryEnumList = new List<LaboratoryEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(LaboratoryEnum)).Length; i < count; i++)
                {
                    LaboratoryEnumList.Add(new LaboratoryEnumTextOrdered() { Laboratory = (LaboratoryEnum)i, LaboratoryText = enums.GetEnumText_LaboratoryEnum((LaboratoryEnum)i) });
                }
                LaboratoryEnumList = LaboratoryEnumList.OrderBy(c => c.LaboratoryText).ToList();

                List<LaboratoryEnumTextOrdered> LaboratoryEnumTextOrderedList = enums.GetLaboratoryEnumTextOrderedList();
                Assert.AreEqual(LaboratoryEnumList.Count, LaboratoryEnumTextOrderedList.Count);

                LaboratoryEnumTextOrdered LaboratoryEnumTextOrdered = new LaboratoryEnumTextOrdered();
                Assert.IsNotNull(LaboratoryEnumTextOrdered);

                for (int i = 0, count = LaboratoryEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(LaboratoryEnumList[i].LaboratoryText, LaboratoryEnumTextOrderedList[i].LaboratoryText);
                    Assert.AreEqual(LaboratoryEnumList[i].Laboratory, LaboratoryEnumTextOrderedList[i].Laboratory);
                }
            }
        }
        [TestMethod]
        public void Enums_LabSheetStatusEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<LabSheetStatusEnumTextOrdered> LabSheetStatusEnumList = new List<LabSheetStatusEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(LabSheetStatusEnum)).Length; i < count; i++)
                {
                    LabSheetStatusEnumList.Add(new LabSheetStatusEnumTextOrdered() { LabSheetStatus = (LabSheetStatusEnum)i, LabSheetStatusText = enums.GetEnumText_LabSheetStatusEnum((LabSheetStatusEnum)i) });
                }
                LabSheetStatusEnumList = LabSheetStatusEnumList.OrderBy(c => c.LabSheetStatusText).ToList();

                List<LabSheetStatusEnumTextOrdered> LabSheetStatusEnumTextOrderedList = enums.GetLabSheetStatusEnumTextOrderedList();
                Assert.AreEqual(LabSheetStatusEnumList.Count, LabSheetStatusEnumTextOrderedList.Count);

                LabSheetStatusEnumTextOrdered LabSheetStatusEnumTextOrdered = new LabSheetStatusEnumTextOrdered();
                Assert.IsNotNull(LabSheetStatusEnumTextOrdered);

                for (int i = 0, count = LabSheetStatusEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(LabSheetStatusEnumList[i].LabSheetStatusText, LabSheetStatusEnumTextOrderedList[i].LabSheetStatusText);
                    Assert.AreEqual(LabSheetStatusEnumList[i].LabSheetStatus, LabSheetStatusEnumTextOrderedList[i].LabSheetStatus);
                }
            }
        }
        [TestMethod]
        public void Enums_LabSheetTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<LabSheetTypeEnumTextOrdered> LabSheetTypeEnumList = new List<LabSheetTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(LabSheetTypeEnum)).Length; i < count; i++)
                {
                    LabSheetTypeEnumList.Add(new LabSheetTypeEnumTextOrdered() { LabSheetType = (LabSheetTypeEnum)i, LabSheetTypeText = enums.GetEnumText_LabSheetTypeEnum((LabSheetTypeEnum)i) });
                }
                LabSheetTypeEnumList = LabSheetTypeEnumList.OrderBy(c => c.LabSheetTypeText).ToList();

                List<LabSheetTypeEnumTextOrdered> LabSheetTypeEnumTextOrderedList = enums.GetLabSheetTypeEnumTextOrderedList();
                Assert.AreEqual(LabSheetTypeEnumList.Count, LabSheetTypeEnumTextOrderedList.Count);

                LabSheetTypeEnumTextOrdered LabSheetTypeEnumTextOrdered = new LabSheetTypeEnumTextOrdered();
                Assert.IsNotNull(LabSheetTypeEnumTextOrdered);

                for (int i = 0, count = LabSheetTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(LabSheetTypeEnumList[i].LabSheetTypeText, LabSheetTypeEnumTextOrderedList[i].LabSheetTypeText);
                    Assert.AreEqual(LabSheetTypeEnumList[i].LabSheetType, LabSheetTypeEnumTextOrderedList[i].LabSheetType);
                }
            }
        }
        [TestMethod]
        public void Enums_LanguageEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<LanguageEnumTextOrdered> LanguageEnumList = new List<LanguageEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(LanguageEnum)).Length; i < count; i++)
                {
                    LanguageEnumList.Add(new LanguageEnumTextOrdered() { Language = (LanguageEnum)i, LanguageText = enums.GetEnumText_LanguageEnum((LanguageEnum)i) });
                }
                LanguageEnumList = LanguageEnumList.OrderBy(c => c.LanguageText).ToList();

                List<LanguageEnumTextOrdered> LanguageEnumTextOrderedList = enums.GetLanguageEnumTextOrderedList();
                Assert.AreEqual(LanguageEnumList.Count, LanguageEnumTextOrderedList.Count);

                LanguageEnumTextOrdered LanguageEnumTextOrdered = new LanguageEnumTextOrdered();
                Assert.IsNotNull(LanguageEnumTextOrdered);

                for (int i = 0, count = LanguageEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(LanguageEnumList[i].LanguageText, LanguageEnumTextOrderedList[i].LanguageText);
                    Assert.AreEqual(LanguageEnumList[i].Language, LanguageEnumTextOrderedList[i].Language);
                }
            }
        }
        [TestMethod]
        public void Enums_LogCommandEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<LogCommandEnumTextOrdered> LogCommandEnumList = new List<LogCommandEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(LogCommandEnum)).Length; i < count; i++)
                {
                    LogCommandEnumList.Add(new LogCommandEnumTextOrdered() { LogCommand = (LogCommandEnum)i, LogCommandText = enums.GetEnumText_LogCommandEnum((LogCommandEnum)i) });
                }
                LogCommandEnumList = LogCommandEnumList.OrderBy(c => c.LogCommandText).ToList();

                List<LogCommandEnumTextOrdered> LogCommandEnumTextOrderedList = enums.GetLogCommandEnumTextOrderedList();
                Assert.AreEqual(LogCommandEnumList.Count, LogCommandEnumTextOrderedList.Count);

                LogCommandEnumTextOrdered LogCommandEnumTextOrdered = new LogCommandEnumTextOrdered();
                Assert.IsNotNull(LogCommandEnumTextOrdered);

                for (int i = 0, count = LogCommandEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(LogCommandEnumList[i].LogCommandText, LogCommandEnumTextOrderedList[i].LogCommandText);
                    Assert.AreEqual(LogCommandEnumList[i].LogCommand, LogCommandEnumTextOrderedList[i].LogCommand);
                }
            }
        }
        [TestMethod]
        public void Enums_MapInfoDrawTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<MapInfoDrawTypeEnumTextOrdered> MapInfoDrawTypeEnumList = new List<MapInfoDrawTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(MapInfoDrawTypeEnum)).Length; i < count; i++)
                {
                    MapInfoDrawTypeEnumList.Add(new MapInfoDrawTypeEnumTextOrdered() { MapInfoDrawType = (MapInfoDrawTypeEnum)i, MapInfoDrawTypeText = enums.GetEnumText_MapInfoDrawTypeEnum((MapInfoDrawTypeEnum)i) });
                }
                MapInfoDrawTypeEnumList = MapInfoDrawTypeEnumList.OrderBy(c => c.MapInfoDrawTypeText).ToList();

                List<MapInfoDrawTypeEnumTextOrdered> MapInfoDrawTypeEnumTextOrderedList = enums.GetMapInfoDrawTypeEnumTextOrderedList();
                Assert.AreEqual(MapInfoDrawTypeEnumList.Count, MapInfoDrawTypeEnumTextOrderedList.Count);

                MapInfoDrawTypeEnumTextOrdered MapInfoDrawTypeEnumTextOrdered = new MapInfoDrawTypeEnumTextOrdered();
                Assert.IsNotNull(MapInfoDrawTypeEnumTextOrdered);

                for (int i = 0, count = MapInfoDrawTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(MapInfoDrawTypeEnumList[i].MapInfoDrawTypeText, MapInfoDrawTypeEnumTextOrderedList[i].MapInfoDrawTypeText);
                    Assert.AreEqual(MapInfoDrawTypeEnumList[i].MapInfoDrawType, MapInfoDrawTypeEnumTextOrderedList[i].MapInfoDrawType);
                }
            }
        }
        [TestMethod]
        public void Enums_MikeBoundaryConditionLevelOrVelocityEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<MikeBoundaryConditionLevelOrVelocityEnumTextOrdered> MikeBoundaryConditionLevelOrVelocityEnumList = new List<MikeBoundaryConditionLevelOrVelocityEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(MikeBoundaryConditionLevelOrVelocityEnum)).Length; i < count; i++)
                {
                    MikeBoundaryConditionLevelOrVelocityEnumList.Add(new MikeBoundaryConditionLevelOrVelocityEnumTextOrdered() { MikeBoundaryConditionLevelOrVelocity = (MikeBoundaryConditionLevelOrVelocityEnum)i, MikeBoundaryConditionLevelOrVelocityText = enums.GetEnumText_MikeBoundaryConditionLevelOrVelocityEnum((MikeBoundaryConditionLevelOrVelocityEnum)i) });
                }
                MikeBoundaryConditionLevelOrVelocityEnumList = MikeBoundaryConditionLevelOrVelocityEnumList.OrderBy(c => c.MikeBoundaryConditionLevelOrVelocityText).ToList();

                List<MikeBoundaryConditionLevelOrVelocityEnumTextOrdered> MikeBoundaryConditionLevelOrVelocityEnumTextOrderedList = enums.GetMikeBoundaryConditionLevelOrVelocityEnumTextOrderedList();
                Assert.AreEqual(MikeBoundaryConditionLevelOrVelocityEnumList.Count, MikeBoundaryConditionLevelOrVelocityEnumTextOrderedList.Count);

                MikeBoundaryConditionLevelOrVelocityEnumTextOrdered MikeBoundaryConditionLevelOrVelocityEnumTextOrdered = new MikeBoundaryConditionLevelOrVelocityEnumTextOrdered();
                Assert.IsNotNull(MikeBoundaryConditionLevelOrVelocityEnumTextOrdered);

                for (int i = 0, count = MikeBoundaryConditionLevelOrVelocityEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(MikeBoundaryConditionLevelOrVelocityEnumList[i].MikeBoundaryConditionLevelOrVelocityText, MikeBoundaryConditionLevelOrVelocityEnumTextOrderedList[i].MikeBoundaryConditionLevelOrVelocityText);
                    Assert.AreEqual(MikeBoundaryConditionLevelOrVelocityEnumList[i].MikeBoundaryConditionLevelOrVelocity, MikeBoundaryConditionLevelOrVelocityEnumTextOrderedList[i].MikeBoundaryConditionLevelOrVelocity);
                }
            }
        }
        [TestMethod]
        public void Enums_MikeScenarioSpecialResultKMLTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<MikeScenarioSpecialResultKMLTypeEnumTextOrdered> MikeScenarioSpecialResultKMLTypeEnumList = new List<MikeScenarioSpecialResultKMLTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(MikeScenarioSpecialResultKMLTypeEnum)).Length; i < count; i++)
                {
                    MikeScenarioSpecialResultKMLTypeEnumList.Add(new MikeScenarioSpecialResultKMLTypeEnumTextOrdered() { MikeScenarioSpecialResultKMLType = (MikeScenarioSpecialResultKMLTypeEnum)i, MikeScenarioSpecialResultKMLTypeText = enums.GetEnumText_MikeScenarioSpecialResultKMLTypeEnum((MikeScenarioSpecialResultKMLTypeEnum)i) });
                }
                MikeScenarioSpecialResultKMLTypeEnumList = MikeScenarioSpecialResultKMLTypeEnumList.OrderBy(c => c.MikeScenarioSpecialResultKMLTypeText).ToList();

                List<MikeScenarioSpecialResultKMLTypeEnumTextOrdered> MikeScenarioSpecialResultKMLTypeEnumTextOrderedList = enums.GetMikeScenarioSpecialResultKMLTypeEnumTextOrderedList();
                Assert.AreEqual(MikeScenarioSpecialResultKMLTypeEnumList.Count, MikeScenarioSpecialResultKMLTypeEnumTextOrderedList.Count);

                MikeScenarioSpecialResultKMLTypeEnumTextOrdered MikeScenarioSpecialResultKMLTypeEnumTextOrdered = new MikeScenarioSpecialResultKMLTypeEnumTextOrdered();
                Assert.IsNotNull(MikeScenarioSpecialResultKMLTypeEnumTextOrdered);

                for (int i = 0, count = MikeScenarioSpecialResultKMLTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(MikeScenarioSpecialResultKMLTypeEnumList[i].MikeScenarioSpecialResultKMLTypeText, MikeScenarioSpecialResultKMLTypeEnumTextOrderedList[i].MikeScenarioSpecialResultKMLTypeText);
                    Assert.AreEqual(MikeScenarioSpecialResultKMLTypeEnumList[i].MikeScenarioSpecialResultKMLType, MikeScenarioSpecialResultKMLTypeEnumTextOrderedList[i].MikeScenarioSpecialResultKMLType);
                }
            }
        }
        [TestMethod]
        public void Enums_MWQMSiteLatestClassificationEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<MWQMSiteLatestClassificationEnumTextOrdered> MWQMSiteLatestClassificationEnumList = new List<MWQMSiteLatestClassificationEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(MWQMSiteLatestClassificationEnum)).Length; i < count; i++)
                {
                    MWQMSiteLatestClassificationEnumList.Add(new MWQMSiteLatestClassificationEnumTextOrdered() { MWQMSiteLatestClassification = (MWQMSiteLatestClassificationEnum)i, MWQMSiteLatestClassificationText = enums.GetEnumText_MWQMSiteLatestClassificationEnum((MWQMSiteLatestClassificationEnum)i) });
                }
                MWQMSiteLatestClassificationEnumList = MWQMSiteLatestClassificationEnumList.OrderBy(c => c.MWQMSiteLatestClassificationText).ToList();

                List<MWQMSiteLatestClassificationEnumTextOrdered> MWQMSiteLatestClassificationEnumTextOrderedList = enums.GetMWQMSiteLatestClassificationEnumTextOrderedList();
                Assert.AreEqual(MWQMSiteLatestClassificationEnumList.Count, MWQMSiteLatestClassificationEnumTextOrderedList.Count);

                MWQMSiteLatestClassificationEnumTextOrdered MWQMSiteLatestClassificationEnumTextOrdered = new MWQMSiteLatestClassificationEnumTextOrdered();
                Assert.IsNotNull(MWQMSiteLatestClassificationEnumTextOrdered);

                for (int i = 0, count = MWQMSiteLatestClassificationEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(MWQMSiteLatestClassificationEnumList[i].MWQMSiteLatestClassificationText, MWQMSiteLatestClassificationEnumTextOrderedList[i].MWQMSiteLatestClassificationText);
                    Assert.AreEqual(MWQMSiteLatestClassificationEnumList[i].MWQMSiteLatestClassification, MWQMSiteLatestClassificationEnumTextOrderedList[i].MWQMSiteLatestClassification);
                }
            }
        }
        [TestMethod]
        public void Enums_PolSourceInactiveReasonEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<PolSourceInactiveReasonEnumTextOrdered> PolSourceInactiveReasonEnumList = new List<PolSourceInactiveReasonEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(PolSourceInactiveReasonEnum)).Length; i < count; i++)
                {
                    PolSourceInactiveReasonEnumList.Add(new PolSourceInactiveReasonEnumTextOrdered() { PolSourceInactiveReason = (PolSourceInactiveReasonEnum)i, PolSourceInactiveReasonText = enums.GetEnumText_PolSourceInactiveReasonEnum((PolSourceInactiveReasonEnum)i) });
                }
                PolSourceInactiveReasonEnumList = PolSourceInactiveReasonEnumList.OrderBy(c => c.PolSourceInactiveReasonText).ToList();

                List<PolSourceInactiveReasonEnumTextOrdered> PolSourceInactiveReasonEnumTextOrderedList = enums.GetPolSourceInactiveReasonEnumTextOrderedList();
                Assert.AreEqual(PolSourceInactiveReasonEnumList.Count, PolSourceInactiveReasonEnumTextOrderedList.Count);

                PolSourceInactiveReasonEnumTextOrdered PolSourceInactiveReasonEnumTextOrdered = new PolSourceInactiveReasonEnumTextOrdered();
                Assert.IsNotNull(PolSourceInactiveReasonEnumTextOrdered);

                for (int i = 0, count = PolSourceInactiveReasonEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(PolSourceInactiveReasonEnumList[i].PolSourceInactiveReasonText, PolSourceInactiveReasonEnumTextOrderedList[i].PolSourceInactiveReasonText);
                    Assert.AreEqual(PolSourceInactiveReasonEnumList[i].PolSourceInactiveReason, PolSourceInactiveReasonEnumTextOrderedList[i].PolSourceInactiveReason);
                }
            }
        }
        [TestMethod]
        public void Enums_PolSourceIssueRiskEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<PolSourceIssueRiskEnumTextOrdered> PolSourceIssueRiskEnumList = new List<PolSourceIssueRiskEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(PolSourceIssueRiskEnum)).Length; i < count; i++)
                {
                    PolSourceIssueRiskEnumList.Add(new PolSourceIssueRiskEnumTextOrdered() { PolSourceIssueRisk = (PolSourceIssueRiskEnum)i, PolSourceIssueRiskText = enums.GetEnumText_PolSourceIssueRiskEnum((PolSourceIssueRiskEnum)i) });
                }
                PolSourceIssueRiskEnumList = PolSourceIssueRiskEnumList.OrderBy(c => c.PolSourceIssueRiskText).ToList();

                List<PolSourceIssueRiskEnumTextOrdered> PolSourceIssueRiskEnumTextOrderedList = enums.GetPolSourceIssueRiskEnumTextOrderedList();
                Assert.AreEqual(PolSourceIssueRiskEnumList.Count, PolSourceIssueRiskEnumTextOrderedList.Count);

                PolSourceIssueRiskEnumTextOrdered PolSourceIssueRiskEnumTextOrdered = new PolSourceIssueRiskEnumTextOrdered();
                Assert.IsNotNull(PolSourceIssueRiskEnumTextOrdered);

                for (int i = 0, count = PolSourceIssueRiskEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(PolSourceIssueRiskEnumList[i].PolSourceIssueRiskText, PolSourceIssueRiskEnumTextOrderedList[i].PolSourceIssueRiskText);
                    Assert.AreEqual(PolSourceIssueRiskEnumList[i].PolSourceIssueRisk, PolSourceIssueRiskEnumTextOrderedList[i].PolSourceIssueRisk);
                }
            }
        }
        [TestMethod]
        public void Enums_PreliminaryTreatmentTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<PreliminaryTreatmentTypeEnumTextOrdered> PreliminaryTreatmentTypeEnumList = new List<PreliminaryTreatmentTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(PreliminaryTreatmentTypeEnum)).Length; i < count; i++)
                {
                    PreliminaryTreatmentTypeEnumList.Add(new PreliminaryTreatmentTypeEnumTextOrdered() { PreliminaryTreatmentType = (PreliminaryTreatmentTypeEnum)i, PreliminaryTreatmentTypeText = enums.GetEnumText_PreliminaryTreatmentTypeEnum((PreliminaryTreatmentTypeEnum)i) });
                }
                PreliminaryTreatmentTypeEnumList = PreliminaryTreatmentTypeEnumList.OrderBy(c => c.PreliminaryTreatmentTypeText).ToList();

                List<PreliminaryTreatmentTypeEnumTextOrdered> PreliminaryTreatmentTypeEnumTextOrderedList = enums.GetPreliminaryTreatmentTypeEnumTextOrderedList();
                Assert.AreEqual(PreliminaryTreatmentTypeEnumList.Count, PreliminaryTreatmentTypeEnumTextOrderedList.Count);

                PreliminaryTreatmentTypeEnumTextOrdered PreliminaryTreatmentTypeEnumTextOrdered = new PreliminaryTreatmentTypeEnumTextOrdered();
                Assert.IsNotNull(PreliminaryTreatmentTypeEnumTextOrdered);

                for (int i = 0, count = PreliminaryTreatmentTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(PreliminaryTreatmentTypeEnumList[i].PreliminaryTreatmentTypeText, PreliminaryTreatmentTypeEnumTextOrderedList[i].PreliminaryTreatmentTypeText);
                    Assert.AreEqual(PreliminaryTreatmentTypeEnumList[i].PreliminaryTreatmentType, PreliminaryTreatmentTypeEnumTextOrderedList[i].PreliminaryTreatmentType);
                }
            }
        }
        [TestMethod]
        public void Enums_PrimaryTreatmentTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<PrimaryTreatmentTypeEnumTextOrdered> PrimaryTreatmentTypeEnumList = new List<PrimaryTreatmentTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(PrimaryTreatmentTypeEnum)).Length; i < count; i++)
                {
                    PrimaryTreatmentTypeEnumList.Add(new PrimaryTreatmentTypeEnumTextOrdered() { PrimaryTreatmentType = (PrimaryTreatmentTypeEnum)i, PrimaryTreatmentTypeText = enums.GetEnumText_PrimaryTreatmentTypeEnum((PrimaryTreatmentTypeEnum)i) });
                }
                PrimaryTreatmentTypeEnumList = PrimaryTreatmentTypeEnumList.OrderBy(c => c.PrimaryTreatmentTypeText).ToList();

                List<PrimaryTreatmentTypeEnumTextOrdered> PrimaryTreatmentTypeEnumTextOrderedList = enums.GetPrimaryTreatmentTypeEnumTextOrderedList();
                Assert.AreEqual(PrimaryTreatmentTypeEnumList.Count, PrimaryTreatmentTypeEnumTextOrderedList.Count);

                PrimaryTreatmentTypeEnumTextOrdered PrimaryTreatmentTypeEnumTextOrdered = new PrimaryTreatmentTypeEnumTextOrdered();
                Assert.IsNotNull(PrimaryTreatmentTypeEnumTextOrdered);

                for (int i = 0, count = PrimaryTreatmentTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(PrimaryTreatmentTypeEnumList[i].PrimaryTreatmentTypeText, PrimaryTreatmentTypeEnumTextOrderedList[i].PrimaryTreatmentTypeText);
                    Assert.AreEqual(PrimaryTreatmentTypeEnumList[i].PrimaryTreatmentType, PrimaryTreatmentTypeEnumTextOrderedList[i].PrimaryTreatmentType);
                }
            }
        }
        [TestMethod]
        public void Enums_ReportConditionEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<ReportConditionEnumTextOrdered> ReportConditionEnumList = new List<ReportConditionEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(ReportConditionEnum)).Length; i < count; i++)
                {
                    ReportConditionEnumList.Add(new ReportConditionEnumTextOrdered() { ReportCondition = (ReportConditionEnum)i, ReportConditionText = enums.GetEnumText_ReportConditionEnum((ReportConditionEnum)i) });
                }
                ReportConditionEnumList = ReportConditionEnumList.OrderBy(c => c.ReportConditionText).ToList();

                List<ReportConditionEnumTextOrdered> ReportConditionEnumTextOrderedList = enums.GetReportConditionEnumTextOrderedList();
                Assert.AreEqual(ReportConditionEnumList.Count, ReportConditionEnumTextOrderedList.Count);

                ReportConditionEnumTextOrdered ReportConditionEnumTextOrdered = new ReportConditionEnumTextOrdered();
                Assert.IsNotNull(ReportConditionEnumTextOrdered);

                for (int i = 0, count = ReportConditionEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(ReportConditionEnumList[i].ReportConditionText, ReportConditionEnumTextOrderedList[i].ReportConditionText);
                    Assert.AreEqual(ReportConditionEnumList[i].ReportCondition, ReportConditionEnumTextOrderedList[i].ReportCondition);
                }
            }
        }
        [TestMethod]
        public void Enums_ReportFieldTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<ReportFieldTypeEnumTextOrdered> ReportFieldTypeEnumList = new List<ReportFieldTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(ReportFieldTypeEnum)).Length; i < count; i++)
                {
                    ReportFieldTypeEnumList.Add(new ReportFieldTypeEnumTextOrdered() { ReportFieldType = (ReportFieldTypeEnum)i, ReportFieldTypeText = enums.GetEnumText_ReportFieldTypeEnum((ReportFieldTypeEnum)i) });
                }
                ReportFieldTypeEnumList = ReportFieldTypeEnumList.OrderBy(c => c.ReportFieldTypeText).ToList();

                List<ReportFieldTypeEnumTextOrdered> ReportFieldTypeEnumTextOrderedList = enums.GetReportFieldTypeEnumTextOrderedList();
                Assert.AreEqual(ReportFieldTypeEnumList.Count, ReportFieldTypeEnumTextOrderedList.Count);

                ReportFieldTypeEnumTextOrdered ReportFieldTypeEnumTextOrdered = new ReportFieldTypeEnumTextOrdered();
                Assert.IsNotNull(ReportFieldTypeEnumTextOrdered);

                for (int i = 0, count = ReportFieldTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(ReportFieldTypeEnumList[i].ReportFieldTypeText, ReportFieldTypeEnumTextOrderedList[i].ReportFieldTypeText);
                    Assert.AreEqual(ReportFieldTypeEnumList[i].ReportFieldType, ReportFieldTypeEnumTextOrderedList[i].ReportFieldType);
                }
            }
        }
        [TestMethod]
        public void Enums_ReportFileTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<ReportFileTypeEnumTextOrdered> ReportFileTypeEnumList = new List<ReportFileTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(ReportFileTypeEnum)).Length; i < count; i++)
                {
                    ReportFileTypeEnumList.Add(new ReportFileTypeEnumTextOrdered() { ReportFileType = (ReportFileTypeEnum)i, ReportFileTypeText = enums.GetEnumText_ReportFileTypeEnum((ReportFileTypeEnum)i) });
                }
                ReportFileTypeEnumList = ReportFileTypeEnumList.OrderBy(c => c.ReportFileTypeText).ToList();

                List<ReportFileTypeEnumTextOrdered> ReportFileTypeEnumTextOrderedList = enums.GetReportFileTypeEnumTextOrderedList();
                Assert.AreEqual(ReportFileTypeEnumList.Count, ReportFileTypeEnumTextOrderedList.Count);

                ReportFileTypeEnumTextOrdered ReportFileTypeEnumTextOrdered = new ReportFileTypeEnumTextOrdered();
                Assert.IsNotNull(ReportFileTypeEnumTextOrdered);

                for (int i = 0, count = ReportFileTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(ReportFileTypeEnumList[i].ReportFileTypeText, ReportFileTypeEnumTextOrderedList[i].ReportFileTypeText);
                    Assert.AreEqual(ReportFileTypeEnumList[i].ReportFileType, ReportFileTypeEnumTextOrderedList[i].ReportFileType);
                }
            }
        }
        [TestMethod]
        public void Enums_ReportFormatingDateEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<ReportFormatingDateEnumTextOrdered> ReportFormatingDateEnumList = new List<ReportFormatingDateEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(ReportFormatingDateEnum)).Length; i < count; i++)
                {
                    ReportFormatingDateEnumList.Add(new ReportFormatingDateEnumTextOrdered() { ReportFormatingDate = (ReportFormatingDateEnum)i, ReportFormatingDateText = enums.GetEnumText_ReportFormatingDateEnum((ReportFormatingDateEnum)i) });
                }
                ReportFormatingDateEnumList = ReportFormatingDateEnumList.OrderBy(c => c.ReportFormatingDateText).ToList();

                List<ReportFormatingDateEnumTextOrdered> ReportFormatingDateEnumTextOrderedList = enums.GetReportFormatingDateEnumTextOrderedList();
                Assert.AreEqual(ReportFormatingDateEnumList.Count, ReportFormatingDateEnumTextOrderedList.Count);

                ReportFormatingDateEnumTextOrdered ReportFormatingDateEnumTextOrdered = new ReportFormatingDateEnumTextOrdered();
                Assert.IsNotNull(ReportFormatingDateEnumTextOrdered);

                for (int i = 0, count = ReportFormatingDateEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(ReportFormatingDateEnumList[i].ReportFormatingDateText, ReportFormatingDateEnumTextOrderedList[i].ReportFormatingDateText);
                    Assert.AreEqual(ReportFormatingDateEnumList[i].ReportFormatingDate, ReportFormatingDateEnumTextOrderedList[i].ReportFormatingDate);
                }
            }
        }
        [TestMethod]
        public void Enums_ReportFormatingNumberEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<ReportFormatingNumberEnumTextOrdered> ReportFormatingNumberEnumList = new List<ReportFormatingNumberEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(ReportFormatingNumberEnum)).Length; i < count; i++)
                {
                    ReportFormatingNumberEnumList.Add(new ReportFormatingNumberEnumTextOrdered() { ReportFormatingNumber = (ReportFormatingNumberEnum)i, ReportFormatingNumberText = enums.GetEnumText_ReportFormatingNumberEnum((ReportFormatingNumberEnum)i) });
                }
                ReportFormatingNumberEnumList = ReportFormatingNumberEnumList.OrderBy(c => c.ReportFormatingNumberText).ToList();

                List<ReportFormatingNumberEnumTextOrdered> ReportFormatingNumberEnumTextOrderedList = enums.GetReportFormatingNumberEnumTextOrderedList();
                Assert.AreEqual(ReportFormatingNumberEnumList.Count, ReportFormatingNumberEnumTextOrderedList.Count);

                ReportFormatingNumberEnumTextOrdered ReportFormatingNumberEnumTextOrdered = new ReportFormatingNumberEnumTextOrdered();
                Assert.IsNotNull(ReportFormatingNumberEnumTextOrdered);

                for (int i = 0, count = ReportFormatingNumberEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(ReportFormatingNumberEnumList[i].ReportFormatingNumberText, ReportFormatingNumberEnumTextOrderedList[i].ReportFormatingNumberText);
                    Assert.AreEqual(ReportFormatingNumberEnumList[i].ReportFormatingNumber, ReportFormatingNumberEnumTextOrderedList[i].ReportFormatingNumber);
                }
            }
        }
        [TestMethod]
        public void Enums_ReportSortingEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<ReportSortingEnumTextOrdered> ReportSortingEnumList = new List<ReportSortingEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(ReportSortingEnum)).Length; i < count; i++)
                {
                    ReportSortingEnumList.Add(new ReportSortingEnumTextOrdered() { ReportSorting = (ReportSortingEnum)i, ReportSortingText = enums.GetEnumText_ReportSortingEnum((ReportSortingEnum)i) });
                }
                ReportSortingEnumList = ReportSortingEnumList.OrderBy(c => c.ReportSortingText).ToList();

                List<ReportSortingEnumTextOrdered> ReportSortingEnumTextOrderedList = enums.GetReportSortingEnumTextOrderedList();
                Assert.AreEqual(ReportSortingEnumList.Count, ReportSortingEnumTextOrderedList.Count);

                ReportSortingEnumTextOrdered ReportSortingEnumTextOrdered = new ReportSortingEnumTextOrdered();
                Assert.IsNotNull(ReportSortingEnumTextOrdered);

                for (int i = 0, count = ReportSortingEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(ReportSortingEnumList[i].ReportSortingText, ReportSortingEnumTextOrderedList[i].ReportSortingText);
                    Assert.AreEqual(ReportSortingEnumList[i].ReportSorting, ReportSortingEnumTextOrderedList[i].ReportSorting);
                }
            }
        }
        [TestMethod]
        public void Enums_ReportTreeNodeSubTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<ReportTreeNodeSubTypeEnumTextOrdered> ReportTreeNodeSubTypeEnumList = new List<ReportTreeNodeSubTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(ReportTreeNodeSubTypeEnum)).Length; i < count; i++)
                {
                    ReportTreeNodeSubTypeEnumList.Add(new ReportTreeNodeSubTypeEnumTextOrdered() { ReportTreeNodeSubType = (ReportTreeNodeSubTypeEnum)i, ReportTreeNodeSubTypeText = enums.GetEnumText_ReportTreeNodeSubTypeEnum((ReportTreeNodeSubTypeEnum)i) });
                }
                ReportTreeNodeSubTypeEnumList = ReportTreeNodeSubTypeEnumList.OrderBy(c => c.ReportTreeNodeSubTypeText).ToList();

                List<ReportTreeNodeSubTypeEnumTextOrdered> ReportTreeNodeSubTypeEnumTextOrderedList = enums.GetReportTreeNodeSubTypeEnumTextOrderedList();
                Assert.AreEqual(ReportTreeNodeSubTypeEnumList.Count, ReportTreeNodeSubTypeEnumTextOrderedList.Count);

                ReportTreeNodeSubTypeEnumTextOrdered ReportTreeNodeSubTypeEnumTextOrdered = new ReportTreeNodeSubTypeEnumTextOrdered();
                Assert.IsNotNull(ReportTreeNodeSubTypeEnumTextOrdered);

                for (int i = 0, count = ReportTreeNodeSubTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(ReportTreeNodeSubTypeEnumList[i].ReportTreeNodeSubTypeText, ReportTreeNodeSubTypeEnumTextOrderedList[i].ReportTreeNodeSubTypeText);
                    Assert.AreEqual(ReportTreeNodeSubTypeEnumList[i].ReportTreeNodeSubType, ReportTreeNodeSubTypeEnumTextOrderedList[i].ReportTreeNodeSubType);
                }
            }
        }
        [TestMethod]
        public void Enums_ReportTreeNodeTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<ReportTreeNodeTypeEnumTextOrdered> ReportTreeNodeTypeEnumList = new List<ReportTreeNodeTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(ReportTreeNodeTypeEnum)).Length; i < count; i++)
                {
                    ReportTreeNodeTypeEnumList.Add(new ReportTreeNodeTypeEnumTextOrdered() { ReportTreeNodeType = (ReportTreeNodeTypeEnum)i, ReportTreeNodeTypeText = enums.GetEnumText_ReportTreeNodeTypeEnum((ReportTreeNodeTypeEnum)i) });
                }
                ReportTreeNodeTypeEnumList = ReportTreeNodeTypeEnumList.OrderBy(c => c.ReportTreeNodeTypeText).ToList();

                List<ReportTreeNodeTypeEnumTextOrdered> ReportTreeNodeTypeEnumTextOrderedList = enums.GetReportTreeNodeTypeEnumTextOrderedList();
                Assert.AreEqual(ReportTreeNodeTypeEnumList.Count, ReportTreeNodeTypeEnumTextOrderedList.Count);

                ReportTreeNodeTypeEnumTextOrdered ReportTreeNodeTypeEnumTextOrdered = new ReportTreeNodeTypeEnumTextOrdered();
                Assert.IsNotNull(ReportTreeNodeTypeEnumTextOrdered);

                for (int i = 0, count = ReportTreeNodeTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(ReportTreeNodeTypeEnumList[i].ReportTreeNodeTypeText, ReportTreeNodeTypeEnumTextOrderedList[i].ReportTreeNodeTypeText);
                    Assert.AreEqual(ReportTreeNodeTypeEnumList[i].ReportTreeNodeType, ReportTreeNodeTypeEnumTextOrderedList[i].ReportTreeNodeType);
                }
            }
        }
        [TestMethod]
        public void Enums_SameDayNextDayEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<SameDayNextDayEnumTextOrdered> SameDayNextDayEnumList = new List<SameDayNextDayEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(SameDayNextDayEnum)).Length; i < count; i++)
                {
                    SameDayNextDayEnumList.Add(new SameDayNextDayEnumTextOrdered() { SameDayNextDay = (SameDayNextDayEnum)i, SameDayNextDayText = enums.GetEnumText_SameDayNextDayEnum((SameDayNextDayEnum)i) });
                }
                SameDayNextDayEnumList = SameDayNextDayEnumList.OrderBy(c => c.SameDayNextDayText).ToList();

                List<SameDayNextDayEnumTextOrdered> SameDayNextDayEnumTextOrderedList = enums.GetSameDayNextDayEnumTextOrderedList();
                Assert.AreEqual(SameDayNextDayEnumList.Count, SameDayNextDayEnumTextOrderedList.Count);

                SameDayNextDayEnumTextOrdered SameDayNextDayEnumTextOrdered = new SameDayNextDayEnumTextOrdered();
                Assert.IsNotNull(SameDayNextDayEnumTextOrdered);

                for (int i = 0, count = SameDayNextDayEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(SameDayNextDayEnumList[i].SameDayNextDayText, SameDayNextDayEnumTextOrderedList[i].SameDayNextDayText);
                    Assert.AreEqual(SameDayNextDayEnumList[i].SameDayNextDay, SameDayNextDayEnumTextOrderedList[i].SameDayNextDay);
                }
            }
        }
        [TestMethod]
        public void Enums_SampleMatrixEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<SampleMatrixEnumTextOrdered> SampleMatrixEnumList = new List<SampleMatrixEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(SampleMatrixEnum)).Length; i < count; i++)
                {
                    SampleMatrixEnumList.Add(new SampleMatrixEnumTextOrdered() { SampleMatrix = (SampleMatrixEnum)i, SampleMatrixText = enums.GetEnumText_SampleMatrixEnum((SampleMatrixEnum)i) });
                }
                SampleMatrixEnumList = SampleMatrixEnumList.OrderBy(c => c.SampleMatrixText).ToList();

                List<SampleMatrixEnumTextOrdered> SampleMatrixEnumTextOrderedList = enums.GetSampleMatrixEnumTextOrderedList();
                Assert.AreEqual(SampleMatrixEnumList.Count, SampleMatrixEnumTextOrderedList.Count);

                SampleMatrixEnumTextOrdered SampleMatrixEnumTextOrdered = new SampleMatrixEnumTextOrdered();
                Assert.IsNotNull(SampleMatrixEnumTextOrdered);

                for (int i = 0, count = SampleMatrixEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(SampleMatrixEnumList[i].SampleMatrixText, SampleMatrixEnumTextOrderedList[i].SampleMatrixText);
                    Assert.AreEqual(SampleMatrixEnumList[i].SampleMatrix, SampleMatrixEnumTextOrderedList[i].SampleMatrix);
                }
            }
        }
        [TestMethod]
        public void Enums_SampleStatusEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<SampleStatusEnumTextOrdered> SampleStatusEnumList = new List<SampleStatusEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(SampleStatusEnum)).Length; i < count; i++)
                {
                    SampleStatusEnumList.Add(new SampleStatusEnumTextOrdered() { SampleStatus = (SampleStatusEnum)i, SampleStatusText = enums.GetEnumText_SampleStatusEnum((SampleStatusEnum)i) });
                }
                SampleStatusEnumList = SampleStatusEnumList.OrderBy(c => c.SampleStatusText).ToList();

                List<SampleStatusEnumTextOrdered> SampleStatusEnumTextOrderedList = enums.GetSampleStatusEnumTextOrderedList();
                Assert.AreEqual(SampleStatusEnumList.Count, SampleStatusEnumTextOrderedList.Count);

                SampleStatusEnumTextOrdered SampleStatusEnumTextOrdered = new SampleStatusEnumTextOrdered();
                Assert.IsNotNull(SampleStatusEnumTextOrdered);

                for (int i = 0, count = SampleStatusEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(SampleStatusEnumList[i].SampleStatusText, SampleStatusEnumTextOrderedList[i].SampleStatusText);
                    Assert.AreEqual(SampleStatusEnumList[i].SampleStatus, SampleStatusEnumTextOrderedList[i].SampleStatus);
                }
            }
        }
        [TestMethod]
        public void Enums_SampleTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<SampleTypeEnumTextOrdered> SampleTypeEnumList = new List<SampleTypeEnumTextOrdered>();
                for (int i = 101, count = Enum.GetNames(typeof(SampleTypeEnum)).Length + 100; i < count; i++)
                {
                    SampleTypeEnumList.Add(new SampleTypeEnumTextOrdered() { SampleType = (SampleTypeEnum)i, SampleTypeText = enums.GetEnumText_SampleTypeEnum((SampleTypeEnum)i) });
                }
                SampleTypeEnumList = SampleTypeEnumList.OrderBy(c => c.SampleTypeText).ToList();

                List<SampleTypeEnumTextOrdered> SampleTypeEnumTextOrderedList = enums.GetSampleTypeEnumTextOrderedList();
                Assert.AreEqual(SampleTypeEnumList.Count, SampleTypeEnumTextOrderedList.Count);

                SampleTypeEnumTextOrdered SampleTypeEnumTextOrdered = new SampleTypeEnumTextOrdered();
                Assert.IsNotNull(SampleTypeEnumTextOrdered);

                for (int i = 0, count = SampleTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(SampleTypeEnumList[i].SampleTypeText, SampleTypeEnumTextOrderedList[i].SampleTypeText);
                    Assert.AreEqual(SampleTypeEnumList[i].SampleType, SampleTypeEnumTextOrderedList[i].SampleType);
                }
            }
        }
        [TestMethod]
        public void Enums_SamplingPlanTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<SamplingPlanTypeEnumTextOrdered> SamplingPlanTypeEnumList = new List<SamplingPlanTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(SamplingPlanTypeEnum)).Length; i < count; i++)
                {
                    SamplingPlanTypeEnumList.Add(new SamplingPlanTypeEnumTextOrdered() { SamplingPlanType = (SamplingPlanTypeEnum)i, SamplingPlanTypeText = enums.GetEnumText_SamplingPlanTypeEnum((SamplingPlanTypeEnum)i) });
                }
                SamplingPlanTypeEnumList = SamplingPlanTypeEnumList.OrderBy(c => c.SamplingPlanTypeText).ToList();

                List<SamplingPlanTypeEnumTextOrdered> SamplingPlanTypeEnumTextOrderedList = enums.GetSamplingPlanTypeEnumTextOrderedList();
                Assert.AreEqual(SamplingPlanTypeEnumList.Count, SamplingPlanTypeEnumTextOrderedList.Count);

                SamplingPlanTypeEnumTextOrdered SamplingPlanTypeEnumTextOrdered = new SamplingPlanTypeEnumTextOrdered();
                Assert.IsNotNull(SamplingPlanTypeEnumTextOrdered);

                for (int i = 0, count = SamplingPlanTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(SamplingPlanTypeEnumList[i].SamplingPlanTypeText, SamplingPlanTypeEnumTextOrderedList[i].SamplingPlanTypeText);
                    Assert.AreEqual(SamplingPlanTypeEnumList[i].SamplingPlanType, SamplingPlanTypeEnumTextOrderedList[i].SamplingPlanType);
                }
            }
        }
        [TestMethod]
        public void Enums_ScenarioStatusEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<ScenarioStatusEnumTextOrdered> ScenarioStatusEnumList = new List<ScenarioStatusEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(ScenarioStatusEnum)).Length; i < count; i++)
                {
                    ScenarioStatusEnumList.Add(new ScenarioStatusEnumTextOrdered() { ScenarioStatus = (ScenarioStatusEnum)i, ScenarioStatusText = enums.GetEnumText_ScenarioStatusEnum((ScenarioStatusEnum)i) });
                }
                ScenarioStatusEnumList = ScenarioStatusEnumList.OrderBy(c => c.ScenarioStatusText).ToList();

                List<ScenarioStatusEnumTextOrdered> ScenarioStatusEnumTextOrderedList = enums.GetScenarioStatusEnumTextOrderedList();
                Assert.AreEqual(ScenarioStatusEnumList.Count, ScenarioStatusEnumTextOrderedList.Count);

                ScenarioStatusEnumTextOrdered ScenarioStatusEnumTextOrdered = new ScenarioStatusEnumTextOrdered();
                Assert.IsNotNull(ScenarioStatusEnumTextOrdered);

                for (int i = 0, count = ScenarioStatusEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(ScenarioStatusEnumList[i].ScenarioStatusText, ScenarioStatusEnumTextOrderedList[i].ScenarioStatusText);
                    Assert.AreEqual(ScenarioStatusEnumList[i].ScenarioStatus, ScenarioStatusEnumTextOrderedList[i].ScenarioStatus);
                }
            }
        }
        [TestMethod]
        public void Enums_SearchTagEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<SearchTagEnumTextOrdered> SearchTagEnumList = new List<SearchTagEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(SearchTagEnum)).Length; i < count; i++)
                {
                    SearchTagEnumList.Add(new SearchTagEnumTextOrdered() { SearchTag = (SearchTagEnum)i, SearchTagText = enums.GetEnumText_SearchTagEnum((SearchTagEnum)i) });
                }
                SearchTagEnumList = SearchTagEnumList.OrderBy(c => c.SearchTagText).ToList();

                List<SearchTagEnumTextOrdered> SearchTagEnumTextOrderedList = enums.GetSearchTagEnumTextOrderedList();
                Assert.AreEqual(SearchTagEnumList.Count, SearchTagEnumTextOrderedList.Count);

                SearchTagEnumTextOrdered SearchTagEnumTextOrdered = new SearchTagEnumTextOrdered();
                Assert.IsNotNull(SearchTagEnumTextOrdered);

                for (int i = 0, count = SearchTagEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(SearchTagEnumList[i].SearchTagText, SearchTagEnumTextOrderedList[i].SearchTagText);
                    Assert.AreEqual(SearchTagEnumList[i].SearchTag, SearchTagEnumTextOrderedList[i].SearchTag);
                }
            }
        }
        [TestMethod]
        public void Enums_SecondaryTreatmentTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<SecondaryTreatmentTypeEnumTextOrdered> SecondaryTreatmentTypeEnumList = new List<SecondaryTreatmentTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(SecondaryTreatmentTypeEnum)).Length; i < count; i++)
                {
                    SecondaryTreatmentTypeEnumList.Add(new SecondaryTreatmentTypeEnumTextOrdered() { SecondaryTreatmentType = (SecondaryTreatmentTypeEnum)i, SecondaryTreatmentTypeText = enums.GetEnumText_SecondaryTreatmentTypeEnum((SecondaryTreatmentTypeEnum)i) });
                }
                SecondaryTreatmentTypeEnumList = SecondaryTreatmentTypeEnumList.OrderBy(c => c.SecondaryTreatmentTypeText).ToList();

                List<SecondaryTreatmentTypeEnumTextOrdered> SecondaryTreatmentTypeEnumTextOrderedList = enums.GetSecondaryTreatmentTypeEnumTextOrderedList();
                Assert.AreEqual(SecondaryTreatmentTypeEnumList.Count, SecondaryTreatmentTypeEnumTextOrderedList.Count);

                SecondaryTreatmentTypeEnumTextOrdered SecondaryTreatmentTypeEnumTextOrdered = new SecondaryTreatmentTypeEnumTextOrdered();
                Assert.IsNotNull(SecondaryTreatmentTypeEnumTextOrdered);

                for (int i = 0, count = SecondaryTreatmentTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(SecondaryTreatmentTypeEnumList[i].SecondaryTreatmentTypeText, SecondaryTreatmentTypeEnumTextOrderedList[i].SecondaryTreatmentTypeText);
                    Assert.AreEqual(SecondaryTreatmentTypeEnumList[i].SecondaryTreatmentType, SecondaryTreatmentTypeEnumTextOrderedList[i].SecondaryTreatmentType);
                }
            }
        }
        [TestMethod]
        public void Enums_SiteTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<SiteTypeEnumTextOrdered> SiteTypeEnumList = new List<SiteTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(SiteTypeEnum)).Length; i < count; i++)
                {
                    SiteTypeEnumList.Add(new SiteTypeEnumTextOrdered() { SiteType = (SiteTypeEnum)i, SiteTypeText = enums.GetEnumText_SiteTypeEnum((SiteTypeEnum)i) });
                }
                SiteTypeEnumList = SiteTypeEnumList.OrderBy(c => c.SiteTypeText).ToList();

                List<SiteTypeEnumTextOrdered> SiteTypeEnumTextOrderedList = enums.GetSiteTypeEnumTextOrderedList();
                Assert.AreEqual(SiteTypeEnumList.Count, SiteTypeEnumTextOrderedList.Count);

                SiteTypeEnumTextOrdered SiteTypeEnumTextOrdered = new SiteTypeEnumTextOrdered();
                Assert.IsNotNull(SiteTypeEnumTextOrdered);

                for (int i = 0, count = SiteTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(SiteTypeEnumList[i].SiteTypeText, SiteTypeEnumTextOrderedList[i].SiteTypeText);
                    Assert.AreEqual(SiteTypeEnumList[i].SiteType, SiteTypeEnumTextOrderedList[i].SiteType);
                }
            }
        }
        [TestMethod]
        public void Enums_SpecialTableTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<SpecialTableTypeEnumTextOrdered> SpecialTableTypeEnumList = new List<SpecialTableTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(SpecialTableTypeEnum)).Length; i < count; i++)
                {
                    SpecialTableTypeEnumList.Add(new SpecialTableTypeEnumTextOrdered() { SpecialTableType = (SpecialTableTypeEnum)i, SpecialTableTypeText = enums.GetEnumText_SpecialTableTypeEnum((SpecialTableTypeEnum)i) });
                }
                SpecialTableTypeEnumList = SpecialTableTypeEnumList.OrderBy(c => c.SpecialTableTypeText).ToList();

                List<SpecialTableTypeEnumTextOrdered> SpecialTableTypeEnumTextOrderedList = enums.GetSpecialTableTypeEnumTextOrderedList();
                Assert.AreEqual(SpecialTableTypeEnumList.Count, SpecialTableTypeEnumTextOrderedList.Count);

                SpecialTableTypeEnumTextOrdered SpecialTableTypeEnumTextOrdered = new SpecialTableTypeEnumTextOrdered();
                Assert.IsNotNull(SpecialTableTypeEnumTextOrdered);

                for (int i = 0, count = SpecialTableTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(SpecialTableTypeEnumList[i].SpecialTableTypeText, SpecialTableTypeEnumTextOrderedList[i].SpecialTableTypeText);
                    Assert.AreEqual(SpecialTableTypeEnumList[i].SpecialTableType, SpecialTableTypeEnumTextOrderedList[i].SpecialTableType);
                }
            }
        }
        [TestMethod]
        public void Enums_StorageDataTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<StorageDataTypeEnumTextOrdered> StorageDataTypeEnumList = new List<StorageDataTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(StorageDataTypeEnum)).Length; i < count; i++)
                {
                    StorageDataTypeEnumList.Add(new StorageDataTypeEnumTextOrdered() { StorageDataType = (StorageDataTypeEnum)i, StorageDataTypeText = enums.GetEnumText_StorageDataTypeEnum((StorageDataTypeEnum)i) });
                }
                StorageDataTypeEnumList = StorageDataTypeEnumList.OrderBy(c => c.StorageDataTypeText).ToList();

                List<StorageDataTypeEnumTextOrdered> StorageDataTypeEnumTextOrderedList = enums.GetStorageDataTypeEnumTextOrderedList();
                Assert.AreEqual(StorageDataTypeEnumList.Count, StorageDataTypeEnumTextOrderedList.Count);

                StorageDataTypeEnumTextOrdered StorageDataTypeEnumTextOrdered = new StorageDataTypeEnumTextOrdered();
                Assert.IsNotNull(StorageDataTypeEnumTextOrdered);

                for (int i = 0, count = StorageDataTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(StorageDataTypeEnumList[i].StorageDataTypeText, StorageDataTypeEnumTextOrderedList[i].StorageDataTypeText);
                    Assert.AreEqual(StorageDataTypeEnumList[i].StorageDataType, StorageDataTypeEnumTextOrderedList[i].StorageDataType);
                }
            }
        }
        [TestMethod]
        public void Enums_StreetTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<StreetTypeEnumTextOrdered> StreetTypeEnumList = new List<StreetTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(StreetTypeEnum)).Length; i < count; i++)
                {
                    StreetTypeEnumList.Add(new StreetTypeEnumTextOrdered() { StreetType = (StreetTypeEnum)i, StreetTypeText = enums.GetEnumText_StreetTypeEnum((StreetTypeEnum)i) });
                }
                StreetTypeEnumList = StreetTypeEnumList.OrderBy(c => c.StreetTypeText).ToList();

                List<StreetTypeEnumTextOrdered> StreetTypeEnumTextOrderedList = enums.GetStreetTypeEnumTextOrderedList();
                Assert.AreEqual(StreetTypeEnumList.Count, StreetTypeEnumTextOrderedList.Count);

                StreetTypeEnumTextOrdered StreetTypeEnumTextOrdered = new StreetTypeEnumTextOrdered();
                Assert.IsNotNull(StreetTypeEnumTextOrdered);

                for (int i = 0, count = StreetTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(StreetTypeEnumList[i].StreetTypeText, StreetTypeEnumTextOrderedList[i].StreetTypeText);
                    Assert.AreEqual(StreetTypeEnumList[i].StreetType, StreetTypeEnumTextOrderedList[i].StreetType);
                }
            }
        }
        [TestMethod]
        public void Enums_TelTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<TelTypeEnumTextOrdered> TelTypeEnumList = new List<TelTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(TelTypeEnum)).Length; i < count; i++)
                {
                    TelTypeEnumList.Add(new TelTypeEnumTextOrdered() { TelType = (TelTypeEnum)i, TelTypeText = enums.GetEnumText_TelTypeEnum((TelTypeEnum)i) });
                }
                TelTypeEnumList = TelTypeEnumList.OrderBy(c => c.TelTypeText).ToList();

                List<TelTypeEnumTextOrdered> TelTypeEnumTextOrderedList = enums.GetTelTypeEnumTextOrderedList();
                Assert.AreEqual(TelTypeEnumList.Count, TelTypeEnumTextOrderedList.Count);

                TelTypeEnumTextOrdered TelTypeEnumTextOrdered = new TelTypeEnumTextOrdered();
                Assert.IsNotNull(TelTypeEnumTextOrdered);

                for (int i = 0, count = TelTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(TelTypeEnumList[i].TelTypeText, TelTypeEnumTextOrderedList[i].TelTypeText);
                    Assert.AreEqual(TelTypeEnumList[i].TelType, TelTypeEnumTextOrderedList[i].TelType);
                }
            }
        }
        [TestMethod]
        public void Enums_TertiaryTreatmentTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<TertiaryTreatmentTypeEnumTextOrdered> TertiaryTreatmentTypeEnumList = new List<TertiaryTreatmentTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(TertiaryTreatmentTypeEnum)).Length; i < count; i++)
                {
                    TertiaryTreatmentTypeEnumList.Add(new TertiaryTreatmentTypeEnumTextOrdered() { TertiaryTreatmentType = (TertiaryTreatmentTypeEnum)i, TertiaryTreatmentTypeText = enums.GetEnumText_TertiaryTreatmentTypeEnum((TertiaryTreatmentTypeEnum)i) });
                }
                TertiaryTreatmentTypeEnumList = TertiaryTreatmentTypeEnumList.OrderBy(c => c.TertiaryTreatmentTypeText).ToList();

                List<TertiaryTreatmentTypeEnumTextOrdered> TertiaryTreatmentTypeEnumTextOrderedList = enums.GetTertiaryTreatmentTypeEnumTextOrderedList();
                Assert.AreEqual(TertiaryTreatmentTypeEnumList.Count, TertiaryTreatmentTypeEnumTextOrderedList.Count);

                TertiaryTreatmentTypeEnumTextOrdered TertiaryTreatmentTypeEnumTextOrdered = new TertiaryTreatmentTypeEnumTextOrdered();
                Assert.IsNotNull(TertiaryTreatmentTypeEnumTextOrdered);

                for (int i = 0, count = TertiaryTreatmentTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(TertiaryTreatmentTypeEnumList[i].TertiaryTreatmentTypeText, TertiaryTreatmentTypeEnumTextOrderedList[i].TertiaryTreatmentTypeText);
                    Assert.AreEqual(TertiaryTreatmentTypeEnumList[i].TertiaryTreatmentType, TertiaryTreatmentTypeEnumTextOrderedList[i].TertiaryTreatmentType);
                }
            }
        }
        [TestMethod]
        public void Enums_TideDataTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<TideDataTypeEnumTextOrdered> TideDataTypeEnumList = new List<TideDataTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(TideDataTypeEnum)).Length; i < count; i++)
                {
                    TideDataTypeEnumList.Add(new TideDataTypeEnumTextOrdered() { TideDataType = (TideDataTypeEnum)i, TideDataTypeText = enums.GetEnumText_TideDataTypeEnum((TideDataTypeEnum)i) });
                }
                TideDataTypeEnumList = TideDataTypeEnumList.OrderBy(c => c.TideDataTypeText).ToList();

                List<TideDataTypeEnumTextOrdered> TideDataTypeEnumTextOrderedList = enums.GetTideDataTypeEnumTextOrderedList();
                Assert.AreEqual(TideDataTypeEnumList.Count, TideDataTypeEnumTextOrderedList.Count);

                TideDataTypeEnumTextOrdered TideDataTypeEnumTextOrdered = new TideDataTypeEnumTextOrdered();
                Assert.IsNotNull(TideDataTypeEnumTextOrdered);

                for (int i = 0, count = TideDataTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(TideDataTypeEnumList[i].TideDataTypeText, TideDataTypeEnumTextOrderedList[i].TideDataTypeText);
                    Assert.AreEqual(TideDataTypeEnumList[i].TideDataType, TideDataTypeEnumTextOrderedList[i].TideDataType);
                }
            }
        }
        [TestMethod]
        public void Enums_TideTextEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<TideTextEnumTextOrdered> TideTextEnumList = new List<TideTextEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(TideTextEnum)).Length; i < count; i++)
                {
                    TideTextEnumList.Add(new TideTextEnumTextOrdered() { TideText = (TideTextEnum)i, TideTextText = enums.GetEnumText_TideTextEnum((TideTextEnum)i) });
                }
                TideTextEnumList = TideTextEnumList.OrderBy(c => c.TideTextText).ToList();

                List<TideTextEnumTextOrdered> TideTextEnumTextOrderedList = enums.GetTideTextEnumTextOrderedList();
                Assert.AreEqual(TideTextEnumList.Count, TideTextEnumTextOrderedList.Count);

                TideTextEnumTextOrdered TideTextEnumTextOrdered = new TideTextEnumTextOrdered();
                Assert.IsNotNull(TideTextEnumTextOrdered);

                for (int i = 0, count = TideTextEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(TideTextEnumList[i].TideTextText, TideTextEnumTextOrderedList[i].TideTextText);
                    Assert.AreEqual(TideTextEnumList[i].TideText, TideTextEnumTextOrderedList[i].TideText);
                }
            }
        }
        [TestMethod]
        public void Enums_TranslationStatusEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<TranslationStatusEnumTextOrdered> TranslationStatusEnumList = new List<TranslationStatusEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(TranslationStatusEnum)).Length; i < count; i++)
                {
                    TranslationStatusEnumList.Add(new TranslationStatusEnumTextOrdered() { TranslationStatus = (TranslationStatusEnum)i, TranslationStatusText = enums.GetEnumText_TranslationStatusEnum((TranslationStatusEnum)i) });
                }
                TranslationStatusEnumList = TranslationStatusEnumList.OrderBy(c => c.TranslationStatusText).ToList();

                List<TranslationStatusEnumTextOrdered> TranslationStatusEnumTextOrderedList = enums.GetTranslationStatusEnumTextOrderedList();
                Assert.AreEqual(TranslationStatusEnumList.Count, TranslationStatusEnumTextOrderedList.Count);

                TranslationStatusEnumTextOrdered TranslationStatusEnumTextOrdered = new TranslationStatusEnumTextOrdered();
                Assert.IsNotNull(TranslationStatusEnumTextOrdered);

                for (int i = 0, count = TranslationStatusEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(TranslationStatusEnumList[i].TranslationStatusText, TranslationStatusEnumTextOrderedList[i].TranslationStatusText);
                    Assert.AreEqual(TranslationStatusEnumList[i].TranslationStatus, TranslationStatusEnumTextOrderedList[i].TranslationStatus);
                }
            }
        }
        [TestMethod]
        public void Enums_TreatmentTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<TreatmentTypeEnumTextOrdered> TreatmentTypeEnumList = new List<TreatmentTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(TreatmentTypeEnum)).Length; i < count; i++)
                {
                    TreatmentTypeEnumList.Add(new TreatmentTypeEnumTextOrdered() { TreatmentType = (TreatmentTypeEnum)i, TreatmentTypeText = enums.GetEnumText_TreatmentTypeEnum((TreatmentTypeEnum)i) });
                }
                TreatmentTypeEnumList = TreatmentTypeEnumList.OrderBy(c => c.TreatmentTypeText).ToList();

                List<TreatmentTypeEnumTextOrdered> TreatmentTypeEnumTextOrderedList = enums.GetTreatmentTypeEnumTextOrderedList();
                Assert.AreEqual(TreatmentTypeEnumList.Count, TreatmentTypeEnumTextOrderedList.Count);

                TreatmentTypeEnumTextOrdered TreatmentTypeEnumTextOrdered = new TreatmentTypeEnumTextOrdered();
                Assert.IsNotNull(TreatmentTypeEnumTextOrdered);

                for (int i = 0, count = TreatmentTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(TreatmentTypeEnumList[i].TreatmentTypeText, TreatmentTypeEnumTextOrderedList[i].TreatmentTypeText);
                    Assert.AreEqual(TreatmentTypeEnumList[i].TreatmentType, TreatmentTypeEnumTextOrderedList[i].TreatmentType);
                }
            }
        }
        [TestMethod]
        public void Enums_TVAuthEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<TVAuthEnumTextOrdered> TVAuthEnumList = new List<TVAuthEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(TVAuthEnum)).Length; i < count; i++)
                {
                    TVAuthEnumList.Add(new TVAuthEnumTextOrdered() { TVAuth = (TVAuthEnum)i, TVAuthText = enums.GetEnumText_TVAuthEnum((TVAuthEnum)i) });
                }
                TVAuthEnumList = TVAuthEnumList.OrderBy(c => c.TVAuthText).ToList();

                List<TVAuthEnumTextOrdered> TVAuthEnumTextOrderedList = enums.GetTVAuthEnumTextOrderedList();
                Assert.AreEqual(TVAuthEnumList.Count, TVAuthEnumTextOrderedList.Count);

                TVAuthEnumTextOrdered TVAuthEnumTextOrdered = new TVAuthEnumTextOrdered();
                Assert.IsNotNull(TVAuthEnumTextOrdered);

                for (int i = 0, count = TVAuthEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(TVAuthEnumList[i].TVAuthText, TVAuthEnumTextOrderedList[i].TVAuthText);
                    Assert.AreEqual(TVAuthEnumList[i].TVAuth, TVAuthEnumTextOrderedList[i].TVAuth);
                }
            }
        }
        [TestMethod]
        public void Enums_TVTypeEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<TVTypeEnumTextOrdered> TVTypeEnumList = new List<TVTypeEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(TVTypeEnum)).Length; i < count; i++)
                {
                    TVTypeEnumList.Add(new TVTypeEnumTextOrdered() { TVType = (TVTypeEnum)i, TVTypeText = enums.GetEnumText_TVTypeEnum((TVTypeEnum)i) });
                }
                TVTypeEnumList = TVTypeEnumList.OrderBy(c => c.TVTypeText).ToList();

                List<TVTypeEnumTextOrdered> TVTypeEnumTextOrderedList = enums.GetTVTypeEnumTextOrderedList();
                Assert.AreEqual(TVTypeEnumList.Count, TVTypeEnumTextOrderedList.Count);

                TVTypeEnumTextOrdered TVTypeEnumTextOrdered = new TVTypeEnumTextOrdered();
                Assert.IsNotNull(TVTypeEnumTextOrdered);

                for (int i = 0, count = TVTypeEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(TVTypeEnumList[i].TVTypeText, TVTypeEnumTextOrderedList[i].TVTypeText);
                    Assert.AreEqual(TVTypeEnumList[i].TVType, TVTypeEnumTextOrderedList[i].TVType);
                }
            }
        }
        [TestMethod]
        public void Enums_WebTideDataSetEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<WebTideDataSetEnumTextOrdered> WebTideDataSetEnumList = new List<WebTideDataSetEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(WebTideDataSetEnum)).Length; i < count; i++)
                {
                    WebTideDataSetEnumList.Add(new WebTideDataSetEnumTextOrdered() { WebTideDataSet = (WebTideDataSetEnum)i, WebTideDataSetText = enums.GetEnumText_WebTideDataSetEnum((WebTideDataSetEnum)i) });
                }
                WebTideDataSetEnumList = WebTideDataSetEnumList.OrderBy(c => c.WebTideDataSetText).ToList();

                List<WebTideDataSetEnumTextOrdered> WebTideDataSetEnumTextOrderedList = enums.GetWebTideDataSetEnumTextOrderedList();
                Assert.AreEqual(WebTideDataSetEnumList.Count, WebTideDataSetEnumTextOrderedList.Count);

                WebTideDataSetEnumTextOrdered WebTideDataSetEnumTextOrdered = new WebTideDataSetEnumTextOrdered();
                Assert.IsNotNull(WebTideDataSetEnumTextOrdered);

                for (int i = 0, count = WebTideDataSetEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(WebTideDataSetEnumList[i].WebTideDataSetText, WebTideDataSetEnumTextOrderedList[i].WebTideDataSetText);
                    Assert.AreEqual(WebTideDataSetEnumList[i].WebTideDataSet, WebTideDataSetEnumTextOrderedList[i].WebTideDataSet);
                }
            }
        }
        [TestMethod]
        public void Enums_PolSourceObsInfoEnumTextOrdered_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                List<PolSourceObsInfoEnumTextOrdered> PolSourceObsInfoEnumList = new List<PolSourceObsInfoEnumTextOrdered>();
                for (int i = 1, count = Enum.GetNames(typeof(PolSourceObsInfoEnum)).Length; i < count; i++)
                {
                    PolSourceObsInfoEnumList.Add(new PolSourceObsInfoEnumTextOrdered() { PolSourceObsInfo = (PolSourceObsInfoEnum)i, PolSourceObsInfoText = enums.GetEnumText_PolSourceObsInfoEnum((PolSourceObsInfoEnum)i) });
                }
                PolSourceObsInfoEnumList = PolSourceObsInfoEnumList.OrderBy(c => c.PolSourceObsInfoText).ToList();

                List<PolSourceObsInfoEnumTextOrdered> PolSourceObsInfoEnumTextOrderedList = enums.GetPolSourceObsInfoEnumTextOrderedList();
                Assert.AreEqual(PolSourceObsInfoEnumList.Count, PolSourceObsInfoEnumTextOrderedList.Count);

                PolSourceObsInfoEnumTextOrdered PolSourceObsInfoEnumTextOrdered = new PolSourceObsInfoEnumTextOrdered();
                Assert.IsNotNull(PolSourceObsInfoEnumTextOrdered);

                for (int i = 0, count = PolSourceObsInfoEnumList.Count; i < count; i++)
                {
                    Assert.AreEqual(PolSourceObsInfoEnumList[i].PolSourceObsInfoText, PolSourceObsInfoEnumTextOrderedList[i].PolSourceObsInfoText);
                    Assert.AreEqual(PolSourceObsInfoEnumList[i].PolSourceObsInfo, PolSourceObsInfoEnumTextOrderedList[i].PolSourceObsInfo);
                }
            }
        }

        #endregion Testing Methods TextOrdered public
    }
}
