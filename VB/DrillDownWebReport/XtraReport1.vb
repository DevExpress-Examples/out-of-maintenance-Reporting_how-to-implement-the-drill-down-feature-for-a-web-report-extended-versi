Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace DrillDownWebReport
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub lbShowHide_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles lbShowHide.BeforePrint
            lbShowHide.Text = If(DetailReport.DrillDownExpanded, "Hide Details", "Show Details")
        End Sub

    End Class
End Namespace
