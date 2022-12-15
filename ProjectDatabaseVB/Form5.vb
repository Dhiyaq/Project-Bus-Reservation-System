Imports System.Data.OleDb

Public Class ServiceForm
    Friend TimeString, FromString, DestinationString, BusDateString, BusTypeString, PriceString As String
    Friend OnwardDate As Date

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row As DataGridViewRow = Me.DataGridView1.RowTemplate
        row.DefaultCellStyle.BackColor = Color.White
        row.Height = 35
        row.MinimumHeight = 20

        Label1.Text = HomeForm.SourceString
        Label2.Text = HomeForm.OnwardDate.ToShortDateString
        ToLabel.Text = HomeForm.DestinationString
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\DatabaseVBAccess.accdb"
        Dim sql As String = "SELECT Time,BusType,Price FROM BusSchedule WHERE (From = '" & HomeForm.SourceString & "' AND To = '" & HomeForm.DestinationString & "' And BusDate like '" & HomeForm.OnwardDate & "' )"
        Dim connection As New OleDbConnection(connectionString)
        Dim dataadapter As New OleDbDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Authors_table")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Authors_table"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Function GetConnection() As String
        Return connection()
    End Function



    Private Function connection() As String
        Throw New NotImplementedException()
    End Function

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Me.Close()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TimeString = DataGridView1.Item(0, i).Value.ToString & " "
        FromString += DataGridView1.Item(1, i).Value.ToString
        DestinationString += DataGridView1.Item(2, i).Value.ToString
        'BusDateString += DataGridView1.Item(3, i).Value.ToString
        'BusTypeString += DataGridView1.Item(4, i).Value.ToString
        'PriceString += DataGridView1.Item(5, i).Value.ToString



        PaymentForm.Show()
    End Sub
End Class