Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Randomize()
        Dim prize(6) As Integer
        Dim pz As Integer
        Dim repeat(48) As Integer
        Dim count As Integer = 1
        Do While (count <= 6)
            pz = CInt(Int(48 * Rnd() + 1))
            If (repeat(pz) = 0) Then
                repeat(pz) = 1
                prize(count) = pz
                count = count + 1
                TextBox1.Text = TextBox1.Text & pz & " "
            Else
                Continue Do
            End If
        Loop
    End Sub
End Class
