using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Direct.Shared;
using log4net;

namespace Template
{
    [DirectSealed]
    [DirectDom("YourDLLClassName")]
    [ParameterType(false)]
    public class YourDLLClassName
    {
        private static readonly ILog _log = LogManager.GetLogger("LibraryObjects");

        [DirectDom("Name of the function in designer")]
        [DirectDomMethod("This is how this funcion will appear when you select it {param1} {param2}")]
        [MethodDescription("description")]
        public static bool TestFunction(int param1, string param2)
        {
            return true;
        }
    }
}
