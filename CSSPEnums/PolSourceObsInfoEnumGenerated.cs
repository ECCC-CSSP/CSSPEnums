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

        SourceStart = 10100,
        SourceHuman = 10101,
        SourceAnimal = 10102,
        SourceIndustrial = 10103,

        HumanPollutionSingleStart = 12600,
        HumanPollutionSingleResidential = 12601,
        HumanPollutionSingleCottage = 12602,
        HumanPollutionSingleTrailer = 12603,
        HumanPollutionSingleWarehouse = 12604,
        HumanPollutionSingleCommerical = 12605,
        HumanPollutionSingleBarn = 12606,
        HumanPollutionSinglePublic = 12607,
        HumanPollutionSingleSchool = 12608,
        HumanPollutionSingleChurch = 12609,
        HumanPollutionSingleMedicalFacility = 12610,
        HumanPollutionSingleOuthouse = 12611,
        HumanPollutionSingleBoatOrBarge = 12612,

        HumanPollutionMultipleStart = 21000,
        HumanPollutionMultipleResidences = 21001,
        HumanPollutionMultipleCottages = 21002,
        HumanPollutionMultipleTrailers = 21003,
        HumanPollutionMultipleWarehouses = 21004,
        HumanPollutionMultipleCommericals = 21005,
        HumanPollutionMultipleBarns = 21006,
        HumanPollutionMultiplePublic = 21007,
        HumanPollutionMultipleSchools = 21008,
        HumanPollutionMultipleChurches = 21009,
        HumanPollutionMultipleMedicalFacilities = 21010,
        HumanPollutionMultipleOuthouses = 21011,
        HumanPollutionMultipleBoatsOrBarges = 21012,

        CountNumberStart = 16900,
        CountNumberEqualTo1 = 16901,
        CountNumberEqualTo2 = 16902,
        CountNumberEqualTo3 = 16903,
        CountNumberEqualTo4 = 16904,
        CountNumberEqualTo5 = 16905,
        CountNumberEqualTo6 = 16906,
        CountNumberEqualTo7 = 16907,
        CountNumberEqualTo8 = 16908,
        CountNumberEqualTo9 = 16909,
        CountNumberEqualTo10 = 16910,
        CountNumberBetween11and25 = 16911,
        CountNumberBetween26and40 = 16912,
        CountNumberGreaterThan40 = 16913,

        GeneralLocationStart = 12700,
        GeneralLocationRural = 12701,
        GeneralLocationUrban = 12702,
        GeneralLocationForested = 12703,
        GeneralLocationAgricultural = 12704,
        GeneralLocationFarm = 12705,
        GeneralLocationShoreline = 12706,
        GeneralLocationWharf = 12707,
        GeneralLocationBarge = 12708,
        GeneralLocationIsland = 12709,
        GeneralLocationRecreationalArea = 12710,
        GeneralLocationCottageLot = 12711,
        GeneralLocationWetland = 12712,
        GeneralLocationWaterCourse = 12713,
        GeneralLocationSandBar = 12714,
        GeneralLocationRock = 12715,
        GeneralLocationAquacultureSite = 12716,
        GeneralLocationOffShoreline = 12717,

        OuthouseStart = 14700,
        OuthouseConcreteTank = 14701,
        OuthouseOnGround = 14702,

        IndustrialEffluentStart = 11200,
        IndustrialEffluentForestry = 11201,
        IndustrialEffluentAgriculture = 11202,
        IndustrialEffluentFisheries = 11203,
        IndustrialEffluentShorelineStructures = 11204,
        IndustrialEffluentIndustrial = 11205,
        IndustrialEffluentStorageTank = 11206,
        IndustrialEffluentAirport = 11207,
        IndustrialEffluentLandfill = 11208,
        IndustrialEffluentUrbanRunoff = 11209,
        IndustrialEffluentRecreation = 11210,
        IndustrialEffluentAquacultureSite = 11211,
        IndustrialEffluentAnchorageMooringSite = 11212,
        IndustrialEffluentDisposalAtSea = 11213,
        IndustrialEffluentMarinePark = 11214,

        AreaSizeStart = 16800,
        AreaSizeMetersEquals10 = 16801,
        AreaSizeMetersEquals20 = 16802,
        AreaSizeMetersEquals40 = 16803,
        AreaSizeMetersEquals60 = 16804,
        AreaSizeMetersEquals80 = 16805,
        AreaSizeMetersEquals100 = 16806,
        AreaSizeMetersBetween101And250 = 16807,
        AreaSizeMetersBetween251And500 = 16808,
        AreaSizeMetersBetween501And1000 = 16809,
        AreaSizeMetersGreaterThan1000 = 16810,

        AgriculturalSourceStart = 10600,
        AgriculturalSourceCrop = 10601,
        AgricultureSourcePasture = 10602,
        AgriculturesourceFeedlot = 10603,
        AriculturalSourcePeatMoss = 10604,

        PastureStart = 10800,
        PastureActive = 10801,
        PastureActiveWithManurePIle = 10802,
        PastureFallow = 10803,

        FeedlotStart = 10900,
        FeedlotActive = 10901,
        FeedlotNotActive = 10902,

        FisheriesSourceStart = 11300,
        FisheriesSourceShellfish = 11301,
        FisheriesSourceFinfish = 11302,
        FisheriesSourceLobster = 11303,

        FishOperationStart = 21700,
        FishOperationProcessing = 21701,
        FishOperationHoldingTanks = 21702,
        FishOperationPackaging = 21703,
        FishOperationRearing = 21704,
        FishOperationFishMeal = 21705,

        FishBuildingTypeSingleStart = 19500,
        FishBuildingTypeSingleProcessingPlant = 19501,
        FishBuildingTypeSingleHatchery = 19502,
        FishBuildingTypeSinglePond = 19503,
        FishBuildingTypeSingleTank = 19504,
        FishBuildingTypeSinglePound = 19506,

        FishBuildingTypeMultipleStart = 12900,
        FishBuildingTypeMultipleProcessingPlants = 12901,
        FishBuildingTypeMultipleHatcheries = 12902,
        FishBuildingTypeMultiplePonds = 12903,
        FishBuildingTypeMultipleTanks = 12904,
        FishBuildingTypeMultiplePounds = 12905,

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

        ShorelineSourceStart = 11400,
        ShorelineSourceWharf = 11401,
        ShorelineSourceSeaWall = 11403,
        ShorelineSourceSlipway = 11404,

        SlipwayStart = 18000,
        SlipwayPaved = 18001,
        SlipwayRocks = 18002,

        WharfStart = 11500,
        WharfCommercialTransportation = 11501,
        WharfFishing = 11502,
        WharfPrivate = 11503,
        WharfMarina = 11504,
        WharfAbandoned = 11505,

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
        WharfTransportationCommericalSingle = 20701,
        WharfTransportationFerrySingle = 20702,
        WharfTransportationBoatSingle = 20703,
        WharfTransportationBargeSingle = 20704,

        WharfTransportationStart = 11600,
        WharfTransportationCommerical = 11601,
        WharfTransportationFerry = 11602,
        WharfTransportationPleasureCraft = 11603,
        WharfTransportationBarges = 11604,

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

        RecreationStart = 11700,
        RecreationCampground = 11701,
        RecreationDayUseArea = 11702,
        RecreationSwimmingArea = 11703,
        RecreationGolfCourse = 11704,

        RECCountNumberStart = 17900,
        RECCountNumber10 = 17901,
        RECCountNumber30 = 17902,
        RECCountNumber50 = 17903,
        RECCountNumber100 = 17904,
        RECCountNumber200 = 17905,
        RECCountNumber300 = 17906,
        RECCountNumber500 = 17907,

        CampgroundFacilitiesStart = 11800,
        CampgroundNoDumpStn = 11801,
        CampgroundWithDumpStn = 11802,

        UrbanStart = 12100,
        UrbanStormWater = 12101,
        UrbanDumpStation = 12102,

        TankSizeStart = 12500,
        TankSize400 = 12501,
        TankSize2000 = 12502,
        TankSize4000 = 12503,
        TankSize8000 = 12504,

        LandfillTypeStart = 13500,
        LandfillTypeResidental = 13501,
        LandfillTypeIndustrial = 13502,
        LandfillTypeWoodwaste = 13503,

        TypesOfLivestockStart = 13700,
        TypesOfLivestockHorses = 13701,
        TypesOfLivestockCows = 13702,
        TypesOfLivestockSheep = 13703,
        TypesOfLivestockPigs = 13704,
        TypesOfLivestockMixtureLarge = 13705,
        TypesOfLivestockChickens = 13706,
        TypesOfLivestockTurkeys = 13707,
        TypesOfLivestockDucks = 13708,
        TypesOfLivestockMixtureSmall = 13709,
        TypesOfLivestockFurFarms = 13710,

        TypesOfWildlifeStart = 13800,
        TypesOfWildlifeCrows = 13801,
        TypesOfWildlifeGulls = 13802,
        TypesOfWildlifeEagle = 13803,
        TypesOfWildlifeUngulate = 13804,
        TypesOfWildlifeCoyote = 13805,
        TypesOfWildlifeGeneral = 13806,
        TypesOfWildlifeBeaver = 13807,
        TypesOfWildlifeMuskrat = 13808,

        TypesOfAnimalStart = 10700,
        TypesOfAnimalLivestock = 10701,
        TypesOfAnimalWildlife = 10702,
        TypesOfAnimalMarine = 10703,

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
        OilDumpingFacilityNotApplicable = 14104,

        SewageDumpingStationStart = 14200,
        SewageDumpingStationPresent = 14201,
        SewageDumpingStationAbsent = 14202,
        SewageDumpingStationNotObserved = 14203,

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
        WaterAquacultureTypeSingleCages = 15401,
        WaterAquacultureTypeSingleFloatingBags = 15402,
        WaterAquacultureTypeSingleSubmergedLines = 15403,
        WaterAquacultureTypeSingleLosterPound = 15404,
        WaterAquacultureTypeSingleBarges = 15405,

        WaterAquacultureTypeStart = 18800,
        WaterAquacultureTypeCages = 18801,
        WaterAquacultureTypeFloatingBags = 18802,
        WaterAquacultureTypeSubmergedLines = 18803,
        WaterAquacultureTypeLosterPounds = 18804,
        WaterAquacultureTypeBarges = 18805,

        WaterTypesOfMarineLifeStart = 16500,
        WaterTypesOfMarineLifeShorelineBirds = 16501,
        WaterTypesOfMarineLifeGulls = 16502,
        WaterTypesOfMarineLifeCormorants = 16503,
        WaterTypesOfMarineLifeDucksGeese = 16504,
        WaterTypesOfMarineLifeLoons = 16505,
        WaterTypesOfMarineLifeSeaducks = 16506,
        WaterTypesOfMarineLifeOther = 16507,
        WaterTypesOfMarineLifeSeal = 16508,
        WaterTypesOfMarineLifeSeaOtter = 16509,

        MajorIssueSourceStart = 13400,
        MajorIssueSourceManurePile = 13401,
        MajorIssueSourceLiqSpread = 13402,

        FieldLocationStart = 20400,
        FieldLocationOnFarm = 20401,
        FieldLocationOffFarm = 20402,
        FieldLocationBoth = 20403,

        SourcesOfContaminantStart = 10500,
        SourcesOfContaminantRunoff = 10501,
        SourcesOfContaminantRunoffFromManure = 10502,
        SourcesOfContaminantProcessingWater = 10503,
        SourcesOfContaminantTankWater = 10504,
        SourcesOfContaminantWashrooms = 10505,
        SourcesOfContaminantEffluent = 10506,
        SourcesOfContaminantExcrement = 10507,

        SewageStart = 11900,
        SewageDirectDischarge = 11901,
        SewageThruConduit = 11902,
        SewageSepticSystemLeachateField = 11903,
        SewageRetentionTank = 11904,
        SewageOpenTank = 11905,
        SewageSystemConstructedWetland = 11906,
        SewageOnSiteSystem = 11907,
        SewageOffSiteSystem = 11908,
        SepticNoInformation = 11909,

        StatusStart = 90000,
        StatusDefinite = 90001,
        StatusPotential = 90002,
        StatusNonPollutionSource = 90003,

        PathWayStart = 25000,
        PathwayLand = 25001,
        PathWayWater = 25002,

        PathwaySourceFirstStart = 14300,
        PathwaySourceFirstCulvert = 14301,
        PathwaySourceFirstPipe = 14302,
        PathwaySourceFirstStream = 14303,
        PathwaySourceFirstDitch = 14304,
        PathwaySourceFirstSurfaceDrainage = 14305,
        PathwaySourceFirstSubSurfaceDrainage = 14306,
        PathwaySourceFirstDirect = 14307,

        PathwaySourceSecondPipeStart = 13000,
        PathwaySourceSecondPipeStream = 13001,
        PathwaySourceSecondPipeDitch = 13002,
        PathwaySourceSecondPipeSurfaceDrainage = 13003,
        PathwaySourceSecondPipeSubSurfaceDrainage = 13004,
        PathwaySourceSecondPipeDirect = 13005,

        PathwaySourceSecondCulvertStart = 13200,
        PathwaySourceSecondCulvertStream = 13201,
        PathwaySourceSecondCulvertDitch = 13202,
        PathwaySourceSecondCulvertSurfaceDrainage = 13203,
        PathwaySourceSecondCulvertSubSurfaceDrainage = 13204,
        PathwaySourceSecondCulvertDirectInput = 13205,

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

        DistanceToSaltWaterStart = 24000,
        DistanceToSaltWaterInMeters5 = 24001,
        DistanceToSaltWaterInMeters10 = 24002,
        DistancetoSaltWaterInMeters20 = 24003,
        DistanceToSaltWaterInMeters30 = 24004,
        DistanceToSaltWaterInMeters50 = 24005,
        DistanceToSaltWaterInMeters100 = 24006,
        DistanceToSaltWaterInMeters200 = 24007,
        DistanceToSaltWaterInMeters400 = 24008,
        DistanceToSaltWaterInMeters800 = 24009,
        DistanceToSaltWaterInMeters1000 = 24010,
        DistanceToSaltWaterInMetersGreaterThan1000 = 24011,

        AreaSlopeStart = 10400,
        AreaSlopeLow = 10401,
        AreaSlopeMedium = 10402,
        AreaSlopeHigh = 10403,
        AreaSlopeNA = 10404,

        MunicipalityDataStart = 12000,

        PipeCountNumberStart = 21600,
        PipeCountNumberEqualTo1 = 21601,
        PipeCountNumberEqualTo2 = 21602,
        PipeCountNumberEqualTo3 = 21603,
        PipeCountNumberEqualTo4 = 21604,
        PipeCountNumberEqualTo5 = 21605,
        PipeCountNumberEqualTo6 = 21606,
        PipeCountNumberEqualTo7 = 21607,
        PipeCountNumberEqualTo8 = 21608,
        PipeCountNumberEqualTo9 = 21609,
        PipeCountNumberEqualTo10 = 21610,

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

        DitchStart = 14900,
        DitchAlongRoad = 14901,
        DitchAcrossProperties = 14902,

        DrainageStart = 15000,
        DrainagePavedSurfaces = 15001,
        DrainageVegetatedSurfaces = 15002,
        DrainageBareSoilSurfaces = 15003,

        FlowLevelStart = 14600,
        FlowLevelHigh = 14601,
        FlowLevelMedium = 14602,
        FlowLevelLow = 14603,

        PipeFlowStart = 13300,
        PipeFlowlHigh = 13301,
        PipeFlowMedium = 13302,
        PipeFlowLow = 13303,

        PathwaySourceWaterStart = 20200,
        PathwaySourceWaterDirectToMarine = 20201,
        PathwaySourceWaterPipe = 20202,
        PathwaySourceWaterLandDisposal = 20203,

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
