Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public NotInheritable Class SqlHelper
    Private Sub SqlHelper()

    End Sub

#Region "ExecuteNonQuery"
    Public Shared Function ExecuteNonQuery(connectionString As String, spName As String, ParamArray parameterValues As Object()) As Integer
        If connectionString Is Nothing Or connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If

        If spName Is Nothing Or spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If

        'If we receive parameter values, we need to figure out where they go
        If ((parameterValues IsNot Nothing) And (parameterValues.Length > 0)) Then

            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As SqlParameter() = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName)

            ' Assign the provided values to these parameters based on parameter order
            AssignParameterValues(commandParameters, parameterValues)

            ' Call the overload that takes an array of SqlParameters
            Return ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a SqlCommand (that returns no resultset and takes no parameters) against the database specified in 
    ''' the connection string
    ''' </summary>
    ''' <remarks>
    ''' e.g.:  
    '''  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders");
    ''' </remarks>
    ''' <param name="connectionString">A valid connection string for a SqlConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    Public Shared Function ExecuteNonQuery(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String) As Integer
        ' Pass through the call providing null for the set of SqlParameters
        Return ExecuteNonQuery(connectionString, commandType, commandText, CType(Nothing, SqlParameter()))
    End Function

    ''' <summary>
    ''' Execute a SqlCommand (that returns no resultset) against the database specified in the connection string 
    ''' using the provided parameters
    ''' </summary>
    ''' <remarks>
    ''' e.g.:  
    '''  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
    ''' </remarks>
    ''' <param name="connectionString">A valid connection string for a SqlConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    Public Shared Function ExecuteNonQuery(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ParamArray commandParameters As SqlParameter()) As Integer
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then Throw New ArgumentNullException("connectionString")

        ' Create & open a SqlConnection, and dispose of it after we are done
        Using connection As SqlConnection = New SqlConnection(connectionString)
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            Return ExecuteNonQuery(connection, commandType, commandText, commandParameters)
        End Using
    End Function

    ''' <summary>
    ''' Execute a SqlCommand (that returns no resultset) against the specified SqlConnection 
    ''' using the provided parameters.
    ''' </summary>
    ''' <remarks>
    ''' e.g.:  
    '''  int result = ExecuteNonQuery(conn, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
    ''' </remarks>
    ''' <param name="connection">A valid SqlConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    Public Shared Function ExecuteNonQuery(ByVal connection As SqlConnection, ByVal commandType As CommandType, ByVal commandText As String, ParamArray commandParameters As SqlParameter()) As Integer
        If connection Is Nothing Then Throw New ArgumentNullException("connection")
        Dim cmd As SqlCommand = New SqlCommand()
        Dim mustCloseConnection As Boolean = False
        PrepareCommand(cmd, connection, CType(Nothing, SqlTransaction), commandType, commandText, commandParameters, mustCloseConnection)
        Dim retval As Integer = cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        If mustCloseConnection Then connection.Close()
        Return retval
    End Function
#End Region

#Region "ExecuteDataset"
    Public Shared Function ExecuteDataset(connectionString As String, spName As String, ParamArray parameterValues() As Object) As DataSet
        If connectionString Is Nothing Or connectionString.Length = 0 Then
            Throw New ArgumentException("connectionString")
        End If
        If (parameterValues IsNot Nothing) And (parameterValues.Length > 0) Then

            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters() As SqlParameter = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName)
            ' Assign the provided values to these parameters based on parameter order
            AssignParameterValues(commandParameters, parameterValues)

            ' Call the overload that takes an array of SqlParameters
            Return ExecuteDataset(connectionString, CommandType.StoredProcedure, spName, commandParameters)
        Else

            'Otherwise we can just call the SP without params
            Return ExecuteDataset(connectionString, CommandType.StoredProcedure, spName)
        End If
    End Function


    ''' <summary>
    ''' Execute a SqlCommand (that returns a resultset) against the database specified in the connection string 
    ''' using the provided parameters.
    ''' </summary>
    ''' <remarks>
    ''' e.g.:  
    '''  DataSet ds = ExecuteDataset(connString, CommandType.StoredProcedure, "GetOrders", new SqlParameter("@prodid", 24));
    ''' </remarks>
    ''' <param name="connectionString">A valid connection string for a SqlConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param>
    ''' <returns>A dataset containing the resultset generated by the command</returns>
    Public Shared Function ExecuteDataset(connectionString As String, commandType As CommandType, commandText As String, ParamArray commandParameters As SqlParameter()) As DataSet
        If connectionString Is Nothing Or connectionString.Length = 0 Then
            Throw New ArgumentException("ConnectionString")
        End If

        Using connection As SqlConnection = New SqlConnection(connectionString)
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            Return ExecuteDataset(connection, commandType, commandText, commandParameters)
        End Using
    End Function

    '''<summary>
    ''' Execute a SqlCommand (that returns a resultset and takes no parameters) against the provided SqlConnection. 
    ''' </summary>
    ''' <remarks>
    ''' e.g.:  
    '''  DataSet ds = ExecuteDataset(conn, CommandType.StoredProcedure, "GetOrders");
    ''' </remarks>
    ''' <param name="connection">A valid SqlConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commentText">The stored procedure name or T-SQL command</param>
    ''' <returns>A dataset containing the resultset generated by the command</returns>
    Public Shared Function ExecuteDataset(connection As SqlConnection, commandType As CommandType, commentText As String) As DataSet
        ' Pass through the call providing null for the set of SqlParameters
        Return ExecuteDataset(connection, commandType, commentText, CType(Nothing, SqlParameter()))
    End Function

    ''' <summary>
    ''' Execute a SqlCommand (that returns a resultset) against the specified SqlConnection 
    ''' using the provided parameters.
    ''' </summary>
    ''' <remarks>
    ''' e.g.:  
    '''  DataSet ds = ExecuteDataset(conn, CommandType.StoredProcedure, "GetOrders", new SqlParameter("@prodid", 24));
    ''' </remarks>
    ''' <param name="connection">A valid SqlConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param>
    ''' <returns>A dataset containing the resultset generated by the command</returns>
    Public Shared Function ExecuteDataset(connection As SqlConnection, commandType As CommandType, commandText As String, ParamArray commandParameters As SqlParameter()) As DataSet
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        ' Create a command and prepare it for execution
        Dim cmd As SqlCommand = New SqlCommand()
        Dim mustCloseConnection As Boolean = False
        PrepareCommand(cmd, connection, CType(Nothing, SqlTransaction), commandType, commandText, mustCloseConnection, commandParameters)

        ' Create the DataAdapter & Dataset
        Using da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()

            ' Fill the Dataset using default values for DataTable names, etc
            da.Fill(ds)
            cmd.Parameters.Clear()
            If mustCloseConnection Then
                connection.Close()
            End If
            Return ds
        End Using

    End Function
    ''' <summary>
    ''' Execute a SqlCommand (that returns a resultset and takes no parameters) against the database specified in 
    ''' the connection string. 
    ''' </summary>
    ''' <remarks>
    ''' e.g.:  
    '''  DataSet ds = ExecuteDataset(connString, CommandType.StoredProcedure, "GetOrders");
    ''' </remarks>
    ''' <param name="connectionString">A valid connection string for a SqlConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commentText">The stored procedure name or T-SQL command</param>
    ''' <returns>A dataset containing the resultset generated by the command</returns>
    Public Shared Function ExecuteDataset(connectionString As String, commandType As CommandType, commentText As String) As DataSet
        ' Pass through the call providing null for the set of SqlParameters
        Return ExecuteDataset(connectionString, commandType, commentText, CType(Nothing, SqlParameter()))
    End Function


    Private Shared Sub PrepareCommand(command As SqlCommand, connection As SqlConnection, transaction As SqlTransaction, commandType As CommandType, commandText As String, mustCloseConnection As Boolean, ParamArray commandParameters() As SqlParameter)
        If command Is Nothing Then
            Throw New ArgumentException("connection")
        End If
        If commandText Is Nothing Then
            Throw New ArgumentException("commandText")
        End If

        'If the provided connection is not open, we will open it
        If connection.State <> ConnectionState.Open Then
            mustCloseConnection = True
            connection.Open()
        Else
            mustCloseConnection = False
        End If

        'Associate the connection with the command
        command.Connection = connection

        'Set the command text (stored procedure name or SQL statement)
        command.CommandText = commandText

        'If we were provided a transaction, assign it
        If transaction IsNot Nothing Then
            If transaction.Connection Is Nothing Then
                Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")
            Else
                command.Transaction = transaction
            End If
        End If

        'Set the command type
        command.CommandType = commandType

        'Attach the command parameters if they are provided
        If commandParameters IsNot Nothing Then
            AttachParameters(command, commandParameters)
        End If
        Return
    End Sub
