Public Class IPK
    Private Sub IPK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'akademisDataSet.ipk' table. You can move, or remove it, as needed.
        Me.ipkTableAdapter.Fill(Me.akademisDataSet.ipk)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class