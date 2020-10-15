using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace ExcelClassLibrary
{
//    [Guid("28451D9D-6422-47F9-88CD-13831749ECAF")]
//    //工具→创建GUID→复制
//    [ClassInterface(ClassInterfaceType.AutoDispatch)]
//    [ComVisible(true)]
//    public class Class1
//    {
//        #region COM related

//        [comregisterfunction]
//        public static void registerfunction(type type)
//        {
//            registry.classesroot.createsubkey(getsubkeyname(type, " programmable "));
//            var key = registry.classesroot.opensubkey(getsubkeyname(type, " inprocserver32 "), true);
//            key.setvalue("", environment.systemdirectory + @" \mscoree.dll ", registryvaluekind.string);
//        }

//        [comunregisterfunction]
//        public static void unregisterfunction(type type)
//        {
//            registry.classesroot.deletesubkey(getsubkeyname(type, " programmable "), false);
//        }

//        private static string getsubkeyname(type type, string subkeyname)
//        {
//            var s = new system.text.stringbuilder();
//            s.append(@" clsid\{ ");
//            s.append(type.guid.tostring().toupper());
//            s.append(@" }\ ");
//            s.append(subkeyname);
//            return s.tostring();
//        }
//        #endregion
//    }
}
