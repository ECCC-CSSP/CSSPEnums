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
        private SetupData setupData;
        private Enums enums { get; set; }
        #endregion Variables

        #region Properties

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
