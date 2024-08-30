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
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Font = New System.Drawing.Font("Yu Gothic", 12.0!)
        Me.lblusuario.Location = New System.Drawing.Point(281, 305)
        Me.lblusuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(118, 42)
        Me.lblusuario.TabIndex = 0
        Me.lblusuario.Text = "Correo"
        '
        'lblclave
        '
        Me.lblclave.AutoSize = True
        Me.lblclave.Font = New System.Drawing.Font("Yu Gothic", 12.0!)
        Me.lblclave.Location = New System.Drawing.Point(255, 394)
        Me.lblclave.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblclave.Name = "lblclave"
        Me.lblclave.Size = New System.Drawing.Size(189, 42)
        Me.lblclave.TabIndex = 1
        Me.lblclave.Text = "Contraseña"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Yu Gothic", 12.0!)
        Me.lblid.Location = New System.Drawing.Point(239, 493)
        Me.lblid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(218, 42)
        Me.lblid.TabIndex = 2
        Me.lblid.Text = "Identificacion"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(184, 353)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(316, 31)
        Me.txtusuario.TabIndex = 3
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(184, 441)
        Me.txtclave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(316, 31)
        Me.txtclave.TabIndex = 4
        '
        'Btnguardar
        '
        Me.Btnguardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnguardar.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!)
        Me.Btnguardar.ForeColor = System.Drawing.SystemColors.Control
        Me.Btnguardar.Location = New System.Drawing.Point(223, 617)
        Me.Btnguardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(260, 51)
        Me.Btnguardar.TabIndex = 6
        Me.Btnguardar.Text = "Registrarse"
        Me.Btnguardar.UseVisualStyleBackColor = False
        '
        'Btnlogin
        '
        Me.Btnlogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnlogin.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!)
        Me.Btnlogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Btnlogin.Location = New System.Drawing.Point(252, 796)
        Me.Btnlogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(198, 71)
        Me.Btnlogin.TabIndex = 7
        Me.Btnlogin.Text = "Ingrese aqui!"
        Me.Btnlogin.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsalir.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!)
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnsalir.Location = New System.Drawing.Point(1483, 833)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(225, 67)
        Me.btnsalir.TabIndex = 8
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(186, 752)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 39)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ya tiene una cuenta?"
        '
        'mskid
        '
        Me.mskid.Location = New System.Drawing.Point(184, 558)
        Me.mskid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mskid.Mask = "0-0000-0000"
        Me.mskid.Name = "mskid"
        Me.mskid.Size = New System.Drawing.Size(316, 31)
        Me.mskid.TabIndex = 10
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(184, 167)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(316, 31)
        Me.tbNombre.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(281, 120)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 42)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Nombre"
        '
        'tbApellido
        '
        Me.tbApellido.Location = New System.Drawing.Point(184, 260)
        Me.tbApellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(316, 31)
        Me.tbApellido.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(281, 213)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 42)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Apellido"
        '
        'registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.PARCIAL1.My.Resources.Resources.WhatsApp_Image_2024_07_11_at_7_55_27_PM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1895, 1038)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbApellido)
        Me.Controls.Add(Me.Label4)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents Label4 As Label
End Class
