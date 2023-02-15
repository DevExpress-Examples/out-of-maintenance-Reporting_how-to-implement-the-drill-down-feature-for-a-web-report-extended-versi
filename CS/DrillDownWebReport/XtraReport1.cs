using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DrillDownWebReport {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void lbShowHide_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            lbShowHide.Text = DetailReport.DrillDownExpanded ? "Hide Details" : "Show Details";
        }

    }
}
