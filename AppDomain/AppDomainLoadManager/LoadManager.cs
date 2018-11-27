using System;
using System.Reflection;
using InteropAsm;

namespace AppDomainLoadManager {
    public class LoadManager : MarshalByRefObject {
        string path;
        public IAddIn LoadAddIn(string asmPath, string typeToLoad) {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Assembly asm = Assembly.ReflectionOnlyLoadFrom(asmPath);
            IAddIn addin = 
                (IAddIn)AppDomain.CurrentDomain.CreateInstanceAndUnwrap(asm.GetName().Name, typeToLoad);
            path = addin.GetType().Assembly.Location;
            return addin;
        }

        Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return Assembly.Load(args.Name);
        }
        public Version GetAssemblyVersionNonLocking(string path) {
            return Assembly.ReflectionOnlyLoadFrom(path).GetName().Version;
        }
        public string GetAssemblyLastLoadedAssemblyPath()
        {
            return path;
        }
    }
}
