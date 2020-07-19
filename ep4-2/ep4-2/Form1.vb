Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username, Password As String
        Username = InputBox("กรุณาป้อนชื่อของคุณ")
        Password = InputBox("กรุณาป้อนรหัส")
        If Username = "อาทิตย์" And Password = "123456" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\นายอาทิตย์ สุขสาเกษ\All_Images\All_Images\2-116-780x405.jpg")
        ElseIf Username = "ฟลุ๊ค" And Password = "456789" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\นายอาทิตย์ สุขสาเกษ\All_Images\All_Images\dFQROr7oWzulq5FZYRqIStZrGs2SqJFon4GMlmV7elTvbMbhfx8C5Ppnl8IUfmuSrMC.jpg")
        ElseIf Username = "โตนน" And Password = "121212" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\นายอาทิตย์ สุขสาเกษ\All_Images\All_Images\unnamed.jpg")
        Else
            MsgBox("ไม่มีชื่อคุณอยู่ในระบบ")
        End If
    End Sub
End Class
