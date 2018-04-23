using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using DevExpress.XtraReports.Web;
using DevExpress.XtraReports.UI;

public partial class _Default : System.Web.UI.Page 
{

    protected void Page_Load(object sender, EventArgs e)
    {
        XtraReport1 report = GetReport();

        ReportViewer1.Report = report;
    }

    protected void ASPxCallbackPanel1_Callback(object source, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
    {
        XtraReport1 report = GetReport();

        report.UpdateDetail(Convert.ToInt32(e.Parameter));

        ReportViewer1.Report = report;
    }

    protected void ReportViewer1_Unload(object sender, EventArgs e)
    {
        ((ReportViewer)sender).Report = null;
    }

    private XtraReport1 GetReport()
    {
        if (Session["report"] == null)
            Session["report"] = new XtraReport1();

        return Session["report"] as XtraReport1;
    }

}
