<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KHS
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.khsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.akademisDataSet = New WindowsApp1.akademisDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.khsTableAdapter = New WindowsApp1.akademisDataSetTableAdapters.khsTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MahasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MahasiswaTableAdapter = New WindowsApp1.akademisDataSetTableAdapters.mahasiswaTableAdapter()
        CType(Me.khsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.akademisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'khsBindingSource
        '
        Me.khsBindingSource.DataMember = "khs"
        Me.khsBindingSource.DataSource = Me.akademisDataSet
        '
        'akademisDataSet
        '
        Me.akademisDataSet.DataSetName = "akademisDataSet"
        Me.akademisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSetKHS"
        ReportDataSource3.Value = Me.khsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApp1.KHS.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 62)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 376)
        Me.ReportViewer1.TabIndex = 0
        '
        'khsTableAdapter
        '
        Me.khsTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Ganjil", "Genap"})
        Me.ComboBox1.Location = New System.Drawing.Point(411, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(228, 14)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 3
        Me.NumericUpDown1.Value = New Decimal(New Integer() {2021, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Th Ajar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Semester"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(539, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.khsBindingSource, "nim", True))
        Me.ComboBox2.DataSource = Me.MahasiswaBindingSource
        Me.ComboBox2.DisplayMember = "nama"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(63, 13)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 6
        Me.ComboBox2.ValueMember = "nim"
        '
        'MahasiswaBindingSource
        '
        Me.MahasiswaBindingSource.DataMember = "mahasiswa"
        Me.MahasiswaBindingSource.DataSource = Me.akademisDataSet
        '
        'MahasiswaTableAdapter
        '
        Me.MahasiswaTableAdapter.ClearBeforeFill = True
        '
        'KHS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "KHS"
        Me.Text = "KHS"
        CType(Me.khsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.akademisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents khsBindingSource As BindingSource
    Friend WithEvents akademisDataSet As akademisDataSet
    Friend WithEvents khsTableAdapter As akademisDataSetTableAdapters.khsTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents MahasiswaBindingSource As BindingSource
    Friend WithEvents MahasiswaTableAdapter As akademisDataSetTableAdapters.mahasiswaTableAdapter
End Class
