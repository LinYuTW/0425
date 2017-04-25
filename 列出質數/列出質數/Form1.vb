Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Flag As Integer
        Dim j As Integer
        For i As Integer = 2 To 10000
            Flag = 1
            j = 2
            Do While ((Flag = 1) And (j < i))
                If ((i Mod j) = 0) Then
                    Flag = 0
                End If
                j = j + 1
            Loop
            If (Flag = 1) Then
                TextBox1.Text = TextBox1.Text & i & "為質數" & vbNewLine
            End If
        Next
    End Sub
End Class
