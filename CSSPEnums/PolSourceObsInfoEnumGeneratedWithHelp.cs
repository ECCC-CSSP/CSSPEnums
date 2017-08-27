using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPEnums
{
    /// <summary>
    /// PolSourceObsInfoEnum used by [CSSPModels] (CSSPModels.html) and [CSSPServices] (CSSPServices.html) 
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum PolSourceObsInfoEnum
    ///     {
    ///         Error = 0,
    ///         Start = 10100,
    ///         LandBased = 10101,
    ///         WaterBased = 10102,
    ///         DistanceFromShoreInMetersStart = 10200,
    ///         DistanceFromShoreInMetersOnShore = 10201,
    ///         DistanceFromShoreInMetersLessThan100 = 10202,
    ///         DistanceFromShoreInMetersBetween100And250 = 10203,
    ///         DistanceFromShoreInMetersBetween250And500 = 10204,
    ///         DistanceFromShoreInMetersBetween500And1000 = 10205,
    ///         DistanceFromShoreInMetersMoreThan1000 = 10206,
    ///         DistanceOnWaterMetersStart = 10300,
    ///         DistanceOnWaterMetersLessThan100 = 10301,
    ///         DistanceOnWaterMetersBetween100And250 = 10302,
    ///         DistanceOnWaterMetersBetween250And500 = 10303,
    ///         DistanceOnWaterMetersBetween500And1000 = 10304,
    ///         DistanceOnWaterMetersMoreThan1000 = 10305,
    ///         AreaSlopeStart = 10400,
    ///         AreaSlopeLow = 10401,
    ///         AreaSlopeMedium = 10402,
    ///         AreaSlopeHigh = 10403,
    ///         SourceTypeLandStart = 10500,
    ///         SourceTypeLandAgriculture = 10501,
    ///         SourceTypeLandForested = 10502,
    ///         SourceTypeLandIndustry = 10503,
    ///         SourceTypeLandMarine = 10504,
    ///         SourceTypeLandRecreation = 10505,
    ///         SourceTypeLandUrban = 10506,
    ///         SourceTypeShore = 10507,
    ///         AgricultureStart = 10600,
    ///         AgricultureCrop = 10601,
    ///         AgriculturePasture = 10602,
    ///         AgricultureFeedlot = 10603,
    ///         AgricultureFarm = 10604,
    ///         AgricultureBuilding = 10605,
    ///         CropStart = 10700,
    ///         CropFood = 10701,
    ///         CropHay = 10702,
    ///         CropPeatMoss = 10703,
    ///         PastureStart = 10800,
    ///         PastureActive = 10801,
    ///         PastureFallow = 10802,
    ///         FeedlotStart = 10900,
    ///         FeedlotActive = 10901,
    ///         FeedlotNotActive = 10902,
    ///         FarmStart = 11000,
    ///         FarmHobby = 11001,
    ///         FarmCommerical = 11002,
    ///         ForestedStart = 11100,
    ///         ForestedLoggingActivity = 11101,
    ///         ForestedClearcut = 11102,
    ///         ForestedRegrowth = 11103,
    ///         ForestedBuilding = 11104,
    ///         IndustryStart = 11200,
    ///         IndustryAirport = 11201,
    ///         IndustryLandfill = 11202,
    ///         IndustryFisheriesRelated = 11203,
    ///         IndustryWaste = 11204,
    ///         IndustryStorageTank = 11205,
    ///         IndustryCommercial = 11206,
    ///         TypeOfFishStart = 11300,
    ///         FishProcessingShellfish = 11301,
    ///         FishProcessingFinfish = 11302,
    ///         FishProcessingFishMeal = 11303,
    ///         MarineStart = 11400,
    ///         MarineWharf = 11401,
    ///         MarineBuildings = 11402,
    ///         MarineSeaWall = 11403,
    ///         WharfStart = 11500,
    ///         WharfCommercialTransportation = 11501,
    ///         WharfFishing = 11502,
    ///         WharfPrivate = 11503,
    ///         WharfMarina = 11504,
    ///         WharfAbandoned = 11505,
    ///         WharfTransportationStart = 11600,
    ///         TransportationCommerical = 11601,
    ///         TransportationFerry = 11602,
    ///         RecreationStart = 11700,
    ///         RecreationCampground = 11701,
    ///         RecreationDayUseArea = 11702,
    ///         RecreationSwimmingArea = 11703,
    ///         RecreationRecreationaltArea = 11704,
    ///         RecreationCommunityCentre = 11705,
    ///         RecreationGolfCourse = 11706,
    ///         CampgroundFacilitiesStart = 11800,
    ///         CampgroundNoDumpStn = 11801,
    ///         CampgroundwithDumpStn = 11802,
    ///         SewageStart = 11900,
    ///         SewageCesspool = 11901,
    ///         SewageDirectDischarge = 11902,
    ///         SewagePrivyOuthouse = 11903,
    ///         SewageMunicipalSystem = 11904,
    ///         SepticSystemDrainageField = 11905,
    ///         SepticSystemFullRention = 11906,
    ///         SepticSystemLagoon = 11907,
    ///         SepticNoStructure = 11908,
    ///         SeeMunicipalityInfrastructureStart = 12000,
    ///         UrbanStart = 12100,
    ///         UrbanStormWater = 12104,
    ///         UrbanSurfaceRunoff = 12106,
    ///         UrbanDumpStation = 12107,
    ///         WildlifeStart = 12200,
    ///         WildlifeBirds = 12201,
    ///         WildlifeLandMammals = 12202,
    ///         WildlifeMarineMammals = 12203,
    ///         MunicipalSystemStart = 12300,
    ///         MuncipialSystemConnected = 12301,
    ///         MunicipalSystemNotConnected = 12302,
    ///         StorageTankStart = 12400,
    ///         StorageTankFuel = 12401,
    ///         StorageTankPropane = 12402,
    ///         StorageTankChemicals = 12403,
    ///         TankSizeStart = 12500,
    ///         TankSizeSmall = 12501,
    ///         TankSizeLarge = 12502,
    ///         BuildingAgricultureStart = 12600,
    ///         BuildingResidentialFarm = 12601,
    ///         BuildingWarehouseFarm = 12602,
    ///         BuildingCommericalFarm = 12603,
    ///         BuildingBarnFarm = 12604,
    ///         BuildingRecreational = 12605,
    ///         BuildingForestedStart = 12700,
    ///         BuildingForestedResidential = 12701,
    ///         BuildingForestedWarehouse = 12702,
    ///         BuildingForestedRecreational = 12703,
    ///         BuildingForestedTrailer = 12704,
    ///         BuildingForestedFactory = 12705,
    ///         BuildingForestedCommerical = 12706,
    ///         BuildingTypeStart = 12800,
    ///         BuildingindustryWarehouse = 12801,
    ///         BuildingIndustryFactory = 12802,
    ///         BuildingIndustryCommerical = 12803,
    ///         BuildingFishStart = 12900,
    ///         BuildingFishHatchery = 12901,
    ///         BuildingFishTanks = 12902,
    ///         BuildingFishWarehouse = 12903,
    ///         BuildingFishCommercial = 12904,
    ///         BuildingAllStart = 13000,
    ///         BuildingAllCottage = 13001,
    ///         BuildingAllTrailer = 13002,
    ///         BuildingAllResidential = 13003,
    ///         BuildingAllWarehouse = 13004,
    ///         BuildingAllHotelMotel = 13005,
    ///         BuildingAllCommerical = 13006,
    ///         CountNumberStart = 13100,
    ///         CountNumberEqualTo1 = 13101,
    ///         CountNumberBetween1and5 = 13102,
    ///         CountNumberbBetween5and10 = 13103,
    ///         CountNumberbBetween10and25 = 13104,
    ///         CountNumberbBetween25and40 = 13105,
    ///         CountNumberGreaterThan40 = 13106,
    ///         AreaSizeStart = 13200,
    ///         AreaSizeSmall = 13201,
    ///         AreaSizeLarge = 13202,
    ///         FecalSourceStart = 13300,
    ///         FecalSourceLivestock = 13301,
    ///         FecalSourcePeople = 13302,
    ///         FecalSourceWildlife = 13303,
    ///         FecalSourceAbsent = 13304,
    ///         FecalSourceDrainagewater = 13305,
    ///         MajorIssueSourceStart = 13400,
    ///         MajorIssueSourceManurePile = 13401,
    ///         MajorIssueAbsent1 = 13402,
    ///         MajorIssueRunoff = 13403,
    ///         LandfillTypeStart = 13500,
    ///         LandfillTypeResidental = 13501,
    ///         LandfillTypeIndustrial = 13502,
    ///         LandfillTypeWoodwaste = 13503,
    ///         NumberPresentStart = 13600,
    ///         NumberPresentLessThan5 = 13601,
    ///         NumberPresentBetween5and10 = 13602,
    ///         NumberPresentBetween10and25 = 13603,
    ///         NumberPresentGreaterThan25 = 13604,
    ///         TypesOfLivestockStart = 13700,
    ///         TypesEqualLargeDomestic = 13701,
    ///         TypesEqualSmallDomestic = 13702,
    ///         TypesEqualDomesticBirds = 13703,
    ///         TypesEqualFurFarms = 13704,
    ///         TypesEqualDomesticMixture = 13705,
    ///         TypesOfWildlifeStart = 13800,
    ///         TypesEqualSmallWildAnimals = 13801,
    ///         TypesEqualLargeWildAnimals = 13802,
    ///         TypesEqualLargeBirds = 13803,
    ///         TypesEqualMediumBirds = 13804,
    ///         TypesEqualSmallBirds = 13805,
    ///         AnimalNumberPresentStart = 13900,
    ///         NumberAnimalPresentLessThan5 = 13901,
    ///         NumberAnimalPresentBetween5and10 = 13902,
    ///         NumberAnimalPresentBetween10and25 = 13903,
    ///         NumberAnimalPresentBetween25and100 = 13904,
    ///         NumberAnimalPresentGreaterThan100 = 13905,
    ///         PointSourceWildlifeStart = 16600,
    ///         SourceDirectInputToMarine = 16601,
    ///         BoatStart = 14000,
    ///         BoatCountEquals1 = 14001,
    ///         BoatCountLessThan5 = 14002,
    ///         BoatCountBetween5and25 = 14003,
    ///         BoatCountBetween25and50 = 14004,
    ///         BoatCountBetween50and100 = 14005,
    ///         BoatCountBetweenMoreThan100 = 14006,
    ///         OilDumpingFacilityStart = 14100,
    ///         OilDumpingFacilityPresent = 14101,
    ///         OilDumpingFacilityAbsent = 14102,
    ///         SewageDumpingStationStart = 14200,
    ///         SewageDumpingStationPresent = 14201,
    ///         SewageDumpingStationAbsent = 14202,
    ///         PointSourceStart = 14300,
    ///         SourceTypeLandCulvert = 14301,
    ///         SourceTypeLandPipe = 14302,
    ///         SourceTypeLandWaterCourse = 14303,
    ///         SourceTypeLandDitch = 14304,
    ///         SourceTypeLandDrainage = 14305,
    ///         SourceTypeDirectInputToMarine = 14306,
    ///         PointSourceManureStart = 14400,
    ///         SourceManureLandDrainage = 14401,
    ///         SourceManureDitch = 14402,
    ///         DiameterInCentimetersStart = 14500,
    ///         DiameterInCentimetersLessThan30 = 14501,
    ///         DiameterInCentimetersBetween30and100cm = 14502,
    ///         DiameterInCentimetersBetween100and200cm = 14503,
    ///         DiameterInCentimetersMoreThan200cm = 14504,
    ///         FlowLevelStart = 14600,
    ///         FlowLevelHigh = 14601,
    ///         FlowLevelMedium = 14602,
    ///         FlowLevelLow = 14603,
    ///         OuthouseStart = 14700,
    ///         OuthouseCementHoldingTank = 14701,
    ///         OuthouseSittingOnGround = 14702,
    ///         WidthInMetersStart = 14800,
    ///         WidthInMetersLessThan1 = 14801,
    ///         WidthInMetersBetween1And5 = 14802,
    ///         WidthInMetersBetween5And25 = 14803,
    ///         WidthInMetersMoreThan25 = 14804,
    ///         DitchStart = 14900,
    ///         DitchAlongRoad = 14901,
    ///         DitchBetweenAcrossProperties = 14902,
    ///         DrainageStart = 15000,
    ///         DrainagePavedSurfaces = 15001,
    ///         DrainageVegetatedSurfaces = 15002,
    ///         DrainageDirect = 15003,
    ///         DrainageBareSoilSurfaces = 15004,
    ///         ManurePileSizeStart = 15100,
    ///         ManurePileSmall = 15101,
    ///         ManurePileLarge = 15102,
    ///         SourceTypeWaterStart = 15200,
    ///         SourceTypeWaterAquacultureSite = 15201,
    ///         SourceTypeWaterAnchorageMooringSite = 15202,
    ///         SourceTypeWaterDisposalAtSea = 15203,
    ///         SourceTypeWaterMarinePark = 15204,
    ///         SourceTypeWaterSeaport = 15205,
    ///         SourceSandBar = 15206,
    ///         WaterAquacultureStart = 15300,
    ///         WaterAquacultureSiteActive = 15301,
    ///         WaterAquacultureSiteFallow = 15302,
    ///         WaterAquacultureTypeStart = 15400,
    ///         AquacultureCages = 15401,
    ///         AquacultureFloatingBags = 15402,
    ///         AquacultureSubmergedLines = 15403,
    ///         WaterStructureSiteStart = 15500,
    ///         WaterStructureVessel = 15501,
    ///         WaterStructureBarge = 15502,
    ///         WaterStructureResidental = 15503,
    ///         WaterStructureCommercial = 15504,
    ///         WaterStructureNotActive = 15505,
    ///         WaterDisposalAtSeaStart = 15600,
    ///         WaterDumpSiteActive = 15601,
    ///         WaterDumpSiteNotActive = 15602,
    ///         WaterSeaportStart = 15700,
    ///         SeaportRecreational = 15701,
    ///         SeaportCommercial = 15702,
    ///         WaterSizeStart = 15800,
    ///         AquacultureSmall = 15801,
    ///         AquacultureLarge = 15802,
    ///         WaterTypeStart = 15900,
    ///         WaterTypeSalt = 15901,
    ///         WaterTypeBrachish = 15902,
    ///         WaterTypeFresh = 15903,
    ///         WaterAreaSizeStart = 16000,
    ///         WaterAreaSizeSmall = 16001,
    ///         WaterAreaSizeLarge = 16002,
    ///         WaterFecalSourceStart = 16100,
    ///         WaterFecalSourcePeople = 16101,
    ///         WaterFecalSourceWildlife = 16102,
    ///         WaterFecalSourceAbsent = 16103,
    ///         WaterCountNumberStart = 16200,
    ///         WaterCountNumberLessThan5 = 16201,
    ///         WaterCountNumberBetween5and10 = 16202,
    ///         WaterCountNumberBetween10and25 = 16203,
    ///         WaterCountNumberGreaterThan25 = 16204,
    ///         WaterSewageStart = 16300,
    ///         WaterSewageDirectDischarge = 16301,
    ///         WaterSepticSystemFullRention = 16302,
    ///         WaterNumberPresentStart = 16400,
    ///         WaterNumberPresentLessThan5 = 16401,
    ///         WaterNumberPresentBetween5and10 = 16402,
    ///         WaterNumberPresentBetween10and25 = 16403,
    ///         WaterNumberPresentGreaterThan25 = 16404,
    ///         WaterTypesOfMarineLifeStart = 16500,
    ///         WaterTypesEqualSmallMammals = 16501,
    ///         WaterTypesEqualLargeMammals = 16502,
    ///         WaterTypesEqualLargeBirds = 16503,
    ///         WaterTypesEqualMediumBirds = 16504,
    ///         WaterTypesEqualSmallBirds = 16505,
    ///         ShorelineStart = 17000,
    ///         ShorelineSandy = 17001,
    ///         ShorelineRocky = 17002,
    ///         ShorelineIssueStart = 17100,
    ///         ShorelineBuildings = 17101,
    ///         ShorelineWildlife = 17102,
    ///         ShorelineLandFill = 17103,
    ///         ShorelineSlipway = 17104,
    ///         ShorelineDayuse = 17105,
    ///         SlipwayStart = 18000,
    ///         SlipwayPaved = 18001,
    ///         SlipwayRocks = 18002,
    ///         SourceTypeShoreStart = 19000,
    ///         SourceTypeShoreline = 19001,
    ///         SourceTypeMarine = 19002,
    ///         StatusStart = 90000,
    ///         StatusDefinite = 90001,
    ///         StatusPotential = 90002,
    ///         StatusNonPollutionSource = 90003,
    ///         RiskAStart = 91000,
    ///         RiskLow = 91001,
    ///         RiskBStart = 92000,
    ///         RiskModerate = 92001,
    ///         RiskHighP = 92002,
    ///         RiskCStart = 93000,
    ///         RiskHigh = 93001,
    ///     }
    /// </code>
    /// 
    /// </remarks>
    public enum PolSourceObsInfoEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 10100 -- en [Pollution source and type] ---- fr [Source et type de pollution]
        /// </summary>
        Start = 10100,
        /// <summary>
        /// 10101 -- en [Land] ---- fr [Terrestre]
        /// </summary>
        LandBased = 10101,
        /// <summary>
        /// 10102 -- en [Water] ---- fr [Marine]
        /// </summary>
        WaterBased = 10102,
        /// <summary>
        /// 10200 -- en [Distance from shore (meters)] ---- fr [Distance de la côte (mètres)]
        /// </summary>
        DistanceFromShoreInMetersStart = 10200,
        /// <summary>
        /// 10201 -- en [        On shore] ---- fr [          Sur la côte]
        /// </summary>
        DistanceFromShoreInMetersOnShore = 10201,
        /// <summary>
        /// 10202 -- en [     Less than 100] ---- fr [      Moins de 100]
        /// </summary>
        DistanceFromShoreInMetersLessThan100 = 10202,
        /// <summary>
        /// 10203 -- en [   100 - 250] ---- fr [   100 à 250]
        /// </summary>
        DistanceFromShoreInMetersBetween100And250 = 10203,
        /// <summary>
        /// 10204 -- en [  250 - 500] ---- fr [  250 à 500]
        /// </summary>
        DistanceFromShoreInMetersBetween250And500 = 10204,
        /// <summary>
        /// 10205 -- en [ 500 - 1000] ---- fr [ 500 à 1000]
        /// </summary>
        DistanceFromShoreInMetersBetween500And1000 = 10205,
        /// <summary>
        /// 10206 -- en [1000 and more] ---- fr [1000 et plus]
        /// </summary>
        DistanceFromShoreInMetersMoreThan1000 = 10206,
        /// <summary>
        /// 10300 -- en [Distance on water] ---- fr [Distance sur l'eau]
        /// </summary>
        DistanceOnWaterMetersStart = 10300,
        /// <summary>
        /// 10301 -- en [      less than 100] ---- fr [      moins de 100]
        /// </summary>
        DistanceOnWaterMetersLessThan100 = 10301,
        /// <summary>
        /// 10302 -- en [    100 - 250] ---- fr [    100 à 250]
        /// </summary>
        DistanceOnWaterMetersBetween100And250 = 10302,
        /// <summary>
        /// 10303 -- en [   250 - 500] ---- fr [   250 à 500]
        /// </summary>
        DistanceOnWaterMetersBetween250And500 = 10303,
        /// <summary>
        /// 10304 -- en [  500 - 1000] ---- fr [  500 à 1000]
        /// </summary>
        DistanceOnWaterMetersBetween500And1000 = 10304,
        /// <summary>
        /// 10305 -- en [1000 and more] ---- fr [1000 et plus]
        /// </summary>
        DistanceOnWaterMetersMoreThan1000 = 10305,
        /// <summary>
        /// 10400 -- en [Area slope] ---- fr [Pente de l'endroit]
        /// </summary>
        AreaSlopeStart = 10400,
        /// <summary>
        /// 10401 -- en [Low] ---- fr [Faible]
        /// </summary>
        AreaSlopeLow = 10401,
        /// <summary>
        /// 10402 -- en [Medium] ---- fr [Modérée]
        /// </summary>
        AreaSlopeMedium = 10402,
        /// <summary>
        /// 10403 -- en [High] ---- fr [Raide]
        /// </summary>
        AreaSlopeHigh = 10403,
        /// <summary>
        /// 10500 -- en [Land Type] ---- fr [Type de milieu]
        /// </summary>
        SourceTypeLandStart = 10500,
        /// <summary>
        /// 10501 -- en [Agriculture] ---- fr [Agricole]
        /// </summary>
        SourceTypeLandAgriculture = 10501,
        /// <summary>
        /// 10502 -- en [Forested] ---- fr [Forestier]
        /// </summary>
        SourceTypeLandForested = 10502,
        /// <summary>
        /// 10503 -- en [Industry] ---- fr [Industriel]
        /// </summary>
        SourceTypeLandIndustry = 10503,
        /// <summary>
        /// 10504 -- en [Marine] ---- fr [Activités maritimes]
        /// </summary>
        SourceTypeLandMarine = 10504,
        /// <summary>
        /// 10505 -- en [Recreational ] ---- fr [Récréatives]
        /// </summary>
        SourceTypeLandRecreation = 10505,
        /// <summary>
        /// 10506 -- en [Urban] ---- fr [Urbain]
        /// </summary>
        SourceTypeLandUrban = 10506,
        /// <summary>
        /// 10507 -- en [Shoreline] ---- fr [Sur la côte]
        /// </summary>
        SourceTypeShore = 10507,
        /// <summary>
        /// 10600 -- en [Agriculture] ---- fr [Agriculture]
        /// </summary>
        AgricultureStart = 10600,
        /// <summary>
        /// 10601 -- en [Crop] ---- fr [Récolte]
        /// </summary>
        AgricultureCrop = 10601,
        /// <summary>
        /// 10602 -- en [Pasture] ---- fr [Pâturage]
        /// </summary>
        AgriculturePasture = 10602,
        /// <summary>
        /// 10603 -- en [Feedlot] ---- fr [Enclos]
        /// </summary>
        AgricultureFeedlot = 10603,
        /// <summary>
        /// 10604 -- en [Farm] ---- fr [Ferme]
        /// </summary>
        AgricultureFarm = 10604,
        /// <summary>
        /// 10605 -- en [Buildings] ---- fr [Bâtiments]
        /// </summary>
        AgricultureBuilding = 10605,
        /// <summary>
        /// 10700 -- en [Crop] ---- fr [Récolte]
        /// </summary>
        CropStart = 10700,
        /// <summary>
        /// 10701 -- en [Food] ---- fr [Nourriture]
        /// </summary>
        CropFood = 10701,
        /// <summary>
        /// 10702 -- en [Hay] ---- fr [Foin]
        /// </summary>
        CropHay = 10702,
        /// <summary>
        /// 10703 -- en [Peat Moss] ---- fr [Tourbe]
        /// </summary>
        CropPeatMoss = 10703,
        /// <summary>
        /// 10800 -- en [Pasture] ---- fr [Pâturage]
        /// </summary>
        PastureStart = 10800,
        /// <summary>
        /// 10801 -- en [Active] ---- fr [Actif]
        /// </summary>
        PastureActive = 10801,
        /// <summary>
        /// 10802 -- en [Fallow] ---- fr [Jachère]
        /// </summary>
        PastureFallow = 10802,
        /// <summary>
        /// 10900 -- en [Feedlot] ---- fr [Enclos]
        /// </summary>
        FeedlotStart = 10900,
        /// <summary>
        /// 10901 -- en [Active] ---- fr [Actif]
        /// </summary>
        FeedlotActive = 10901,
        /// <summary>
        /// 10902 -- en [Not Active] ---- fr [Inactif]
        /// </summary>
        FeedlotNotActive = 10902,
        /// <summary>
        /// 11000 -- en [Farm] ---- fr [Ferme]
        /// </summary>
        FarmStart = 11000,
        /// <summary>
        /// 11001 -- en [Hobby] ---- fr [Divertissement]
        /// </summary>
        FarmHobby = 11001,
        /// <summary>
        /// 11002 -- en [Commercial] ---- fr [Commercial]
        /// </summary>
        FarmCommerical = 11002,
        /// <summary>
        /// 11100 -- en [Forested] ---- fr [Foresterie]
        /// </summary>
        ForestedStart = 11100,
        /// <summary>
        /// 11101 -- en [Forest harvesting] ---- fr [Activités d'exploitation forestière]
        /// </summary>
        ForestedLoggingActivity = 11101,
        /// <summary>
        /// 11102 -- en [Clearcut] ---- fr [Coupe à blanc]
        /// </summary>
        ForestedClearcut = 11102,
        /// <summary>
        /// 11103 -- en [Regrowth] ---- fr [Reboisement]
        /// </summary>
        ForestedRegrowth = 11103,
        /// <summary>
        /// 11104 -- en [Building] ---- fr [Bâtiment]
        /// </summary>
        ForestedBuilding = 11104,
        /// <summary>
        /// 11200 -- en [Industry] ---- fr [Industrie]
        /// </summary>
        IndustryStart = 11200,
        /// <summary>
        /// 11201 -- en [Airport] ---- fr [Aéroport]
        /// </summary>
        IndustryAirport = 11201,
        /// <summary>
        /// 11202 -- en [Landfill] ---- fr [Centre d'enfouissement]
        /// </summary>
        IndustryLandfill = 11202,
        /// <summary>
        /// 11203 -- en [Fisheries] ---- fr [Pêches]
        /// </summary>
        IndustryFisheriesRelated = 11203,
        /// <summary>
        /// 11204 -- en [Waste treatment] ---- fr [Traitement des eaux usées]
        /// </summary>
        IndustryWaste = 11204,
        /// <summary>
        /// 11205 -- en [Storage tank] ---- fr [Réservoir]
        /// </summary>
        IndustryStorageTank = 11205,
        /// <summary>
        /// 11206 -- en [Commercial] ---- fr [Commerces]
        /// </summary>
        IndustryCommercial = 11206,
        /// <summary>
        /// 11300 -- en [Type of fish] ---- fr [Type de poisson]
        /// </summary>
        TypeOfFishStart = 11300,
        /// <summary>
        /// 11301 -- en [Shellfish] ---- fr [Mollusques]
        /// </summary>
        FishProcessingShellfish = 11301,
        /// <summary>
        /// 11302 -- en [Finfish] ---- fr [Poissons]
        /// </summary>
        FishProcessingFinfish = 11302,
        /// <summary>
        /// 11303 -- en [Fish meal] ---- fr [Nourriture à base de poisson]
        /// </summary>
        FishProcessingFishMeal = 11303,
        /// <summary>
        /// 11400 -- en [Marine facilities] ---- fr [Installations marines]
        /// </summary>
        MarineStart = 11400,
        /// <summary>
        /// 11401 -- en [Wharf] ---- fr [Quai]
        /// </summary>
        MarineWharf = 11401,
        /// <summary>
        /// 11402 -- en [Buildings] ---- fr [Bâtiment]
        /// </summary>
        MarineBuildings = 11402,
        /// <summary>
        /// 11403 -- en [Seawall] ---- fr [Mur marin]
        /// </summary>
        MarineSeaWall = 11403,
        /// <summary>
        /// 11500 -- en [Wharf] ---- fr [Quai]
        /// </summary>
        WharfStart = 11500,
        /// <summary>
        /// 11501 -- en [Commercial transportation] ---- fr [Transport commercial]
        /// </summary>
        WharfCommercialTransportation = 11501,
        /// <summary>
        /// 11502 -- en [Fishing] ---- fr [Pêche]
        /// </summary>
        WharfFishing = 11502,
        /// <summary>
        /// 11503 -- en [Private] ---- fr [Privé]
        /// </summary>
        WharfPrivate = 11503,
        /// <summary>
        /// 11504 -- en [Marina] ---- fr [Marina]
        /// </summary>
        WharfMarina = 11504,
        /// <summary>
        /// 11505 -- en [Abandoned] ---- fr [Abandonné]
        /// </summary>
        WharfAbandoned = 11505,
        /// <summary>
        /// 11600 -- en [Vessel Type] ---- fr [Type de bateau]
        /// </summary>
        WharfTransportationStart = 11600,
        /// <summary>
        /// 11601 -- en [Ship] ---- fr [Navire]
        /// </summary>
        TransportationCommerical = 11601,
        /// <summary>
        /// 11602 -- en [Ferry] ---- fr [Traversier]
        /// </summary>
        TransportationFerry = 11602,
        /// <summary>
        /// 11700 -- en [Recreational Activities] ---- fr [Activités récréatives]
        /// </summary>
        RecreationStart = 11700,
        /// <summary>
        /// 11701 -- en [Campground] ---- fr [Terrain de camping]
        /// </summary>
        RecreationCampground = 11701,
        /// <summary>
        /// 11702 -- en [Day use area] ---- fr [Aire d'utilisation journalière]
        /// </summary>
        RecreationDayUseArea = 11702,
        /// <summary>
        /// 11703 -- en [Swimming area] ---- fr [Zone de baignade]
        /// </summary>
        RecreationSwimmingArea = 11703,
        /// <summary>
        /// 11704 -- en [Residental or recreational area] ---- fr [Aire Activités récréatives or residental]
        /// </summary>
        RecreationRecreationaltArea = 11704,
        /// <summary>
        /// 11705 -- en [Community Centre] ---- fr [Centre communautaire]
        /// </summary>
        RecreationCommunityCentre = 11705,
        /// <summary>
        /// 11706 -- en [Golf Course] ---- fr [Terrain de golf]
        /// </summary>
        RecreationGolfCourse = 11706,
        /// <summary>
        /// 11800 -- en [Campground size] ---- fr [Taille du terrain de camping]
        /// </summary>
        CampgroundFacilitiesStart = 11800,
        /// <summary>
        /// 11801 -- en [no dump station ] ---- fr [Aucune station d’élimination des eaux usées]
        /// </summary>
        CampgroundNoDumpStn = 11801,
        /// <summary>
        /// 11802 -- en [dump station] ---- fr [Station d’élimination des eaux usées]
        /// </summary>
        CampgroundwithDumpStn = 11802,
        /// <summary>
        /// 11900 -- en [Sewage] ---- fr [Égoûts]
        /// </summary>
        SewageStart = 11900,
        /// <summary>
        /// 11901 -- en [Cesspool/Holding tank] ---- fr [Fosse / Réservoir]
        /// </summary>
        SewageCesspool = 11901,
        /// <summary>
        /// 11902 -- en [Direct discharge] ---- fr [Décharge directe]
        /// </summary>
        SewageDirectDischarge = 11902,
        /// <summary>
        /// 11903 -- en [Privy-Outhouse] ---- fr [Fosse des latrines]
        /// </summary>
        SewagePrivyOuthouse = 11903,
        /// <summary>
        /// 11904 -- en [Municipal system] ---- fr [Système municipal]
        /// </summary>
        SewageMunicipalSystem = 11904,
        /// <summary>
        /// 11905 -- en [Drainage field] ---- fr [Aire de drainage]
        /// </summary>
        SepticSystemDrainageField = 11905,
        /// <summary>
        /// 11906 -- en [Full retention] ---- fr [Rétention complète]
        /// </summary>
        SepticSystemFullRention = 11906,
        /// <summary>
        /// 11907 -- en [Lagoon ] ---- fr [Lagune]
        /// </summary>
        SepticSystemLagoon = 11907,
        /// <summary>
        /// 11908 -- en [No Structure] ---- fr [Aucune structure]
        /// </summary>
        SepticNoStructure = 11908,
        /// <summary>
        /// 12000 -- en [Infrastructure] ---- fr [Infrastructure]
        /// </summary>
        SeeMunicipalityInfrastructureStart = 12000,
        /// <summary>
        /// 12100 -- en [Urban] ---- fr [Urbain]
        /// </summary>
        UrbanStart = 12100,
        /// <summary>
        /// 12104 -- en [Storm water] ---- fr [Eaux pluviales]
        /// </summary>
        UrbanStormWater = 12104,
        /// <summary>
        /// 12106 -- en [Surface runoff] ---- fr [Ruisellement de surface]
        /// </summary>
        UrbanSurfaceRunoff = 12106,
        /// <summary>
        /// 12107 -- en [Dump Station] ---- fr [Station d’élimination des eaux usées]
        /// </summary>
        UrbanDumpStation = 12107,
        /// <summary>
        /// 12200 -- en [Wildlife] ---- fr [Faune]
        /// </summary>
        WildlifeStart = 12200,
        /// <summary>
        /// 12201 -- en [Birds] ---- fr [Oiseaux]
        /// </summary>
        WildlifeBirds = 12201,
        /// <summary>
        /// 12202 -- en [Land mammals] ---- fr [Mammifères terrestres]
        /// </summary>
        WildlifeLandMammals = 12202,
        /// <summary>
        /// 12203 -- en [Marine Mammals] ---- fr [Mammifères marins]
        /// </summary>
        WildlifeMarineMammals = 12203,
        /// <summary>
        /// 12300 -- en [Municipal System] ---- fr [Eaux pluviales]
        /// </summary>
        MunicipalSystemStart = 12300,
        /// <summary>
        /// 12301 -- en [Connected to Infrastructure] ---- fr [Infrastructure des eaux pluviales]
        /// </summary>
        MuncipialSystemConnected = 12301,
        /// <summary>
        /// 12302 -- en [Not connected to Municipal System] ---- fr [Collecteur des eaux pluviales]
        /// </summary>
        MunicipalSystemNotConnected = 12302,
        /// <summary>
        /// 12400 -- en [StorageTank] ---- fr [Réservoir de stockage]
        /// </summary>
        StorageTankStart = 12400,
        /// <summary>
        /// 12401 -- en [Fuel Tank] ---- fr [Carburant]
        /// </summary>
        StorageTankFuel = 12401,
        /// <summary>
        /// 12402 -- en [Propane Tank] ---- fr [Propane]
        /// </summary>
        StorageTankPropane = 12402,
        /// <summary>
        /// 12403 -- en [Chemical Tank] ---- fr [Produits chimiques]
        /// </summary>
        StorageTankChemicals = 12403,
        /// <summary>
        /// 12500 -- en [Tank Size] ---- fr [Taille du réservoir]
        /// </summary>
        TankSizeStart = 12500,
        /// <summary>
        /// 12501 -- en [Small Tank] ---- fr [Petit]
        /// </summary>
        TankSizeSmall = 12501,
        /// <summary>
        /// 12502 -- en [Large Tank] ---- fr [Grand]
        /// </summary>
        TankSizeLarge = 12502,
        /// <summary>
        /// 12600 -- en [Building Types] ---- fr [Type d'édifices]
        /// </summary>
        BuildingAgricultureStart = 12600,
        /// <summary>
        /// 12601 -- en [Residental ] ---- fr [Résidentiel]
        /// </summary>
        BuildingResidentialFarm = 12601,
        /// <summary>
        /// 12602 -- en [Warehouse] ---- fr [Entrepôt]
        /// </summary>
        BuildingWarehouseFarm = 12602,
        /// <summary>
        /// 12603 -- en [Commercial] ---- fr [Commercial-affaires, ]
        /// </summary>
        BuildingCommericalFarm = 12603,
        /// <summary>
        /// 12604 -- en [Barn] ---- fr [Grange]
        /// </summary>
        BuildingBarnFarm = 12604,
        /// <summary>
        /// 12605 -- en [Recreational] ---- fr [Récréatif]
        /// </summary>
        BuildingRecreational = 12605,
        /// <summary>
        /// 12700 -- en [Forested Buildings ] ---- fr [Édifice forestier]
        /// </summary>
        BuildingForestedStart = 12700,
        /// <summary>
        /// 12701 -- en [Residental ] ---- fr [Résidentiel]
        /// </summary>
        BuildingForestedResidential = 12701,
        /// <summary>
        /// 12702 -- en [Warehouse] ---- fr [Entrepôt]
        /// </summary>
        BuildingForestedWarehouse = 12702,
        /// <summary>
        /// 12703 -- en [Recreational] ---- fr [Récréatif]
        /// </summary>
        BuildingForestedRecreational = 12703,
        /// <summary>
        /// 12704 -- en [Trailer] ---- fr [Caravane]
        /// </summary>
        BuildingForestedTrailer = 12704,
        /// <summary>
        /// 12705 -- en [Factory] ---- fr [Usine]
        /// </summary>
        BuildingForestedFactory = 12705,
        /// <summary>
        /// 12706 -- en [Commercial] ---- fr [Commercial]
        /// </summary>
        BuildingForestedCommerical = 12706,
        /// <summary>
        /// 12800 -- en [Type of Buildings] ---- fr [Type d'édifices]
        /// </summary>
        BuildingTypeStart = 12800,
        /// <summary>
        /// 12801 -- en [Warehouse] ---- fr [Entrepôt]
        /// </summary>
        BuildingindustryWarehouse = 12801,
        /// <summary>
        /// 12802 -- en [Factory] ---- fr [Usine]
        /// </summary>
        BuildingIndustryFactory = 12802,
        /// <summary>
        /// 12803 -- en [Commercial] ---- fr [Commercial]
        /// </summary>
        BuildingIndustryCommerical = 12803,
        /// <summary>
        /// 12900 -- en [Fishery Buildings] ---- fr [Bâtiments pour la pêche]
        /// </summary>
        BuildingFishStart = 12900,
        /// <summary>
        /// 12901 -- en [Hatchery] ---- fr [Incubateur]
        /// </summary>
        BuildingFishHatchery = 12901,
        /// <summary>
        /// 12902 -- en [Tanks ] ---- fr [Réservoirs]
        /// </summary>
        BuildingFishTanks = 12902,
        /// <summary>
        /// 12903 -- en [Warehouse] ---- fr [Entrepôt]
        /// </summary>
        BuildingFishWarehouse = 12903,
        /// <summary>
        /// 12904 -- en [Commercial] ---- fr [Commercial]
        /// </summary>
        BuildingFishCommercial = 12904,
        /// <summary>
        /// 13000 -- en [Buildings] ---- fr [Bâtiments]
        /// </summary>
        BuildingAllStart = 13000,
        /// <summary>
        /// 13001 -- en [Cottage] ---- fr [Chalet]
        /// </summary>
        BuildingAllCottage = 13001,
        /// <summary>
        /// 13002 -- en [Trailer] ---- fr [Caravane]
        /// </summary>
        BuildingAllTrailer = 13002,
        /// <summary>
        /// 13003 -- en [Residental ] ---- fr [Résidentiel]
        /// </summary>
        BuildingAllResidential = 13003,
        /// <summary>
        /// 13004 -- en [Warehouse] ---- fr [Entrepôt]
        /// </summary>
        BuildingAllWarehouse = 13004,
        /// <summary>
        /// 13005 -- en [Hotel or motel] ---- fr [Hôtel ou motel]
        /// </summary>
        BuildingAllHotelMotel = 13005,
        /// <summary>
        /// 13006 -- en [Commercial-Business] ---- fr [Commercial-affaires]
        /// </summary>
        BuildingAllCommerical = 13006,
        /// <summary>
        /// 13100 -- en [Number ] ---- fr [Nombre d'unités]
        /// </summary>
        CountNumberStart = 13100,
        /// <summary>
        /// 13101 -- en [    1] ---- fr [  1]
        /// </summary>
        CountNumberEqualTo1 = 13101,
        /// <summary>
        /// 13102 -- en [   1 - 5] ---- fr [1 à 5]
        /// </summary>
        CountNumberBetween1and5 = 13102,
        /// <summary>
        /// 13103 -- en [  5 - 10] ---- fr [5 à 10]
        /// </summary>
        CountNumberbBetween5and10 = 13103,
        /// <summary>
        /// 13104 -- en [10 - 25] ---- fr [10 à 25]
        /// </summary>
        CountNumberbBetween10and25 = 13104,
        /// <summary>
        /// 13105 -- en [25 - 40] ---- fr [25 à 40]
        /// </summary>
        CountNumberbBetween25and40 = 13105,
        /// <summary>
        /// 13106 -- en [40 and more] ---- fr [40 et plus.]
        /// </summary>
        CountNumberGreaterThan40 = 13106,
        /// <summary>
        /// 13200 -- en [Area size] ---- fr [Taille de l'endroit]
        /// </summary>
        AreaSizeStart = 13200,
        /// <summary>
        /// 13201 -- en [Small] ---- fr [Petit]
        /// </summary>
        AreaSizeSmall = 13201,
        /// <summary>
        /// 13202 -- en [Large] ---- fr [Grand]
        /// </summary>
        AreaSizeLarge = 13202,
        /// <summary>
        /// 13300 -- en [Fecal source] ---- fr [Source fécale]
        /// </summary>
        FecalSourceStart = 13300,
        /// <summary>
        /// 13301 -- en [Livestock] ---- fr [Bétail]
        /// </summary>
        FecalSourceLivestock = 13301,
        /// <summary>
        /// 13302 -- en [People] ---- fr [Personnes]
        /// </summary>
        FecalSourcePeople = 13302,
        /// <summary>
        /// 13303 -- en [Wildlife] ---- fr [Faune]
        /// </summary>
        FecalSourceWildlife = 13303,
        /// <summary>
        /// 13304 -- en [Absent] ---- fr [Nul]
        /// </summary>
        FecalSourceAbsent = 13304,
        /// <summary>
        /// 13305 -- en [Drainage Water] ---- fr [Écoulement d'eau]
        /// </summary>
        FecalSourceDrainagewater = 13305,
        /// <summary>
        /// 13400 -- en [Major Issue] ---- fr [Préoccupation majeure]
        /// </summary>
        MajorIssueSourceStart = 13400,
        /// <summary>
        /// 13401 -- en [Manure pile] ---- fr [Tas de fumier]
        /// </summary>
        MajorIssueSourceManurePile = 13401,
        /// <summary>
        /// 13402 -- en [No issue identified] ---- fr [Aucun problème identifié]
        /// </summary>
        MajorIssueAbsent1 = 13402,
        /// <summary>
        /// 13403 -- en [Runoff] ---- fr [Ruisellement]
        /// </summary>
        MajorIssueRunoff = 13403,
        /// <summary>
        /// 13500 -- en [Land Fill Type] ---- fr [Type de mise en décharge]
        /// </summary>
        LandfillTypeStart = 13500,
        /// <summary>
        /// 13501 -- en [Residental Landfill] ---- fr [Mise en décharge résidentielle]
        /// </summary>
        LandfillTypeResidental = 13501,
        /// <summary>
        /// 13502 -- en [Industrial Landfill] ---- fr [Mise en décharge industrielle]
        /// </summary>
        LandfillTypeIndustrial = 13502,
        /// <summary>
        /// 13503 -- en [Woodwaste Landfill] ---- fr [Mise en décharge de déchets ligneux]
        /// </summary>
        LandfillTypeWoodwaste = 13503,
        /// <summary>
        /// 13600 -- en [Number present] ---- fr [Nombre présent]
        /// </summary>
        NumberPresentStart = 13600,
        /// <summary>
        /// 13601 -- en [     less than 5] ---- fr [ moins de 5]
        /// </summary>
        NumberPresentLessThan5 = 13601,
        /// <summary>
        /// 13602 -- en [   5 - 10] ---- fr [5 à 10]
        /// </summary>
        NumberPresentBetween5and10 = 13602,
        /// <summary>
        /// 13603 -- en [ 10 - 25] ---- fr [10 à 25]
        /// </summary>
        NumberPresentBetween10and25 = 13603,
        /// <summary>
        /// 13604 -- en [25 and more] ---- fr [25 et plus]
        /// </summary>
        NumberPresentGreaterThan25 = 13604,
        /// <summary>
        /// 13700 -- en [Type of livestock] ---- fr [Type de bétail]
        /// </summary>
        TypesOfLivestockStart = 13700,
        /// <summary>
        /// 13701 -- en [Large domestic livestock] ---- fr [Grands, domestiques]
        /// </summary>
        TypesEqualLargeDomestic = 13701,
        /// <summary>
        /// 13702 -- en [Small domestic livestock] ---- fr [Petits, domestiques]
        /// </summary>
        TypesEqualSmallDomestic = 13702,
        /// <summary>
        /// 13703 -- en [Domestic birds] ---- fr [Oiseaux domestiques]
        /// </summary>
        TypesEqualDomesticBirds = 13703,
        /// <summary>
        /// 13704 -- en [Fur farm animals] ---- fr [Commerce de la fourrure]
        /// </summary>
        TypesEqualFurFarms = 13704,
        /// <summary>
        /// 13705 -- en [A mixture of domestic animals] ---- fr [Domestique mixte]
        /// </summary>
        TypesEqualDomesticMixture = 13705,
        /// <summary>
        /// 13800 -- en [Type of wildlife] ---- fr [Type d'animal]
        /// </summary>
        TypesOfWildlifeStart = 13800,
        /// <summary>
        /// 13801 -- en [Small wild animals] ---- fr [Petits animaux sauvages]
        /// </summary>
        TypesEqualSmallWildAnimals = 13801,
        /// <summary>
        /// 13802 -- en [ Large wild animals] ---- fr [Grands animaux sauvages]
        /// </summary>
        TypesEqualLargeWildAnimals = 13802,
        /// <summary>
        /// 13803 -- en [  Large birds] ---- fr [Grands oiseaux]
        /// </summary>
        TypesEqualLargeBirds = 13803,
        /// <summary>
        /// 13804 -- en [   Medium birds] ---- fr [Moyens oiseaux]
        /// </summary>
        TypesEqualMediumBirds = 13804,
        /// <summary>
        /// 13805 -- en [     Small birds] ---- fr [Petits oiseaux]
        /// </summary>
        TypesEqualSmallBirds = 13805,
        /// <summary>
        /// 13900 -- en [Number present] ---- fr [Nombre présent]
        /// </summary>
        AnimalNumberPresentStart = 13900,
        /// <summary>
        /// 13901 -- en [      less than 5] ---- fr [ moins de 5]
        /// </summary>
        NumberAnimalPresentLessThan5 = 13901,
        /// <summary>
        /// 13902 -- en [     5 - 10] ---- fr [5 à 10]
        /// </summary>
        NumberAnimalPresentBetween5and10 = 13902,
        /// <summary>
        /// 13903 -- en [   10 - 25] ---- fr [10 à 25 ]
        /// </summary>
        NumberAnimalPresentBetween10and25 = 13903,
        /// <summary>
        /// 13904 -- en [  25 - 100] ---- fr [ 25 à 100 ]
        /// </summary>
        NumberAnimalPresentBetween25and100 = 13904,
        /// <summary>
        /// 13905 -- en [100 and more] ---- fr [   100 et plus]
        /// </summary>
        NumberAnimalPresentGreaterThan100 = 13905,
        /// <summary>
        /// 16600 -- en [Point Source] ---- fr [Source ponctuelle]
        /// </summary>
        PointSourceWildlifeStart = 16600,
        /// <summary>
        /// 16601 -- en [Directly to water] ---- fr [Directement vers un cours d'eau]
        /// </summary>
        SourceDirectInputToMarine = 16601,
        /// <summary>
        /// 14000 -- en [Boat] ---- fr [Bateau]
        /// </summary>
        BoatStart = 14000,
        /// <summary>
        /// 14001 -- en [   1] ---- fr [ 1 bateau]
        /// </summary>
        BoatCountEquals1 = 14001,
        /// <summary>
        /// 14002 -- en [  2 - 5] ---- fr [ 2 à 5 bateaux]
        /// </summary>
        BoatCountLessThan5 = 14002,
        /// <summary>
        /// 14003 -- en [  5 - 25] ---- fr [ 5 à 25 bateaux]
        /// </summary>
        BoatCountBetween5and25 = 14003,
        /// <summary>
        /// 14004 -- en [ 25 - 50] ---- fr [ 25 à 50 bateaux]
        /// </summary>
        BoatCountBetween25and50 = 14004,
        /// <summary>
        /// 14005 -- en [ 50 - 100] ---- fr [ 50 à 100 bateaux]
        /// </summary>
        BoatCountBetween50and100 = 14005,
        /// <summary>
        /// 14006 -- en [100 and more] ---- fr [ 100 bateaux et plus]
        /// </summary>
        BoatCountBetweenMoreThan100 = 14006,
        /// <summary>
        /// 14100 -- en [Oil dumping facility] ---- fr [Installations pour vider l'huile]
        /// </summary>
        OilDumpingFacilityStart = 14100,
        /// <summary>
        /// 14101 -- en [Present] ---- fr [Présent]
        /// </summary>
        OilDumpingFacilityPresent = 14101,
        /// <summary>
        /// 14102 -- en [Absent] ---- fr [Absent]
        /// </summary>
        OilDumpingFacilityAbsent = 14102,
        /// <summary>
        /// 14200 -- en [Sewage dumping station] ---- fr [Station d’élimination des eaux usées]
        /// </summary>
        SewageDumpingStationStart = 14200,
        /// <summary>
        /// 14201 -- en [Present] ---- fr [Présent]
        /// </summary>
        SewageDumpingStationPresent = 14201,
        /// <summary>
        /// 14202 -- en [Absent] ---- fr [Absent]
        /// </summary>
        SewageDumpingStationAbsent = 14202,
        /// <summary>
        /// 14300 -- en [Point source] ---- fr [Source ponctuelle]
        /// </summary>
        PointSourceStart = 14300,
        /// <summary>
        /// 14301 -- en [Culvert] ---- fr [Aqueduc]
        /// </summary>
        SourceTypeLandCulvert = 14301,
        /// <summary>
        /// 14302 -- en [Pipe] ---- fr [Tuyau]
        /// </summary>
        SourceTypeLandPipe = 14302,
        /// <summary>
        /// 14303 -- en [Water course] ---- fr [Cours d'eau]
        /// </summary>
        SourceTypeLandWaterCourse = 14303,
        /// <summary>
        /// 14304 -- en [Ditch] ---- fr [Fossé]
        /// </summary>
        SourceTypeLandDitch = 14304,
        /// <summary>
        /// 14305 -- en [Surface Drainage] ---- fr [Débit]
        /// </summary>
        SourceTypeLandDrainage = 14305,
        /// <summary>
        /// 14306 -- en [Directly to water] ---- fr [Directement vers un cours d'eau]
        /// </summary>
        SourceTypeDirectInputToMarine = 14306,
        /// <summary>
        /// 14400 -- en [Manure point source] ---- fr [Source ponctuelle du fumier]
        /// </summary>
        PointSourceManureStart = 14400,
        /// <summary>
        /// 14401 -- en [Drainage] ---- fr [Écoulement]
        /// </summary>
        SourceManureLandDrainage = 14401,
        /// <summary>
        /// 14402 -- en [Ditch] ---- fr [Fossé]
        /// </summary>
        SourceManureDitch = 14402,
        /// <summary>
        /// 14500 -- en [Pipe or culvert diameter (centimeters)] ---- fr [Diamètre du tuyau ou aqueduc en centimètres ]
        /// </summary>
        DiameterInCentimetersStart = 14500,
        /// <summary>
        /// 14501 -- en [  less than 30] ---- fr [  moins de 30 (cm)]
        /// </summary>
        DiameterInCentimetersLessThan30 = 14501,
        /// <summary>
        /// 14502 -- en [ 30 - 100] ---- fr [ 30 à 100 (cm)]
        /// </summary>
        DiameterInCentimetersBetween30and100cm = 14502,
        /// <summary>
        /// 14503 -- en [100 - 200] ---- fr [100 à 200 (cm)]
        /// </summary>
        DiameterInCentimetersBetween100and200cm = 14503,
        /// <summary>
        /// 14504 -- en [200 and more] ---- fr [200 et plus (cm)]
        /// </summary>
        DiameterInCentimetersMoreThan200cm = 14504,
        /// <summary>
        /// 14600 -- en [Flow] ---- fr [Débit]
        /// </summary>
        FlowLevelStart = 14600,
        /// <summary>
        /// 14601 -- en [High] ---- fr [Élevé]
        /// </summary>
        FlowLevelHigh = 14601,
        /// <summary>
        /// 14602 -- en [ Medium] ---- fr [ Modéré]
        /// </summary>
        FlowLevelMedium = 14602,
        /// <summary>
        /// 14603 -- en [  Low] ---- fr [  Faible]
        /// </summary>
        FlowLevelLow = 14603,
        /// <summary>
        /// 14700 -- en [Outhouse] ---- fr [Fosse des latrines]
        /// </summary>
        OuthouseStart = 14700,
        /// <summary>
        /// 14701 -- en [Cement holding tank] ---- fr [Réservoir en béton]
        /// </summary>
        OuthouseCementHoldingTank = 14701,
        /// <summary>
        /// 14702 -- en [On ground] ---- fr [Sur le sol]
        /// </summary>
        OuthouseSittingOnGround = 14702,
        /// <summary>
        /// 14800 -- en [Width (meters)] ---- fr [Largeur (mètres)]
        /// </summary>
        WidthInMetersStart = 14800,
        /// <summary>
        /// 14801 -- en [  less than 1] ---- fr [moins que 1]
        /// </summary>
        WidthInMetersLessThan1 = 14801,
        /// <summary>
        /// 14802 -- en [ 1 - 5] ---- fr [1 à 5]
        /// </summary>
        WidthInMetersBetween1And5 = 14802,
        /// <summary>
        /// 14803 -- en [ 5 - 25] ---- fr [5 à 25]
        /// </summary>
        WidthInMetersBetween5And25 = 14803,
        /// <summary>
        /// 14804 -- en [25 and more] ---- fr [25 et plus]
        /// </summary>
        WidthInMetersMoreThan25 = 14804,
        /// <summary>
        /// 14900 -- en [Ditch] ---- fr [Fossé]
        /// </summary>
        DitchStart = 14900,
        /// <summary>
        /// 14901 -- en [Along a road] ---- fr [Le long d'un chemin]
        /// </summary>
        DitchAlongRoad = 14901,
        /// <summary>
        /// 14902 -- en [Across properties] ---- fr [Par le biais de terrains]
        /// </summary>
        DitchBetweenAcrossProperties = 14902,
        /// <summary>
        /// 15000 -- en [Drainage] ---- fr [Drainage]
        /// </summary>
        DrainageStart = 15000,
        /// <summary>
        /// 15001 -- en [Paved surface] ---- fr [Surface d'asphalte]
        /// </summary>
        DrainagePavedSurfaces = 15001,
        /// <summary>
        /// 15002 -- en [Vegetated surface] ---- fr [Surface recouverte de végétation]
        /// </summary>
        DrainageVegetatedSurfaces = 15002,
        /// <summary>
        /// 15003 -- en [Direct flow] ---- fr [Débit direct]
        /// </summary>
        DrainageDirect = 15003,
        /// <summary>
        /// 15004 -- en [Bare soil] ---- fr [Sol]
        /// </summary>
        DrainageBareSoilSurfaces = 15004,
        /// <summary>
        /// 15100 -- en [Manure pile size] ---- fr [Grandeur du tas de fumier]
        /// </summary>
        ManurePileSizeStart = 15100,
        /// <summary>
        /// 15101 -- en [Small] ---- fr [Petit]
        /// </summary>
        ManurePileSmall = 15101,
        /// <summary>
        /// 15102 -- en [Large] ---- fr [Grand ]
        /// </summary>
        ManurePileLarge = 15102,
        /// <summary>
        /// 15200 -- en [Source type ] ---- fr [Source définie]
        /// </summary>
        SourceTypeWaterStart = 15200,
        /// <summary>
        /// 15201 -- en [Aquaculture site] ---- fr [Site de l'aquaculture]
        /// </summary>
        SourceTypeWaterAquacultureSite = 15201,
        /// <summary>
        /// 15202 -- en [Anchorage mooring site] ---- fr [Site de mouillage ou de amarrage]
        /// </summary>
        SourceTypeWaterAnchorageMooringSite = 15202,
        /// <summary>
        /// 15203 -- en [Disposal -Dredging] ---- fr [Décharge en haute mer]
        /// </summary>
        SourceTypeWaterDisposalAtSea = 15203,
        /// <summary>
        /// 15204 -- en [Marine park] ---- fr [Parc marin]
        /// </summary>
        SourceTypeWaterMarinePark = 15204,
        /// <summary>
        /// 15205 -- en [Seaport] ---- fr [Port de mer]
        /// </summary>
        SourceTypeWaterSeaport = 15205,
        /// <summary>
        /// 15206 -- en [Sandbar or Rock Outcrop] ---- fr [Banc de sable]
        /// </summary>
        SourceSandBar = 15206,
        /// <summary>
        /// 15300 -- en [Aquaculture site] ---- fr [Site de l'aquaculture]
        /// </summary>
        WaterAquacultureStart = 15300,
        /// <summary>
        /// 15301 -- en [Active] ---- fr [Actif]
        /// </summary>
        WaterAquacultureSiteActive = 15301,
        /// <summary>
        /// 15302 -- en [Fallow] ---- fr [Inutilisé]
        /// </summary>
        WaterAquacultureSiteFallow = 15302,
        /// <summary>
        /// 15400 -- en [Aquaculture type] ---- fr [Type d'aquaculture  ]
        /// </summary>
        WaterAquacultureTypeStart = 15400,
        /// <summary>
        /// 15401 -- en [Cages] ---- fr [Cages]
        /// </summary>
        AquacultureCages = 15401,
        /// <summary>
        /// 15402 -- en [Floating bags] ---- fr [Sacs flottantes]
        /// </summary>
        AquacultureFloatingBags = 15402,
        /// <summary>
        /// 15403 -- en [Submerged lines] ---- fr [Lignes submergées ]
        /// </summary>
        AquacultureSubmergedLines = 15403,
        /// <summary>
        /// 15500 -- en [Structure] ---- fr [Structure]
        /// </summary>
        WaterStructureSiteStart = 15500,
        /// <summary>
        /// 15501 -- en [Vessels] ---- fr [Embarcation]
        /// </summary>
        WaterStructureVessel = 15501,
        /// <summary>
        /// 15502 -- en [Barge] ---- fr [Barque]
        /// </summary>
        WaterStructureBarge = 15502,
        /// <summary>
        /// 15503 -- en [Residental] ---- fr [Résidentiel]
        /// </summary>
        WaterStructureResidental = 15503,
        /// <summary>
        /// 15504 -- en [Commerical] ---- fr [Commercial]
        /// </summary>
        WaterStructureCommercial = 15504,
        /// <summary>
        /// 15505 -- en [Not Active] ---- fr [  Inactif]
        /// </summary>
        WaterStructureNotActive = 15505,
        /// <summary>
        /// 15600 -- en [Disposal at sea] ---- fr [Décharge en haute mer]
        /// </summary>
        WaterDisposalAtSeaStart = 15600,
        /// <summary>
        /// 15601 -- en [Dump site active] ---- fr [Site de décharge actif]
        /// </summary>
        WaterDumpSiteActive = 15601,
        /// <summary>
        /// 15602 -- en [Dump site not active] ---- fr [Site de décharge inactif]
        /// </summary>
        WaterDumpSiteNotActive = 15602,
        /// <summary>
        /// 15700 -- en [Seaport] ---- fr [Port de mer]
        /// </summary>
        WaterSeaportStart = 15700,
        /// <summary>
        /// 15701 -- en [Recreational boats] ---- fr [Bateaux de plaisance ]
        /// </summary>
        SeaportRecreational = 15701,
        /// <summary>
        /// 15702 -- en [Commerical Vessels] ---- fr [Bateaux commerciaux]
        /// </summary>
        SeaportCommercial = 15702,
        /// <summary>
        /// 15800 -- en [Size] ---- fr [Grandeure]
        /// </summary>
        WaterSizeStart = 15800,
        /// <summary>
        /// 15801 -- en [Small] ---- fr [Petit]
        /// </summary>
        AquacultureSmall = 15801,
        /// <summary>
        /// 15802 -- en [Large] ---- fr [Grand ]
        /// </summary>
        AquacultureLarge = 15802,
        /// <summary>
        /// 15900 -- en [Water Type] ---- fr [percentage of salt]
        /// </summary>
        WaterTypeStart = 15900,
        /// <summary>
        /// 15901 -- en [Salt] ---- fr [Salt]
        /// </summary>
        WaterTypeSalt = 15901,
        /// <summary>
        /// 15902 -- en [Brackish] ---- fr [Brackish]
        /// </summary>
        WaterTypeBrachish = 15902,
        /// <summary>
        /// 15903 -- en [Fresh] ---- fr [Fresh]
        /// </summary>
        WaterTypeFresh = 15903,
        /// <summary>
        /// 16000 -- en [Area size] ---- fr [Superficie]
        /// </summary>
        WaterAreaSizeStart = 16000,
        /// <summary>
        /// 16001 -- en [Small] ---- fr [Petit]
        /// </summary>
        WaterAreaSizeSmall = 16001,
        /// <summary>
        /// 16002 -- en [Large] ---- fr [Grand]
        /// </summary>
        WaterAreaSizeLarge = 16002,
        /// <summary>
        /// 16100 -- en [Fecal source] ---- fr [Source de coliformes fécaux]
        /// </summary>
        WaterFecalSourceStart = 16100,
        /// <summary>
        /// 16101 -- en [People] ---- fr [Humain]
        /// </summary>
        WaterFecalSourcePeople = 16101,
        /// <summary>
        /// 16102 -- en [Wildlife] ---- fr [Faune]
        /// </summary>
        WaterFecalSourceWildlife = 16102,
        /// <summary>
        /// 16103 -- en [Absent] ---- fr [Absent]
        /// </summary>
        WaterFecalSourceAbsent = 16103,
        /// <summary>
        /// 16200 -- en [Number of units] ---- fr [Nombre d'unités]
        /// </summary>
        WaterCountNumberStart = 16200,
        /// <summary>
        /// 16201 -- en [   less than 5] ---- fr [ moins que 5.]
        /// </summary>
        WaterCountNumberLessThan5 = 16201,
        /// <summary>
        /// 16202 -- en [ 5 - 10] ---- fr [ 5 à 10.]
        /// </summary>
        WaterCountNumberBetween5and10 = 16202,
        /// <summary>
        /// 16203 -- en [ 10 - 25] ---- fr [ 10 à 25.]
        /// </summary>
        WaterCountNumberBetween10and25 = 16203,
        /// <summary>
        /// 16204 -- en [25 and more] ---- fr [ 25 et plus.]
        /// </summary>
        WaterCountNumberGreaterThan25 = 16204,
        /// <summary>
        /// 16300 -- en [Sewage] ---- fr [Eaux usées]
        /// </summary>
        WaterSewageStart = 16300,
        /// <summary>
        /// 16301 -- en [Direct discharge] ---- fr [Décharge directe]
        /// </summary>
        WaterSewageDirectDischarge = 16301,
        /// <summary>
        /// 16302 -- en [Full retention] ---- fr [Accumulation totale]
        /// </summary>
        WaterSepticSystemFullRention = 16302,
        /// <summary>
        /// 16400 -- en [Number present] ---- fr [Nombre présents.]
        /// </summary>
        WaterNumberPresentStart = 16400,
        /// <summary>
        /// 16401 -- en [   less than 5] ---- fr [moins que 5.]
        /// </summary>
        WaterNumberPresentLessThan5 = 16401,
        /// <summary>
        /// 16402 -- en [  5 - 10] ---- fr [5 à 10.]
        /// </summary>
        WaterNumberPresentBetween5and10 = 16402,
        /// <summary>
        /// 16403 -- en [ 10 - 25] ---- fr [10 à 25.]
        /// </summary>
        WaterNumberPresentBetween10and25 = 16403,
        /// <summary>
        /// 16404 -- en [25 and more] ---- fr [25 et plus.]
        /// </summary>
        WaterNumberPresentGreaterThan25 = 16404,
        /// <summary>
        /// 16500 -- en [Type of wildlife] ---- fr [Type de faune]
        /// </summary>
        WaterTypesOfMarineLifeStart = 16500,
        /// <summary>
        /// 16501 -- en [Small marine animals] ---- fr [Petits animaux marins]
        /// </summary>
        WaterTypesEqualSmallMammals = 16501,
        /// <summary>
        /// 16502 -- en [Large marine animals] ---- fr [Grands animaux marins]
        /// </summary>
        WaterTypesEqualLargeMammals = 16502,
        /// <summary>
        /// 16503 -- en [Large birds] ---- fr [Grands oiseaux]
        /// </summary>
        WaterTypesEqualLargeBirds = 16503,
        /// <summary>
        /// 16504 -- en [Medium birds] ---- fr [Oiseaux de taille moyenne]
        /// </summary>
        WaterTypesEqualMediumBirds = 16504,
        /// <summary>
        /// 16505 -- en [Small birds] ---- fr [Petits oiseaux]
        /// </summary>
        WaterTypesEqualSmallBirds = 16505,
        /// <summary>
        /// 17000 -- en [Type of substrate] ---- fr [Type de substrat]
        /// </summary>
        ShorelineStart = 17000,
        /// <summary>
        /// 17001 -- en [Sandy Shoreline] ---- fr [Littoral de sable]
        /// </summary>
        ShorelineSandy = 17001,
        /// <summary>
        /// 17002 -- en [Rocky Shoreline] ---- fr [Littoral rocheux]
        /// </summary>
        ShorelineRocky = 17002,
        /// <summary>
        /// 17100 -- en [Items on shoreline] ---- fr [Éléments sur le rivage]
        /// </summary>
        ShorelineIssueStart = 17100,
        /// <summary>
        /// 17101 -- en [Building] ---- fr [Édifices]
        /// </summary>
        ShorelineBuildings = 17101,
        /// <summary>
        /// 17102 -- en [Wildlife] ---- fr [Faune]
        /// </summary>
        ShorelineWildlife = 17102,
        /// <summary>
        /// 17103 -- en [Landfill] ---- fr [Site d'enfouissement]
        /// </summary>
        ShorelineLandFill = 17103,
        /// <summary>
        /// 17104 -- en [Slipway] ---- fr [Mise à l'eau]
        /// </summary>
        ShorelineSlipway = 17104,
        /// <summary>
        /// 17105 -- en [Dayuse] ---- fr [Intra-jour]
        /// </summary>
        ShorelineDayuse = 17105,
        /// <summary>
        /// 18000 -- en [Type of Slipway] ---- fr [Genre de mise à l'eau]
        /// </summary>
        SlipwayStart = 18000,
        /// <summary>
        /// 18001 -- en [Paved slipway] ---- fr [Mise à l'eau pavé]
        /// </summary>
        SlipwayPaved = 18001,
        /// <summary>
        /// 18002 -- en [Natural slipway] ---- fr [Mise à l'eau, surface naturelle]
        /// </summary>
        SlipwayRocks = 18002,
        /// <summary>
        /// 19000 -- en [Shoreline] ---- fr [Rivage]
        /// </summary>
        SourceTypeShoreStart = 19000,
        /// <summary>
        /// 19001 -- en [Shore structure] ---- fr [Rivage]
        /// </summary>
        SourceTypeShoreline = 19001,
        /// <summary>
        /// 19002 -- en [Marine Structure] ---- fr [Structure marine]
        /// </summary>
        SourceTypeMarine = 19002,
        /// <summary>
        /// 90000 -- en [Status as a pollutant source ] ---- fr [Évaluation de la source de pollution]
        /// </summary>
        StatusStart = 90000,
        /// <summary>
        /// 90001 -- en [  Definite] ---- fr [Définitif,]
        /// </summary>
        StatusDefinite = 90001,
        /// <summary>
        /// 90002 -- en [   Potential] ---- fr [Potentiel,]
        /// </summary>
        StatusPotential = 90002,
        /// <summary>
        /// 90003 -- en [    Non Active] ---- fr [Non Active]
        /// </summary>
        StatusNonPollutionSource = 90003,
        /// <summary>
        /// 91000 -- en [Risk to Pollute] ---- fr [Le risque de pollution]
        /// </summary>
        RiskAStart = 91000,
        /// <summary>
        /// 91001 -- en [  Low] ---- fr [Faible ]
        /// </summary>
        RiskLow = 91001,
        /// <summary>
        /// 92000 -- en [Risk to Pollute] ---- fr [Le risque de pollution]
        /// </summary>
        RiskBStart = 92000,
        /// <summary>
        /// 92001 -- en [ Moderate] ---- fr [Moyen]
        /// </summary>
        RiskModerate = 92001,
        /// <summary>
        /// 92002 -- en [High] ---- fr [Élevé]
        /// </summary>
        RiskHighP = 92002,
        /// <summary>
        /// 93000 -- en [Risk to Pollute] ---- fr [Le risque de pollution]
        /// </summary>
        RiskCStart = 93000,
        /// <summary>
        /// 93001 -- en [High] ---- fr [Élevé]
        /// </summary>
        RiskHigh = 93001,
    }
}
