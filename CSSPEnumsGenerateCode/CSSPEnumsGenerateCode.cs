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
        public CSSPEnumsGenerateCode()
        {
            InitializeComponent();
        }

        private void butGenerateAllCodeFiles_Click(object sender, EventArgs e)
        {
            richTextBoxStatus.Text = "";
            GenerateCode();
        }

        private void GenerateCode()
        {
            richTextBoxStatus.AppendText("Stating...\r\n");

            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will generate CSSPEnums/GeneratedEnumsTextOrder.cs file
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            GenerateCodeHelper generateCodeHelper = new GenerateCodeHelper(textBoxCSSPEnumsDLL.Text, textBoxBaseDir.Text, richTextBoxStatus, lblStatus);
            generateCodeHelper.EnumsTextOrderGenerated();

            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will generate CSSPEnums/GeneratedEnums.cs file
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            generateCodeHelper = new GenerateCodeHelper(textBoxCSSPEnumsDLL.Text, textBoxBaseDir.Text, richTextBoxStatus, lblStatus);
            generateCodeHelper.EnumsGenerated();

            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will generate CSSPEnums.Tests/GeneratedEnumsTests.cs file
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            generateCodeHelper = new GenerateCodeHelper(textBoxCSSPEnumsDLL.Text, textBoxBaseDir.Text, richTextBoxStatus, lblStatus);
            generateCodeHelper.EnumsTestGenerated();

            richTextBoxStatus.AppendText("Done...\r\n");
        }

    }
}
