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
    public partial class EnumsGenerateCodeHelper
    {
        public void EnumsTestGenerate()
        {
            StringBuilder sb = new StringBuilder();
            FileInfo fiDLL = new FileInfo(enumsFiles.CSSPEnumsDLL);
            FileInfo fi = new FileInfo(enumsFiles.BaseDir + enumsFiles.EnumsTestGenerated);

            sb.AppendLine(@"using System;");
            sb.AppendLine(@"using System.Text;");
            sb.AppendLine(@"using System.Collections.Generic;");
            sb.AppendLine(@"using Microsoft.VisualStudio.TestTools.UnitTesting;");
            sb.AppendLine(@"using CSSPEnums.Tests;");
            sb.AppendLine(@"using System.Globalization;");
            sb.AppendLine(@"using System.Threading;");
            sb.AppendLine(@"using CSSPEnums;");
            sb.AppendLine(@"using CSSPEnums.Resources;");
            sb.AppendLine(@"using System.Linq;");
            sb.AppendLine(@"using System.Net;");
            sb.AppendLine(@"");
            sb.AppendLine(@"namespace CSSPEnums.Tests");
            sb.AppendLine(@"{");
            sb.AppendLine(@"    public partial class EnumsTest : SetupData");
            sb.AppendLine(@"    {");
            sb.AppendLine(@"");

            // Doing Testing Methods GetEnumText public
            sb.AppendLine(@"        #region Testing Methods GetEnumText public");
            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.GetTypeInfo().BaseType == typeof(System.Enum))
                {
                    string enumName = type.Name;
                    if (enumName == "PolSourceObsInfoEnum")
                        continue;

                    sb.AppendLine(@"        [TestMethod]");
                    sb.AppendLine(@"        public void Enums_GetEnumText_" + enumName + "_Test()");
                    sb.AppendLine(@"        {");
                    sb.AppendLine(@"            foreach (CultureInfo culture in cultureListGood)");
                    sb.AppendLine(@"            {");
                    sb.AppendLine(@"                SetupTest(culture);");
                    sb.AppendLine(@"        ");
                    sb.AppendLine(@"                string retStr = enums.GetResValueForTypeAndField(typeof(" + enumName + @"), -1);");
                    sb.AppendLine(@"                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);");
                    sb.AppendLine(@"        ");
                    if (enumName == "BeaufortScaleEnum")
                    {
                        sb.AppendLine(@"                for (int i = -1, count = Enum.GetNames(typeof(" + enumName + ")).Length + 1; i < count; i++)");
                    }
                    else if (enumName == "SampleTypeEnum")
                    {
                        sb.AppendLine(@"                for (int i = 0, count = Enum.GetNames(typeof(" + enumName + ")).Length + 101; i < count; i++)");
                    }
                    else
                    {
                        sb.AppendLine(@"                for (int i = 0, count = Enum.GetNames(typeof(" + enumName + ")).Length + 1; i < count; i++)");
                    }
                    sb.AppendLine(@"                {");
                    sb.AppendLine(@"                    retStr = WebUtility.HtmlDecode(enums.GetResValueForTypeAndField(typeof(" + enumName + "), i));");
                    sb.AppendLine(@"        ");
                    sb.AppendLine(@"                    switch ((" + enumName + ")i)");
                    sb.AppendLine(@"                    {");
                    foreach (FieldInfo fieldInfo in type.GetFields())
                    {
                        if (fieldInfo.FieldType.GetTypeInfo().BaseType == typeof(System.Enum))
                        {
                            string fName = fieldInfo.Name;
                            sb.AppendLine(@"                        case " + enumName + "." + fName + ":");
                            if (fName == "Error")
                            {
                                sb.AppendLine(@"                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);");
                                sb.AppendLine(@"                            break;");
                            }
                            else
                            {
                                sb.AppendLine(@"                            Assert.AreEqual(CSSPEnumsRes." + enumName + fName + ", retStr);");
                                sb.AppendLine(@"                            break;");
                            }
                        }
                    }
                    sb.AppendLine(@"                        default:");
                    sb.AppendLine(@"                            Assert.AreEqual(CSSPEnumsRes.Empty, retStr);");
                    sb.AppendLine(@"                            break;");
                    sb.AppendLine(@"                    }");
                    if (enumName == "SampleTypeEnum")
                    {
                        sb.AppendLine(@"                    if (i == 0)");
                        sb.AppendLine(@"                    {");
                        sb.AppendLine(@"                        i = 100;");
                        sb.AppendLine(@"                    }");
                    }
                    sb.AppendLine(@"                }");
                    sb.AppendLine(@"            }");
                    sb.AppendLine(@"        }");

                }
            }
            sb.AppendLine(@"");
            sb.AppendLine(@"        #endregion Testing Methods GetEnumText public");
            sb.AppendLine(@"");


            // Doing Testing Methods Check OK public
            sb.AppendLine(@"        #region Testing Methods Check OK public");
            importAssembly = Assembly.LoadFile(fiDLL.FullName);
            types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.GetTypeInfo().BaseType == typeof(System.Enum))
                {
                    string enumName = type.Name;
                    if (enumName == "PolSourceObsInfoEnum")
                        continue;

                    sb.AppendLine(@"        [TestMethod]");
                    sb.AppendLine(@"        public void Enums_" + enumName.Substring(0, enumName.Length - 4) + "OK_Test()");
                    sb.AppendLine(@"        {");
                    sb.AppendLine(@"            foreach (CultureInfo culture in cultureListGood)");
                    sb.AppendLine(@"            {");
                    sb.AppendLine(@"                SetupTest(culture);");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"                string retStr = enums." + enumName.Substring(0, enumName.Length - 4) + "OK(null);");
                    sb.AppendLine(@"                Assert.AreEqual("""", retStr);");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"                for (int i = 0, count = Enum.GetNames(typeof(" + enumName + ")).Length + 1; i < count; i++)");
                    sb.AppendLine(@"                {");
                    sb.AppendLine(@"                    retStr = enums." + enumName.Substring(0, enumName.Length - 4) + "OK((" + enumName + ")i);");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"                    switch ((" + enumName + ")i)");
                    sb.AppendLine(@"                    {");
                    foreach (FieldInfo fieldInfo in type.GetFields())
                    {
                        if (fieldInfo.FieldType.GetTypeInfo().BaseType == typeof(System.Enum))
                        {
                            string fName = fieldInfo.Name;
                            sb.AppendLine(@"                        case " + enumName + "." + fName + ":");
                        }
                    }
                    sb.AppendLine(@"                            Assert.AreEqual("""", retStr);");
                    sb.AppendLine(@"                            break;");
                    sb.AppendLine(@"                        default:");
                    sb.AppendLine(@"                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, CSSPEnumsRes." + enumName.Substring(0, enumName.Length - 4) + "), retStr);");
                    sb.AppendLine(@"                            break;");
                    sb.AppendLine(@"                    }");
                    sb.AppendLine(@"                }");
                    sb.AppendLine(@"            }");
                    sb.AppendLine(@"        }");

                }
            }
            sb.AppendLine(@"");
            sb.AppendLine(@"        #endregion Testing Methods Check OK public");


            // Doing Testing Methods TextOrdered public
            sb.AppendLine(@"        #region Testing Methods TextOrdered public");
            importAssembly = Assembly.LoadFile(fiDLL.FullName);
            types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.GetTypeInfo().BaseType == typeof(System.Enum))
                {
                    string enumName = type.Name;
                    //if (enumName == "PolSourceObsInfoEnum")
                    //    continue;

                    sb.AppendLine(@"        [TestMethod]");
                    sb.AppendLine(@"        public void Enums_" + enumName + "TextOrdered_Test()");
                    sb.AppendLine(@"        {");
                    sb.AppendLine(@"            foreach (CultureInfo culture in cultureListGood)");
                    sb.AppendLine(@"            {");
                    sb.AppendLine(@"                SetupTest(culture);");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"                List<" + enumName + "TextOrdered> " + enumName + "List = new List<" + enumName + "TextOrdered>();");
                    if (enumName == "SampleTypeEnum")
                    {
                        sb.AppendLine(@"                for (int i = 101, count = Enum.GetNames(typeof(" + enumName + ")).Length + 100; i < count; i++)");
                    }
                    else
                    {
                        sb.AppendLine(@"                for (int i = 1, count = Enum.GetNames(typeof(" + enumName + ")).Length; i < count; i++)");
                    }
                    sb.AppendLine(@"                {");
                    sb.AppendLine(@"                    " + enumName + "List.Add(new " + enumName + "TextOrdered() { " + enumName.Substring(0, enumName.Length - 4) + " = (" + enumName + ")i, " + enumName.Substring(0, enumName.Length - 4) + "Text = WebUtility.HtmlDecode(enums.GetResValueForTypeAndField(typeof(" + enumName + "), i)) });");
                    sb.AppendLine(@"                }");
                    sb.AppendLine(@"                " + enumName + "List = " + enumName + "List.OrderBy(c => c." + enumName.Substring(0, enumName.Length - 4) + "Text).ToList();");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"                List<" + enumName + "TextOrdered> " + enumName + "TextOrderedList = enums.Get" + enumName + "TextOrderedList();");
                    sb.AppendLine(@"                Assert.AreEqual(" + enumName + "List.Count, " + enumName + "TextOrderedList.Count);");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"                " + enumName + "TextOrdered " + enumName + "TextOrdered = new " + enumName + "TextOrdered();");
                    sb.AppendLine(@"                Assert.IsNotNull(" + enumName + "TextOrdered);");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"                for (int i = 0, count = " + enumName + "List.Count; i < count; i++)");
                    sb.AppendLine(@"                {");
                    sb.AppendLine(@"                    Assert.AreEqual(" + enumName + "List[i]." + enumName.Substring(0, enumName.Length - 4) + "Text, " + enumName + "TextOrderedList[i]." + enumName.Substring(0, enumName.Length - 4) + "Text);");
                    sb.AppendLine(@"                    Assert.AreEqual(" + enumName + "List[i]." + enumName.Substring(0, enumName.Length - 4) + ", " + enumName + "TextOrderedList[i]." + enumName.Substring(0, enumName.Length - 4) + ");");
                    sb.AppendLine(@"                }");
                    sb.AppendLine(@"            }");
                    sb.AppendLine(@"        }");
                }
            }
            sb.AppendLine(@"");
            sb.AppendLine(@"        #endregion Testing Methods TextOrdered public");

            sb.AppendLine(@"    }");
            sb.AppendLine(@"}");

            using (StreamWriter sw = fi.CreateText())
            {
                sw.Write(sb.ToString());
            }
            StatusEvent(new StatusEventArgs("Created [" + fi.FullName + "] ..."));
        }
    }
}
