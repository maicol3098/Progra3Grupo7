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
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.lbltitle1 = New System.Windows.Forms.Label()
        Me.btnsolicitudes = New System.Windows.Forms.Button()
        Me.btnhacersolicitud = New System.Windows.Forms.Button()
        Me.btnconsultarvacaciones = New System.Windows.Forms.Button()
        Me.NOTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NOTABindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.btnsalir.Size = New System.Drawing.Size(181, 51)
        Me.btnsalir.TabIndex = 27
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'lbltitle1
        '
        Me.lbltitle1.AutoSize = True
        Me.lbltitle1.Font = New System.Drawing.Font("Yu Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltitle1.Location = New System.Drawing.Point(80, 179)
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
        Me.btnsolicitudes.Location = New System.Drawing.Point(89, 358)
        Me.btnsolicitudes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsolicitudes.Name = "btnsolicitudes"
        Me.btnsolicitudes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnsolicitudes.Size = New System.Drawing.Size(417, 72)
        Me.btnsolicitudes.TabIndex = 28
        Me.btnsolicitudes.Text = "Ver solicitudes"
        Me.btnsolicitudes.UseVisualStyleBackColor = False
        '
        'btnhacersolicitud
        '
        Me.btnhacersolicitud.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnhacersolicitud.Font = New System.Drawing.Font("Yu Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhacersolicitud.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnhacersolicitud.Location = New System.Drawing.Point(89, 470)
        Me.btnhacersolicitud.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnhacersolicitud.Name = "btnhacersolicitud"
        Me.btnhacersolicitud.Size = New System.Drawing.Size(417, 74)
        Me.btnhacersolicitud.TabIndex = 29
        Me.btnhacersolicitud.Text = "Hacer solicitud"
        Me.btnhacersolicitud.UseVisualStyleBackColor = False
        '
        'btnconsultarvacaciones
        '
        Me.btnconsultarvacaciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnconsultarvacaciones.Font = New System.Drawing.Font("Yu Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultarvacaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnconsultarvacaciones.Location = New System.Drawing.Point(89, 578)
        Me.btnconsultarvacaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnconsultarvacaciones.Name = "btnconsultarvacaciones"
        Me.btnconsultarvacaciones.Size = New System.Drawing.Size(417, 80)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.PARCIAL1.My.Resources.Resources.WhatsApp_Image_2024_07_11_at_7_55_27_PM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1924, 906)
        Me.Controls.Add(Me.btnconsultarvacaciones)
        Me.Controls.Add(Me.btnhacersolicitud)
        Me.Controls.Add(Me.btnsolicitudes)
        Me.Controls.Add(Me.lbltitle1)
        Me.Controls.Add(Me.btnsalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
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
End Class
