Imports CoreLibrary

Public Class PhanLoai
    Public Property MAPL As Integer
    Public Property TEN As String
    Public Property GHICHU As String

    Public Sub PhanLoai()

    End Sub

    Public Shared Function GetAllPhanLoai() As List(Of PhanLoai)
        Return CBO.FillCollection(Of PhanLoai)(SqlDataProvider.Instance.ExecuteReader("GetAllPhanLoai"))
    End Function
End Class
