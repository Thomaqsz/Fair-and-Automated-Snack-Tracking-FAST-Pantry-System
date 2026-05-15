<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodSelection
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
        snackBox = New PictureBox()
        drinkBox = New PictureBox()
        backBttn = New Button()
        CType(snackBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(drinkBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' snackBox
        ' 
        snackBox.BackColor = Color.Transparent
        snackBox.Image = My.Resources.Resources.SnackBttn1
        snackBox.Location = New Point(248, 197)
        snackBox.Name = "snackBox"
        snackBox.Size = New Size(318, 320)
        snackBox.SizeMode = PictureBoxSizeMode.Zoom
        snackBox.TabIndex = 1
        snackBox.TabStop = False
        ' 
        ' drinkBox
        ' 
        drinkBox.BackColor = Color.Transparent
        drinkBox.Image = My.Resources.Resources.DrinkBttn1
        drinkBox.Location = New Point(554, 197)
        drinkBox.Name = "drinkBox"
        drinkBox.Size = New Size(318, 320)
        drinkBox.SizeMode = PictureBoxSizeMode.Zoom
        drinkBox.TabIndex = 2
        drinkBox.TabStop = False
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
        backBttn.TabIndex = 18
        backBttn.UseVisualStyleBackColor = False
        ' 
        ' FoodSelection
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.FoodBG
        ClientSize = New Size(1129, 650)
        Controls.Add(backBttn)
        Controls.Add(drinkBox)
        Controls.Add(snackBox)
        FormBorderStyle = FormBorderStyle.None
        Name = "FoodSelection"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FoodSelection"
        CType(snackBox, ComponentModel.ISupportInitialize).EndInit()
        CType(drinkBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents snackBox As PictureBox
    Friend WithEvents drinkBox As PictureBox
    Friend WithEvents backBttn As Button
End Class
