<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyForm2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TxtBox1 = New TextBox()
        GroupBox1 = New GroupBox()
        FontBox = New GroupBox()
        TahomaRdBtn = New RadioButton()
        MagRdBtn = New RadioButton()
        GarRdBtn = New RadioButton()
        PicBtn = New Button()
        ExitBtn2 = New Button()
        StyleBox = New GroupBox()
        CombinationBox = New CheckBox()
        BoldBox = New CheckBox()
        ItalicBox = New CheckBox()
        ColourBox = New GroupBox()
        RedBtn = New RadioButton()
        BlueBtn = New RadioButton()
        GreenBtn = New RadioButton()
        PictureBox1 = New PictureBox()
        ToolTip1 = New ToolTip(components)
        GroupBox1.SuspendLayout()
        FontBox.SuspendLayout()
        StyleBox.SuspendLayout()
        ColourBox.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtBox1
        ' 
        TxtBox1.Location = New Point(6, 40)
        TxtBox1.Name = "TxtBox1"
        TxtBox1.PlaceholderText = "Sample Test"
        TxtBox1.Size = New Size(187, 31)
        TxtBox1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TxtBox1)
        GroupBox1.Location = New Point(62, 33)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(240, 88)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Display Test"
        ' 
        ' FontBox
        ' 
        FontBox.Controls.Add(TahomaRdBtn)
        FontBox.Controls.Add(MagRdBtn)
        FontBox.Controls.Add(GarRdBtn)
        FontBox.Location = New Point(327, 33)
        FontBox.Name = "FontBox"
        FontBox.Size = New Size(450, 88)
        FontBox.TabIndex = 2
        FontBox.TabStop = False
        FontBox.Text = "Font"
        ' 
        ' TahomaRdBtn
        ' 
        TahomaRdBtn.AutoSize = True
        TahomaRdBtn.Location = New Point(306, 42)
        TahomaRdBtn.Name = "TahomaRdBtn"
        TahomaRdBtn.Size = New Size(99, 29)
        TahomaRdBtn.TabIndex = 2
        TahomaRdBtn.TabStop = True
        TahomaRdBtn.Text = "Tahoma"
        TahomaRdBtn.UseVisualStyleBackColor = True
        ' 
        ' MagRdBtn
        ' 
        MagRdBtn.AutoSize = True
        MagRdBtn.Location = New Point(162, 42)
        MagRdBtn.Name = "MagRdBtn"
        MagRdBtn.Size = New Size(109, 29)
        MagRdBtn.TabIndex = 1
        MagRdBtn.TabStop = True
        MagRdBtn.Text = "Magneto"
        MagRdBtn.UseVisualStyleBackColor = True
        ' 
        ' GarRdBtn
        ' 
        GarRdBtn.AutoSize = True
        GarRdBtn.Location = New Point(6, 42)
        GarRdBtn.Name = "GarRdBtn"
        GarRdBtn.Size = New Size(121, 29)
        GarRdBtn.TabIndex = 0
        GarRdBtn.TabStop = True
        GarRdBtn.Text = "Garamond"
        GarRdBtn.UseVisualStyleBackColor = True
        ' 
        ' PicBtn
        ' 
        PicBtn.Location = New Point(96, 423)
        PicBtn.Name = "PicBtn"
        PicBtn.Size = New Size(159, 53)
        PicBtn.TabIndex = 3
        PicBtn.Text = "Load Picture"
        PicBtn.TextAlign = ContentAlignment.MiddleLeft
        PicBtn.UseVisualStyleBackColor = True
        ' 
        ' ExitBtn2
        ' 
        ExitBtn2.Location = New Point(603, 423)
        ExitBtn2.Name = "ExitBtn2"
        ExitBtn2.Size = New Size(112, 53)
        ExitBtn2.TabIndex = 4
        ExitBtn2.Text = "Exit"
        ExitBtn2.UseVisualStyleBackColor = True
        ' 
        ' StyleBox
        ' 
        StyleBox.Controls.Add(CombinationBox)
        StyleBox.Controls.Add(BoldBox)
        StyleBox.Controls.Add(ItalicBox)
        StyleBox.Location = New Point(342, 192)
        StyleBox.Name = "StyleBox"
        StyleBox.Size = New Size(152, 212)
        StyleBox.TabIndex = 5
        StyleBox.TabStop = False
        StyleBox.Text = "Font Style"
        ' 
        ' CombinationBox
        ' 
        CombinationBox.AutoSize = True
        CombinationBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        CombinationBox.Location = New Point(16, 152)
        CombinationBox.Name = "CombinationBox"
        CombinationBox.Size = New Size(126, 29)
        CombinationBox.TabIndex = 2
        CombinationBox.Text = "Bold Italic"
        CombinationBox.UseVisualStyleBackColor = True
        ' 
        ' BoldBox
        ' 
        BoldBox.AutoSize = True
        BoldBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BoldBox.Location = New Point(19, 100)
        BoldBox.Name = "BoldBox"
        BoldBox.Size = New Size(77, 29)
        BoldBox.TabIndex = 1
        BoldBox.Text = "Bold"
        BoldBox.UseVisualStyleBackColor = True
        ' 
        ' ItalicBox
        ' 
        ItalicBox.AutoSize = True
        ItalicBox.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        ItalicBox.Location = New Point(21, 47)
        ItalicBox.Name = "ItalicBox"
        ItalicBox.Size = New Size(77, 29)
        ItalicBox.TabIndex = 0
        ItalicBox.Text = "Italic"
        ItalicBox.UseVisualStyleBackColor = True
        ' 
        ' ColourBox
        ' 
        ColourBox.Controls.Add(RedBtn)
        ColourBox.Controls.Add(BlueBtn)
        ColourBox.Controls.Add(GreenBtn)
        ColourBox.Location = New Point(587, 192)
        ColourBox.Name = "ColourBox"
        ColourBox.Size = New Size(164, 212)
        ColourBox.TabIndex = 6
        ColourBox.TabStop = False
        ColourBox.Text = "Font color"
        ' 
        ' RedBtn
        ' 
        RedBtn.AutoSize = True
        RedBtn.Location = New Point(18, 153)
        RedBtn.Name = "RedBtn"
        RedBtn.Size = New Size(67, 29)
        RedBtn.TabIndex = 2
        RedBtn.TabStop = True
        RedBtn.Text = "Red"
        RedBtn.UseVisualStyleBackColor = True
        ' 
        ' BlueBtn
        ' 
        BlueBtn.AutoSize = True
        BlueBtn.Location = New Point(16, 99)
        BlueBtn.Name = "BlueBtn"
        BlueBtn.Size = New Size(70, 29)
        BlueBtn.TabIndex = 1
        BlueBtn.TabStop = True
        BlueBtn.Text = "Blue"
        BlueBtn.UseVisualStyleBackColor = True
        ' 
        ' GreenBtn
        ' 
        GreenBtn.AutoSize = True
        GreenBtn.Location = New Point(16, 46)
        GreenBtn.Name = "GreenBtn"
        GreenBtn.Size = New Size(83, 29)
        GreenBtn.TabIndex = 0
        GreenBtn.TabStop = True
        GreenBtn.Text = "Green"
        GreenBtn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(62, 140)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(240, 264)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' MyForm2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 508)
        Controls.Add(PictureBox1)
        Controls.Add(ColourBox)
        Controls.Add(StyleBox)
        Controls.Add(ExitBtn2)
        Controls.Add(PicBtn)
        Controls.Add(FontBox)
        Controls.Add(GroupBox1)
        Name = "MyForm2"
        Text = "Objec Demonstrations"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        FontBox.ResumeLayout(False)
        FontBox.PerformLayout()
        StyleBox.ResumeLayout(False)
        StyleBox.PerformLayout()
        ColourBox.ResumeLayout(False)
        ColourBox.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TxtBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FontBox As GroupBox
    Friend WithEvents PicBtn As Button
    Friend WithEvents ExitBtn2 As Button
    Friend WithEvents StyleBox As GroupBox
    Friend WithEvents BoldBox As CheckBox
    Friend WithEvents ItalicBox As CheckBox
    Friend WithEvents CombinationBox As CheckBox
    Friend WithEvents ColourBox As GroupBox
    Friend WithEvents RedBtn As RadioButton
    Friend WithEvents BlueBtn As RadioButton
    Friend WithEvents GreenBtn As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TahomaRdBtn As RadioButton
    Friend WithEvents MagRdBtn As RadioButton
    Friend WithEvents GarRdBtn As RadioButton
    Friend WithEvents ToolTip1 As ToolTip
End Class
