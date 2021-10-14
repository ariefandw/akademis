Public Class KRS
    Private Sub KrsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles KrsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.KrsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AkademisDataSet)

    End Sub

    Private Sub KRS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AkademisDataSet.matkul' table. You can move, or remove it, as needed.
        Me.MatkulTableAdapter.Fill(Me.AkademisDataSet.matkul)
        'TODO: This line of code loads data into the 'AkademisDataSet.mahasiswa' table. You can move, or remove it, as needed.
        Me.MahasiswaTableAdapter.Fill(Me.AkademisDataSet.mahasiswa)
        'TODO: This line of code loads data into the 'AkademisDataSet.krs' table. You can move, or remove it, as needed.
        Me.KrsTableAdapter.Fill(Me.AkademisDataSet.krs)

    End Sub
End Class