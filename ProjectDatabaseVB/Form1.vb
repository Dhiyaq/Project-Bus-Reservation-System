Public Class HomeForm

    Friend SourceString, DestinationString, OnwordDateString As String
    Friend OnwardDate, ReturnDate As Date

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles ReturnDateLabel.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles EnterSourceLabel.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MyAccountButton_Click(sender As Object, e As EventArgs) Handles MyAccountButton.Click
        MyAccountForm.ShowDialog()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        HelpForm.ShowDialog()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        If SourceComboBox.SelectedIndex <> -1 Then
            If DestinationComboBox.SelectedIndex <> -1 Then
                SourceString = SourceComboBox.Text
                DestinationString = DestinationComboBox.Text
                OnwardDate = OnwardMonthCalendar.SelectionStart
                'OnwardDate = 
                ServiceForm.ShowDialog()
            Else
                MessageBox.Show("Please select destination")
            End If
        Else
            MessageBox.Show("Please select source")
        End If

    End Sub
End Class
