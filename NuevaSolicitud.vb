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