#End Region

    ''' <summary>
    ''' This method is used to attach array of SqlParameters to a SqlCommand.
    '''
    ''' This method will assign a value of DbNull to any parameter with a direction of
    ''' InputOutput and a value of null.  
    ''' 
    ''' This behavior will prevent default values from being used, but
    ''' this will be the less common case than an intended pure output parameter (derived as InputOutput)
    ''' where the user provided no input value.
    ''' </summary>
    ''' <param name="command">The command to which the parameters will be added</param>
    ''' <param name="commandParameters">An array of SqlParameters to be added to command</param>
    Private Shared Sub AttachParameters(command As SqlCommand, ParamArray commandParameters() As SqlParameter)
        If command Is Nothing Then
            Throw New ArgumentException("command")
        End If
        If commandParameters IsNot Nothing Then
            For Each p As SqlParameter In commandParameters
                If p IsNot Nothing Then
                    'Check for derived output value with no value assigned
                    If (p.Direction = ParameterDirection.InputOutput Or p.Direction = ParameterDirection.Input) And (p.Value Is Nothing) Then
                        p.Value = DBNull.Value
                    End If
                    command.Parameters.Add(p)
                End If
            Next
        End If
    End Sub

    ''' <summary>
    ''' This method assigns dataRow column values to an array of SqlParameters
    ''' </summary>
    ''' <param name="commandParameters">Array of SqlParameters to be assigned values</param>
    Private Shared Sub AssignParameterValues(commandParameters As SqlParameter(), parameterValues As Object())
        If (commandParameters Is Nothing) Or (parameterValues Is Nothing) Then
            ' Do nothing if we get no data
            Return
        End If

        ' we must have the same number of values as we save parameters to put them in
        If commandParameters.Length <> parameterValues.Length Then
            Throw New ArgumentException("Parameter count does not match Parameter Value count.")
        End If

        ' Iterate through the SqlParameters, assigning the value from the corresponding position the value array
        Dim i As Integer = 0, j As Integer = commandParameters.Length

        While i < j

            If TypeOf parameterValues(i) Is IDbDataParameter Then
                Dim paramInstance As IDbDataParameter = CType(parameterValues(i), IDbDataParameter)

                If paramInstance.Value Is Nothing Then
                    commandParameters(i).Value = DBNull.Value
                Else
                    commandParameters(i).Value = paramInstance.Value
                End If
            ElseIf parameterValues(i) Is Nothing Then
                commandParameters(i).Value = DBNull.Value
            Else
                commandParameters(i).Value = parameterValues(i)
            End If

            i += 1
        End While
    End Sub

