Public Class Form1
    Dim FristNum, SecondNum, SecondNum1, Result, Result1 As Double

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FristNum = TextBox1.Text
        SecondNum = TextBox2.Text
        SecondNum1 = TextBox3.Text

        Result = FristNum * SecondNum
        Result1 = SecondNum1 - Result

        Label6.Text = Result
        Label7.Text = Result1

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
