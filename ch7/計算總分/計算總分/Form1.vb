Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sum As Integer = 0
        Dim score() = {95, 75, 80, 69, 87, 59, 43, 8, 97, 86, 73, 90}
        Array.Sort(score)
        For i = 0 To 11 Step 1
            sum = sum + score(i)
            TextBox1.Text = TextBox1.Text & "score(" & i & ")=" & score(i) & vbNewLine
            TextBox1.Text = TextBox1.Text & "sum=" & sum & vbNewLine
        Next
        sum = sum / score.Length
        TextBox1.Text = TextBox1.Text & "總共：" & score.Length & " 位" & vbNewLine
        TextBox1.Text = TextBox1.Text & "平均：" & sum
    End Sub
End Class
