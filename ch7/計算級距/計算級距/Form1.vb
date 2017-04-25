Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Randomize()
        Dim score(999) As Integer
        Dim num(11) As Integer
        Dim j As Integer
        For i As Integer = 0 To 999
            score(i) = CInt(Int(101 * Rnd()))
            j = score(i) / 10
            num(j) = num(j) + 1
        Next
        For i As Integer = 0 To 10
            TextBox1.Text = TextBox1.Text & num(i) & vbNewLine
        Next
    End Sub
End Class
