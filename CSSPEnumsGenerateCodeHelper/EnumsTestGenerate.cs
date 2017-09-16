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
            FileInfo fiDLL = new FileInfo(@"C:\CSSP Code\CSSPEnums\CSSPEnums\bin\Debug\CSSPEnums.dll");
            FileInfo fi = new FileInfo(@"C:\CSSP Code\CSSPEnums\CSSPEnums.Tests\EnumsTestGenerated.cs");

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
                    sb.AppendLine(@"");
                    sb.AppendLine(@"                string retStr = enums.GetResValueForTypeAndID(typeof(" + enumName + @"), -1);");
                    sb.AppendLine(@"                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"                retStr = enums.GetResValueForTypeAndID(typeof(" + enumName + @"), null);");
                    sb.AppendLine(@"                Assert.AreEqual(CSSPEnumsRes.Empty, retStr);");
                    sb.AppendLine(@"");
                    if (enumName == "BeaufortScaleEnum")
                    {
                        sb.AppendLine(@"                for (int i = -1, count = Enum.GetNames(typeof(" + enumName + ")).Length + 4; i < count; i++)");
                    }
                    else if (enumName == "SampleTypeEnum")
                    {
                        sb.AppendLine(@"                for (int i = 101, count = Enum.GetNames(typeof(" + enumName + ")).Length + 105; i < count; i++)");
                    }
                    else
                    {
                        sb.AppendLine(@"                for (int i = 0, count = Enum.GetNames(typeof(" + enumName + ")).Length + 5; i < count; i++)");
                    }
                    sb.AppendLine(@"                {");
                    sb.AppendLine(@"                    retStr = enums.GetResValueForTypeAndID(typeof(" + enumName + "), i);");
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
            sb.AppendLine(@"        [TestMethod]");
            sb.AppendLine(@"        public void Enums_EnumTypeListOK_Test()");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            foreach (CultureInfo culture in cultureListGood)");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                SetupTest(culture);");
            sb.AppendLine(@"");
            sb.AppendLine(@"                List<int?> intList = new List<int?>() { (int)PolSourceObsInfoEnum.AgricultureBuilding, (int)PolSourceObsInfoEnum.AquacultureLarge };");
            sb.AppendLine(@"                Assert.AreEqual((int)PolSourceObsInfoEnum.AgricultureBuilding, intList[0]);");
            sb.AppendLine(@"                Assert.AreEqual((int)PolSourceObsInfoEnum.AquacultureLarge, intList[1]);");
            sb.AppendLine(@"                string retStr = enums.EnumTypeListOK(typeof(PolSourceObsInfoEnum), intList);");
            sb.AppendLine(@"                Assert.AreEqual("""", retStr);");
            sb.AppendLine(@"");
            sb.AppendLine(@"                intList.Add(1000000);");
            sb.AppendLine(@"                retStr = enums.EnumTypeListOK(typeof(PolSourceObsInfoEnum), intList);");
            sb.AppendLine(@"                Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, ""PolSourceObsInfoEnum""), retStr);");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"        }");

            importAssembly = Assembly.LoadFile(fiDLL.FullName);
            types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.GetTypeInfo().BaseType == typeof(System.Enum))
                {
                    string enumName = type.Name;

                    sb.AppendLine(@"        [TestMethod]");
                    sb.AppendLine(@"        public void Enums_" + enumName.Substring(0, enumName.Length - 4) + "OK_Test()");
                    sb.AppendLine(@"        {");
                    sb.AppendLine(@"            foreach (CultureInfo culture in cultureListGood)");
                    sb.AppendLine(@"            {");
                    sb.AppendLine(@"                SetupTest(culture);");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"                string retStr = enums.EnumTypeOK(typeof(" + enumName + "), null);");
                    sb.AppendLine(@"                Assert.AreEqual("""", retStr);");
                    sb.AppendLine(@"");
                    if (enumName == "BeaufortScaleEnum")
                    {
                        sb.AppendLine(@"                for (int i = -1, count = Enum.GetNames(typeof(" + enumName + ")).Length + 5; i < count; i++)");
                    }
                    else if (enumName == "SampleTypeEnum")
                    {
                        sb.AppendLine(@"                for (int i = 101, count = Enum.GetNames(typeof(" + enumName + ")).Length + 105; i < count; i++)");
                    }
                    else
                    {
                        sb.AppendLine(@"                for (int i = 0, count = Enum.GetNames(typeof(" + enumName + ")).Length + 5; i < count; i++)");
                    }
                    sb.AppendLine(@"                {");
                    if (enumName == "TVTypeEnum")
                    {
                        sb.AppendLine(@"                    if (i == 32)");
                        sb.AppendLine(@"                    {");
                        sb.AppendLine(@"                        continue;");
                        sb.AppendLine(@"                    }");
                    }
                    sb.AppendLine(@"                    retStr = enums.EnumTypeOK(typeof(" + enumName + @"), i);");
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
                    sb.AppendLine(@"                            Assert.AreEqual(string.Format(CSSPEnumsRes._IsRequired, """ + enumName + @"""), retStr);");
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

                    sb.AppendLine(@"        [TestMethod]");
                    sb.AppendLine(@"        public void Enums_" + enumName + "TextOrdered_Test()");
                    sb.AppendLine(@"        {");
                    sb.AppendLine(@"            foreach (CultureInfo culture in cultureListGood)");
                    sb.AppendLine(@"            {");
                    sb.AppendLine(@"                SetupTest(culture);");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"                List<EnumIDAndText> enumTextOrderedList = new List<EnumIDAndText>();");
                    if (enumName == "BeaufortScaleEnum")
                    {
                        sb.AppendLine(@"                for (int i = 0, count = Enum.GetNames(typeof(" + enumName + ")).Length - 1; i < count; i++)");
                    }
                    else if (enumName == "SampleTypeEnum")
                    {
                        sb.AppendLine(@"                for (int i = 101, count = Enum.GetNames(typeof(" + enumName + ")).Length + 101; i < count; i++)");
                    }
                    else
                    {
                        sb.AppendLine(@"                for (int i = 1, count = Enum.GetNames(typeof(" + enumName + ")).Length; i < count; i++)");
                    }
                    sb.AppendLine(@"                {");
                    sb.AppendLine(@"                    enumTextOrderedList.Add(new EnumIDAndText() { EnumID = i, EnumText = enums.GetResValueForTypeAndID(typeof(" + enumName + "), i) });");
                    sb.AppendLine(@"                }");
                    sb.AppendLine(@"                enumTextOrderedList = enumTextOrderedList.OrderBy(c => c.EnumText).ToList();");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"                List<EnumIDAndText> enumTextOrderedList2 = enums.GetEnumTextOrderedList(typeof(" + enumName + "));");
                    sb.AppendLine(@"                Assert.AreEqual(enumTextOrderedList.Count, enumTextOrderedList2.Count);");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"                EnumIDAndText enumTextOrdered = new EnumIDAndText();");
                    sb.AppendLine(@"                Assert.IsNotNull(enumTextOrdered);");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"                for (int i = 0, count = enumTextOrderedList.Count; i < count; i++)");
                    sb.AppendLine(@"                {");
                    sb.AppendLine(@"                    Assert.AreEqual(enumTextOrderedList[i].EnumText, enumTextOrderedList2[i].EnumText);");
                    sb.AppendLine(@"                    Assert.AreEqual(enumTextOrderedList[i].EnumID, enumTextOrderedList2[i].EnumID);");
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
            StatusTempEvent(new StatusEventArgs("Created [" + fi.FullName + "] ..."));
            StatusPermanentEvent(new StatusEventArgs("Created [" + fi.FullName + "] ..."));
        }
    }
}
