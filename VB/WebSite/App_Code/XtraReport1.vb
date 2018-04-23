Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
	Inherits DevExpress.XtraReports.UI.XtraReport
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private dataSet11 As DataSet1
	Private xrPictureBox1 As XRPictureBox
	Private xrLabel2 As XRLabel
	Private xrLabel1 As XRLabel
	Private WithEvents DetailReport As DetailReportBand
	Private Detail1 As DetailBand
	Private xrLabel3 As XRLabel
	Private productsTableAdapter1 As DataSet1TableAdapters.ProductsTableAdapter
	Private categoriesTableAdapter1 As DataSet1TableAdapters.CategoriesTableAdapter
	Private WithEvents xrLabel4 As XRLabel
	Private xrLabel5 As XRLabel
	Private ReportHeader As ReportHeaderBand
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
		'
		' TODO: Add constructor logic here
		'
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resourceFileName As String = "XtraReport1.resx"
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
		Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
		Me.dataSet11 = New DataSet1()
		Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
		Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
		Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
		Me.productsTableAdapter1 = New DataSet1TableAdapters.ProductsTableAdapter()
		Me.categoriesTableAdapter1 = New DataSet1TableAdapters.CategoriesTableAdapter()
		Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
		CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel4, Me.xrPictureBox1, Me.xrLabel2, Me.xrLabel1})
		Me.Detail.Height = 69
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrLabel4
		' 
		Me.xrLabel4.BackColor = System.Drawing.Color.LightBlue
		Me.xrLabel4.Location = New System.Drawing.Point(0, 0)
		Me.xrLabel4.Name = "xrLabel4"
		Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel4.Size = New System.Drawing.Size(17, 17)
		Me.xrLabel4.StylePriority.UseBackColor = False
		Me.xrLabel4.Text = "-"
		Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
'		Me.xrLabel4.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrLabel4_BeforePrint);
		' 
		' xrPictureBox1
		' 
		Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture", "")})
		Me.xrPictureBox1.Location = New System.Drawing.Point(483, 0)
		Me.xrPictureBox1.Name = "xrPictureBox1"
		Me.xrPictureBox1.Size = New System.Drawing.Size(158, 58)
		Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
		' 
		' xrLabel2
		' 
		Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description", "")})
		Me.xrLabel2.Location = New System.Drawing.Point(75, 33)
		Me.xrLabel2.Name = "xrLabel2"
		Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel2.Size = New System.Drawing.Size(250, 25)
		Me.xrLabel2.Text = "xrLabel2"
		' 
		' xrLabel1
		' 
		Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName", "")})
		Me.xrLabel1.Location = New System.Drawing.Point(75, 0)
		Me.xrLabel1.Name = "xrLabel1"
		Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel1.Size = New System.Drawing.Size(158, 25)
		Me.xrLabel1.Text = "xrLabel1"
		Me.xrLabel1.Font = New Font(Me.Font.FontFamily.ToString(), 12, FontStyle.Bold)
		' 
		' xrLabel5
		' 
		Me.xrLabel5.Font = New System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
		Me.xrLabel5.ForeColor = System.Drawing.Color.Blue
		Me.xrLabel5.Location = New System.Drawing.Point(275, 0)
		Me.xrLabel5.Name = "xrLabel5"
		Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel5.Size = New System.Drawing.Size(100, 33)
		Me.xrLabel5.StylePriority.UseFont = False
		Me.xrLabel5.StylePriority.UseForeColor = False
		Me.xrLabel5.Text = "Catalog"
		' 
		' dataSet11
		' 
		Me.dataSet11.DataSetName = "DataSet1"
		Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		' 
		' DetailReport
		' 
		Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1})
		Me.DetailReport.DataMember = "Products"
		Me.DetailReport.DataSource = Me.dataSet11
		Me.DetailReport.Level = 0
		Me.DetailReport.Name = "DetailReport"
'		Me.DetailReport.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.DetailReport_BeforePrint);
		' 
		' Detail1
		' 
		Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3})
		Me.Detail1.Height = 25
		Me.Detail1.Name = "Detail1"
		' 
		' xrLabel3
		' 
		Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName", "")})
		Me.xrLabel3.Location = New System.Drawing.Point(225, 0)
		Me.xrLabel3.Name = "xrLabel3"
		Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel3.Size = New System.Drawing.Size(192, 25)
		Me.xrLabel3.Text = "xrLabel3"
		' 
		' productsTableAdapter1
		' 
		Me.productsTableAdapter1.ClearBeforeFill = True
		' 
		' categoriesTableAdapter1
		' 
		Me.categoriesTableAdapter1.ClearBeforeFill = True
		' 
		' ReportHeader
		' 
		Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel5})
		Me.ReportHeader.Height = 33
		Me.ReportHeader.Name = "ReportHeader"
		' 
		' XtraReport1
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.DetailReport, Me.ReportHeader})
		Me.DataAdapter = Me.categoriesTableAdapter1
		Me.DataSource = Me.dataSet11
		Me.Version = "8.1"
		CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private skippedDetailBands_Renamed As Hashtable

	Public Property SkippedDetailBands() As Hashtable
		Get
			If skippedDetailBands_Renamed Is Nothing Then
				skippedDetailBands_Renamed = New Hashtable()
			End If

			Return skippedDetailBands_Renamed
		End Get
		Set(ByVal value As Hashtable)
			skippedDetailBands_Renamed = value
		End Set
	End Property

	Public Sub UpdateDetail(ByVal detailID As Integer)
		If SkippedDetailBands.Contains(detailID) Then
			SkippedDetailBands(detailID) = Not Convert.ToBoolean(SkippedDetailBands(detailID))
		Else
			SkippedDetailBands.Add(detailID, True)
		End If

		Me.CreateDocument()
	End Sub

	Private Sub DetailReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles DetailReport.BeforePrint
		Dim catid As Integer = CInt(Fix(GetCurrentColumnValue("CategoryID")))

		' Fill the dataset with data from the data adapter.
		Me.productsTableAdapter1.Fill(Me.dataSet11.Products, catid)

		If SkippedDetailBands.Contains(catid) Then
			e.Cancel = Convert.ToBoolean(SkippedDetailBands(catid))
		End If
	End Sub

	Private Sub xrLabel4_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabel4.BeforePrint
		Dim label As XRLabel = TryCast(sender, XRLabel)
		Dim catid As Integer = CInt(Fix(GetCurrentColumnValue("CategoryID")))

		label.NavigateUrl = String.Format("javascript:DXReportViewerWindow.ASPxCallbackPanel1.PerformCallback({0})", catid.ToString())

		If SkippedDetailBands.Contains(catid) AndAlso CBool(SkippedDetailBands(catid)) = True Then
			label.Text = "+"
		Else
			label.Text = "-"
		End If
	End Sub

End Class
