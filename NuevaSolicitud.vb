Public Class NuevaSolicitud

    Private mainForm As Form1
    Private conexion As New Conexion()
    Private vusuario As String

    ' contructor con parametros de login
    Public Sub New(vusuario As String, mainForm As Form1)
        InitializeComponent()
        Me.vusuario = vusuario
        Me.mainForm = mainForm
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        'boton de salir
        Application.Exit()
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        ' revisar que el form1 existe antes de carga o dar mensaje de error
        If Me.mainForm IsNot Nothing Then
            Me.mainForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Form1 no existe.")
        End If
    End Sub

    Private Sub NuevaSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btSInsertar_Click(sender As Object, e As EventArgs) Handles btSInsertar.Click
        ' Obtener valores del form
        Dim fechaInicio As Date = DateTimePickerFechaInicio.Value
        Dim fechaFin As Date = DateTimePickerFechaFinal.Value
        Dim horas As Integer = 8 * (fechaFin - fechaInicio).Days

        ' verificar si el usuario existe en la base de datos
        Dim consultaUsuario As String = $"SELECT * FROM USERS WHERE USUARIO = '{vusuario}'"
        conexion.consultar(consultaUsuario, "USERS")

        If conexion.ds.Tables("USERS").Rows.Count > 0 Then
            ' usuario encontrado
            Dim userRow As DataRow = conexion.ds.Tables("USERS").Rows(0)
            Dim identificacion As String = userRow("IDENTIFICACION").ToString()
            Dim nombre As String = userRow("NOMBRE").ToString()
            Dim apellido As String = userRow("APELLIDO").ToString()

            ' insertar el usuario a la base de datos
            Dim consultaInsertar As String = $"INSERT INTO SOLICITUDES (IDENTIFICATION, NOMBRE, APELLIDO, HORAS, FECHA_FIN, FECHA_INICIO, ESTADO, EMAIL) " &
                                             $"VALUES ('{identificacion}', '{nombre}', '{apellido}', {horas}, '{fechaFin:yyyy-MM-dd}', '{fechaInicio:yyyy-MM-dd}', 'Solicitado', '{vusuario}')"

            If conexion.inserta_datos(consultaInsertar) Then
                MessageBox.Show("Solicitud insertada correctamente")
            Else
                MessageBox.Show("Error al insertar la solicitud")
            End If
        Else
            ' usuario no encontrado
            MessageBox.Show("Usuario no encontrado")
        End If
    End Sub

    Private Sub DateTimePickerFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFechaInicio.ValueChanged
    End Sub

    Private Sub DateTimePickerFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFechaFinal.ValueChanged
    End Sub

    Private Sub lbUsuario_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub txbUsuario_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub LbFechaFinal_Click(sender As Object, e As EventArgs) Handles LbFechaFinal.Click
    End Sub

    Private Sub lbFechaInicio_Click(sender As Object, e As EventArgs) Handles lbFechaInicio.Click
    End Sub
End Class
