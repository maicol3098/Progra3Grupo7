Public Class NuevaSolicitud

    Private mainForm As Form1
    Private conexion As New Conexion()
    Private vusuario As String
    Private VacacionesDisponibles As Integer

    ' Constructor con parametros de login
    Public Sub New(vusuario As String, mainForm As Form1, VacacionesDisponibles As Integer)
        InitializeComponent()
        Me.vusuario = vusuario
        Me.mainForm = mainForm
        Me.VacacionesDisponibles = VacacionesDisponibles
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        ' Botón de salir
        Application.Exit()
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        ' Revisar que el form1 existe antes de cargar o dar mensaje de error
        If Me.mainForm IsNot Nothing Then
            Me.mainForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Form1 no existe.")
        End If
    End Sub

    Private Sub NuevaSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar VacacionesDisponibles en un label 
        LbDiasDisponibles.Text = VacacionesDisponibles.ToString()
        ' Calcular y mostrar la cantidad de días solicitados 
        UpdateDiasSolicitados()
    End Sub

    Private Sub btSInsertar_Click(sender As Object, e As EventArgs) Handles btSInsertar.Click
        ' Obtener valores del form
        Dim fechaInicio As Date = DateTimePickerFechaInicio.Value
        Dim fechaFin As Date = DateTimePickerFechaFinal.Value
        Dim diasSolicitados As Integer = (fechaFin - fechaInicio).Days + 1 ' Calcular la cantidad de días solicitados

        ' Verificar si los días solicitados exceden los días disponibles
        If diasSolicitados > VacacionesDisponibles Then
            MessageBox.Show("No tiene suficientes dias disponibles")
            Return
        End If

        ' Verificar si el usuario existe en la base de datos
        Dim consultaUsuario As String = $"SELECT * FROM USERS WHERE USUARIO = '{vusuario}'"
        conexion.consultar(consultaUsuario, "USERS")

        If conexion.ds.Tables("USERS").Rows.Count > 0 Then
            ' Usuario encontrado
            Dim userRow As DataRow = conexion.ds.Tables("USERS").Rows(0)
            Dim identificacion As String = userRow("IDENTIFICACION").ToString()
            Dim nombre As String = userRow("NOMBRE").ToString()
            Dim apellido As String = userRow("APELLIDO").ToString()
            Dim horas As Integer = 8

            ' Insertar el usuario a la base de datos
            Dim consultaInsertar As String = $"INSERT INTO SOLICITUDES (IDENTIFICATION, NOMBRE, APELLIDO, HORAS, FECHA_FIN, FECHA_INICIO, ESTADO, EMAIL, DIAS_SOLICITADOS) " &
                                         $"VALUES ('{identificacion}', '{nombre}', '{apellido}', {horas}, '{fechaFin:yyyy-MM-dd}', '{fechaInicio:yyyy-MM-dd}', 'Solicitado', '{vusuario}', {diasSolicitados})"

            If conexion.inserta_datos(consultaInsertar) Then
                MessageBox.Show("Solicitud insertada correctamente")
            Else
                MessageBox.Show("Error al insertar la solicitud")
            End If
        Else
            ' Usuario no encontrado
            MessageBox.Show("Usuario no encontrado")
        End If
    End Sub

    Private Sub DateTimePickerFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFechaInicio.ValueChanged
        ' Actualizar la cantidad de días solicitados cuando cambia la fecha de inicio
        UpdateDiasSolicitados()
    End Sub

    Private Sub DateTimePickerFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFechaFinal.ValueChanged
        ' Actualizar la cantidad de días solicitados cuando cambia la fecha de finalización
        UpdateDiasSolicitados()
    End Sub

    Private Sub UpdateDiasSolicitados()
        ' Calcular la cantidad de días entre las fechas seleccionadas
        Dim fechaInicio As Date = DateTimePickerFechaInicio.Value
        Dim fechaFin As Date = DateTimePickerFechaFinal.Value
        Dim diasSolicitados As Integer = (fechaFin - fechaInicio).Days + 1

        ' Actualizar el label con la cantidad de días solicitados
        LblcantidadDias.Text = diasSolicitados.ToString()
    End Sub

End Class
