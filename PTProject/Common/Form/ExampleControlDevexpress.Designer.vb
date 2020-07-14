<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExampleControlDevexpress
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnClick = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClick2 = New DevExpress.XtraEditors.SimpleButton()
        Me.chkOption = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCheck2 = New DevExpress.XtraEditors.CheckEdit()
        Me.cbbEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Menus = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu21ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnContextMenuTrip = New DevExpress.XtraEditors.SimpleButton()
        Me.dteEdit = New DevExpress.XtraEditors.DateEdit()
        Me.groupControl = New DevExpress.XtraEditors.GroupControl()
        Me.lblText = New DevExpress.XtraEditors.LabelControl()
        Me.lstBoxControl = New DevExpress.XtraEditors.ListBoxControl()
        Me.BrManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.pnControl = New DevExpress.XtraEditors.PanelControl()
        Me.pctEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.pgBarControl = New DevExpress.XtraEditors.ProgressBarControl()
        Me.radioGroup = New DevExpress.XtraEditors.RadioGroup()
        Me.tabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        CType(Me.chkOption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCheck2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menus.SuspendLayout()
        CType(Me.dteEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgBarControl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        CType(Me.txtEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.Location = New System.Drawing.Point(111, 12)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(96, 37)
        Me.btnClick.TabIndex = 0
        Me.btnClick.Text = "Click"
        '
        'btnClick2
        '
        Me.btnClick2.Location = New System.Drawing.Point(9, 12)
        Me.btnClick2.Name = "btnClick2"
        Me.btnClick2.Size = New System.Drawing.Size(96, 37)
        Me.btnClick2.TabIndex = 1
        Me.btnClick2.Text = "Click 2"
        '
        'chkOption
        '
        Me.chkOption.Location = New System.Drawing.Point(12, 68)
        Me.chkOption.Name = "chkOption"
        Me.chkOption.Properties.Caption = "Is Check"
        Me.chkOption.Size = New System.Drawing.Size(75, 19)
        Me.chkOption.TabIndex = 2
        '
        'chkCheck2
        '
        Me.chkCheck2.Location = New System.Drawing.Point(12, 93)
        Me.chkCheck2.Name = "chkCheck2"
        Me.chkCheck2.Properties.Caption = "Is Check 2"
        Me.chkCheck2.Size = New System.Drawing.Size(75, 19)
        Me.chkCheck2.TabIndex = 3
        '
        'cbbEdit
        '
        Me.cbbEdit.Location = New System.Drawing.Point(12, 127)
        Me.cbbEdit.Name = "cbbEdit"
        Me.cbbEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbEdit.Size = New System.Drawing.Size(100, 20)
        Me.cbbEdit.TabIndex = 4
        '
        'Menus
        '
        Me.Menus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu1ToolStripMenuItem, Me.Menu2ToolStripMenuItem})
        Me.Menus.Name = "Menu"
        Me.Menus.Size = New System.Drawing.Size(115, 48)
        '
        'Menu1ToolStripMenuItem
        '
        Me.Menu1ToolStripMenuItem.Name = "Menu1ToolStripMenuItem"
        Me.Menu1ToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.Menu1ToolStripMenuItem.Text = "Menu 1"
        '
        'Menu2ToolStripMenuItem
        '
        Me.Menu2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu21ToolStripMenuItem})
        Me.Menu2ToolStripMenuItem.Name = "Menu2ToolStripMenuItem"
        Me.Menu2ToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.Menu2ToolStripMenuItem.Text = "Menu 2"
        '
        'Menu21ToolStripMenuItem
        '
        Me.Menu21ToolStripMenuItem.Name = "Menu21ToolStripMenuItem"
        Me.Menu21ToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.Menu21ToolStripMenuItem.Text = "Menu 2.1"
        '
        'btnContextMenuTrip
        '
        Me.btnContextMenuTrip.ContextMenuStrip = Me.Menus
        Me.btnContextMenuTrip.Location = New System.Drawing.Point(12, 176)
        Me.btnContextMenuTrip.Name = "btnContextMenuTrip"
        Me.btnContextMenuTrip.Size = New System.Drawing.Size(119, 37)
        Me.btnContextMenuTrip.TabIndex = 6
        Me.btnContextMenuTrip.Text = "Context Menu Strip"
        '
        'dteEdit
        '
        Me.dteEdit.EditValue = Nothing
        Me.dteEdit.Location = New System.Drawing.Point(12, 237)
        Me.dteEdit.Name = "dteEdit"
        Me.dteEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteEdit.Size = New System.Drawing.Size(119, 20)
        Me.dteEdit.TabIndex = 7
        '
        'groupControl
        '
        Me.groupControl.Location = New System.Drawing.Point(333, 12)
        Me.groupControl.Name = "groupControl"
        Me.groupControl.Size = New System.Drawing.Size(200, 100)
        Me.groupControl.TabIndex = 8
        Me.groupControl.Text = "GroupControl1"
        '
        'lblText
        '
        Me.lblText.Location = New System.Drawing.Point(333, 134)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(66, 13)
        Me.lblText.TabIndex = 9
        Me.lblText.Text = "LabelControl1"
        '
        'lstBoxControl
        '
        Me.lstBoxControl.Location = New System.Drawing.Point(333, 162)
        Me.lstBoxControl.Name = "lstBoxControl"
        Me.lstBoxControl.Size = New System.Drawing.Size(120, 95)
        Me.lstBoxControl.TabIndex = 10
        '
        'BrManager
        '
        Me.BrManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3})
        Me.BrManager.DockControls.Add(Me.barDockControlTop)
        Me.BrManager.DockControls.Add(Me.barDockControlBottom)
        Me.BrManager.DockControls.Add(Me.barDockControlLeft)
        Me.BrManager.DockControls.Add(Me.barDockControlRight)
        Me.BrManager.Form = Me
        Me.BrManager.MainMenu = Me.Bar2
        Me.BrManager.MaxItemId = 0
        Me.BrManager.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Tools"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1115, 49)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 335)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1115, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 49)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 286)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1115, 49)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 286)
        '
        'pnControl
        '
        Me.pnControl.Location = New System.Drawing.Point(477, 162)
        Me.pnControl.Name = "pnControl"
        Me.pnControl.Size = New System.Drawing.Size(200, 95)
        Me.pnControl.TabIndex = 15
        '
        'pctEdit
        '
        Me.pctEdit.Location = New System.Drawing.Point(178, 161)
        Me.pctEdit.MenuManager = Me.BrManager
        Me.pctEdit.Name = "pctEdit"
        Me.pctEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pctEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.pctEdit.Size = New System.Drawing.Size(100, 96)
        Me.pctEdit.TabIndex = 16
        '
        'pgBarControl
        '
        Me.pgBarControl.Location = New System.Drawing.Point(178, 129)
        Me.pgBarControl.MenuManager = Me.BrManager
        Me.pgBarControl.Name = "pgBarControl"
        Me.pgBarControl.Size = New System.Drawing.Size(100, 18)
        Me.pgBarControl.TabIndex = 17
        '
        'radioGroup
        '
        Me.radioGroup.Location = New System.Drawing.Point(553, 16)
        Me.radioGroup.MenuManager = Me.BrManager
        Me.radioGroup.Name = "radioGroup"
        Me.radioGroup.Size = New System.Drawing.Size(100, 96)
        Me.radioGroup.TabIndex = 18
        '
        'tabControl
        '
        Me.tabControl.Location = New System.Drawing.Point(693, 12)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedTabPage = Me.XtraTabPage1
        Me.tabControl.Size = New System.Drawing.Size(300, 245)
        Me.tabControl.TabIndex = 19
        Me.tabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(294, 217)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(294, 217)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'txtEdit
        '
        Me.txtEdit.Location = New System.Drawing.Point(178, 68)
        Me.txtEdit.MenuManager = Me.BrManager
        Me.txtEdit.Name = "txtEdit"
        Me.txtEdit.Size = New System.Drawing.Size(100, 20)
        Me.txtEdit.TabIndex = 20
        '
        'ToolTipController1
        '
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 315)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Nothing
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1115, 20)
        '
        'ExampleControlDevexpress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 358)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.txtEdit)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.radioGroup)
        Me.Controls.Add(Me.pgBarControl)
        Me.Controls.Add(Me.pctEdit)
        Me.Controls.Add(Me.pnControl)
        Me.Controls.Add(Me.lstBoxControl)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.groupControl)
        Me.Controls.Add(Me.dteEdit)
        Me.Controls.Add(Me.btnContextMenuTrip)
        Me.Controls.Add(Me.cbbEdit)
        Me.Controls.Add(Me.chkCheck2)
        Me.Controls.Add(Me.chkOption)
        Me.Controls.Add(Me.btnClick2)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExampleControlDevexpress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Example Control Devexpress"
        CType(Me.chkOption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCheck2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menus.ResumeLayout(False)
        CType(Me.dteEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgBarControl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        CType(Me.txtEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClick As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClick2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkOption As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCheck2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbbEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Menus As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Menu1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu21ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnContextMenuTrip As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dteEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents groupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblText As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lstBoxControl As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents BrManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents pnControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pctEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents pgBarControl As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents radioGroup As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents tabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
End Class
