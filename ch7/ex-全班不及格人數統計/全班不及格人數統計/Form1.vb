Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Randomize()
        Dim score(39) As Integer
        Dim count As Integer
        For i As Integer = 0 To 39
            score(i) = CInt(Int(101 * Rnd()))
            TextBox1.Text = TextBox1.Text & score(i) & vbNewLine
            If score(i) < 60 Then
                count = count + 1
            End If
        Next
        TextBox1.Text = TextBox1.Text & "不及格人數=" & count & vbNewLine
    End Sub
End Class
