<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        PictureBox1 = New PictureBox()
        logoPic = New PictureBox()
        numTxt = New TextBox()
        txtPic = New PictureBox()
        confirmBttn = New Button()
        studentNumPic = New PictureBox()
        adminBttn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(logoPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(studentNumPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Location = New Point(268, 210)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(629, 231)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' logoPic
        ' 
        logoPic.BackColor = Color.White
        logoPic.Image = My.Resources.Resources.FAST
        logoPic.Location = New Point(268, 223)
        logoPic.Name = "logoPic"
        logoPic.Size = New Size(313, 206)
        logoPic.SizeMode = PictureBoxSizeMode.Zoom
        logoPic.TabIndex = 1
        logoPic.TabStop = False
        ' 
        ' numTxt
        ' 
        numTxt.BackColor = Color.FromArgb(CByte(155), CByte(162), CByte(170))
        numTxt.BorderStyle = BorderStyle.None
        numTxt.Location = New Point(625, 306)
        numTxt.Name = "numTxt"
        numTxt.Size = New Size(220, 16)
        numTxt.TabIndex = 2
        ' 
        ' txtPic
        ' 
        txtPic.Image = My.Resources.Resources.TextBox
        txtPic.Location = New Point(616, 249)
        txtPic.Name = "txtPic"
        txtPic.Size = New Size(239, 131)
        txtPic.SizeMode = PictureBoxSizeMode.StretchImage
        txtPic.TabIndex = 3
        txtPic.TabStop = False
        ' 
        ' confirmBttn
        ' 
        confirmBttn.BackColor = Color.White
        confirmBttn.BackgroundImage = My.Resources.Resources.Button2
        confirmBttn.BackgroundImageLayout = ImageLayout.Zoom
        confirmBttn.FlatAppearance.BorderSize = 0
        confirmBttn.FlatStyle = FlatStyle.Flat
        confirmBttn.Location = New Point(655, 349)
        confirmBttn.Name = "confirmBttn"
        confirmBttn.Size = New Size(158, 31)
        confirmBttn.TabIndex = 4
        confirmBttn.UseVisualStyleBackColor = False
        ' 
        ' studentNumPic
        ' 
        studentNumPic.BackColor = Color.White
        studentNumPic.Image = My.Resources.Resources.StudentNum
        studentNumPic.Location = New Point(640, 254)
        studentNumPic.Name = "studentNumPic"
        studentNumPic.Size = New Size(193, 27)
        studentNumPic.SizeMode = PictureBoxSizeMode.Zoom
        studentNumPic.TabIndex = 5
        studentNumPic.TabStop = False
        ' 
        ' adminBttn
        ' 
        adminBttn.BackColor = Color.Transparent
        adminBttn.BackgroundImage = My.Resources.Resources.AdminButton
        adminBttn.BackgroundImageLayout = ImageLayout.Zoom
        adminBttn.FlatAppearance.BorderSize = 0
        adminBttn.FlatStyle = FlatStyle.Flat
        adminBttn.Location = New Point(-14, 567)
        adminBttn.Name = "adminBttn"
        adminBttn.Size = New Size(203, 80)
        adminBttn.TabIndex = 6
        adminBttn.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources.Background
        ClientSize = New Size(1129, 650)
        Controls.Add(adminBttn)
        Controls.Add(studentNumPic)
        Controls.Add(confirmBttn)
        Controls.Add(numTxt)
        Controls.Add(txtPic)
        Controls.Add(logoPic)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(logoPic, ComponentModel.ISupportInitialize).EndInit()
        CType(txtPic, ComponentModel.ISupportInitialize).EndInit()
        CType(studentNumPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents logoPic As PictureBox
    Friend WithEvents numTxt As TextBox
    Friend WithEvents txtPic As PictureBox
    Friend WithEvents confirmBttn As Button
    Friend WithEvents studentNumPic As PictureBox
    Friend WithEvents adminBttn As Button

End Class
