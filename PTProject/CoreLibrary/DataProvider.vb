Public MustInherit Class DataProvider
    Public Shared ReadOnly Property Instance As DataProvider
        Get
            If Instance Is Nothing Then Instance = New SqlDataProvider("ConnectionString")
            Return Instance
        End Get
    End Property

    Public MustOverride Function ExecuteNonQuery(spName As String, ParamArray parameterValues() As Object) As Integer
    Public MustOverride Function ExecuteDataset(spName As String, ParamArray parameterValues() As Object) As DataSet
    Public MustOverride Function ExecuteReader(spName As String, ParamArray parameterValues() As Object) As IDataReader
End Class
