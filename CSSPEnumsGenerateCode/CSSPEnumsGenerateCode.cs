using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSSPEnumsGenerateCodeHelper;
using CSSPGenerateCodeBase;

namespace CSSPEnumsGenerateCode
{
    public partial class CSSPEnumsGenerateCode : Form
    {
        #region Variables
        #endregion Variables

        #region Properties
        EnumsGenerateCodeHelper enumGenerateCodeHelper { get; set; }
        #endregion Properties

        #region Constructors
        public CSSPEnumsGenerateCode()
        {
            InitializeComponent();
            StartUp();
        }
        #endregion Constructors

        #region Events
        private void butGenerateAllCodeFiles_Click(object sender, EventArgs e)
        {
            richTextBoxStatus.Text = "";
            GenerateCode();
        }
        private void EnumGenerateCodeHelper_ErrorHandler(object sender, GenerateCodeBase.ErrorEventArgs e)
        {
            richTextBoxStatus.AppendText("Error [" + e.Error + "]\r\n");
        }
        private void EnumGenerateCodeHelper_StatusTempHandler(object sender, GenerateCodeBase.StatusEventArgs e)
        {
            lblStatus.Text = e.Status;
            lblStatus.Refresh();
            Application.DoEvents();
        }
        private void EnumGenerateCodeHelper_StatusPermanentHandler(object sender, GenerateCodeBase.StatusEventArgs e)
        {
            richTextBoxStatus.AppendText("Status [" + e.Status + "]\r\n");
        }
        private void butGenerateEnumsWithHelp_Click(object sender, EventArgs e)
        {
            richTextBoxStatus.Text = "";
            GenerateEnumsAndPolSourceInfoEnumsWithHelpCode();
        }
        #endregion Events

        #region Functions public
        #endregion Functions public

        #region Functions private
        private void GenerateCode()
        {
            richTextBoxStatus.AppendText("Starting...\r\n");

            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will generate CSSPEnums/GeneratedEnums.cs file
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            enumGenerateCodeHelper.EnumsGenerate();

            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will generate CSSPEnums.Tests/GeneratedEnumsTests.cs file
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            enumGenerateCodeHelper.EnumsTestGenerate();

            lblStatus.Text = "Done...";
            richTextBoxStatus.AppendText("Done...\r\n");
        }
        private void GenerateEnumsAndPolSourceInfoEnumsWithHelpCode()
        {
            richTextBoxStatus.AppendText("Starting...\r\n");

            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will generate CSSPEnums/EnumsWithHelp.cs file
            // Will generate CSSPEnums/PolSourceObsInfoEnumGeneratedWithHelp.cs file
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            enumGenerateCodeHelper.EnumsAndPolSourceInfoEnumsWithHelpGenerate();

            richTextBoxStatus.AppendText("Done...\r\n\r\n");

            richTextBoxStatus.AppendText("In order to compile the CSSPEnums project with documentation\r\n");
            richTextBoxStatus.AppendText("You need to [EXCLUDE] Enums.cs and PolSourceObsInfoEnumGenerated.cs from the CSSPEnums project\r\n");
            richTextBoxStatus.AppendText("and [INCLUDE] EnumsWithHelp.cs and PolSourceObsInfoEnumGeneratedWithHelp.cs from the CSSPEnums project\r\n");
        }
        private void StartUp()
        {
            enumGenerateCodeHelper = new EnumsGenerateCodeHelper();

            enumGenerateCodeHelper.ErrorHandler += EnumGenerateCodeHelper_ErrorHandler;
            enumGenerateCodeHelper.StatusTempHandler += EnumGenerateCodeHelper_StatusTempHandler;
            enumGenerateCodeHelper.StatusPermanentHandler += EnumGenerateCodeHelper_StatusPermanentHandler;
        }

        #endregion Functions private
    }
}
