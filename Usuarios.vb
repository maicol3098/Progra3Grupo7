Imports PARCIAL1.CustomControls
Imports System.Data.SqlClient
Imports System.IO

Public Class Usuarios

    Private emailSender As EmailSender
    Private mainForm As Form1
    Private vusuario As String
    Private connectionString As String = "Data Source=MICHAELSEGU76AC\SQLEXPRESS;Initial Catalog=Progra3;Integrated Security=True"
    Private conexion As New Conexion()

    Public Sub New(vusuario As String, mainForm As Form1)
        ' Inicializar forma para que pueda obtener el valor de usuario y isadmin
        InitializeComponent()
        Me.vusuario = vusuario
        Me.mainForm = mainForm
        Me.emailSender = New EmailSender() ' Initialize the email sender object
    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llama al método para actualizar automáticamente los días de vacaciones
        ActualizarVacacionesAutomaticamente()

        ' Load data into the table adapter
        Me.USERSTableAdapter.Fill(Me.Progra3DataSet1.USERS)

        ' Set up the ComboBox column for isAdmin
        Dim isAdminComboBox As New DataGridViewComboBoxColumn()
        isAdminComboBox.Name = "isAdmin"
        isAdminComboBox.HeaderText = "isAdmin"
        isAdminComboBox.DataPropertyName = "isAdmin"
        isAdminComboBox.ValueMember = "Key"
        isAdminComboBox.DisplayMember = "Value"

        ' configurar el combo box
        Dim isAdminValues As New Dictionary(Of Integer, String) From {
            {0, "0"},
            {1, "1"}
        }
        isAdminComboBox.DataSource = New BindingSource(isAdminValues, Nothing)

        ' configurar otras columnas
        Dim usuarioColumn As New DataGridViewTextBoxColumn()
        usuarioColumn.Name = "USUARIO"
        usuarioColumn.HeaderText = "USUARIO"
        usuarioColumn.DataPropertyName = "USUARIO"

        Dim identificacionColumn As New DataGridViewTextBoxColumn()
        identificacionColumn.Name = "IDENTIFICACION"
        identificacionColumn.HeaderText = "IDENTIFICACION"
        identificacionColumn.DataPropertyName = "IDENTIFICACION"
        identificacionColumn.ReadOnly = True  ' Primary key

        Dim nombreColumn As New DataGridViewTextBoxColumn()
        nombreColumn.Name = "NOMBRE"
        nombreColumn.HeaderText = "NOMBRE"
        nombreColumn.DataPropertyName = "NOMBRE"

        Dim apellidoColumn As New DataGridViewTextBoxColumn()
        apellidoColumn.Name = "APELLIDO"
        apellidoColumn.HeaderText = "APELLIDO"
        apellidoColumn.DataPropertyName = "APELLIDO"

        Dim vacacionesColumn As New DataGridViewTextBoxColumn()
        vacacionesColumn.Name = "VACACIONES_DISPONIBLES"
        vacacionesColumn.HeaderText = "VACACIONES_DISPONIBLES"
        vacacionesColumn.DataPropertyName = "VACACIONES_DISPONIBLES"

        ' DateTimePicker columna para FECHA_INICIO_LABORAL
        Dim fechaInicioLaboralColumn As New DataGridViewDateTimePickerColumn()
        fechaInicioLaboralColumn.Name = "FECHA_INICIO_LABORAL"
        fechaInicioLaboralColumn.HeaderText = "FECHA_INICIO_LABORAL"
        fechaInicioLaboralColumn.DataPropertyName = "FECHA_INICIO_LABORAL"

        ' agregar vacaciones a la columna
        Dim vacacionesActualizadasColumn As New DataGridViewTextBoxColumn()
        vacacionesActualizadasColumn.Name = "VACACIONES_ACTUALIZADAS"
        vacacionesActualizadasColumn.HeaderText = "Vacaciones Actualizadas"
        vacacionesActualizadasColumn.DataPropertyName = "VacacionesActualizadas"

        ' limpiar las colunas
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add(usuarioColumn)
        DataGridView1.Columns.Add(identificacionColumn)
        DataGridView1.Columns.Add(nombreColumn)
        DataGridView1.Columns.Add(apellidoColumn)
        DataGridView1.Columns.Add(vacacionesColumn)
        DataGridView1.Columns.Add(fechaInicioLaboralColumn)
        DataGridView1.Columns.Add(vacacionesActualizadasColumn) ' agregar nueva columna al datagrid
        DataGridView1.Columns.Add(isAdminComboBox)

        ' poner propiedades en read only
        For Each column As DataGridViewColumn In DataGridView1.Columns
            If column.Name <> "USUARIO" AndAlso column.Name <> "NOMBRE" AndAlso column.Name <> "APELLIDO" AndAlso column.Name <> "VACACIONES_DISPONIBLES" AndAlso column.Name <> "FECHA_INICIO_LABORAL" AndAlso column.Name <> "VACACIONES_ACTUALIZADAS" AndAlso column.Name <> "isAdmin" Then
                column.ReadOnly = True
            End If
        Next

        AddHandler DataGridView1.CellFormatting, AddressOf DataGridView1_CellFormatting
        AddHandler DataGridView1.CurrentCellDirtyStateChanged, AddressOf DataGridView1_CurrentCellDirtyStateChanged
        AddHandler DataGridView1.CellValueChanged, AddressOf DataGridView1_CellValueChanged
        AddHandler DataGridView1.DataError, AddressOf DataGridView1_DataError
    End Sub

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs)
        If DataGridView1.IsCurrentCellDirty Then
            ' esto causa que se envie el cambio
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        ' maneja cambios de celdas
        Dim currentDate As Date = DateTime.Now


        ' revisar si las celdas modificadas requieren actualizar VacacionesActualizadas
        If DataGridView1.Columns(e.ColumnIndex).Name = "VACACIONES_DISPONIBLES" OrElse DataGridView1.Columns(e.ColumnIndex).Name = "FECHA_INICIO_LABORAL" Then
            ' Set VacacionesActualizadas to the current date
            DataGridView1.Rows(e.RowIndex).Cells("VACACIONES_ACTUALIZADAS").Value = currentDate
        End If

        ' Validad la columna isAdmin
        If DataGridView1.Columns(e.ColumnIndex).Name = "isAdmin" Then
            Dim cellValue = DataGridView1.Rows(e.RowIndex).Cells("isAdmin").Value
            If cellValue Is Nothing OrElse Not {"0", "1"}.Contains(cellValue.ToString()) Then
                MessageBox.Show("Valor de isAdmin debe ser 0 o 1.")
                DataGridView1.CancelEdit()
            End If
        End If
    End Sub


    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        Try
            If DataGridView1.Columns(e.ColumnIndex).Name = "FECHA_INICIO_LABORAL" AndAlso e.Value IsNot Nothing AndAlso IsDate(e.Value) Then
                e.Value = Convert.ToDateTime(e.Value).ToString("dd/MM/yyyy")
                e.FormattingApplied = True
            End If
        Catch ex As Exception
            e.FormattingApplied = False
        End Try
    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        MessageBox.Show($"Error con el valor de la celda en fila {e.RowIndex + 1}, columna '{DataGridView1.Columns(e.ColumnIndex).Name}': {e.Exception.Message}")
        e.ThrowException = False
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        ' regregar al form1
        If Me.mainForm IsNot Nothing Then
            Me.mainForm.UpdateFormData() ' Call the method to refresh data
            Me.mainForm.Show()
        End If
        Me.Close()
    End Sub


    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Application.Exit()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        ' Confirmar cambios antes de guardar
        Dim result As DialogResult = MessageBox.Show("¿Quiere guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                DataGridView1.EndEdit()
                Me.Validate()
                Me.BindingContext(Me.Progra3DataSet1.USERS).EndCurrentEdit()

                UpdateDatabase()
                MessageBox.Show("Cambios guardados con éxito.")
            Catch ex As Exception
                MessageBox.Show("Sucedió un error al guardar: " & ex.Message)
            End Try
        Else
            ' revertir cambios si dice "no"
            Me.USERSTableAdapter.Fill(Me.Progra3DataSet1.USERS)
        End If
    End Sub

    Private Sub UpdateDatabase()
        Dim updateCommand As New SqlCommand("UPDATE USERS SET USUARIO = @USUARIO, isAdmin = @isAdmin, NOMBRE = @NOMBRE, APELLIDO = @APELLIDO, VACACIONES_DISPONIBLES = @VACACIONES_DISPONIBLES, FECHA_INICIO_LABORAL = @FECHA_INICIO_LABORAL, VacacionesActualizadas = @VacacionesActualizadas WHERE IDENTIFICACION = @IDENTIFICACION", conexion.conexion)
        updateCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 50, "USUARIO")
        updateCommand.Parameters.Add("@isAdmin", SqlDbType.Int, 4, "isAdmin")
        updateCommand.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 50, "NOMBRE")
        updateCommand.Parameters.Add("@APELLIDO", SqlDbType.VarChar, 50, "APELLIDO")
        updateCommand.Parameters.Add("@VACACIONES_DISPONIBLES", SqlDbType.Int, 4, "VACACIONES_DISPONIBLES")
        updateCommand.Parameters.Add("@FECHA_INICIO_LABORAL", SqlDbType.Date, 4, "FECHA_INICIO_LABORAL")
        updateCommand.Parameters.Add("@VacacionesActualizadas", SqlDbType.Date, 4, "VacacionesActualizadas")
        updateCommand.Parameters.Add("@IDENTIFICACION", SqlDbType.VarChar, 50, "IDENTIFICACION").SourceVersion = DataRowVersion.Original

        conexion.conexion.Open()
        For Each row As DataRow In Me.Progra3DataSet1.USERS.GetChanges(DataRowState.Modified).Rows
            updateCommand.Parameters("@USUARIO").Value = row("USUARIO")
            updateCommand.Parameters("@isAdmin").Value = row("isAdmin")
            updateCommand.Parameters("@NOMBRE").Value = row("NOMBRE")
            updateCommand.Parameters("@APELLIDO").Value = row("APELLIDO")
            updateCommand.Parameters("@VACACIONES_DISPONIBLES").Value = row("VACACIONES_DISPONIBLES")
            updateCommand.Parameters("@FECHA_INICIO_LABORAL").Value = row("FECHA_INICIO_LABORAL")
            updateCommand.Parameters("@VacacionesActualizadas").Value = row("VacacionesActualizadas")
            updateCommand.Parameters("@IDENTIFICACION").Value = row("IDENTIFICACION")
            updateCommand.ExecuteNonQuery()
        Next
        conexion.conexion.Close()

        Me.Progra3DataSet1.USERS.AcceptChanges()
    End Sub

    Private Sub ActualizarVacacionesAutomaticamente()
        Dim conexion As SqlConnection = Nothing
        Dim command As SqlCommand = Nothing
        Dim reader As SqlDataReader = Nothing

        Try
            conexion = New SqlConnection(connectionString)
            conexion.Open()

            ' Obtener la lista de usuarios, sus días de vacaciones disponibles, la fecha de inicio laboral y la última actualización
            command = New SqlCommand("SELECT IDENTIFICACION, VACACIONES_DISPONIBLES, FECHA_INICIO_LABORAL, VacacionesActualizadas, USUARIO FROM USERS", conexion)
            reader = command.ExecuteReader()

            ' Crear una lista para almacenar las actualizaciones necesarias
            Dim updates As New List(Of (UsuarioID As Integer, VacacionesDisponibles As Integer, FechaActualizacion As Date, Email As String))
            Dim needsAttention As Boolean = False

            ' Leer todos los registros y determinar si se necesita una actualización
            While reader.Read()
                Dim usuarioID As Integer = Convert.ToInt32(reader("IDENTIFICACION"))
                Dim vacacionesDisponibles As Integer
                Dim fechaInicioLaboral As Date

                ' Revisar si hay errores DBNull y manejarlos
                If IsDBNull(reader("VACACIONES_DISPONIBLES")) Or IsDBNull(reader("FECHA_INICIO_LABORAL")) Then
                    needsAttention = True
                    Continue While ' saltarse este record y pasar al siguiente
                Else
                    vacacionesDisponibles = Convert.ToInt32(reader("VACACIONES_DISPONIBLES"))
                    fechaInicioLaboral = Convert.ToDateTime(reader("FECHA_INICIO_LABORAL"))
                End If

                Dim vacacionesActualizadas As Date = If(IsDBNull(reader("VacacionesActualizadas")), Date.MinValue, Convert.ToDateTime(reader("VacacionesActualizadas")))
                Dim email As String = reader("USUARIO").ToString()

                ' Calcular el numero de meses que el usuario ha estado con la compania
                Dim monthsWithCompany As Integer = DateDiff(DateInterval.Month, fechaInicioLaboral, DateTime.Now)

                ' saltarse al usuario si no ha estado con la compania mas de un mes
                If monthsWithCompany < 1 Then
                    Continue While
                End If

                ' Obtener el día y mes actuales
                Dim currentDay As Integer = DateTime.Now.Day
                Dim currentMonth As Integer = DateTime.Now.Month

                ' Obtener el día y mes de FECHA_INICIO_LABORAL
                Dim inicioLaboralDay As Integer = fechaInicioLaboral.Day
                Dim inicioLaboralMonth As Integer = fechaInicioLaboral.Month

                ' Verificar si el mes actual no ha sido procesado y si el día y mes actuales son mayores o iguales a los de FECHA_INICIO_LABORAL
                If (vacacionesActualizadas.Month <> DateTime.Now.Month Or vacacionesActualizadas.Year <> DateTime.Now.Year) AndAlso
                   (currentMonth > inicioLaboralMonth Or (currentMonth = inicioLaboralMonth And currentDay >= inicioLaboralDay)) Then

                    ' Incrementar días de vacaciones disponibles y añadir a la lista de actualizaciones
                    vacacionesDisponibles += 1
                    updates.Add((usuarioID, vacacionesDisponibles, DateTime.Now, email))
                End If
            End While

            reader.Close() ' Cerrar el lector antes de ejecutar cualquier comando adicional

            ' Mostrar mensaje si se encontró algún usuario que necesita atención
            If needsAttention Then
                MessageBox.Show("Hay usuarios que necesitan atención", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            ' Ejecutar las actualizaciones necesarias y enviar correos electrónicos
            For Each updateItem In updates
                ' Actualizar la base de datos
                Dim updateCommand As New SqlCommand("UPDATE USERS SET VACACIONES_DISPONIBLES = @VacacionesDisponibles, VacacionesActualizadas = @VacacionesActualizadas WHERE IDENTIFICACION = @UsuarioID", conexion)
                updateCommand.Parameters.AddWithValue("@VacacionesDisponibles", updateItem.VacacionesDisponibles)
                updateCommand.Parameters.AddWithValue("@VacacionesActualizadas", updateItem.FechaActualizacion)
                updateCommand.Parameters.AddWithValue("@UsuarioID", updateItem.UsuarioID)
                updateCommand.ExecuteNonQuery()

                ' Enviar correo electrónico al usuario
                Dim subject As String = "Actualización de Días de Vacaciones"
                Dim body As String = $"Estimado usuario, ahora tienes {updateItem.VacacionesDisponibles} días de vacaciones disponibles. Esta actualización es válida a partir de {updateItem.FechaActualizacion.ToString("dd/MM/yyyy")}."
                emailSender.SendEmail(updateItem.Email, subject, body)
            Next

        Catch ex As Exception
            MessageBox.Show("Error al actualizar las vacaciones: " & ex.Message)
        Finally
            If reader IsNot Nothing AndAlso Not reader.IsClosed Then reader.Close()
            If conexion IsNot Nothing AndAlso conexion.State <> ConnectionState.Closed Then conexion.Close()
        End Try
    End Sub

    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs) Handles btnExportCSV.Click
        ' Configuracion del dialogo
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv"
            saveFileDialog.Title = "Save Users Data As CSV"
            saveFileDialog.FileName = "usuarios_export.csv"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' obtener el path del archivo
                Dim filePath As String = saveFileDialog.FileName

                Try

                    Using writer As New StreamWriter(filePath)

                        ' crear headers del csv
                        For Each column As DataGridViewColumn In DataGridView1.Columns
                            writer.Write(column.HeaderText & ",")
                        Next
                        writer.WriteLine()

                        ' agregar data al csv
                        For Each row As DataGridViewRow In DataGridView1.Rows
                            If Not row.IsNewRow Then
                                For Each cell As DataGridViewCell In row.Cells
                                    writer.Write(cell.Value?.ToString() & ",")
                                Next
                                writer.WriteLine()
                            End If
                        Next
                    End Using

                    MessageBox.Show("Se ha exportado la informacion a CSV", "Export Completo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Error exportando los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

End Class
