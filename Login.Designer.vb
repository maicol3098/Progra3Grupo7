<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(1177, 231)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(1152, 371)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(1063, 306)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(344, 31)
        Me.txtid.TabIndex = 2
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(1063, 426)
        Me.txtclave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(344, 31)
        Me.txtclave.TabIndex = 3
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlogin.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlogin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnlogin.Location = New System.Drawing.Point(1027, 518)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(419, 54)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "Iniciar sesion"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'btnregistrar
        '
        Me.btnregistrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnregistrar.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnregistrar.Location = New System.Drawing.Point(1114, 689)
        Me.btnregistrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(252, 65)
        Me.btnregistrar.TabIndex = 6
        Me.btnregistrar.Text = "Regístrese aquí"
        Me.btnregistrar.UseVisualStyleBackColor = False
        '
        'Btnsalir
        '
        Me.Btnsalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnsalir.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnsalir.Location = New System.Drawing.Point(1497, 764)
        Me.Btnsalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(181, 51)
        Me.Btnsalir.TabIndex = 7
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1077, 614)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(314, 39)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "No tiene una cuenta?"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.PARCIAL1.My.Resources.Resources.WhatsApp_Image_2024_07_11_at_7_55_27_PM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1928, 910)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.btnregistrar)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtclave)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtclave As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnregistrar As Button
    Friend WithEvents Btnsalir As Button
    Friend WithEvents Label3 As Label
End Class
