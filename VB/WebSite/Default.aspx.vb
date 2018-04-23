Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections
Imports DevExpress.XtraReports.Web
Imports DevExpress.XtraReports.UI

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim report As XtraReport1 = GetReport()

		ReportViewer1.Report = report
	End Sub

	Protected Sub ASPxCallbackPanel1_Callback(ByVal source As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase)
		Dim report As XtraReport1 = GetReport()

		report.UpdateDetail(Convert.ToInt32(e.Parameter))

		ReportViewer1.Report = report
	End Sub

	Protected Sub ReportViewer1_Unload(ByVal sender As Object, ByVal e As EventArgs)
		CType(sender, ReportViewer).Report = Nothing
	End Sub

	Private Function GetReport() As XtraReport1
		If Session("report") Is Nothing Then
			Session("report") = New XtraReport1()
		End If

		Return TryCast(Session("report"), XtraReport1)
	End Function

End Class
