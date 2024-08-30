<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.USUARIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDENTIFICACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsAdminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VACACIONESDISPONIBLESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAINICIOLABORALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Progra3DataSet1 = New PARCIAL1.Progra3DataSet1()
        Me.USERSTableAdapter = New PARCIAL1.Progra3DataSet1TableAdapters.USERSTableAdapter()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExportCSV = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Progra3DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.USUARIODataGridViewTextBoxColumn, Me.IDENTIFICACIONDataGridViewTextBoxColumn, Me.IsAdminDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDODataGridViewTextBoxColumn, Me.VACACIONESDISPONIBLESDataGridViewTextBoxColumn, Me.FECHAINICIOLABORALDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.USERSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(39, 148)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1695, 678)
        Me.DataGridView1.TabIndex = 0
        '
        'USUARIODataGridViewTextBoxColumn
        '
        Me.USUARIODataGridViewTextBoxColumn.DataPropertyName = "USUARIO"
        Me.USUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO"
        Me.USUARIODataGridViewTextBoxColumn.MinimumWidth = 10
        Me.USUARIODataGridViewTextBoxColumn.Name = "USUARIODataGridViewTextBoxColumn"
        Me.USUARIODataGridViewTextBoxColumn.Width = 200
        '
        'IDENTIFICACIONDataGridViewTextBoxColumn
        '
        Me.IDENTIFICACIONDataGridViewTextBoxColumn.DataPropertyName = "IDENTIFICACION"
        Me.IDENTIFICACIONDataGridViewTextBoxColumn.HeaderText = "IDENTIFICACION"
        Me.IDENTIFICACIONDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.IDENTIFICACIONDataGridViewTextBoxColumn.Name = "IDENTIFICACIONDataGridViewTextBoxColumn"
        Me.IDENTIFICACIONDataGridViewTextBoxColumn.Width = 200
        '
        'IsAdminDataGridViewTextBoxColumn
        '
        Me.IsAdminDataGridViewTextBoxColumn.DataPropertyName = "isAdmin"
        Me.IsAdminDataGridViewTextBoxColumn.HeaderText = "isAdmin"
        Me.IsAdminDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.IsAdminDataGridViewTextBoxColumn.Name = "IsAdminDataGridViewTextBoxColumn"
        Me.IsAdminDataGridViewTextBoxColumn.Width = 200
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.Width = 200
        '
        'APELLIDODataGridViewTextBoxColumn
        '
        Me.APELLIDODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO"
        Me.APELLIDODataGridViewTextBoxColumn.HeaderText = "APELLIDO"
        Me.APELLIDODataGridViewTextBoxColumn.MinimumWidth = 10
        Me.APELLIDODataGridViewTextBoxColumn.Name = "APELLIDODataGridViewTextBoxColumn"
        Me.APELLIDODataGridViewTextBoxColumn.Width = 200
        '
        'VACACIONESDISPONIBLESDataGridViewTextBoxColumn
        '
        Me.VACACIONESDISPONIBLESDataGridViewTextBoxColumn.DataPropertyName = "VACACIONES_DISPONIBLES"
        Me.VACACIONESDISPONIBLESDataGridViewTextBoxColumn.HeaderText = "VACACIONES_DISPONIBLES"
        Me.VACACIONESDISPONIBLESDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.VACACIONESDISPONIBLESDataGridViewTextBoxColumn.Name = "VACACIONESDISPONIBLESDataGridViewTextBoxColumn"
        Me.VACACIONESDISPONIBLESDataGridViewTextBoxColumn.Width = 200
        '
        'FECHAINICIOLABORALDataGridViewTextBoxColumn
        '
        Me.FECHAINICIOLABORALDataGridViewTextBoxColumn.DataPropertyName = "FECHA_INICIO_LABORAL"
        Me.FECHAINICIOLABORALDataGridViewTextBoxColumn.HeaderText = "FECHA_INICIO_LABORAL"
        Me.FECHAINICIOLABORALDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.FECHAINICIOLABORALDataGridViewTextBoxColumn.Name = "FECHAINICIOLABORALDataGridViewTextBoxColumn"
        Me.FECHAINICIOLABORALDataGridViewTextBoxColumn.Width = 200
        '
        'USERSBindingSource
        '
        Me.USERSBindingSource.DataMember = "USERS"
        Me.USERSBindingSource.DataSource = Me.Progra3DataSet1
        '
        'Progra3DataSet1
        '
        Me.Progra3DataSet1.DataSetName = "Progra3DataSet1"
        Me.Progra3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USERSTableAdapter
        '
        Me.USERSTableAdapter.ClearBeforeFill = True
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnvolver.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnvolver.Location = New System.Drawing.Point(1382, 891)
        Me.btnvolver.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(148, 54)
        Me.btnvolver.TabIndex = 33
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsalir.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsalir.Location = New System.Drawing.Point(1547, 891)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(148, 54)
        Me.btnsalir.TabIndex = 32
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnguardar.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnguardar.Location = New System.Drawing.Point(1192, 891)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(154, 54)
        Me.btnguardar.TabIndex = 34
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(800, 0, 800, 0)
        Me.Label1.Size = New System.Drawing.Size(1742, 45)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Usuarios"
        '
        'btnExportCSV
        '
        Me.btnExportCSV.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExportCSV.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportCSV.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExportCSV.Location = New System.Drawing.Point(927, 891)
        Me.btnExportCSV.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnExportCSV.Name = "btnExportCSV"
        Me.btnExportCSV.Size = New System.Drawing.Size(240, 54)
        Me.btnExportCSV.TabIndex = 36
        Me.btnExportCSV.Text = "Exportar CSV"
        Me.btnExportCSV.UseVisualStyleBackColor = False
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.PARCIAL1.My.Resources.Resources.WhatsApp_Image_2024_07_11_at_7_55_27_PM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1802, 1016)
        Me.Controls.Add(Me.btnExportCSV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Usuarios"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Progra3DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Progra3DataSet1 As Progra3DataSet1
    Friend WithEvents USERSBindingSource As BindingSource
    Friend WithEvents USERSTableAdapter As Progra3DataSet1TableAdapters.USERSTableAdapter
    Friend WithEvents USUARIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDENTIFICACIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsAdminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VACACIONESDISPONIBLESDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAINICIOLABORALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnvolver As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExportCSV As Button
End Class
