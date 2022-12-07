Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web
Imports DevExpress.Web
Imports System.Collections.Generic

Partial Public Class _Default
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim report As New XtraReport1()
		DocumentViewer1.Report = report
	End Sub

	Protected Sub ASPxCallbackPanel1_Callback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		Dim report As New XtraReport1()
		Dim skipedOparation = New SkipedOperation()
		skipedOparation.UpdateDetail(Convert.ToInt32(e.Parameter))
		DocumentViewer1.Report = report
		DocumentViewer1.Report.CreateDocument()
	End Sub
End Class
