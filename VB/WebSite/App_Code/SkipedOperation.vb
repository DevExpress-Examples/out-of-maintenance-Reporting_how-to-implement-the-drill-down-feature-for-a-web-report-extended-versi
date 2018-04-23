Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

''' <summary>
''' Summary description for SkipedOperation
''' </summary>
Public Class SkipedOperation
	Private skippedDetailBands_Renamed As List(Of Integer)

	Public Property SkippedDetailBands() As List(Of Integer)
		Get
			If HttpContext.Current.Session("SkipedList") Is Nothing Then
				HttpContext.Current.Session("SkipedList") = New List(Of Integer)()
			End If
			Return TryCast(HttpContext.Current.Session("SkipedList"), List(Of Integer))
		End Get
		Set(ByVal value As List(Of Integer))
			skippedDetailBands_Renamed = value
		End Set
	End Property

	Public Sub UpdateDetail(ByVal detailID As Integer)
		If SkippedDetailBands.Contains(detailID) Then
			SkippedDetailBands.Remove(detailID)
		Else
			SkippedDetailBands.Add(detailID)
		End If
	End Sub
End Class