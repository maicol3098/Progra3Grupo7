Public Class Form1
    Dim Conexion As Conexion = New Conexion()
    Private vusuario As String
    Private isAdmin As Integer
    Private vnombre As String

    ' Contructor por default
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Constructor con parametros de login
    Public Sub New(vusuario As String, isAdmin As Integer, vnombre As String)
        InitializeComponent()
        Me.vusuario = vusuario
        Me.isAdmin = isAdmin
        Me.vnombre = vnombre
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Bienvenido al sistema")
        Conexion.conectar()

        ' Actualizar titulo si es administrador
        Dim adminText As String = If(isAdmin = 1, "(administrador)", "")
        lbltitle1.Text = $"Bienvenido - {vnombre} {adminText}"

        ' Ocultar botones para usuarios estandard
        btnsolicitudes.Visible = (isAdmin = 1)
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        ' Boton de salir
        Application.Exit()
    End Sub

    Private Sub btnsolicitudes_Click(sender As Object, e As EventArgs) Handles btnsolicitudes.Click
        ' ir a la pagina de solicitudes
        Dim solicitudesform As New Solicitudes(Me)
        solicitudesform.Show()
        Me.Hide()
    End Sub

    Private Sub btnhacersolicitud_Click(sender As Object, e As EventArgs) Handles btnhacersolicitud.Click
        ' ir a la pagina de hacer solicitud
        Dim form1 As New NuevaSolicitud(vusuario, Me)
        form1.Show()
        Me.Visible = False
    End Sub

End Class
