<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Solicitudes
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDENTIFICATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAFINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAINICIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOLICITUDESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Progra3DataSet = New PARCIAL1.Progra3DataSet()
        Me.lblsolicitudes = New System.Windows.Forms.Label()
        Me.SOLICITUDESTableAdapter = New PARCIAL1.Progra3DataSetTableAdapters.SOLICITUDESTableAdapter()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SOLICITUDESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Progra3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.IDENTIFICATIONDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDODataGridViewTextBoxColumn, Me.FECHAFINDataGridViewTextBoxColumn, Me.FECHAINICIODataGridViewTextBoxColumn, Me.ESTADODataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SOLICITUDESBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(50, 137)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(2208, 679)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDENTIFICATIONDataGridViewTextBoxColumn
        '
        Me.IDENTIFICATIONDataGridViewTextBoxColumn.DataPropertyName = "IDENTIFICATION"
        Me.IDENTIFICATIONDataGridViewTextBoxColumn.HeaderText = "IDENTIFICATION"
        Me.IDENTIFICATIONDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.IDENTIFICATIONDataGridViewTextBoxColumn.Name = "IDENTIFICATIONDataGridViewTextBoxColumn"
        Me.IDENTIFICATIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'APELLIDODataGridViewTextBoxColumn
        '
        Me.APELLIDODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO"
        Me.APELLIDODataGridViewTextBoxColumn.HeaderText = "APELLIDO"
        Me.APELLIDODataGridViewTextBoxColumn.MinimumWidth = 10
        Me.APELLIDODataGridViewTextBoxColumn.Name = "APELLIDODataGridViewTextBoxColumn"
        Me.APELLIDODataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHAFINDataGridViewTextBoxColumn
        '
        Me.FECHAFINDataGridViewTextBoxColumn.DataPropertyName = "FECHA_FIN"
        Me.FECHAFINDataGridViewTextBoxColumn.HeaderText = "FECHA_FIN"
        Me.FECHAFINDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.FECHAFINDataGridViewTextBoxColumn.Name = "FECHAFINDataGridViewTextBoxColumn"
        Me.FECHAFINDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHAINICIODataGridViewTextBoxColumn
        '
        Me.FECHAINICIODataGridViewTextBoxColumn.DataPropertyName = "FECHA_INICIO"
        Me.FECHAINICIODataGridViewTextBoxColumn.HeaderText = "FECHA_INICIO"
        Me.FECHAINICIODataGridViewTextBoxColumn.MinimumWidth = 10
        Me.FECHAINICIODataGridViewTextBoxColumn.Name = "FECHAINICIODataGridViewTextBoxColumn"
        Me.FECHAINICIODataGridViewTextBoxColumn.ReadOnly = True
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.MinimumWidth = 10
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        '
        'SOLICITUDESBindingSource
        '
        Me.SOLICITUDESBindingSource.DataMember = "SOLICITUDES"
        Me.SOLICITUDESBindingSource.DataSource = Me.Progra3DataSet
        '
        'Progra3DataSet
        '
        Me.Progra3DataSet.DataSetName = "Progra3DataSet"
        Me.Progra3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblsolicitudes
        '
        Me.lblsolicitudes.AutoSize = True
        Me.lblsolicitudes.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblsolicitudes.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsolicitudes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblsolicitudes.Location = New System.Drawing.Point(748, 38)
        Me.lblsolicitudes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsolicitudes.Name = "lblsolicitudes"
        Me.lblsolicitudes.Size = New System.Drawing.Size(236, 59)
        Me.lblsolicitudes.TabIndex = 1
        Me.lblsolicitudes.Text = "Solicitudes"
        '
        'SOLICITUDESTableAdapter
        '
        Me.SOLICITUDESTableAdapter.ClearBeforeFill = True
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsalir.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsalir.Location = New System.Drawing.Point(1497, 764)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(181, 51)
        Me.btnsalir.TabIndex = 28
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnvolver.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnvolver.Location = New System.Drawing.Point(1332, 764)
        Me.btnvolver.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(136, 50)
        Me.btnvolver.TabIndex = 29
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'Solicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1886, 862)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.lblsolicitudes)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "Solicitudes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitudes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SOLICITUDESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Progra3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Progra3DataSet As Progra3DataSet
    Friend WithEvents SOLICITUDESBindingSource As BindingSource
    Friend WithEvents SOLICITUDESTableAdapter As Progra3DataSetTableAdapters.SOLICITUDESTableAdapter
    Friend WithEvents lblsolicitudes As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnvolver As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDENTIFICATIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAFINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAINICIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
