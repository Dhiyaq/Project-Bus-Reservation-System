Imports System.Data.OleDb
Imports System.Runtime.CompilerServices

Public Class SignUpForm
    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=D:\DatabaseVBAccess.accdb;"

    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbProvider & dbSource
    End Sub
    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click

        LogInForm.Show()


    End Sub

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        If UsernameTextBox.Text = Nothing Or PasswordTextBox.Text = Nothing Then
            MessageBox.Show("Please Enter the Detials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Using cmd As New OleDbCommand("SELECT COUNT(*) FROM Login WHERE [Username] = @Username OR [Password] = @Password", conn)
            cmd.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = UsernameTextBox.Text.Trim
            cmd.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = PasswordTextBox.Text.Trim

            Dim count = Convert.ToInt64(cmd.ExecuteScalar)
            If count > 0 Then
                MessageBox.Show("Username and Password has already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End Using

        Using create As New OleDbCommand("INSERT INTO Login([Username],[Password])VALUES(@Username,@Password)", conn)
            create.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = UsernameTextBox.Text.Trim
            create.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = PasswordTextBox.Text.Trim

            If create.ExecuteNonQuery Then
                MessageBox.Show("Account created. Please go to login page", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()

            End If
        End Using

        conn.Close()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class