Imports CoreLibrary

Public Class HangHoa
    Public Property MAVT As Integer
    Public Property MAPL As Integer
    Public Property TENVT As String
    Public Property GIAMUA As Decimal
    Public Property GIABAN As Decimal
    Public Property TYLE As Decimal
    Public Property QUICACH As String
    Public Property DVT As String
    Public Property GHICHU As String
    Public Property TONKHOMIN As Integer
    Public Property TONKHOMAX As Integer
    Public Property TONKHO As Integer
    Public Property LUUMAVT As Boolean
    Public Property NgayNhap As String

    Public Sub HangHoa()

    End Sub

    Public Shared Function GetAllHangHoa() As List(Of HangHoa)
        Return CBO.FillCollection(Of HangHoa)(DataProvider.Instance.ExecuteReader("GetAllHangHoa"))
    End Function

    Public Shared Function GetHangHoaByID(id As Integer) As HangHoa
        Return CBO.FillObject(Of HangHoa)(DataProvider.Instance.ExecuteReader("GetHangHoaByID", id))
    End Function

    Public Shared Function UpdateHangHoa(hangHoa As HangHoa) As Integer
        Return DataProvider.Instance.ExecuteNonQuery("UpdateHangHoaByID", hangHoa.MAVT, hangHoa.TENVT, hangHoa.QUICACH, hangHoa.GIABAN, hangHoa.GHICHU)
    End Function

    Public Shared Function GetHangHoaAndPhanLoai() As DataSet
        Return DataProvider.Instance.ExecuteDataset("GetHangHoa")
    End Function

    Public Shared Function GetHangHoaByMaPL(maPl As Integer) As List(Of HangHoa)
        Return CBO.FillCollection(Of HangHoa)(DataProvider.Instance.ExecuteReader("GetHangHoaByMaPL", maPl))
    End Function
End Class
