Public Class NuevaSolicitud

    Private mainForm As Form1

    Public Sub New()
        '
        InitializeComponent()
    End Sub

    ' Constructor para aceptar referencia de Form1
    Public Sub New(mainForm As Form1)

        InitializeComponent()

        Me.mainForm = mainForm
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Application.Exit()
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        ' volver a form1
        If Me.mainForm IsNot Nothing Then
            Me.mainForm.Show()
        End If
        Me.Close()
    End Sub

    Private Sub NuevaSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
