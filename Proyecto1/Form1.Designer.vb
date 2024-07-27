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
        Me.btnsalir.Location = New System.Drawing.Point(1383, 816)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(112, 36)
        Me.btnsalir.TabIndex = 27
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'lbltitle1
        '
        Me.lbltitle1.AutoSize = True
        Me.lbltitle1.Location = New System.Drawing.Point(93, 86)
        Me.lbltitle1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitle1.Name = "lbltitle1"
        Me.lbltitle1.Size = New System.Drawing.Size(222, 25)
        Me.lbltitle1.TabIndex = 20
        Me.lbltitle1.Text = "Bienvenido al sistema"
        '
        'btnsolicitudes
        '
        Me.btnsolicitudes.Location = New System.Drawing.Point(242, 208)
        Me.btnsolicitudes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsolicitudes.Name = "btnsolicitudes"
        Me.btnsolicitudes.Size = New System.Drawing.Size(264, 39)
        Me.btnsolicitudes.TabIndex = 28
        Me.btnsolicitudes.Text = "Ver solicitudes"
        Me.btnsolicitudes.UseVisualStyleBackColor = True
        '
        'btnhacersolicitud
        '
        Me.btnhacersolicitud.Location = New System.Drawing.Point(242, 289)
        Me.btnhacersolicitud.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnhacersolicitud.Name = "btnhacersolicitud"
        Me.btnhacersolicitud.Size = New System.Drawing.Size(264, 39)
        Me.btnhacersolicitud.TabIndex = 29
        Me.btnhacersolicitud.Text = "Hacer solicitud"
        Me.btnhacersolicitud.UseVisualStyleBackColor = True
        '
        'btnconsultarvacaciones
        '
        Me.btnconsultarvacaciones.Location = New System.Drawing.Point(242, 364)
        Me.btnconsultarvacaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnconsultarvacaciones.Name = "btnconsultarvacaciones"
        Me.btnconsultarvacaciones.Size = New System.Drawing.Size(264, 68)
        Me.btnconsultarvacaciones.TabIndex = 30
        Me.btnconsultarvacaciones.Text = "Mis solicitudes"
        Me.btnconsultarvacaciones.UseVisualStyleBackColor = True
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
        Me.ClientSize = New System.Drawing.Size(2038, 906)
        Me.Controls.Add(Me.btnconsultarvacaciones)
        Me.Controls.Add(Me.btnhacersolicitud)
        Me.Controls.Add(Me.btnsolicitudes)
        Me.Controls.Add(Me.lbltitle1)
        Me.Controls.Add(Me.btnsalir)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
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
