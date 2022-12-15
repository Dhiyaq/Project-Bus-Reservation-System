Imports System.Data.OleDb
Public Class LogInForm
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\DatabaseVBAccess.accdb")
    Dim dr As OleDbDataReader
    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        Try
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT * FROM Login WHERE Username='" & UsernameTextBox.Text & "' AND Password= '" & PasswordTextBox.Text & "'", conn)
            dr = cmd.ExecuteReader()

            If dr.HasRows = True Then
                HomeForm.Show()
                Me.Hide()
            Else
                MsgBox("Incorrect Password or Username")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        Me.Close()
        SignUpForm.Show()


    End Sub
End Class