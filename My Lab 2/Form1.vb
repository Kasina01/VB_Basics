Imports System.Windows.Forms

Public Class AverageMarksForm

    Private Sub AverageMarksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set dialog results for buttons
        CalculateBtn.DialogResult = DialogResult.OK
        ExitBtn.DialogResult = DialogResult.Cancel

        ' Initialize TextBoxes
        Subject1TextBox.Text = ""
        Subject2TextBox.Text = ""
        Subject3TextBox.Text = ""
        Subject4TextBox.Text = ""
    End Sub

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        ' Parse values from TextBoxes
        Dim mark1 As Integer
        Dim mark2 As Integer
        Dim mark3 As Integer
        Dim mark4 As Integer

        If Not Integer.TryParse(Subject1TextBox.Text, mark1) OrElse
           mark1 < 0 OrElse mark1 > 100 Then
            MessageBox.Show("Invalid input for Subject 1! Please enter a valid mark between 0 and 100.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Integer.TryParse(Subject2TextBox.Text, mark2) OrElse
           mark2 < 0 OrElse mark2 > 100 Then
            MessageBox.Show("Invalid input for Subject 2! Please enter a valid mark between 0 and 100.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Integer.TryParse(Subject3TextBox.Text, mark3) OrElse
           mark3 < 0 OrElse mark3 > 100 Then
            MessageBox.Show("Invalid input for Subject 3! Please enter a valid mark between 0 and 100.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Integer.TryParse(Subject4TextBox.Text, mark4) OrElse
           mark4 < 0 OrElse mark4 > 100 Then
            MessageBox.Show("Invalid input for Subject 4! Please enter a valid mark between 0 and 100.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Calculate the average mark
        Dim averageMark As Double = (mark1 + mark2 + mark3 + mark4) / 4

        ' Determine the grade
        Dim grade As String
        If averageMark < 50 Then
            grade = "Fail"
        ElseIf averageMark < 65 Then
            grade = "C"
        ElseIf averageMark < 75 Then
            grade = "B"
        Else
            grade = "A"
        End If

        ' Display the result using a message box
        MessageBox.Show(String.Format("Average mark: {0:F2}%{1}Grade: {2}", averageMark, Environment.NewLine, grade, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information))
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ' Clear all TextBoxes
        Subject1TextBox.Clear()
        Subject2TextBox.Clear()
        Subject3TextBox.Clear()
        Subject4TextBox.Clear()
    End Sub
End Class
