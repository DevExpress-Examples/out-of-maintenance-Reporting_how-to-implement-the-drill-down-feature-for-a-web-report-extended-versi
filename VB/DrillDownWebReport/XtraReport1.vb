Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace DrillDownWebReport

    Public Partial Class XtraReport1
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub lbShowHide_BeforePrint(ByVal sender As Object, ByVal e As CancelEventArgs)
            lbShowHide.Text = If(DetailReport.DrillDownExpanded, "Hide Details", "Show Details")
        End Sub
    End Class
End Namespace
