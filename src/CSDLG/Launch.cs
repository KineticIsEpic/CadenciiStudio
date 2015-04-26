using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSDLG {
    public partial class Launch : Form {
        public Launch() {
            InitializeComponent();

            try {
                if (File.Exists("dlg")) {
                    StreamReader sr = new StreamReader("dlg");
                    string dlgtxt = sr.ReadToEnd();
                    sr.Close();

                    if (dlgtxt.ToLower() == "aboutdlg") {
                        new AboutDlg().ShowDialog();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + "\r\nStack Trace:\r\n" + ex.StackTrace, "Error"); }
        }
    }
}
