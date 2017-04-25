Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sum As Integer = 0
        Dim score() = {90, 90, 90, 80, 80, 80}
        For i = 0 To 5
            sum = sum + score(i)
            TextBox1.Text = TextBox1.Text & "score(" & i & ")=" & score(i) & vbNewLine
            TextBox1.Text = TextBox1.Text & "sum=" & sum & vbNewLine
        Next
    End Sub
End Class
