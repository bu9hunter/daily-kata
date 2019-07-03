using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("RegularExpLibrary")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("RegularExpLibrary")]
[assembly: AssemblyCopyright("Copyright ©  2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("6aed3973-c0a5-4075-b31d-4a6e7bb6497b")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

namespace RegularExpLibrary.Properties
{
    public class RegularExpMatch
    {
        public RegularExpMatch()
        {
        }

        public bool isMatch(string text, string pattern)
        {
            if (String.IsNullOrEmpty(pattern)) return String.IsNullOrEmpty(text);

            bool firstMatch = (!String.IsNullOrEmpty(text) && (text.ToCharArray()[0] == pattern.ToCharArray()[0] || pattern.ToCharArray()[0] == '.'));

            if (pattern.Length >= 2 && pattern.ToCharArray()[1] == '*')
            {
                return isMatch(text, pattern.Substring(2)) || firstMatch && isMatch(text.Substring(1), pattern);
            }
            else
            {
                return firstMatch && isMatch(text.Substring(1), pattern.Substring(1));
            }
        }
    }
}