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
        public void BaseService_PolSourceObsInfoListOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                foreach (int i in Enum.GetValues(typeof(PolSourceObsInfoEnum)))
                {
                    List<PolSourceObsInfoEnum> polSourceInfoList = new List<PolSourceObsInfoEnum>();
                    polSourceInfoList.Add((PolSourceObsInfoEnum)i);

                    string retStr = enums.PolSourceObsInfoListOK(polSourceInfoList);
                    Assert.AreEqual("", retStr);
                }

                string retStr2 = enums.PolSourceObsInfoListOK(new List<PolSourceObsInfoEnum>() { (PolSourceObsInfoEnum)1000000 });
                Assert.AreEqual(string.Format(CSSPEnumsRes.CouldNotFind_Within_, ((PolSourceObsInfoEnum)1000000).ToString(), "PolSourceObsInfoEnum"), retStr2);
                retStr2 = enums.PolSourceObsInfoListOK(new List<PolSourceObsInfoEnum>() { (PolSourceObsInfoEnum)0 });
                Assert.AreEqual("", retStr2);
            }
        }

        [TestMethod]
        public void BaseService_PolSourceObsInfoOK_Test()
        {
            foreach (CultureInfo culture in cultureListGood)
            {
                SetupTest(culture);

                foreach (int i in Enum.GetValues(typeof(PolSourceObsInfoEnum)))
                {
                    string retStr = enums.PolSourceObsInfoOK((PolSourceObsInfoEnum)i);
                    Assert.AreEqual("", retStr);
                }

                string retStr2 = enums.PolSourceObsInfoOK((PolSourceObsInfoEnum)1000000);
                Assert.AreEqual(string.Format(CSSPEnumsRes.CouldNotFind_Within_, ((PolSourceObsInfoEnum)1000000).ToString(), "PolSourceObsInfoEnum"), retStr2);
                retStr2 = enums.PolSourceObsInfoOK((PolSourceObsInfoEnum)0);
                Assert.AreEqual("", retStr2);
            }
        }

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
                string retStrInit = enums.GetEnumText_PolSourceObsInfoInitEnum(null);
                Assert.AreEqual(CSSPEnumsRes.Empty, retStrInit);

                foreach (int i in Enum.GetValues(typeof(PolSourceObsInfoEnum)))
                {
                    retStr = enums.GetEnumText_PolSourceObsInfoEnum((PolSourceObsInfoEnum)i);
                    retStrDesc = enums.GetEnumText_PolSourceObsInfoDescEnum((PolSourceObsInfoEnum)i);
                    retStrReport = enums.GetEnumText_PolSourceObsInfoReportEnum((PolSourceObsInfoEnum)i);
                    retStrText = enums.GetEnumText_PolSourceObsInfoTextEnum((PolSourceObsInfoEnum)i);
                    retStrInit = enums.GetEnumText_PolSourceObsInfoInitEnum((PolSourceObsInfoEnum)i);

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
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandAgricultureInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandForested:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandForested, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandForestedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandForestedText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandForestedInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandIndustry:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandIndustry, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandIndustryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandIndustryText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandIndustryInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandMarineText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandMarineInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandRecreation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandRecreation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandRecreationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandRecreationText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandRecreationInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandUrban:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandUrban, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandUrbanReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandUrbanText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandUrbanInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeShore:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShore, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShoreReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShoreText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShoreInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureCrop:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureCrop, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureCropReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureCropText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureCropInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgriculturePasture:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgriculturePasture, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgriculturePastureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgriculturePastureText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgriculturePastureInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureFeedlot:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureFeedlot, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureFeedlotReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureFeedlotText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureFeedlotInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureFarmText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureFarmInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.AgricultureBuilding:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureBuilding, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureBuildingReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureBuildingText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAgricultureBuildingInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.CropFood:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropFood, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropFoodReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropFoodText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropFoodInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.CropHay:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropHay, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropHayReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropHayText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropHayInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.CropPeatMoss:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropPeatMoss, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropPeatMossReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropPeatMossText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCropPeatMossInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.PastureActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureActiveText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureActiveInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.PastureFallow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureFallow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureFallowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureFallowText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumPastureFallowInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.FeedlotActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotActiveText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotActiveInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.FeedlotNotActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotNotActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotNotActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotNotActiveText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFeedlotNotActiveInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.FarmHobby:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmHobby, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmHobbyReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmHobbyText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmHobbyInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.FarmCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmCommericalText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFarmCommericalInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedLoggingActivity:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedLoggingActivity, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedLoggingActivityReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedLoggingActivityText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedLoggingActivityInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedClearcut:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedClearcut, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedClearcutReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedClearcutText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedClearcutInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedRegrowth:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedRegrowth, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedRegrowthReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedRegrowthText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedRegrowthInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.ForestedBuilding:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedBuilding, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedBuildingReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedBuildingText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumForestedBuildingInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryAirport:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryAirport, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryAirportReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryAirportText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryAirportInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryLandfill:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryLandfill, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryLandfillReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryLandfillText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryLandfillInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryFisheriesRelated:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryFisheriesRelated, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryFisheriesRelatedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryFisheriesRelatedText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryFisheriesRelatedInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryWaste:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryWaste, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryWasteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryWasteText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryWasteInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryStorageTank:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryStorageTank, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryStorageTankReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryStorageTankText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryStorageTankInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.IndustryCommercial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryCommercial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryCommercialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryCommercialText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumIndustryCommercialInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishProcessingShellfish:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingShellfish, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingShellfishReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingShellfishText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingShellfishInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishProcessingFinfish:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingFinfish, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingFinfishReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingFinfishText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingFinfishInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.FishProcessingFishMeal:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingFishMeal, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingFishMealReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingFishMealText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFishProcessingFishMealInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineWharf:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineWharf, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineWharfReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineWharfText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineWharfInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineBuildings:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineBuildings, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineBuildingsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineBuildingsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineBuildingsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.MarineSeaWall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineSeaWall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineSeaWallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineSeaWallText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMarineSeaWallInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfCommercialTransportation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfCommercialTransportation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfCommercialTransportationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfCommercialTransportationText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfCommercialTransportationInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfFishing:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfFishing, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfFishingReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfFishingText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfFishingInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfPrivate:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfPrivate, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfPrivateReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfPrivateText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfPrivateInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfMarina:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfMarina, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfMarinaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfMarinaText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfMarinaInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WharfAbandoned:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfAbandoned, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfAbandonedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfAbandonedText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWharfAbandonedInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.TransportationCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTransportationCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTransportationCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTransportationCommericalText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTransportationCommericalInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.TransportationFerry:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTransportationFerry, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTransportationFerryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTransportationFerryText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTransportationFerryInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationCampground:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationCampground, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationCampgroundReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationCampgroundText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationCampgroundInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationDayUseArea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationDayUseArea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationDayUseAreaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationDayUseAreaText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationDayUseAreaInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationSwimmingArea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationSwimmingArea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationSwimmingAreaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationSwimmingAreaText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationSwimmingAreaInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationRecreationaltArea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationRecreationaltArea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationRecreationaltAreaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationRecreationaltAreaText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationRecreationaltAreaInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationCommunityCentre:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationCommunityCentre, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationCommunityCentreReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationCommunityCentreText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationCommunityCentreInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.RecreationGolfCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationGolfCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationGolfCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationGolfCourseText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRecreationGolfCourseInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundNoDumpStn:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundNoDumpStn, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundNoDumpStnReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundNoDumpStnText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundNoDumpStnInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.CampgroundwithDumpStn:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundwithDumpStn, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundwithDumpStnReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundwithDumpStnText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCampgroundwithDumpStnInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageCesspool:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageCesspool, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageCesspoolReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageCesspoolText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageCesspoolInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDirectDischarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDirectDischarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDirectDischargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDirectDischargeText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDirectDischargeInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewagePrivyOuthouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewagePrivyOuthouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewagePrivyOuthouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewagePrivyOuthouseText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewagePrivyOuthouseInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageMunicipalSystem:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageMunicipalSystem, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageMunicipalSystemReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageMunicipalSystemText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageMunicipalSystemInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticSystemDrainageField:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemDrainageField, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemDrainageFieldReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemDrainageFieldText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemDrainageFieldInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticSystemFullRention:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemFullRention, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemFullRentionReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemFullRentionText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemFullRentionInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticSystemLagoon:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemLagoon, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemLagoonReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemLagoonText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticSystemLagoonInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SepticNoStructure:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticNoStructure, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticNoStructureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticNoStructureText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSepticNoStructureInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanStormWater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanStormWater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanStormWaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanStormWaterText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanStormWaterInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanSurfaceRunoff:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanSurfaceRunoff, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanSurfaceRunoffReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanSurfaceRunoffText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanSurfaceRunoffInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.UrbanDumpStation:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanDumpStation, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanDumpStationReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanDumpStationText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumUrbanDumpStationInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WildlifeBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeBirdsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeBirdsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WildlifeLandMammals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeLandMammals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeLandMammalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeLandMammalsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeLandMammalsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WildlifeMarineMammals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeMarineMammals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeMarineMammalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeMarineMammalsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWildlifeMarineMammalsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.MuncipialSystemConnected:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMuncipialSystemConnected, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMuncipialSystemConnectedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMuncipialSystemConnectedText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMuncipialSystemConnectedInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.MunicipalSystemNotConnected:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMunicipalSystemNotConnected, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMunicipalSystemNotConnectedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMunicipalSystemNotConnectedText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMunicipalSystemNotConnectedInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.StorageTankFuel:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankFuel, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankFuelReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankFuelText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankFuelInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.StorageTankPropane:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankPropane, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankPropaneReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankPropaneText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankPropaneInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.StorageTankChemicals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankChemicals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankChemicalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankChemicalsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStorageTankChemicalsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSizeSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeSmallText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeSmallInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.TankSizeLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeLargeText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTankSizeLargeInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingResidentialFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingResidentialFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingResidentialFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingResidentialFarmText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingResidentialFarmInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingWarehouseFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingWarehouseFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingWarehouseFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingWarehouseFarmText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingWarehouseFarmInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingCommericalFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingCommericalFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingCommericalFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingCommericalFarmText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingCommericalFarmInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingBarnFarm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingBarnFarm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingBarnFarmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingBarnFarmText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingBarnFarmInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingRecreational:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingRecreational, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingRecreationalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingRecreationalText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingRecreationalInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedResidential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedResidential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedResidentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedResidentialText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedResidentialInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedWarehouseText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedWarehouseInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedRecreational:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedRecreational, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedRecreationalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedRecreationalText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedRecreationalInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedTrailer:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedTrailer, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedTrailerReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedTrailerText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedTrailerInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedFactory:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedFactory, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedFactoryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedFactoryText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedFactoryInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingForestedCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedCommericalText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingForestedCommericalInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingindustryWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingindustryWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingindustryWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingindustryWarehouseText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingindustryWarehouseInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingIndustryFactory:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingIndustryFactory, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingIndustryFactoryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingIndustryFactoryText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingIndustryFactoryInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingIndustryCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingIndustryCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingIndustryCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingIndustryCommericalText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingIndustryCommericalInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishHatchery:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishHatchery, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishHatcheryReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishHatcheryText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishHatcheryInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishTanks:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishTanks, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishTanksReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishTanksText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishTanksInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishWarehouseText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishWarehouseInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingFishCommercial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishCommercial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishCommercialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishCommercialText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingFishCommercialInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllCottage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllCottage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllCottageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllCottageText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllCottageInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllTrailer:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllTrailer, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllTrailerReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllTrailerText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllTrailerInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllResidential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllResidential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllResidentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllResidentialText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllResidentialInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllWarehouse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllWarehouse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllWarehouseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllWarehouseText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllWarehouseInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllHotelMotel:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllHotelMotel, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllHotelMotelReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllHotelMotelText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllHotelMotelInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BuildingAllCommerical:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllCommerical, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllCommericalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllCommericalText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBuildingAllCommericalInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberEqualTo1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberEqualTo1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberEqualTo1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberEqualTo1Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberEqualTo1Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberBetween1and5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberBetween1and5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberBetween1and5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberBetween1and5Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberBetween1and5Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberbBetween5and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween5and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween5and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween5and10Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween5and10Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberbBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween10and25Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween10and25Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberbBetween25and40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween25and40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween25and40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween25and40Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberbBetween25and40Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.CountNumberGreaterThan40:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberGreaterThan40, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberGreaterThan40Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberGreaterThan40Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumCountNumberGreaterThan40Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeSmallText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeSmallInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.AreaSizeLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeLargeText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAreaSizeLargeInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceLivestock:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceLivestock, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceLivestockReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceLivestockText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceLivestockInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourcePeople:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourcePeople, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourcePeopleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourcePeopleText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourcePeopleInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceWildlife:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceWildlife, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceWildlifeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceWildlifeText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceWildlifeInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceAbsentText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceAbsentInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.FecalSourceDrainagewater:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceDrainagewater, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceDrainagewaterReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceDrainagewaterText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFecalSourceDrainagewaterInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueSourceManurePile:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueSourceManurePile, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueSourceManurePileReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueSourceManurePileText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueSourceManurePileInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueAbsent1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueAbsent1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueAbsent1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueAbsent1Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueAbsent1Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.MajorIssueRunoff:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueRunoff, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueRunoffReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueRunoffText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumMajorIssueRunoffInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeResidental:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeResidental, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeResidentalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeResidentalText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeResidentalInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeIndustrial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeIndustrial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeIndustrialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeIndustrialText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeIndustrialInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.LandfillTypeWoodwaste:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeWoodwaste, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeWoodwasteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeWoodwasteText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumLandfillTypeWoodwasteInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentLessThan5Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentLessThan5Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentBetween5and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentBetween5and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentBetween5and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentBetween5and10Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentBetween5and10Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentBetween10and25Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentBetween10and25Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberPresentGreaterThan25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentGreaterThan25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentGreaterThan25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentGreaterThan25Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberPresentGreaterThan25Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualLargeDomestic:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeDomestic, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeDomesticReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeDomesticText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeDomesticInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualSmallDomestic:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallDomestic, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallDomesticReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallDomesticText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallDomesticInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualDomesticBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualDomesticBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualDomesticBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualDomesticBirdsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualDomesticBirdsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualFurFarms:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualFurFarms, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualFurFarmsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualFurFarmsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualFurFarmsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualDomesticMixture:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualDomesticMixture, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualDomesticMixtureReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualDomesticMixtureText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualDomesticMixtureInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualSmallWildAnimals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallWildAnimals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallWildAnimalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallWildAnimalsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallWildAnimalsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualLargeWildAnimals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeWildAnimals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeWildAnimalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeWildAnimalsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeWildAnimalsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualLargeBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeBirdsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualLargeBirdsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualMediumBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualMediumBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualMediumBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualMediumBirdsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualMediumBirdsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.TypesEqualSmallBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallBirdsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumTypesEqualSmallBirdsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentLessThan5Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentLessThan5Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentBetween5and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween5and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween5and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween5and10Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween5and10Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween10and25Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween10and25Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentBetween25and100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween25and100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween25and100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween25and100Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentBetween25and100Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.NumberAnimalPresentGreaterThan100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan100Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumNumberAnimalPresentGreaterThan100Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceDirectInputToMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceDirectInputToMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceDirectInputToMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceDirectInputToMarineText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceDirectInputToMarineInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountEquals1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountEquals1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountEquals1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountEquals1Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountEquals1Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountLessThan5Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountLessThan5Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween5and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween5and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween5and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween5and25Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween5and25Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween25and50:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween25and50, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween25and50Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween25and50Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween25and50Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetween50and100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween50and100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween50and100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween50and100Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetween50and100Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.BoatCountBetweenMoreThan100:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetweenMoreThan100, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetweenMoreThan100Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetweenMoreThan100Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumBoatCountBetweenMoreThan100Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.OilDumpingFacilityPresent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityPresent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityPresentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityPresentText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityPresentInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.OilDumpingFacilityAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityAbsentText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOilDumpingFacilityAbsentInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDumpingStationPresent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationPresent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationPresentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationPresentText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationPresentInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SewageDumpingStationAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationAbsentText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSewageDumpingStationAbsentInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandCulvert:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandCulvert, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandCulvertReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandCulvertText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandCulvertInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandPipe:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandPipe, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandPipeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandPipeText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandPipeInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandWaterCourse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandWaterCourse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandWaterCourseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandWaterCourseText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandWaterCourseInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandDitch:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandDitch, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandDitchReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandDitchText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandDitchInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeLandDrainage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandDrainage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandDrainageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandDrainageText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeLandDrainageInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeDirectInputToMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeDirectInputToMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeDirectInputToMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeDirectInputToMarineText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeDirectInputToMarineInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceManureLandDrainage:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceManureLandDrainage, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceManureLandDrainageReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceManureLandDrainageText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceManureLandDrainageInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceManureDitch:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceManureDitch, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceManureDitchReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceManureDitchText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceManureDitchInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersLessThan30:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersLessThan30, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersLessThan30Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersLessThan30Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersLessThan30Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween30and100cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersBetween30and100cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersBetween30and100cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersBetween30and100cmText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersBetween30and100cmInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersBetween100and200cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersBetween100and200cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersBetween100and200cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersBetween100and200cmText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersBetween100and200cmInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.DiameterInCentimetersMoreThan200cm:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersMoreThan200cm, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersMoreThan200cmReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersMoreThan200cmText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDiameterInCentimetersMoreThan200cmInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelHighReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelHighText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelHighInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelMedium:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelMedium, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelMediumReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelMediumText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelMediumInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.FlowLevelLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelLowText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumFlowLevelLowInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.OuthouseCementHoldingTank:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseCementHoldingTank, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseCementHoldingTankReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseCementHoldingTankText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseCementHoldingTankInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.OuthouseSittingOnGround:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseSittingOnGround, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseSittingOnGroundReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseSittingOnGroundText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumOuthouseSittingOnGroundInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersLessThan1:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersLessThan1, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersLessThan1Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersLessThan1Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersLessThan1Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersBetween1And5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersBetween1And5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersBetween1And5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersBetween1And5Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersBetween1And5Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersBetween5And25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersBetween5And25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersBetween5And25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersBetween5And25Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersBetween5And25Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WidthInMetersMoreThan25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersMoreThan25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersMoreThan25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersMoreThan25Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWidthInMetersMoreThan25Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchAlongRoad:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchAlongRoad, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchAlongRoadReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchAlongRoadText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchAlongRoadInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.DitchBetweenAcrossProperties:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchBetweenAcrossProperties, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchBetweenAcrossPropertiesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchBetweenAcrossPropertiesText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDitchBetweenAcrossPropertiesInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainagePavedSurfaces:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainagePavedSurfaces, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainagePavedSurfacesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainagePavedSurfacesText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainagePavedSurfacesInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageVegetatedSurfaces:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageVegetatedSurfaces, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageVegetatedSurfacesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageVegetatedSurfacesText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageVegetatedSurfacesInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageDirect:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageDirect, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageDirectReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageDirectText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageDirectInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.DrainageBareSoilSurfaces:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageBareSoilSurfaces, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageBareSoilSurfacesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageBareSoilSurfacesText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumDrainageBareSoilSurfacesInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManurePileSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileSmallText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileSmallInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.ManurePileLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileLargeText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumManurePileLargeInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterAquacultureSite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterAquacultureSite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterAquacultureSiteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterAquacultureSiteText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterAquacultureSiteInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterAnchorageMooringSite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterAnchorageMooringSite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterAnchorageMooringSiteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterAnchorageMooringSiteText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterAnchorageMooringSiteInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterDisposalAtSea:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterDisposalAtSea, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterDisposalAtSeaReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterDisposalAtSeaText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterDisposalAtSeaInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterMarinePark:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterMarinePark, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterMarineParkReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterMarineParkText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterMarineParkInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeWaterSeaport:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterSeaport, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterSeaportReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterSeaportText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeWaterSeaportInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceSandBar:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceSandBar, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceSandBarReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceSandBarText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceSandBarInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureSiteActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureSiteActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureSiteActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureSiteActiveText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureSiteActiveInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAquacultureSiteFallow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureSiteFallow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureSiteFallowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureSiteFallowText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAquacultureSiteFallowInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureCages:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureCages, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureCagesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureCagesText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureCagesInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureFloatingBags:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureFloatingBags, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureFloatingBagsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureFloatingBagsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureFloatingBagsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureSubmergedLines:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureSubmergedLines, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureSubmergedLinesReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureSubmergedLinesText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureSubmergedLinesInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureVessel:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureVessel, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureVesselReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureVesselText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureVesselInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureBarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureBarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureBargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureBargeText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureBargeInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureResidental:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureResidental, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureResidentalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureResidentalText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureResidentalInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureCommercial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureCommercial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureCommercialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureCommercialText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureCommercialInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterStructureNotActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureNotActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureNotActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureNotActiveText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterStructureNotActiveInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterDumpSiteActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDumpSiteActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDumpSiteActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDumpSiteActiveText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDumpSiteActiveInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterDumpSiteNotActive:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDumpSiteNotActive, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDumpSiteNotActiveReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDumpSiteNotActiveText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterDumpSiteNotActiveInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaportRecreational:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeaportRecreational, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeaportRecreationalReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeaportRecreationalText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeaportRecreationalInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SeaportCommercial:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeaportCommercial, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeaportCommercialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeaportCommercialText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSeaportCommercialInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureSmallText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureSmallInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.AquacultureLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureLargeText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumAquacultureLargeInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeSalt:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeSalt, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeSaltReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeSaltText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeSaltInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeBrachish:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeBrachish, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeBrachishReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeBrachishText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeBrachishInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypeFresh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeFresh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeFreshReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeFreshText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypeFreshInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAreaSizeSmall:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeSmall, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeSmallReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeSmallText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeSmallInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterAreaSizeLarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeLarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeLargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeLargeText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterAreaSizeLargeInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterFecalSourcePeople:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourcePeople, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourcePeopleReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourcePeopleText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourcePeopleInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterFecalSourceWildlife:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceWildlife, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceWildlifeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceWildlifeText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceWildlifeInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterFecalSourceAbsent:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceAbsent, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceAbsentReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceAbsentText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterFecalSourceAbsentInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberLessThan5Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberLessThan5Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberBetween5and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberBetween5and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberBetween5and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberBetween5and10Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberBetween5and10Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberBetween10and25Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberBetween10and25Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterCountNumberGreaterThan25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberGreaterThan25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberGreaterThan25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberGreaterThan25Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterCountNumberGreaterThan25Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSewageDirectDischarge:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSewageDirectDischarge, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSewageDirectDischargeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSewageDirectDischargeText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSewageDirectDischargeInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterSepticSystemFullRention:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSepticSystemFullRention, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSepticSystemFullRentionReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSepticSystemFullRentionText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterSepticSystemFullRentionInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentLessThan5:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentLessThan5, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentLessThan5Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentLessThan5Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentLessThan5Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentBetween5and10:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentBetween5and10, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentBetween5and10Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentBetween5and10Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentBetween5and10Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentBetween10and25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentBetween10and25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentBetween10and25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentBetween10and25Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentBetween10and25Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterNumberPresentGreaterThan25:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentGreaterThan25, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentGreaterThan25Report, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentGreaterThan25Text, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterNumberPresentGreaterThan25Init, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualSmallMammals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualSmallMammals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualSmallMammalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualSmallMammalsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualSmallMammalsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualLargeMammals:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualLargeMammals, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualLargeMammalsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualLargeMammalsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualLargeMammalsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualLargeBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualLargeBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualLargeBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualLargeBirdsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualLargeBirdsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualMediumBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualMediumBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualMediumBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualMediumBirdsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualMediumBirdsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.WaterTypesEqualSmallBirds:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualSmallBirds, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualSmallBirdsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualSmallBirdsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumWaterTypesEqualSmallBirdsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineSandy:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineSandy, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineSandyReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineSandyText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineSandyInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineRocky:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineRocky, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineRockyReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineRockyText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineRockyInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineBuildings:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineBuildings, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineBuildingsReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineBuildingsText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineBuildingsInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineWildlife:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineWildlife, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineWildlifeReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineWildlifeText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineWildlifeInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineLandFill:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineLandFill, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineLandFillReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineLandFillText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineLandFillInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineSlipway:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineSlipway, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineSlipwayReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineSlipwayText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineSlipwayInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.ShorelineDayuse:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineDayuse, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineDayuseReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineDayuseText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumShorelineDayuseInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SlipwayPaved:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayPaved, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayPavedReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayPavedText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayPavedInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SlipwayRocks:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayRocks, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayRocksReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayRocksText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSlipwayRocksInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeShoreline:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShoreline, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShorelineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShorelineText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeShorelineInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.SourceTypeMarine:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeMarine, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeMarineReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeMarineText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumSourceTypeMarineInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusDefinite:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusDefinite, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusDefiniteReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusDefiniteText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusDefiniteInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusPotential:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusPotential, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusPotentialReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusPotentialText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusPotentialInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.StatusNonPollutionSource:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusNonPollutionSource, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusNonPollutionSourceReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusNonPollutionSourceText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumStatusNonPollutionSourceInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskLow:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskLow, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskLowReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskLowText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskLowInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskModerate:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskModerate, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskModerateReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskModerateText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskModerateInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskHighP:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskHighP, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskHighPReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskHighPText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskHighPInit, retStrInit);
                        }
                        break;
                        case PolSourceObsInfoEnum.RiskHigh:
                        {
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskHigh, retStr);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskHighReport, retStrReport);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskHighText, retStrText);
                            Assert.AreEqual(PolSourceInfoEnumGeneratedRes.PolSourceInfoEnumRiskHighInit, retStrInit);
                        }
                        break;
                    }
                }

            retStr = enums.GetEnumText_PolSourceObsInfoEnum((PolSourceObsInfoEnum)1000000);
            Assert.AreEqual(CSSPEnumsRes.Error.ToString(), retStr);
            retStrDesc = enums.GetEnumText_PolSourceObsInfoDescEnum((PolSourceObsInfoEnum)1000000);
            Assert.AreEqual(CSSPEnumsRes.Error.ToString(), retStrDesc);
            retStrReport = enums.GetEnumText_PolSourceObsInfoReportEnum((PolSourceObsInfoEnum)1000000);
            Assert.AreEqual("", retStrReport);
            retStrText = enums.GetEnumText_PolSourceObsInfoTextEnum((PolSourceObsInfoEnum)1000000);
            Assert.AreEqual("", retStrText);
            retStrInit = enums.GetEnumText_PolSourceObsInfoInitEnum((PolSourceObsInfoEnum)1000000);
            Assert.AreEqual("", retStrInit);
            }
        }
    }
}
