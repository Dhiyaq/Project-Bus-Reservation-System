Imports System.Reflection.Emit

Public Class ReceiptForm
    Friend TimeString, FromString, DestinationString, BusDateString, BusTypeString, PriceString As String
    Friend OnwardDate As Date
    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = HomeForm.SourceString
        Label4.Text = HomeForm.OnwardDate.ToShortDateString
        Label6.Text = HomeForm.DestinationString

    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        HomeForm.Show()
        Me.Close()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

End Class