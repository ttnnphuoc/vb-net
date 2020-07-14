Imports System
Imports System.Web

Public Class DataCache
    Public Shared Function GetCache(cacheKey As String) As Object
        Return HttpRuntime.Cache(cacheKey)
    End Function

    Public Shared Sub RemoveCache(cacheKey As String)
        Dim objCache As System.Web.Caching.Cache = HttpRuntime.Cache
        If Not Convert.ToBoolean(objCache(cacheKey) Is Nothing) Then
            objCache.Remove(cacheKey)
        End If
    End Sub

    Public Shared Sub SetCache(cacheKey As String, objObject As Object)
        HttpRuntime.Cache.Insert(cacheKey, objObject)
    End Sub

    Public Shared Sub SetCache(ByVal cacheKey As String, ByVal objObject As Object, ByVal AbsoluteExpiration As DateTime)
        HttpRuntime.Cache.Insert(cacheKey, objObject, Nothing, AbsoluteExpiration, TimeSpan.Zero)
    End Sub

    Public Shared Sub SetCache(ByVal cacheKey As String, ByVal objObject As Object, ByVal SlidingExpiration As Integer)
        HttpRuntime.Cache.Insert(cacheKey, objObject, Nothing, DateTime.MaxValue, TimeSpan.FromSeconds(CDbl(SlidingExpiration)))
    End Sub

    Public Shared Sub SetCache(ByVal cacheKey As String, ByVal objObject As Object, ByVal objDependency As System.Web.Caching.CacheDependency)
        HttpRuntime.Cache.Insert(cacheKey, objObject, objDependency)
    End Sub
End Class
