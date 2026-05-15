Imports MySql.Data.MySqlClient
Public Class AdminLogin
    Dim connectionString As String = "server=localhost;userid=root;password=;database=adminlogin"

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        confirmBttn.FlatAppearance.BorderSize = 0
        confirmBttn.FlatAppearance.MouseOverBackColor = Color.White
        confirmBttn.FlatAppearance.MouseDownBackColor = Color.White
        confirmBttn.TabStop = False
    End Sub
    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim isAuthenticated As Boolean = False

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM info WHERE Username = @Username AND Password = @Password"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        isAuthenticated = True
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return isAuthenticated
    End Function

    Private Sub confirmBttn_Click(sender As Object, e As EventArgs) Handles confirmBttn.Click
        Dim userName As String = userTxt.Text.Trim()
        Dim passWord As String = passTxt.Text.Trim()

        If String.IsNullOrEmpty(userName) OrElse String.IsNullOrEmpty(passWord) Then
            MessageBox.Show("Please enter both username and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If AuthenticateUser(userName, passWord) Then
            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()

        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub backBttn_Click(sender As Object, e As EventArgs) Handles backBttn.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class