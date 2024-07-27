Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Conexion


    Public conexion As SqlConnection = New SqlConnection("Data Source=MICHAELSEGU76AC\SQLEXPRESS;Initial Catalog=Progra3;Integrated Security=True")


    Public comando As SqlCommand
    Public da As SqlDataAdapter
    Public ds As DataSet = New DataSet()
    Public builder As SqlCommandBuilder

    Public Sub conectar()

        Try
            conexion.Open()



        Catch ex As Exception

            MessageBox.Show("Error" + ex.ToString)

        Finally

            conexion.Close()

        End Try

    End Sub

    Public Function inserta_datos(ByVal datos As String) As Boolean

        Try
            conexion.Open()
            comando = New SqlCommand(datos, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            f = 0

            Return True

        Catch ex As Exception

            MessageBox.Show("Error:" + ex.ToString)
            Return False

        Finally
            conexion.Close()

        End Try

    End Function




    Public Sub consultar(ByVal sql As String, ByVal tabla As String)


        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        builder = New SqlCommandBuilder(da)

        da.Fill(ds, tabla)

    End Sub


    Public Function encriptar(ByVal Password As String, ByVal PasswordLong As Integer) As String

        Dim caracter As Integer = 0

        Dim cifrado As String = ""

        For i = 1 To PasswordLong

            caracter = Asc(Mid(Password, i)) + 64


            If caracter > 255 Then caracter = caracter - 256
            cifrado = cifrado + Chr(caracter)
        Next


        encriptar = cifrado
        resultado = encriptar



    End Function


    Public Function desEncriptar(ByVal palabracifrada As String, ByVal palabracifradalong As Integer) As String

        Dim caracter As Integer = 0
        Dim descifrado As String = ""

        For i = 1 To palabracifradalong
            caracter = Asc(Mid(palabracifrada, i)) - 64
            If caracter = 1 Then caracter = caracter + 256
            descifrado = descifrado + Chr(caracter)
        Next

        desEncriptar = descifrado
        resultado = desEncriptar

    End Function

    Public Function encriptarcontrasena(contrasena As String) As String

        Dim sha256 As SHA256 = SHA256Managed.Create()

        Dim bytes As Byte() = Encoding.UTF8.GetBytes(contrasena)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringbuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringbuilder.Append(hash(i).ToString("X2"))

        Next

        Return stringbuilder.ToString()

    End Function


    Public Function desencriptarcontrasena(contrasenaencriptada As String) As String

        Dim sha256 As SHA256 = SHA256Managed.Create()

        Dim hashBytes As Byte() = Encoding.UTF8.GetBytes(contrasenaencriptada)

        Dim decryptedbytes As Byte() = sha256.ComputeHash(hashBytes)

        Dim decryptedbuilder As New StringBuilder()
        For i As Integer = 0 To decryptedbytes.Length - 1

            decryptedbuilder.Append(decryptedbytes(i).ToString("X2"))
        Next

        Return decryptedbuilder.ToString()

    End Function


End Class
