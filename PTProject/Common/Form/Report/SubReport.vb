Imports DataAccess

Public Class SubReport

    Private Sub SubReport_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        DataSource = PhanLoai.GetAllPhanLoai()
        xrMa.DataBindings.Add("Text", DataSource, "MAPL")
        xrTen.DataBindings.Add("Text", DataSource, "TEN")
        xrGhiChu.DataBindings.Add("Text", DataSource, "GHICHU")
    End Sub
End Class