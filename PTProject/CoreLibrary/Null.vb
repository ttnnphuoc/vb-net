Imports System.Reflection

Public Class Null
    Public Shared ReadOnly Property NullString As String
        Get
            Return ""
        End Get
    End Property

    Public Shared ReadOnly Property NullBoolean As Boolean
        Get
            Return False
        End Get
    End Property

    Public Shared ReadOnly Property NullDate As DateTime
        Get
            Return DateTime.MinValue
        End Get
    End Property

    Public Shared ReadOnly Property NullDecimal As Decimal
        Get
            Return Decimal.MinValue
        End Get
    End Property

    Public Shared ReadOnly Property NullDouble As Double
        Get
            Return Double.MinValue
        End Get
    End Property

    Public Shared ReadOnly Property NullGuid As Guid
        Get
            Return Guid.Empty
        End Get
    End Property

    Public Shared ReadOnly Property NullInteger As Integer
        Get
            Return -1
        End Get
    End Property

    Public Shared ReadOnly Property NullShort As Short
        Get
            Return -1
        End Get
    End Property

    Public Shared ReadOnly Property NullSingle As Single
        Get
            Return Single.MinValue
        End Get
    End Property

    Public Shared Function SetNull(ByVal objValue As Object, ByVal objField As Object) As Object
        If Convert.IsDBNull(objValue) Then

            If TypeOf objField Is Short Then
                Return NullShort
            End If

            If TypeOf objField Is Integer Then
                Return NullInteger
            End If

            If TypeOf objField Is Single Then
                Return NullSingle
            End If

            If TypeOf objField Is Double Then
                Return NullDouble
            End If

            If TypeOf objField Is Decimal Then
                Return NullDecimal
            End If

            If TypeOf objField Is DateTime Then
                Return NullDate
            End If

            If TypeOf objField Is String Then
                Return NullString
            End If

            If TypeOf objField Is Boolean Then
                Return NullBoolean
            End If

            If TypeOf objField Is Guid Then
                Return NullGuid
            End If

            Return Nothing
        End If

        Return objValue
    End Function

    Public Shared Function SetNull(ByVal objPropertyInfo As PropertyInfo) As Object
        Select Case objPropertyInfo.PropertyType.ToString()
            Case "System.Int16"
                Return NullShort
            Case "System.Int32"
                Return NullInteger
            Case "System.Single"
                Return NullSingle
            Case "System.Double"
                Return NullDouble
            Case "System.Decimal"
                Return NullDecimal
            Case "System.DateTime"
                Return NullDate
            Case "System.String"
                Return NullString
            Case "System.Boolean"
                Return NullBoolean
            Case "System.Guid"
                Return NullGuid
            Case Else
                Dim pType As Type = objPropertyInfo.PropertyType

                If pType.BaseType.Equals(GetType([Enum])) Then
                    Dim objEnumValues As Array = [Enum].GetValues(pType)
                    Array.Sort(objEnumValues)
                    Return [Enum].ToObject(pType, objEnumValues.GetValue(0))
                End If

                Return Nothing
        End Select
    End Function

End Class
