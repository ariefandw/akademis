Public Class KHS

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.khsTableAdapter.Fill(Me.akademisDataSet.khs, TextBox1.Text, NumericUpDown1.Value, ComboBox1.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class