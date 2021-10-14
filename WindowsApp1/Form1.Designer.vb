<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim NimLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim AngkatanLabel As System.Windows.Forms.Label
        Dim Jenis_kelaminLabel As System.Windows.Forms.Label
        Dim Tgl_lahirLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AkademisDataSet = New WindowsApp1.akademisDataSet()
        Me.MahasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MahasiswaTableAdapter = New WindowsApp1.akademisDataSetTableAdapters.mahasiswaTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.akademisDataSetTableAdapters.TableAdapterManager()
        Me.MahasiswaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MahasiswaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.NimTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.AngkatanNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Jenis_kelaminComboBox = New System.Windows.Forms.ComboBox()
        Me.Tgl_lahirDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MahasiswaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        NimLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        AngkatanLabel = New System.Windows.Forms.Label()
        Jenis_kelaminLabel = New System.Windows.Forms.Label()
        Tgl_lahirLabel = New System.Windows.Forms.Label()
        CType(Me.AkademisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MahasiswaBindingNavigator.SuspendLayout()
        CType(Me.AngkatanNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NimLabel
        '
        NimLabel.AutoSize = True
        NimLabel.Location = New System.Drawing.Point(12, 47)
        NimLabel.Name = "NimLabel"
        NimLabel.Size = New System.Drawing.Size(26, 13)
        NimLabel.TabIndex = 1
        NimLabel.Text = "nim:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(12, 73)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(36, 13)
        NamaLabel.TabIndex = 3
        NamaLabel.Text = "nama:"
        '
        'AngkatanLabel
        '
        AngkatanLabel.AutoSize = True
        AngkatanLabel.Location = New System.Drawing.Point(12, 96)
        AngkatanLabel.Name = "AngkatanLabel"
        AngkatanLabel.Size = New System.Drawing.Size(55, 13)
        AngkatanLabel.TabIndex = 5
        AngkatanLabel.Text = "angkatan:"
        '
        'Jenis_kelaminLabel
        '
        Jenis_kelaminLabel.AutoSize = True
        Jenis_kelaminLabel.Location = New System.Drawing.Point(12, 125)
        Jenis_kelaminLabel.Name = "Jenis_kelaminLabel"
        Jenis_kelaminLabel.Size = New System.Drawing.Size(70, 13)
        Jenis_kelaminLabel.TabIndex = 7
        Jenis_kelaminLabel.Text = "jenis kelamin:"
        '
        'Tgl_lahirLabel
        '
        Tgl_lahirLabel.AutoSize = True
        Tgl_lahirLabel.Location = New System.Drawing.Point(12, 153)
        Tgl_lahirLabel.Name = "Tgl_lahirLabel"
        Tgl_lahirLabel.Size = New System.Drawing.Size(43, 13)
        Tgl_lahirLabel.TabIndex = 9
        Tgl_lahirLabel.Text = "tgl lahir:"
        '
        'AkademisDataSet
        '
        Me.AkademisDataSet.DataSetName = "akademisDataSet"
        Me.AkademisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.krsTableAdapter = Nothing
        Me.TableAdapterManager.mahasiswaTableAdapter = Me.MahasiswaTableAdapter
        Me.TableAdapterManager.matkulTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.akademisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MahasiswaBindingNavigator
        '
        Me.MahasiswaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MahasiswaBindingNavigator.BindingSource = Me.MahasiswaBindingSource
        Me.MahasiswaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MahasiswaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MahasiswaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MahasiswaBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.MahasiswaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MahasiswaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MahasiswaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MahasiswaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MahasiswaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MahasiswaBindingNavigator.Name = "MahasiswaBindingNavigator"
        Me.MahasiswaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MahasiswaBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.MahasiswaBindingNavigator.TabIndex = 0
        Me.MahasiswaBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MahasiswaBindingNavigatorSaveItem
        '
        Me.MahasiswaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MahasiswaBindingNavigatorSaveItem.Image = CType(resources.GetObject("MahasiswaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MahasiswaBindingNavigatorSaveItem.Name = "MahasiswaBindingNavigatorSaveItem"
        Me.MahasiswaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MahasiswaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(83, 22)
        Me.ToolStripButton1.Text = "Mata Kuliah..."
        '
        'NimTextBox
        '
        Me.NimTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "nim", True))
        Me.NimTextBox.Location = New System.Drawing.Point(88, 44)
        Me.NimTextBox.Name = "NimTextBox"
        Me.NimTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NimTextBox.TabIndex = 2
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(88, 70)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NamaTextBox.TabIndex = 4
        '
        'AngkatanNumericUpDown
        '
        Me.AngkatanNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MahasiswaBindingSource, "angkatan", True))
        Me.AngkatanNumericUpDown.Location = New System.Drawing.Point(88, 96)
        Me.AngkatanNumericUpDown.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.AngkatanNumericUpDown.Name = "AngkatanNumericUpDown"
        Me.AngkatanNumericUpDown.Size = New System.Drawing.Size(200, 20)
        Me.AngkatanNumericUpDown.TabIndex = 6
        '
        'Jenis_kelaminComboBox
        '
        Me.Jenis_kelaminComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "jenis_kelamin", True))
        Me.Jenis_kelaminComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Jenis_kelaminComboBox.FormattingEnabled = True
        Me.Jenis_kelaminComboBox.Items.AddRange(New Object() {"L", "P"})
        Me.Jenis_kelaminComboBox.Location = New System.Drawing.Point(88, 122)
        Me.Jenis_kelaminComboBox.Name = "Jenis_kelaminComboBox"
        Me.Jenis_kelaminComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Jenis_kelaminComboBox.TabIndex = 8
        '
        'Tgl_lahirDateTimePicker
        '
        Me.Tgl_lahirDateTimePicker.CustomFormat = "dd MMMM yyyy"
        Me.Tgl_lahirDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MahasiswaBindingSource, "tgl_lahir", True))
        Me.Tgl_lahirDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Tgl_lahirDateTimePicker.Location = New System.Drawing.Point(88, 149)
        Me.Tgl_lahirDateTimePicker.Name = "Tgl_lahirDateTimePicker"
        Me.Tgl_lahirDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Tgl_lahirDateTimePicker.TabIndex = 10
        '
        'MahasiswaDataGridView
        '
        Me.MahasiswaDataGridView.AllowUserToAddRows = False
        Me.MahasiswaDataGridView.AllowUserToDeleteRows = False
        Me.MahasiswaDataGridView.AutoGenerateColumns = False
        Me.MahasiswaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MahasiswaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.MahasiswaDataGridView.DataSource = Me.MahasiswaBindingSource
        Me.MahasiswaDataGridView.Location = New System.Drawing.Point(15, 186)
        Me.MahasiswaDataGridView.Name = "MahasiswaDataGridView"
        Me.MahasiswaDataGridView.ReadOnly = True
        Me.MahasiswaDataGridView.Size = New System.Drawing.Size(773, 214)
        Me.MahasiswaDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nim"
        Me.DataGridViewTextBoxColumn1.HeaderText = "nim"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nama"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "angkatan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "angkatan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "jenis_kelamin"
        Me.DataGridViewTextBoxColumn4.HeaderText = "jenis_kelamin"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tgl_lahir"
        Me.DataGridViewTextBoxColumn5.HeaderText = "tgl_lahir"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(40, 22)
        Me.ToolStripButton2.Text = "KRS..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MahasiswaDataGridView)
        Me.Controls.Add(NimLabel)
        Me.Controls.Add(Me.NimTextBox)
        Me.Controls.Add(NamaLabel)
        Me.Controls.Add(Me.NamaTextBox)
        Me.Controls.Add(AngkatanLabel)
        Me.Controls.Add(Me.AngkatanNumericUpDown)
        Me.Controls.Add(Jenis_kelaminLabel)
        Me.Controls.Add(Me.Jenis_kelaminComboBox)
        Me.Controls.Add(Tgl_lahirLabel)
        Me.Controls.Add(Me.Tgl_lahirDateTimePicker)
        Me.Controls.Add(Me.MahasiswaBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AkademisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MahasiswaBindingNavigator.ResumeLayout(False)
        Me.MahasiswaBindingNavigator.PerformLayout()
        CType(Me.AngkatanNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AkademisDataSet As akademisDataSet
    Friend WithEvents MahasiswaBindingSource As BindingSource
    Friend WithEvents MahasiswaTableAdapter As akademisDataSetTableAdapters.mahasiswaTableAdapter
    Friend WithEvents TableAdapterManager As akademisDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MahasiswaBindingNavigator As BindingNavigator
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
    Friend WithEvents MahasiswaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NimTextBox As TextBox
    Friend WithEvents NamaTextBox As TextBox
    Friend WithEvents AngkatanNumericUpDown As NumericUpDown
    Friend WithEvents Jenis_kelaminComboBox As ComboBox
    Friend WithEvents Tgl_lahirDateTimePicker As DateTimePicker
    Friend WithEvents MahasiswaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
