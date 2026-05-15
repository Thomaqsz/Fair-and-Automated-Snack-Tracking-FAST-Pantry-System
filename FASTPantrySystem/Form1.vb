Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connectionString As String = "server=localhost;userid=root;password=;database=fast_student_info"
    Private targetForm As Form
    Private WithEvents FadeOutTimer As New Timer()
    '///////////////////////////////////FORM LOAD///////////////////////////////////'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        confirmBttn.FlatAppearance.BorderSize = 0
        confirmBttn.FlatAppearance.MouseOverBackColor = Color.White
        confirmBttn.FlatAppearance.MouseDownBackColor = Color.White
        confirmBttn.TabStop = False

        adminBttn.FlatAppearance.BorderSize = 0
        adminBttn.FlatAppearance.MouseOverBackColor = Color.Transparent
        adminBttn.FlatAppearance.MouseDownBackColor = Color.Transparent
        adminBttn.TabStop = False
        Try
            Dim startInfo As New ProcessStartInfo("C:\xampp\apache_start.bat")
            startInfo.WindowStyle = ProcessWindowStyle.Hidden
            Process.Start(startInfo)

            Dim startInfo2 As New ProcessStartInfo("C:\xampp\mysql_start.bat")
            startInfo2.WindowStyle = ProcessWindowStyle.Hidden
            Process.Start(startInfo2)

            Threading.Thread.Sleep(3000)

            MessageBox.Show("XAMPP started successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error starting XAMPP: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '///////////////////////////////////FUNCTIONS/METHODS///////////////////////////////////'

    Private Function CheckStudentExists(studentNumber As String) As Boolean
        Dim exists As Boolean = False
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM studentinfo WHERE StudentNumber = @StudentNumber"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StudentNumber", studentNumber)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    exists = (count > 0)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return exists
    End Function

    Private Function CheckStudentStatus(studentNumber As String) As String
        Dim status As String = ""
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT ClaimStatus FROM studentinfo WHERE StudentNumber = @StudentNumber"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StudentNumber", studentNumber)
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        status = result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return status
    End Function
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

    '///////////////////////////////////CLICK FUNCTIONS///////////////////////////////////'
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub adminBttn_Click(sender As Object, e As EventArgs) Handles adminBttn.Click
        targetForm = AdminLogin
        FadeOutTimer.Interval = 20
        FadeOutTimer.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles confirmBttn.Click
        targetForm = FoodSelection
        Dim studentNumber As String = numTxt.Text.Trim()

        If String.IsNullOrEmpty(studentNumber) Then
            MessageBox.Show("Please enter a student number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If CheckStudentExists(studentNumber) Then
            Dim claimStatus As String = CheckStudentStatus(studentNumber)
            If CheckStudentStatus(studentNumber) = "Claimed" Then
                MessageBox.Show("YOU HAVE ALREADY CLAIMED AN ITEM TODAY! PLEASE COME BACK TOMORROW!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf CheckStudentStatus(studentNumber) = "Unclaimed" Then
                MessageBox.Show("SUCCESS! YOU CAN CLAIM ONE (1) ITEM FOR TODAY!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FadeOutTimer.Interval = 20
                FadeOutTimer.Start()
            End If

        Else
            MessageBox.Show("Student number not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    '///////////////////////////////////HOVER BUTTONS///////////////////////////////////'
    Private Sub confirmBttn_MouseEnter(sender As Object, e As EventArgs) Handles confirmBttn.MouseEnter
        confirmBttn.Width += 3
        confirmBttn.Height += 3
    End Sub

    Private Sub confirmBttn_MouseLeave(sender As Object, e As EventArgs) Handles confirmBttn.MouseLeave
        confirmBttn.Width -= 3
        confirmBttn.Height -= 3
    End Sub

    Private Sub adminBttn_MouseEnter(sender As Object, e As EventArgs) Handles adminBttn.MouseEnter
        adminBttn.Width += 3
        adminBttn.Height += 3
    End Sub

    Private Sub adminBttn_MouseLeave(sender As Object, e As EventArgs) Handles adminBttn.MouseLeave
        adminBttn.Width -= 3
        adminBttn.Height -= 3
    End Sub

End Class