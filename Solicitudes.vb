Imports System.Data.SqlClient

Public Class Solicitudes

    Private mainForm As Form1

    Public Sub New()

        InitializeComponent()
    End Sub

    ' Constructor para aceptar la referencia de Form1
    Public Sub New(mainForm As Form1)
        InitializeComponent()
        Me.mainForm = mainForm
    End Sub

    Private connectionString As String = "Data Source=MICHAELSEGU76AC\SQLEXPRESS;Initial Catalog=Progra3;Integrated Security=True"
    Private conexion As New Conexion()

    Private Sub Solicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' cargar datos al cargar el form
        Me.SOLICITUDESTableAdapter.Fill(Me.Progra3DataSet.SOLICITUDES)

        ' hacer Estado sea un drop down
        Dim comboBoxColumn As New DataGridViewComboBoxColumn()
        comboBoxColumn.Name = "ESTADO"
        comboBoxColumn.HeaderText = "ESTADO"
        comboBoxColumn.DataPropertyName = "ESTADO"
        comboBoxColumn.Items.AddRange("Solicitado", "Aprobado", "Denegado")


        DataGridView1.Columns.Remove("ESTADODataGridViewTextBoxColumn")
        DataGridView1.Columns.Insert(7, comboBoxColumn)

        ' poner las demas columnas en modo lectura
        For Each column As DataGridViewColumn In DataGridView1.Columns
            If column.Name <> "ESTADO" Then
                column.ReadOnly = True
            End If
        Next

        AddHandler DataGridView1.CellValueChanged, AddressOf DataGridView1_CellValueChanged

        AddHandler DataGridView1.DataError, AddressOf DataGridView1_DataError
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        ' revisar por cambios
        If DataGridView1.Columns.Contains("ESTADO") AndAlso e.ColumnIndex = DataGridView1.Columns("ESTADO").Index Then
            ' Confirmar cambios
            Dim result As DialogResult = MessageBox.Show("Quiere realizar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Actualizar la tabla
                Try

                    DataGridView1.EndEdit()

                    Me.Validate()
                    Me.BindingContext(Me.Progra3DataSet.SOLICITUDES).EndCurrentEdit()

                    UpdateDatabase()
                    MessageBox.Show("Actualizacion completa.")
                Catch ex As Exception
                    MessageBox.Show("Sucedio un error: " & ex.Message)
                End Try
            Else
                ' cargar tabla de nuevo si no se confirman los cambios
                Me.SOLICITUDESTableAdapter.Fill(Me.Progra3DataSet.SOLICITUDES)
            End If
        End If
    End Sub

    Private Sub UpdateDatabase()
        Dim updateCommand As New SqlCommand("UPDATE SOLICITUDES SET ESTADO = @ESTADO WHERE ID = @ID", conexion.conexion)
        updateCommand.Parameters.Add("@ESTADO", SqlDbType.VarChar, 50, "ESTADO")
        updateCommand.Parameters.Add("@ID", SqlDbType.Int, 4, "ID").SourceVersion = DataRowVersion.Original

        conexion.conexion.Open()
        For Each row As DataRow In Me.Progra3DataSet.SOLICITUDES.GetChanges(DataRowState.Modified).Rows
            updateCommand.Parameters("@ESTADO").Value = row("ESTADO")
            updateCommand.Parameters("@ID").Value = row("ID")
            updateCommand.ExecuteNonQuery()
        Next
        conexion.conexion.Close()

        Me.Progra3DataSet.SOLICITUDES.AcceptChanges()
    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        MessageBox.Show("Error con el valor de la celda: " & e.Context.ToString())
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Application.Exit()
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        ' salir de la pantalla solicitudes y volver a form1
        Me.mainForm.Show()
        Me.Close()
    End Sub

End Class
