using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Threading;

namespace CSSPEnums.Tests
{
    /// <summary>
    /// Summary description for EnumsTest
    /// </summary>
    [TestClass]
    public partial class EnumsTest : SetupData
    {
        #region Variables
        private TestContext testContextInstance;
        private SetupData setupData;
        private Enums enums { get; set; }
        #endregion Variables

        #region Properties
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        #endregion Properties

        #region Constructors
        public EnumsTest()
        {
            setupData = new SetupData();
        }
        #endregion Constructors

        // All the testing function are under the EnumsGeneratedTest.cs

        #region Testing Methods private
        #endregion Testing Methods private

        #region Functions private
        public void SetupTest(CultureInfo culture)
        {
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            enums = new Enums((culture.TwoLetterISOLanguageName == "fr" ? LanguageEnum.fr : LanguageEnum.en));
        }
        #endregion Functions private

    }
}
