<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevaSolicitud
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.DateTimePickerFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lbFechaInicio = New System.Windows.Forms.Label()
        Me.LbFechaFinal = New System.Windows.Forms.Label()
        Me.DateTimePickerFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.btSInsertar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(1060, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "  Nueva Solicitud  "
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsalir.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsalir.Location = New System.Drawing.Point(1497, 764)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(147, 52)
        Me.btnsalir.TabIndex = 9
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnvolver.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnvolver.Location = New System.Drawing.Point(1332, 764)
        Me.btnvolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(147, 52)
        Me.btnvolver.TabIndex = 30
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'DateTimePickerFechaInicio
        '
        Me.DateTimePickerFechaInicio.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DateTimePickerFechaInicio.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DateTimePickerFechaInicio.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFechaInicio.Location = New System.Drawing.Point(947, 332)
        Me.DateTimePickerFechaInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerFechaInicio.Name = "DateTimePickerFechaInicio"
        Me.DateTimePickerFechaInicio.Size = New System.Drawing.Size(564, 47)
        Me.DateTimePickerFechaInicio.TabIndex = 31
        '
        'lbFechaInicio
        '
        Me.lbFechaInicio.AutoSize = True
        Me.lbFechaInicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbFechaInicio.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbFechaInicio.Location = New System.Drawing.Point(1119, 258)
        Me.lbFechaInicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFechaInicio.Name = "lbFechaInicio"
        Me.lbFechaInicio.Size = New System.Drawing.Size(234, 45)
        Me.lbFechaInicio.TabIndex = 32
        Me.lbFechaInicio.Text = "Fecha de inicio"
        '
        'LbFechaFinal
        '
        Me.LbFechaFinal.AutoSize = True
        Me.LbFechaFinal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LbFechaFinal.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaFinal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LbFechaFinal.Location = New System.Drawing.Point(1119, 410)
        Me.LbFechaFinal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbFechaFinal.Name = "LbFechaFinal"
        Me.LbFechaFinal.Size = New System.Drawing.Size(220, 45)
        Me.LbFechaFinal.TabIndex = 34
        Me.LbFechaFinal.Text = "  Fecha final   "
        '
        'DateTimePickerFechaFinal
        '
        Me.DateTimePickerFechaFinal.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DateTimePickerFechaFinal.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateTimePickerFechaFinal.Font = New System.Drawing.Font("Yu Gothic UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFechaFinal.Location = New System.Drawing.Point(947, 482)
        Me.DateTimePickerFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerFechaFinal.Name = "DateTimePickerFechaFinal"
        Me.DateTimePickerFechaFinal.Size = New System.Drawing.Size(596, 47)
        Me.DateTimePickerFechaFinal.TabIndex = 33
        '
        'btSInsertar
        '
        Me.btSInsertar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btSInsertar.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSInsertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btSInsertar.Location = New System.Drawing.Point(1071, 565)
        Me.btSInsertar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btSInsertar.Name = "btSInsertar"
        Me.btSInsertar.Size = New System.Drawing.Size(357, 58)
        Me.btSInsertar.TabIndex = 35
        Me.btSInsertar.Text = "Enviar Solicitud"
        Me.btSInsertar.UseVisualStyleBackColor = False
        '
        'NuevaSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.PARCIAL1.My.Resources.Resources.WhatsApp_Image_2024_07_11_at_7_55_27_PM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1928, 910)
        Me.Controls.Add(Me.btSInsertar)
        Me.Controls.Add(Me.LbFechaFinal)
        Me.Controls.Add(Me.DateTimePickerFechaFinal)
        Me.Controls.Add(Me.lbFechaInicio)
        Me.Controls.Add(Me.DateTimePickerFechaInicio)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "NuevaSolicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NuevaSolicitud"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnvolver As Button
    Friend WithEvents DateTimePickerFechaInicio As DateTimePicker
    Friend WithEvents lbFechaInicio As Label
    Friend WithEvents LbFechaFinal As Label
    Friend WithEvents DateTimePickerFechaFinal As DateTimePicker
    Friend WithEvents btSInsertar As Button
End Class
