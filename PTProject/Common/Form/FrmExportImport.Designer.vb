<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportImport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExportImport))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPath = New DevExpress.XtraEditors.TextEdit()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.chooseFolderExport = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnChooseFolder = New DevExpress.XtraEditors.SimpleButton()
        Me.openFileImport = New System.Windows.Forms.OpenFileDialog()
        CType(Me.txtPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Thư Mục"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(59, 17)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Properties.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(339, 20)
        Me.txtPath.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(159, 55)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'btnChooseFolder
        '
        Me.btnChooseFolder.Image = CType(resources.GetObject("btnChooseFolder.Image"), System.Drawing.Image)
        Me.btnChooseFolder.Location = New System.Drawing.Point(404, 16)
        Me.btnChooseFolder.Name = "btnChooseFolder"
        Me.btnChooseFolder.Size = New System.Drawing.Size(26, 22)
        Me.btnChooseFolder.TabIndex = 7
        '
        'FrmExportImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 90)
        Me.Controls.Add(Me.btnChooseFolder)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "FrmExportImport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmExport"
        CType(Me.txtPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chooseFolderExport As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnChooseFolder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents openFileImport As System.Windows.Forms.OpenFileDialog
End Class
