Imports Microsoft.VisualBasic
Imports System
Namespace DynamicStyleSheet
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.buttonPreview = New System.Windows.Forms.Button()
			Me.printControl1 = New DevExpress.XtraPrinting.Control.PrintControl()
			Me.button1 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Items.AddRange(New Object() { "Yellow", "Blue"})
			Me.comboBox1.Location = New System.Drawing.Point(12, 12)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(121, 21)
			Me.comboBox1.TabIndex = 1
			' 
			' buttonPreview
			' 
			Me.buttonPreview.Location = New System.Drawing.Point(150, 12)
			Me.buttonPreview.Name = "buttonPreview"
			Me.buttonPreview.Size = New System.Drawing.Size(100, 23)
			Me.buttonPreview.TabIndex = 2
			Me.buttonPreview.Text = "Preview"
			Me.buttonPreview.UseVisualStyleBackColor = True
'			Me.buttonPreview.Click += New System.EventHandler(Me.buttonPreview_Click);
			' 
			' printControl1
			' 
			Me.printControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.printControl1.BackColor = System.Drawing.Color.Empty
			Me.printControl1.ForeColor = System.Drawing.Color.Empty
			Me.printControl1.IsMetric = False
			Me.printControl1.Location = New System.Drawing.Point(12, 41)
			Me.printControl1.Name = "printControl1"
			Me.printControl1.Size = New System.Drawing.Size(653, 448)
			Me.printControl1.TabIndex = 3
			Me.printControl1.TooltipFont = New System.Drawing.Font("Tahoma", 8.25F)
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(278, 13)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(185, 23)
			Me.button1.TabIndex = 4
			Me.button1.Text = "Save the Current Style Sheet"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(677, 501)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.printControl1)
			Me.Controls.Add(Me.buttonPreview)
			Me.Controls.Add(Me.comboBox1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private comboBox1 As System.Windows.Forms.ComboBox
		Private WithEvents buttonPreview As System.Windows.Forms.Button
		Private printControl1 As DevExpress.XtraPrinting.Control.PrintControl
		Private WithEvents button1 As System.Windows.Forms.Button
	End Class
End Namespace

