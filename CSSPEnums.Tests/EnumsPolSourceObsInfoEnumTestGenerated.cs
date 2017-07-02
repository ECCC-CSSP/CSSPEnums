using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSSPEnums.Tests;
using System.Globalization;
using System.Threading;
using CSSPEnums;
using CSSPEnums.Resources;

namespace CSSPEnums.Tests
{
    public partial class EnumsTest
    {
        [TestMethod]
        public void BaseService_GetEnumText_PolSourceObsInfoEnum_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                string retStr = enums.GetEnumText_PolSourceObsInfoEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                string retStrDesc = enums.GetEnumText_PolSourceObsInfoDescEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStrDesc);
                string retStrReport = enums.GetEnumText_PolSourceObsInfoReportEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStrReport);
                string retStrText = enums.GetEnumText_PolSourceObsInfoTextEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStrText);

                foreach (int i in Enum.GetValues(typeof(PolSourceObsInfoEnum)))
                {
                    retStr = enums.GetEnumText_PolSourceObsInfoEnum((PolSourceObsInfoEnum)i);
                    retStrDesc = enums.GetEnumText_PolSourceObsInfoDescEnum((PolSourceObsInfoEnum)i);
                    retStrReport = enums.GetEnumText_PolSourceObsInfoReportEnum((PolSourceObsInfoEnum)i);
                    retStrText = enums.GetEnumText_PolSourceObsInfoTextEnum((PolSourceObsInfoEnum)i);

                    switch ((PolSourceObsInfoEnum)i)
                    {
                        case PolSourceObsInfoEnum.Error:
                        {
                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);
                        }
                        break;
                        case PolSourceObsInfoEnum.Start:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceFromShoreInMetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceFromShoreInMetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceOnWaterMetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceOnWaterMetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSlopeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSlopeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.CropStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PastureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FeedlotStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FarmStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypeOfFishStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypeOfFishStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypeOfFishStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfTransportationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfTransportationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfTransportationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundFacilitiesStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundFacilitiesStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundFacilitiesStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeeMunicipalityInfrastructureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeeMunicipalityInfrastructureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeeMunicipalityInfrastructureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WildlifeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MunicipalSystemStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMunicipalSystemStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMunicipalSystemStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.StorageTankStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAgricultureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAgricultureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAgricultureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingTypeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingTypeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfLivestockStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesOfLivestockStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesOfLivestockStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfWildlifeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesOfWildlifeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesOfWildlifeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalNumberPresentStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAnimalNumberPresentStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAnimalNumberPresentStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointSourceWildlifeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPointSourceWildlifeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPointSourceWildlifeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OilDumpingFacilityStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDumpingStationStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPointSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPointSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointSourceManureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPointSourceManureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPointSourceManureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OuthouseStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManurePileSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureTypeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureSiteStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureSiteStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureSiteStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterDisposalAtSeaStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDisposalAtSeaStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDisposalAtSeaStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSeaportStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSeaportStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSeaportStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAreaSizeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterFecalSourceStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSewageStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSewageStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSewageStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesOfMarineLifeStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesOfMarineLifeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineIssueStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineIssueStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineIssueStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SlipwayStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeShoreStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShoreStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShoreStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskAStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskAStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskAStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskBStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskBStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskBStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskCStart:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskCStart, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskCStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandBased:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandBased, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandBasedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterBased:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterBased, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterBasedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersOnShore:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceFromShoreInMetersOnShore, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceFromShoreInMetersOnShoreReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersLessThan100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceFromShoreInMetersLessThan100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceFromShoreInMetersLessThan100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersBetween100And250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween100And250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween100And250Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersBetween250And500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween250And500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween250And500Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersBetween500And1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween500And1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween500And1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersMoreThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceFromShoreInMetersMoreThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceFromShoreInMetersMoreThan1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersLessThan100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceOnWaterMetersLessThan100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceOnWaterMetersLessThan100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersBetween100And250:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceOnWaterMetersBetween100And250, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceOnWaterMetersBetween100And250Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersBetween250And500:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceOnWaterMetersBetween250And500, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceOnWaterMetersBetween250And500Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersBetween500And1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceOnWaterMetersBetween500And1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceOnWaterMetersBetween500And1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersMoreThan1000:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceOnWaterMetersMoreThan1000, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDistanceOnWaterMetersMoreThan1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSlopeLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSlopeLowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeMedium:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSlopeMedium, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSlopeMediumReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSlopeHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSlopeHighReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandAgriculture:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandAgriculture, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandAgricultureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandAgricultureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandForested:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandForested, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandForestedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandForestedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandIndustry:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandIndustry, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandIndustryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandIndustryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandRecreation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandRecreation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandRecreationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandRecreationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandUrban:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandUrban, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandUrbanReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandUrbanText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeShore:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShore, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShoreReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShoreText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureCrop:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureCrop, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureCropReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureCropText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgriculturePasture:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgriculturePasture, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgriculturePastureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgriculturePastureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureFeedlot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureFeedlot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureFeedlotReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureFeedlotText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureBuilding:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureBuilding, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureBuildingReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureBuildingText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CropFood:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropFood, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropFoodReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropFoodText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CropHay:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropHay, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropHayReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropHayText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CropPeatMoss:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropPeatMoss, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropPeatMossReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropPeatMossText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PastureActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PastureFallow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureFallow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureFallowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureFallowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FeedlotActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FeedlotNotActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotNotActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotNotActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotNotActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FarmHobby:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmHobby, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmHobbyReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmHobbyText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FarmCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedLoggingActivity:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedLoggingActivity, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedLoggingActivityReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedLoggingActivityText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedClearcut:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedClearcut, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedClearcutReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedClearcutText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedRegrowth:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedRegrowth, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedRegrowthReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedRegrowthText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedBuilding:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedBuilding, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedBuildingReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedBuildingText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryAirport:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryAirport, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryAirportReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryAirportText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryLandfill:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryLandfill, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryLandfillReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryLandfillText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryFisheriesRelated:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryFisheriesRelated, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryFisheriesRelatedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryFisheriesRelatedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryWaste:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryWaste, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryWasteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryWasteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryStorageTank:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryStorageTank, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryStorageTankReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryStorageTankText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryCommercial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryCommercial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryCommercialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryCommercialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishProcessingShellfish:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingShellfish, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingShellfishReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingShellfishText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishProcessingFinfish:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingFinfish, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingFinfishReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingFinfishText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishProcessingFishMeal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingFishMeal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingFishMealReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingFishMealText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineWharf:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineWharf, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineWharfReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineWharfText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineBuildings:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineBuildings, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineBuildingsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineBuildingsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineSeaWall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineSeaWall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineSeaWallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineSeaWallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfCommercialTransportation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfCommercialTransportation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfCommercialTransportationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfCommercialTransportationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfFishing:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfFishing, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfFishingReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfFishingText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfPrivate:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfPrivate, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfPrivateReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfPrivateText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfMarina:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfMarina, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfMarinaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfMarinaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfAbandoned:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfAbandoned, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfAbandonedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfAbandonedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TransportationCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTransportationCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTransportationCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTransportationCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TransportationFerry:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTransportationFerry, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTransportationFerryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTransportationFerryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationCampground:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationCampground, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationCampgroundReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationCampgroundText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationDayUseArea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationDayUseArea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationDayUseAreaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationDayUseAreaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationSwimmingArea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationSwimmingArea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationSwimmingAreaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationSwimmingAreaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationRecreationaltArea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationRecreationaltArea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationRecreationaltAreaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationRecreationaltAreaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationCommunityCentre:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationCommunityCentre, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationCommunityCentreReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationCommunityCentreText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationGolfCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationGolfCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationGolfCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationGolfCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundNoDumpStn:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundNoDumpStn, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundNoDumpStnReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundNoDumpStnText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundwithDumpStn:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundwithDumpStn, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundwithDumpStnReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundwithDumpStnText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageCesspool:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageCesspool, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageCesspoolReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageCesspoolText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDirectDischarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDirectDischarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDirectDischargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDirectDischargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewagePrivyOuthouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewagePrivyOuthouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewagePrivyOuthouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewagePrivyOuthouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageMunicipalSystem:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageMunicipalSystem, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageMunicipalSystemReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageMunicipalSystemText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticSystemDrainageField:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemDrainageField, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemDrainageFieldReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemDrainageFieldText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticSystemFullRention:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemFullRention, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemFullRentionReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemFullRentionText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticSystemLagoon:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemLagoon, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemLagoonReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemLagoonText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticNoStructure:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticNoStructure, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticNoStructureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticNoStructureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanStormWater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanStormWater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanStormWaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanStormWaterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanSurfaceRunoff:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanSurfaceRunoff, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanSurfaceRunoffReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanSurfaceRunoffText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanDumpStation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanDumpStation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanDumpStationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanDumpStationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WildlifeBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WildlifeLandMammals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeLandMammals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeLandMammalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeLandMammalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WildlifeMarineMammals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeMarineMammals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeMarineMammalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeMarineMammalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MuncipialSystemConnected:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMuncipialSystemConnected, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMuncipialSystemConnectedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMuncipialSystemConnectedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MunicipalSystemNotConnected:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMunicipalSystemNotConnected, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMunicipalSystemNotConnectedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMunicipalSystemNotConnectedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StorageTankFuel:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankFuel, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankFuelReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankFuelText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StorageTankPropane:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankPropane, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankPropaneReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankPropaneText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StorageTankChemicals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankChemicals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankChemicalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankChemicalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSizeSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSizeLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingResidentialFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingResidentialFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingResidentialFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingResidentialFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingWarehouseFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingWarehouseFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingWarehouseFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingWarehouseFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingCommericalFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingCommericalFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingCommericalFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingCommericalFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingBarnFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingBarnFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingBarnFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingBarnFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingRecreational:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingRecreational, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingRecreationalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingRecreationalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedResidential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedResidential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedResidentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedResidentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedRecreational:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedRecreational, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedRecreationalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedRecreationalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedTrailer:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedTrailer, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedTrailerReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedTrailerText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedFactory:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedFactory, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedFactoryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedFactoryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingindustryWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingindustryWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingindustryWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingindustryWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingIndustryFactory:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingIndustryFactory, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingIndustryFactoryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingIndustryFactoryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingIndustryCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingIndustryCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingIndustryCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingIndustryCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishHatchery:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishHatchery, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishHatcheryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishHatcheryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishTanks:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishTanks, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishTanksReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishTanksText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishCommercial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishCommercial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishCommercialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishCommercialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllCottage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllCottage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllCottageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllCottageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllTrailer:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllTrailer, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllTrailerReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllTrailerText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllResidential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllResidential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllResidentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllResidentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllHotelMotel:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllHotelMotel, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllHotelMotelReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllHotelMotelText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberBetween1and5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberBetween1and5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberBetween1and5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberBetween1and5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberbBetween5and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween5and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween5and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween5and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberbBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberbBetween25and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween25and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween25and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween25and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberGreaterThan40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceLivestock:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceLivestock, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceLivestockReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceLivestockText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourcePeople:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourcePeople, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourcePeopleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourcePeopleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceWildlife:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceWildlife, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceWildlifeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceWildlifeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceAbsentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceDrainagewater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceDrainagewater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceDrainagewaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceDrainagewaterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueSourceManurePile:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueSourceManurePile, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueSourceManurePileReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueSourceManurePileText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueAbsent1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueAbsent1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueAbsent1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueAbsent1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueRunoff:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueRunoff, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueRunoffReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueRunoffText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeResidental:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeResidental, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeResidentalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeResidentalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeIndustrial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeIndustrial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeIndustrialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeIndustrialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeWoodwaste:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeWoodwaste, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeWoodwasteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeWoodwasteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentBetween5and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentBetween5and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentBetween5and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentBetween5and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentGreaterThan25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentGreaterThan25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentGreaterThan25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentGreaterThan25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualLargeDomestic:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeDomestic, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeDomesticReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeDomesticText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualSmallDomestic:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallDomestic, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallDomesticReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallDomesticText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualDomesticBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualDomesticBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualDomesticBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualDomesticBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualFurFarms:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualFurFarms, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualFurFarmsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualFurFarmsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualDomesticMixture:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualDomesticMixture, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualDomesticMixtureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualDomesticMixtureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualSmallWildAnimals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallWildAnimals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallWildAnimalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallWildAnimalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualLargeWildAnimals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeWildAnimals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeWildAnimalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeWildAnimalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualLargeBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualMediumBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualMediumBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualMediumBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualMediumBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualSmallBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentBetween5and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween5and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween5and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween5and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentBetween25and100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween25and100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween25and100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween25and100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentGreaterThan100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceDirectInputToMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceDirectInputToMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceDirectInputToMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceDirectInputToMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountEquals1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountEquals1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountEquals1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountEquals1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween5and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween5and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween5and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween5and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween25and50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween25and50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween25and50Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween25and50Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween50and100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween50and100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween50and100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween50and100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetweenMoreThan100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetweenMoreThan100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetweenMoreThan100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetweenMoreThan100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OilDumpingFacilityPresent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityPresent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityPresentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityPresentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OilDumpingFacilityAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityAbsentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDumpingStationPresent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationPresent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationPresentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationPresentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDumpingStationAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationAbsentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandCulvert:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandCulvert, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandCulvertReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandCulvertText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandPipe:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandPipe, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandPipeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandPipeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandDitch:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandDitch, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandDitchReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandDitchText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandDrainage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandDrainage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandDrainageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandDrainageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeDirectInputToMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeDirectInputToMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeDirectInputToMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeDirectInputToMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceManureLandDrainage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceManureLandDrainage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceManureLandDrainageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceManureLandDrainageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceManureDitch:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceManureDitch, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceManureDitchReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceManureDitchText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersLessThan30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersLessThan30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersLessThan30Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersLessThan30Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween30and100cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersBetween30and100cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersBetween30and100cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersBetween30and100cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween100and200cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersBetween100and200cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersBetween100and200cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersBetween100and200cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersMoreThan200cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersMoreThan200cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersMoreThan200cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersMoreThan200cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelHighReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelHighText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelMedium:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelMedium, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelMediumReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelMediumText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OuthouseCementHoldingTank:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseCementHoldingTank, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseCementHoldingTankReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseCementHoldingTankText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OuthouseSittingOnGround:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseSittingOnGround, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseSittingOnGroundReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseSittingOnGroundText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersLessThan1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersLessThan1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersLessThan1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersLessThan1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersBetween1And5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersBetween1And5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersBetween1And5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersBetween1And5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersBetween5And25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersBetween5And25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersBetween5And25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersBetween5And25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersMoreThan25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersMoreThan25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersMoreThan25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersMoreThan25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchAlongRoad:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchAlongRoad, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchAlongRoadReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchAlongRoadText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchBetweenAcrossProperties:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchBetweenAcrossProperties, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchBetweenAcrossPropertiesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchBetweenAcrossPropertiesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainagePavedSurfaces:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainagePavedSurfaces, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainagePavedSurfacesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainagePavedSurfacesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageVegetatedSurfaces:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageVegetatedSurfaces, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageVegetatedSurfacesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageVegetatedSurfacesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageDirect:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageDirect, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageDirectReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageDirectText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageBareSoilSurfaces:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageBareSoilSurfaces, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageBareSoilSurfacesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageBareSoilSurfacesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManurePileSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManurePileLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterAquacultureSite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterAquacultureSite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterAquacultureSiteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterAquacultureSiteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterAnchorageMooringSite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterAnchorageMooringSite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterAnchorageMooringSiteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterAnchorageMooringSiteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterDisposalAtSea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterDisposalAtSea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterDisposalAtSeaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterDisposalAtSeaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterMarinePark:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterMarinePark, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterMarineParkReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterMarineParkText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterSeaport:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterSeaport, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterSeaportReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterSeaportText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceSandBar:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceSandBar, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceSandBarReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceSandBarText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureSiteActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureSiteActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureSiteActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureSiteActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureSiteFallow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureSiteFallow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureSiteFallowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureSiteFallowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureCages:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureCages, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureCagesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureCagesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureFloatingBags:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureFloatingBags, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureFloatingBagsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureFloatingBagsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureSubmergedLines:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureSubmergedLines, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureSubmergedLinesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureSubmergedLinesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureVessel:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureVessel, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureVesselReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureVesselText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureBarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureBarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureBargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureBargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureResidental:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureResidental, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureResidentalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureResidentalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureCommercial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureCommercial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureCommercialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureCommercialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureNotActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureNotActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureNotActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureNotActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterDumpSiteActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDumpSiteActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDumpSiteActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDumpSiteActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterDumpSiteNotActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDumpSiteNotActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDumpSiteNotActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDumpSiteNotActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaportRecreational:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeaportRecreational, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeaportRecreationalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeaportRecreationalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaportCommercial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeaportCommercial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeaportCommercialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeaportCommercialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeSalt:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeSalt, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeSaltReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeSaltText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeBrachish:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeBrachish, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeBrachishReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeBrachishText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeFresh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeFresh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeFreshReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeFreshText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAreaSizeSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAreaSizeLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterFecalSourcePeople:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourcePeople, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourcePeopleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourcePeopleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterFecalSourceWildlife:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceWildlife, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceWildlifeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceWildlifeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterFecalSourceAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceAbsentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberBetween5and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberBetween5and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberBetween5and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberBetween5and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberGreaterThan25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberGreaterThan25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberGreaterThan25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberGreaterThan25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSewageDirectDischarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSewageDirectDischarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSewageDirectDischargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSewageDirectDischargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSepticSystemFullRention:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSepticSystemFullRention, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSepticSystemFullRentionReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSepticSystemFullRentionText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentBetween5and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentBetween5and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentBetween5and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentBetween5and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentGreaterThan25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentGreaterThan25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentGreaterThan25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentGreaterThan25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualSmallMammals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualSmallMammals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualSmallMammalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualSmallMammalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualLargeMammals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualLargeMammals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualLargeMammalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualLargeMammalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualLargeBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualLargeBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualLargeBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualLargeBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualMediumBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualMediumBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualMediumBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualMediumBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualSmallBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualSmallBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualSmallBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualSmallBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineSandy:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineSandy, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineSandyReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineSandyText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRocky:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineRocky, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineRockyReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineRockyText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineBuildings:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineBuildings, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineBuildingsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineBuildingsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineWildlife:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineWildlife, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineWildlifeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineWildlifeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineLandFill:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineLandFill, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineLandFillReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineLandFillText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineSlipway:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineSlipway, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineSlipwayReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineSlipwayText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineDayuse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineDayuse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineDayuseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineDayuseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SlipwayPaved:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayPaved, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayPavedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayPavedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SlipwayRocks:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayRocks, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayRocksReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayRocksText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeShoreline:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShoreline, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShorelineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShorelineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusNonPollutionSource:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusNonPollutionSource, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusNonPollutionSourceReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusNonPollutionSourceText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskModerate:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskModerate, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskModerateReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskModerateText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskHighP:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskHighP, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskHighPReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskHighPText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskHighReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskHighText, retStrText);
                        }
                        break;
                        default:
                        {
                            Assert.AreEqual("", ((PolSourceObsInfoEnum)i).ToString() + "[" + i.ToString() + "]");
                        }
                        break;
                    }
                }
            }
        }
    }
}
