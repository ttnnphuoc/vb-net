Imports System.Data.OleDb
Imports System.IO
Imports DevExpress.DataAccess.Excel
Imports System.ComponentModel

Public Class FuncCommon

    Public isImport As Boolean = False
    Public isSuccess As Boolean = False
    Public msg As String
    Public Sub ExportExcel(data As DataTable, path As String)
        Try
            Dim _excel As New Microsoft.Office.Interop.Excel.Application
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

            wBook = _excel.Workbooks.Add()
            wSheet = DirectCast(wBook.ActiveSheet(), Microsoft.Office.Interop.Excel.Worksheet)
            Dim dt As System.Data.DataTable = data
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                _excel.Cells(1, colIndex) = dc.ColumnName
            Next
            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    _excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next

            wSheet.Columns.AutoFit()
            Dim strFileName As String = path + "\data.xlsx"
            If System.IO.File.Exists(strFileName) Then
                System.IO.File.Delete(strFileName)
            End If

            wBook.SaveAs(strFileName)
            wBook.Close()
            _excel.Quit()
            msg = "Thành Công"
            isSuccess = True
        Catch ex As Exception
            msg = "Thất Bại"
            isSuccess = False
        End Try
    End Sub

    Public Function ImportExcel(ByVal fileName As String) As Object

        Try
            Dim excelDataSource As New ExcelDataSource()
            excelDataSource.FileName = fileName

            Dim schemaProvider As IExcelSchemaProvider = TryCast(excelDataSource.GetService(GetType(IExcelSchemaProvider)), IExcelSchemaProvider)

            Dim worksheetSettings As New ExcelWorksheetSettings("Sheet1")
            excelDataSource.SourceOptions = New ExcelSourceOptions(worksheetSettings)

            Dim availableFields() As FieldInfo = schemaProvider.GetSchema(excelDataSource.FileName, Nothing, ExcelDocumentFormat.Xlsx, excelDataSource.SourceOptions, System.Threading.CancellationToken.None)
            For Each field As FieldInfo In availableFields
                If field.Name = "Value" Then
                    field.Type = GetType(String)
                    excelDataSource.Schema.Add(field)
                Else
                    excelDataSource.Schema.Add(field)
                End If
            Next field
            excelDataSource.Fill()
            isSuccess = True
            msg = "Thành Công"
            Return excelDataSource
        Catch ex As Exception
            isSuccess = False
            msg = "Thất Bại"
            Return Nothing
        End Try
    End Function

    Public Function ConvertToDataTable(Of T)(list As IList(Of T)) As DataTable
        Dim entityType As Type = GetType(T)
        Dim table As New DataTable()
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(entityType)

        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name, If(Nullable.GetUnderlyingType(prop.PropertyType), prop.PropertyType))
        Next
        For Each item As T In list
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next
            table.Rows.Add(row)
        Next
        Return table

    End Function
End Class
