<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AverageMarksForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Subject1TextBox = New TextBox()
        Subject3TextBox = New TextBox()
        Subject4TextBox = New TextBox()
        Subject2TextBox = New TextBox()
        GroupBox1 = New GroupBox()
        CalculateBtn = New Button()
        ExitBtn = New Button()
        ClearBtn = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 25)
        Label1.TabIndex = 0
        Label1.Text = "Subject 1:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 25)
        Label2.TabIndex = 1
        Label2.Text = "Subject 2:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 25)
        Label3.TabIndex = 2
        Label3.Text = "Subject 3:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 220)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 25)
        Label4.TabIndex = 3
        Label4.Text = "Subject 4:"
        ' 
        ' Subject1TextBox
        ' 
        Subject1TextBox.Location = New Point(210, 48)
        Subject1TextBox.Name = "Subject1TextBox"
        Subject1TextBox.PlaceholderText = "Enter Marks"
        Subject1TextBox.Size = New Size(150, 31)
        Subject1TextBox.TabIndex = 4
        ' 
        ' Subject3TextBox
        ' 
        Subject3TextBox.Location = New Point(210, 161)
        Subject3TextBox.Name = "Subject3TextBox"
        Subject3TextBox.PlaceholderText = "Enter Marks"
        Subject3TextBox.Size = New Size(150, 31)
        Subject3TextBox.TabIndex = 5
        ' 
        ' Subject4TextBox
        ' 
        Subject4TextBox.Location = New Point(210, 220)
        Subject4TextBox.Name = "Subject4TextBox"
        Subject4TextBox.PlaceholderText = "Enter Marks"
        Subject4TextBox.Size = New Size(150, 31)
        Subject4TextBox.TabIndex = 6
        ' 
        ' Subject2TextBox
        ' 
        Subject2TextBox.Location = New Point(210, 104)
        Subject2TextBox.Name = "Subject2TextBox"
        Subject2TextBox.PlaceholderText = "Enter Marks"
        Subject2TextBox.Size = New Size(150, 31)
        Subject2TextBox.TabIndex = 7
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Subject4TextBox)
        GroupBox1.Controls.Add(Subject2TextBox)
        GroupBox1.Controls.Add(Subject3TextBox)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Subject1TextBox)
        GroupBox1.Location = New Point(141, 49)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(400, 291)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        ' 
        ' CalculateBtn
        ' 
        CalculateBtn.Location = New Point(141, 365)
        CalculateBtn.Name = "CalculateBtn"
        CalculateBtn.Size = New Size(160, 56)
        CalculateBtn.TabIndex = 9
        CalculateBtn.Text = "Calculate"
        CalculateBtn.UseVisualStyleBackColor = True
        ' 
        ' ExitBtn
        ' 
        ExitBtn.Location = New Point(628, 382)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(160, 56)
        ExitBtn.TabIndex = 10
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = True
        ' 
        ' ClearBtn
        ' 
        ClearBtn.Location = New Point(381, 365)
        ClearBtn.Name = "ClearBtn"
        ClearBtn.Size = New Size(160, 56)
        ClearBtn.TabIndex = 11
        ClearBtn.Text = "Clear"
        ClearBtn.UseVisualStyleBackColor = True
        ' 
        ' AverageMarksForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ClearBtn)
        Controls.Add(ExitBtn)
        Controls.Add(CalculateBtn)
        Controls.Add(GroupBox1)
        Name = "AverageMarksForm"
        Text = "Average Marks"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents Subject1TextBox As TextBox
    Public WithEvents Subject3TextBox As TextBox
    Public WithEvents Subject4TextBox As TextBox
    Public WithEvents Subject2TextBox As TextBox
    Public WithEvents CalculateBtn As Button
    Public WithEvents ExitBtn As Button
    Public WithEvents ClearBtn As Button

End Class
