using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace ClassLibrary1 {
    public class Class1 : MarshalByRefObject, InteropAsm.IAddIn {
        string text;
        public Class1() {
            text = ConfigurationManager.AppSettings["foo"];
        }

        #region IAddIn Members

        public string Text {
            get { return text; }
        }

        #endregion
    }
}
