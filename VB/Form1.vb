Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace DynamicStyleSheet
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private report As XtraReport1
		Private path As String = ""

		Private Sub buttonPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonPreview.Click
			Dim sheetName As String = ""

			Select Case comboBox1.Text
				Case "Yellow"
					sheetName = "myStyle_Yellow.repss"
				Case "Blue"
					sheetName = "myStyle_Blue.repss"

			End Select

			report.StyleSheetPath = path & sheetName

			report.CreateDocument()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			report = New XtraReport1()
			printControl1.PrintingSystem = report.PrintingSystem

			comboBox1.SelectedIndex = 0
			path = Application.StartupPath & "\..\..\Styles\"
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			report.StyleSheet.SaveToFile(path & "currentStyleSheet.repss")
		End Sub
	End Class
End Namespace