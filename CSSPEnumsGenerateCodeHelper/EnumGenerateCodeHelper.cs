using CSSPGenerateCodeBase;
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
    public partial class EnumsGenerateCodeHelper : GenerateCodeBase
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
        //protected virtual void ErrorEvent(ErrorEventArgs e)
        //{
        //    ErrorHandler?.Invoke(this, e);
        //}

        //public event EventHandler<ErrorEventArgs> ErrorHandler;
        //protected virtual void StatusEvent(StatusEventArgs e)
        //{
        //    StatusHandler?.Invoke(this, e);
        //}

        //public event EventHandler<StatusEventArgs> StatusHandler;
        #endregion Events

        #region Functions public
        //public bool FillDLLTypeInfoList(FileInfo fiCSSPEnumsDLL, List<DLLTypeInfo> DLLTypeInfoList)
        //{
        //    var importAssembly = Assembly.LoadFile(fiCSSPEnumsDLL.FullName);
        //    List<Type> typeList = importAssembly.GetTypes().ToList();

        //    foreach (Type type in typeList)
        //    {
        //        if (type.Name.StartsWith("<"))
        //        {
        //            continue;
        //        }

        //        StatusEvent(new StatusEventArgs("Reading type file [" + fiCSSPEnumsDLL.Name + "] [" + type.Name + "]"));

        //        DLLTypeInfo dllTypeInfo = new DLLTypeInfo();
        //        dllTypeInfo.Type = type;
        //        dllTypeInfo.Name = type.Name;
        //        dllTypeInfo.IsEnum = false;
        //        if (type.GetTypeInfo().BaseType == typeof(System.Enum))
        //        {
        //            dllTypeInfo.IsEnum = true;
        //        }

        //        foreach (FieldInfo fieldInfo in type.GetFields())
        //        {
        //            if (!fieldInfo.FieldType.Name.EndsWith("Enum"))
        //            {
        //                continue;
        //            }

        //            DLLFieldInfo dllFieldInfo = new DLLFieldInfo();
        //            dllFieldInfo.FieldInfo = fieldInfo;
        //            dllFieldInfo.Name = fieldInfo.Name;

        //            dllTypeInfo.FieldInfoList.Add(dllFieldInfo);
        //        }

        //        foreach (PropertyInfo propertyInfo in type.GetProperties())
        //        {
        //            bool CanReadPropertyType = false;
        //            try
        //            {
        //                var PropertyType = propertyInfo.PropertyType;
        //                CanReadPropertyType = true;
        //            }
        //            catch (Exception ex)
        //            {
        //                // not used
        //            }
        //            if (!CanReadPropertyType)
        //            {
        //                continue;
        //            }
        //            if (propertyInfo.PropertyType.Name.StartsWith("<"))
        //            {
        //                continue;
        //            }

        //            StatusEvent(new StatusEventArgs("Reading type file [" + fiCSSPEnumsDLL.Name + "] [" + type.Name + "] [" + propertyInfo.Name + "]"));

        //            DLLPropertyInfo dllPropertyInfo = new DLLPropertyInfo();
        //            dllPropertyInfo.PropertyInfo = propertyInfo;
        //            dllPropertyInfo.Name = propertyInfo.Name;
        //            dllPropertyInfo.PropertyType = propertyInfo.PropertyType;

        //            string PropertyTypeName = propertyInfo.PropertyType.FullName;
        //            if (PropertyTypeName.StartsWith("System.Nullable"))
        //            {
        //                PropertyTypeName = PropertyTypeName.Substring(PropertyTypeName.IndexOf("[[") + 2);
        //                PropertyTypeName = PropertyTypeName.Substring(PropertyTypeName.IndexOf(".") + 1);
        //                PropertyTypeName = PropertyTypeName.Substring(0, PropertyTypeName.IndexOf(","));
        //            }

        //            dllPropertyInfo.PropertyTypeName = PropertyTypeName;

        //            dllTypeInfo.PropertyInfoList.Add(dllPropertyInfo);
        //        }

        //        foreach (MethodInfo methodInfo in type.GetMethods())
        //        {
        //            if (methodInfo.Name.StartsWith("<"))
        //            {
        //                continue;
        //            }

        //            StatusEvent(new StatusEventArgs("Reading type file [" + fiCSSPEnumsDLL.Name + "] [" + type.Name + "] [" + methodInfo.Name + "]"));

        //            if (methodInfo.DeclaringType.FullName.StartsWith("CSSP"))
        //            {
        //                DLLMethodInfo dllMethodInfo = new DLLMethodInfo();
        //                dllMethodInfo.MethodInfo = methodInfo;
        //                dllMethodInfo.Name = methodInfo.Name;
        //                dllMethodInfo.DeclaringType = methodInfo.DeclaringType;

        //                string DeclaringTypeName = methodInfo.DeclaringType.FullName;
        //                if (DeclaringTypeName.StartsWith("System.Nullable"))
        //                {
        //                    DeclaringTypeName = DeclaringTypeName.Substring(DeclaringTypeName.IndexOf("[[") + 2);
        //                    DeclaringTypeName = DeclaringTypeName.Substring(DeclaringTypeName.IndexOf(".") + 1);
        //                    DeclaringTypeName = DeclaringTypeName.Substring(0, DeclaringTypeName.IndexOf(","));
        //                }

        //                dllMethodInfo.DeclaringTypeName = DeclaringTypeName;

        //                try
        //                {
        //                    foreach (ParameterInfo parameterInfo in methodInfo.GetParameters())
        //                    {
        //                        DLLParameterInfo dllParameterInfo = new DLLParameterInfo();
        //                        dllParameterInfo.ParameterInfo = parameterInfo;
        //                        dllParameterInfo.Name = parameterInfo.Name;

        //                        dllMethodInfo.ParameterInfoList.Add(dllParameterInfo);
        //                    }

        //                }
        //                catch (Exception ex)
        //                {
        //                    // nothing
        //                }
        //            }
        //        }

        //        DLLTypeInfoList.Add(dllTypeInfo);
        //    }


        //    return false;
        //}
        #endregion Functions public
    }

    #region Other classes
    //public class ErrorEventArgs : EventArgs
    //{
    //    public ErrorEventArgs(string Error)
    //    {
    //        this.Error = Error;
    //    }

    //    public string Error { get; set; }
    //}
    //public class StatusEventArgs : EventArgs
    //{
    //    public StatusEventArgs(string Status)
    //    {
    //        this.Status = Status;
    //    }

    //    public string Status { get; set; }
    //}
    //public class EnumsFiles
    //{
    //    public EnumsFiles()
    //    {
    //        CSSPEnumsDLL = "";
    //        BaseDir = "";
    //        EnumsGenerated = "";
    //        EnumsTestGenerated = "";
    //    }

    //    public string CSSPEnumsDLL { get; set; }
    //    public string BaseDir { get; set; }
    //    public string EnumsGenerated { get; set; }
    //    public string EnumsTestGenerated { get; set; }
    //}
    //public class DLLTypeInfo
    //{
    //    public DLLTypeInfo()
    //    {
    //        FieldInfoList = new List<DLLFieldInfo>();
    //        PropertyInfoList = new List<DLLPropertyInfo>();
    //        MethodInfoList = new List<DLLMethodInfo>();
    //    }

    //    public Type Type { get; set; }
    //    public string Name { get; set; }
    //    public bool IsEnum { get; set; }
    //    public bool IsPublic { get; set; }
    //    public List<DLLFieldInfo> FieldInfoList { get; set; }
    //    public List<DLLPropertyInfo> PropertyInfoList { get; set; }
    //    public List<DLLMethodInfo> MethodInfoList { get; set; }
    //}
    //public class DLLFieldInfo
    //{
    //    public DLLFieldInfo()
    //    {

    //    }

    //    public FieldInfo FieldInfo { get; set; }
    //    public string Name { get; set; }
    //}
    //public class DLLPropertyInfo
    //{
    //    public DLLPropertyInfo()
    //    {

    //    }

    //    public PropertyInfo PropertyInfo { get; set; }
    //    public string Name { get; set; }
    //    public Type PropertyType { get; set; }
    //    public string PropertyTypeName { get; set; }
    //}
    //public class DLLMethodInfo
    //{
    //    public DLLMethodInfo()
    //    {
    //        ParameterInfoList = new List<DLLParameterInfo>();
    //    }

    //    public MethodInfo MethodInfo { get; set; }
    //    public string Name { get; set; }
    //    public Type DeclaringType { get; set; }
    //    public string DeclaringTypeName { get; set; }
    //    public List<DLLParameterInfo> ParameterInfoList { get; set; }
    //}
    //public class DLLParameterInfo
    //{
    //    public DLLParameterInfo()
    //    {

    //    }

    //    public ParameterInfo ParameterInfo { get; set; }
    //    public string Name { get; set; }
    //}
    #endregion Other classes
}
