<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDetail))
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.mmoGhiChu = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTenVT = New DevExpress.XtraEditors.TextEdit()
        Me.txtQuyCach = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaVT = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaPL = New DevExpress.XtraEditors.TextEdit()
        Me.speGiaBan = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.mmoGhiChu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenVT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuyCach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaVT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaPL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.speGiaBan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(359, 249)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(34, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Mã VT"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(34, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Tên VT"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(34, 111)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "Giá Bán"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(34, 85)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "Quy Cách"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(263, 24)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl5.TabIndex = 16
        Me.LabelControl5.Text = "Mã PL"
        '
        'mmoGhiChu
        '
        Me.mmoGhiChu.Location = New System.Drawing.Point(99, 134)
        Me.mmoGhiChu.Name = "mmoGhiChu"
        Me.mmoGhiChu.Size = New System.Drawing.Size(335, 96)
        Me.mmoGhiChu.TabIndex = 7
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(34, 136)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl6.TabIndex = 18
        Me.LabelControl6.Text = "Ghi Chú"
        '
        'txtTenVT
        '
        Me.txtTenVT.Location = New System.Drawing.Point(99, 53)
        Me.txtTenVT.Name = "txtTenVT"
        Me.txtTenVT.Size = New System.Drawing.Size(335, 20)
        Me.txtTenVT.TabIndex = 19
        '
        'txtQuyCach
        '
        Me.txtQuyCach.Location = New System.Drawing.Point(99, 82)
        Me.txtQuyCach.Name = "txtQuyCach"
        Me.txtQuyCach.Size = New System.Drawing.Size(335, 20)
        Me.txtQuyCach.TabIndex = 21
        '
        'txtMaVT
        '
        Me.txtMaVT.Location = New System.Drawing.Point(99, 21)
        Me.txtMaVT.Name = "txtMaVT"
        Me.txtMaVT.Properties.ReadOnly = True
        Me.txtMaVT.Size = New System.Drawing.Size(119, 20)
        Me.txtMaVT.TabIndex = 22
        '
        'txtMaPL
        '
        Me.txtMaPL.Location = New System.Drawing.Point(315, 21)
        Me.txtMaPL.Name = "txtMaPL"
        Me.txtMaPL.Properties.ReadOnly = True
        Me.txtMaPL.Size = New System.Drawing.Size(119, 20)
        Me.txtMaPL.TabIndex = 23
        '
        'speGiaBan
        '
        Me.speGiaBan.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.speGiaBan.Location = New System.Drawing.Point(99, 108)
        Me.speGiaBan.Name = "speGiaBan"
        Me.speGiaBan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.speGiaBan.Properties.DisplayFormat.FormatString = "N0"
        Me.speGiaBan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.speGiaBan.Size = New System.Drawing.Size(335, 20)
        Me.speGiaBan.TabIndex = 24
        '
        'FrmDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 316)
        Me.Controls.Add(Me.speGiaBan)
        Me.Controls.Add(Me.txtMaPL)
        Me.Controls.Add(Me.txtMaVT)
        Me.Controls.Add(Me.txtQuyCach)
        Me.Controls.Add(Me.txtTenVT)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.mmoGhiChu)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnSave)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Chi Tiết"
        CType(Me.mmoGhiChu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenVT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuyCach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaVT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaPL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.speGiaBan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mmoGhiChu As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenVT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtQuyCach As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaVT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaPL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents speGiaBan As DevExpress.XtraEditors.SpinEdit
End Class
