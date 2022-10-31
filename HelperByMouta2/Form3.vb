Imports System.Security.Policy

Public Class HM2
    Dim x As Double, soma As Double, numero As Double, quantidade As Double, subt As Double

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        x = 2
        ListBox3.Items.Add(x)
        ListBox3.Items.Add("After you choose the amount of numbers insert, one by one, all the numbers.")

    End Sub

    Private Sub bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click
        x = 3
        ListBox3.Items.Add(x)
        ListBox3.Items.Add("After you choose the amount of numbers insert, one by one, all the numbers.")
    End Sub

    Private Sub bt4_Click(sender As Object, e As EventArgs) Handles bt4.Click
        x = 4
        ListBox3.Items.Add(x)
        ListBox3.Items.Add("After you choose the amount of numbers insert, one by one, all the numbers.")
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        numero = TextBox1.Text
        soma += numero
        ListBox3.Items.Add(numero)
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If x = 2 Then
            ListBox3.Items.Add("Average: " & soma / x)
        ElseIf x = 3 Then
            ListBox3.Items.Add("Average: " & soma / x)
        ElseIf x = 4 Then
            ListBox3.Items.Add("Average: " & soma / x)
        ElseIf x = 5 Then
            ListBox3.Items.Add("Average: " & soma / x)
        ElseIf x = 6 Then
            ListBox3.Items.Add("Average: " & soma / x)
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        soma = 0
        numero = 0
        ListBox3.Items.Clear()
        TextBox1.Clear()
    End Sub

    Private Sub bt5_Click(sender As Object, e As EventArgs) Handles bt5.Click
        x = 5
        ListBox3.Items.Add(x)
        ListBox3.Items.Add("After you choose the amount of numbers insert,")
        ListBox3.Items.Add("one by one, all the numbers.")
    End Sub

    Private Sub bt6_Click(sender As Object, e As EventArgs) Handles bt6.Click
        x = 6
        ListBox3.Items.Add(x)
        ListBox3.Items.Add("After you choose the amount of numbers insert, one by one, all the numbers.")
    End Sub


End Class