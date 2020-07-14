Public Class FrmSendMail 
    Dim sendMail As New Common.SendMail

    Private Sub btnSendMail_Click(sender As Object, e As EventArgs) Handles btnSendMail.Click
        sendMail.sendMailToCustomer(txtToMail.Text, mmContent.Text, txtAtt.Text, txtSubject.Text)
        If sendMail.isSuccess Then
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnChooseFolder.Click
        Dim result As DialogResult = dialogAttached.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            txtAtt.Text = System.IO.Path.GetFullPath(dialogAttached.FileName)
        End If
    End Sub
End Class