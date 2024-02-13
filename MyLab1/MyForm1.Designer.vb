<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyForm1
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
        components = New ComponentModel.Container()
        LoadBtn = New Button()
        ExitBtn = New Button()
        ToolTip1 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' LoadBtn
        ' 
        LoadBtn.Location = New Point(30, 220)
        LoadBtn.Name = "LoadBtn"
        LoadBtn.Size = New Size(265, 73)
        LoadBtn.TabIndex = 0
        LoadBtn.Text = "Load Object Demo"
        LoadBtn.UseVisualStyleBackColor = True
        ' 
        ' ExitBtn
        ' 
        ExitBtn.Location = New Point(339, 220)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(244, 73)
        ExitBtn.TabIndex = 1
        ExitBtn.Text = "EXIT"
        ExitBtn.TextAlign = ContentAlignment.MiddleLeft
        ExitBtn.UseVisualStyleBackColor = True
        ' 
        ' MyForm1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ExitBtn)
        Controls.Add(LoadBtn)
        Name = "MyForm1"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents LoadBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents ToolTip1 As ToolTip

End Class
