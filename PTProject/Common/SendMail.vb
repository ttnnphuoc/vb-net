Imports System.Net.Mail

Public Class SendMail
    Public isSuccess As Boolean = False
    Public Sub sendMailToCustomer(email As String, content As String, urlFile As String, subject As String)
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("ttnnPhuoc@gmail.com", "Nhincaigi")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            If urlFile.Length > 0 Then
                e_mail.Attachments.Add(New Attachment(urlFile))
            End If

            e_mail.From = New MailAddress(email)
            e_mail.To.Add(email)
            e_mail.Subject = subject
            e_mail.IsBodyHtml = False
            e_mail.Body = content
            Smtp_Server.Send(e_mail)
            MsgBox("Gửi Mail Thành Công", MsgBoxStyle.Information, "Thông Báo")
            isSuccess = True
        Catch error_t As Exception
            isSuccess = False
            MsgBox("Gửi Mail Thất Bại", MsgBoxStyle.Information, "Thông Báo")
        End Try
    End Sub
End Class
