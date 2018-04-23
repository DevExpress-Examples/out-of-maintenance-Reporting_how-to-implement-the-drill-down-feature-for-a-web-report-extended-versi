// Developer Express Code Central Example:
// How to implement the drill-down feature for XtraReports in a web application: Extended version
// 
// This example is an extended version of the
// http://www.devexpress.com/scid=E287example. The main improvement in this example
// is using the ASPxCallbackPanel to host a ReportToolbar and ReportViewer
// controls. Now all updates of the report content are performing via the callbacks
// which prevent the web page form entire regeneration and save the position of the
// IE window scrollbars. When the user clicks on the master report's nodes, the
// corresponding javascript event handler is called (the same technique is
// described in the http://www.devexpress.com/scid=E1337example) which initiates
// the callback to the server via the ASPxClientCallbackPanel.PerformCallback()
// method. Processing continued on the server in the server
// ASPxCallbackPanel.Callback() event handler in which the report content is
// updated. Once the callback is completed the resulting report appears on the
// client.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1598

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;

/// <summary>
/// Summary description for XtraReport1
/// </summary>
public class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DataSet1 dataSet11;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    private DetailReportBand DetailReport;
    private DetailBand Detail1;
    private XRLabel xrLabel3;
    private DataSet1TableAdapters.ProductsTableAdapter productsTableAdapter1;
    private DataSet1TableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
    private XRLabel xrLabel4;
    private XRLabel xrLabel5;
    private ReportHeaderBand ReportHeader;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public XtraReport1() {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        string resourceFileName = "XtraReport1.resx";
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
        this.dataSet11 = new DataSet1();
        this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
        this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        this.productsTableAdapter1 = new DataSet1TableAdapters.ProductsTableAdapter();
        this.categoriesTableAdapter1 = new DataSet1TableAdapters.CategoriesTableAdapter();
        this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
        ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrPictureBox1,
            this.xrLabel2,
            this.xrLabel1});
        this.Detail.Height = 69;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel4
        // 
        this.xrLabel4.BackColor = System.Drawing.Color.LightBlue;
        this.xrLabel4.Location = new System.Drawing.Point(0, 0);
        this.xrLabel4.Name = "xrLabel4";
        this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel4.Size = new System.Drawing.Size(17, 17);
        this.xrLabel4.StylePriority.UseBackColor = false;
        this.xrLabel4.Text = "-";
        this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrLabel4.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel4_BeforePrint);
        // 
        // xrPictureBox1
        // 
        this.xrPictureBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Categories.Picture", "")});
        this.xrPictureBox1.Location = new System.Drawing.Point(483, 0);
        this.xrPictureBox1.Name = "xrPictureBox1";
        this.xrPictureBox1.Size = new System.Drawing.Size(158, 58);
        this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
        // 
        // xrLabel2
        // 
        this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.Description", "")});
        this.xrLabel2.Location = new System.Drawing.Point(75, 33);
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel2.Size = new System.Drawing.Size(250, 25);
        this.xrLabel2.Text = "xrLabel2";
        // 
        // xrLabel1
        // 
        this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.CategoryName", "")});
        this.xrLabel1.Location = new System.Drawing.Point(75, 0);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.Size = new System.Drawing.Size(158, 25);
        this.xrLabel1.Text = "xrLabel1";
        this.xrLabel1.Font = new Font(this.Font.FontFamily.ToString(), 12, FontStyle.Bold);
        // 
        // xrLabel5
        // 
        this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.xrLabel5.ForeColor = System.Drawing.Color.Blue;
        this.xrLabel5.Location = new System.Drawing.Point(275, 0);
        this.xrLabel5.Name = "xrLabel5";
        this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel5.Size = new System.Drawing.Size(100, 33);
        this.xrLabel5.StylePriority.UseFont = false;
        this.xrLabel5.StylePriority.UseForeColor = false;
        this.xrLabel5.Text = "Catalog";
        // 
        // dataSet11
        // 
        this.dataSet11.DataSetName = "DataSet1";
        this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // DetailReport
        // 
        this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
        this.DetailReport.DataMember = "Products";
        this.DetailReport.DataSource = this.dataSet11;
        this.DetailReport.Level = 0;
        this.DetailReport.Name = "DetailReport";
        this.DetailReport.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.DetailReport_BeforePrint);
        // 
        // Detail1
        // 
        this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3});
        this.Detail1.Height = 25;
        this.Detail1.Name = "Detail1";
        // 
        // xrLabel3
        // 
        this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.ProductName", "")});
        this.xrLabel3.Location = new System.Drawing.Point(225, 0);
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel3.Size = new System.Drawing.Size(192, 25);
        this.xrLabel3.Text = "xrLabel3";
        // 
        // productsTableAdapter1
        // 
        this.productsTableAdapter1.ClearBeforeFill = true;
        // 
        // categoriesTableAdapter1
        // 
        this.categoriesTableAdapter1.ClearBeforeFill = true;
        // 
        // ReportHeader
        // 
        this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5});
        this.ReportHeader.Height = 33;
        this.ReportHeader.Name = "ReportHeader";
        // 
        // XtraReport1
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.DetailReport,
            this.ReportHeader});
        this.DataAdapter = this.categoriesTableAdapter1;
        this.DataSource = this.dataSet11;
        this.Version = "8.1";
        ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void DetailReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
        int catid = (int)GetCurrentColumnValue("CategoryID");

        // Fill the dataset with data from the data adapter.
        this.productsTableAdapter1.Fill(this.dataSet11.Products, catid);
        SkipedOperation operation = new SkipedOperation();
        if (operation.SkippedDetailBands.Contains(catid))
            e.Cancel = true;
    }

    private void xrLabel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
        XRLabel label = sender as XRLabel;
        int catid = (int)GetCurrentColumnValue("CategoryID");

        label.NavigateUrl = string.Format("javascript:parent.ASPxCallbackPanel1.PerformCallback('{0}');", catid.ToString());
        SkipedOperation operation = new SkipedOperation();
        if (operation.SkippedDetailBands.Contains(catid))
            label.Text = "+";
        else
            label.Text = "-";
    }
}
