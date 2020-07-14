Partial Public Class FormAction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAction))
        Me.btnLoadHangHoa = New DevExpress.XtraEditors.SimpleButton()
        Me.grcData = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.sluPhanLoai = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.sluHangHoa = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSendMail = New DevExpress.XtraEditors.SimpleButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLoadReport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnView = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sluPhanLoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sluHangHoa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoadHangHoa
        '
        Me.btnLoadHangHoa.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadHangHoa.Appearance.Options.UseFont = True
        Me.btnLoadHangHoa.Location = New System.Drawing.Point(12, 12)
        Me.btnLoadHangHoa.Name = "btnLoadHangHoa"
        Me.btnLoadHangHoa.Size = New System.Drawing.Size(134, 30)
        Me.btnLoadHangHoa.TabIndex = 2
        Me.btnLoadHangHoa.Text = "Load Data"
        '
        'grcData
        '
        Me.grcData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcData.Location = New System.Drawing.Point(12, 90)
        Me.grcData.MainView = Me.GridView1
        Me.grcData.Name = "grcData"
        Me.grcData.Size = New System.Drawing.Size(765, 338)
        Me.grcData.TabIndex = 3
        Me.grcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grcData
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'sluPhanLoai
        '
        Me.sluPhanLoai.Location = New System.Drawing.Point(152, 17)
        Me.sluPhanLoai.Name = "sluPhanLoai"
        Me.sluPhanLoai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sluPhanLoai.Properties.NullText = ""
        Me.sluPhanLoai.Properties.View = Me.SearchLookUpEdit1View
        Me.sluPhanLoai.Size = New System.Drawing.Size(225, 20)
        Me.sluPhanLoai.TabIndex = 6
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'sluHangHoa
        '
        Me.sluHangHoa.Location = New System.Drawing.Point(383, 17)
        Me.sluHangHoa.Name = "sluHangHoa"
        Me.sluHangHoa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sluHangHoa.Properties.NullText = ""
        Me.sluHangHoa.Properties.View = Me.GridView2
        Me.sluHangHoa.Size = New System.Drawing.Size(394, 20)
        Me.sluHangHoa.TabIndex = 7
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'btnExport
        '
        Me.btnExport.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Appearance.Options.UseFont = True
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Location = New System.Drawing.Point(12, 54)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(71, 30)
        Me.btnExport.TabIndex = 8
        Me.btnExport.Text = "Export"
        '
        'btnSendMail
        '
        Me.btnSendMail.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendMail.Appearance.Options.UseFont = True
        Me.btnSendMail.Image = CType(resources.GetObject("btnSendMail.Image"), System.Drawing.Image)
        Me.btnSendMail.Location = New System.Drawing.Point(197, 54)
        Me.btnSendMail.Name = "btnSendMail"
        Me.btnSendMail.Size = New System.Drawing.Size(91, 30)
        Me.btnSendMail.TabIndex = 9
        Me.btnSendMail.Text = "Send Mail"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnImport
        '
        Me.btnImport.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Appearance.Options.UseFont = True
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.Location = New System.Drawing.Point(105, 54)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(71, 30)
        Me.btnImport.TabIndex = 10
        Me.btnImport.Text = "Import"
        '
        'btnLoadReport
        '
        Me.btnLoadReport.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadReport.Appearance.Options.UseFont = True
        Me.btnLoadReport.Image = CType(resources.GetObject("btnLoadReport.Image"), System.Drawing.Image)
        Me.btnLoadReport.Location = New System.Drawing.Point(311, 54)
        Me.btnLoadReport.Name = "btnLoadReport"
        Me.btnLoadReport.Size = New System.Drawing.Size(105, 30)
        Me.btnLoadReport.TabIndex = 11
        Me.btnLoadReport.Text = "Load Report"
        '
        'btnView
        '
        Me.btnView.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Appearance.Options.UseFont = True
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Image)
        Me.btnView.Location = New System.Drawing.Point(437, 54)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(81, 30)
        Me.btnView.TabIndex = 12
        Me.btnView.Text = "Xem"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(548, 54)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 30)
        Me.SimpleButton1.TabIndex = 13
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'FormAction
        '
        Me.ClientSize = New System.Drawing.Size(802, 440)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnLoadReport)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnSendMail)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.sluHangHoa)
        Me.Controls.Add(Me.sluPhanLoai)
        Me.Controls.Add(Me.grcData)
        Me.Controls.Add(Me.btnLoadHangHoa)
        Me.Name = "FormAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.grcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sluPhanLoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sluHangHoa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoadHangHoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents sluPhanLoai As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents sluHangHoa As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSendMail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton

#End Region

End Class
