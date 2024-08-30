Public Class Form1
    Dim Conexion As Conexion = New Conexion()
    Private vusuario As String
    Private isAdmin As Integer
    Private vnombre As String
    Private VacacionesDisponibles As Integer
    Private emailSender As EmailSender = New EmailSender()

    ' Constructor por default
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Constructor con parametros de login
    Public Sub New(vusuario As String, isAdmin As Integer, vnombre As String, VacacionesDisponibles As Integer)
        InitializeComponent()
        Me.vusuario = vusuario
        Me.isAdmin = isAdmin
        Me.vnombre = vnombre
        Me.VacacionesDisponibles = VacacionesDisponibles
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.conectar()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        UpdateFormData() ' Refrescar la informacion cada vez que la forma carga
    End Sub

    Public Sub UpdateFormData()
        ' esconder aviso sobre usuarios pendientes de informacion si no los hay
        LblNeedAttention.Visible = False

        ' Revisar si usuario es admin
        If isAdmin = 1 Then
            ' Revisar si hay usuarios con nulos en VACACIONES_DISPONIBLES o FECHA_INICIO_LABORAL
            Dim sqlQuery As String = "SELECT COUNT(*) FROM USERS WHERE VACACIONES_DISPONIBLES IS NULL OR FECHA_INICIO_LABORAL IS NULL"
            Conexion.consultar(sqlQuery, "USERS")

            If Conexion.ds.Tables("USERS").Rows(0)(0) > 0 Then
                LblNeedAttention.Text = "Hay usuarios que necesitan atención"
                LblNeedAttention.Visible = True
            Else
                LblNeedAttention.Visible = False
            End If
        End If

        ' Actualizar título si es administrador
        Dim adminText As String = If(isAdmin = 1, "(administrador)", "")
        lbltitle1.Text = $"Bienvenido - {vnombre} {adminText}"

        ' Obtener dias de vacaciones disponibles para visualizar en el form
        Dim sqlQueryUser As String = $"SELECT VACACIONES_DISPONIBLES FROM USERS WHERE USUARIO = '{vusuario}'"
        Conexion.consultar(sqlQueryUser, "USERS")

        If Conexion.ds.Tables("USERS").Rows.Count > 0 Then
            VacacionesDisponibles = Convert.ToInt32(Conexion.ds.Tables("USERS").Rows(0)("VACACIONES_DISPONIBLES"))
        End If
        LbDiasDisponibles.Text = VacacionesDisponibles
    End Sub


    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        ' boton de salir
        Application.Exit()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        ' boton de logout/cerrar sesion
        Dim loginForm As New login()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub btnsolicitudes_Click(sender As Object, e As EventArgs) Handles btnsolicitudes.Click
        ' ir a la pagina de solicitudes
        Dim solicitudesform As New Solicitudes(Me)
        solicitudesform.Show()
        Me.Hide()
    End Sub

    Private Sub btnhacersolicitud_Click(sender As Object, e As EventArgs) Handles btnhacersolicitud.Click
        ' ir a la pagina de nueva solicitud
        Dim form1 As New NuevaSolicitud(vusuario, Me, VacacionesDisponibles)
        form1.Show()
        Me.Visible = False
    End Sub

    Private Sub btnconsultarvacaciones_Click(sender As Object, e As EventArgs) Handles btnconsultarvacaciones.Click
        ' ir a la pagina de consultar vacaciones
        Dim form1 As New MisSolicitudes(vusuario, Me, VacacionesDisponibles)
        form1.Show()
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        ' ir a la pagina de usuarios
        Dim form1 As New Usuarios(vusuario, Me)
        form1.Show()
        Me.Visible = False
    End Sub

    Private Sub BtnEmailReporte_Click(sender As Object, e As EventArgs) Handles BtnEmailReporte.Click
        Try
            ' ir a la tabla de usuarios para obtener las vacaciones disponibles
            Dim sqlQueryUser As String = $"SELECT VACACIONES_DISPONIBLES FROM USERS WHERE USUARIO = '{vusuario}'"
            Conexion.consultar(sqlQueryUser, "USERS")

            Dim vacacionesDisponibles As Integer = 0
            If Conexion.ds.Tables("USERS").Rows.Count > 0 Then
                vacacionesDisponibles = Convert.ToInt32(Conexion.ds.Tables("USERS").Rows(0)("VACACIONES_DISPONIBLES"))
            End If

            ' obtener la lista de solicitudes para el usuario actual
            Dim sqlQuerySolicitudes As String = $"SELECT IDENTIFICATION, NOMBRE, APELLIDO, FECHA_INICIO, FECHA_FIN, ESTADO, DIAS_SOLICITADOS FROM SOLICITUDES WHERE EMAIL = '{vusuario}'"
            Conexion.consultar(sqlQuerySolicitudes, "SOLICITUDES")

            If Conexion.ds.Tables("SOLICITUDES").Rows.Count > 0 Then
                ' creacion del correo
                Dim body As New System.Text.StringBuilder()
                Dim currentDate As String = DateTime.Now.ToString("dd/MM/yyyy")
                body.AppendLine($"Reporte de Solicitudes de Vacaciones - Fecha: {currentDate}")
                body.AppendLine("")

                ' resumen de las solicitudes
                body.AppendLine($"Días de vacaciones disponibles: {vacacionesDisponibles}")
                body.AppendLine("")

                For Each row As DataRow In Conexion.ds.Tables("SOLICITUDES").Rows
                    Dim identification As String = row("IDENTIFICATION").ToString()
                    Dim nombre As String = row("NOMBRE").ToString()
                    Dim apellido As String = row("APELLIDO").ToString()
                    Dim fechaInicio As String = Convert.ToDateTime(row("FECHA_INICIO")).ToString("dd/MM/yyyy")
                    Dim fechaFin As String = Convert.ToDateTime(row("FECHA_FIN")).ToString("dd/MM/yyyy")
                    Dim estado As String = row("ESTADO").ToString()
                    Dim diasSolicitados As Integer = Convert.ToInt32(row("DIAS_SOLICITADOS"))

                    body.AppendLine($"- {nombre} {apellido} (ID: {identification}):")
                    body.AppendLine($"  * Fecha Inicio: {fechaInicio}")
                    body.AppendLine($"  * Fecha Fin: {fechaFin}")
                    body.AppendLine($"  * Estado: {estado}")
                    body.AppendLine($"  * Días Solicitados: {diasSolicitados}")
                    body.AppendLine("")
                Next

                ' titulo del correo
                Dim subject As String = "Reporte de Solicitudes de Vacaciones"

                ' enviar el correo al usuario
                emailSender.SendEmail(vusuario, subject, body.ToString())

                MessageBox.Show("Reporte enviado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No hay solicitudes disponibles para enviar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al enviar el reporte: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LblNeedAttention_Click(sender As Object, e As EventArgs) Handles LblNeedAttention.Click

    End Sub
End Class
