Public Class KeyGenerator
    Public Function GenerateKey(ByVal serial As Long) As Long
        Dim x As Long = serial
        Return x * x + 41.0 / x + 212.0 * (x / 4.0)
    End Function
End Class
