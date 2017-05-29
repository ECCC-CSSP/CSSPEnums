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
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgricultureStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgricultureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.CropStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCropStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCropStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PastureStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumPastureStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumPastureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FeedlotStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFeedlotStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFeedlotStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FarmStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFarmStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFarmStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumForestedStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumForestedStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypeOfFishStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypeOfFishStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypeOfFishStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMarineStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMarineStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfTransportationStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfTransportationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundFacilitiesStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCampgroundFacilitiesStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCampgroundFacilitiesStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeeMunicipalityInfrastructureStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSeeMunicipalityInfrastructureStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSeeMunicipalityInfrastructureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumUrbanStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumUrbanStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WildlifeStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWildlifeStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWildlifeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MunicipalSystemStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMunicipalSystemStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMunicipalSystemStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.StorageTankStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStorageTankStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStorageTankStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSizeStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTankSizeStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTankSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAgricultureStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAgricultureStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAgricultureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingTypeStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingTypeStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueSourceStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfLivestockStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesOfLivestockStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesOfWildlifeStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesOfWildlifeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.AnimalNumberPresentStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAnimalNumberPresentStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAnimalNumberPresentStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointSourceWildlifeStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumPointSourceWildlifeStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumPointSourceWildlifeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OilDumpingFacilityStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDumpingStationStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointSourceStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumPointSourceStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumPointSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.PointSourceManureStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumPointSourceManureStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumPointSourceManureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.OuthouseStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOuthouseStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOuthouseStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDitchStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDitchStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDrainageStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDrainageStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManurePileSizeStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumManurePileSizeStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumManurePileSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureTypeStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureSiteStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureSiteStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureSiteStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterDisposalAtSeaStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterDisposalAtSeaStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterDisposalAtSeaStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSeaportStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterSeaportStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterSeaportStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSizeStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAreaSizeStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterFecalSourceStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSewageStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterSewageStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterSewageStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesOfMarineLifeStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesOfMarineLifeStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineIssueStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineIssueStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineIssueStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SlipwayStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSlipwayStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSlipwayStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeShoreStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShoreStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShoreStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStatusStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStatusStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskAStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskAStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskAStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskBStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskBStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskBStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskCStart:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskCStart, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskCStartDesc, retStrDesc);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandBased:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumLandBased, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumLandBasedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterBased:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterBased, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterBasedReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersOnShore:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersOnShore, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersOnShoreReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersLessThan100:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersLessThan100, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersLessThan100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersBetween100And250:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween100And250, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween100And250Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersBetween250And500:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween250And500, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween250And500Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersBetween500And1000:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween500And1000, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersBetween500And1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceFromShoreInMetersMoreThan1000:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersMoreThan1000, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceFromShoreInMetersMoreThan1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersLessThan100:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersLessThan100, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersLessThan100Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersBetween100And250:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersBetween100And250, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersBetween100And250Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersBetween250And500:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersBetween250And500, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersBetween250And500Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersBetween500And1000:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersBetween500And1000, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersBetween500And1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.DistanceOnWaterMetersMoreThan1000:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersMoreThan1000, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDistanceOnWaterMetersMoreThan1000Report, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeLow:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeLow, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeLowReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeMedium:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeMedium, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeMediumReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSlopeHigh:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeHigh, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSlopeHighReport, retStrReport);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandAgriculture:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandAgriculture, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandAgricultureReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandAgricultureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandForested:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandForested, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandForestedReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandForestedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandIndustry:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandIndustry, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandIndustryReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandIndustryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandMarine:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandMarine, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandMarineReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandRecreation:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandRecreation, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandRecreationReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandRecreationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandUrban:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandUrban, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandUrbanReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandUrbanText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeShore:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShore, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShoreReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShoreText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureCrop:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgricultureCrop, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgricultureCropReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgricultureCropText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgriculturePasture:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgriculturePasture, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgriculturePastureReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgriculturePastureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureFeedlot:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgricultureFeedlot, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgricultureFeedlotReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgricultureFeedlotText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureFarm:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgricultureFarm, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgricultureFarmReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgricultureFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureBuilding:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgricultureBuilding, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgricultureBuildingReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAgricultureBuildingText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CropFood:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCropFood, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCropFoodReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCropFoodText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CropHay:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCropHay, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCropHayReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCropHayText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CropPeatMoss:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCropPeatMoss, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCropPeatMossReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCropPeatMossText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PastureActive:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumPastureActive, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumPastureActiveReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumPastureActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.PastureFallow:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumPastureFallow, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumPastureFallowReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumPastureFallowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FeedlotActive:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFeedlotActive, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFeedlotActiveReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFeedlotActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FeedlotNotActive:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFeedlotNotActive, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFeedlotNotActiveReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFeedlotNotActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FarmHobby:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFarmHobby, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFarmHobbyReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFarmHobbyText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FarmCommerical:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFarmCommerical, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFarmCommericalReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFarmCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedLoggingActivity:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumForestedLoggingActivity, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumForestedLoggingActivityReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumForestedLoggingActivityText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedClearcut:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumForestedClearcut, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumForestedClearcutReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumForestedClearcutText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedRegrowth:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumForestedRegrowth, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumForestedRegrowthReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumForestedRegrowthText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedBuilding:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumForestedBuilding, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumForestedBuildingReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumForestedBuildingText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryAirport:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryAirport, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryAirportReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryAirportText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryLandfill:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryLandfill, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryLandfillReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryLandfillText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryFisheriesRelated:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryFisheriesRelated, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryFisheriesRelatedReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryFisheriesRelatedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryWaste:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryWaste, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryWasteReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryWasteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryStorageTank:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryStorageTank, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryStorageTankReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryStorageTankText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryCommercial:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryCommercial, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryCommercialReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumIndustryCommercialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishProcessingShellfish:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingShellfish, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingShellfishReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingShellfishText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishProcessingFinfish:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingFinfish, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingFinfishReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingFinfishText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishProcessingFishMeal:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingFishMeal, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingFishMealReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFishProcessingFishMealText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineWharf:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMarineWharf, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMarineWharfReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMarineWharfText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineBuildings:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMarineBuildings, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMarineBuildingsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMarineBuildingsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineSeaWall:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMarineSeaWall, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMarineSeaWallReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMarineSeaWallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfCommercialTransportation:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfCommercialTransportation, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfCommercialTransportationReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfCommercialTransportationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfFishing:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfFishing, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfFishingReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfFishingText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfPrivate:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfPrivate, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfPrivateReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfPrivateText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfMarina:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfMarina, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfMarinaReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfMarinaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfAbandoned:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfAbandoned, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfAbandonedReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWharfAbandonedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TransportationCommerical:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTransportationCommerical, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTransportationCommericalReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTransportationCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TransportationFerry:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTransportationFerry, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTransportationFerryReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTransportationFerryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationCampground:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationCampground, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationCampgroundReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationCampgroundText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationDayUseArea:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationDayUseArea, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationDayUseAreaReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationDayUseAreaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationSwimmingArea:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationSwimmingArea, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationSwimmingAreaReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationSwimmingAreaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationRecreationaltArea:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationRecreationaltArea, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationRecreationaltAreaReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationRecreationaltAreaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationCommunityCentre:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationCommunityCentre, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationCommunityCentreReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationCommunityCentreText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationGolfCourse:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationGolfCourse, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationGolfCourseReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRecreationGolfCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundNoDumpStn:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCampgroundNoDumpStn, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCampgroundNoDumpStnReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCampgroundNoDumpStnText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundwithDumpStn:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCampgroundwithDumpStn, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCampgroundwithDumpStnReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCampgroundwithDumpStnText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageCesspool:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageCesspool, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageCesspoolReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageCesspoolText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDirectDischarge:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageDirectDischarge, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageDirectDischargeReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageDirectDischargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewagePrivyOuthouse:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewagePrivyOuthouse, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewagePrivyOuthouseReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewagePrivyOuthouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageMunicipalSystem:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageMunicipalSystem, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageMunicipalSystemReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageMunicipalSystemText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticSystemDrainageField:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemDrainageField, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemDrainageFieldReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemDrainageFieldText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticSystemFullRention:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemFullRention, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemFullRentionReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemFullRentionText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticSystemLagoon:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemLagoon, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemLagoonReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSepticSystemLagoonText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticNoStructure:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSepticNoStructure, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSepticNoStructureReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSepticNoStructureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanStormWater:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumUrbanStormWater, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumUrbanStormWaterReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumUrbanStormWaterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanSurfaceRunoff:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumUrbanSurfaceRunoff, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumUrbanSurfaceRunoffReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumUrbanSurfaceRunoffText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanDumpStation:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumUrbanDumpStation, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumUrbanDumpStationReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumUrbanDumpStationText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WildlifeBirds:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWildlifeBirds, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWildlifeBirdsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWildlifeBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WildlifeLandMammals:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWildlifeLandMammals, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWildlifeLandMammalsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWildlifeLandMammalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WildlifeMarineMammals:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWildlifeMarineMammals, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWildlifeMarineMammalsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWildlifeMarineMammalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MuncipialSystemConnected:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMuncipialSystemConnected, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMuncipialSystemConnectedReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMuncipialSystemConnectedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MunicipalSystemNotConnected:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMunicipalSystemNotConnected, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMunicipalSystemNotConnectedReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMunicipalSystemNotConnectedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StorageTankFuel:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStorageTankFuel, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStorageTankFuelReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStorageTankFuelText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StorageTankPropane:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStorageTankPropane, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStorageTankPropaneReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStorageTankPropaneText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StorageTankChemicals:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStorageTankChemicals, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStorageTankChemicalsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStorageTankChemicalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSizeSmall:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTankSizeSmall, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTankSizeSmallReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTankSizeSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSizeLarge:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTankSizeLarge, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTankSizeLargeReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTankSizeLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingResidentialFarm:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingResidentialFarm, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingResidentialFarmReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingResidentialFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingWarehouseFarm:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingWarehouseFarm, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingWarehouseFarmReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingWarehouseFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingCommericalFarm:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingCommericalFarm, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingCommericalFarmReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingCommericalFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingBarnFarm:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingBarnFarm, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingBarnFarmReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingBarnFarmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingRecreational:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingRecreational, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingRecreationalReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingRecreationalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedResidential:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedResidential, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedResidentialReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedResidentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedWarehouse:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedWarehouse, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedWarehouseReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedRecreational:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedRecreational, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedRecreationalReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedRecreationalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedTrailer:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedTrailer, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedTrailerReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedTrailerText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedFactory:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedFactory, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedFactoryReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedFactoryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedCommerical:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedCommerical, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedCommericalReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingForestedCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingindustryWarehouse:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingindustryWarehouse, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingindustryWarehouseReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingindustryWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingIndustryFactory:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryFactory, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryFactoryReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryFactoryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingIndustryCommerical:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryCommerical, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryCommericalReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingIndustryCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishHatchery:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishHatchery, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishHatcheryReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishHatcheryText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishTanks:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishTanks, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishTanksReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishTanksText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishWarehouse:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishWarehouse, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishWarehouseReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishCommercial:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishCommercial, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishCommercialReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingFishCommercialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllCottage:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCottage, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCottageReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCottageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllTrailer:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllTrailer, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllTrailerReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllTrailerText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllResidential:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllResidential, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllResidentialReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllResidentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllWarehouse:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllWarehouse, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllWarehouseReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllWarehouseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllHotelMotel:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllHotelMotel, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllHotelMotelReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllHotelMotelText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllCommerical:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCommerical, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCommericalReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBuildingAllCommericalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberEqualTo1:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo1, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberEqualTo1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberBetween1and5:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberBetween1and5, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberBetween1and5Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberBetween1and5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberbBetween5and10:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween5and10, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween5and10Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween5and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberbBetween10and25:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween10and25, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween10and25Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberbBetween25and40:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween25and40, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween25and40Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberbBetween25and40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberGreaterThan40:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberGreaterThan40, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberGreaterThan40Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumCountNumberGreaterThan40Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeSmall:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeSmall, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeSmallReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeLarge:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeLarge, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeLargeReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAreaSizeLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceLivestock:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceLivestock, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceLivestockReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceLivestockText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourcePeople:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourcePeople, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourcePeopleReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourcePeopleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceWildlife:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceWildlife, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceWildlifeReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceWildlifeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceAbsent:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceAbsent, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceAbsentReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceAbsentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceDrainagewater:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceDrainagewater, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceDrainagewaterReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFecalSourceDrainagewaterText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueSourceManurePile:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceManurePile, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceManurePileReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueSourceManurePileText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueAbsent1:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueAbsent1, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueAbsent1Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueAbsent1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueRunoff:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueRunoff, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueRunoffReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumMajorIssueRunoffText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeResidental:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeResidental, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeResidentalReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeResidentalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeIndustrial:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeIndustrial, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeIndustrialReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeIndustrialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeWoodwaste:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeWoodwaste, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeWoodwasteReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumLandfillTypeWoodwasteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentLessThan5:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentLessThan5, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentLessThan5Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentBetween5and10:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentBetween5and10, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentBetween5and10Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentBetween5and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentBetween10and25:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentBetween10and25, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentBetween10and25Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentGreaterThan25:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentGreaterThan25, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentGreaterThan25Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberPresentGreaterThan25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualLargeDomestic:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeDomestic, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeDomesticReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeDomesticText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualSmallDomestic:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallDomestic, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallDomesticReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallDomesticText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualDomesticBirds:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticBirds, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticBirdsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualFurFarms:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualFurFarms, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualFurFarmsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualFurFarmsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualDomesticMixture:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticMixture, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticMixtureReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualDomesticMixtureText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualSmallWildAnimals:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallWildAnimals, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallWildAnimalsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallWildAnimalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualLargeWildAnimals:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeWildAnimals, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeWildAnimalsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeWildAnimalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualLargeBirds:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeBirds, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeBirdsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualLargeBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualMediumBirds:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualMediumBirds, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualMediumBirdsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualMediumBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualSmallBirds:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallBirds, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallBirdsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumTypesEqualSmallBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentLessThan5:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentLessThan5, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentLessThan5Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentBetween5and10:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween5and10, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween5and10Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween5and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentBetween10and25:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween10and25, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween10and25Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentBetween25and100:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween25and100, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween25and100Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentBetween25and100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentGreaterThan100:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan100, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan100Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceDirectInputToMarine:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceDirectInputToMarine, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceDirectInputToMarineReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceDirectInputToMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountEquals1:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals1, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals1Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountEquals1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountLessThan5:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountLessThan5, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountLessThan5Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween5and25:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween5and25, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween5and25Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween5and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween25and50:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween25and50, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween25and50Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween25and50Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween50and100:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween50and100, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween50and100Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetween50and100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetweenMoreThan100:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetweenMoreThan100, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetweenMoreThan100Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumBoatCountBetweenMoreThan100Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OilDumpingFacilityPresent:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityPresent, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityPresentReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityPresentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OilDumpingFacilityAbsent:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityAbsent, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityAbsentReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOilDumpingFacilityAbsentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDumpingStationPresent:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationPresent, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationPresentReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationPresentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDumpingStationAbsent:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationAbsent, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationAbsentReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSewageDumpingStationAbsentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandCulvert:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandCulvert, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandCulvertReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandCulvertText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandPipe:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandPipe, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandPipeReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandPipeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandWaterCourse:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandWaterCourse, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandWaterCourseReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandWaterCourseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandDitch:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDitch, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDitchReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDitchText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandDrainage:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDrainage, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDrainageReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeLandDrainageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeDirectInputToMarine:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeDirectInputToMarine, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeDirectInputToMarineReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeDirectInputToMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceManureLandDrainage:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceManureLandDrainage, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceManureLandDrainageReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceManureLandDrainageText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceManureDitch:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceManureDitch, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceManureDitchReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceManureDitchText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersLessThan30:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersLessThan30, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersLessThan30Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersLessThan30Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween30and100cm:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween30and100cm, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween30and100cmReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween30and100cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween100and200cm:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween100and200cm, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween100and200cmReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersBetween100and200cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersMoreThan200cm:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersMoreThan200cm, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersMoreThan200cmReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDiameterInCentimetersMoreThan200cmText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelHigh:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHigh, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelHighText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelMedium:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMedium, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelMediumText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelLow:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLow, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumFlowLevelLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OuthouseCementHoldingTank:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOuthouseCementHoldingTank, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOuthouseCementHoldingTankReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOuthouseCementHoldingTankText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.OuthouseSittingOnGround:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOuthouseSittingOnGround, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOuthouseSittingOnGroundReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumOuthouseSittingOnGroundText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersLessThan1:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersLessThan1, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersLessThan1Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersLessThan1Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersBetween1And5:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween1And5, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween1And5Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween1And5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersBetween5And25:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween5And25, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween5And25Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersBetween5And25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersMoreThan25:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersMoreThan25, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersMoreThan25Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWidthInMetersMoreThan25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchAlongRoad:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDitchAlongRoad, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDitchAlongRoadReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDitchAlongRoadText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchBetweenAcrossProperties:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDitchBetweenAcrossProperties, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDitchBetweenAcrossPropertiesReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDitchBetweenAcrossPropertiesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainagePavedSurfaces:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDrainagePavedSurfaces, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDrainagePavedSurfacesReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDrainagePavedSurfacesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageVegetatedSurfaces:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDrainageVegetatedSurfaces, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDrainageVegetatedSurfacesReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDrainageVegetatedSurfacesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageDirect:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDrainageDirect, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDrainageDirectReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDrainageDirectText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageBareSoilSurfaces:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDrainageBareSoilSurfaces, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDrainageBareSoilSurfacesReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumDrainageBareSoilSurfacesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManurePileSmall:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumManurePileSmall, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumManurePileSmallReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumManurePileSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManurePileLarge:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumManurePileLarge, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumManurePileLargeReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumManurePileLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterAquacultureSite:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterAquacultureSite, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterAquacultureSiteReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterAquacultureSiteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterAnchorageMooringSite:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterAnchorageMooringSite, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterAnchorageMooringSiteReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterAnchorageMooringSiteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterDisposalAtSea:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterDisposalAtSea, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterDisposalAtSeaReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterDisposalAtSeaText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterMarinePark:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterMarinePark, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterMarineParkReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterMarineParkText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterSeaport:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterSeaport, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterSeaportReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeWaterSeaportText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceSandBar:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceSandBar, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceSandBarReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceSandBarText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureSiteActive:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureSiteActive, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureSiteActiveReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureSiteActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureSiteFallow:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureSiteFallow, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureSiteFallowReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAquacultureSiteFallowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureCages:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAquacultureCages, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAquacultureCagesReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAquacultureCagesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureFloatingBags:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAquacultureFloatingBags, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAquacultureFloatingBagsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAquacultureFloatingBagsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureSubmergedLines:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSubmergedLines, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSubmergedLinesReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSubmergedLinesText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureVessel:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureVessel, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureVesselReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureVesselText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureBarge:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureBarge, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureBargeReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureBargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureResidental:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureResidental, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureResidentalReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureResidentalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureCommercial:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureCommercial, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureCommercialReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureCommercialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureNotActive:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureNotActive, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureNotActiveReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterStructureNotActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterDumpSiteActive:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterDumpSiteActive, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterDumpSiteActiveReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterDumpSiteActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterDumpSiteNotActive:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterDumpSiteNotActive, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterDumpSiteNotActiveReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterDumpSiteNotActiveText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaportRecreational:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSeaportRecreational, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSeaportRecreationalReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSeaportRecreationalText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaportCommercial:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSeaportCommercial, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSeaportCommercialReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSeaportCommercialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureSmall:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSmall, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSmallReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAquacultureSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureLarge:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAquacultureLarge, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAquacultureLargeReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumAquacultureLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeSalt:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeSalt, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeSaltReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeSaltText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeBrachish:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeBrachish, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeBrachishReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeBrachishText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeFresh:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeFresh, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeFreshReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypeFreshText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAreaSizeSmall:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeSmall, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeSmallReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeSmallText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAreaSizeLarge:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeLarge, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeLargeReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterAreaSizeLargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterFecalSourcePeople:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourcePeople, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourcePeopleReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourcePeopleText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterFecalSourceWildlife:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceWildlife, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceWildlifeReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceWildlifeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterFecalSourceAbsent:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceAbsent, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceAbsentReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterFecalSourceAbsentText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberLessThan5:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberLessThan5, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberLessThan5Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberBetween5and10:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberBetween5and10, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberBetween5and10Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberBetween5and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberBetween10and25:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberBetween10and25, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberBetween10and25Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberGreaterThan25:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberGreaterThan25, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberGreaterThan25Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterCountNumberGreaterThan25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSewageDirectDischarge:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterSewageDirectDischarge, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterSewageDirectDischargeReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterSewageDirectDischargeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSepticSystemFullRention:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterSepticSystemFullRention, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterSepticSystemFullRentionReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterSepticSystemFullRentionText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentLessThan5:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentLessThan5, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentLessThan5Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentLessThan5Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentBetween5and10:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentBetween5and10, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentBetween5and10Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentBetween5and10Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentBetween10and25:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentBetween10and25, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentBetween10and25Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentBetween10and25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentGreaterThan25:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentGreaterThan25, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentGreaterThan25Report, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterNumberPresentGreaterThan25Text, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualSmallMammals:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualSmallMammals, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualSmallMammalsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualSmallMammalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualLargeMammals:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualLargeMammals, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualLargeMammalsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualLargeMammalsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualLargeBirds:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualLargeBirds, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualLargeBirdsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualLargeBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualMediumBirds:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualMediumBirds, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualMediumBirdsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualMediumBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualSmallBirds:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualSmallBirds, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualSmallBirdsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumWaterTypesEqualSmallBirdsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineSandy:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineSandy, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineSandyReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineSandyText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRocky:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineRocky, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineRockyReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineRockyText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineBuildings:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineBuildings, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineBuildingsReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineBuildingsText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineWildlife:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineWildlife, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineWildlifeReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineWildlifeText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineLandFill:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineLandFill, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineLandFillReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineLandFillText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineSlipway:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineSlipway, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineSlipwayReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineSlipwayText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineDayuse:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineDayuse, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineDayuseReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumShorelineDayuseText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SlipwayPaved:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSlipwayPaved, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSlipwayPavedReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSlipwayPavedText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SlipwayRocks:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSlipwayRocks, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSlipwayRocksReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSlipwayRocksText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeShoreline:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShoreline, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShorelineReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeShorelineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeMarine:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeMarine, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeMarineReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumSourceTypeMarineText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusDefinite:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStatusDefinite, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStatusDefiniteReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStatusDefiniteText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusPotential:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStatusPotential, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStatusPotentialReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStatusPotentialText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusNonPollutionSource:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStatusNonPollutionSource, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStatusNonPollutionSourceReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumStatusNonPollutionSourceText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskLow:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskLow, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskLowReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskLowText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskModerate:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskModerate, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskModerateReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskModerateText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskHighP:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskHighP, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskHighPReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskHighPText, retStrText);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskHigh:
                        {
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskHigh, retStr);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskHighReport, retStrReport);
                            Assert.AreEqual(GeneratedPolSourceInfoEnumRes.PolSourceInfoEnumRiskHighText, retStrText);
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
