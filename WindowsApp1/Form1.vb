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

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        KRS.Show()
    End Sub

    Private Sub FillByNimNamaToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByNimNamaToolStripButton.Click
        Try
            Me.MahasiswaTableAdapter.FillByNimNama(Me.AkademisDataSet.mahasiswa, "%" & NimToolStripTextBox.Text & "%", "%" & NamaToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        KHS.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        IPK.Show()
    End Sub
End Class
