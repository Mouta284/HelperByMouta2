Imports System.Runtime.Serialization

Public Class Form1
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim n1 As Double = TextBox1.Text, n2 As Double = TextBox2.Text
        TextBox3.Text = n1 + n2
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim n1 As Double = TextBox6.Text, n2 As Double = TextBox5.Text
        TextBox4.Text = n1 * n2
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim n1 As Double = TextBox9.Text, n2 As Double = TextBox8.Text
        TextBox7.Text = n1 / n2
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim n1 As Double = TextBox12.Text, n2 As Double = TextBox11.Text
        TextBox10.Text = n1 - n2
    End Sub
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
    End Sub
    ' variaveis declaradas
    Dim soma As Double
    Dim multi As Double
    Dim div As Double
    Dim subt As Double
    Dim operador As String
    Dim number As Double


    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        For ciclo = 1 To 100
            Dim raiz As Double = Math.Sqrt(ciclo)
            ListBox2.Items.Add("√" & ciclo & " = " & raiz)
        Next

    End Sub

    '----------------------------------------------------------------

    'calculadora botões
    Dim numero As Double, soma2 As Double, operando As String, div2 As Double, sub2 As Double
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        numero = 1
        soma2 += numero 'soma2 = 0, logo soma2 = soma2 + numero = 0 + 1 = 1, assim, soma2 = 1 (exemplo)
        sub2 = numero - sub2
        CalLay.Text = 1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        numero = 2
        soma2 += numero 'soma2 = 1, logo soma2 = soma2 + numero = 1 + 2, assim, soma2 = 3 (exemplo)
        sub2 = numero - sub2 'sub2 = 1, logo sub2 = 2 - 1, assim, soma2 = 1 (exemplo)
        CalLay.Text = 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        numero = 3
        soma2 += numero
        sub2 = numero - sub2 ' sub2 = 5, logo sub2 = 3 - 5, assim, sub2 = -2 (exemplo)
        CalLay.Text = 3
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        numero = 4
        soma2 += numero
        sub2 = numero - sub2
        CalLay.Text = 4
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        numero = 5
        soma2 += numero
        sub2 = numero - sub2
        CalLay.Text = 5
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        numero = 6
        soma2 += numero
        sub2 = numero - sub2
        CalLay.Text = 6
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        numero = 7
        soma2 += numero
        sub2 = numero - sub2
        CalLay.Text = 7
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        numero = 8
        soma2 += numero
        sub2 = numero - sub2
        CalLay.Text = 8
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        numero = 9
        soma2 += numero
        sub2 = numero - sub2
        CalLay.Text = 9
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        operando = "+"
        CalLay.Text = operando
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If operando = "+" Then 'se escolhermos +, então a caixa de texto irá apresentar a soma2, que será por exemplo, 3
            CalLay.Text = soma2
        ElseIf operando = "/" Then
            CalLay.Text = div2
        ElseIf operando = "-" Then
            CalLay.Text = -sub2
        End If
        soma2 = 0
        sub2 = 0
    End Sub
    'o botao - armazenará no seu click a str "-" e irá mostrar na caixa de texto
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        operando = "-"
        CalLay.Text = "-"
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form2.Show()

    End Sub

    'este botao CA irá "resetar" a memória de cada variavel global
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        soma2 = 0
        div2 = 0
        sub2 = 0
        numero = 0
        CalLay.Text = soma2
    End Sub


    'para ja nao funciona -----------------------
    Private Sub Button16_Click(sender As Object, e As EventArgs)
        operando = "/"
        CalLay.Text = operando
    End Sub
    'botao para o form3 aparecer (as medias)----------------
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        HM2.Show()
    End Sub


    'botao para fazer a listbox2 que é das raizes quadradas aparecer + o botao que gera as raizes
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ListBox2.Show()
        Button22.Show()

    End Sub




End Class
