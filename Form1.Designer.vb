<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.lbltitle1 = New System.Windows.Forms.Label()
        Me.btnsolicitudes = New System.Windows.Forms.Button()
        Me.btnhacersolicitud = New System.Windows.Forms.Button()
        Me.btnconsultarvacaciones = New System.Windows.Forms.Button()
        Me.NOTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NOTABindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbDiasDisponibles = New System.Windows.Forms.Label()
        Me.BtnEmailReporte = New System.Windows.Forms.Button()
        Me.LblNeedAttention = New System.Windows.Forms.Label()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.NOTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOTABindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsalir.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsalir.Location = New System.Drawing.Point(1497, 764)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(216, 51)
        Me.btnsalir.TabIndex = 27
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'lbltitle1
        '
        Me.lbltitle1.AutoSize = True
        Me.lbltitle1.Font = New System.Drawing.Font("Yu Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltitle1.Location = New System.Drawing.Point(60, 117)
        Me.lbltitle1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitle1.Name = "lbltitle1"
        Me.lbltitle1.Size = New System.Drawing.Size(480, 55)
        Me.lbltitle1.TabIndex = 20
        Me.lbltitle1.Text = "Bienvenido al sistema"
        '
        'btnsolicitudes
        '
        Me.btnsolicitudes.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsolicitudes.Font = New System.Drawing.Font("Yu Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsolicitudes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsolicitudes.Location = New System.Drawing.Point(1316, 419)
        Me.btnsolicitudes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsolicitudes.Name = "btnsolicitudes"
        Me.btnsolicitudes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnsolicitudes.Size = New System.Drawing.Size(379, 72)
        Me.btnsolicitudes.TabIndex = 28
        Me.btnsolicitudes.Text = "Ver solicitudes"
        Me.btnsolicitudes.UseVisualStyleBackColor = False
        '
        'btnhacersolicitud
        '
        Me.btnhacersolicitud.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnhacersolicitud.Font = New System.Drawing.Font("Yu Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhacersolicitud.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnhacersolicitud.Location = New System.Drawing.Point(89, 337)
        Me.btnhacersolicitud.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnhacersolicitud.Name = "btnhacersolicitud"
        Me.btnhacersolicitud.Size = New System.Drawing.Size(379, 74)
        Me.btnhacersolicitud.TabIndex = 29
        Me.btnhacersolicitud.Text = "Hacer solicitud"
        Me.btnhacersolicitud.UseVisualStyleBackColor = False
        '
        'btnconsultarvacaciones
        '
        Me.btnconsultarvacaciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnconsultarvacaciones.Font = New System.Drawing.Font("Yu Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultarvacaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnconsultarvacaciones.Location = New System.Drawing.Point(89, 445)
        Me.btnconsultarvacaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnconsultarvacaciones.Name = "btnconsultarvacaciones"
        Me.btnconsultarvacaciones.Size = New System.Drawing.Size(379, 80)
        Me.btnconsultarvacaciones.TabIndex = 30
        Me.btnconsultarvacaciones.Text = "Mis solicitudes"
        Me.btnconsultarvacaciones.UseVisualStyleBackColor = False
        '
        'NOTABindingSource
        '
        Me.NOTABindingSource.DataMember = "NOTA"
        '
        'NOTABindingSource1
        '
        Me.NOTABindingSource1.DataMember = "NOTA"
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUsuarios.Font = New System.Drawing.Font("Yu Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUsuarios.Location = New System.Drawing.Point(1316, 306)
        Me.btnUsuarios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnUsuarios.Size = New System.Drawing.Size(379, 72)
        Me.btnUsuarios.TabIndex = 31
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 680)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 25)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Sus Vacaciones Disponibles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1377, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 33
        '
        'LbDiasDisponibles
        '
        Me.LbDiasDisponibles.AutoSize = True
        Me.LbDiasDisponibles.Font = New System.Drawing.Font("Yu Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDiasDisponibles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LbDiasDisponibles.Location = New System.Drawing.Point(273, 738)
        Me.LbDiasDisponibles.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbDiasDisponibles.Name = "LbDiasDisponibles"
        Me.LbDiasDisponibles.Size = New System.Drawing.Size(49, 55)
        Me.LbDiasDisponibles.TabIndex = 34
        Me.LbDiasDisponibles.Text = "0"
        '
        'BtnEmailReporte
        '
        Me.BtnEmailReporte.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEmailReporte.Font = New System.Drawing.Font("Yu Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmailReporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEmailReporte.Location = New System.Drawing.Point(89, 561)
        Me.BtnEmailReporte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEmailReporte.Name = "BtnEmailReporte"
        Me.BtnEmailReporte.Size = New System.Drawing.Size(379, 80)
        Me.BtnEmailReporte.TabIndex = 35
        Me.BtnEmailReporte.Text = "Enviar Reporte"
        Me.BtnEmailReporte.UseVisualStyleBackColor = False
        '
        'LblNeedAttention
        '
        Me.LblNeedAttention.AutoSize = True
        Me.LblNeedAttention.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNeedAttention.ForeColor = System.Drawing.Color.Red
        Me.LblNeedAttention.Location = New System.Drawing.Point(701, 834)
        Me.LblNeedAttention.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNeedAttention.Name = "LblNeedAttention"
        Me.LblNeedAttention.Size = New System.Drawing.Size(601, 42)
        Me.LblNeedAttention.TabIndex = 36
        Me.LblNeedAttention.Text = "Hay Usuarios que requieren atencion"
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlogout.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlogout.Location = New System.Drawing.Point(1497, 825)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(216, 51)
        Me.btnlogout.TabIndex = 37
        Me.btnlogout.Text = "Cerrar Sesion"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1432, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 25)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Administracion"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.PARCIAL1.My.Resources.Resources.WhatsApp_Image_2024_07_11_at_7_55_27_PM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1895, 1038)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.LblNeedAttention)
        Me.Controls.Add(Me.BtnEmailReporte)
        Me.Controls.Add(Me.LbDiasDisponibles)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUsuarios)
        Me.Controls.Add(Me.btnconsultarvacaciones)
        Me.Controls.Add(Me.btnhacersolicitud)
        Me.Controls.Add(Me.btnsolicitudes)
        Me.Controls.Add(Me.lbltitle1)
        Me.Controls.Add(Me.btnsalir)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.NOTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOTABindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NOTABindingSource As BindingSource

    Friend WithEvents NOTABindingSource1 As BindingSource

    Friend WithEvents btnsalir As Button
    Friend WithEvents lbltitle1 As Label
    Friend WithEvents btnsolicitudes As Button
    Friend WithEvents btnhacersolicitud As Button
    Friend WithEvents btnconsultarvacaciones As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LbDiasDisponibles As Label
    Friend WithEvents BtnEmailReporte As Button
    Friend WithEvents LblNeedAttention As Label
    Friend WithEvents btnlogout As Button
    Friend WithEvents Label3 As Label
End Class
