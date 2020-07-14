Imports DataAccess
Imports DevExpress.XtraGrid.Views.Grid

Public Class XtraFormGridViewDevexpress
    Private Sub XtraFormGridViewDevexpress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data for grid control nhiều table
        'grcData.DataSource = HangHoa.GetHangHoaAndPhanLoai().Tables(0)

        ' Load data for grid control một table
        'grcData.DataSource = HangHoa.GetAllHangHoa()

        ' Load data for grid control theo tham số truyền vào
        grcData.DataSource = HangHoa.GetHangHoaByMaPL(3)

        ' Format hiển thị kiểu dữ (Number) liệu ứng với từng cột trên lưới 
        grvData.Columns("GIABAN").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        grvData.Columns("GIABAN").DisplayFormat.FormatString = "n0"
        grvData.Columns("GIAMUA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        grvData.Columns("GIAMUA").DisplayFormat.FormatString = "n0"

        ' Format hiển thị kiểu dữ (Number) liệu ứng với từng cột trên lưới 
        'grvData.Columns("NGAY").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        'grvData.Columns("NGAY").DisplayFormat.FormatString = "dd/MM/yyyy"
    End Sub

    ''' <summary>
    ''' Sự kiện cho phép thay đổi màu dòng, cột tùy theo giá trị.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvData_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles grvData.RowStyle
        ' Convert sender to GridView
        Dim View As GridView = DirectCast(sender, GridView)
        If (e.RowHandle >= 0) Then
            ' Get data with column name
            Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("MAPL"))

            If category = "1" Then
                e.Appearance.BackColor = Color.Yellow
            ElseIf category = "3" Then
                e.Appearance.BackColor = Color.Green
            End If
        End If
    End Sub

    ''' <summary>
    ''' Sự kiện xử lý khi dòng, cột trên lưới thay đổi
    ''' Sự kiện xử lý trước và sau khi dòng, cột update (Before/AfterRow/ColumnUpdate).
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvData_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grvData.CellValueChanged
        MessageBox.Show("Value After Changed: " + e.Value.ToString(), "Thông Báo")
    End Sub

    ''' <summary>
    ''' Sự kiện xử lý khi dòng, cột trên lưới thay đổi
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvData_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grvData.CellValueChanging
        MessageBox.Show("Value during Changing: " + e.Value.ToString(), "Thông Báo")
    End Sub


    ''' <summary>
    ''' Lấy giá trị dòng, cột hiện hành trên lưới. Gán giá trị dòng, cột hiện hành trên lưới.
    ''' Lấy giá trị kiểu Checkbox trên lưới
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvData_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvData.FocusedRowChanged
        'Dim view As GridView = TryCast(sender, GridView)
        'Dim hh As HangHoa = TryCast(view.GetRow(e.FocusedRowHandle), HangHoa)
        'MessageBox.Show("Row Handle: " + e.FocusedRowHandle.ToString() + " - Name:" + hh.TENVT + " - Value CheckBox: " + hh.LUUMAVT.ToString(), "Thông Báo")
    End Sub
End Class