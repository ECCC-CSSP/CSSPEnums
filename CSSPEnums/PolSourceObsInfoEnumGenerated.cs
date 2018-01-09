/*
 * Auto generated from the PolSourceGroupingGenerateCode.proj by clicking on the [Generate all code files] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles LeBlanc
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSPEnums
{
    public enum PolSourceObsInfoEnum
    {
        Error = 0,

        Start = 10100,
        LandBased = 10101,
        WaterBased = 10102,

        DistanceFromShoreInMetersStart = 10200,
        DistanceFromShoreInMetersOnShore = 10201,
        DistanceFromShoreInMeters5 = 10202,
        DistanceFromShoreInMeters10 = 10203,
        DistanceFromShoreInMeters20 = 10204,
        DistanceFromShoreInMeters30 = 10205,
        DistanceFromShoreInMeters40 = 10206,
        DistanceFromShoreInMeters50 = 10207,
        DistanceFromShoreInMeters75 = 10208,
        DistanceFromShoreInMeters100 = 10209,
        DistanceFromShoreInMeters150 = 10210,
        DistanceFromShoreInMeters200 = 10212,
        DistanceFromShoreInMeters300 = 10213,
        DistanceFromShoreInMeters400 = 10215,
        DistanceFromShoreInMeters600 = 10216,
        DistanceFromShoreInMeters800 = 10218,
        DistanceFromShoreInMeters1000 = 10219,
        DistanceFromShoreInMetersGreaterThan1000 = 10220,

        ShorelineRiparionZoneStart = 23000,
        ShorelineRiparianZonePresent = 23001,
        ShorelineRiparianZoneAbsent = 23002,
        ShorelineRiparianZoneNoInfo = 23003,

        DistancetoSaltWaterStart = 24000,
        DistancetoSaltWaterInMeters5 = 24001,
        DistancetoSaltWaterInMeters10 = 24002,
        DistancetoSaltWaterInMeters20 = 24003,
        DistancetoSaltWaterInMeters30 = 24004,
        DistancetoSaltWaterInMeters50 = 24005,
        DistancetoSaltWaterInMeters100 = 24006,
        DistancetoSaltWaterInMeters200 = 24007,
        DistancetoSaltWaterInMeters400 = 24008,
        DistancetoSaltWaterInMeters800 = 24009,
        DistancetoSaltWaterInMeters1000 = 24010,
        DistancetoSaltWaterInMetersGreaterThan1000 = 24011,

        AreaSlopeStart = 10400,
        AreaSlopeLow = 10401,
        AreaSlopeMedium = 10402,
        AreaSlopeHigh = 10403,

        SourceTypeLandStart = 10500,
        SourceTypeLandAgriculture = 10501,
        SourceTypeLandForested = 10502,
        SourceTypeLandFisheries = 10503,
        SourceTypeLandIndustry = 10504,
        SourceTypeLandMarineStructure = 10505,
        SourceTypeLandRecreation = 10506,
        SourceTypeLandUrban = 10507,
        SourceTypeShore = 10508,

        AgricultureStart = 10600,
        AgricultureCrop = 10601,
        AgriculturePasture = 10602,
        AgricultureFeedlot = 10603,
        AgricultureFarm = 10604,
        AgricultureBuilding = 10605,

        CropStart = 10700,
        CropFood = 10701,
        CropHay = 10702,
        CropPeatMoss = 10703,

        PastureStart = 10800,
        PastureActive = 10801,
        PastureFallow = 10802,

        FeedlotStart = 10900,
        FeedlotActive = 10901,
        FeedlotNotActive = 10902,

        FarmStart = 11000,
        FarmHobby = 11001,
        FarmCommercial = 11002,

        AgrAreaSizeStart = 16700,
        AgrAreaMetersequals10 = 16701,
        AgrAreaMetersequals20 = 16702,
        AgrAreaMetersequals40 = 16703,
        AgrAreaMetersequals60 = 16704,
        AgrAreaMetersequals80 = 16705,
        AgrAreaMetersequals100 = 16706,
        AgrAreaMetersbetween101And250 = 16707,
        AgrAreaMetersBetween251And500 = 16708,
        AgrAreaMetersBetween501And1000 = 16709,
        AgrAreaMetersGreaterThan1000 = 16710,

        ForestedStart = 11100,
        ForestedLoggingActivity = 11101,
        ForestedClearcut = 11102,
        ForestedRegrowth = 11103,
        ForestedBuilding = 11104,

        ForAreaSizeStart = 16800,
        ForAreaMetersequals10 = 16801,
        ForAreaMetersequals20 = 16802,
        ForAreaMetersequals40 = 16803,
        ForAreaMetersequals60 = 16804,
        ForAreaMetersequals80 = 16805,
        ForAreaMetersequals100 = 16806,
        ForAreaMetersbetween101And250 = 16807,
        ForAreaMetersBetween251And500 = 16808,
        ForAreaMetersBetween501And1000 = 16809,
        ForAreaMetersGreaterThan1000 = 16810,

        IndustryStart = 11200,
        IndustryAirport = 11201,
        IndustryLandfill = 11202,
        IndustryWaste = 11203,
        IndustryStorageTank = 11204,
        IndustryBuildings = 11205,

        INDCountNumberStart = 17200,
        INDCountNumberEqualTo1 = 17201,
        INDCountNumberEqualTo2 = 17202,
        INDCountNumberEqualTo3 = 17203,
        INDCountNumberEqualTo4 = 17204,
        INDCountNumberEqualTo5 = 17205,
        INDCountNumberEqualTo6 = 17206,
        INDCountNumberEqualTo7 = 17207,
        INDCountNumberEqualTo8 = 17208,
        INDCountNumberEqualTo9 = 17209,
        INDCountNumberEqualTo10 = 17210,
        INDCountNumberBetween10and25 = 17211,
        INDCountNumberBetween25and40 = 17212,
        INDCountNumberGreaterThan40 = 17213,

        TypeOfFishStart = 11300,
        FishShellfish = 11301,
        FishFinfish = 11302,
        FishLobster = 11303,
        FishFishMeal = 11304,

        FishOperationStart = 21700,
        FishProcessing = 21701,
        FishHeldAlive = 21702,
        FishPackaging = 21703,
        FishingRearing = 21704,

        BuildingFishSingleStart = 19500,
        BuildingFishHatcherySingle = 19501,
        BuildingFishTanksSingle = 19502,
        BuildingFishPondsSingle = 19503,
        BuildingFishWarehouseSingle = 19504,
        BuildingFishCommercialSingle = 19505,

        BuildingFishStart = 12900,
        BuildingFishHatchery = 12901,
        BuildingFishInsideTanks = 12902,
        BuildingFishPounds = 12903,
        BuildingFishWarehouse = 12904,
        BuildingFishCommercial = 12905,

        FISCountNumberStart = 17400,
        FISCountNumberEqualTo1 = 17401,
        FISCountNumberEqualTo2 = 17402,
        FISCountNumberEqualTo3 = 17403,
        FISCountNumberEqualTo4 = 17404,
        FISCountNumberEqualTo5 = 17405,
        FISCountNumberEqualTo6 = 17406,
        FISCountNumberEqualTo7 = 17407,
        FISCountNumberEqualTo8 = 17408,
        FISCountNumberEqualTo9 = 17409,
        FISCountNumberEqualTo10 = 17410,
        FISCountNumberBetween10and25 = 17411,
        FISCountNumberBetween25and40 = 17412,
        FISCountNumberGreaterThan40 = 17413,

        MarineStructureStart = 11400,
        MarineWharf = 11401,
        MarineBuildings = 11402,
        MarineSeaWall = 11403,

        MarNumPresentStart = 20500,
        MarNumPresentEqual1 = 20501,
        MarNumPresentEqual2 = 20502,
        MarNumPresentEqual3 = 20503,
        MarNumPresentEqual4 = 20504,
        MarNumPresentEqual5 = 20505,
        MarNumPresentEqual6 = 20506,
        MarNumPresentEqual7 = 20507,
        MarNumPresentEqual8 = 20508,
        MarNumPresentEqual9 = 20509,
        MarNumPresentEqual10 = 20510,
        MarNumPresentBetween11and25 = 20511,
        MarNumPresentBetween25and40 = 20512,
        MarNumPresentGreaterThan40 = 20513,

        SeaWallSourceSingleStart = 20600,
        SeaWallSourceSingleCulvert = 20601,
        SeaWallSourceSinglePipe = 20602,

        SeaWallSourceStart = 20800,
        SeaWallSourceCulvert = 20801,
        SeaWallSourcePipe = 20802,

        WharfStart = 11500,
        WharfCommercialTransportation = 11501,
        WharfFishing = 11502,
        WharfPrivate = 11503,
        WharfMarina = 11504,
        WharfAbandoned = 11505,
        WharfBuildings = 11506,

        VesselStart = 17700,
        VesselCountEquals1 = 17701,
        VesselCountEquals2 = 17702,
        VesselCountEquals3 = 17703,
        VesselCountEquals4 = 17704,
        VesselCountEquals5 = 17705,
        VesselCountEquals6 = 17706,
        VesselCountEquals7 = 17707,
        VesselCountEquals8 = 17708,
        VesselCountEquals9 = 17709,
        VesselCountEquals10 = 17710,
        VesselCountBetwee11and25 = 17711,
        VesselCountBetween26and50 = 17712,
        VesselCountBetween51and100 = 17713,
        VesselCountGreaterThan100 = 17714,

        WharfTransportationSingleStart = 20700,
        TransportationCommericalSingle = 20701,
        TransportationFerrySingle = 20702,
        TransportationPleasureCraftSingle = 20703,

        WharfTransportationStart = 11600,
        TransportationCommerical = 11601,
        TransportationFerry = 11602,
        TransportationPleasureCraft = 11603,

        MarWhfWharfCountNumberStart = 17500,
        MarWhfCountNumberEqualTo1 = 17501,
        MarWhfCountNumberEqualTo2 = 17502,
        MarWhfCountNumberEqualTo3 = 17503,
        MarWhfCountNumberEqualTo4 = 17504,
        MarWhfCountNumberEqualTo5 = 17505,
        MarWhfCountNumberEqualTo6 = 17506,
        MarWhfCountNumberEqualTo7 = 17507,
        MarWhfCountNumberEqualTo8 = 17508,
        MarWhfCountNumberEqualTo9 = 17509,
        MarWhfCountNumberEqualTo10 = 17510,
        MarWhfCountNumberBetween11and25 = 17511,
        MarWhfCountNumberBetween26and40 = 17512,
        MarWhfCountNumberGreaterThan40 = 17513,

        MarBldCountNumberStart = 17600,
        MarBldCountNumberEqualTo1 = 17601,
        MarBldCountNumberEqualTo2 = 17602,
        MarBldCountNumberEqualTo3 = 17603,
        MarBldCountNumberEqualTo4 = 17604,
        MarBldCountNumberEqualTo5 = 17605,
        MarBldCountNumberEqualTo6 = 17606,
        MarBldCountNumberEqualTo7 = 17607,
        MarBldCountNumberEqualTo8 = 17608,
        MarBldCountNumberEqualTo9 = 17609,
        MarBldCountNumberEqualTo10 = 17610,
        MarBldCountNumberBetween11and25 = 17611,

        MARBuildingAllSingleStart = 20900,
        MARBuildingAllCottageSingle = 20901,
        MARBuildingAllTrailerSingle = 20902,
        MARBuildingAllResidentialSingle = 20903,
        MARBuildingAllWarehouseSingle = 20904,
        MARBuildingAllHotelMotelSingle = 20905,
        MARBuildingAllCommericalSingle = 20906,
        MARBuildingAllSchoolSingle = 20907,
        MARBuildingAllChurchSingle = 20908,
        MARBuildingAllmedicalFacilitySingle = 20909,

        MARBuildingAllStart = 17800,
        MARBuildingAllCottage = 17801,
        MARBuildingAllTrailer = 17802,
        MARBuildingAllResidential = 17803,
        MARBuildingAllWarehouse = 17804,
        MARBuildingAllHotelMotel = 17805,
        MARBuildingAllCommerical = 17806,
        MARBuildingAllSchool = 17807,
        MARBuildingAllChurch = 17808,
        MARBuildingAllmedicalFacility = 17809,

        RecreationStart = 11700,
        RecreationCampground = 11701,
        RecreationDayUseArea = 11702,
        RecreationSwimmingArea = 11703,
        RecreationRecreationaltArea = 11704,
        RecreationCommunityCentre = 11705,
        RecreationGolfCourse = 11706,

        RECCountNumberStart = 17900,
        RECcampgrdLotsapprox10 = 17901,
        RECcampgrdLotsapprox30 = 17902,
        RECcampgrdLotsapprox50 = 17903,
        RECcampgrdLotsapprox100 = 17904,
        RECcampgrdLotsapprox200 = 17905,
        RECcampgrdLotsapprox300 = 17906,
        RECcampgrdLotsapprox500 = 17907,

        RecTypeStart = 18100,
        RecTrailer = 18101,
        RecTents = 18102,
        RecTrailersandTents = 18103,

        CampgroundFacilitiesStart = 11800,
        CampgroundNoDumpStn = 11801,
        CampgroundwithDumpStn = 11802,

        RECFecalSourceStart = 18200,
        RecFecalSourcePeople = 18201,
        RecFecalSourceWildlife = 18203,
        RecFecalSourceDrainagewater = 18204,
        RecFecalSourcePets = 18205,

        RecSewageStart = 18300,
        RecSewageCesspool = 18301,
        RecSewagePrivyOuthouse = 18302,
        RecSewageMunicipalSystem = 18304,
        RecSepticSystemDrainageField = 18305,
        RecSepticSystemLagoon = 18306,
        RecSepticSystemConstructedWetland = 18307,
        RecSepticFreeFlow = 18308,

        RecNumPresentStart = 13600,
        RecNumPresentEqualTo1 = 13601,
        RecNumPresentEqualTo2 = 13602,
        RecNumPresentEqualTo3 = 13603,
        RecNumPresentEqualTo4 = 13604,
        RecNumPresentEqualTo5 = 13605,
        RecNumPresentEqualTo6 = 13606,
        RecNumPresentEqualTo7 = 13607,
        RecNumPresentEqualTo8 = 13608,
        RecNumPresentEqualTo9 = 13609,
        RecNumPresentEqualTo10 = 13610,
        RecNumPresentBetween11and25 = 13611,
        RecNumPresentBetween26and40 = 13612,
        RecNumPresentGreaterThan40 = 13613,

        SewageStart = 11900,
        SewageDirectDischarge = 11901,
        SewageFlowStructure = 11902,
        SewagePrivyOuthouse = 11903,
        SepticSystemLeachateField = 11904,
        SepticSystemFullRention = 11905,
        SewageCesspool = 11906,
        SepticSystemLagoon = 11907,
        SewageSystemConstructedWetland = 11908,
        SewageMunicipalSystem = 11909,
        SepticNoStructure = 11910,

        SeeMunicipalityInfrastructureStart = 12000,

        UrbanStart = 12100,
        UrbanStormWater = 12101,
        UrbanSurfaceRunoff = 12102,
        UrbanDumpStation = 12103,

        WildlifeStart = 12200,
        WildlifeBirds = 12201,
        WildlifeLandMammals = 12202,
        WildlifeMarineMammals = 12203,

        MunicipalSystemStart = 12300,
        MuncipialSystemConnected = 12301,
        MunicipalSystemNotConnected = 12302,

        StorageTankStart = 12400,
        StorageTankFuel = 12401,
        StorageTankPropane = 12402,
        StorageTankChemicals = 12403,

        TankSizeStart = 12500,
        TankSize100 = 12501,
        TankSize500 = 12502,
        TankSize1000 = 12503,
        TankSize2000plus = 12504,

        BuildingAgricultureSingleStart = 12600,
        BuildingResidentialFarmSingle = 12601,
        BuildingWarehouseFarmSingle = 12602,
        BuildingCommericalFarmSingle = 12603,
        BuildingBarnFarmSingle = 12604,
        BuildingRecreationalFarmSingle = 12605,
        BuildingSchoolFarmSingle = 12606,
        BuildingChurchFarmSingle = 12607,
        BuildingMedicalFacilityFarmSingle = 12608,

        BuildingAgricultureStart = 21000,
        BuildingResidentialFarm = 21001,
        BuildingWarehouseFarm = 21002,
        BuildingCommericalFarm = 21003,
        BuildingBarnFarm = 21004,
        BuildingRecreationalFarm = 21005,
        BuildingSchoolFarm = 21006,
        BuildingChurchFarm = 21007,
        BuildingMedicalFacilityFarm = 21008,

        AGRCountNumberStart = 16900,
        AGRCountNumberEqualTo1 = 16901,
        AGRCountNumberEqualTo2 = 16902,
        AGRCountNumberEqualTo3 = 16903,
        AGRCountNumberEqualTo4 = 16904,
        AGRCountNumberEqualTo5 = 16905,
        AGRCountNumberEqualTo6 = 16906,
        AGRCountNumberEqualTo7 = 16907,
        AGRCountNumberEqualTo8 = 16908,
        AGRCountNumberEqualTo9 = 16909,
        AGRCountNumberEqualTo10 = 16910,
        AGRCountNumberBetween11and25 = 16911,
        AGRCountNumberBetween26and40 = 16912,
        AGRCountNumberGreaterThan40 = 16913,

        FORCountNumberStart = 17300,
        FORCountNumberEqualTo1 = 17301,
        FORCountNumberEqualTo2 = 17302,
        FORCountNumberEqualTo3 = 17303,
        FORCountNumberEqualTo4 = 17304,
        FORCountNumberEqualTo5 = 17305,
        FORCountNumberEqualTo6 = 17306,
        FORCountNumberEqualTo7 = 17307,
        FORCountNumberEqualTo8 = 17308,
        FORCountNumberEqualTo9 = 17309,
        FORCountNumberEqualTo10 = 17310,
        FORCountNumberBetween11and25 = 17311,
        FORCountNumberBetween26and40 = 17312,
        FORCountNumberGreaterThan40 = 17313,

        BuildingForestedSingleStart = 12700,
        BuildingForestedResidentialSingle = 12701,
        BuildingForestedWarehouseSingle = 12702,
        BuildingForestedRecreationalSingle = 12703,
        BuildingForestedTrailerSingle = 12704,
        BuildingForestedFactorySingle = 12705,
        BuildingForestedCommericalSingle = 12706,
        BuildingForestedSchoolSingle = 12707,
        BuildingForestedChurchSingle = 12708,
        BuildingForestedMedicalFacilitySingle = 12709,

        BuildingForestedStart = 21100,
        BuildingForestedResidential = 21101,
        BuildingForestedWarehouse = 21102,
        BuildingForestedRecreational = 21103,
        BuildingForestedTrailer = 21104,
        BuildingForestedFactory = 21105,
        BuildingForestedCommerical = 21106,
        BuildingForestedSchool = 21107,
        BuildingForestedChurch = 21108,
        BuildingForestedMedicalFacility = 21109,

        BuildingTypeSingleStart = 12800,
        BuildingindustryWarehouseSingle = 12801,
        BuildingIndustryFactorySingle = 12802,
        BuildingIndustryCommericalSingle = 12803,
        BuildingIndustrySchoolSingle = 12804,
        BuildingIndustryChurchSingle = 12805,
        BuildingIndustryMedicalFacilitySingle = 12806,

        BuildingTypeStart = 21200,
        BuildingindustryWarehouse = 21201,
        BuildingIndustryFactory = 21202,
        BuildingIndustryCommerical = 21203,
        BuildingIndustrySchool = 21204,
        BuildingIndustryChurch = 21205,
        BuildingIndustryMedicalFacility = 21206,

        BuildingAllSingleStart = 13000,
        BuildingAllCottageSingle = 13001,
        BuildingAllTrailerSingle = 13002,
        BuildingAllResidentialSingle = 13003,
        BuildingAllWarehouseSingle = 13004,
        BuildingAllHotelMotelSingle = 13005,
        BuildingAllCommericalSingle = 13006,
        BuildingAllSchoolSingle = 13007,
        BuildingAllChurchSingle = 13008,
        BuildingAllmedicalFacilitySingle = 13009,

        BuildingAllStart = 21300,
        BuildingAllCottage = 21301,
        BuildingAllTrailer = 21302,
        BuildingAllResidential = 21303,
        BuildingAllWarehouse = 21304,
        BuildingAllHotelMotel = 21305,
        BuildingAllCommerical = 21306,
        BuildingAllSchool = 21307,
        BuildingAllChurch = 21308,
        BuildingAllmedicalFacility = 21309,

        CountNumberStart = 13100,
        CountNumberEqualTo1 = 13101,
        CountNumberEqualTo2 = 13102,
        CountNumberEqualTo3 = 13103,
        CountNumberEqualTo4 = 13104,
        CountNumberEqualTo5 = 13105,
        CountNumberEqualTo6 = 13106,
        CountNumberEqualTo7 = 13107,
        CountNumberEqualTo8 = 13108,
        CountNumberEqualTo9 = 13109,
        CountNumberEqualTo10 = 13110,
        CountNumberBetween11and25 = 13111,
        CountNumberBetween26and40 = 13112,
        CountNumberGreaterThan40 = 13113,

        AreaSizeStart = 13200,
        AreaMetersEquals5 = 13201,
        AreaMetersEquals10 = 13202,
        AreaMetersEquals20 = 13203,
        AreaMetersEquals40 = 13204,
        AreaMetersEquals60 = 13205,
        AreaMetersEquals80 = 13206,
        AreaMetersEquals100 = 13207,
        AreaMetersBetween101And250 = 13208,
        AreaMetersBetween251And500 = 13209,
        AreaMetersBetween501And1000 = 13210,
        AreaMetersgreaterThan1000 = 13211,

        FecalSourceStart = 13300,
        FecalSourcePeople = 13301,
        FecalSourcePets = 13302,
        FecalSourceWildlife = 13303,
        FecalSourceLivestock = 13304,
        FecalSourceDrainagewater = 13305,
        FecalProcessWater = 13306,
        FecalPotentialContamination = 13307,
        FecalSourceAbsent = 13308,

        MajorIssueSourceStart = 13400,
        MajorIssueSourceManurePile = 13401,
        MajorIssueAbsent1 = 13402,
        MajorIssueCollectedRunoff = 13403,
        MajorIssueSurfaceRunoff = 13404,

        LandfillTypeStart = 13500,
        LandfillTypeResidental = 13501,
        LandfillTypeIndustrial = 13502,
        LandfillTypeWoodwaste = 13503,

        TypesOfLivestockStart = 13700,
        TypesEqualHorses = 13701,
        TypesEqualCows = 13702,
        TypesEqualSheep = 13703,
        TypesEqualPigs = 13704,
        TypesEqualDomesticMixtureLarge = 13705,
        TypesEqualChickens = 13706,
        TypesEqualTurkeys = 13707,
        TypesEqualDucks = 13708,
        TypesEqualGeese = 13709,
        TypesEqualDomesticMixtureSmall = 13710,
        TypesEqualFurFarms = 13711,

        TypesOfWildlifeStart = 13800,
        TypesEqualSmallWildAnimals = 13801,
        TypesEqualLargeWildAnimals = 13802,
        TypesEquallandBirds = 13804,
        TypesEqualMarinebirdsSeals = 13805,

        TypesLandBIrdsStart = 21800,
        TypesLandBirdsCrows = 21801,
        TypesLandBirdsEagle = 21802,

        TypesLargeWildAnimalsStart = 21900,
        TypesLargeWildAnimalsMoose = 21901,
        TypesLargeWildAnimalsDeer = 21902,
        TypesLargeWildAnimalsCoyote = 21903,

        TypesSmallWildAnimalsStart = 22000,
        TypesSmallWildAnimalsFoxes = 22001,
        TypesSmallWildAnimalsGroundHogs = 22002,
        TypesSmallWildAnimalsSkunks = 22003,

        AnimalNumberPresentStart = 13900,
        NumberAnimalPresentapprox2 = 13901,
        NumberAnimalPresentapprox5 = 13902,
        NumberAnimalPresentapprox10 = 13903,
        NumberAnimalPresentapprox15 = 13904,
        NumberAnimalPresentapprox25 = 13905,
        NumberAnimalPresentapprox50 = 13906,
        NumberAnimalPresentapprox100 = 13907,
        NumberAnimalPresentapprox500 = 13908,
        NumberAnimalPresentapprox1000 = 13909,
        NumberAnimalPresentapprox5000 = 13910,
        NumberAnimalPresentGreaterThan10000 = 13911,
        NumberAnimalPresentGreaterThan20000 = 13912,

        WasteSourceStart = 20300,
        WasteSourceTypeLandCulvert = 20301,
        WasteSourceTypeLandPipe = 20302,
        WasteSourceTypeLandWaterCourse = 20303,
        WasteSourceTypeLandDitch = 20304,
        WasteSourceTypeLandDrainage = 20305,
        WasteSourceTypeDirectInputToMarine = 20306,
        WasteSourceTypetoField = 20307,

        FieldLocationStart = 20400,
        FieldLocationOnFarm = 20401,
        FieldLocationOffFarm = 20402,

        PointSourceWildlifeStart = 16600,
        SourceDirectInputToMarine = 16601,

        BoatStart = 14000,
        BoatCountEquals1 = 14001,
        BoatCountEquals2 = 14002,
        BoatCountEquals3 = 14003,
        BoatCountEquals4 = 14004,
        BoatCountEquals5 = 14005,
        BoatCountEquals6 = 14006,
        BoatCountEquals7 = 14007,
        BoatCountEquals8 = 14008,
        BoatCountEquals9 = 14009,
        BoatCountEquals10 = 14010,
        BoatCountBetween11to25 = 14011,
        BoatCountBetween26to50 = 14012,
        BoatCountBetween51to75 = 14013,
        BoatCountBetween76to100 = 14014,
        BoatCountGreaterThan100 = 14015,
        BoatCountGreaterThan150 = 14016,
        BoatCountGreaterThan250 = 14017,

        OilDumpingFacilityStart = 14100,
        OilDumpingFacilityPresent = 14101,
        OilDumpingFacilityAbsent = 14102,
        OilDumpingFacilityNotObserved = 14103,

        SewageDumpingStationStart = 14200,
        SewageDumpingStationPresent = 14201,
        SewageDumpingStationAbsent = 14202,
        SewageDumpingStationNotObserved = 14203,

        PointCountNumberStart = 21600,
        PointCountNumberEqualTo1 = 21601,
        PointCountNumberEqualTo2 = 21602,
        PointCountNumberEqualTo3 = 21603,
        PointCountNumberEqualTo4 = 21604,
        PointCountNumberEqualTo5 = 21605,
        PointCountNumberEqualTo6 = 21606,
        PointCountNumberEqualTo7 = 21607,
        PointCountNumberEqualTo8 = 21608,
        PointCountNumberEqualTo9 = 21609,
        PointCountNumberEqualTo10 = 21610,
        PointCountNumberBetween11and25 = 21611,
        PointCountNumberBetween26and40 = 21612,
        PointCountNumberGreaterThan40 = 21613,

        PointSourceSingleStart = 14300,
        SourceTypeLandCulvertSingle = 14301,
        SourceTypeLandPipeSingle = 14302,
        SourceTypeLandWaterCourseSingle = 14303,
        SourceTypeLandDitchSingle = 14304,
        SourceTypeLandDrainageSingle = 14305,

        PointSourceStart = 21400,
        SourceTypeLandCulvert = 21401,
        SourceTypeLandPipe = 21402,
        SourceTypeLandWaterCourse = 21403,
        SourceTypeLandDitch = 21404,
        SourceTypeLandDrainage = 21405,
        SourceTypeDirectInputToMarine = 21406,

        PointSourceManureStart = 14400,
        SourceManureLandDrainage = 14401,
        SourceManureDitch = 14402,

        DiameterInCentimetersStart = 14500,
        DiameterInCentimetersLessThan30 = 14501,
        DiameterInCentimetersBetween31and50cm = 14502,
        DiameterInCentimetersBetween51and100cm = 14503,
        DiameterInCentimetersBetween101and200cm = 14504,
        DiameterInCentimetersBetween201and300cm = 14505,
        DiameterInCentimetersBetween301and400cm = 14506,
        DiameterInCentimetersBetween401and500cm = 14507,
        DiameterInCentimetersGreaterThan500cm = 14508,
        DiameterNoInformation = 14509,

        FlowLevelStart = 14600,
        FlowLevelHigh = 14601,
        FlowLevelMedium = 14602,
        FlowLevelLow = 14603,

        OuthouseStart = 14700,
        OuthouseCementHoldingTank = 14701,
        OuthouseSittingOnGround = 14702,

        WidthInMetersStart = 14800,
        WidthInMetersApprox1 = 14801,
        WidthInMetersApprox2 = 14802,
        WidthInMetersApprox3 = 14803,
        WidthInMetersApprox4 = 14804,
        WidthInMetersApprox5 = 14805,
        WidthInMetersApprox6 = 14806,
        WidthInMetersApprox7 = 14807,
        WidthInMetersApprox8 = 14808,
        WidthInMetersApprox9 = 14809,
        WidthInMetersApprox10 = 14810,
        WidthInMetersBetween11And25 = 14811,
        WidthInMetersBetween26And40 = 14812,
        WidthInMetersGreaterThan40 = 14813,

        DitchStart = 14900,
        DitchAlongRoad = 14901,
        DitchBetweenAcrossProperties = 14902,
        DitchDirectlytoWater = 14903,

        DrainageStart = 15000,
        DrainagePavedSurfaces = 15001,
        DrainageVegetatedSurfaces = 15002,
        DrainageDirect = 15003,
        DrainageBareSoilSurfaces = 15004,

        ManureAreaSizeStart = 15100,
        ManureAreaMetersapproximately10 = 15101,
        ManureAreaMetersapproximately20 = 15102,
        ManureAreaMetersapproximately30 = 15103,
        ManureAreaMetersapproximately40 = 15104,
        ManureAreaMetersapproximately50 = 15105,
        ManureAreaMetersapproximately60 = 15106,
        ManureAreaMetersapproximately70 = 15107,
        ManureAreaMetersapproximately80 = 15108,
        ManureAreaMetersapproximately90 = 15109,
        ManureAreaMetersapproximately100 = 15110,
        ManureAreaMetersMoreThan100 = 15111,

        SourceTypeWaterStart = 15200,
        SourceTypeWaterAquacultureSite = 15201,
        SourceTypeWaterAnchorageMooringSite = 15202,
        SourceTypeWaterDisposalAtSea = 15203,
        SourceTypeWaterMarinePark = 15204,
        SourceLandOutcrop = 15205,

        AquacultureSiteStart = 19100,
        AquacultureSite = 19101,

        AnchorageMooringSiteStart = 19200,
        AnchorageMooringSite = 19201,

        DisposalAtSeaStart = 19300,
        DisposalAtSea = 19301,

        MarineParkStart = 19400,
        MarinePark = 19401,

        OutcropStart = 19600,
        OutcropSandBar = 19601,
        OutcropRock = 19602,
        OutcropIsland = 19603,

        WaterAquacultureStart = 18900,
        WaterAquacultureSiteActive = 18901,
        WaterAquacultureSiteFallow = 18902,

        WatAquaCountNumberStart = 18400,
        WatAquaCountNumberEqualTo1 = 18401,
        WatAquaCountNumberEqualTo2 = 18402,
        WatAquaCountNumberEqualTo3 = 18403,
        WatAquaCountNumberEqualTo4 = 18404,
        WatAquaCountNumberEqualTo5 = 18405,
        WatAquaCountNumberEqualTo6 = 18406,
        WatAquaCountNumberEqualTo7 = 18407,
        WatAquaCountNumberEqualTo8 = 18408,
        WatAquaCountNumberEqualTo9 = 18409,
        WatAquaCountNumberEqualTo10 = 18410,
        WatAquaCountNumberBetween11and25 = 18411,
        WatAquaCountNumberBetween26and40 = 18412,
        WatAquaCountNumberGreaterThan40 = 18413,

        WaterAquacultureTypeSingleStart = 15400,
        AquacultureCagesSingle = 15401,
        AquacultureFloatingBagsSingle = 15402,
        AquacultureSubmergedLinesSingle = 15403,
        AquacultureLosterPoundCageSingle = 15404,
        AquacultureBargesSingle = 15405,

        WaterAquacultureTypeStart = 18800,
        AquacultureCages = 18801,
        AquacultureFloatingBags = 18802,
        AquacultureSubmergedLines = 18803,
        AquacultureLosterPoundCage = 18804,
        AquacultureBarges = 18805,

        WatStructActiveStart = 15300,
        WatStructActive = 15301,
        WatStructInactive = 15302,

        WaterStructureSiteSingleStart = 15500,
        WaterStructureVesselSingle = 15501,
        WaterStructureBargeSingle = 15502,
        WaterStructureResidentalSingle = 15503,
        WaterStructureCommercialSingle = 15504,
        WaterStructureNotActiveSingle = 15505,

        WaterStructureSiteStart = 21500,
        WaterStructureVessel = 21501,
        WaterStructureBarge = 21502,
        WaterStructureResidental = 21503,
        WaterStructureCommercial = 21504,
        WaterStructureNotActive = 21505,

        WatStructCountNumberStart = 18500,
        WatStructCountNumberEqualTo1 = 18501,
        WatStructCountNumberEqualTo2 = 18502,
        WatStructCountNumberEqualTo3 = 18503,
        WatStructCountNumberEqualTo4 = 18504,
        WatStructCountNumberEqualTo5 = 18505,
        WatStructCountNumberEqualTo6 = 18506,
        WatStructCountNumberEqualTo7 = 18507,
        WatStructCountNumberEqualTo8 = 18508,
        WatStructCountNumberEqualTo9 = 18509,
        WatStructCountNumberEqualTo10 = 18510,
        WatStructCountNumberBetween11and25 = 18511,
        WatStructCountNumberBetween26and40 = 18512,
        WatStructCountNumberGreaterThan40 = 18513,

        WaterDisposalAtSeaStart = 15600,
        WaterDumpSiteActive = 15601,
        WaterDumpSiteNotActive = 15602,

        WaterSeaportStart = 15700,
        SeaportRecreational = 15701,
        SeaportCommercial = 15702,

        WaterSizeStart = 15800,
        WaterSizeMetersEqual5 = 15801,
        WaterSizeMetersEqual10 = 15802,
        WaterSizeMetersEqual20 = 15803,
        WaterSizeMetersEqual40 = 15804,
        WaterSizeMetersEqual60 = 15805,
        WaterSizeMetersEqual80 = 15806,
        WaterSizeMetersEqual100 = 15807,
        WaterSizeMetersEqual150 = 15808,
        WaterSizeMetersEqual200 = 15809,
        WaterSizeMetersEqual250 = 15810,
        WaterSizeMetersEqual300 = 15811,
        WaterSizeMetersEqual400 = 15812,
        WaterSizeMetersEqual500 = 15813,
        WaterSizeMetersEqual750 = 15814,
        WaterSizeMetersEqual1000 = 15815,
        WaterSizeMetersGreaterThan1000 = 15816,

        DistanceOnWaterMetersStart = 10300,
        DistanceOnWaterMetersEqual5 = 10301,
        DistanceOnWaterMetersEqual10 = 10302,
        DistanceOnWaterMetersEqual20 = 10303,
        DistanceOnWaterMetersEqual30 = 10304,
        DistanceOnWaterMetersEqual40 = 10305,
        DistanceOnWaterMetersEqual50 = 10306,
        DistanceOnWaterMetersEqual75 = 10307,
        DistanceOnWaterMetersEqual100 = 10308,
        DistanceOnWaterMetersEqual150 = 10309,
        DistanceOnWaterMetersEqual200 = 10310,
        DistanceOnWaterMetersEqual300 = 10311,
        DistanceOnWaterMetersEqual400 = 10312,
        DistanceOnWaterMetersEqual600 = 10313,
        DistanceOnWaterMetersEqual800 = 10314,
        DistanceOnWaterMetersEqual1000 = 10315,
        DistanceOnWaterMetersGreaterThan1000 = 10316,

        WaterTypeStart = 15900,
        WaterTypeSalt = 15901,
        WaterTypeBrachish = 15902,
        WaterTypeFresh = 15903,

        WaterFecalSourceStart = 16100,
        WaterFecalSourcePeople = 16101,
        WaterFecalSourceWildlife = 16102,
        WaterFecalSourceAbsent = 16103,
        WaterFecalProcessWater = 16104,

        WaterCountNumberStart = 16200,
        WatCountNumberEqualTo1 = 16201,
        WatCountNumberEqualTo2 = 16202,
        WatCountNumberEqualTo3 = 16203,
        WatCountNumberEqualTo4 = 16204,
        WatCountNumberEqualTo5 = 16205,
        WatCountNumberEqualTo6 = 16206,
        WatCountNumberEqualTo7 = 16207,
        WatCountNumberEqualTo8 = 16208,
        WatCountNumberEqualTo9 = 16209,
        WatCountNumberEqualTo10 = 16210,
        WatCountNumberBetween11and25 = 16211,
        WatCountNumberBetween26and40 = 16212,
        WatCountNumberGreaterThan40 = 16213,

        HumanSewageStart = 18700,
        HumanSewageWashroom = 18701,
        HumanSewageWashroomAbsent = 18702,

        WaterSewageStart = 16300,
        WaterSewageDirectDischarge = 16301,
        WaterSepticSystemFullRention = 16302,

        WaterNumberPresentStart = 16400,
        WatNumberPresentEqualTo1 = 16401,
        WatNumberPresentEqualTo2 = 16402,
        WatNumberPresentEqualTo3 = 16403,
        WatNumberPresentEqualTo4 = 16404,
        WatNumberPresentEqualTo5 = 16405,
        WatNumberPresentEqualTo6 = 16406,
        WatNumberPresentEqualTo7 = 16407,
        WatNumberPresentEqualTo8 = 16408,
        WatNumberPresentEqualTo9 = 16409,
        WatNumberPresentEqualTo10 = 16410,
        WatNumberPresentBetween11and25 = 16411,
        WatNumberPresentBetween26and40 = 16412,
        WatNumberPresentGreaterThan40 = 16413,

        WaterTypesOfMarineLifeStart = 16500,
        WaterTypesEqualSmallMammals = 16501,
        WaterTypesEqualLargeMammals = 16502,
        WaterTypesEqualSeaBirds = 16503,
        WaterTypesEqualShorelineBirds = 16504,

        ShorelineBirdsStart = 19700,
        ShorelineBirdsPloversandSandpipers = 19701,
        ShorelineBirdsBlackBackedGulls = 19702,
        ShorelineBirdsHerringGulls = 19703,
        ShorelineBirdsGreaterYellowlegs = 19704,
        ShorelineBirdsSurfScoter = 19705,
        ShorelineBirdsBrownPelican = 19706,
        ShorelineBirdsOthers = 19707,

        SeaBirdsStart = 19800,
        SeaBirdsCormorants = 19801,
        SeaBirdsDucks = 19802,
        SeaBirdsGeese = 19803,
        SeaBirdsBlackBlackGulls = 19804,
        SeaBirdsLoons = 19805,
        SeaBirdsSeaducks = 19806,
        SeaBirdsOther = 19807,

        LargeMarineMammalStart = 19900,
        LargeMarineMammaGreySeal = 19901,
        LargeMarineMammalHoodedSeal = 19902,
        LargeMarineMammalBeardSeal = 19903,
        LargeMarineMammalStellarSeaLion = 19904,
        LargeMarineMammalAtlanticWalrus = 19905,
        LargeMarineMammalNorthernFurSeal = 19906,

        SmallMarineanimalStart = 20000,
        SmallMarineanimalHarpSeal = 20001,
        SmallMarineanimalHarbourSeal = 20002,
        SmallMarineanimalSeaOtter = 20003,

        MarineAnimalPresentStart = 20100,
        MarineAnimalPresentLessThan5 = 20101,
        MarineAnimalPresentBetween6and10 = 20102,
        MarineAnimalPresentBetween11and25 = 20103,
        MarineAnimalPresentBetween26and100 = 20104,
        MarineAnimalPresentGreaterThan100 = 20105,
        MarineAnimalPresentGreaterThan500 = 20106,
        MarineAnimalPresentGreaterThan1000 = 20107,
        MarineAnimalPresentGreaterThan10000 = 20108,
        MarineAnimalPresentGreaterThan20000 = 20109,

        MarinePointSourceStart = 20200,
        MarinePointSourceInputToMarine = 20201,

        ShorelineStart = 17000,
        ShorelineSandy = 17001,
        ShorelineRocky = 17002,

        ShorelineIssueStart = 17100,
        ShorelineBuildings = 17101,
        ShorelineWildlife = 17102,
        ShorelineLandFill = 17103,
        ShorelineSlipway = 17104,
        ShorelineDayuse = 17105,

        SlipwayStart = 18000,
        SlipwayPaved = 18001,
        SlipwayRocks = 18002,

        SourceTypeShoreStart = 19000,
        SourceTypeShoreline = 19001,

        StatusStart = 90000,
        StatusDefinite = 90001,
        StatusPotential = 90002,
        StatusNonPollutionSource = 90003,

        RiskStart = 91000,
        RiskLow = 91001,
        RiskModerate = 91002,
        RiskHighP = 91003,
        RiskHighConfirmedVisual = 91004,
        RishHighConfirmedWater = 91005,

        FollowupStart = 92000,
        FollowupRequired = 92001,
        FollowupNotRequired = 92002,
    }
}
