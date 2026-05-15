Public Class FoodSelection
    Private WithEvents FadeTimer As New Timer()

    '///////////////////////////////////FUNCTIONS/METHODS///////////////////////////////////'
    Private Sub FoodSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        FadeTimer.Interval = 20
        FadeTimer.Start()
    End Sub

    Private Sub FadeTimer_Tick(sender As Object, e As EventArgs) Handles FadeTimer.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.1
        Else
            FadeTimer.Stop()
        End If
    End Sub

    Private targetForm As Form
    Private WithEvents FadeOutTimer As New Timer()
    Private Sub FadeOutTimer_Tick(sender As Object, e As EventArgs) Handles FadeOutTimer.Tick
        If Me.Opacity > 0 Then
            Me.Opacity -= 0.1
        Else
            FadeOutTimer.Stop()
            Me.Hide()
            If targetForm IsNot Nothing Then
                targetForm.Show()
            End If
        End If
    End Sub


    '///////////////////////////////////BUTTON CLICKS///////////////////////////////////'
    Private Sub snackBox_Click(sender As Object, e As EventArgs) Handles snackBox.Click
        Me.Dispose()

    End Sub

    Private Sub drinkBox_Click(sender As Object, e As EventArgs) Handles drinkBox.Click
        Me.Dispose()

    End Sub

    '///////////////////////////////////HOVER BUTTONS///////////////////////////////////'
    Private Sub snackBox_MouseEnter(sender As Object, e As EventArgs) Handles snackBox.MouseEnter
        snackBox.Width += 10
        snackBox.Height += 10
    End Sub

    Private Sub snackBox_MouseLeave(sender As Object, e As EventArgs) Handles snackBox.MouseLeave
        snackBox.Width -= 10
        snackBox.Height -= 10
    End Sub

    Private Sub drinkBox_MouseEnter(sender As Object, e As EventArgs) Handles drinkBox.MouseEnter
        drinkBox.Width += 10
        drinkBox.Height += 10
    End Sub

    Private Sub drinkBox_MouseLeave(sender As Object, e As EventArgs) Handles drinkBox.MouseLeave
        drinkBox.Width -= 10
        drinkBox.Height -= 10
    End Sub

    Private Sub backBttn_Click(sender As Object, e As EventArgs) Handles backBttn.Click
        targetForm = Form1
        FadeOutTimer.Interval = 20
        FadeOutTimer.Start()
    End Sub
End Class