<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro
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
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.lblclave = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.Btnlogin = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskid = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Location = New System.Drawing.Point(358, 153)
        Me.lblusuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(77, 25)
        Me.lblusuario.TabIndex = 0
        Me.lblusuario.Text = "Correo"
        '
        'lblclave
        '
        Me.lblclave.AutoSize = True
        Me.lblclave.Location = New System.Drawing.Point(312, 230)
        Me.lblclave.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblclave.Name = "lblclave"
        Me.lblclave.Size = New System.Drawing.Size(123, 25)
        Me.lblclave.TabIndex = 1
        Me.lblclave.Text = "Contraseña"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(297, 295)
        Me.lblid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(138, 25)
        Me.lblid.TabIndex = 2
        Me.lblid.Text = "Identificacion"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(454, 153)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(200, 31)
        Me.txtusuario.TabIndex = 3
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(454, 230)
        Me.txtclave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(200, 31)
        Me.txtclave.TabIndex = 4
        '
        'Btnguardar
        '
        Me.Btnguardar.Location = New System.Drawing.Point(435, 384)
        Me.Btnguardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(222, 36)
        Me.Btnguardar.TabIndex = 6
        Me.Btnguardar.Text = "Registrarse"
        Me.Btnguardar.UseVisualStyleBackColor = True
        '
        'Btnlogin
        '
        Me.Btnlogin.Location = New System.Drawing.Point(747, 628)
        Me.Btnlogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(172, 36)
        Me.Btnlogin.TabIndex = 7
        Me.Btnlogin.Text = "Ingrese aqui!"
        Me.Btnlogin.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(1008, 628)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(112, 36)
        Me.btnsalir.TabIndex = 8
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(742, 598)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ya tiene una cuenta?"
        '
        'mskid
        '
        Me.mskid.Location = New System.Drawing.Point(454, 295)
        Me.mskid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mskid.Mask = "0-0000-0000"
        Me.mskid.Name = "mskid"
        Me.mskid.Size = New System.Drawing.Size(200, 31)
        Me.mskid.TabIndex = 10
        '
        'registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 703)
        Me.Controls.Add(Me.mskid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Btnlogin)
        Me.Controls.Add(Me.Btnguardar)
        Me.Controls.Add(Me.txtclave)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.lblclave)
        Me.Controls.Add(Me.lblusuario)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "registro"
        Me.Text = "registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblusuario As Label
    Friend WithEvents lblclave As Label
    Friend WithEvents lblid As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtclave As TextBox
    Friend WithEvents Btnguardar As Button
    Friend WithEvents Btnlogin As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents mskid As MaskedTextBox
End Class
