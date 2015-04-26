using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace cadencii {
    class CsDialog {
        StreamWriter file;

        public enum CsDlgType {
            About, Wait
        }

        public CsDialog(CsDlgType dialog) {
            file = new StreamWriter("dlg");

            if (dialog == CsDlgType.About) {
                
            }
        }
    }
}
