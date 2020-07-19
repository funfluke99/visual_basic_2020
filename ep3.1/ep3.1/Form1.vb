Public Class Form1
    Dim Birds As Short
    Dim Insrcts As Integer
    Dim Worldpop As Long
    Dim Price As String
    Dim Fullname As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Short")
        ListBox1.Items.Add("Integer")
        ListBox1.Items.Add("long")
        ListBox1.Items.Add("Single")
        ListBox1.Items.Add("Fullname")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                Birds = 12500
                Label3.Text = Birds
            Case 1
                Insrcts = 375000546
                Label3.Text = Insrcts
            Case 2
                Worldpop = 95.59
                Label3.Text = Worldpop
            Case 3
                Price = "BugFluke"
                Label3.Text = Price
            Case 4
                Fullname = "อาทิตย์ สุขสาเกษ"
                Label3.Text = Fullname
        End Select
    End Sub
End Class
