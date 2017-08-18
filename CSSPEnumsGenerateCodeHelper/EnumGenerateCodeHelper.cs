using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSPEnumsGenerateCodeHelper
{
    public partial class EnumsGenerateCodeHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private EnumsFiles enumsFiles { get; set; }
        #endregion Properties

        #region Constructors
        public EnumsGenerateCodeHelper(EnumsFiles enumFiles)
        {
            this.enumsFiles = enumFiles;
        }
        #endregion Constructors

        #region Events
        protected virtual void ErrorEvent(ErrorEventArgs e)
        {
            ErrorHandler?.Invoke(this, e);
        }

        public event EventHandler<ErrorEventArgs> ErrorHandler;
        protected virtual void StatusEvent(StatusEventArgs e)
        {
            StatusHandler?.Invoke(this, e);
        }

        public event EventHandler<StatusEventArgs> StatusHandler;
        #endregion Events
    }

    #region Other classes
    public class ErrorEventArgs : EventArgs
    {
        public ErrorEventArgs(string Error)
        {
            this.Error = Error;
        }

        public string Error { get; set; }
    }
    public class StatusEventArgs : EventArgs
    {
        public StatusEventArgs(string Status)
        {
            this.Status = Status;
        }

        public string Status { get; set; }
    }
    public class EnumsFiles
    {
        public EnumsFiles()
        {
            CSSPEnumsDLL = "";
            BaseDir = "";
            EnumsGenerated = "";
            EnumsTestGenerated = "";
        }

        public string CSSPEnumsDLL { get; set; }
        public string BaseDir { get; set; }
        public string EnumsGenerated { get; set; }
        public string EnumsTestGenerated { get; set; }
    }
    #endregion Other classes
}
