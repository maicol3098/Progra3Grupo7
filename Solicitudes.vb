Imports System.Data.SqlClient
Imports System.IO

Public Class Solicitudes

    Private emailSender As EmailSender
    Private mainForm As Form1
    Private conexion As New Conexion() ' Use the Conexion class

    Public Sub New()
        InitializeComponent()
    End Sub

    ' Constructor para aceptar la referencia de Form1
    Public Sub New(mainForm As Form1)
        InitializeComponent()
        Me.mainForm = mainForm
    End Sub

    Private Sub Solicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emailSender = New EmailSender()

        ' Cargar datos al cargar el formulario
        Me.SOLICITUDESTableAdapter.Fill(Me.Progra3DataSet.SOLICITUDES)

        ' Verificar si la columna IDENTIFICATION existe y agregarla si es necesario
        If Not DataGridView1.Columns.Contains("IDENTIFICATION") Then
            Dim identificationColumn As New DataGridViewTextBoxColumn()
            identificationColumn.Name = "IDENTIFICATION"
            identificationColumn.HeaderText = "IDENTIFICATION"
            identificationColumn.DataPropertyName = "IDENTIFICATION"
            DataGridView1.Columns.Add(identificationColumn)
        End If

        ' Hacer que Estado sea un combo box
        Dim comboBoxColumn As New DataGridViewComboBoxColumn()
        comboBoxColumn.Name = "ESTADO"
        comboBoxColumn.HeaderText = "ESTADO"
        comboBoxColumn.DataPropertyName = "ESTADO"
        comboBoxColumn.Items.AddRange("Solicitado", "Aprobado", "Denegado")

        ' Inicializar y agregar columnas
        Dim fechaInicioColumn As New DataGridViewTextBoxColumn()
        fechaInicioColumn.Name = "FECHA_INICIO"
        fechaInicioColumn.HeaderText = "FECHA_INICIO"
        fechaInicioColumn.DataPropertyName = "FECHA_INICIO"

        Dim fechaFinColumn As New DataGridViewTextBoxColumn()
        fechaFinColumn.Name = "FECHA_FIN"
        fechaFinColumn.HeaderText = "FECHA_FIN"
        fechaFinColumn.DataPropertyName = "FECHA_FIN"

        Dim emailColumn As New DataGridViewTextBoxColumn()
        emailColumn.Name = "EMAIL"
        emailColumn.HeaderText = "EMAIL"
        emailColumn.DataPropertyName = "EMAIL"

        ' Eliminar columnas existentes si están presentes para evitar conflicto
        If DataGridView1.Columns.Contains("FECHAINICIODataGridViewTextBoxColumn") Then
            DataGridView1.Columns.Remove("FECHAINICIODataGridViewTextBoxColumn")
        End If
        If DataGridView1.Columns.Contains("FECHAFINDataGridViewTextBoxColumn") Then
            DataGridView1.Columns.Remove("FECHAFINDataGridViewTextBoxColumn")
        End If
        If DataGridView1.Columns.Contains("ESTADODataGridViewTextBoxColumn") Then
            DataGridView1.Columns.Remove("ESTADODataGridViewTextBoxColumn")
        End If

        ' Agregar nuevas columnas
        DataGridView1.Columns.Add(fechaInicioColumn)
        DataGridView1.Columns.Add(fechaFinColumn)
        DataGridView1.Columns.Add(comboBoxColumn)
        DataGridView1.Columns.Add(emailColumn)

        ' Poner las demás columnas en modo de solo lectura
        For Each column As DataGridViewColumn In DataGridView1.Columns
            If column.Name <> "ESTADO" AndAlso column.Name <> "FECHA_INICIO" AndAlso column.Name <> "FECHA_FIN" AndAlso column.Name <> "EMAIL" AndAlso column.Name <> "IDENTIFICATION" Then
                column.ReadOnly = True
            End If
        Next

        AddHandler DataGridView1.CurrentCellDirtyStateChanged, AddressOf DataGridView1_CurrentCellDirtyStateChanged
        AddHandler DataGridView1.CellValueChanged, AddressOf DataGridView1_CellValueChanged
        AddHandler DataGridView1.DataError, AddressOf DataGridView1_DataError
    End Sub

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs)
        If DataGridView1.IsCurrentCellDirty Then
            ' Esto causa que inicie el proceso de cambio de celda en estado
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        ' Revisar por cambios
        If DataGridView1.Columns.Contains("ESTADO") AndAlso e.ColumnIndex = DataGridView1.Columns("ESTADO").Index Then
            ' Confirmar cambios
            Dim result As DialogResult = MessageBox.Show("¿Quiere realizar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Verificar si el estado es "Aprobado"
                Dim estado As String = DataGridView1.Rows(e.RowIndex).Cells("ESTADO").Value.ToString()

                If estado = "Aprobado" Then
                    ' Obtener IDENTIFICATION y DIAS_SOLICITADOS
                    Dim identificacion As String = DataGridView1.Rows(e.RowIndex).Cells("IDENTIFICATION").Value.ToString()
                    Dim diasSolicitados As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("DIAS_SOLICITADOS").Value)



                    ' Consultar la tabla USERS para verificar VACACIONES_DISPONIBLES
                    Dim sqlQuery As String = $"SELECT VACACIONES_DISPONIBLES FROM USERS WHERE IDENTIFICACION = '{identificacion}'"
                    conexion.consultar(sqlQuery, "USERS")

                    ' Verificar si hay resultados
                    If conexion.ds.Tables("USERS").Rows.Count > 0 Then
                        Dim vacacionesDisponibles As Integer = Convert.ToInt32(conexion.ds.Tables("USERS").Rows(0)("VACACIONES_DISPONIBLES"))

                        ' Comparar DIAS_SOLICITADOS con VACACIONES_DISPONIBLES
                        If diasSolicitados > vacacionesDisponibles Then
                            MessageBox.Show("No tiene suficientes dias de vacaciones disponibles")
                            ' Cancel the changes
                            RemoveHandler DataGridView1.CellValueChanged, AddressOf DataGridView1_CellValueChanged
                            DataGridView1.CancelEdit()
                            Me.SOLICITUDESTableAdapter.Fill(Me.Progra3DataSet.SOLICITUDES) ' Reload the data to revert changes
                            AddHandler DataGridView1.CellValueChanged, AddressOf DataGridView1_CellValueChanged
                            Return ' Exit the method to prevent further processing
                        Else
                            ' Actualizar la tabla USERS restando DIAS_SOLICITADOS de VACACIONES_DISPONIBLES
                            Dim updateQuery As String = $"UPDATE USERS SET VACACIONES_DISPONIBLES = VACACIONES_DISPONIBLES - {diasSolicitados} WHERE IDENTIFICACION = '{identificacion}'"
                            conexion.inserta_datos(updateQuery)

                            MessageBox.Show("Si tiene suficientes dias, se han reducido los dias.")
                        End If
                    Else
                        MessageBox.Show("No se encontró el usuario en la tabla USERS.")
                    End If
                End If

                ' Si el estado es aprobado o no, sigue con el proceso de actualización de la base de datos
                Try
                    DataGridView1.EndEdit()

                    Me.Validate()
                    Me.BindingContext(Me.Progra3DataSet.SOLICITUDES).EndCurrentEdit()

                    UpdateDatabase()
                    MessageBox.Show("Actualización completa.")

                    ' Obtener el email y estado de la fila actual
                    Dim email As String = DataGridView1.Rows(e.RowIndex).Cells("EMAIL").Value.ToString()
                    Dim fechaInicio As DateTime = Convert.ToDateTime(DataGridView1.Rows(e.RowIndex).Cells("FECHA_INICIO").Value)
                    Dim fechaFin As DateTime = Convert.ToDateTime(DataGridView1.Rows(e.RowIndex).Cells("FECHA_FIN").Value)

                    ' Crear el mensaje de correo basado en el estado
                    Dim subject As String = "Estado de Solicitud de Vacaciones"
                    Dim body As String
                    If estado = "Aprobado" Then
                        body = $"Sus vacaciones han sido aprobadas del {fechaInicio.ToString("dd/MM/yyyy")} al {fechaFin.ToString("dd/MM/yyyy")}."
                    ElseIf estado = "Denegado" Then
                        body = $"Sus vacaciones del {fechaInicio.ToString("dd/MM/yyyy")} al {fechaFin.ToString("dd/MM/yyyy")} han sido denegadas."
                    Else
                        body = $"El estado de su solicitud ha cambiado."
                    End If

                    ' Enviar el correo
                    emailSender.SendEmail(email, subject, body)

                Catch ex As Exception
                    MessageBox.Show("Sucedió un error: " & ex.Message)
                End Try
            Else
                ' Revertir cambios si se confirma "no"
                RemoveHandler DataGridView1.CellValueChanged, AddressOf DataGridView1_CellValueChanged
                DataGridView1.CancelEdit()
                Me.SOLICITUDESTableAdapter.Fill(Me.Progra3DataSet.SOLICITUDES)
                AddHandler DataGridView1.CellValueChanged, AddressOf DataGridView1_CellValueChanged
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
        ' Salir de la pantalla solicitudes y volver a form1
        Me.mainForm.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub lblsolicitudes_Click(sender As Object, e As EventArgs) Handles lblsolicitudes.Click

    End Sub

    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs) Handles btnExportCSV.Click
        Try
            ' Configuracion del dialogo
            Using sfd As New SaveFileDialog()
                sfd.Filter = "CSV Files (*.csv)|*.csv"
                sfd.FileName = "Solicitudes.csv"
                sfd.Title = "Guardar como CSV"
                If sfd.ShowDialog() = DialogResult.OK Then
                    ' Crear el csv
                    Using writer As New StreamWriter(sfd.FileName)
                        ' creaar el header del csv
                        Dim header As String = String.Join(",", DataGridView1.Columns.Cast(Of DataGridViewColumn).Select(Function(col) col.HeaderText))
                        writer.WriteLine(header)

                        ' agregar la data al csv
                        For Each row As DataGridViewRow In DataGridView1.Rows
                            If Not row.IsNewRow Then
                                Dim line As String = String.Join(",", row.Cells.Cast(Of DataGridViewCell).Select(Function(cell) If(cell.Value IsNot Nothing, cell.Value.ToString(), String.Empty)))
                                writer.WriteLine(line)
                            End If
                        Next
                    End Using

                    MessageBox.Show("Se ha exportado la informacion a CSV", "Export Completo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("A ocurrido un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
