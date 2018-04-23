using System;
using System.Web.UI;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web;
using DevExpress.Web.ASPxClasses;
// ...

public partial class _Default : Page {

    protected void Page_Load(object sender, EventArgs e) {
        XtraReport1 report = GetReport();
        ReportViewer1.Report = report;
    }

    protected void ASPxCallbackPanel1_Callback(object source, CallbackEventArgsBase e) {
        XtraReport1 report = GetReport();
        report.UpdateDetail(Convert.ToInt32(e.Parameter));
        ReportViewer1.Report = report;
    }

    protected void ReportViewer1_Unload(object sender, EventArgs e) {
        ((ReportViewer)sender).Report = null;
    }

    private XtraReport1 GetReport() {
        if (Session["report"] == null) {
            Session["report"] = new XtraReport1();
        }
        return Session["report"] as XtraReport1;
    }

}
