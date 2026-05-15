<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        confirmBttn = New Button()
        userTxt = New TextBox()
        passTxt = New TextBox()
        PictureBox3 = New PictureBox()
        logoPic = New PictureBox()
        PictureBox4 = New PictureBox()
        backBttn = New Button()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(logoPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' confirmBttn
        ' 
        confirmBttn.BackColor = Color.White
        confirmBttn.BackgroundImage = My.Resources.Resources.Button2
        confirmBttn.BackgroundImageLayout = ImageLayout.Zoom
        confirmBttn.FlatAppearance.BorderSize = 0
        confirmBttn.FlatStyle = FlatStyle.Flat
        confirmBttn.Location = New Point(673, 380)
        confirmBttn.Name = "confirmBttn"
        confirmBttn.Size = New Size(158, 31)
        confirmBttn.TabIndex = 3
        confirmBttn.UseVisualStyleBackColor = False
        ' 
        ' userTxt
        ' 
        userTxt.BackColor = Color.FromArgb(CByte(155), CByte(162), CByte(170))
        userTxt.BorderStyle = BorderStyle.None
        userTxt.Location = New Point(643, 280)
        userTxt.Name = "userTxt"
        userTxt.Size = New Size(217, 16)
        userTxt.TabIndex = 0
        ' 
        ' passTxt
        ' 
        passTxt.BackColor = Color.FromArgb(CByte(155), CByte(162), CByte(170))
        passTxt.BorderStyle = BorderStyle.None
        passTxt.Location = New Point(643, 334)
        passTxt.Name = "passTxt"
        passTxt.Size = New Size(217, 16)
        passTxt.TabIndex = 1
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.Location = New Point(250, 210)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(629, 231)
        PictureBox3.TabIndex = 14
        PictureBox3.TabStop = False
        ' 
        ' logoPic
        ' 
        logoPic.BackColor = Color.White
        logoPic.Image = My.Resources.Resources.AdminLogo
        logoPic.Location = New Point(260, 223)
        logoPic.Name = "logoPic"
        logoPic.Size = New Size(290, 192)
        logoPic.SizeMode = PictureBoxSizeMode.Zoom
        logoPic.TabIndex = 15
        logoPic.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.White
        PictureBox4.Image = My.Resources.Resources.LoginFields
        PictureBox4.Location = New Point(556, 212)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(313, 206)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 16
        PictureBox4.TabStop = False
        ' 
        ' backBttn
        ' 
        backBttn.BackColor = Color.Transparent
        backBttn.BackgroundImage = My.Resources.Resources.BackButton
        backBttn.BackgroundImageLayout = ImageLayout.Zoom
        backBttn.FlatAppearance.BorderSize = 0
        backBttn.FlatStyle = FlatStyle.Flat
        backBttn.Location = New Point(-19, 562)
        backBttn.Name = "backBttn"
        backBttn.Size = New Size(139, 77)
        backBttn.TabIndex = 17
        backBttn.UseVisualStyleBackColor = False
        ' 
        ' AdminLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.AdminBG
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1129, 650)
        Controls.Add(backBttn)
        Controls.Add(passTxt)
        Controls.Add(userTxt)
        Controls.Add(confirmBttn)
        Controls.Add(PictureBox4)
        Controls.Add(logoPic)
        Controls.Add(PictureBox3)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminLogin"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(logoPic, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents confirmBttn As Button
    Friend WithEvents userTxt As TextBox
    Friend WithEvents passTxt As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents logoPic As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents backBttn As Button
End Class
