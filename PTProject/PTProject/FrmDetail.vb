Imports CoreLibrary
Imports DataAccess

Public Class FrmDetail
    Public id As Integer

    Private Sub FrmDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As HangHoa = HangHoa.GetHangHoaByID(id)
        If data Is Nothing Then
            MsgBox("Không có dữ liệu", MsgBoxStyle.Information, "Thông Báo")
            Return
        End If

        txtMaVT.Text = data.MAVT.ToString()
        txtMaPL.Text = data.MAPL.ToString()
        txtQuyCach.Text = data.QUICACH
        speGiaBan.Text = data.GIABAN.ToString("N0")
        mmoGhiChu.Text = data.GHICHU
        txtTenVT.Text = data.TENVT
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim data As HangHoa = New HangHoa()
        data.MAVT = Integer.Parse(txtMaVT.Text.ToString())
        data.TENVT = txtTenVT.Text
        data.QUICACH = txtQuyCach.Text
        data.GIABAN = Decimal.Parse(speGiaBan.EditValue.ToString())
        data.GHICHU = mmoGhiChu.Text

        Dim rs As Integer = HangHoa.UpdateHangHoa(data)
        If rs > 0 Then
            MsgBox("Thành Công", MsgBoxStyle.Information, "Thông Báo")
            Me.Close()
            FormAction.btnLoadHangHoa.PerformClick()
        Else
            MsgBox("Thất Bại", MsgBoxStyle.Information, "Thông Báo")
        End If
    End Sub
End Class