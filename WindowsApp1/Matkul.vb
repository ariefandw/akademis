Public Class Matkul
    Private Sub MatkulBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MatkulBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MatkulBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AkademisDataSet)

    End Sub

    Private Sub Matkul_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AkademisDataSet.matkul' table. You can move, or remove it, as needed.
        Me.MatkulTableAdapter.Fill(Me.AkademisDataSet.matkul)

    End Sub
End Class