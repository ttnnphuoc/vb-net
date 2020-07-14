Imports System.Configuration

Public Class SqlDataProvider : Inherits DataProvider
    Private connectionString As String

    Public Sub New(ByVal connectionStringName As String)
        Me.connectionString = ConfigurationManager.ConnectionStrings(connectionStringName).ConnectionString
    End Sub

    Public Overrides Function ExecuteDataset(spName As String, ParamArray parameterValues() As Object) As DataSet
        Return SqlHelper.ExecuteDataset(connectionString, spName, parameterValues)
    End Function

    Public Overrides Function ExecuteNonQuery(spName As String, ParamArray parameterValues() As Object) As Integer
        Return SqlHelper.ExecuteNonQuery(connectionString, spName, parameterValues)
    End Function

    Public Overrides Function ExecuteReader(spName As String, ParamArray parameterValues() As Object) As IDataReader
        Return SqlHelper.ExecuteReader(connectionString, spName, parameterValues)
    End Function

End Class
