Public Class MyForm1
    Private Sub LoadBtn_Click(sender As Object, e As EventArgs) Handles LoadBtn.Click
        Dim objDemoForm As New MyForm2()
        objDemoForm.Show()

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Application.Exit()

    End Sub

    Private Sub MyForm1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        WindowState = FormWindowState.Maximized
        BackColor = Color.Red
    End Sub

    Private Sub MyForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(LoadBtn, "Load Object Demonstration")
        ToolTip1.SetToolTip(ExitBtn, "Exit")
    End Sub

End Class
