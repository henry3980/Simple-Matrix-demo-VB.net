Public Class Form1
    Dim eggprice(3, 3) As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox(CStr(eggprice(ComboBox1.SelectedIndex, ComboBox2.SelectedIndex)))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eggprice(0, 0) = 15
        eggprice(0, 1) = 25
        eggprice(0, 2) = 95
        eggprice(0, 3) = 45
        eggprice(1, 0) = 269
        eggprice(1, 1) = 154
        eggprice(1, 2) = 154
        eggprice(1, 3) = 27
        eggprice(2, 0) = 5
        eggprice(2, 1) = 17
        eggprice(2, 2) = 0
        eggprice(2, 3) = 9
        eggprice(3, 0) = 31
        eggprice(3, 1) = 14
        eggprice(3, 2) = 8
        eggprice(3, 3) = 0
    End Sub
End Class
