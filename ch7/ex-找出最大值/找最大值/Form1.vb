Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Randomize()
        Dim score(9) As Integer
        Dim max As Integer
        For i As Integer = 0 To 9
            score(i) = CInt(Int(101 * Rnd()))
            TextBox1.Text = TextBox1.Text & score(i) & " "
            If max < score(i) Then
                max = score(i)
            End If
        Next
        TextBox1.Text = TextBox1.Text & "max=" & max
    End Sub
End Class
