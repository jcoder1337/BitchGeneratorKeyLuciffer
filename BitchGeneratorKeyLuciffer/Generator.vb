Public Class Generator
    Private Sub btnKeyGenerator_Click(sender As Object, e As EventArgs) Handles btnKeyGenerator.Click
        Dim serial As Long
        If Not Long.TryParse(txtSerial.Text, serial) Then
            MessageBox.Show("Inavlid serial number")
            Exit Sub
        End If

        Dim kg As New KeyGenerator
        Dim key As Long = kg.GenerateKey(serial)
        txtKey.Text = key
    End Sub
End Class