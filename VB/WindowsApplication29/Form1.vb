Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Reflection
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraNavBar.ViewInfo

Namespace WindowsApplication29
  ''' <summary>
  ''' Summary description for Form1.
  ''' </summary>
  Public Class Form1
	  Inherits System.Windows.Forms.Form
		Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private WithEvents navBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem7 As DevExpress.XtraNavBar.NavBarItem
		Private navBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private navBarItem8 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem9 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem10 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem11 As DevExpress.XtraNavBar.NavBarItem
		Private panel1 As Panel
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.Container = Nothing

	Public Sub New()
	  '
	  ' Required for Windows Form Designer support
	  '
	  InitializeComponent()

	  '
	  ' TODO: Add any constructor code after InitializeComponent call
	  '
	End Sub

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
	  If disposing Then
		If components IsNot Nothing Then
		  components.Dispose()
		End If
	  End If
	  MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"
	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
		Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
		Me.navBarItem10 = New DevExpress.XtraNavBar.NavBarItem()
		Me.navBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
		Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
		Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
		Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
		Me.navBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
		Me.navBarItem8 = New DevExpress.XtraNavBar.NavBarItem()
		Me.navBarItem9 = New DevExpress.XtraNavBar.NavBarItem()
		Me.navBarItem11 = New DevExpress.XtraNavBar.NavBarItem()
		Me.navBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
		Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
		Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
		Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
		Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
		Me.panel1 = New System.Windows.Forms.Panel()
		CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.navBarControl1.SuspendLayout()
		Me.navBarGroupControlContainer1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' navBarControl1
		' 
		Me.navBarControl1.ActiveGroup = Me.navBarGroup1
		Me.navBarControl1.ContentButtonHint = Nothing
		Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer1)
		Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Right
		Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2, Me.navBarGroup3})
		Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6, Me.navBarItem7, Me.navBarItem8, Me.navBarItem9, Me.navBarItem10, Me.navBarItem11})
		Me.navBarControl1.Location = New System.Drawing.Point(344, 0)
		Me.navBarControl1.LookAndFeel.SkinName = "Liquid Sky"
		Me.navBarControl1.LookAndFeel.UseDefaultLookAndFeel = False
		Me.navBarControl1.Name = "navBarControl1"
		Me.navBarControl1.OptionsNavPane.ExpandedWidth = 280
		Me.navBarControl1.Size = New System.Drawing.Size(280, 374)
		Me.navBarControl1.TabIndex = 0
		Me.navBarControl1.Text = "navBarControl1"
		' 
		' navBarGroup1
		' 
		Me.navBarGroup1.Caption = "navBarGroup1"
		Me.navBarGroup1.Expanded = True
		Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem10)})
		Me.navBarGroup1.Name = "navBarGroup1"
		' 
		' navBarItem10
		' 
		Me.navBarItem10.Caption = "navBarItem10"
		Me.navBarItem10.Name = "navBarItem10"
		' 
		' navBarGroupControlContainer1
		' 
		Me.navBarGroupControlContainer1.Controls.Add(Me.panel1)
		Me.navBarGroupControlContainer1.ForeColor = System.Drawing.Color.Transparent
		Me.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1"
		Me.navBarGroupControlContainer1.Size = New System.Drawing.Size(276, 78)
		Me.navBarGroupControlContainer1.TabIndex = 2
		' 
		' navBarGroup2
		' 
		Me.navBarGroup2.Caption = "navBarGroup2"
		Me.navBarGroup2.Expanded = True
		Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem7), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem8), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem9), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem11)})
		Me.navBarGroup2.Name = "navBarGroup2"
		' 
		' navBarItem5
		' 
		Me.navBarItem5.Caption = "navBarItem5"
		Me.navBarItem5.Name = "navBarItem5"
		' 
		' navBarItem6
		' 
		Me.navBarItem6.Caption = "navBarItem6"
		Me.navBarItem6.Name = "navBarItem6"
		' 
		' navBarItem7
		' 
		Me.navBarItem7.Caption = "navBarItem7"
		Me.navBarItem7.Name = "navBarItem7"
		' 
		' navBarItem8
		' 
		Me.navBarItem8.Caption = "navBarItem8"
		Me.navBarItem8.Name = "navBarItem8"
		' 
		' navBarItem9
		' 
		Me.navBarItem9.Caption = "navBarItem9"
		Me.navBarItem9.Name = "navBarItem9"
		' 
		' navBarItem11
		' 
		Me.navBarItem11.Caption = "navBarItem11"
		Me.navBarItem11.Name = "navBarItem11"
		' 
		' navBarGroup3
		' 
		Me.navBarGroup3.Caption = "navBarGroup3"
		Me.navBarGroup3.ControlContainer = Me.navBarGroupControlContainer1
		Me.navBarGroup3.Expanded = True
		Me.navBarGroup3.GroupClientHeight = 80
		Me.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
		Me.navBarGroup3.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4)})
		Me.navBarGroup3.Name = "navBarGroup3"
'		Me.navBarGroup3.CalcGroupClientHeight += New DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventHandler(Me.navBarGroup3_CalcGroupClientHeight);
		' 
		' navBarItem1
		' 
		Me.navBarItem1.Caption = "navBarItem1"
		Me.navBarItem1.Name = "navBarItem1"
		' 
		' navBarItem2
		' 
		Me.navBarItem2.Caption = "navBarItem2"
		Me.navBarItem2.Name = "navBarItem2"
		' 
		' navBarItem3
		' 
		Me.navBarItem3.Caption = "navBarItem3"
		Me.navBarItem3.Name = "navBarItem3"
		' 
		' navBarItem4
		' 
		Me.navBarItem4.Caption = "navBarItem4"
		Me.navBarItem4.Name = "navBarItem4"
		' 
		' panel1
		' 
		Me.panel1.BackColor = System.Drawing.Color.Red
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.panel1.ForeColor = System.Drawing.Color.Transparent
		Me.panel1.Location = New System.Drawing.Point(0, 0)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(276, 78)
		Me.panel1.TabIndex = 0
		' 
		' Form1
		' 
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(624, 374)
		Me.Controls.Add(Me.navBarControl1)
		Me.Name = "Form1"
		Me.Text = "Form1"
'		Me.Load += New System.EventHandler(Me.Form1_Load);
		CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.navBarControl1.ResumeLayout(False)
		Me.navBarGroupControlContainer1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	#End Region

	''' <summary>
	''' The main entry point for the application.
	''' </summary>
	<STAThread> _
	Shared Sub Main()
	  Application.Run(New Form1())
	End Sub

		Private Function GetViewInfo(ByVal navBar As NavBarControl) As NavBarViewInfo
			Dim fi As FieldInfo = GetType(NavBarControl).GetField("viewInfo", BindingFlags.NonPublic Or BindingFlags.Instance)
			Return TryCast(fi.GetValue(navBar), NavBarViewInfo)
		End Function

		Private Function GetGroupPainter(ByVal navBar As NavBarControl) As ExplorerBarNavGroupPainter
			Dim fi As FieldInfo = GetType(NavBarControl).GetField("groupPainter", BindingFlags.NonPublic Or BindingFlags.Instance)
			Return TryCast(fi.GetValue(navBar), ExplorerBarNavGroupPainter)
		End Function

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		End Sub

		Private Sub navBarGroup3_CalcGroupClientHeight(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs) Handles navBarGroup3.CalcGroupClientHeight
			Dim vi As NavBarViewInfo = GetViewInfo(navBarControl1)
			Dim gi As NavGroupInfoArgs = TryCast(vi.Groups(vi.Groups.Count - 1), NavGroupInfoArgs)
			Dim groupPainter As ExplorerBarNavGroupPainter = GetGroupPainter(navBarControl1)
			groupPainter.CalcFooterBounds(gi, gi.Bounds)
			Dim delta As Integer = gi.Bounds.Top - vi.Client.Top
			Dim ch As Integer = vi.Client.Height - delta - gi.Bounds.Height - gi.FooterBounds.Height
			e.Height = ch
		End Sub
  End Class
End Namespace
