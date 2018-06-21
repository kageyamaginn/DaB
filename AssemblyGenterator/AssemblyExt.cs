using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;

namespace AssemblyGenterator
{
    public static class AssemblyExt
    {
        public static CompilerResults Add(this Assembly me, string assemblyName, CompilerParameters param = null,params string[] soruces)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider();
            String fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EntitiesMeta", assemblyName);
            if (param == null)
            {
                param.GenerateExecutable = false;
                param.GenerateInMemory = false;
                param.TreatWarningsAsErrors = false;
                param.OutputAssembly = fileName;
            }

            CompilerResults res= provider.CompileAssemblyFromSource(param, soruces);
            return res;
        }
    }
}
