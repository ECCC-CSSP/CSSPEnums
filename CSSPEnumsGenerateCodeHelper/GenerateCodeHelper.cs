using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSPEnumsGenerateCodeHelper
{
    public partial class GenerateCodeHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private string DLLFileName { get; set; }
        private RichTextBox RichTextBoxStatus { get; set; }
        private Label LabelStatus { get; set; }
        private string BaseDir { get; set; }
        #endregion Properties

        #region Constructors
        public GenerateCodeHelper(string DLLFileName, string BaseDir, RichTextBox richTextBoxStatus, Label lblStatus)
        {
            this.DLLFileName = DLLFileName;
            this.RichTextBoxStatus = richTextBoxStatus;
            this.LabelStatus = lblStatus;
            this.BaseDir = BaseDir;
        }
        #endregion Constructors
    }
}