#Region "ExecuteReader"
    ''' <summary>
    ''' Execute a stored procedure via a SqlCommand (that returns a resultset) against the database specified in 
    ''' the connection string using the provided parameter values.  This method will query the database to discover the parameters for the 
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    '''
    ''' e.g.:  
    '''  SqlDataReader dr = ExecuteReader(connString, "GetOrders", 24, 36);
    ''' </remarks>
    ''' <param name="connectionString">A valid connection string for a SqlConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>A SqlDataReader containing the resultset generated by the command</returns>
    Public Shared Function ExecuteReader(ByVal connectionString As String, ByVal spName As String, ParamArray parameterValues As Object()) As SqlDataReader
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then Throw New ArgumentNullException("connectionString")
        If spName Is Nothing OrElse spName.Length = 0 Then Throw New ArgumentNullException("spName")

        If (parameterValues IsNot Nothing) AndAlso (parameterValues.Length > 0) Then
            Dim commandParameters As SqlParameter() = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName)
            AssignParameterValues(commandParameters, parameterValues)
            Return ExecuteReader(connectionString, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteReader(connectionString, CommandType.StoredProcedure, spName)
        End If
    End Function
    ''' <summary>
    ''' Execute a SqlCommand (that returns a resultset and takes no parameters) against the database specified in 
    ''' the connection string. 
    ''' </summary>
    ''' <remarks>
    ''' e.g.:  
    '''  SqlDataReader dr = ExecuteReader(connString, CommandType.StoredProcedure, "GetOrders");
    ''' </remarks>
    ''' <param name="connectionString">A valid connection string for a SqlConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <returns>A SqlDataReader containing the resultset generated by the command</returns>
    Public Shared Function ExecuteReader(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String) As SqlDataReader
        Return ExecuteReader(connectionString, commandType, commandText, CType(Nothing, SqlParameter()))
    End Function

    ''' <summary>
    ''' Execute a SqlCommand (that returns a resultset) against the database specified in the connection string 
    ''' using the provided parameters.
    ''' </summary>
    ''' <remarks>
    ''' e.g.:  
    '''  SqlDataReader dr = ExecuteReader(connString, CommandType.StoredProcedure, "GetOrders", new SqlParameter("@prodid", 24));
    ''' </remarks>
    ''' <param name="connectionString">A valid connection string for a SqlConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param>
    ''' <returns>A SqlDataReader containing the resultset generated by the command</returns>
    Public Shared Function ExecuteReader(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ParamArray commandParameters As SqlParameter()) As SqlDataReader
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then Throw New ArgumentNullException("connectionString")
        Dim connection As SqlConnection = Nothing

        Try
            connection = New SqlConnection(connectionString)
            connection.Open()
            Return ExecuteReader(connection, Nothing, commandType, commandText, commandParameters, SqlConnectionOwnership.Internal)
        Catch
            If connection IsNot Nothing Then connection.Close()
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Create and prepare a SqlCommand, and call ExecuteReader with the appropriate CommandBehavior.
    ''' </summary>
    ''' <remarks>
    ''' If we created and opened the connection, we want the connection to be closed when the DataReader is closed.
    ''' 
    ''' If the caller provided the connection, we want to leave it to them to manage.
    ''' </remarks>
    ''' <param name="connection">A valid SqlConnection, on which to execute this command</param>
    ''' <param name="transaction">A valid SqlTransaction, or 'null'</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <param name="commandParameters">An array of SqlParameters to be associated with the command or 'null' if no parameters are required</param>
    ''' <param name="connectionOwnership">Indicates whether the connection parameter was provided by the caller, or created by SqlHelper</param>
    ''' <returns>SqlDataReader containing the results of the command</returns>
    Private Shared Function ExecuteReader(ByVal connection As SqlConnection, ByVal transaction As SqlTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal commandParameters As SqlParameter(), ByVal connectionOwnership As SqlConnectionOwnership) As SqlDataReader
        If connection Is Nothing Then Throw New ArgumentNullException("connection")
        Dim mustCloseConnection As Boolean = False
        Dim cmd As SqlCommand = New SqlCommand()

        Try
            PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters, mustCloseConnection)
            Dim dataReader As SqlDataReader

            If connectionOwnership = SqlConnectionOwnership.External Then
                dataReader = cmd.ExecuteReader()
            Else
                dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            End If

            Dim canClear As Boolean = True

            For Each commandParameter As SqlParameter In cmd.Parameters
                If commandParameter.Direction <> ParameterDirection.Input Then canClear = False
            Next

            If canClear Then
                cmd.Parameters.Clear()
            End If

            Return dataReader
        Catch
            If mustCloseConnection Then connection.Close()
            Throw
        End Try
    End Function

    ''' <summary>
    ''' This enum is used to indicate whether the connection was provided by the caller, or created by SqlHelper, so that
    ''' we can set the appropriate CommandBehavior when calling ExecuteReader()
    ''' </summary>
    Private Enum SqlConnectionOwnership
        Internal
        External
    End Enum

    ''' <summary>
    ''' This method opens (if necessary) and assigns a connection, transaction, command type and parameters 
    ''' to the provided command
    ''' </summary>
    ''' <param name="command">The SqlCommand to be prepared</param>
    ''' <param name="connection">A valid SqlConnection, on which to execute this command</param>
    ''' <param name="transaction">A valid SqlTransaction, or 'null'</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <param name="commandParameters">An array of SqlParameters to be associated with the command or 'null' if no parameters are required</param>
    ''' <param name="mustCloseConnection"><c>true</c> if the connection was opened by the method, otherwose is false.</param>
    Private Shared Sub PrepareCommand(ByVal command As SqlCommand, ByVal connection As SqlConnection, ByVal transaction As SqlTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal commandParameters As SqlParameter(), <Out> ByRef mustCloseConnection As Boolean)
        If command Is Nothing Then Throw New ArgumentNullException("command")
        If commandText Is Nothing OrElse commandText.Length = 0 Then Throw New ArgumentNullException("commandText")

        If connection.State <> ConnectionState.Open Then
            mustCloseConnection = True
            connection.Open()
        Else
            mustCloseConnection = False
        End If

        command.Connection = connection
        command.CommandText = commandText

        If transaction IsNot Nothing Then
            If transaction.Connection Is Nothing Then Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")
            command.Transaction = transaction
        End If

        command.CommandType = commandType

        If commandParameters IsNot Nothing Then
            AttachParameters(command, commandParameters)
        End If

        Return
    End Sub
#End Region



End Class

''' <summary>
''' SqlHelperParameterCache provides functions to leverage a static cache of procedure parameters, and the
''' ability to discover parameters for stored procedures at run-time.
''' </summary>
Public NotInheritable Class SqlHelperParameterCache
    Private Sub SqlHelperParameterCache()

    End Sub

    Private Shared paramCache As Hashtable = Hashtable.Synchronized(New Hashtable())

    ''' <summary>
    ''' Retrieves the set of SqlParameters appropriate for the stored procedure
    ''' </summary>
    ''' <remarks>
    ''' This method will query the database for this information, and then store it in a cache for future requests.
    ''' </remarks>
    ''' <param name="connectionString">A valid connection string for a SqlConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <returns>An array of SqlParameters</returns>
    Public Shared Function GetSpParameterSet(connectionString As String, spName As String) As SqlParameter()
        Return GetSpParameterSet(connectionString, spName, False)
    End Function

    ''' <summary>
    ''' Retrieves the set of SqlParameters appropriate for the stored procedure
    ''' </summary>
    ''' <remarks>
    ''' This method will query the database for this information, and then store it in a cache for future requests.
    ''' </remarks>
    ''' <param name="connectionString">A valid connection string for a SqlConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="includeReturnValueParameter">A bool value indicating whether the return value parameter should be included in the results</param>
    ''' <returns>An array of SqlParameters</returns>
    Public Shared Function GetSpParameterSet(connectionString As String, spName As String, includeReturnValueParameter As Boolean) As SqlParameter()
        If (connectionString Is Nothing Or connectionString.Length = 0) Then
            Throw New ArgumentNullException("connectionString")
        End If

        If (spName Is Nothing Or spName.Length = 0) Then
            Throw New ArgumentNullException("spName")
        End If

        Using connection As SqlConnection = New SqlConnection(connectionString)
            Return GetSpParameterSetInternal(connection, spName, includeReturnValueParameter)
        End Using
    End Function

    ''' <summary>
    ''' Deep copy of cached SqlParameter array
    ''' </summary>
    ''' <param name="originalParameters"></param>
    ''' <returns></returns>
    Private Shared Function CloneParameters(ByVal originalParameters As SqlParameter()) As SqlParameter()
        Dim clonedParameters As SqlParameter() = New SqlParameter(originalParameters.Length - 1) {}
        Dim i As Integer = 0, j As Integer = originalParameters.Length

        While i < j
            clonedParameters(i) = CType((CType(originalParameters(i), ICloneable)).Clone(), SqlParameter)
            i += 1
        End While

        Return clonedParameters
    End Function


    ''' <summary>
    ''' Retrieves the set of SqlParameters appropriate for the stored procedure
    ''' </summary>
    ''' <param name="connection">A valid SqlConnection object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="includeReturnValueParameter">A bool value indicating whether the return value parameter should be included in the results</param>
    ''' <returns>An array of SqlParameters</returns>
    Private Shared Function GetSpParameterSetInternal(connection As SqlConnection, spName As String, includeReturnValueParameter As Boolean) As SqlParameter()
        If (connection Is Nothing) Then
            Throw New ArgumentNullException("connectionString")
        End If

        If (spName Is Nothing Or spName.Length = 0) Then
            Throw New ArgumentNullException("spName")
        End If

        Dim hashKey = connection.ConnectionString + ":" + spName + IIf(includeReturnValueParameter, "include ReturnValue Parameter", "")

        Dim cachedParameters As SqlParameter()

        cachedParameters = DirectCast(paramCache(hashKey), SqlParameter())
        If cachedParameters Is Nothing Then
            Dim spParameters = DiscoverSpParameterSet(connection, spName, includeReturnValueParameter)
            paramCache(hashKey) = spParameters
            cachedParameters = spParameters
        End If

        Return CloneParameters(cachedParameters)
    End Function


    ''' <summary>
    ''' Resolve at run time the appropriate set of SqlParameters for a stored procedure
    ''' </summary>
    ''' <param name="connection">A valid SqlConnection object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="includeReturnValueParameter">Whether or not to include their return value parameter</param>
    ''' <returns>The parameter array discovered.</returns>
    Private Shared Function DiscoverSpParameterSet(connection As SqlConnection, spName As String, includeReturnValueParameter As Boolean) As SqlParameter()
        If (connection Is Nothing) Then
            Throw New ArgumentNullException("connectionString")
        End If

        If (spName Is Nothing Or spName.Length = 0) Then
            Throw New ArgumentNullException("spName")
        End If

        Dim cmd As SqlCommand = New SqlCommand(spName, connection)
        cmd.CommandType = CommandType.StoredProcedure

        connection.Open()
        SqlCommandBuilder.DeriveParameters(cmd)
        connection.Close()

        If Not includeReturnValueParameter Then
            cmd.Parameters.RemoveAt(0)
        End If

        Dim discoveredParameters As SqlParameter() = New SqlParameter(cmd.Parameters.Count - 1) {}
        cmd.Parameters.CopyTo(discoveredParameters, 0)

        For Each discoveredParameter As SqlParameter In discoveredParameters
            discoveredParameter.Value = DBNull.Value
        Next

        Return discoveredParameters
    End Function

End Class
