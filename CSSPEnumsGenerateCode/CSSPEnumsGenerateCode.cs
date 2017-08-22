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
        private void EnumGenerateCodeHelper_ErrorHandler(object sender, CSSPEnumsGenerateCodeHelper.ErrorEventArgs e)
        {
            richTextBoxStatus.AppendText("Error [" + e.Error + "]\r\n");
        }
        private void EnumGenerateCodeHelper_StatusHandler(object sender, StatusEventArgs e)
        {
            lblStatus.Text = e.Status;
            lblStatus.Refresh();
            Application.DoEvents();
        }
        private void butGenerateEnumsWithHelp_Click(object sender, EventArgs e)
        {
            richTextBoxStatus.Text = "";
            GenerateEnumsWithHelpCode();
        }
        #endregion Events

        #region Functions public
        #endregion Functions public

        #region Functions private
        private void GenerateCode()
        {
            richTextBoxStatus.AppendText("Stating...\r\n");

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

            richTextBoxStatus.AppendText("Done...\r\n");
        }
        private void GenerateEnumsWithHelpCode()
        {
            richTextBoxStatus.AppendText("Stating...\r\n");

            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will generate CSSPEnums/EnumsWithHelp.cs file
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            enumGenerateCodeHelper.EnumsWithHelpGenerate();

            richTextBoxStatus.AppendText("Done...\r\n\r\n");

            richTextBoxStatus.AppendText("You can now replace the Enums.cs content with the content of EnumsWithHelp.cs file ...\r\n");
        }
        private void StartUp()
        {
            EnumsFiles enumsFiles = new EnumsFiles();
            enumsFiles.CSSPEnumsDLL = textBoxCSSPEnumsDLL.Text;
            enumsFiles.BaseDir = textBoxBaseDir.Text;
            enumsFiles.EnumsGenerated = textBoxFile1.Text;
            enumsFiles.EnumsTestGenerated = textBoxFile2.Text;

            enumGenerateCodeHelper = new EnumsGenerateCodeHelper(enumsFiles);

            enumGenerateCodeHelper.ErrorHandler += EnumGenerateCodeHelper_ErrorHandler;
            enumGenerateCodeHelper.StatusHandler += EnumGenerateCodeHelper_StatusHandler;
        }
        #endregion Functions private
    }
}
