Public Class login
    Dim Conexion As Conexion = New Conexion()

    Private Sub Btnguardar_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim strsql, vusuario, vclave, VID, nombre As String
        Dim j, isAdmin, vacacionesDisponibles As Integer
        'iniciar variables
        strsql = ""
        vusuario = ""
        vclave = ""
        j = 0
        VID = ""
        isAdmin = 0
        nombre = ""
        vacacionesDisponibles = 0

        Try
            If txtid.Text = "" Or txtclave.Text = "" Then
                MsgBox("Datos incompletos, favor completar")
                Return
            Else
                vusuario = txtid.Text
                j = Len(txtclave.Text)
                VID = txtid.Text
                vclave = txtclave.Text
                ' buscar el usuario para confirmar si existe
                Conexion.consultar("SELECT * FROM USERS WHERE USUARIO= '" + vusuario + "'", "USERS")

                If Conexion.ds.Tables("USERS").Rows.Count > 0 Then
                    f = 0
                Else
                    f = 1
                End If

                If f = 0 Then

                    'desencriptar la contrasena y comparar con la contrasena digitada por los usuarios

                    Dim contraseñaAlmacenada As String = Conexion.ds.Tables("USERS").Rows(0)("CLAVE").ToString()
                    Dim nombreAlmacenado As String = Conexion.ds.Tables("USERS").Rows(0)("NOMBRE").ToString()
                    Dim contraseñaEncriptada As String = Conexion.encriptarcontrasena(vclave)

                    ' Check if VACACIONES_DISPONIBLES is null
                    If IsDBNull(Conexion.ds.Tables("USERS").Rows(0)("VACACIONES_DISPONIBLES")) Then
                        MessageBox.Show("El administrador nesecita revisar la cuenta primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    Else
                        vacacionesDisponibles = Convert.ToInt32(Conexion.ds.Tables("USERS").Rows(0)("VACACIONES_DISPONIBLES"))
                    End If

                    ' codigo para revisar si hay nulos
                    If Not IsDBNull(Conexion.ds.Tables("USERS").Rows(0)("isAdmin")) Then
                        isAdmin = Convert.ToInt32(Conexion.ds.Tables("USERS").Rows(0)("isAdmin"))
                    Else
                        isAdmin = 0
                    End If

                    If contraseñaAlmacenada = contraseñaEncriptada Then
                        MessageBox.Show("Login exitoso", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        Dim form1 As New Form1(vusuario, isAdmin, nombreAlmacenado, vacacionesDisponibles)
                        form1.Show()
                        Me.Visible = False
                        f = 0
                    Else
                        MessageBox.Show("Contrasena incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        f = 2
                    End If
                Else
                    MessageBox.Show("Usuario no encontrado", "Debe registrarse", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error:" + ex.ToString)
        End Try
    End Sub


    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ocultar los valores de contrasena

        txtclave.UseSystemPasswordChar = True
    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        'boton de registrar

        Dim registro As New registro()
        registro.Show()
        Me.Visible = False
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        'boton de salir
        Application.Exit()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
