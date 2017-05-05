Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_TClick(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.AppendText("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.AppendText("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.AppendText("3")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.AppendText("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.AppendText("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.AppendText("6")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.AppendText("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.AppendText("8")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.AppendText("9")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.AppendText("0")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Label1.Text = "+"
        My.Settings.first = TextBox1.Text

        TextBox1.Text = ""
        My.Settings.Save()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Label1.Text = "-"
        My.Settings.first = TextBox1.Text
        TextBox1.Text = ""
        My.Settings.Save()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Label1.Text = "*"
        My.Settings.first = TextBox1.Text
        TextBox1.Text = ""
        My.Settings.Save()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Label1.Text = "/"
        My.Settings.first = TextBox1.Text
        TextBox1.Text = ""
        My.Settings.Save()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If Label1.Text = "+" Then
            Label1.Text = Label1.Text + TextBox1.Text
            TextBox1.Text = Val(My.Settings.first) + Val(TextBox1.Text)
        ElseIf Label1.Text = "-" Then
            TextBox1.Text = Val(My.Settings.first) - Val(TextBox1.Text)
        ElseIf Label1.Text = "*" Then
            TextBox1.Text = Val(My.Settings.first) * Val(TextBox1.Text)
        ElseIf Label1.Text = "/" Then
            TextBox1.Text = Val(My.Settings.first) / Val(TextBox1.Text)

        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        MessageBox.Show("Don't forget to give your feedback..BEWARE OF BUGS!!!!")

    End Sub
End Class
