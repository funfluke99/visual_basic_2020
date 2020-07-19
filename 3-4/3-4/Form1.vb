Public Class Form1
    Dim FristNum, SecondNum, SecondNum1, Result, Result1 As Double


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FristNum = TextBox1.Text
        SecondNum = TextBox2.Text
        SecondNum1 = TextBox4.Text
        Result = FristNum * SecondNum
        Result1 = SecondNum1 - Result
        TextBox3.Text = Result
        TextBox5.Text = Result1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
