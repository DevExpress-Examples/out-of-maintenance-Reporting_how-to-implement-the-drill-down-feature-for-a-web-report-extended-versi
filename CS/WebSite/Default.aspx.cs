using System;
using System.Web.UI;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web;
using DevExpress.Web;
using System.Collections.Generic;

public partial class _Default : Page {

    protected void Page_Load(object sender, EventArgs e) {
        XtraReport1 report = new XtraReport1();
        DocumentViewer1.Report = report;
    }

    protected void ASPxCallbackPanel1_Callback(object source, CallbackEventArgsBase e) {
        XtraReport1 report = new XtraReport1();
        var skipedOparation = new SkipedOperation();
        skipedOparation.UpdateDetail(Convert.ToInt32(e.Parameter));
        DocumentViewer1.Report = report;
        DocumentViewer1.Report.CreateDocument();
    }
}
