using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSPEnumsGenerateCodeHelper
{
    public partial class GenerateCodeHelper
    {
        public void EnumsTextOrderGenerated()
        {
            StringBuilder sb = new StringBuilder();
            FileInfo fiDLL = new FileInfo(DLLFileName);
            FileInfo fi = new FileInfo(BaseDir + @"CSSPEnums\CSSPEnums\EnumsTextOrderGenerated.cs");

            sb.AppendLine(@"using System;");
            sb.AppendLine(@"using System.Collections.Generic;");
            sb.AppendLine(@"using System.Linq;");
            sb.AppendLine(@"using System.Text;");
            sb.AppendLine(@"using System.Threading.Tasks;");
            sb.AppendLine(@"");
            sb.AppendLine(@"namespace CSSPEnums");
            sb.AppendLine(@"{");
            sb.AppendLine(@"    #region Class Enum Ordered");
            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.GetTypeInfo().BaseType == typeof(System.Enum))
                {
                    string enumName = type.Name;
                    sb.AppendLine(@"    public class " + enumName + "TextOrdered");
                    sb.AppendLine(@"    {");
                    sb.AppendLine(@"        public " + enumName + "TextOrdered()");
                    sb.AppendLine(@"        {");
                    sb.AppendLine(@"        }");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"        public " + enumName + " " + enumName.Substring(0, enumName.Length - 4) + " { get; set; }");
                    sb.AppendLine(@"        public string " + enumName.Substring(0, enumName.Length - 4) + "Text { get; set; }");
                    sb.AppendLine(@"    }");
                }
            }
            sb.AppendLine(@"");
            sb.AppendLine(@"    #endregion Class Enum Ordered");
            sb.AppendLine(@"}");

            using (StreamWriter sw = fi.CreateText())
            {
                sw.Write(sb.ToString());
            }
            RichTextBoxStatus.AppendText("Created [" + fi.FullName + "] ...\r\n");

        }

    }
}
