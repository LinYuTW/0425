Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fib(15) As Integer
        fib(0) = 1
        fib(1) = 1
        For i = 2 To 15
            fib(i) = fib(i - 1) + fib(i - 2)
        Next
        For i = 0 To 15
            TextBox1.Text = TextBox1.Text & "fib(" & i & ")=" & fib(i) & vbNewLine
        Next
    End Sub
End Class
