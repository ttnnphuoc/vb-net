Public Class FrmExportImport

    Public isImport As Boolean = False
    Public dataImport As DevExpress.DataAccess.Excel.ExcelDataSource
    Dim func As New Common.FuncCommon
    Public dataExport As DataTable

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtPath.Text = "" Then
            MsgBox("Vui lòng chọn thư mục", MsgBoxStyle.Information, "Thông Báo")
            Return
        End If

        If isImport Then
            dataImport = DirectCast(func.ImportExcel(txtPath.Text), DevExpress.DataAccess.Excel.ExcelDataSource)
        Else
            func.ExportExcel(dataExport, txtPath.Text)
        End If

        ' Close form current if success
        If func.isSuccess Then
            MsgBox(func.msg, MsgBoxStyle.Information, "Thông Báo")
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnChooseFolder.Click
        If isImport Then
            ' Fiter format file to import
            openFileImport.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
            Dim result As DialogResult = openFileImport.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                txtPath.Text = System.IO.Path.GetFullPath(openFileImport.FileName)
            End If
        Else
            Dim result As DialogResult = chooseFolderExport.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                txtPath.Text = chooseFolderExport.SelectedPath
            End If
        End If
    End Sub

End Class