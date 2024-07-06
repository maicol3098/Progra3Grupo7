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
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(278, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 216)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(480, 144)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(180, 31)
        Me.txtid.TabIndex = 2
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(480, 211)
        Me.txtclave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(180, 31)
        Me.txtclave.TabIndex = 3
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(478, 292)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(186, 36)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "Iniciar sesion"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'btnregistrar
        '
        Me.btnregistrar.Location = New System.Drawing.Point(622, 609)
        Me.btnregistrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(206, 36)
        Me.btnregistrar.TabIndex = 6
        Me.btnregistrar.Text = "Registrese aqui!"
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.Location = New System.Drawing.Point(898, 608)
        Me.Btnsalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(147, 36)
        Me.Btnsalir.TabIndex = 7
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(630, 578)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "No tiene una cuenta?"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 703)
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
