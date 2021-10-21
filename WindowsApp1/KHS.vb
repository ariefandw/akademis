Public Class KHS

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.khsTableAdapter.Fill(Me.akademisDataSet.khs, ComboBox2.SelectedValue, NumericUpDown1.Value, ComboBox1.Text)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub KHS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'akademisDataSet.mahasiswa' table. You can move, or remove it, as needed.
        Me.MahasiswaTableAdapter.Fill(Me.akademisDataSet.mahasiswa)
        ComboBox1.SelectedIndex = 0
    End Sub
End Class