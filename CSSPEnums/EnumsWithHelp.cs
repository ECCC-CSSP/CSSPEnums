using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.Net;

namespace CSSPEnums
{
    /// <summary>
    /// Class holding all Enum used in CSSP applications and methods used to get text associated with the Enum in both languages [en, fr]
    /// 
    /// Used by 
    /// * <c>[CSSPModels] (CSSPModels.html)</c>
    /// * <c>[CSSPServices] (CSSPServices.html)</c>
    /// </summary>
    public partial class Enums
    {
        #region Variables
        #endregion Variables

        #region Properties
        /// <summary>
        /// Allowable values are [en, fr]
        /// </summary>
        public LanguageEnum LanguageRequest { get; set; }
        #endregion Properties

        #region Constructors
        /// <summary>
        /// <para>**using [en]**</para>
        /// 
        /// <para> <c>CurrentCulture = new CultureInfo("en-CA");</c></para>
        /// 
        /// <para> <c>CurrentUICulture = new CultureInfo("en-CA");</c></para>
        /// 
        /// <para>**using [fr]**</para>
        /// 
        /// <para> <c>CurrentCulture = new CultureInfo("fr-CA");</c></para>
        /// 
        /// <para> <c>CurrentUICulture = new CultureInfo("fr-CA");</c></para>
        /// 
        /// </summary>
        /// <param name="LanguageRequest"></param>
        public Enums(LanguageEnum LanguageRequest)
        {
            this.LanguageRequest = LanguageRequest;
            if (this.LanguageRequest == LanguageEnum.fr)
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
        #endregion Construtors

    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum ActionDBTypeEnum
    ///     {
    ///         Error = 0,
    ///         Create = 1,
    ///         Read = 2,
    ///         Update = 3,
    ///         Delete = 4,
    ///     }
    /// </code>
    /// </remarks>
    public enum ActionDBTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Create] ---- fr [Créer]
        /// </summary>
        Create = 1,
        /// <summary>
        /// 2 -- en [Read] ---- fr [Lire]
        /// </summary>
        Read = 2,
        /// <summary>
        /// 3 -- en [Update] ---- fr [Mettre à jour]
        /// </summary>
        Update = 3,
        /// <summary>
        /// 4 -- en [Delete] ---- fr [Effacer]
        /// </summary>
        Delete = 4,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum AddressTypeEnum
    ///     {
    ///         Error = 0,
    ///         Mailing = 1,
    ///         Shipping = 2,
    ///         Civic = 3,
    ///     }
    /// </code>
    /// </remarks>
    public enum AddressTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Mailing] ---- fr [Postale]
        /// </summary>
        Mailing = 1,
        /// <summary>
        /// 2 -- en [Shipping] ---- fr [Livraison]
        /// </summary>
        Shipping = 2,
        /// <summary>
        /// 3 -- en [Civic] ---- fr [Civic (fr)]
        /// </summary>
        Civic = 3,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [Infrastructure.AerationType] (CSSPModels.Infrastructure.html#CSSPModels_Infrastructure_AerationType), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum AerationTypeEnum
    ///     {
    ///         Error = 0,
    ///         Diffuser = 1,
    ///         Surface = 2,
    ///     }
    /// </code>
    /// </remarks>
    public enum AerationTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Diffuser] ---- fr [Diffuser (fr)]
        /// </summary>
        Diffuser = 1,
        /// <summary>
        /// 2 -- en [Surface] ---- fr [Surface (fr)]
        /// </summary>
        Surface = 2,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [Infrastructure.AlarmSystemType] (CSSPModels.Infrastructure.html#CSSPModels_Infrastructure_AlarmSystemType), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum AlarmSystemTypeEnum
    ///     {
    ///         Error = 0,
    ///         SCADA = 1,
    ///         None = 2,
    ///         OnlyVisualLight = 3,
    ///         SCADAAndLight = 4,
    ///         PagerAndLight = 5,
    ///     }
    /// </code>
    /// </remarks>
    public enum AlarmSystemTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [SCADA] ---- fr [SCADA (fr)]
        /// </summary>
        SCADA = 1,
        /// <summary>
        /// 2 -- en [None] ---- fr [Aucun]
        /// </summary>
        None = 2,
        /// <summary>
        /// 3 -- en [Only Visual Light] ---- fr [Only Visual Light (fr)]
        /// </summary>
        OnlyVisualLight = 3,
        /// <summary>
        /// 4 -- en [SCADA And Light] ---- fr [SCADA And Light (fr)]
        /// </summary>
        SCADAAndLight = 4,
        /// <summary>
        /// 5 -- en [Pager And Light] ---- fr [Pager And Light (fr)]
        /// </summary>
        PagerAndLight = 5,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [MWQMRun.AnalyzeMethod] (CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_AnalyzeMethod), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum AnalyzeMethodEnum
    ///     {
    ///         Error = 0,
    ///         MF = 1,
    ///         ZZ_510Q = 2,
    ///         ZZ_509Q = 3,
    ///         ZZ_0 = 4,
    ///         ZZ_525Q = 5,
    ///         MPN = 6,
    ///         ZZ_0Q = 7,
    ///         AnalyzeMethod8 = 8,
    ///         AnalyzeMethod9 = 9,
    ///         AnalyzeMethod10 = 10,
    ///         AnalyzeMethod11 = 11,
    ///         AnalyzeMethod12 = 12,
    ///     }
    /// </code>
    /// </remarks>
    public enum AnalyzeMethodEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [MF] ---- fr [MF]
        /// </summary>
        MF = 1,
        /// <summary>
        /// 2 -- en [ZZ_510Q] ---- fr [ZZ_510Q]
        /// </summary>
        ZZ_510Q = 2,
        /// <summary>
        /// 3 -- en [ZZ_509Q] ---- fr [ZZ_509Q]
        /// </summary>
        ZZ_509Q = 3,
        /// <summary>
        /// 4 -- en [ZZ_0] ---- fr [ZZ_0]
        /// </summary>
        ZZ_0 = 4,
        /// <summary>
        /// 5 -- en [ZZ_525Q] ---- fr [ZZ_525Q]
        /// </summary>
        ZZ_525Q = 5,
        /// <summary>
        /// 6 -- en [MPN] ---- fr [MPN]
        /// </summary>
        MPN = 6,
        /// <summary>
        /// 7 -- en [ZZ_0Q] ---- fr [ZZ_0Q]
        /// </summary>
        ZZ_0Q = 7,
        /// <summary>
        /// 8 -- en [AnalyzeMethod8] ---- fr [Méthode analytique 8]
        /// </summary>
        AnalyzeMethod8 = 8,
        /// <summary>
        /// 9 -- en [AnalyzeMethod9] ---- fr [Méthode analytique 9]
        /// </summary>
        AnalyzeMethod9 = 9,
        /// <summary>
        /// 10 -- en [AnalyzeMethod10] ---- fr [Méthode analytique 10 ]
        /// </summary>
        AnalyzeMethod10 = 10,
        /// <summary>
        /// 11 -- en [AnalyzeMethod11] ---- fr [Méthode analytique 11]
        /// </summary>
        AnalyzeMethod11 = 11,
        /// <summary>
        /// 12 -- en [AnalyzeMethod12] ---- fr [Méthode analytique 12 ]
        /// </summary>
        AnalyzeMethod12 = 12,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum AppTaskCommandEnum
    ///     {
    ///         Error = 0,
    ///         GenerateWebTide = 1,
    ///         MikeScenarioAskToRun = 2,
    ///         MikeScenarioImport = 3,
    ///         MikeScenarioOtherFileImport = 4,
    ///         MikeScenarioRunning = 5,
    ///         MikeScenarioToCancel = 6,
    ///         MikeScenarioWaitingToRun = 7,
    ///         SetupWebTide = 8,
    ///         UpdateClimateSiteInformation = 9,
    ///         UpdateClimateSiteDailyAndHourlyFromStartDateToEndDate = 10,
    ///         UpdateClimateSiteDailyAndHourlyForSubsectorFromStartDateToEndDate = 11,
    ///         CreateFCForm = 12,
    ///         CreateSamplingPlanSamplingPlanTextFile = 13,
    ///         CreateDocumentFromTemplate = 14,
    ///         GetClimateSitesDataForRunsOfYear = 15,
    ///         CreateWebTideDataWLAtFirstNode = 16,
    ///     }
    /// </code>
    /// </remarks>
    public enum AppTaskCommandEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Generate Web Tide] ---- fr [Generate Web Tide (fr)]
        /// </summary>
        GenerateWebTide = 1,
        /// <summary>
        /// 2 -- en [MIKE Scenario Ask To Run] ---- fr [MIKE Scenario Ask To Run (fr)]
        /// </summary>
        MikeScenarioAskToRun = 2,
        /// <summary>
        /// 3 -- en [MIKE Scenario Import] ---- fr [MIKE Scenario Import (fr)]
        /// </summary>
        MikeScenarioImport = 3,
        /// <summary>
        /// 4 -- en [MIKEScenario Other File Import] ---- fr [MIKEScenario Other File Import (fr)]
        /// </summary>
        MikeScenarioOtherFileImport = 4,
        /// <summary>
        /// 5 -- en [MIKE Scenario Running] ---- fr [MIKE Scenario Running (fr)]
        /// </summary>
        MikeScenarioRunning = 5,
        /// <summary>
        /// 6 -- en [MIKE Scenario To Cancel] ---- fr [MIKE Scenario To Cancel (fr)]
        /// </summary>
        MikeScenarioToCancel = 6,
        /// <summary>
        /// 7 -- en [MIKE Scenario Waiting To Run] ---- fr [MIKE Scenario Waiting To Run (fr)]
        /// </summary>
        MikeScenarioWaitingToRun = 7,
        /// <summary>
        /// 8 -- en [Setup Web Tide] ---- fr [Setup Web Tide (fr)]
        /// </summary>
        SetupWebTide = 8,
        /// <summary>
        /// 9 -- en [Update Climate Site Information] ---- fr [Update Climate Site Informatiion (fr)]
        /// </summary>
        UpdateClimateSiteInformation = 9,
        /// <summary>
        /// 10 -- en [Update Climate Site Daily And Hourly From Start Date To End Date] ---- fr [Update Climate Site Daily And Hourly From Start Date To End Date (fr)]
        /// </summary>
        UpdateClimateSiteDailyAndHourlyFromStartDateToEndDate = 10,
        /// <summary>
        /// 11 -- en [Update Climate Site Daily And Hourly For Subsector From Start Date To End Date] ---- fr [Update Climate Site Daily And Hourly For Subsector From Start Date To End Date (fr)]
        /// </summary>
        UpdateClimateSiteDailyAndHourlyForSubsectorFromStartDateToEndDate = 11,
        /// <summary>
        /// 12 -- en [Fecal Coliform Form] ---- fr [Fecal Coliform Form (fr)]
        /// </summary>
        CreateFCForm = 12,
        /// <summary>
        /// 13 -- en [Create MWQM Plan Sampling Plan Text file] ---- fr [Create MWQM Plan Sampling Plan Text file (fr)]
        /// </summary>
        CreateSamplingPlanSamplingPlanTextFile = 13,
        /// <summary>
        /// 14 -- en [Create file from template] ---- fr [Create file from template (fr)]
        /// </summary>
        CreateDocumentFromTemplate = 14,
        /// <summary>
        /// 15 -- en [Get climate sites data for runs of year] ---- fr [Get climate sites data for runs of year (fr)]
        /// </summary>
        GetClimateSitesDataForRunsOfYear = 15,
        /// <summary>
        /// 16 -- en [Create WebTide data (water level) at first node] ---- fr [Creation de données WebTide (niveau d'eau) au premier noeud]
        /// </summary>
        CreateWebTideDataWLAtFirstNode = 16,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum AppTaskStatusEnum
    ///     {
    ///         Error = 0,
    ///         Created = 1,
    ///         Running = 2,
    ///         Completed = 3,
    ///         Cancelled = 4,
    ///     }
    /// </code>
    /// </remarks>
    public enum AppTaskStatusEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Created] ---- fr [Créé]
        /// </summary>
        Created = 1,
        /// <summary>
        /// 2 -- en [Running] ---- fr [En traitement]
        /// </summary>
        Running = 2,
        /// <summary>
        /// 3 -- en [Completed] ---- fr [Terminé]
        /// </summary>
        Completed = 3,
        /// <summary>
        /// 4 -- en [Cancelled] ---- fr [Annulé]
        /// </summary>
        Cancelled = 4,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [MWQMRun.SeaStateAtStart_BeaufortScale] (CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_SeaStateAtStart_BeaufortScale), [MWQMRun.SeaStateAtEnd_BeaufortScale] (CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_SeaStateAtEnd_BeaufortScale), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum BeaufortScaleEnum
    ///     {
    ///         Error = -1,
    ///         Calm = 0,
    ///         LightAir = 1,
    ///         LightBreeze = 2,
    ///         GentleBreeze = 3,
    ///         ModerateBreeze = 4,
    ///         FreshBreeze = 5,
    ///         StrongBreeze = 6,
    ///         HighWind_ModerateGale_NearGale = 7,
    ///         Gale_FreshGale = 8,
    ///         Strong_SevereGale = 9,
    ///         Storm_WholeGale = 10,
    ///         ViolentStorm = 11,
    ///         HurricaneForce = 12,
    ///     }
    /// </code>
    /// </remarks>
    public enum BeaufortScaleEnum
    {
        /// <summary>
        /// -1 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = -1,
        /// <summary>
        /// 0 -- en [Calm] ---- fr [Calm (fr)]
        /// </summary>
        Calm = 0,
        /// <summary>
        /// 1 -- en [Light air] ---- fr [Light air (fr)]
        /// </summary>
        LightAir = 1,
        /// <summary>
        /// 2 -- en [Light breeze] ---- fr [Light breeze (fr)]
        /// </summary>
        LightBreeze = 2,
        /// <summary>
        /// 3 -- en [Gentle breeze] ---- fr [Gentle breeze (fr)]
        /// </summary>
        GentleBreeze = 3,
        /// <summary>
        /// 4 -- en [Moderate breeze] ---- fr [Moderate breeze (fr)]
        /// </summary>
        ModerateBreeze = 4,
        /// <summary>
        /// 5 -- en [Fresh breeze] ---- fr [Fresh breeze (fr)]
        /// </summary>
        FreshBreeze = 5,
        /// <summary>
        /// 6 -- en [Strong breeze] ---- fr [Strong breeze (fr)]
        /// </summary>
        StrongBreeze = 6,
        /// <summary>
        /// 7 -- en [High wind, moderate gale, near gale] ---- fr [High wind, moderate gale, near gale (fr)]
        /// </summary>
        HighWind_ModerateGale_NearGale = 7,
        /// <summary>
        /// 8 -- en [Gale, fresh gale] ---- fr [Gale, fresh gale (fr)]
        /// </summary>
        Gale_FreshGale = 8,
        /// <summary>
        /// 9 -- en [Strong, severe gale] ---- fr [Strong, severe gale (fr)]
        /// </summary>
        Strong_SevereGale = 9,
        /// <summary>
        /// 10 -- en [Storm, whole gale] ---- fr [Storm, whole gale (fr)]
        /// </summary>
        Storm_WholeGale = 10,
        /// <summary>
        /// 11 -- en [Violent storm] ---- fr [Violent storm (fr)]
        /// </summary>
        ViolentStorm = 11,
        /// <summary>
        /// 12 -- en [Hurricane force] ---- fr [Hurricane force (fr)]
        /// </summary>
        HurricaneForce = 12,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum BoxModelResultTypeEnum
    ///     {
    ///         Error = 0,
    ///         Dilution = 1,
    ///         NoDecayUntreated = 2,
    ///         NoDecayPreDisinfection = 3,
    ///         DecayUntreated = 4,
    ///         DecayPreDisinfection = 5,
    ///     }
    /// </code>
    /// </remarks>
    public enum BoxModelResultTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Dilution] ---- fr [Dilution]
        /// </summary>
        Dilution = 1,
        /// <summary>
        /// 2 -- en [NoDecayUntreated] ---- fr [NoDecayUntreated (fr)]
        /// </summary>
        NoDecayUntreated = 2,
        /// <summary>
        /// 3 -- en [NoDecayPreDisinfection] ---- fr [NoDecayPreDisinfection (fr)]
        /// </summary>
        NoDecayPreDisinfection = 3,
        /// <summary>
        /// 4 -- en [DecayUntreated] ---- fr [DecayUntreated (fr)]
        /// </summary>
        DecayUntreated = 4,
        /// <summary>
        /// 5 -- en [DecayPreDisinfection] ---- fr [DecayPreDisinfection (fr)]
        /// </summary>
        DecayPreDisinfection = 5,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [Infrastructure.CollectionSystemType] (CSSPModels.Infrastructure.html#CSSPModels_Infrastructure_CollectionSystemType), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum CollectionSystemTypeEnum
    ///     {
    ///         Error = 0,
    ///         CompletelySeparated = 1,
    ///         CompletelyCombined = 2,
    ///         Combined90Separated10 = 3,
    ///         Combined80Separated20 = 4,
    ///         Combined70Separated30 = 5,
    ///         Combined60Separated40 = 6,
    ///         Combined50Separated50 = 7,
    ///         Combined40Separated60 = 8,
    ///         Combined30Separated70 = 9,
    ///         Combined20Separated80 = 10,
    ///         Combined10Separated90 = 11,
    ///     }
    /// </code>
    /// </remarks>
    public enum CollectionSystemTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Completely Separated] ---- fr [Completely Separated (fr)]
        /// </summary>
        CompletelySeparated = 1,
        /// <summary>
        /// 2 -- en [Completely Combined] ---- fr [Completely Combined (fr)]
        /// </summary>
        CompletelyCombined = 2,
        /// <summary>
        /// 3 -- en [Combined 90% Separated 10%] ---- fr [Combined 90% Separated 10% (fr)]
        /// </summary>
        Combined90Separated10 = 3,
        /// <summary>
        /// 4 -- en [Combined 80% Separated 20%] ---- fr [Combined 80% Separated 20% (fr)]
        /// </summary>
        Combined80Separated20 = 4,
        /// <summary>
        /// 5 -- en [Combined 70% Separated 30%] ---- fr [Combined 70% Separated 30% (fr)]
        /// </summary>
        Combined70Separated30 = 5,
        /// <summary>
        /// 6 -- en [Combined 60% Separated 40%] ---- fr [Combined 60% Separated 40% (fr)]
        /// </summary>
        Combined60Separated40 = 6,
        /// <summary>
        /// 7 -- en [] ---- fr [Combined 50% Separated 50% (fr)]
        /// </summary>
        Combined50Separated50 = 7,
        /// <summary>
        /// 8 -- en [Combined 40% Separated 60%] ---- fr [Combined 40% Separated 60% (fr)]
        /// </summary>
        Combined40Separated60 = 8,
        /// <summary>
        /// 9 -- en [Combined 30% Separated 70%] ---- fr [Combined 30% Separated 70% (fr)]
        /// </summary>
        Combined30Separated70 = 9,
        /// <summary>
        /// 10 -- en [Combined 20% Separated 80%] ---- fr [Combined 20% Separated 80% (fr)]
        /// </summary>
        Combined20Separated80 = 10,
        /// <summary>
        /// 11 -- en [Combined 10% Separated 90%] ---- fr [Combined 10% Separated 90% (fr)]
        /// </summary>
        Combined10Separated90 = 11,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [NewContact.ContactTitle] (CSSPModels.NewContact.html#CSSPModels_NewContact_ContactTitle), [Contact.ContactTitle] (CSSPModels.Contact.html#CSSPModels_Contact_ContactTitle), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum ContactTitleEnum
    ///     {
    ///         Error = 0,
    ///         DirectorGeneral = 1,
    ///         DirectorPublicWorks = 2,
    ///         Superintendent = 3,
    ///         Engineer = 4,
    ///         Foreman = 5,
    ///         Operator = 6,
    ///         FacilitiesManager = 7,
    ///         Supervisor = 8,
    ///         Technician = 9,
    ///     }
    /// </code>
    /// </remarks>
    public enum ContactTitleEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Director General] ---- fr [Director General (fr)]
        /// </summary>
        DirectorGeneral = 1,
        /// <summary>
        /// 2 -- en [Director Public Works] ---- fr [Director Public Works (fr)]
        /// </summary>
        DirectorPublicWorks = 2,
        /// <summary>
        /// 3 -- en [Superintendent] ---- fr [Superintendent (fr)]
        /// </summary>
        Superintendent = 3,
        /// <summary>
        /// 4 -- en [Engineer] ---- fr [Engineer (fr)]
        /// </summary>
        Engineer = 4,
        /// <summary>
        /// 5 -- en [Foreman] ---- fr [Foreman (fr)]
        /// </summary>
        Foreman = 5,
        /// <summary>
        /// 6 -- en [Operator] ---- fr [Operator (fr)]
        /// </summary>
        Operator = 6,
        /// <summary>
        /// 7 -- en [Facilities Manager] ---- fr [Facilities Manager (fr)]
        /// </summary>
        FacilitiesManager = 7,
        /// <summary>
        /// 8 -- en [Supervisor] ---- fr [Supervisor (fr)]
        /// </summary>
        Supervisor = 8,
        /// <summary>
        /// 9 -- en [Technician] ---- fr [Technician (fr)]
        /// </summary>
        Technician = 9,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum CSSPWQInputSheetTypeEnum
    ///     {
    ///         Error = 0,
    ///         A1 = 1,
    ///         LTB = 2,
    ///         EC = 3,
    ///     }
    /// </code>
    /// </remarks>
    public enum CSSPWQInputSheetTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [A1] ---- fr [A1]
        /// </summary>
        A1 = 1,
        /// <summary>
        /// 2 -- en [LTB] ---- fr [LTB]
        /// </summary>
        LTB = 2,
        /// <summary>
        /// 3 -- en [EC] ---- fr [EC]
        /// </summary>
        EC = 3,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum CSSPWQInputTypeEnum
    ///     {
    ///         Error = 0,
    ///         Subsector = 1,
    ///         Municipality = 2,
    ///     }
    /// </code>
    /// </remarks>
    public enum CSSPWQInputTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Subsector] ---- fr [Subsector (fr)]
        /// </summary>
        Subsector = 1,
        /// <summary>
        /// 2 -- en [Municipality] ---- fr [Municipality (fr)]
        /// </summary>
        Municipality = 2,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum DailyOrHourlyDataEnum
    ///     {
    ///         Error = 0,
    ///         Daily = 1,
    ///         Hourly = 2,
    ///     }
    /// </code>
    /// </remarks>
    public enum DailyOrHourlyDataEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Daily] ---- fr [Daily (fr)]
        /// </summary>
        Daily = 1,
        /// <summary>
        /// 2 -- en [Hourly] ---- fr [Hourly (fr)]
        /// </summary>
        Hourly = 2,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum DatabaseTypeEnum
    ///     {
    ///         Error = 0,
    ///         MemoryCSSPWebToolsDB = 1,
    ///         MemoryTestDB = 2,
    ///         SqlServerCSSPWebToolsDB = 3,
    ///         SqlServerTestDB = 4,
    ///     }
    /// </code>
    /// </remarks>
    public enum DatabaseTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [MemoryCSSPWebToolsDB] ---- fr [MemoryCSSPWebToolsDB]
        /// </summary>
        MemoryCSSPWebToolsDB = 1,
        /// <summary>
        /// 2 -- en [MemoryTestDB] ---- fr [MemoryTestDB]
        /// </summary>
        MemoryTestDB = 2,
        /// <summary>
        /// 3 -- en [SqlServerCSSPWebToolsDB] ---- fr [SqlServerCSSPWebToolsDB]
        /// </summary>
        SqlServerCSSPWebToolsDB = 3,
        /// <summary>
        /// 4 -- en [SqlServerTestDB] ---- fr [SqlServerTestDB]
        /// </summary>
        SqlServerTestDB = 4,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [Infrastructure.DisinfectionType] (CSSPModels.Infrastructure.html#CSSPModels_Infrastructure_DisinfectionType), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum DisinfectionTypeEnum
    ///     {
    ///         Error = 0,
    ///         None = 1,
    ///         UV = 2,
    ///         ChlorinationNoDechlorination = 3,
    ///         ChlorinationWithDechlorination = 4,
    ///         UVSeasonal = 5,
    ///         ChlorinationNoDechlorinationSeasonal = 6,
    ///         ChlorinationWithDechlorinationSeasonal = 7,
    ///     }
    /// </code>
    /// </remarks>
    public enum DisinfectionTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [None] ---- fr [Aucun]
        /// </summary>
        None = 1,
        /// <summary>
        /// 2 -- en [UV] ---- fr [UV ]
        /// </summary>
        UV = 2,
        /// <summary>
        /// 3 -- en [Chlorination No Dechlorination] ---- fr [Chlorination No Dechlorination (fr)]
        /// </summary>
        ChlorinationNoDechlorination = 3,
        /// <summary>
        /// 4 -- en [Chlorination With Dechlorination] ---- fr [Chlorination With Dechlorination (fr)]
        /// </summary>
        ChlorinationWithDechlorination = 4,
        /// <summary>
        /// 5 -- en [UV Seasonal] ---- fr [UV Seasonal (fr)]
        /// </summary>
        UVSeasonal = 5,
        /// <summary>
        /// 6 -- en [Chlorination No Dechlorination Seasonal] ---- fr [Chlorination No Dechlorination Seasonal (fr)]
        /// </summary>
        ChlorinationNoDechlorinationSeasonal = 6,
        /// <summary>
        /// 7 -- en [Chlorination With Dechlorination Seasonal] ---- fr [Chlorination With Dechlorination Seasonal (fr)]
        /// </summary>
        ChlorinationWithDechlorinationSeasonal = 7,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum EmailTypeEnum
    ///     {
    ///         Error = 0,
    ///         Personal = 1,
    ///         Work = 2,
    ///         Personal2 = 3,
    ///         Work2 = 4,
    ///     }
    /// </code>
    /// </remarks>
    public enum EmailTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Personal] ---- fr [Personnel]
        /// </summary>
        Personal = 1,
        /// <summary>
        /// 2 -- en [Work] ---- fr [Travail]
        /// </summary>
        Work = 2,
        /// <summary>
        /// 3 -- en [Personal-2] ---- fr [Personnel-2]
        /// </summary>
        Personal2 = 3,
        /// <summary>
        /// 4 -- en [Work-2] ---- fr [Travail-2]
        /// </summary>
        Work2 = 4,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [Infrastructure.FacilityType] (CSSPModels.Infrastructure.html#CSSPModels_Infrastructure_FacilityType), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum FacilityTypeEnum
    ///     {
    ///         Error = 0,
    ///         Lagoon = 1,
    ///         Plant = 2,
    ///     }
    /// </code>
    /// </remarks>
    public enum FacilityTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Lagoon] ---- fr [Lagoon (fr)]
        /// </summary>
        Lagoon = 1,
        /// <summary>
        /// 2 -- en [Plant] ---- fr [Plant (fr)]
        /// </summary>
        Plant = 2,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum FilePurposeEnum
    ///     {
    ///         Error = 0,
    ///         MikeInput = 1,
    ///         MikeInputMDF = 2,
    ///         MikeResultDFSU = 3,
    ///         MikeResultKMZ = 4,
    ///         Information = 5,
    ///         Image = 6,
    ///         Picture = 7,
    ///         Reported = 8,
    ///         Generated = 9,
    ///         GeneratedFCForm = 10,
    ///         Template = 11,
    ///         Map = 12,
    ///     }
    /// </code>
    /// </remarks>
    public enum FilePurposeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [MIKE Input] ---- fr [MIKE Input (fr)]
        /// </summary>
        MikeInput = 1,
        /// <summary>
        /// 2 -- en [MIKE Input MDF] ---- fr [MIKE Input MDF (fr)]
        /// </summary>
        MikeInputMDF = 2,
        /// <summary>
        /// 3 -- en [MIKE Result DFSU] ---- fr [MIKE Result DFSU (fr)]
        /// </summary>
        MikeResultDFSU = 3,
        /// <summary>
        /// 4 -- en [MIKE Result KMZ] ---- fr [MIKE Result KMZ (fr)]
        /// </summary>
        MikeResultKMZ = 4,
        /// <summary>
        /// 5 -- en [Information] ---- fr [Information (fr)]
        /// </summary>
        Information = 5,
        /// <summary>
        /// 6 -- en [Image] ---- fr [Image (fr)]
        /// </summary>
        Image = 6,
        /// <summary>
        /// 7 -- en [Picture] ---- fr [Picture (fr)]
        /// </summary>
        Picture = 7,
        /// <summary>
        /// 8 -- en [Reported] ---- fr [Reported (fr)]
        /// </summary>
        Reported = 8,
        /// <summary>
        /// 9 -- en [Generated] ---- fr [Generated (fr)]
        /// </summary>
        Generated = 9,
        /// <summary>
        /// 10 -- en [Generated FC Form] ---- fr [Generated FC Form(fr)]
        /// </summary>
        GeneratedFCForm = 10,
        /// <summary>
        /// 11 -- en [Template] ---- fr [Template (fr)]
        /// </summary>
        Template = 11,
        /// <summary>
        /// 12 -- en [Map] ---- fr [Map (fr)]
        /// </summary>
        Map = 12,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum FileStatusEnum
    ///     {
    ///         Error = 0,
    ///         Changed = 1,
    ///         Sent = 2,
    ///         Accepted = 3,
    ///         Rejected = 4,
    ///         Fail = 5,
    ///     }
    /// </code>
    /// </remarks>
    public enum FileStatusEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Changed] ---- fr [Changed (fr)]
        /// </summary>
        Changed = 1,
        /// <summary>
        /// 2 -- en [Sent] ---- fr [Sent (fr)]
        /// </summary>
        Sent = 2,
        /// <summary>
        /// 3 -- en [Accepted] ---- fr [Accepté]
        /// </summary>
        Accepted = 3,
        /// <summary>
        /// 4 -- en [Rejected] ---- fr [Rejected (fr)]
        /// </summary>
        Rejected = 4,
        /// <summary>
        /// 5 -- en [Fail] ---- fr [Fail (fr)]
        /// </summary>
        Fail = 5,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum FileTypeEnum
    ///     {
    ///         Error = 0,
    ///         DFS0 = 1,
    ///         DFS1 = 2,
    ///         DFSU = 3,
    ///         KMZ = 4,
    ///         LOG = 5,
    ///         M21FM = 6,
    ///         M3FM = 7,
    ///         MDF = 8,
    ///         MESH = 9,
    ///         XLSX = 10,
    ///         DOCX = 11,
    ///         PDF = 12,
    ///         JPG = 13,
    ///         JPEG = 14,
    ///         GIF = 15,
    ///         PNG = 16,
    ///         HTML = 17,
    ///         TXT = 18,
    ///         XYZ = 19,
    ///         KML = 20,
    ///         CSV = 21,
    ///     }
    /// </code>
    /// </remarks>
    public enum FileTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [DFS0] ---- fr [DFS0 (fr)]
        /// </summary>
        DFS0 = 1,
        /// <summary>
        /// 2 -- en [DFS1] ---- fr [DFS1 (fr)]
        /// </summary>
        DFS1 = 2,
        /// <summary>
        /// 3 -- en [DFSU] ---- fr [DFSU (fr)]
        /// </summary>
        DFSU = 3,
        /// <summary>
        /// 4 -- en [KMZ] ---- fr [KMZ (fr)]
        /// </summary>
        KMZ = 4,
        /// <summary>
        /// 5 -- en [LOG] ---- fr [LOG (fr)]
        /// </summary>
        LOG = 5,
        /// <summary>
        /// 6 -- en [M21FM] ---- fr [M21FM (fr)]
        /// </summary>
        M21FM = 6,
        /// <summary>
        /// 7 -- en [M3FM] ---- fr [M3FM (fr)]
        /// </summary>
        M3FM = 7,
        /// <summary>
        /// 8 -- en [MDF] ---- fr [MDF (fr)]
        /// </summary>
        MDF = 8,
        /// <summary>
        /// 9 -- en [MESH] ---- fr [MESH (fr)]
        /// </summary>
        MESH = 9,
        /// <summary>
        /// 10 -- en [XLSX] ---- fr [XLSX (fr)]
        /// </summary>
        XLSX = 10,
        /// <summary>
        /// 11 -- en [DOCX] ---- fr [DOCX (fr)]
        /// </summary>
        DOCX = 11,
        /// <summary>
        /// 12 -- en [PDF] ---- fr [PDF (fr)]
        /// </summary>
        PDF = 12,
        /// <summary>
        /// 13 -- en [JPG] ---- fr [JPG (fr)]
        /// </summary>
        JPG = 13,
        /// <summary>
        /// 14 -- en [JPEG] ---- fr [JPEG (fr)]
        /// </summary>
        JPEG = 14,
        /// <summary>
        /// 15 -- en [GIF] ---- fr [GIF (fr)]
        /// </summary>
        GIF = 15,
        /// <summary>
        /// 16 -- en [PNG] ---- fr [PNG (fr)]
        /// </summary>
        PNG = 16,
        /// <summary>
        /// 17 -- en [HTML] ---- fr [HTML (fr)]
        /// </summary>
        HTML = 17,
        /// <summary>
        /// 18 -- en [TXT] ---- fr [TXT (fr)]
        /// </summary>
        TXT = 18,
        /// <summary>
        /// 19 -- en [XYZ] ---- fr [XYZ (fr)]
        /// </summary>
        XYZ = 19,
        /// <summary>
        /// 20 -- en [KML] ---- fr [KML (fr)]
        /// </summary>
        KML = 20,
        /// <summary>
        /// 21 -- en [CSV] ---- fr [CSV]
        /// </summary>
        CSV = 21,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [Infrastructure.InfrastructureType] (CSSPModels.Infrastructure.html#CSSPModels_Infrastructure_InfrastructureType), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum InfrastructureTypeEnum
    ///     {
    ///         Error = 0,
    ///         WWTP = 1,
    ///         LiftStation = 2,
    ///         Other = 3,
    ///         SeeOther = 4,
    ///         LineOverflow = 5,
    ///     }
    /// </code>
    /// </remarks>
    public enum InfrastructureTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [WWTP] ---- fr [WWTP (fr)]
        /// </summary>
        WWTP = 1,
        /// <summary>
        /// 2 -- en [Lift Station] ---- fr [Lift Station (fr)]
        /// </summary>
        LiftStation = 2,
        /// <summary>
        /// 3 -- en [Other] ---- fr [Other (fr)]
        /// </summary>
        Other = 3,
        /// <summary>
        /// 4 -- en [See other] ---- fr [See other (fr)]
        /// </summary>
        SeeOther = 4,
        /// <summary>
        /// 5 -- en [Line overflow] ---- fr [Line overflow (fr)]
        /// </summary>
        LineOverflow = 5,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum KMZActionEnum
    ///     {
    ///         Error = 0,
    ///         DoNothing = 1,
    ///         GenerateKMZContourAnimation = 2,
    ///         GenerateKMZContourLimit = 3,
    ///         GenerateKMZCurrentAnimation = 4,
    ///         GenerateKMZCurrentMaximum = 5,
    ///         GenerateKMZMesh = 6,
    ///         GenerateKMZStudyArea = 7,
    ///         GenerateKMZBoundaryConditionNodes = 8,
    ///     }
    /// </code>
    /// </remarks>
    public enum KMZActionEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [DoNothing] ---- fr [DoNothing (fr)]
        /// </summary>
        DoNothing = 1,
        /// <summary>
        /// 2 -- en [GenerateKMZContourAnimation] ---- fr [GenerateKMZContourAnimation (fr)]
        /// </summary>
        GenerateKMZContourAnimation = 2,
        /// <summary>
        /// 3 -- en [GenerateKMZContourLimit] ---- fr [GenerateKMZContourLimit (fr)]
        /// </summary>
        GenerateKMZContourLimit = 3,
        /// <summary>
        /// 4 -- en [GenerateKMZCurrentAnimation] ---- fr [GenerateKMZCurrentAnimation (fr)]
        /// </summary>
        GenerateKMZCurrentAnimation = 4,
        /// <summary>
        /// 5 -- en [GenerateKMZCurrentMaximum] ---- fr [GenerateKMZCurrentMaximum (fr)]
        /// </summary>
        GenerateKMZCurrentMaximum = 5,
        /// <summary>
        /// 6 -- en [GenerateKMZMesh] ---- fr [GenerateKMZMesh (fr)]
        /// </summary>
        GenerateKMZMesh = 6,
        /// <summary>
        /// 7 -- en [GenerateKMZStudyArea] ---- fr [GenerateKMZStudyArea (fr)]
        /// </summary>
        GenerateKMZStudyArea = 7,
        /// <summary>
        /// 8 -- en [GenerateKMZBoundaryConditionNodes] ---- fr [GenerateKMZBoundaryConditionNodes (fr)]
        /// </summary>
        GenerateKMZBoundaryConditionNodes = 8,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [MWQMRun.Laboratory] (CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_Laboratory), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum LaboratoryEnum
    ///     {
    ///         Error = 0,
    ///         ZZ_0 = 1,
    ///         ZZ_1 = 2,
    ///         ZZ_2 = 3,
    ///         ZZ_3 = 4,
    ///         ZZ_4 = 5,
    ///         ZZ_1Q = 6,
    ///         ZZ_2Q = 7,
    ///         ZZ_3Q = 8,
    ///         ZZ_4Q = 9,
    ///         ZZ_5Q = 10,
    ///         ZZ_11BC = 11,
    ///         ZZ_12BC = 12,
    ///         ZZ_13BC = 13,
    ///         ZZ_14BC = 14,
    ///         ZZ_15BC = 15,
    ///         ZZ_16BC = 16,
    ///         ZZ_17BC = 17,
    ///         ZZ_18BC = 18,
    ///         MonctonEnvironmentCanada = 19,
    ///         BIOEnvironmentCanada = 20,
    ///         EasternCharlotteWaterwayLaboratory = 21,
    ///         InstitutDeRechercheSurLesZonesCotieres = 22,
    ///         CentreDeRechercheSurLesAliments = 23,
    ///         CaraquetMobileLaboratoryEnvironmentCanada = 24,
    ///         MaxxamAnalyticsBedford = 25,
    ///         MaxxamAnalyticsSydney = 26,
    ///         PEIAnalyticalLaboratory = 27,
    ///         NLMobileLaboratory = 28,
    ///         PetroformaInc = 29,
    ///     }
    /// </code>
    /// </remarks>
    public enum LaboratoryEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [ZZ_0] ---- fr [ZZ_0 (fr)]
        /// </summary>
        ZZ_0 = 1,
        /// <summary>
        /// 2 -- en [ZZ_1] ---- fr [ZZ_1 (fr)]
        /// </summary>
        ZZ_1 = 2,
        /// <summary>
        /// 3 -- en [ZZ_2] ---- fr [ZZ_2 (fr)]
        /// </summary>
        ZZ_2 = 3,
        /// <summary>
        /// 4 -- en [ZZ_3] ---- fr [ZZ_3 (fr)]
        /// </summary>
        ZZ_3 = 4,
        /// <summary>
        /// 5 -- en [ZZ_4] ---- fr [ZZ_4 (fr)]
        /// </summary>
        ZZ_4 = 5,
        /// <summary>
        /// 6 -- en [ZZ_1Q] ---- fr [ZZ_1Q (fr)]
        /// </summary>
        ZZ_1Q = 6,
        /// <summary>
        /// 7 -- en [ZZ_2Q] ---- fr [ZZ_2Q (fr)]
        /// </summary>
        ZZ_2Q = 7,
        /// <summary>
        /// 8 -- en [ZZ_3Q] ---- fr [ZZ_3Q (fr)]
        /// </summary>
        ZZ_3Q = 8,
        /// <summary>
        /// 9 -- en [ZZ_4Q] ---- fr [ZZ_4Q (fr)]
        /// </summary>
        ZZ_4Q = 9,
        /// <summary>
        /// 10 -- en [ZZ_5Q] ---- fr [ZZ_5Q (fr)]
        /// </summary>
        ZZ_5Q = 10,
        /// <summary>
        /// 11 -- en [ZZ_11BC] ---- fr [ZZ_11BC (fr)]
        /// </summary>
        ZZ_11BC = 11,
        /// <summary>
        /// 12 -- en [ZZ_12BC] ---- fr [ZZ_12BC (fr)]
        /// </summary>
        ZZ_12BC = 12,
        /// <summary>
        /// 13 -- en [ZZ_13BC] ---- fr [ZZ_13BC (fr)]
        /// </summary>
        ZZ_13BC = 13,
        /// <summary>
        /// 14 -- en [ZZ_14BC] ---- fr [ZZ_14BC (fr)]
        /// </summary>
        ZZ_14BC = 14,
        /// <summary>
        /// 15 -- en [ZZ_15BC] ---- fr [ZZ_15BC (fr)]
        /// </summary>
        ZZ_15BC = 15,
        /// <summary>
        /// 16 -- en [ZZ_16BC] ---- fr [ZZ_16BC (fr)]
        /// </summary>
        ZZ_16BC = 16,
        /// <summary>
        /// 17 -- en [ZZ_17BC] ---- fr [ZZ_17BC (fr)]
        /// </summary>
        ZZ_17BC = 17,
        /// <summary>
        /// 18 -- en [ZZ_18BC] ---- fr [ZZ_18BC (fr)]
        /// </summary>
        ZZ_18BC = 18,
        /// <summary>
        /// 19 -- en [Moncton Environment Canada] ---- fr [Moncton Environment Canada (fr)]
        /// </summary>
        MonctonEnvironmentCanada = 19,
        /// <summary>
        /// 20 -- en [BIO Environment Canada] ---- fr [BIO Environment Canada]
        /// </summary>
        BIOEnvironmentCanada = 20,
        /// <summary>
        /// 21 -- en [Eastern Charlotte Waterway Laboratory] ---- fr [Eastern Charlotte Waterway Laboratory]
        /// </summary>
        EasternCharlotteWaterwayLaboratory = 21,
        /// <summary>
        /// 22 -- en [Institut de recherche sur les zones cotières] ---- fr [Institut de recherche sur les zones cotières]
        /// </summary>
        InstitutDeRechercheSurLesZonesCotieres = 22,
        /// <summary>
        /// 23 -- en [Centre de recherche sur les aliments] ---- fr [Centre de recherche sur les aliments]
        /// </summary>
        CentreDeRechercheSurLesAliments = 23,
        /// <summary>
        /// 24 -- en [Caraquet mobile laboratory Environment Canada] ---- fr [Caraquet mobile laboratory Environment Canada (fr)]
        /// </summary>
        CaraquetMobileLaboratoryEnvironmentCanada = 24,
        /// <summary>
        /// 25 -- en [Maxxam Analytics Bedford] ---- fr [Maxxam Analytics Bedford (fr)]
        /// </summary>
        MaxxamAnalyticsBedford = 25,
        /// <summary>
        /// 26 -- en [Maxxam Analytics Sydney] ---- fr [Maxxam Analytics Sydney (fr)]
        /// </summary>
        MaxxamAnalyticsSydney = 26,
        /// <summary>
        /// 27 -- en [PEI Analytical Laboratory] ---- fr [PEI Analytical Laboratory (fr)]
        /// </summary>
        PEIAnalyticalLaboratory = 27,
        /// <summary>
        /// 28 -- en [NL Mobile Laboratory] ---- fr [NL Mobile Laboratory (fr)]
        /// </summary>
        NLMobileLaboratory = 28,
        /// <summary>
        /// 29 -- en [Petroforma Inc.] ---- fr [Petroforma Inc. (fr)]
        /// </summary>
        PetroformaInc = 29,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum LabSheetStatusEnum
    ///     {
    ///         Error = 0,
    ///         Created = 1,
    ///         Transferred = 2,
    ///         Accepted = 3,
    ///         Rejected = 4,
    ///     }
    /// </code>
    /// </remarks>
    public enum LabSheetStatusEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Created] ---- fr [Created (fr)]
        /// </summary>
        Created = 1,
        /// <summary>
        /// 2 -- en [Transferred] ---- fr [Transferred (fr)]
        /// </summary>
        Transferred = 2,
        /// <summary>
        /// 3 -- en [Accepted] ---- fr [Accepté]
        /// </summary>
        Accepted = 3,
        /// <summary>
        /// 4 -- en [Rejected] ---- fr [Rejected (fr)]
        /// </summary>
        Rejected = 4,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum LabSheetTypeEnum
    ///     {
    ///         Error = 0,
    ///         A1 = 1,
    ///         LTB = 2,
    ///         EC = 3,
    ///     }
    /// </code>
    /// </remarks>
    public enum LabSheetTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [A1] ---- fr [A1]
        /// </summary>
        A1 = 1,
        /// <summary>
        /// 2 -- en [LTB] ---- fr [LTB]
        /// </summary>
        LTB = 2,
        /// <summary>
        /// 3 -- en [EC] ---- fr [EC]
        /// </summary>
        EC = 3,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum LanguageEnum
    ///     {
    ///         Error = 0,
    ///         en = 1,
    ///         fr = 2,
    ///         enAndfr = 3,
    ///         es = 4,
    ///     }
    /// </code>
    /// </remarks>
    public enum LanguageEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [en] ---- fr [en]
        /// </summary>
        en = 1,
        /// <summary>
        /// 2 -- en [fr] ---- fr [fr]
        /// </summary>
        fr = 2,
        /// <summary>
        /// 3 -- en [enAndfr] ---- fr [enAndfr]
        /// </summary>
        enAndfr = 3,
        /// <summary>
        /// 4 -- en [es] ---- fr [es]
        /// </summary>
        es = 4,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum LogCommandEnum
    ///     {
    ///         Error = 0,
    ///         Add = 1,
    ///         Change = 2,
    ///         Delete = 3,
    ///     }
    /// </code>
    /// </remarks>
    public enum LogCommandEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Add] ---- fr [Add (fr)]
        /// </summary>
        Add = 1,
        /// <summary>
        /// 2 -- en [Change] ---- fr [Change (fr)]
        /// </summary>
        Change = 2,
        /// <summary>
        /// 3 -- en [Delete] ---- fr [Delete (fr)]
        /// </summary>
        Delete = 3,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum MapInfoDrawTypeEnum
    ///     {
    ///         Error = 0,
    ///         Point = 1,
    ///         Polyline = 2,
    ///         Polygon = 3,
    ///     }
    /// </code>
    /// </remarks>
    public enum MapInfoDrawTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Point] ---- fr [Point (fr)]
        /// </summary>
        Point = 1,
        /// <summary>
        /// 2 -- en [Polyline] ---- fr [Polyline (fr)]
        /// </summary>
        Polyline = 2,
        /// <summary>
        /// 3 -- en [Polygon] ---- fr [Polygon (fr)]
        /// </summary>
        Polygon = 3,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum MikeBoundaryConditionLevelOrVelocityEnum
    ///     {
    ///         Error = 0,
    ///         Level = 1,
    ///         Velocity = 2,
    ///     }
    /// </code>
    /// </remarks>
    public enum MikeBoundaryConditionLevelOrVelocityEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Level] ---- fr [Level (fr)]
        /// </summary>
        Level = 1,
        /// <summary>
        /// 2 -- en [Velocity] ---- fr [Velocity (fr)]
        /// </summary>
        Velocity = 2,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum MikeScenarioSpecialResultKMLTypeEnum
    ///     {
    ///         Error = 0,
    ///         Mesh = 1,
    ///         StudyArea = 2,
    ///         BoundaryConditions = 3,
    ///         PollutionLimit = 4,
    ///         PollutionAnimation = 5,
    ///     }
    /// </code>
    /// </remarks>
    public enum MikeScenarioSpecialResultKMLTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Mesh] ---- fr [Grillage]
        /// </summary>
        Mesh = 1,
        /// <summary>
        /// 2 -- en [Study area] ---- fr [Région d'étude]
        /// </summary>
        StudyArea = 2,
        /// <summary>
        /// 3 -- en [Boundary conditions] ---- fr [Conditions aux limits]
        /// </summary>
        BoundaryConditions = 3,
        /// <summary>
        /// 4 -- en [Pollution limit] ---- fr [Limit de pollution]
        /// </summary>
        PollutionLimit = 4,
        /// <summary>
        /// 5 -- en [Pollution animation] ---- fr [Animation de pollution]
        /// </summary>
        PollutionAnimation = 5,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum MWQMSiteLatestClassificationEnum
    ///     {
    ///         Error = 0,
    ///         Approved = 1,
    ///         ConditionallyApproved = 2,
    ///         Restricted = 3,
    ///         ConditionallyRestricted = 4,
    ///         Prohibited = 5,
    ///         Unclassified = 6,
    ///     }
    /// </code>
    /// </remarks>
    public enum MWQMSiteLatestClassificationEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Approved] ---- fr [Approved (fr)]
        /// </summary>
        Approved = 1,
        /// <summary>
        /// 2 -- en [ConditionallyApproved] ---- fr [ConditionallyApproved (fr)]
        /// </summary>
        ConditionallyApproved = 2,
        /// <summary>
        /// 3 -- en [Restricted] ---- fr [Restricted (fr)]
        /// </summary>
        Restricted = 3,
        /// <summary>
        /// 4 -- en [ConditionallyRestricted] ---- fr [ConditionallyRestricted (fr)]
        /// </summary>
        ConditionallyRestricted = 4,
        /// <summary>
        /// 5 -- en [Prohibited] ---- fr [Prohibited (fr)]
        /// </summary>
        Prohibited = 5,
        /// <summary>
        /// 6 -- en [Unclassified] ---- fr [Unclassified (fr)]
        /// </summary>
        Unclassified = 6,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [PolSourceSite.InactiveReason] (CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_InactiveReason), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum PolSourceInactiveReasonEnum
    ///     {
    ///         Error = 0,
    ///         Abandoned = 1,
    ///         Closed = 2,
    ///         Removed = 3,
    ///     }
    /// </code>
    /// </remarks>
    public enum PolSourceInactiveReasonEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Abandoned] ---- fr [Abandoned (fr)]
        /// </summary>
        Abandoned = 1,
        /// <summary>
        /// 2 -- en [Closed] ---- fr [Closed (fr)]
        /// </summary>
        Closed = 2,
        /// <summary>
        /// 3 -- en [Removed] ---- fr [Removed (fr)]
        /// </summary>
        Removed = 3,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum PolSourceIssueRiskEnum
    ///     {
    ///         Error = 0,
    ///         LowRisk = 1,
    ///         ModerateRisk = 2,
    ///         HighRisk = 3,
    ///     }
    /// </code>
    /// </remarks>
    public enum PolSourceIssueRiskEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [LowRisk] ---- fr [LowRisk]
        /// </summary>
        LowRisk = 1,
        /// <summary>
        /// 2 -- en [ModerateRisk] ---- fr [ModerateRisk]
        /// </summary>
        ModerateRisk = 2,
        /// <summary>
        /// 3 -- en [HighRisk] ---- fr [HighRisk]
        /// </summary>
        HighRisk = 3,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum PolSourceObsInfoTypeEnum
    ///     {
    ///         Error = 0,
    ///         Description = 1,
    ///         Report = 2,
    ///         Text = 3,
    ///         Initial = 4,
    ///     }
    /// </code>
    /// </remarks>
    public enum PolSourceObsInfoTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Description] ---- fr [Description (fr)]
        /// </summary>
        Description = 1,
        /// <summary>
        /// 2 -- en [Report] ---- fr [Report (fr)]
        /// </summary>
        Report = 2,
        /// <summary>
        /// 3 -- en [Text] ---- fr [Text (fr)]
        /// </summary>
        Text = 3,
        /// <summary>
        /// 4 -- en [Initial] ---- fr [Initial (fr)]
        /// </summary>
        Initial = 4,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [Infrastructure.PreliminaryTreatmentType] (CSSPModels.Infrastructure.html#CSSPModels_Infrastructure_PreliminaryTreatmentType), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum PreliminaryTreatmentTypeEnum
    ///     {
    ///         Error = 0,
    ///         NotApplicable = 1,
    ///         BarScreen = 2,
    ///         Grinder = 3,
    ///     }
    /// </code>
    /// </remarks>
    public enum PreliminaryTreatmentTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Not applicable] ---- fr [Not applicable (fr)]
        /// </summary>
        NotApplicable = 1,
        /// <summary>
        /// 2 -- en [Bar screen] ---- fr [Bar screen (fr)]
        /// </summary>
        BarScreen = 2,
        /// <summary>
        /// 3 -- en [Grinder] ---- fr [Grinder (fr)]
        /// </summary>
        Grinder = 3,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [Infrastructure.PrimaryTreatmentType] (CSSPModels.Infrastructure.html#CSSPModels_Infrastructure_PrimaryTreatmentType), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum PrimaryTreatmentTypeEnum
    ///     {
    ///         Error = 0,
    ///         NotApplicable = 1,
    ///         Sedimentation = 2,
    ///         ChemicalCoagulation = 3,
    ///         Filtration = 4,
    ///     }
    /// </code>
    /// </remarks>
    public enum PrimaryTreatmentTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Not applicable] ---- fr [Not applicable (fr)]
        /// </summary>
        NotApplicable = 1,
        /// <summary>
        /// 2 -- en [Sedimentation] ---- fr [Sedimentation (fr)]
        /// </summary>
        Sedimentation = 2,
        /// <summary>
        /// 3 -- en [Chemical coagulation] ---- fr [Chemical coagulation (fr)]
        /// </summary>
        ChemicalCoagulation = 3,
        /// <summary>
        /// 4 -- en [Filtration] ---- fr [Filtration (fr)]
        /// </summary>
        Filtration = 4,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum ReportConditionEnum
    ///     {
    ///         Error = 0,
    ///         ReportConditionTrue = 1,
    ///         ReportConditionFalse = 2,
    ///         ReportConditionContain = 3,
    ///         ReportConditionStart = 4,
    ///         ReportConditionEnd = 5,
    ///         ReportConditionBigger = 6,
    ///         ReportConditionSmaller = 7,
    ///         ReportConditionEqual = 8,
    ///     }
    /// </code>
    /// </remarks>
    public enum ReportConditionEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [TRUE] ---- fr [TRUE]
        /// </summary>
        ReportConditionTrue = 1,
        /// <summary>
        /// 2 -- en [FALSE] ---- fr [FALSE]
        /// </summary>
        ReportConditionFalse = 2,
        /// <summary>
        /// 3 -- en [CONTAIN] ---- fr [CONTAIN]
        /// </summary>
        ReportConditionContain = 3,
        /// <summary>
        /// 4 -- en [START] ---- fr [START]
        /// </summary>
        ReportConditionStart = 4,
        /// <summary>
        /// 5 -- en [END] ---- fr [END]
        /// </summary>
        ReportConditionEnd = 5,
        /// <summary>
        /// 6 -- en [BIGGER] ---- fr [BIGGER]
        /// </summary>
        ReportConditionBigger = 6,
        /// <summary>
        /// 7 -- en [SMALLER] ---- fr [SMALLER]
        /// </summary>
        ReportConditionSmaller = 7,
        /// <summary>
        /// 8 -- en [EQUAL] ---- fr [EQUAL]
        /// </summary>
        ReportConditionEqual = 8,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum ReportFieldTypeEnum
    ///     {
    ///         Error = 0,
    ///         NumberWhole = 1,
    ///         NumberWithDecimal = 2,
    ///         DateAndTime = 3,
    ///         Text = 4,
    ///         TrueOrFalse = 5,
    ///         FilePurpose = 6,
    ///         FileType = 7,
    ///         TranslationStatus = 8,
    ///         BoxModelResultType = 9,
    ///         InfrastructureType = 10,
    ///         FacilityType = 11,
    ///         AerationType = 12,
    ///         PreliminaryTreatmentType = 13,
    ///         PrimaryTreatmentType = 14,
    ///         SecondaryTreatmentType = 15,
    ///         TertiaryTreatmentType = 16,
    ///         TreatmentType = 17,
    ///         DisinfectionType = 18,
    ///         CollectionSystemType = 19,
    ///         AlarmSystemType = 20,
    ///         ScenarioStatus = 21,
    ///         StorageDataType = 22,
    ///         Language = 23,
    ///         SampleType = 24,
    ///         BeaufortScale = 25,
    ///         AnalyzeMethod = 26,
    ///         SampleMatrix = 27,
    ///         Laboratory = 28,
    ///         SampleStatus = 29,
    ///         SamplingPlanType = 30,
    ///         LabSheetSampleType = 31,
    ///         LabSheetType = 32,
    ///         LabSheetStatus = 33,
    ///         PolSourceInactiveReason = 34,
    ///         PolSourceObsInfo = 35,
    ///         AddressType = 36,
    ///         StreetType = 37,
    ///         ContactTitle = 38,
    ///         EmailType = 39,
    ///         TelType = 40,
    ///         TideText = 41,
    ///         TideDataType = 42,
    ///         SpecialTableType = 43,
    ///         MWQMSiteLatestClassification = 44,
    ///         PolSourceIssueRisk = 45,
    ///         MikeScenarioSpecialResultKMLType = 46,
    ///     }
    /// </code>
    /// </remarks>
    public enum ReportFieldTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [NumberWhole] ---- fr [NumberWhole]
        /// </summary>
        NumberWhole = 1,
        /// <summary>
        /// 2 -- en [NumberWithDecimal] ---- fr [NumberWithDecimal]
        /// </summary>
        NumberWithDecimal = 2,
        /// <summary>
        /// 3 -- en [DateAndTime] ---- fr [DateAndTime]
        /// </summary>
        DateAndTime = 3,
        /// <summary>
        /// 4 -- en [Text] ---- fr [Text]
        /// </summary>
        Text = 4,
        /// <summary>
        /// 5 -- en [TrueOrFalse] ---- fr [TrueOrFalse]
        /// </summary>
        TrueOrFalse = 5,
        /// <summary>
        /// 6 -- en [FilePurpose] ---- fr [FilePurpose]
        /// </summary>
        FilePurpose = 6,
        /// <summary>
        /// 7 -- en [FileType] ---- fr [FileType]
        /// </summary>
        FileType = 7,
        /// <summary>
        /// 8 -- en [TranslationStatus] ---- fr [TranslationStatus]
        /// </summary>
        TranslationStatus = 8,
        /// <summary>
        /// 9 -- en [BoxModelResultType] ---- fr [BoxModelResultType]
        /// </summary>
        BoxModelResultType = 9,
        /// <summary>
        /// 10 -- en [InfrastructureType] ---- fr [InfrastructureType]
        /// </summary>
        InfrastructureType = 10,
        /// <summary>
        /// 11 -- en [FacilityType] ---- fr [FacilityType]
        /// </summary>
        FacilityType = 11,
        /// <summary>
        /// 12 -- en [AerationType] ---- fr [AerationType]
        /// </summary>
        AerationType = 12,
        /// <summary>
        /// 13 -- en [PreliminaryTreatmentType] ---- fr [PreliminaryTreatmentType]
        /// </summary>
        PreliminaryTreatmentType = 13,
        /// <summary>
        /// 14 -- en [PrimaryTreatmentType] ---- fr [PrimaryTreatmentType]
        /// </summary>
        PrimaryTreatmentType = 14,
        /// <summary>
        /// 15 -- en [SecondaryTreatmentType] ---- fr [SecondaryTreatmentType]
        /// </summary>
        SecondaryTreatmentType = 15,
        /// <summary>
        /// 16 -- en [TertiaryTreatmentType] ---- fr [TertiaryTreatmentType]
        /// </summary>
        TertiaryTreatmentType = 16,
        /// <summary>
        /// 17 -- en [TreatmentType] ---- fr [TreatmentType]
        /// </summary>
        TreatmentType = 17,
        /// <summary>
        /// 18 -- en [DisinfectionType] ---- fr [DisinfectionType]
        /// </summary>
        DisinfectionType = 18,
        /// <summary>
        /// 19 -- en [CollectionSystemType] ---- fr [CollectionSystemType]
        /// </summary>
        CollectionSystemType = 19,
        /// <summary>
        /// 20 -- en [AlarmSystemType] ---- fr [AlarmSystemType]
        /// </summary>
        AlarmSystemType = 20,
        /// <summary>
        /// 21 -- en [ScenarioStatus] ---- fr [ScenarioStatus]
        /// </summary>
        ScenarioStatus = 21,
        /// <summary>
        /// 22 -- en [StorageDataType] ---- fr [StorageDataType]
        /// </summary>
        StorageDataType = 22,
        /// <summary>
        /// 23 -- en [Language] ---- fr [Language]
        /// </summary>
        Language = 23,
        /// <summary>
        /// 24 -- en [SampleType] ---- fr [SampleType]
        /// </summary>
        SampleType = 24,
        /// <summary>
        /// 25 -- en [BeaufortScale] ---- fr [BeaufortScale]
        /// </summary>
        BeaufortScale = 25,
        /// <summary>
        /// 26 -- en [AnalyzeMethod] ---- fr [AnalyzeMethod]
        /// </summary>
        AnalyzeMethod = 26,
        /// <summary>
        /// 27 -- en [SampleMatrix] ---- fr [SampleMatrix]
        /// </summary>
        SampleMatrix = 27,
        /// <summary>
        /// 28 -- en [Laboratory] ---- fr [Laboratory]
        /// </summary>
        Laboratory = 28,
        /// <summary>
        /// 29 -- en [SampleStatus] ---- fr [SampleStatus]
        /// </summary>
        SampleStatus = 29,
        /// <summary>
        /// 30 -- en [SamplingPlanType] ---- fr [SamplingPlanType]
        /// </summary>
        SamplingPlanType = 30,
        /// <summary>
        /// 31 -- en [LabSheetSampleType] ---- fr [LabSheetSampleType]
        /// </summary>
        LabSheetSampleType = 31,
        /// <summary>
        /// 32 -- en [LabSheetType] ---- fr [LabSheetType]
        /// </summary>
        LabSheetType = 32,
        /// <summary>
        /// 33 -- en [LabSheetStatus] ---- fr [LabSheetStatus]
        /// </summary>
        LabSheetStatus = 33,
        /// <summary>
        /// 34 -- en [PolSourceInactiveReason] ---- fr [PolSourceInactiveReason]
        /// </summary>
        PolSourceInactiveReason = 34,
        /// <summary>
        /// 35 -- en [PolSourceObsInfo] ---- fr [PolSourceObsInfo]
        /// </summary>
        PolSourceObsInfo = 35,
        /// <summary>
        /// 36 -- en [AddressType] ---- fr [AddressType]
        /// </summary>
        AddressType = 36,
        /// <summary>
        /// 37 -- en [StreetType] ---- fr [StreetType]
        /// </summary>
        StreetType = 37,
        /// <summary>
        /// 38 -- en [ContactTitle] ---- fr [ContactTitle]
        /// </summary>
        ContactTitle = 38,
        /// <summary>
        /// 39 -- en [EmailType] ---- fr [EmailType]
        /// </summary>
        EmailType = 39,
        /// <summary>
        /// 40 -- en [TelType] ---- fr [TelType]
        /// </summary>
        TelType = 40,
        /// <summary>
        /// 41 -- en [TideText] ---- fr [TideText]
        /// </summary>
        TideText = 41,
        /// <summary>
        /// 42 -- en [TideDataType] ---- fr [TideDataType]
        /// </summary>
        TideDataType = 42,
        /// <summary>
        /// 43 -- en [SpecialTableType] ---- fr [SpecialTableType]
        /// </summary>
        SpecialTableType = 43,
        /// <summary>
        /// 44 -- en [MWQMSiteLatestClassification] ---- fr [MWQMSiteLatestClassification]
        /// </summary>
        MWQMSiteLatestClassification = 44,
        /// <summary>
        /// 45 -- en [PolSourceIssueRisk] ---- fr [PolSourceIssueRisk]
        /// </summary>
        PolSourceIssueRisk = 45,
        /// <summary>
        /// 46 -- en [MikeScenarioSpecialResultKMLType] ---- fr [Type de résultat spécial du scénario MIKE (KML)]
        /// </summary>
        MikeScenarioSpecialResultKMLType = 46,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum ReportFileTypeEnum
    ///     {
    ///         Error = 0,
    ///         CSV = 1,
    ///         Word = 2,
    ///         Excel = 3,
    ///         KML = 4,
    ///     }
    /// </code>
    /// </remarks>
    public enum ReportFileTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Comma Seperated Values] ---- fr [Comma Seperated Values (fr)]
        /// </summary>
        CSV = 1,
        /// <summary>
        /// 2 -- en [Word] ---- fr [Word (fr)]
        /// </summary>
        Word = 2,
        /// <summary>
        /// 3 -- en [Excel] ---- fr [Excel (fr)]
        /// </summary>
        Excel = 3,
        /// <summary>
        /// 4 -- en [Google Earth] ---- fr [Google Earth]
        /// </summary>
        KML = 4,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum ReportFormatingDateEnum
    ///     {
    ///         Error = 0,
    ///         ReportFormatingDateYearOnly = 1,
    ///         ReportFormatingDateMonthDecimalOnly = 2,
    ///         ReportFormatingDateMonthShortTextOnly = 3,
    ///         ReportFormatingDateMonthFullTextOnly = 4,
    ///         ReportFormatingDateDayOnly = 5,
    ///         ReportFormatingDateHourOnly = 6,
    ///         ReportFormatingDateMinuteOnly = 7,
    ///         ReportFormatingDateYearMonthDecimalDay = 8,
    ///         ReportFormatingDateYearMonthShortTextDay = 9,
    ///         ReportFormatingDateYearMonthFullTextDay = 10,
    ///         ReportFormatingDateYearMonthDecimalDayHourMinute = 11,
    ///         ReportFormatingDateYearMonthShortTextDayHourMinute = 12,
    ///         ReportFormatingDateYearMonthFullTextDayHourMinute = 13,
    ///     }
    /// </code>
    /// </remarks>
    public enum ReportFormatingDateEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [ReportFormatingDateYearOnly] ---- fr [ReportFormatingDateYearOnly]
        /// </summary>
        ReportFormatingDateYearOnly = 1,
        /// <summary>
        /// 2 -- en [ReportFormatingDateMonthDecimalOnly] ---- fr [ReportFormatingDateMonthDecimalOnly]
        /// </summary>
        ReportFormatingDateMonthDecimalOnly = 2,
        /// <summary>
        /// 3 -- en [ReportFormatingDateMonthShortTextOnly] ---- fr [ReportFormatingDateMonthShortTextOnly]
        /// </summary>
        ReportFormatingDateMonthShortTextOnly = 3,
        /// <summary>
        /// 4 -- en [ReportFormatingDateMonthFullTextOnly] ---- fr [ReportFormatingDateMonthFullTextOnly]
        /// </summary>
        ReportFormatingDateMonthFullTextOnly = 4,
        /// <summary>
        /// 5 -- en [ReportFormatingDateDayOnly] ---- fr [ReportFormatingDateDayOnly]
        /// </summary>
        ReportFormatingDateDayOnly = 5,
        /// <summary>
        /// 6 -- en [ReportFormatingDateHourOnly] ---- fr [ReportFormatingDateHourOnly]
        /// </summary>
        ReportFormatingDateHourOnly = 6,
        /// <summary>
        /// 7 -- en [ReportFormatingDateMinuteOnly] ---- fr [ReportFormatingDateMinuteOnly]
        /// </summary>
        ReportFormatingDateMinuteOnly = 7,
        /// <summary>
        /// 8 -- en [ReportFormatingDateYearMonthDecimalDay] ---- fr [ReportFormatingDateYearMonthDecimalDay]
        /// </summary>
        ReportFormatingDateYearMonthDecimalDay = 8,
        /// <summary>
        /// 9 -- en [ReportFormatingDateYearMonthShortTextDay] ---- fr [ReportFormatingDateYearMonthShortTextDay]
        /// </summary>
        ReportFormatingDateYearMonthShortTextDay = 9,
        /// <summary>
        /// 10 -- en [ReportFormatingDateYearMonthFullTextDay] ---- fr [ReportFormatingDateYearMonthFullTextDay]
        /// </summary>
        ReportFormatingDateYearMonthFullTextDay = 10,
        /// <summary>
        /// 11 -- en [ReportFormatingDateYearMonthDecimalDayHourMinute] ---- fr [ReportFormatingDateYearMonthDecimalDayHourMinute]
        /// </summary>
        ReportFormatingDateYearMonthDecimalDayHourMinute = 11,
        /// <summary>
        /// 12 -- en [ReportFormatingDateYearMonthShortTextDayHourMinute] ---- fr [ReportFormatingDateYearMonthShortTextDayHourMinute]
        /// </summary>
        ReportFormatingDateYearMonthShortTextDayHourMinute = 12,
        /// <summary>
        /// 13 -- en [ReportFormatingDateYearMonthFullTextDayHourMinute] ---- fr [ReportFormatingDateYearMonthFullTextDayHourMinute]
        /// </summary>
        ReportFormatingDateYearMonthFullTextDayHourMinute = 13,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum ReportFormatingNumberEnum
    ///     {
    ///         Error = 0,
    ///         ReportFormatingNumber0Decimal = 1,
    ///         ReportFormatingNumber1Decimal = 2,
    ///         ReportFormatingNumber2Decimal = 3,
    ///         ReportFormatingNumber3Decimal = 4,
    ///         ReportFormatingNumber4Decimal = 5,
    ///         ReportFormatingNumber5Decimal = 6,
    ///         ReportFormatingNumber6Decimal = 7,
    ///         ReportFormatingNumberScientific0Decimal = 8,
    ///         ReportFormatingNumberScientific1Decimal = 9,
    ///         ReportFormatingNumberScientific2Decimal = 10,
    ///         ReportFormatingNumberScientific3Decimal = 11,
    ///         ReportFormatingNumberScientific4Decimal = 12,
    ///         ReportFormatingNumberScientific5Decimal = 13,
    ///         ReportFormatingNumberScientific6Decimal = 14,
    ///     }
    /// </code>
    /// </remarks>
    public enum ReportFormatingNumberEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [ReportFormatingNumber0Decimal] ---- fr [ReportFormatingNumber0Decimal]
        /// </summary>
        ReportFormatingNumber0Decimal = 1,
        /// <summary>
        /// 2 -- en [ReportFormatingNumber1Decimal] ---- fr [ReportFormatingNumber1Decimal]
        /// </summary>
        ReportFormatingNumber1Decimal = 2,
        /// <summary>
        /// 3 -- en [ReportFormatingNumber2Decimal] ---- fr [ReportFormatingNumber2Decimal]
        /// </summary>
        ReportFormatingNumber2Decimal = 3,
        /// <summary>
        /// 4 -- en [ReportFormatingNumber3Decimal] ---- fr [ReportFormatingNumber3Decimal]
        /// </summary>
        ReportFormatingNumber3Decimal = 4,
        /// <summary>
        /// 5 -- en [ReportFormatingNumber4Decimal] ---- fr [ReportFormatingNumber4Decimal]
        /// </summary>
        ReportFormatingNumber4Decimal = 5,
        /// <summary>
        /// 6 -- en [ReportFormatingNumber5Decimal] ---- fr [ReportFormatingNumber5Decimal]
        /// </summary>
        ReportFormatingNumber5Decimal = 6,
        /// <summary>
        /// 7 -- en [ReportFormatingNumber6Decimal] ---- fr [ReportFormatingNumber6Decimal]
        /// </summary>
        ReportFormatingNumber6Decimal = 7,
        /// <summary>
        /// 8 -- en [ReportFormatingNumberScientific0Decimal] ---- fr [ReportFormatingNumberScientific0Decimal]
        /// </summary>
        ReportFormatingNumberScientific0Decimal = 8,
        /// <summary>
        /// 9 -- en [ReportFormatingNumberScientific1Decimal] ---- fr [ReportFormatingNumberScientific1Decimal]
        /// </summary>
        ReportFormatingNumberScientific1Decimal = 9,
        /// <summary>
        /// 10 -- en [ReportFormatingNumberScientific2Decimal] ---- fr [ReportFormatingNumberScientific2Decimal]
        /// </summary>
        ReportFormatingNumberScientific2Decimal = 10,
        /// <summary>
        /// 11 -- en [ReportFormatingNumberScientific3Decimal] ---- fr [ReportFormatingNumberScientific3Decimal]
        /// </summary>
        ReportFormatingNumberScientific3Decimal = 11,
        /// <summary>
        /// 12 -- en [ReportFormatingNumberScientific4Decimal] ---- fr [ReportFormatingNumberScientific4Decimal]
        /// </summary>
        ReportFormatingNumberScientific4Decimal = 12,
        /// <summary>
        /// 13 -- en [ReportFormatingNumberScientific5Decimal] ---- fr [ReportFormatingNumberScientific5Decimal]
        /// </summary>
        ReportFormatingNumberScientific5Decimal = 13,
        /// <summary>
        /// 14 -- en [ReportFormatingNumberScientific6Decimal] ---- fr [ReportFormatingNumberScientific6Decimal]
        /// </summary>
        ReportFormatingNumberScientific6Decimal = 14,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum ReportSortingEnum
    ///     {
    ///         Error = 0,
    ///         ReportSortingAscending = 1,
    ///         ReportSortingDescending = 2,
    ///     }
    /// </code>
    /// </remarks>
    public enum ReportSortingEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [ReportSortingAscending] ---- fr [ReportSortingAscending]
        /// </summary>
        ReportSortingAscending = 1,
        /// <summary>
        /// 2 -- en [ReportSortingDescending] ---- fr [ReportSortingDescending]
        /// </summary>
        ReportSortingDescending = 2,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum ReportTreeNodeSubTypeEnum
    ///     {
    ///         Error = 0,
    ///         TableSelectable = 1,
    ///         Field = 2,
    ///         FieldsHolder = 3,
    ///         TableNotSelectable = 4,
    ///     }
    /// </code>
    /// </remarks>
    public enum ReportTreeNodeSubTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [TableSelectable] ---- fr [TableSelectable]
        /// </summary>
        TableSelectable = 1,
        /// <summary>
        /// 2 -- en [Field] ---- fr [Field]
        /// </summary>
        Field = 2,
        /// <summary>
        /// 3 -- en [FieldsHolder] ---- fr [FieldsHolder]
        /// </summary>
        FieldsHolder = 3,
        /// <summary>
        /// 4 -- en [TableNotSelectable] ---- fr [TableNotSelectable]
        /// </summary>
        TableNotSelectable = 4,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum ReportTreeNodeTypeEnum
    ///     {
    ///         Error = 0,
    ///         ReportRootType = 1,
    ///         ReportCountryType = 2,
    ///         ReportProvinceType = 3,
    ///         ReportAreaType = 4,
    ///         ReportSectorType = 5,
    ///         ReportSubsectorType = 6,
    ///         ReportMWQMSiteType = 7,
    ///         ReportMWQMRunType = 8,
    ///         ReportPolSourceSiteType = 9,
    ///         ReportMunicipalityType = 10,
    ///         ReportRootFileType = 11,
    ///         ReportInfrastructureType = 12,
    ///         ReportBoxModelType = 13,
    ///         ReportVisualPlumesScenarioType = 14,
    ///         ReportMikeScenarioType = 15,
    ///         ReportMikeSourceType = 16,
    ///         ReportMWQMSiteSampleType = 17,
    ///         ReportPolSourceSiteObsType = 18,
    ///         ReportPolSourceSiteObsIssueType = 19,
    ///         ReportMikeScenarioGeneralParameterType = 20,
    ///         ReportMunicipalityContactType = 21,
    ///         ReportConditionType = 22,
    ///         ReportStatisticType = 23,
    ///         ReportFieldsType = 24,
    ///         ReportFieldType = 25,
    ///         ReportPolSourceSiteAddressType = 26,
    ///         ReportMunicipalityContactTelType = 27,
    ///         ReportMunicipalityContactEmailType = 28,
    ///         ReportBoxModelResultType = 29,
    ///         ReportClimateSiteType = 30,
    ///         ReportClimateSiteDataType = 31,
    ///         ReportHydrometricSiteType = 32,
    ///         ReportHydrometricSiteDataType = 33,
    ///         ReportHydrometricSiteRatingCurveType = 34,
    ///         ReportHydrometricSiteRatingCurveValueType = 35,
    ///         ReportInfrastructureAddressType = 36,
    ///         ReportSubsectorLabSheetType = 37,
    ///         ReportSubsectorLabSheetDetailType = 38,
    ///         ReportSubsectorLabSheetTubeMPNDetailType = 39,
    ///         ReportMWQMRunSampleType = 40,
    ///         ReportCountryFileType = 41,
    ///         ReportProvinceFileType = 42,
    ///         ReportAreaFileType = 43,
    ///         ReportSectorFileType = 44,
    ///         ReportSubsectorFileType = 45,
    ///         ReportMWQMSiteFileType = 46,
    ///         ReportMWQMRunFileType = 47,
    ///         ReportPolSourceSiteFileType = 48,
    ///         ReportMunicipalityFileType = 49,
    ///         ReportInfrastructureFileType = 50,
    ///         ReportMikeScenarioFileType = 51,
    ///         ReportMikeSourceStartEndType = 52,
    ///         ReportMWQMRunLabSheetType = 53,
    ///         ReportMWQMRunLabSheetDetailType = 54,
    ///         ReportMWQMRunLabSheetTubeMPNDetailType = 55,
    ///         ReportSamplingPlanLabSheetType = 56,
    ///         ReportSamplingPlanLabSheetDetailType = 57,
    ///         ReportSamplingPlanLabSheetTubeMPNDetailType = 58,
    ///         ReportSamplingPlanType = 59,
    ///         ReportSamplingPlanSubsectorType = 60,
    ///         ReportSamplingPlanSubsectorSiteType = 61,
    ///         ReportMikeBoundaryConditionType = 62,
    ///         ReportVisualPlumesScenarioAmbientType = 63,
    ///         ReportVisualPlumesScenarioResultType = 64,
    ///         ReportMPNLookupType = 65,
    ///         ReportMWQMSiteStartAndEndType = 66,
    ///         ReportSubsectorTideSiteType = 67,
    ///         ReportSubsectorTideSiteDataType = 68,
    ///         ReportOrderType = 69,
    ///         ReportFormatType = 70,
    ///         ReportMunicipalityContactAddressType = 71,
    ///         ReportSubsectorClimateSiteType = 72,
    ///         ReportSubsectorHydrometricSiteType = 73,
    ///         ReportSubsectorHydrometricSiteDataType = 74,
    ///         ReportSubsectorHydrometricSiteRatingCurveType = 75,
    ///         ReportSubsectorClimateSiteDataType = 76,
    ///         ReportSubsectorHydrometricSiteRatingCurveValueType = 77,
    ///         ReportSubsectorSpecialTableType = 78,
    ///         ReportMikeScenarioSpecialResultKMLType = 79,
    ///     }
    /// </code>
    /// </remarks>
    public enum ReportTreeNodeTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [ReportRootType] ---- fr [ReportRootType]
        /// </summary>
        ReportRootType = 1,
        /// <summary>
        /// 2 -- en [ReportCountryType] ---- fr [ReportCountryType]
        /// </summary>
        ReportCountryType = 2,
        /// <summary>
        /// 3 -- en [ReportProvinceType] ---- fr [ReportProvinceType]
        /// </summary>
        ReportProvinceType = 3,
        /// <summary>
        /// 4 -- en [ReportAreaType] ---- fr [ReportAreaType]
        /// </summary>
        ReportAreaType = 4,
        /// <summary>
        /// 5 -- en [ReportSectorType] ---- fr [ReportSectorType]
        /// </summary>
        ReportSectorType = 5,
        /// <summary>
        /// 6 -- en [ReportSubsectorType] ---- fr [ReportSubsectorType]
        /// </summary>
        ReportSubsectorType = 6,
        /// <summary>
        /// 7 -- en [ReportMWQMSiteType] ---- fr [ReportMWQMSiteType]
        /// </summary>
        ReportMWQMSiteType = 7,
        /// <summary>
        /// 8 -- en [ReportMWQMRunType] ---- fr [ReportMWQMRunType]
        /// </summary>
        ReportMWQMRunType = 8,
        /// <summary>
        /// 9 -- en [ReportPolSourceSiteType] ---- fr [ReportPolSourceSiteType]
        /// </summary>
        ReportPolSourceSiteType = 9,
        /// <summary>
        /// 10 -- en [ReportMunicipalityType] ---- fr [ReportMunicipalityType]
        /// </summary>
        ReportMunicipalityType = 10,
        /// <summary>
        /// 11 -- en [ReportRootFileType] ---- fr [ReportRootFileType]
        /// </summary>
        ReportRootFileType = 11,
        /// <summary>
        /// 12 -- en [ReportInfrastructureType] ---- fr [ReportInfrastructureType]
        /// </summary>
        ReportInfrastructureType = 12,
        /// <summary>
        /// 13 -- en [ReportBoxModelType] ---- fr [ReportBoxModelType]
        /// </summary>
        ReportBoxModelType = 13,
        /// <summary>
        /// 14 -- en [ReportVisualPlumesScenarioType] ---- fr [ReportVisualPlumesScenarioType]
        /// </summary>
        ReportVisualPlumesScenarioType = 14,
        /// <summary>
        /// 15 -- en [ReportMikeScenarioType] ---- fr [ReportMikeScenarioType]
        /// </summary>
        ReportMikeScenarioType = 15,
        /// <summary>
        /// 16 -- en [ReportMikeSourceType] ---- fr [ReportMikeSourceType]
        /// </summary>
        ReportMikeSourceType = 16,
        /// <summary>
        /// 17 -- en [ReportMWQMSiteSampleType] ---- fr [ReportMWQMSiteSampleType]
        /// </summary>
        ReportMWQMSiteSampleType = 17,
        /// <summary>
        /// 18 -- en [ReportPolSourceSiteObsType] ---- fr [ReportPolSourceSiteObsType]
        /// </summary>
        ReportPolSourceSiteObsType = 18,
        /// <summary>
        /// 19 -- en [ReportPolSourceSiteObsIssueType] ---- fr [ReportPolSourceSiteObsIssueType]
        /// </summary>
        ReportPolSourceSiteObsIssueType = 19,
        /// <summary>
        /// 20 -- en [ReportMikeScenarioGeneralParameterType] ---- fr [ReportMikeScenarioGeneralParameterType]
        /// </summary>
        ReportMikeScenarioGeneralParameterType = 20,
        /// <summary>
        /// 21 -- en [ReportMunicipalityContactType] ---- fr [ReportMunicipalityContactType]
        /// </summary>
        ReportMunicipalityContactType = 21,
        /// <summary>
        /// 22 -- en [ReportConditionType] ---- fr [ReportConditionType]
        /// </summary>
        ReportConditionType = 22,
        /// <summary>
        /// 23 -- en [ReportStatisticType] ---- fr [ReportStatisticType]
        /// </summary>
        ReportStatisticType = 23,
        /// <summary>
        /// 24 -- en [ReportFieldsType] ---- fr [ReportFieldsType]
        /// </summary>
        ReportFieldsType = 24,
        /// <summary>
        /// 25 -- en [ReportFieldType] ---- fr [ReportFieldType]
        /// </summary>
        ReportFieldType = 25,
        /// <summary>
        /// 26 -- en [ReportPolSourceSiteAddressType] ---- fr [ReportPolSourceSiteAddressType]
        /// </summary>
        ReportPolSourceSiteAddressType = 26,
        /// <summary>
        /// 27 -- en [ReportMunicipalityContactTelType] ---- fr [ReportMunicipalityContactTelType]
        /// </summary>
        ReportMunicipalityContactTelType = 27,
        /// <summary>
        /// 28 -- en [ReportMunicipalityContactEmailType] ---- fr [ReportMunicipalityContactEmailType]
        /// </summary>
        ReportMunicipalityContactEmailType = 28,
        /// <summary>
        /// 29 -- en [ReportBoxModelResultType] ---- fr [ReportBoxModelResultType]
        /// </summary>
        ReportBoxModelResultType = 29,
        /// <summary>
        /// 30 -- en [ReportClimateSiteType] ---- fr [ReportClimateSiteType]
        /// </summary>
        ReportClimateSiteType = 30,
        /// <summary>
        /// 31 -- en [ReportClimateSiteDataType] ---- fr [ReportClimateSiteDataType]
        /// </summary>
        ReportClimateSiteDataType = 31,
        /// <summary>
        /// 32 -- en [ReportHydrometricSiteType] ---- fr [ReportHydrometricSiteType]
        /// </summary>
        ReportHydrometricSiteType = 32,
        /// <summary>
        /// 33 -- en [ReportHydrometricSiteDataType] ---- fr [ReportHydrometricSiteDataType]
        /// </summary>
        ReportHydrometricSiteDataType = 33,
        /// <summary>
        /// 34 -- en [ReportHydrometricSiteRatingCurveType] ---- fr [ReportHydrometricSiteRatingCurveType]
        /// </summary>
        ReportHydrometricSiteRatingCurveType = 34,
        /// <summary>
        /// 35 -- en [ReportHydrometricSiteRatingCurveValueType] ---- fr [ReportHydrometricSiteRatingCurveValueType]
        /// </summary>
        ReportHydrometricSiteRatingCurveValueType = 35,
        /// <summary>
        /// 36 -- en [ReportInfrastructureAddressType] ---- fr [ReportInfrastructureAddressType]
        /// </summary>
        ReportInfrastructureAddressType = 36,
        /// <summary>
        /// 37 -- en [ReportSubsectorLabSheetType] ---- fr [ReportSubsectorLabSheetType]
        /// </summary>
        ReportSubsectorLabSheetType = 37,
        /// <summary>
        /// 38 -- en [ReportSubsectorLabSheetDetailType] ---- fr [ReportSubsectorLabSheetDetailType]
        /// </summary>
        ReportSubsectorLabSheetDetailType = 38,
        /// <summary>
        /// 39 -- en [ReportSubsectorLabSheetTubeMPNDetailType] ---- fr [ReportSubsectorLabSheetTubeMPNDetailType]
        /// </summary>
        ReportSubsectorLabSheetTubeMPNDetailType = 39,
        /// <summary>
        /// 40 -- en [ReportMWQMRunSampleType] ---- fr [ReportMWQMRunSampleType]
        /// </summary>
        ReportMWQMRunSampleType = 40,
        /// <summary>
        /// 41 -- en [ReportCountryFileType] ---- fr [ReportCountryFileType]
        /// </summary>
        ReportCountryFileType = 41,
        /// <summary>
        /// 42 -- en [ReportProvinceFileType] ---- fr [ReportProvinceFileType]
        /// </summary>
        ReportProvinceFileType = 42,
        /// <summary>
        /// 43 -- en [ReportAreaFileType] ---- fr [ReportAreaFileType]
        /// </summary>
        ReportAreaFileType = 43,
        /// <summary>
        /// 44 -- en [ReportSectorFileType] ---- fr [ReportSectorFileType]
        /// </summary>
        ReportSectorFileType = 44,
        /// <summary>
        /// 45 -- en [ReportSubsectorFileType] ---- fr [ReportSubsectorFileType]
        /// </summary>
        ReportSubsectorFileType = 45,
        /// <summary>
        /// 46 -- en [ReportMWQMSiteFileType] ---- fr [ReportMWQMSiteFileType]
        /// </summary>
        ReportMWQMSiteFileType = 46,
        /// <summary>
        /// 47 -- en [ReportMWQMRunFileType] ---- fr [ReportMWQMRunFileType]
        /// </summary>
        ReportMWQMRunFileType = 47,
        /// <summary>
        /// 48 -- en [ReportPolSourceSiteFileType] ---- fr [ReportPolSourceSiteFileType]
        /// </summary>
        ReportPolSourceSiteFileType = 48,
        /// <summary>
        /// 49 -- en [ReportMunicipalityFileType] ---- fr [ReportMunicipalityFileType]
        /// </summary>
        ReportMunicipalityFileType = 49,
        /// <summary>
        /// 50 -- en [ReportInfrastructureFileType] ---- fr [ReportInfrastructureFileType]
        /// </summary>
        ReportInfrastructureFileType = 50,
        /// <summary>
        /// 51 -- en [ReportMikeScenarioFileType] ---- fr [ReportMikeScenarioFileType]
        /// </summary>
        ReportMikeScenarioFileType = 51,
        /// <summary>
        /// 52 -- en [ReportMikeSourceStartEndType] ---- fr [ReportMikeSourceStartEndType]
        /// </summary>
        ReportMikeSourceStartEndType = 52,
        /// <summary>
        /// 53 -- en [ReportMWQMRunLabSheetType] ---- fr [ReportMWQMRunLabSheetType]
        /// </summary>
        ReportMWQMRunLabSheetType = 53,
        /// <summary>
        /// 54 -- en [ReportMWQMRunLabSheetDetailType] ---- fr [ReportMWQMRunLabSheetDetailType]
        /// </summary>
        ReportMWQMRunLabSheetDetailType = 54,
        /// <summary>
        /// 55 -- en [ReportMWQMRunLabSheetTubeMPNDetailType] ---- fr [ReportMWQMRunLabSheetTubeMPNDetailType]
        /// </summary>
        ReportMWQMRunLabSheetTubeMPNDetailType = 55,
        /// <summary>
        /// 56 -- en [ReportSamplingPlanLabSheetType] ---- fr [ReportSamplingPlanLabSheetType]
        /// </summary>
        ReportSamplingPlanLabSheetType = 56,
        /// <summary>
        /// 57 -- en [ReportSamplingPlanLabSheetDetailType] ---- fr [ReportSamplingPlanLabSheetDetailType]
        /// </summary>
        ReportSamplingPlanLabSheetDetailType = 57,
        /// <summary>
        /// 58 -- en [ReportSamplingPlanLabSheetTubeMPNDetailType] ---- fr [ReportSamplingPlanLabSheetTubeMPNDetailType]
        /// </summary>
        ReportSamplingPlanLabSheetTubeMPNDetailType = 58,
        /// <summary>
        /// 59 -- en [ReportSamplingPlanType] ---- fr [ReportSamplingPlanType]
        /// </summary>
        ReportSamplingPlanType = 59,
        /// <summary>
        /// 60 -- en [ReportSamplingPlanSubsectorType] ---- fr [ReportSamplingPlanSubsectorType]
        /// </summary>
        ReportSamplingPlanSubsectorType = 60,
        /// <summary>
        /// 61 -- en [ReportSamplingPlanSubsectorSiteType] ---- fr [ReportSamplingPlanSubsectorSiteType]
        /// </summary>
        ReportSamplingPlanSubsectorSiteType = 61,
        /// <summary>
        /// 62 -- en [ReportMikeBoundaryConditionType] ---- fr [ReportMikeBoundaryConditionType]
        /// </summary>
        ReportMikeBoundaryConditionType = 62,
        /// <summary>
        /// 63 -- en [ReportVisualPlumesScenarioAmbientType] ---- fr [ReportVisualPlumesScenarioAmbientType]
        /// </summary>
        ReportVisualPlumesScenarioAmbientType = 63,
        /// <summary>
        /// 64 -- en [ReportVisualPlumesScenarioResultType] ---- fr [ReportVisualPlumesScenarioResultType]
        /// </summary>
        ReportVisualPlumesScenarioResultType = 64,
        /// <summary>
        /// 65 -- en [ReportMPNLookupType] ---- fr [ReportMPNLookupType]
        /// </summary>
        ReportMPNLookupType = 65,
        /// <summary>
        /// 66 -- en [ReportMWQMSiteStartAndEndType] ---- fr [ReportMWQMSiteStartAndEndType]
        /// </summary>
        ReportMWQMSiteStartAndEndType = 66,
        /// <summary>
        /// 67 -- en [SubsectorTideSiteType] ---- fr [SubsectorTideSiteType]
        /// </summary>
        ReportSubsectorTideSiteType = 67,
        /// <summary>
        /// 68 -- en [SubsectorTideSiteDataType] ---- fr [SubsectorTideSiteDataType]
        /// </summary>
        ReportSubsectorTideSiteDataType = 68,
        /// <summary>
        /// 69 -- en [ReportOrderType] ---- fr [ReportOrderType]
        /// </summary>
        ReportOrderType = 69,
        /// <summary>
        /// 70 -- en [ReportFormatType] ---- fr [ReportFormatType]
        /// </summary>
        ReportFormatType = 70,
        /// <summary>
        /// 71 -- en [ReportMunicipalityContactAddressType] ---- fr [ReportMunicipalityContactAddressType]
        /// </summary>
        ReportMunicipalityContactAddressType = 71,
        /// <summary>
        /// 72 -- en [SubsectorClimateSiteType] ---- fr [SubsectorClimateSiteType]
        /// </summary>
        ReportSubsectorClimateSiteType = 72,
        /// <summary>
        /// 73 -- en [SubsectorHydrometricSiteType] ---- fr [SubsectorHydrometricSiteType]
        /// </summary>
        ReportSubsectorHydrometricSiteType = 73,
        /// <summary>
        /// 74 -- en [SubsectorHydrometricSiteDataType] ---- fr [SubsectorHydrometricSiteDataType]
        /// </summary>
        ReportSubsectorHydrometricSiteDataType = 74,
        /// <summary>
        /// 75 -- en [SubsectorHydrometricSiteRatingCurveType] ---- fr [SubsectorHydrometricSiteRatingCurveType]
        /// </summary>
        ReportSubsectorHydrometricSiteRatingCurveType = 75,
        /// <summary>
        /// 76 -- en [SubsectorClimateSiteDataType] ---- fr [SubsectorClimateSiteDataType]
        /// </summary>
        ReportSubsectorClimateSiteDataType = 76,
        /// <summary>
        /// 77 -- en [SubsectorHydrometricSiteRatingCurveValueType] ---- fr [SubsectorHydrometricSiteRatingCurveValueType]
        /// </summary>
        ReportSubsectorHydrometricSiteRatingCurveValueType = 77,
        /// <summary>
        /// 78 -- en [ReportSubsectorSpecialTableType] ---- fr [ReportSubsectorSpecialTableType]
        /// </summary>
        ReportSubsectorSpecialTableType = 78,
        /// <summary>
        /// 79 -- en [ReportMikeScenarioSpecialResultKMLType] ---- fr [Type de résultat spécial du scénario MIKE raport (KML) ]
        /// </summary>
        ReportMikeScenarioSpecialResultKMLType = 79,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum SameDayNextDayEnum
    ///     {
    ///         Error = 0,
    ///         SameDay = 1,
    ///         NextDay = 2,
    ///     }
    /// </code>
    /// </remarks>
    public enum SameDayNextDayEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Same day] ---- fr [Same day (fr)]
        /// </summary>
        SameDay = 1,
        /// <summary>
        /// 2 -- en [Next day] ---- fr [Next day (fr)]
        /// </summary>
        NextDay = 2,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [MWQMRun.SampleMatrix] (CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_SampleMatrix), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum SampleMatrixEnum
    ///     {
    ///         Error = 0,
    ///         W = 1,
    ///         S = 2,
    ///         B = 3,
    ///         MPNQ = 4,
    ///         SampleMatrix5 = 5,
    ///         SampleMatrix6 = 6,
    ///         Water = 7,
    ///     }
    /// </code>
    /// </remarks>
    public enum SampleMatrixEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [W] ---- fr [W (fr)]
        /// </summary>
        W = 1,
        /// <summary>
        /// 2 -- en [S] ---- fr [S (fr)]
        /// </summary>
        S = 2,
        /// <summary>
        /// 3 -- en [B] ---- fr [B (fr)]
        /// </summary>
        B = 3,
        /// <summary>
        /// 4 -- en [MPNQ] ---- fr [MPNQ (fr)]
        /// </summary>
        MPNQ = 4,
        /// <summary>
        /// 5 -- en [Sample Matrix 5] ---- fr [Sample Matrix 5 (fr)]
        /// </summary>
        SampleMatrix5 = 5,
        /// <summary>
        /// 6 -- en [Sample Matrix 6] ---- fr [Sample Matrix 6 (fr)]
        /// </summary>
        SampleMatrix6 = 6,
        /// <summary>
        /// 7 -- en [Water] ---- fr [Water (fr)]
        /// </summary>
        Water = 7,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [MWQMRun.SampleStatus] (CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_SampleStatus), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum SampleStatusEnum
    ///     {
    ///         Error = 0,
    ///         Active = 1,
    ///         Archived = 2,
    ///         SampleStatus3 = 3,
    ///         SampleStatus4 = 4,
    ///         SampleStatus5 = 5,
    ///     }
    /// </code>
    /// </remarks>
    public enum SampleStatusEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Active] ---- fr [Active (fr)]
        /// </summary>
        Active = 1,
        /// <summary>
        /// 2 -- en [Archived] ---- fr [Archived (fr)]
        /// </summary>
        Archived = 2,
        /// <summary>
        /// 3 -- en [Sample Status 3] ---- fr [Sample Status 3 (fr)]
        /// </summary>
        SampleStatus3 = 3,
        /// <summary>
        /// 4 -- en [Sample Status 4] ---- fr [Sample Status 4 (fr)]
        /// </summary>
        SampleStatus4 = 4,
        /// <summary>
        /// 5 -- en [Sample Status 5] ---- fr [Sample Status 5 (fr)]
        /// </summary>
        SampleStatus5 = 5,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [LabSheetA1Measurement.SampleType] (CSSPModels.LabSheetA1Measurement.html#CSSPModels_LabSheetA1Measurement_SampleType), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum SampleTypeEnum
    ///     {
    ///         Error = 0,
    ///         DailyDuplicate = 101,
    ///         Infrastructure = 102,
    ///         IntertechDuplicate = 103,
    ///         IntertechRead = 104,
    ///         RainCMPRoutine = 105,
    ///         RainRun = 106,
    ///         ReopeningEmergencyRain = 107,
    ///         ReopeningSpill = 108,
    ///         Routine = 109,
    ///         Sanitary = 110,
    ///         Study = 111,
    ///     }
    /// </code>
    /// </remarks>
    public enum SampleTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 101 -- en [Daily duplicate] ---- fr [Daily duplicate (fr)]
        /// </summary>
        DailyDuplicate = 101,
        /// <summary>
        /// 102 -- en [Infrastructure] ---- fr [Infrastructure (fr)]
        /// </summary>
        Infrastructure = 102,
        /// <summary>
        /// 103 -- en [Intertech duplicate] ---- fr [Intertech duplicate (fr)]
        /// </summary>
        IntertechDuplicate = 103,
        /// <summary>
        /// 104 -- en [Intertech read] ---- fr [Intertech read (fr)]
        /// </summary>
        IntertechRead = 104,
        /// <summary>
        /// 105 -- en [Rain CMP routine] ---- fr [Rain CMP routine (fr)]
        /// </summary>
        RainCMPRoutine = 105,
        /// <summary>
        /// 106 -- en [Rain run] ---- fr [Rain run (fr)]
        /// </summary>
        RainRun = 106,
        /// <summary>
        /// 107 -- en [Reopening emergency rain] ---- fr [Reopening emergency rain (fr)]
        /// </summary>
        ReopeningEmergencyRain = 107,
        /// <summary>
        /// 108 -- en [Reopening spill] ---- fr [Reopening spill (fr)]
        /// </summary>
        ReopeningSpill = 108,
        /// <summary>
        /// 109 -- en [Routine] ---- fr [Routine (fr)]
        /// </summary>
        Routine = 109,
        /// <summary>
        /// 110 -- en [Sanitary] ---- fr [Sanitary (fr)]
        /// </summary>
        Sanitary = 110,
        /// <summary>
        /// 111 -- en [Study] ---- fr [Study (fr)]
        /// </summary>
        Study = 111,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum SamplingPlanTypeEnum
    ///     {
    ///         Error = 0,
    ///         Subsector = 1,
    ///         Municipality = 2,
    ///     }
    /// </code>
    /// </remarks>
    public enum SamplingPlanTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Subsector] ---- fr [Subsector (fr)]
        /// </summary>
        Subsector = 1,
        /// <summary>
        /// 2 -- en [Municipality] ---- fr [Municipality (fr)]
        /// </summary>
        Municipality = 2,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum ScenarioStatusEnum
    ///     {
    ///         Error = 0,
    ///         Normal = 1,
    ///         Copying = 2,
    ///         Copied = 3,
    ///         Changing = 4,
    ///         Changed = 5,
    ///         AskToRun = 6,
    ///         Running = 7,
    ///         Completed = 8,
    ///         Cancelled = 9,
    ///     }
    /// </code>
    /// </remarks>
    public enum ScenarioStatusEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Normal] ---- fr [Normal (fr)]
        /// </summary>
        Normal = 1,
        /// <summary>
        /// 2 -- en [Copying] ---- fr [Copying (fr)]
        /// </summary>
        Copying = 2,
        /// <summary>
        /// 3 -- en [Copied] ---- fr [Copied (fr)]
        /// </summary>
        Copied = 3,
        /// <summary>
        /// 4 -- en [Changing] ---- fr [Changing (fr)]
        /// </summary>
        Changing = 4,
        /// <summary>
        /// 5 -- en [Changed] ---- fr [Changed (fr)]
        /// </summary>
        Changed = 5,
        /// <summary>
        /// 6 -- en [Ask To Run] ---- fr [Ask To Run (fr)]
        /// </summary>
        AskToRun = 6,
        /// <summary>
        /// 7 -- en [Running] ---- fr [Running (fr)]
        /// </summary>
        Running = 7,
        /// <summary>
        /// 8 -- en [Completed] ---- fr [Completed (fr)]
        /// </summary>
        Completed = 8,
        /// <summary>
        /// 9 -- en [Cancelled] ---- fr [Cancelled (fr)]
        /// </summary>
        Cancelled = 9,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum SearchTagEnum
    ///     {
    ///         Error = 0,
    ///         c = 1,
    ///         e = 2,
    ///         t = 3,
    ///         fi = 4,
    ///         fp = 5,
    ///         fr = 6,
    ///         fg = 7,
    ///         fpdf = 8,
    ///         fdocx = 9,
    ///         fxlsx = 10,
    ///         fkmz = 11,
    ///         fxyz = 12,
    ///         fdfs = 13,
    ///         fmike = 14,
    ///         fmdf = 15,
    ///         fm21fm = 16,
    ///         fm3fm = 17,
    ///         fmesh = 18,
    ///         flog = 19,
    ///         ftxt = 20,
    ///         m = 21,
    ///         p = 22,
    ///         ms = 23,
    ///         cs = 24,
    ///         hs = 25,
    ///         ts = 26,
    ///         ww = 27,
    ///         ls = 28,
    ///         st = 29,
    ///         ps = 30,
    ///         a = 31,
    ///         s = 32,
    ///         ss = 33,
    ///         u = 34,
    ///         notag = 35,
    ///         fcsv = 36,
    ///     }
    /// </code>
    /// </remarks>
    public enum SearchTagEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [c] ---- fr [c]
        /// </summary>
        c = 1,
        /// <summary>
        /// 2 -- en [e] ---- fr [e]
        /// </summary>
        e = 2,
        /// <summary>
        /// 3 -- en [t] ---- fr [t]
        /// </summary>
        t = 3,
        /// <summary>
        /// 4 -- en [fi] ---- fr [fi]
        /// </summary>
        fi = 4,
        /// <summary>
        /// 5 -- en [fp] ---- fr [fp]
        /// </summary>
        fp = 5,
        /// <summary>
        /// 6 -- en [fr] ---- fr [fr]
        /// </summary>
        fr = 6,
        /// <summary>
        /// 7 -- en [fg] ---- fr [fg]
        /// </summary>
        fg = 7,
        /// <summary>
        /// 8 -- en [fpdf] ---- fr [fpdf]
        /// </summary>
        fpdf = 8,
        /// <summary>
        /// 9 -- en [fdocx] ---- fr [fdocx]
        /// </summary>
        fdocx = 9,
        /// <summary>
        /// 10 -- en [fxlsx] ---- fr [fxlsx]
        /// </summary>
        fxlsx = 10,
        /// <summary>
        /// 11 -- en [fkmz] ---- fr [fkmz]
        /// </summary>
        fkmz = 11,
        /// <summary>
        /// 12 -- en [fxyz] ---- fr [fxyz]
        /// </summary>
        fxyz = 12,
        /// <summary>
        /// 13 -- en [fdfs] ---- fr [fdfs]
        /// </summary>
        fdfs = 13,
        /// <summary>
        /// 14 -- en [fmike] ---- fr [fmike]
        /// </summary>
        fmike = 14,
        /// <summary>
        /// 15 -- en [fmdf] ---- fr [fmdf]
        /// </summary>
        fmdf = 15,
        /// <summary>
        /// 16 -- en [fm21fm] ---- fr [fm21fm]
        /// </summary>
        fm21fm = 16,
        /// <summary>
        /// 17 -- en [fm3fm] ---- fr [fm3fm]
        /// </summary>
        fm3fm = 17,
        /// <summary>
        /// 18 -- en [fmesh] ---- fr [fmesh]
        /// </summary>
        fmesh = 18,
        /// <summary>
        /// 19 -- en [flog] ---- fr [flog]
        /// </summary>
        flog = 19,
        /// <summary>
        /// 20 -- en [ftxt] ---- fr [ftxt]
        /// </summary>
        ftxt = 20,
        /// <summary>
        /// 21 -- en [m] ---- fr [m]
        /// </summary>
        m = 21,
        /// <summary>
        /// 22 -- en [p] ---- fr [p]
        /// </summary>
        p = 22,
        /// <summary>
        /// 23 -- en [ms] ---- fr [ms]
        /// </summary>
        ms = 23,
        /// <summary>
        /// 24 -- en [cs] ---- fr [cs]
        /// </summary>
        cs = 24,
        /// <summary>
        /// 25 -- en [hs] ---- fr [hs]
        /// </summary>
        hs = 25,
        /// <summary>
        /// 26 -- en [ts] ---- fr [ts]
        /// </summary>
        ts = 26,
        /// <summary>
        /// 27 -- en [ww] ---- fr [ww]
        /// </summary>
        ww = 27,
        /// <summary>
        /// 28 -- en [ls] ---- fr [ls]
        /// </summary>
        ls = 28,
        /// <summary>
        /// 29 -- en [st] ---- fr [st]
        /// </summary>
        st = 29,
        /// <summary>
        /// 30 -- en [ps] ---- fr [ps]
        /// </summary>
        ps = 30,
        /// <summary>
        /// 31 -- en [a] ---- fr [a]
        /// </summary>
        a = 31,
        /// <summary>
        /// 32 -- en [s] ---- fr [s]
        /// </summary>
        s = 32,
        /// <summary>
        /// 33 -- en [ss] ---- fr [ss]
        /// </summary>
        ss = 33,
        /// <summary>
        /// 34 -- en [u] ---- fr [u]
        /// </summary>
        u = 34,
        /// <summary>
        /// 35 -- en [notag] ---- fr [notag]
        /// </summary>
        notag = 35,
        /// <summary>
        /// 36 -- en [fcsv] ---- fr [fcsv]
        /// </summary>
        fcsv = 36,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [Infrastructure.SecondaryTreatmentType] (CSSPModels.Infrastructure.html#CSSPModels_Infrastructure_SecondaryTreatmentType), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum SecondaryTreatmentTypeEnum
    ///     {
    ///         Error = 0,
    ///         NotApplicable = 1,
    ///         RotatingBiologicalContactor = 2,
    ///         TricklingFilters = 3,
    ///         SequencingBatchReator = 4,
    ///         OxidationDitch = 5,
    ///     }
    /// </code>
    /// </remarks>
    public enum SecondaryTreatmentTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Not applicable] ---- fr [Not applicable (fr)]
        /// </summary>
        NotApplicable = 1,
        /// <summary>
        /// 2 -- en [Rotating Biological Contactor (RBC)] ---- fr [Rotating Biological Contactor (RBC) (fr)]
        /// </summary>
        RotatingBiologicalContactor = 2,
        /// <summary>
        /// 3 -- en [Trickling filters] ---- fr [Trickling filters (fr)]
        /// </summary>
        TricklingFilters = 3,
        /// <summary>
        /// 4 -- en [Sequencing Batch Reator (SBR)] ---- fr [Sequencing Batch Reator (SBR) (fr)]
        /// </summary>
        SequencingBatchReator = 4,
        /// <summary>
        /// 5 -- en [Oxidation Ditch] ---- fr [Oxidation Ditch (fr)]
        /// </summary>
        OxidationDitch = 5,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum SiteTypeEnum
    ///     {
    ///         Error = 0,
    ///         Climate = 1,
    ///         Hydrometric = 2,
    ///         Tide = 3,
    ///     }
    /// </code>
    /// </remarks>
    public enum SiteTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Climate] ---- fr [Climate (fr)]
        /// </summary>
        Climate = 1,
        /// <summary>
        /// 2 -- en [Hydrometric] ---- fr [Hydrometric (fr)]
        /// </summary>
        Hydrometric = 2,
        /// <summary>
        /// 3 -- en [Tide] ---- fr [Tide (fr)]
        /// </summary>
        Tide = 3,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum SpecialTableTypeEnum
    ///     {
    ///         Error = 0,
    ///         FCDensitiesTable = 1,
    ///         SalinityTable = 2,
    ///         TemperatureTable = 3,
    ///         GeometricMeanTable = 4,
    ///         MedianTable = 5,
    ///         P90Table = 6,
    ///         PercentOver43Table = 7,
    ///         PercentOver260Table = 8,
    ///     }
    /// </code>
    /// </remarks>
    public enum SpecialTableTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [FCDensitiesTable] ---- fr [FCDensitiesTable]
        /// </summary>
        FCDensitiesTable = 1,
        /// <summary>
        /// 2 -- en [SalinityTable] ---- fr [SalinityTable]
        /// </summary>
        SalinityTable = 2,
        /// <summary>
        /// 3 -- en [TemperatureTable] ---- fr [TemperatureTable]
        /// </summary>
        TemperatureTable = 3,
        /// <summary>
        /// 4 -- en [GeometricMeanTable] ---- fr [GeometricMeanTable]
        /// </summary>
        GeometricMeanTable = 4,
        /// <summary>
        /// 5 -- en [MedianTable] ---- fr [MedianTable]
        /// </summary>
        MedianTable = 5,
        /// <summary>
        /// 6 -- en [P90Table] ---- fr [P90Table]
        /// </summary>
        P90Table = 6,
        /// <summary>
        /// 7 -- en [PercentOver43Table] ---- fr [PercentOver43Table]
        /// </summary>
        PercentOver43Table = 7,
        /// <summary>
        /// 8 -- en [PercentOver260Table] ---- fr [PercentOver260Table]
        /// </summary>
        PercentOver260Table = 8,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum StorageDataTypeEnum
    ///     {
    ///         Error = 0,
    ///         Archived = 1,
    ///         Forcasted = 2,
    ///         Observed = 3,
    ///     }
    /// </code>
    /// </remarks>
    public enum StorageDataTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Archived] ---- fr [Archived (fr)]
        /// </summary>
        Archived = 1,
        /// <summary>
        /// 2 -- en [Forcasted] ---- fr [Forcasted (fr)]
        /// </summary>
        Forcasted = 2,
        /// <summary>
        /// 3 -- en [Observed] ---- fr [Observed (fr)]
        /// </summary>
        Observed = 3,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [Address.StreetType] (CSSPModels.Address.html#CSSPModels_Address_StreetType), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum StreetTypeEnum
    ///     {
    ///         Error = 0,
    ///         Street = 1,
    ///         Road = 2,
    ///         Avenue = 3,
    ///         Crescent = 4,
    ///         Court = 5,
    ///         Alley = 6,
    ///         Drive = 7,
    ///         Blvd = 8,
    ///         Route = 9,
    ///     }
    /// </code>
    /// </remarks>
    public enum StreetTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Street] ---- fr [Rue]
        /// </summary>
        Street = 1,
        /// <summary>
        /// 2 -- en [Road] ---- fr [Chemin]
        /// </summary>
        Road = 2,
        /// <summary>
        /// 3 -- en [Avenue] ---- fr [Avenue]
        /// </summary>
        Avenue = 3,
        /// <summary>
        /// 4 -- en [Crescent] ---- fr [Croissant]
        /// </summary>
        Crescent = 4,
        /// <summary>
        /// 5 -- en [Court] ---- fr [Ruelle]
        /// </summary>
        Court = 5,
        /// <summary>
        /// 6 -- en [Alley] ---- fr [Allée]
        /// </summary>
        Alley = 6,
        /// <summary>
        /// 7 -- en [Drive] ---- fr [Promenade]
        /// </summary>
        Drive = 7,
        /// <summary>
        /// 8 -- en [Boulevard] ---- fr [Boulevard]
        /// </summary>
        Blvd = 8,
        /// <summary>
        /// 9 -- en [Route] ---- fr [Route (fr)]
        /// </summary>
        Route = 9,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum TelTypeEnum
    ///     {
    ///         Error = 0,
    ///         Personal = 1,
    ///         Work = 2,
    ///         Mobile = 3,
    ///         Personal2 = 4,
    ///         Work2 = 5,
    ///         Mobile2 = 6,
    ///     }
    /// </code>
    /// </remarks>
    public enum TelTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Personal] ---- fr [Personnel]
        /// </summary>
        Personal = 1,
        /// <summary>
        /// 2 -- en [Work] ---- fr [Travail]
        /// </summary>
        Work = 2,
        /// <summary>
        /// 3 -- en [Mobile] ---- fr [Cellulaire]
        /// </summary>
        Mobile = 3,
        /// <summary>
        /// 4 -- en [Personal-2] ---- fr [Personnel-2]
        /// </summary>
        Personal2 = 4,
        /// <summary>
        /// 5 -- en [Work-2] ---- fr [Travail-2]
        /// </summary>
        Work2 = 5,
        /// <summary>
        /// 6 -- en [Mobile-2] ---- fr [Cellulaire-2]
        /// </summary>
        Mobile2 = 6,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [Infrastructure.TertiaryTreatmentType] (CSSPModels.Infrastructure.html#CSSPModels_Infrastructure_TertiaryTreatmentType), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum TertiaryTreatmentTypeEnum
    ///     {
    ///         Error = 0,
    ///         NotApplicable = 1,
    ///         Adsorption = 2,
    ///         Flocculation = 3,
    ///         MembraneFiltration = 4,
    ///         IonExchange = 5,
    ///         ReverseOsmosis = 6,
    ///         BiologicalNutrientRemoval = 7,
    ///     }
    /// </code>
    /// </remarks>
    public enum TertiaryTreatmentTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Not applicable] ---- fr [Not applicable (fr)]
        /// </summary>
        NotApplicable = 1,
        /// <summary>
        /// 2 -- en [Adsorption] ---- fr [Adsorption (fr)]
        /// </summary>
        Adsorption = 2,
        /// <summary>
        /// 3 -- en [Flocculation] ---- fr [Flocculation (fr)]
        /// </summary>
        Flocculation = 3,
        /// <summary>
        /// 4 -- en [Membrane filtration] ---- fr [Membrane filtration (fr)]
        /// </summary>
        MembraneFiltration = 4,
        /// <summary>
        /// 5 -- en [Ion exchange] ---- fr [Ion exchange (fr)]
        /// </summary>
        IonExchange = 5,
        /// <summary>
        /// 6 -- en [Reverse osmosis] ---- fr [Reverse osmosis (fr)]
        /// </summary>
        ReverseOsmosis = 6,
        /// <summary>
        /// 7 -- en [Biological Nutrient Removal (BNR)] ---- fr [Biological Nutrient Removal (BNR) (fr)]
        /// </summary>
        BiologicalNutrientRemoval = 7,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum TideDataTypeEnum
    ///     {
    ///         Error = 0,
    ///         Min15 = 1,
    ///         Min60 = 2,
    ///     }
    /// </code>
    /// </remarks>
    public enum TideDataTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Min15] ---- fr [Min15]
        /// </summary>
        Min15 = 1,
        /// <summary>
        /// 2 -- en [Min60] ---- fr [Min60]
        /// </summary>
        Min60 = 2,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [MWQMRun.Tide_Start] (CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_Tide_Start), [MWQMRun.Tide_End] (CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_Tide_End), [TideDataValue.TideStart] (CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_TideStart), [TideDataValue.TideEnd] (CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_TideEnd), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum TideTextEnum
    ///     {
    ///         Error = 0,
    ///         LowTide = 1,
    ///         LowTideFalling = 2,
    ///         LowTideRising = 3,
    ///         MidTide = 4,
    ///         MidTideFalling = 5,
    ///         MidTideRising = 6,
    ///         HighTide = 7,
    ///         HighTideFalling = 8,
    ///         HighTideRising = 9,
    ///     }
    /// </code>
    /// </remarks>
    public enum TideTextEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Low Tide] ---- fr [Low Tide (fr)]
        /// </summary>
        LowTide = 1,
        /// <summary>
        /// 2 -- en [Low Tide Falling] ---- fr [Low Tide Falling (fr)]
        /// </summary>
        LowTideFalling = 2,
        /// <summary>
        /// 3 -- en [Low Tide Rising] ---- fr [Low Tide Rising (fr)]
        /// </summary>
        LowTideRising = 3,
        /// <summary>
        /// 4 -- en [Mid Tide] ---- fr [Mid Tide (fr)]
        /// </summary>
        MidTide = 4,
        /// <summary>
        /// 5 -- en [Mid Tide Falling] ---- fr [Mid Tide Falling (fr)]
        /// </summary>
        MidTideFalling = 5,
        /// <summary>
        /// 6 -- en [Mid Tide Rising] ---- fr [Mid Tide Rising (fr)]
        /// </summary>
        MidTideRising = 6,
        /// <summary>
        /// 7 -- en [High Tide] ---- fr [High Tide (fr)]
        /// </summary>
        HighTide = 7,
        /// <summary>
        /// 8 -- en [High Tide Falling] ---- fr [High Tide Falling (fr)]
        /// </summary>
        HighTideFalling = 8,
        /// <summary>
        /// 9 -- en [High Tide Rising] ---- fr [High Tide Rising (fr)]
        /// </summary>
        HighTideRising = 9,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum TranslationStatusEnum
    ///     {
    ///         Error = 0,
    ///         NotTranslated = 1,
    ///         ElectronicallyTranslated = 2,
    ///         Translated = 3,
    ///     }
    /// </code>
    /// </remarks>
    public enum TranslationStatusEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Not Translated] ---- fr [Not Translated (fr)]
        /// </summary>
        NotTranslated = 1,
        /// <summary>
        /// 2 -- en [Electronically Translated] ---- fr [Electronically Translated (fr)]
        /// </summary>
        ElectronicallyTranslated = 2,
        /// <summary>
        /// 3 -- en [Translated] ---- fr [Translated (fr)]
        /// </summary>
        Translated = 3,
    }
    /// <summary>
    /// <para>**Used by CSSPModels:** [Infrastructure.TreatmentType] (CSSPModels.Infrastructure.html#CSSPModels_Infrastructure_TreatmentType), </para>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum TreatmentTypeEnum
    ///     {
    ///         Error = 0,
    ///         ActivatedSludge = 1,
    ///         ActivatedSludgeWithBiofilter = 2,
    ///         LagoonNoAeration1Cell = 3,
    ///         LagoonNoAeration2Cell = 4,
    ///         LagoonNoAeration3Cell = 5,
    ///         LagoonNoAeration4Cell = 6,
    ///         LagoonNoAeration5Cell = 7,
    ///         LagoonWithAeration1Cell = 8,
    ///         LagoonWithAeration2Cell = 9,
    ///         LagoonWithAeration3Cell = 10,
    ///         LagoonWithAeration4Cell = 11,
    ///         LagoonWithAeration5Cell = 12,
    ///         LagoonWithAeration6Cell = 13,
    ///         StabalizingPondOnly = 14,
    ///         OxidationDitchOnly = 15,
    ///         CirculatingFluidizedBed = 16,
    ///         TricklingFilter = 17,
    ///         RecirculatingSandFilter = 18,
    ///         TrashRackRakeOnly = 19,
    ///         SepticTank = 20,
    ///         Secondary = 21,
    ///         Tertiary = 22,
    ///         VolumeFermenter = 23,
    ///         BioFilmReactor = 24,
    ///         BioGreen = 25,
    ///         BioDisks = 26,
    ///         ChemicalPrimary = 27,
    ///         Chromoglass = 28,
    ///         Primary = 29,
    ///         SequencingBatchReactor = 30,
    ///         PeatSystem = 31,
    ///         Physicochimique = 32,
    ///         RotatingBiologicalContactor = 33,
    ///     }
    /// </code>
    /// </remarks>
    public enum TreatmentTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Activated Sludge] ---- fr [Activated Sludge (fr)]
        /// </summary>
        ActivatedSludge = 1,
        /// <summary>
        /// 2 -- en [Activated Sludge With Biofilter] ---- fr [Activated Sludge With Biofilter (fr)]
        /// </summary>
        ActivatedSludgeWithBiofilter = 2,
        /// <summary>
        /// 3 -- en [Lagoon No Aeration 1 Cell] ---- fr [Lagoon No Aeration 1 Cell (fr)]
        /// </summary>
        LagoonNoAeration1Cell = 3,
        /// <summary>
        /// 4 -- en [Lagoon No Aeration 2 Cell] ---- fr [Lagoon No Aeration 2 Cell (fr)]
        /// </summary>
        LagoonNoAeration2Cell = 4,
        /// <summary>
        /// 5 -- en [Lagoon No Aeration 3 Cell] ---- fr [Lagoon No Aeration 3 Cell (fr)]
        /// </summary>
        LagoonNoAeration3Cell = 5,
        /// <summary>
        /// 6 -- en [Lagoon No Aeration 4 Cell] ---- fr [Lagoon No Aeration 4 Cell (fr)]
        /// </summary>
        LagoonNoAeration4Cell = 6,
        /// <summary>
        /// 7 -- en [Lagoon No Aeration 5 Cell] ---- fr [Lagoon No Aeration 5 Cell (fr)]
        /// </summary>
        LagoonNoAeration5Cell = 7,
        /// <summary>
        /// 8 -- en [Lagoon With Aeration 1 Cell] ---- fr [Lagoon With Aeration 1 Cell (fr)]
        /// </summary>
        LagoonWithAeration1Cell = 8,
        /// <summary>
        /// 9 -- en [Lagoon With Aeration 2 Cell] ---- fr [Lagoon With Aeration 2 Cell (fr)]
        /// </summary>
        LagoonWithAeration2Cell = 9,
        /// <summary>
        /// 10 -- en [Lagoon With Aeration 3 Cell] ---- fr [Lagoon With Aeration 3 Cell (fr)]
        /// </summary>
        LagoonWithAeration3Cell = 10,
        /// <summary>
        /// 11 -- en [Lagoon With Aeration 4 Cell] ---- fr [Lagoon With Aeration 4 Cell (fr)]
        /// </summary>
        LagoonWithAeration4Cell = 11,
        /// <summary>
        /// 12 -- en [Lagoon With Aeration 5 Cell] ---- fr [Lagoon With Aeration 5 Cell (fr)]
        /// </summary>
        LagoonWithAeration5Cell = 12,
        /// <summary>
        /// 13 -- en [Lagoon With Aeration 6 Cell] ---- fr [Lagoon With Aeration 6 Cell (fr)]
        /// </summary>
        LagoonWithAeration6Cell = 13,
        /// <summary>
        /// 14 -- en [Stabalizing Pond Only] ---- fr [Stabalizing Pond Only (fr)]
        /// </summary>
        StabalizingPondOnly = 14,
        /// <summary>
        /// 15 -- en [Oxidation Ditch Only] ---- fr [Oxidation Ditch Only (fr)]
        /// </summary>
        OxidationDitchOnly = 15,
        /// <summary>
        /// 16 -- en [Circulating Fluidized Bed] ---- fr [Circulating Fluidized Bed (fr)]
        /// </summary>
        CirculatingFluidizedBed = 16,
        /// <summary>
        /// 17 -- en [Trickling Filter] ---- fr [Trickling Filter (fr)]
        /// </summary>
        TricklingFilter = 17,
        /// <summary>
        /// 18 -- en [Recirculating Sand Filter] ---- fr [Recirculating Sand Filter (fr)]
        /// </summary>
        RecirculatingSandFilter = 18,
        /// <summary>
        /// 19 -- en [Trash Rack Rake Only] ---- fr [Trash Rack Rake Only (fr)]
        /// </summary>
        TrashRackRakeOnly = 19,
        /// <summary>
        /// 20 -- en [Septic Tank] ---- fr [Septic Tank (fr)]
        /// </summary>
        SepticTank = 20,
        /// <summary>
        /// 21 -- en [Secondary] ---- fr [Secondary (fr)]
        /// </summary>
        Secondary = 21,
        /// <summary>
        /// 22 -- en [Tertiary] ---- fr [Tertiary (fr)]
        /// </summary>
        Tertiary = 22,
        /// <summary>
        /// 23 -- en [Volume Fermenter] ---- fr [Volume Fermenter (fr)]
        /// </summary>
        VolumeFermenter = 23,
        /// <summary>
        /// 24 -- en [Bio Film Reactor] ---- fr [Bio Film Reactor (fr)]
        /// </summary>
        BioFilmReactor = 24,
        /// <summary>
        /// 25 -- en [Bio Green] ---- fr [Bio Green (fr)]
        /// </summary>
        BioGreen = 25,
        /// <summary>
        /// 26 -- en [Bio Disks] ---- fr [Bio Disks (fr)]
        /// </summary>
        BioDisks = 26,
        /// <summary>
        /// 27 -- en [Chemical Primary] ---- fr [Chemical Primary (fr)]
        /// </summary>
        ChemicalPrimary = 27,
        /// <summary>
        /// 28 -- en [Chromoglass] ---- fr [Chromoglass (fr)]
        /// </summary>
        Chromoglass = 28,
        /// <summary>
        /// 29 -- en [Primary] ---- fr [Primary (fr)]
        /// </summary>
        Primary = 29,
        /// <summary>
        /// 30 -- en [Sequencing Batch Reactor] ---- fr [Sequencing Batch Reactor (fr)]
        /// </summary>
        SequencingBatchReactor = 30,
        /// <summary>
        /// 31 -- en [Peat System] ---- fr [Peat System (fr)]
        /// </summary>
        PeatSystem = 31,
        /// <summary>
        /// 32 -- en [Physicochimique] ---- fr [Physicochimique (fr)]
        /// </summary>
        Physicochimique = 32,
        /// <summary>
        /// 33 -- en [Rotating Biological Contactor] ---- fr [Rotating Biological Contactor (fr)]
        /// </summary>
        RotatingBiologicalContactor = 33,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum TVAuthEnum
    ///     {
    ///         Error = 0,
    ///         NoAccess = 1,
    ///         Read = 2,
    ///         Write = 3,
    ///         Create = 4,
    ///         Delete = 5,
    ///         Admin = 6,
    ///     }
    /// </code>
    /// </remarks>
    public enum TVAuthEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [No access] ---- fr [No access (fr)]
        /// </summary>
        NoAccess = 1,
        /// <summary>
        /// 2 -- en [Read] ---- fr [Read (fr)]
        /// </summary>
        Read = 2,
        /// <summary>
        /// 3 -- en [Write] ---- fr [Write (fr)]
        /// </summary>
        Write = 3,
        /// <summary>
        /// 4 -- en [Create] ---- fr [Create (fr)]
        /// </summary>
        Create = 4,
        /// <summary>
        /// 5 -- en [Delete] ---- fr [Delete (fr)]
        /// </summary>
        Delete = 5,
        /// <summary>
        /// 6 -- en [Admin] ---- fr [Admin (fr)]
        /// </summary>
        Admin = 6,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum TVTypeEnum
    ///     {
    ///         Error = 0,
    ///         Root = 1,
    ///         Address = 2,
    ///         Area = 3,
    ///         ClimateSite = 4,
    ///         Contact = 5,
    ///         Country = 6,
    ///         Email = 7,
    ///         File = 8,
    ///         HydrometricSite = 9,
    ///         Infrastructure = 10,
    ///         MikeBoundaryConditionWebTide = 11,
    ///         MikeBoundaryConditionMesh = 12,
    ///         MikeScenario = 13,
    ///         MikeSource = 14,
    ///         Municipality = 15,
    ///         MWQMSite = 16,
    ///         PolSourceSite = 17,
    ///         Province = 18,
    ///         Sector = 19,
    ///         Subsector = 20,
    ///         Tel = 21,
    ///         TideSite = 22,
    ///         MWQMSiteSample = 23,
    ///         WasteWaterTreatmentPlant = 24,
    ///         LiftStation = 25,
    ///         Spill = 26,
    ///         BoxModel = 27,
    ///         VisualPlumesScenario = 28,
    ///         Outfall = 29,
    ///         OtherInfrastructure = 30,
    ///         MWQMRun = 31,
    ///         NoDepuration = 33,
    ///         Failed = 34,
    ///         Passed = 35,
    ///         NoData = 36,
    ///         LessThan10 = 37,
    ///         MeshNode = 38,
    ///         WebTideNode = 39,
    ///         SamplingPlan = 40,
    ///         SeeOther = 41,
    ///         LineOverflow = 42,
    ///         BoxModelInputs = 43,
    ///         BoxModelResults = 44,
    ///         ClimateSiteInfo = 45,
    ///         ClimateSiteData = 46,
    ///         HydrometricSiteInfo = 47,
    ///         HydrometricSiteData = 48,
    ///         InfrastructureInfo = 49,
    ///         LabSheetInfo = 50,
    ///         LabSheetDetailInfo = 51,
    ///         MapInfo = 52,
    ///         MapInfoPoint = 53,
    ///         MikeSourceStartEndInfo = 54,
    ///         MWQMLookupMPNInfo = 55,
    ///         SamplingPlanInfo = 56,
    ///         SamplingPlanSubsectorInfo = 57,
    ///         SamplingPlanSubsectorSiteInfo = 58,
    ///         MWQMSiteStartEndInfo = 59,
    ///         MWQMSubsectorInfo = 60,
    ///         PolSourceSiteInfo = 61,
    ///         PolSourceSiteObsInfo = 62,
    ///         HydrometricRatingCurveInfo = 63,
    ///         HydrometricRatingCurveDataInfo = 64,
    ///         TideLocationInfo = 65,
    ///         TideSiteDataInfo = 66,
    ///         UseOfSite = 67,
    ///         VisualPlumesScenarioInfo = 68,
    ///         VisualPlumesScenarioAmbient = 69,
    ///         VisualPlumesScenarioResults = 70,
    ///         TotalFile = 71,
    ///         MikeSourceIsRiver = 72,
    ///         MikeSourceIncluded = 73,
    ///         MikeSourceNotIncluded = 74,
    ///     }
    /// </code>
    /// </remarks>
    public enum TVTypeEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Root] ---- fr [Base]
        /// </summary>
        Root = 1,
        /// <summary>
        /// 2 -- en [Address] ---- fr [Adresse]
        /// </summary>
        Address = 2,
        /// <summary>
        /// 3 -- en [Area] ---- fr [Région]
        /// </summary>
        Area = 3,
        /// <summary>
        /// 4 -- en [Climate Site] ---- fr [Climate Site (fr)]
        /// </summary>
        ClimateSite = 4,
        /// <summary>
        /// 5 -- en [Contact] ---- fr [Contact (fr)]
        /// </summary>
        Contact = 5,
        /// <summary>
        /// 6 -- en [Country] ---- fr [Pays]
        /// </summary>
        Country = 6,
        /// <summary>
        /// 7 -- en [Email] ---- fr [Courriel]
        /// </summary>
        Email = 7,
        /// <summary>
        /// 8 -- en [File] ---- fr [Fichier]
        /// </summary>
        File = 8,
        /// <summary>
        /// 9 -- en [Hydrometric Site] ---- fr [Poste hydrométrique]
        /// </summary>
        HydrometricSite = 9,
        /// <summary>
        /// 10 -- en [Infrastructure] ---- fr [Infrastructure]
        /// </summary>
        Infrastructure = 10,
        /// <summary>
        /// 11 -- en [Mike Boundary Condition Web Tide] ---- fr [Mike Boundary Condition Web Tide (fr)]
        /// </summary>
        MikeBoundaryConditionWebTide = 11,
        /// <summary>
        /// 12 -- en [Mike Boundary Condition Mesh] ---- fr [Mike Boundary Condition Mesh (fr)]
        /// </summary>
        MikeBoundaryConditionMesh = 12,
        /// <summary>
        /// 13 -- en [Mike Scenario] ---- fr [Scénario MIKE]
        /// </summary>
        MikeScenario = 13,
        /// <summary>
        /// 14 -- en [Mike Source] ---- fr [Source MIKE]
        /// </summary>
        MikeSource = 14,
        /// <summary>
        /// 15 -- en [Municipality] ---- fr [Municipalité]
        /// </summary>
        Municipality = 15,
        /// <summary>
        /// 16 -- en [MWQM Site] ---- fr [MWQM Site (fr)]
        /// </summary>
        MWQMSite = 16,
        /// <summary>
        /// 17 -- en [Pollution Source Site] ---- fr [Site de la source de pollution]
        /// </summary>
        PolSourceSite = 17,
        /// <summary>
        /// 18 -- en [Province] ---- fr [Province ]
        /// </summary>
        Province = 18,
        /// <summary>
        /// 19 -- en [Sector] ---- fr [Secteur]
        /// </summary>
        Sector = 19,
        /// <summary>
        /// 20 -- en [Subsector] ---- fr [Sous-secteur]
        /// </summary>
        Subsector = 20,
        /// <summary>
        /// 21 -- en [Tel] ---- fr [Tél]
        /// </summary>
        Tel = 21,
        /// <summary>
        /// 22 -- en [Tide Site] ---- fr [Poste de marée]
        /// </summary>
        TideSite = 22,
        /// <summary>
        /// 23 -- en [MWQM Site Sample] ---- fr [MWQM Site Sample (fr)]
        /// </summary>
        MWQMSiteSample = 23,
        /// <summary>
        /// 24 -- en [Waste Water Treatment Plant] ---- fr [Usine de traitement de eaux usées]
        /// </summary>
        WasteWaterTreatmentPlant = 24,
        /// <summary>
        /// 25 -- en [Lift Station] ---- fr [Poste de pompage]
        /// </summary>
        LiftStation = 25,
        /// <summary>
        /// 26 -- en [Spill] ---- fr [Déversement]
        /// </summary>
        Spill = 26,
        /// <summary>
        /// 27 -- en [Box Model] ---- fr [Box Model]
        /// </summary>
        BoxModel = 27,
        /// <summary>
        /// 28 -- en [Visual Plumes Scenario] ---- fr [Scénario Visual Plumes]
        /// </summary>
        VisualPlumesScenario = 28,
        /// <summary>
        /// 29 -- en [Outfall] ---- fr [Émissaire]
        /// </summary>
        Outfall = 29,
        /// <summary>
        /// 30 -- en [Other Infrastructure] ---- fr [Other Infrastructure (fr)]
        /// </summary>
        OtherInfrastructure = 30,
        /// <summary>
        /// 31 -- en [MWQM Run] ---- fr [MWQM Run (fr)]
        /// </summary>
        MWQMRun = 31,
        /// <summary>
        /// 33 -- en [No Depuration] ---- fr [No Depuration (fr)]
        /// </summary>
        NoDepuration = 33,
        /// <summary>
        /// 34 -- en [Failed] ---- fr [Échec]
        /// </summary>
        Failed = 34,
        /// <summary>
        /// 35 -- en [Passed] ---- fr [Réussi]
        /// </summary>
        Passed = 35,
        /// <summary>
        /// 36 -- en [No Data] ---- fr [Aucune donnée]
        /// </summary>
        NoData = 36,
        /// <summary>
        /// 37 -- en [Less Than 10 Samples] ---- fr [Less Than 10 Samples (fr)]
        /// </summary>
        LessThan10 = 37,
        /// <summary>
        /// 38 -- en [Mesh Node] ---- fr [Mesh Node (fr)]
        /// </summary>
        MeshNode = 38,
        /// <summary>
        /// 39 -- en [Web Tide Node] ---- fr [Web Tide Node (fr)]
        /// </summary>
        WebTideNode = 39,
        /// <summary>
        /// 40 -- en [MWQM Plan] ---- fr [MWQM Plan (fr)]
        /// </summary>
        SamplingPlan = 40,
        /// <summary>
        /// 41 -- en [See other] ---- fr [See other (fr)]
        /// </summary>
        SeeOther = 41,
        /// <summary>
        /// 42 -- en [Line overflow] ---- fr [Line overflow (fr)]
        /// </summary>
        LineOverflow = 42,
        /// <summary>
        /// 43 -- en [Box Model Inputs] ---- fr [Box Model Inputs (fr)]
        /// </summary>
        BoxModelInputs = 43,
        /// <summary>
        /// 44 -- en [Box Model Results] ---- fr [Box Model Results (fr)]
        /// </summary>
        BoxModelResults = 44,
        /// <summary>
        /// 45 -- en [Climate Site Info] ---- fr [Climate Site Info (fr)]
        /// </summary>
        ClimateSiteInfo = 45,
        /// <summary>
        /// 46 -- en [Climate Site Data] ---- fr [Climate Site Data (fr)]
        /// </summary>
        ClimateSiteData = 46,
        /// <summary>
        /// 47 -- en [Hydrometric Site Info] ---- fr [Hydrometric Site Info (fr)]
        /// </summary>
        HydrometricSiteInfo = 47,
        /// <summary>
        /// 48 -- en [Hydrometric Site Data] ---- fr [Hydrometric Site Data (fr)]
        /// </summary>
        HydrometricSiteData = 48,
        /// <summary>
        /// 49 -- en [Infrastructure Info] ---- fr [Infrastructure Info (fr)]
        /// </summary>
        InfrastructureInfo = 49,
        /// <summary>
        /// 50 -- en [Lab Sheet Info] ---- fr [Lab Sheet Info (fr)]
        /// </summary>
        LabSheetInfo = 50,
        /// <summary>
        /// 51 -- en [Lab Sheet Detail Info] ---- fr [Lab Sheet Detail Info (fr)]
        /// </summary>
        LabSheetDetailInfo = 51,
        /// <summary>
        /// 52 -- en [Map Info] ---- fr [Map Info (fr)]
        /// </summary>
        MapInfo = 52,
        /// <summary>
        /// 53 -- en [Map Info Point] ---- fr [Map Info Point (fr)]
        /// </summary>
        MapInfoPoint = 53,
        /// <summary>
        /// 54 -- en [Mike Source Start End Info] ---- fr [Mike Source Start End Info (fr)]
        /// </summary>
        MikeSourceStartEndInfo = 54,
        /// <summary>
        /// 55 -- en [MWQM Lookup MPN Info] ---- fr [MWQM Lookup MPN Info (fr)]
        /// </summary>
        MWQMLookupMPNInfo = 55,
        /// <summary>
        /// 56 -- en [MWQM Plan Info] ---- fr [MWQM Plan Info (fr)]
        /// </summary>
        SamplingPlanInfo = 56,
        /// <summary>
        /// 57 -- en [MWQM Plan Subsector Info] ---- fr [MWQM Plan Subsector Info (fr)]
        /// </summary>
        SamplingPlanSubsectorInfo = 57,
        /// <summary>
        /// 58 -- en [MWQM Plan Subsector Site Info] ---- fr [MWQM Plan Subsector Site Info (fr)]
        /// </summary>
        SamplingPlanSubsectorSiteInfo = 58,
        /// <summary>
        /// 59 -- en [MWQM Site Start End Info] ---- fr [MWQM Site Start End Info (fr)]
        /// </summary>
        MWQMSiteStartEndInfo = 59,
        /// <summary>
        /// 60 -- en [MWQM Subsector Info] ---- fr [MWQM Subsector Info (fr)]
        /// </summary>
        MWQMSubsectorInfo = 60,
        /// <summary>
        /// 61 -- en [Pollution Source Site Info] ---- fr [Pollution Source Site Info (fr)]
        /// </summary>
        PolSourceSiteInfo = 61,
        /// <summary>
        /// 62 -- en [Pollution Source Site Observation Info] ---- fr [Pollution Source Site Observation Info (fr)]
        /// </summary>
        PolSourceSiteObsInfo = 62,
        /// <summary>
        /// 63 -- en [Hydrometric Rating Curve Info] ---- fr [Hydrometric Rating Curve Info (fr)]
        /// </summary>
        HydrometricRatingCurveInfo = 63,
        /// <summary>
        /// 64 -- en [Hydrometric Rating Curve Data Info] ---- fr [Hydrometric Rating Curve Data Info (fr)]
        /// </summary>
        HydrometricRatingCurveDataInfo = 64,
        /// <summary>
        /// 65 -- en [Tide Location Info] ---- fr [Tide Location Info (fr)]
        /// </summary>
        TideLocationInfo = 65,
        /// <summary>
        /// 66 -- en [Tide Site Data Info] ---- fr [Tide Site Data Info (fr)]
        /// </summary>
        TideSiteDataInfo = 66,
        /// <summary>
        /// 67 -- en [Use Of Site] ---- fr [Use Of Site (fr)]
        /// </summary>
        UseOfSite = 67,
        /// <summary>
        /// 68 -- en [Visual Plumes Scenario Info] ---- fr [Visual Plumes Scenario Info (fr)]
        /// </summary>
        VisualPlumesScenarioInfo = 68,
        /// <summary>
        /// 69 -- en [Visual Plumes Scenario Ambient] ---- fr [Visual Plumes Scenario Ambient (fr)]
        /// </summary>
        VisualPlumesScenarioAmbient = 69,
        /// <summary>
        /// 70 -- en [Visual Plumes Scenario Results] ---- fr [Visual Plumes Scenario Results (fr)]
        /// </summary>
        VisualPlumesScenarioResults = 70,
        /// <summary>
        /// 71 -- en [Total file] ---- fr [Totale filière]
        /// </summary>
        TotalFile = 71,
        /// <summary>
        /// 72 -- en [Mike source is river] ---- fr [Source de pollution MIKE rivière]
        /// </summary>
        MikeSourceIsRiver = 72,
        /// <summary>
        /// 73 -- en [Mike source included] ---- fr [Source de pollution MIKE inclus]
        /// </summary>
        MikeSourceIncluded = 73,
        /// <summary>
        /// 74 -- en [Mike source not included] ---- fr [Source de pollution MIKE non inclus]
        /// </summary>
        MikeSourceNotIncluded = 74,
    }
    /// <summary>
    /// </summary>
    /// <remarks>
    /// <code>
    ///     public enum WebTideDataSetEnum
    ///     {
    ///         Error = 0,
    ///         arctic9 = 1,
    ///         brador = 2,
    ///         HRglobal = 3,
    ///         h3o = 4,
    ///         hudson = 5,
    ///         ne_pac4 = 6,
    ///         nwatl = 7,
    ///         QuatsinoModel14 = 8,
    ///         sshelf = 9,
    ///         flood = 10,
    ///         vigf8 = 11,
    ///     }
    /// </code>
    /// </remarks>
    public enum WebTideDataSetEnum
    {
        /// <summary>
        /// 0 -- en [Empty] ---- fr [Empty (fr)]
        /// </summary>
        Error = 0,
        /// <summary>
        /// 1 -- en [Arctic] ---- fr [Arctic (fr)]
        /// </summary>
        arctic9 = 1,
        /// <summary>
        /// 2 -- en [Brador] ---- fr [Brador (fr)]
        /// </summary>
        brador = 2,
        /// <summary>
        /// 3 -- en [Global (LEGOS France)] ---- fr [Global (LEGOS France) (fr)]
        /// </summary>
        HRglobal = 3,
        /// <summary>
        /// 4 -- en [Halifax Harbour] ---- fr [Halifax Harbour (fr)]
        /// </summary>
        h3o = 4,
        /// <summary>
        /// 5 -- en [Hudson Bay (IML)] ---- fr [Hudson Bay (IML) (fr)]
        /// </summary>
        hudson = 5,
        /// <summary>
        /// 6 -- en [North East Pacific (IOS)] ---- fr [North East Pacific (IOS) (fr)]
        /// </summary>
        ne_pac4 = 6,
        /// <summary>
        /// 7 -- en [North West Atlantic] ---- fr [North West Atlantic (fr)]
        /// </summary>
        nwatl = 7,
        /// <summary>
        /// 8 -- en [Quatsino Sound] ---- fr [Quatsino Sound (fr)]
        /// </summary>
        QuatsinoModel14 = 8,
        /// <summary>
        /// 9 -- en [Scotian Fundy Maine] ---- fr [Scotian Fundy Maine (fr)]
        /// </summary>
        sshelf = 9,
        /// <summary>
        /// 10 -- en [Upper Bay of Fundy] ---- fr [Upper Bay of Fundy (fr)]
        /// </summary>
        flood = 10,
        /// <summary>
        /// 11 -- en [Vancouver Island (Mike Foreman)] ---- fr [Vancouver Island (Mike Foreman) (fr)]
        /// </summary>
        vigf8 = 11,
    }

    /// <summary>
    /// Class representing the Enumeration ID and Text in allowable languages [en, fr]
    /// </summary>
    public class EnumIDAndText
    {
        /// <summary>
        /// Enumeration ID
        /// </summary>
        public int EnumID { get; set; }
        /// <summary>
        /// Enumeration Text in allowable languages [en, fr]
        /// </summary>
        public string EnumText { get; set; }
    }

}
