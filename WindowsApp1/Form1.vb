Public Class Form1
    Private Sub MahasiswaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MahasiswaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MahasiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AkademisDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AkademisDataSet.mahasiswa' table. You can move, or remove it, as needed.
        Me.MahasiswaTableAdapter.Fill(Me.AkademisDataSet.mahasiswa)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Matkul.ShowDialog()
    End Sub
End Class
