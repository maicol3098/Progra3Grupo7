﻿Public Class registro

    Dim Conexion As Conexion = New Conexion()




    Private Sub Btnguardar_Click(sender As Object, e As EventArgs) Handles Btnguardar.Click
        'codigo para guardar el usuario
        Dim strsql, vusuario, vclave, VID, vNombre, vApellido As String
        Dim j As Integer

        strsql = ""
        vusuario = ""
        vclave = ""
        j = 0
        VID = ""

        Try
            If txtusuario.Text = "" Or txtclave.Text = "" Or mskid.Text = "" Or tbApellido.Text = "" Or tbNombre.Text = "" Then
                MsgBox("Datos incompletos, favor completar")
                Return

            Else

                If MessageBox.Show("Esta seguro que quiere guardar?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                    vclave = txtclave.Text
                    vusuario = txtusuario.Text
                    j = Len(txtclave.Text)


                    VID = mskid.Text
                    VID = VID.Replace("-", "")


                    'revisar si el usuario existe en la base de datos

                    Conexion.consultar("SELECT * FROM USERS WHERE USUARIO= '" + vusuario + "'", "USERS")

                    If Conexion.ds.Tables("USERS").Rows.Count > 0 Then

                        f = 0

                    Else

                        f = 1

                    End If

                    If f = 0 Then

                        MsgBox("El usuario ya existe, inicie sesion o cree uno nuevo")
                        Return
                    End If


                    Conexion.consultar("SELECT * FROM USERS WHERE IDENTIFICACION= '" + VID + "'", "USERS")

                    If Conexion.ds.Tables("USERS").Rows.Count > 0 Then

                        f = 0

                    Else

                        f = 1

                    End If

                    If f = 0 Then

                        MsgBox("El id ya esta siendo utilizado, inicie sesion o cree uno nuevo")
                        Return
                    End If



                    Dim contraseñaEncriptada As String = Conexion.encriptarcontrasena(vclave)
                    ' Conexion.encriptar(Txtclave.Text, j)



                    vclave = contraseñaEncriptada
                    vNombre = tbNombre.Text
                    vApellido = tbApellido.Text

                    strsql = "INSERT INTO USERS (USUARIO,CLAVE,IDENTIFICACION,isAdmin,NOMBRE,APELLIDO)"
                    strsql += vbCrLf + "VALUES ('" & vusuario & "','" & vclave & "','" & VID & "','" & 0 & "','" & vNombre & "','" & vApellido & "')"

                    Conexion.inserta_datos(strsql)



                    If f = 0 Then

                        MessageBox.Show("Datos almacenados exitosamente, ahora puede iniciar sesion", "datos guardado", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Else

                        MessageBox.Show("Error insertando datos", "datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error:" + ex.ToString)
        End Try



    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click

        'redireccion al la forma de login
        Dim login As New login()
        login.Show()


        Me.Visible() = False

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        'boton de salir
        Application.Exit()
    End Sub

    Private Sub registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ocultar los valores de contrasena
        txtclave.UseSystemPasswordChar = True
    End Sub
End Class