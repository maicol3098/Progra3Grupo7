Public Class Form1
    Dim Conexion As Conexion = New Conexion()
    Private vusuario As String
    Private isAdmin As Integer

    ' contrcutor por defecto
    Public Sub New()
        ' 
        InitializeComponent()
    End Sub

    ' contrcutor con parametros desde login
    Public Sub New(vusuario As String, isAdmin As Integer)

        InitializeComponent()

        ' aqui se pueden agregar mas parametros que acepte el contrcutor
        Me.vusuario = vusuario
        Me.isAdmin = isAdmin
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Bienvenido al sistema")
        Conexion.conectar()

        ' actualizar el titulo si es administrador
        Dim adminText As String = If(isAdmin = 1, "(administrador)", "")
        lbltitle1.Text = $"Bienvenido - {vusuario} {adminText}"

        ' ocultar botones de adminitrador si no es administrador
        btnsolicitudes.Visible = (isAdmin = 1)
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        'boton de salir
        Application.Exit()
    End Sub

    Private Sub btnsolicitudes_Click(sender As Object, e As EventArgs) Handles btnsolicitudes.Click
        'ir a la pagina de solicitudes
        Dim solicitudesform As New Solicitudes(Me)
        solicitudesform.Show()
        Me.Hide()
    End Sub

    Private Sub btnhacersolicitud_Click(sender As Object, e As EventArgs) Handles btnhacersolicitud.Click

        'ir a la pagina de solicitudes

        Dim nuevaSolicitudForm As New NuevaSolicitud(Me)
        nuevaSolicitudForm.Show()

        Me.Hide()

    End Sub

    Private Sub btnconsultarvacaciones_Click(sender As Object, e As EventArgs) Handles btnconsultarvacaciones.Click

        'ir a la pagina de mis solicitudes

        Dim misSolicitudForm As New MisSolicitudes(Me)
        misSolicitudForm.Show()

        Me.Hide()
    End Sub
End Class
