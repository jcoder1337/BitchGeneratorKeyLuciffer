Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim serial As Long
        Dim sm As New SecurityManager
        serial = sm.GetSerial
        txtSerial.Text = serial
    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        Dim key As Long
        If Not Long.TryParse(txtKey.Text, key) Then
            MessageBox.Show("Invalid activation key")
            Exit Sub
        End If

        Dim sm As New SecurityManager
        If sm.CheckKey(key) Then
            MessageBox.Show("Activation was successful")
        Else
            MessageBox.Show("Activation was unsuccessful")
        End If
    End Sub

    Private Sub btnKeyGenerator_Click(sender As Object, e As EventArgs) Handles btnKeyGenerator.Click
        Dim frm As New Generator
        frm.ShowDialog()
    End Sub
End Class
