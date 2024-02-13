Public Class MyForm2
    Private Sub MyForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(PicBtn, "Load a Picture")
        ToolTip1.SetToolTip(ExitBtn2, "Exit")
    End Sub
    Private Sub TxtBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtBox1.TextChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles MagRdBtn.CheckedChanged, GarRdBtn.CheckedChanged, TahomaRdBtn.CheckedChanged

        If GarRdBtn.Checked Then
            TxtBox1.Font = New Font("Garamond", TxtBox1.Font.Size, TxtBox1.Font.Style)
        ElseIf MagRdBtn.Checked Then
            TxtBox1.Font = New Font("Magneto", TxtBox1.Font.Size, TxtBox1.Font.Style)
        ElseIf TahomaRdBtn.Checked Then
            TxtBox1.Font = New Font("Tahoma", TxtBox1.Font.Size, TxtBox1.Font.Style)
        End If

    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldBox.CheckedChanged, ItalicBox.CheckedChanged, CombinationBox.CheckedChanged

        Dim fontStyle As FontStyle = FontStyle.Regular

        If BoldBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Regular
            fontStyle = fontStyle Or FontStyle.Bold
        End If

        If ItalicBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Regular
            fontStyle = fontStyle Or FontStyle.Italic
        End If

        If CombinationBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Regular
            fontStyle = fontStyle Or FontStyle.Bold
            fontStyle = fontStyle Or FontStyle.Italic
        End If

        TxtBox1.Font = New Font(TxtBox1.Font.FontFamily, TxtBox1.Font.Size, fontStyle)
    End Sub

    Private Sub GreenBtn_CheckedChanged(sender As Object, e As EventArgs) Handles GreenBtn.CheckedChanged
        TxtBox1.ForeColor = Color.Green
    End Sub

    Private Sub BlueBtn_CheckedChanged(sender As Object, e As EventArgs) Handles BlueBtn.CheckedChanged
        TxtBox1.ForeColor = Color.Blue
    End Sub

    Private Sub RedBtn_CheckedChanged(sender As Object, e As EventArgs) Handles RedBtn.CheckedChanged
        TxtBox1.ForeColor = Color.Red
    End Sub

    Private Sub ExitBtn2_Click(sender As Object, e As EventArgs) Handles ExitBtn2.Click
        Dim welcomePage As New MyForm1()
        welcomePage.Show()
    End Sub

    Private Sub PicBtn_Click(sender As Object, e As EventArgs) Handles PicBtn.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.png;*.gif)|*.bmp;*.jpg;*.png;*.gif|All files (*.*)|*.*"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

End Class