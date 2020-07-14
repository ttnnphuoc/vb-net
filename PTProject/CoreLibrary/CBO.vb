Imports System.Reflection

Public Class CBO
    Public Shared Function GetPropertyInfo(objType As Type) As List(Of PropertyInfo)
        Dim objProperties As List(Of PropertyInfo) = CType(DataCache.GetCache(objType.FullName), List(Of PropertyInfo))
        If objProperties Is Nothing Then
            objProperties = New List(Of PropertyInfo)
            For Each tempLoopVar_objProperty As PropertyInfo In objType.GetProperties()
                objProperties.Add(tempLoopVar_objProperty)
            Next
            objProperties.TrimExcess()
            DataCache.SetCache(objType.FullName, objProperties)
        End If
        Return objProperties
    End Function

    Private Shared Function GetOrdinals(ByVal objProperties As List(Of PropertyInfo), ByVal dr As IDataReader) As Integer()
        Dim arrOrdinals As Integer() = New Integer(objProperties.Count - 1) {}

        If dr IsNot Nothing Then
            Dim count As Integer = objProperties.Count - 1

            For i As Integer = 0 To count
                arrOrdinals(i) = -1

                Try
                    arrOrdinals(i) = dr.GetOrdinal(objProperties(i).Name)
                Catch
                End Try
            Next
        End If

        Return arrOrdinals
    End Function

    Private Shared Function CreateObject(ByVal objType As Type, ByVal dr As IDataReader, ByVal objProperties As List(Of PropertyInfo), ByVal arrOrdinals As Integer()) As Object
        Dim objObject As Object = Activator.CreateInstance(objType)
        Dim count As Integer = objProperties.Count - 1

        For i As Integer = 0 To count

            If objProperties(i).CanWrite Then

                If arrOrdinals(i) <> -1 Then

                    If Convert.IsDBNull(dr.GetValue(arrOrdinals(i))) Then
                        objProperties(i).SetValue(objObject, Null.SetNull(objProperties(i)), Nothing)
                    Else

                        Try
                            objProperties(i).SetValue(objObject, dr.GetValue(arrOrdinals(i)), Nothing)
                        Catch

                            Try
                                Dim pType As Type = objProperties(i).PropertyType

                                If pType.BaseType.Equals(GetType([Enum])) Then
                                    objProperties(i).SetValue(objObject, [Enum].ToObject(pType, dr.GetValue(arrOrdinals(i))), Nothing)
                                Else
                                    objProperties(i).SetValue(objObject, Convert.ChangeType(dr.GetValue(arrOrdinals(i)), pType), Nothing)
                                End If

                            Catch
                                objProperties(i).SetValue(objObject, Null.SetNull(objProperties(i)), Nothing)
                            End Try
                        End Try
                    End If
                End If
            End If
        Next

        Return objObject
    End Function

    Class SurroundingClass
        Public Shared Function FillObject(ByVal dr As IDataReader, ByVal objType As Type) As Object
            Dim objFillObject As Object
            Dim objProperties As List(Of PropertyInfo) = GetPropertyInfo(objType)
            Dim arrOrdinals As Integer() = GetOrdinals(objProperties, dr)

            If dr IsNot Nothing AndAlso dr.Read() Then
                objFillObject = CreateObject(objType, dr, objProperties, arrOrdinals)
            Else
                objFillObject = Nothing
            End If

            If dr IsNot Nothing Then
                dr.Close()
            End If

            Return objFillObject
        End Function

        Public Shared Function FillCollection(ByVal dr As IDataReader, ByVal objType As Type) As ArrayList
            Dim objFillCollection As ArrayList = New ArrayList()
            If dr Is Nothing Then Return objFillCollection
            Dim objFillObject As Object
            Dim objProperties As List(Of PropertyInfo) = GetPropertyInfo(objType)
            Dim arrOrdinals As Integer() = GetOrdinals(objProperties, dr)

            While dr.Read()
                objFillObject = CreateObject(objType, dr, objProperties, arrOrdinals)
                objFillCollection.Add(objFillObject)
            End While

            If dr IsNot Nothing Then
                dr.Close()
            End If

            Return objFillCollection
        End Function

        Public Shared Function FillCollection(ByVal dr As IDataReader, ByVal objType As Type, ByVal objToFill As IList) As IList
            If dr Is Nothing Then Return objToFill
            Dim objFillObject As Object
            Dim objProperties As List(Of PropertyInfo) = GetPropertyInfo(objType)
            Dim arrOrdinals As Integer() = GetOrdinals(objProperties, dr)

            While dr.Read()
                objFillObject = CreateObject(objType, dr, objProperties, arrOrdinals)
                objToFill.Add(objFillObject)
            End While

            If dr IsNot Nothing Then
                dr.Close()
            End If

            Return objToFill
        End Function
    End Class

    Private Shared Function CreateObject(Of T As {Class, New})(ByVal dr As IDataReader, ByVal objProperties As List(Of PropertyInfo), ByVal arrOrdinals As Integer()) As T
        Dim objObject As T = New T()
        Dim count As Integer = objProperties.Count - 1

        For i As Integer = 0 To count

            If objProperties(i).CanWrite Then

                If arrOrdinals(i) <> -1 Then

                    If Convert.IsDBNull(dr.GetValue(arrOrdinals(i))) Then
                        objProperties(i).SetValue(objObject, Null.SetNull(objProperties(i)), Nothing)
                    Else

                        Try
                            objProperties(i).SetValue(objObject, dr.GetValue(arrOrdinals(i)), Nothing)
                        Catch

                            Try
                                Dim pType As Type = objProperties(i).PropertyType

                                If pType.BaseType.Equals(GetType([Enum])) Then
                                    objProperties(i).SetValue(objObject, [Enum].ToObject(pType, dr.GetValue(arrOrdinals(i))), Nothing)
                                Else
                                    objProperties(i).SetValue(objObject, Convert.ChangeType(dr.GetValue(arrOrdinals(i)), pType), Nothing)
                                End If

                            Catch
                                objProperties(i).SetValue(objObject, Null.SetNull(objProperties(i)), Nothing)
                            End Try
                        End Try
                    End If
                End If
            End If
        Next

        Return objObject
    End Function

    Public Shared Function FillObject(Of T As {Class, New})(ByVal dr As IDataReader) As T
        Dim objFillObject As T = New T()
        Dim objProperties As List(Of PropertyInfo) = GetPropertyInfo(GetType(T))
        Dim arrOrdinals As Integer() = GetOrdinals(objProperties, dr)

        If dr IsNot Nothing AndAlso dr.Read() Then
            objFillObject = CreateObject(Of T)(dr, objProperties, arrOrdinals)
        Else
            objFillObject = Nothing
        End If

        If dr IsNot Nothing Then
            dr.Close()
        End If

        Return objFillObject
    End Function


    Public Shared Function FillCollection(Of T As {Class, New}, C As {ICollection(Of T), New})(ByVal dr As IDataReader) As C
        Dim objFillCollection As C = New C()
        If dr Is Nothing Then Return objFillCollection
        Dim objFillObject As T
        Dim objProperties As List(Of PropertyInfo) = GetPropertyInfo(GetType(T))
        Dim arrOrdinals As Integer() = GetOrdinals(objProperties, dr)

        While dr.Read()
            objFillObject = CreateObject(Of T)(dr, objProperties, arrOrdinals)
            objFillCollection.Add(objFillObject)
        End While

        If dr IsNot Nothing Then
            dr.Close()
        End If

        Return objFillCollection
    End Function

    Public Shared Function FillCollection(Of T As {Class, New})(ByVal dr As IDataReader) As List(Of T)
        Return FillCollection(Of T, List(Of T))(dr)
    End Function

    Public Shared Function FillCollection(Of T As {Class, New})(ByVal dr As IDataReader, ByVal objToFill As IList(Of T)) As IList(Of T)
        If dr Is Nothing Then Return objToFill
        Dim objFillObject As T
        Dim objProperties As List(Of PropertyInfo) = GetPropertyInfo(GetType(T))
        Dim arrOrdinals As Integer() = GetOrdinals(objProperties, dr)

        While dr.Read()
            objFillObject = CreateObject(Of T)(dr, objProperties, arrOrdinals)
            objToFill.Add(objFillObject)
        End While

        If dr IsNot Nothing Then
            dr.Close()
        End If

        Return objToFill
    End Function

    Public Shared Function InitializeObject(ByVal objObject As Object, ByVal objType As Type) As Object
        Dim objProperties As List(Of PropertyInfo) = GetPropertyInfo(objType)
        Dim count As Integer = objProperties.Count - 1

        For i As Integer = 0 To count

            If objProperties(i).CanWrite Then
                objProperties(i).SetValue(objObject, Null.SetNull(CType(objProperties(i), PropertyInfo)), Nothing)
            End If
        Next

        Return objObject
    End Function
End Class