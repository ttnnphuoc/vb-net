<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSendMail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSendMail))
        Me.txtToMail = New System.Windows.Forms.TextBox()
        Me.btnSendMail = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.mmContent = New DevExpress.XtraEditors.MemoEdit()
        Me.dialogAttached = New System.Windows.Forms.OpenFileDialog()
        Me.txtAtt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnChooseFolder = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.mmContent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAtt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtToMail
        '
        Me.txtToMail.Location = New System.Drawing.Point(41, 31)
        Me.txtToMail.Name = "txtToMail"
        Me.txtToMail.Size = New System.Drawing.Size(363, 21)
        Me.txtToMail.TabIndex = 0
        '
        'btnSendMail
        '
        Me.btnSendMail.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendMail.Appearance.Options.UseFont = True
        Me.btnSendMail.Image = CType(resources.GetObject("btnSendMail.Image"), System.Drawing.Image)
        Me.btnSendMail.Location = New System.Drawing.Point(41, 280)
        Me.btnSendMail.Name = "btnSendMail"
        Me.btnSendMail.Size = New System.Drawing.Size(75, 30)
        Me.btnSendMail.TabIndex = 4
        Me.btnSendMail.Text = "Gửi"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(41, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Email"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(41, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Chủ Đề"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(41, 77)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(363, 21)
        Me.txtSubject.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(41, 104)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Tệp Đính Kèm"
        '
        'mmContent
        '
        Me.mmContent.Location = New System.Drawing.Point(41, 168)
        Me.mmContent.Name = "mmContent"
        Me.mmContent.Size = New System.Drawing.Size(363, 96)
        Me.mmContent.TabIndex = 3
        '
        'txtAtt
        '
        Me.txtAtt.Location = New System.Drawing.Point(41, 123)
        Me.txtAtt.Name = "txtAtt"
        Me.txtAtt.Properties.ReadOnly = True
        Me.txtAtt.Size = New System.Drawing.Size(329, 20)
        Me.txtAtt.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(41, 149)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "Nội Dung"
        '
        'btnChooseFolder
        '
        Me.btnChooseFolder.Image = CType(resources.GetObject("btnChooseFolder.Image"), System.Drawing.Image)
        Me.btnChooseFolder.Location = New System.Drawing.Point(376, 121)
        Me.btnChooseFolder.Name = "btnChooseFolder"
        Me.btnChooseFolder.Size = New System.Drawing.Size(28, 23)
        Me.btnChooseFolder.TabIndex = 11
        '
        'FrmSendMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 338)
        Me.Controls.Add(Me.btnChooseFolder)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtAtt)
        Me.Controls.Add(Me.mmContent)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnSendMail)
        Me.Controls.Add(Me.txtToMail)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSendMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gửi Mail"
        CType(Me.mmContent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAtt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtToMail As System.Windows.Forms.TextBox
    Friend WithEvents btnSendMail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mmContent As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dialogAttached As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtAtt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnChooseFolder As DevExpress.XtraEditors.SimpleButton
End Class
