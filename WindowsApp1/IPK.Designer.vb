<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IPK
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.akademisDataSet = New WindowsApp1.akademisDataSet()
        Me.ipkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ipkTableAdapter = New WindowsApp1.akademisDataSetTableAdapters.ipkTableAdapter()
        CType(Me.akademisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ipkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetIpk"
        ReportDataSource1.Value = Me.ipkBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApp1.IPK.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'akademisDataSet
        '
        Me.akademisDataSet.DataSetName = "akademisDataSet"
        Me.akademisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ipkBindingSource
        '
        Me.ipkBindingSource.DataMember = "ipk"
        Me.ipkBindingSource.DataSource = Me.akademisDataSet
        '
        'ipkTableAdapter
        '
        Me.ipkTableAdapter.ClearBeforeFill = True
        '
        'IPK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "IPK"
        Me.Text = "IPK"
        CType(Me.akademisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ipkBindingSource As BindingSource
    Friend WithEvents akademisDataSet As akademisDataSet
    Friend WithEvents ipkTableAdapter As akademisDataSetTableAdapters.ipkTableAdapter
End Class
