Public Class PaymentForm
    Private Sub BankIslamButton_Click(sender As Object, e As EventArgs) Handles BankIslamButton.Click
        Me.Close()
        Process.Start("https://www.bankislam.biz")
        ReceiptForm.Show()
    End Sub

    Private Sub MaybankButton_Click(sender As Object, e As EventArgs) Handles MaybankButton.Click
        Me.Close()
        Process.Start("https://www.maybank2u.com.my/home/m2u/common/login.do")
        ReceiptForm.Show()

    End Sub

    Private Sub CIMBBankButton_Click(sender As Object, e As EventArgs) Handles CIMBBankButton.Click
        Me.Close()
        Process.Start("https://www.cimbclicks.com.my")
        ReceiptForm.Show()

    End Sub

    Private Sub RHBBankButton_Click(sender As Object, e As EventArgs) Handles RHBBankButton.Click
        Me.Close()
        Process.Start("https://www.rhbgroup.com/index.html")
        ReceiptForm.Show()

    End Sub
End Class