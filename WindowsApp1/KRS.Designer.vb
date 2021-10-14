<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KRS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KRS))
        Me.KrsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.KrsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.KrsDataGridView = New System.Windows.Forms.DataGridView()
        Me.KrsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AkademisDataSet = New WindowsApp1.akademisDataSet()
        Me.KrsTableAdapter = New WindowsApp1.akademisDataSetTableAdapters.krsTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.akademisDataSetTableAdapters.TableAdapterManager()
        Me.MahasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MahasiswaTableAdapter = New WindowsApp1.akademisDataSetTableAdapters.mahasiswaTableAdapter()
        Me.MatkulBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MatkulTableAdapter = New WindowsApp1.akademisDataSetTableAdapters.matkulTableAdapter()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.KrsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KrsBindingNavigator.SuspendLayout()
        CType(Me.KrsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KrsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AkademisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatkulBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KrsBindingNavigator
        '
        Me.KrsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.KrsBindingNavigator.BindingSource = Me.KrsBindingSource
        Me.KrsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.KrsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.KrsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.KrsBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.KrsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.KrsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.KrsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.KrsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.KrsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.KrsBindingNavigator.Name = "KrsBindingNavigator"
        Me.KrsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.KrsBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.KrsBindingNavigator.TabIndex = 0
        Me.KrsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'KrsBindingNavigatorSaveItem
        '
        Me.KrsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KrsBindingNavigatorSaveItem.Image = CType(resources.GetObject("KrsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.KrsBindingNavigatorSaveItem.Name = "KrsBindingNavigatorSaveItem"
        Me.KrsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.KrsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'KrsDataGridView
        '
        Me.KrsDataGridView.AutoGenerateColumns = False
        Me.KrsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KrsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.KrsDataGridView.DataSource = Me.KrsBindingSource
        Me.KrsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KrsDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.KrsDataGridView.Name = "KrsDataGridView"
        Me.KrsDataGridView.Size = New System.Drawing.Size(800, 425)
        Me.KrsDataGridView.TabIndex = 1
        '
        'KrsBindingSource
        '
        Me.KrsBindingSource.DataMember = "krs"
        Me.KrsBindingSource.DataSource = Me.AkademisDataSet
        '
        'AkademisDataSet
        '
        Me.AkademisDataSet.DataSetName = "akademisDataSet"
        Me.AkademisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KrsTableAdapter
        '
        Me.KrsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.krsTableAdapter = Me.KrsTableAdapter
        Me.TableAdapterManager.mahasiswaTableAdapter = Nothing
        Me.TableAdapterManager.matkulTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.akademisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MahasiswaBindingSource
        '
        Me.MahasiswaBindingSource.DataMember = "mahasiswa"
        Me.MahasiswaBindingSource.DataSource = Me.AkademisDataSet
        '
        'MahasiswaTableAdapter
        '
        Me.MahasiswaTableAdapter.ClearBeforeFill = True
        '
        'MatkulBindingSource
        '
        Me.MatkulBindingSource.DataMember = "matkul"
        Me.MatkulBindingSource.DataSource = Me.AkademisDataSet
        '
        'MatkulTableAdapter
        '
        Me.MatkulTableAdapter.ClearBeforeFill = True
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripButton1.Text = "Refresh"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nim"
        Me.DataGridViewTextBoxColumn1.DataSource = Me.MahasiswaBindingSource
        Me.DataGridViewTextBoxColumn1.DisplayMember = "nama"
        Me.DataGridViewTextBoxColumn1.HeaderText = "nim"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.ValueMember = "nim"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "thn_ajar"
        Me.DataGridViewTextBoxColumn2.HeaderText = "thn_ajar"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "semester"
        Me.DataGridViewTextBoxColumn3.HeaderText = "semester"
        Me.DataGridViewTextBoxColumn3.Items.AddRange(New Object() {"Ganjil", "Genap"})
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "kd_matkul"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.MatkulBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "nama_matkul"
        Me.DataGridViewTextBoxColumn4.HeaderText = "kd_matkul"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "kd_matkul"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nilai_huruf"
        Me.DataGridViewTextBoxColumn5.HeaderText = "nilai_huruf"
        Me.DataGridViewTextBoxColumn5.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'KRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.KrsDataGridView)
        Me.Controls.Add(Me.KrsBindingNavigator)
        Me.Name = "KRS"
        Me.Text = "KRS"
        CType(Me.KrsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KrsBindingNavigator.ResumeLayout(False)
        Me.KrsBindingNavigator.PerformLayout()
        CType(Me.KrsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KrsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AkademisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatkulBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AkademisDataSet As akademisDataSet
    Friend WithEvents KrsBindingSource As BindingSource
    Friend WithEvents KrsTableAdapter As akademisDataSetTableAdapters.krsTableAdapter
    Friend WithEvents TableAdapterManager As akademisDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KrsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents KrsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents KrsDataGridView As DataGridView
    Friend WithEvents MahasiswaBindingSource As BindingSource
    Friend WithEvents MahasiswaTableAdapter As akademisDataSetTableAdapters.mahasiswaTableAdapter
    Friend WithEvents MatkulBindingSource As BindingSource
    Friend WithEvents MatkulTableAdapter As akademisDataSetTableAdapters.matkulTableAdapter
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewComboBoxColumn
End Class
