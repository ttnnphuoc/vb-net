Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Public Class ControlHelper
    Public Sub loadDataSearchLookup(Of T As {Class, New})(control As DevExpress.XtraEditors.SearchLookUpEdit, data As List(Of T), display As String, value As String)
        control.Properties.DataSource = data
        control.Properties.DisplayMember = display
        control.Properties.ValueMember = value
    End Sub

    Public Sub addNewRowToGridView(Of T As {Class, New})(control As DevExpress.XtraGrid.GridControl, dtObject As T)
        Dim data As List(Of T) = DirectCast(control.DataSource, List(Of T))
        If data.Count > 0 Then
            data.Add(dtObject)
            control.DataSource = data
        End If
    End Sub
End Class
