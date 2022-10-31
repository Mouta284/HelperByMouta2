Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tarefas As String = TextBox1.Text
        ListBox1.Items.Add(tarefas)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        TextBox1.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tarefas As String = TextBox2.Text
        CheckedListBox1.Items.Add(tarefas)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckedListBox1.Items.Clear()
        TextBox2.Clear()

    End Sub
End Class