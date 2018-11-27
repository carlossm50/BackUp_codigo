using System;
using System.Reflection;
using InteropAsm;

namespace AppDomainTest {
    public class LoadManager : MarshalByRefObject {
        public IAddIn LoadAddIn(string asmPath, string typeToLoad) {
            Assembly asm = Assembly.LoadFile(asmPath);
            Type t = asm.GetType(typeToLoad);
            IAddIn addin = (IAddIn)Activator.CreateInstance(t);
            return addin;
        }
    }
}
