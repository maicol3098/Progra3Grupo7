﻿Imports System.Data.SqlClient

Public Class Solicitudes

    Private emailSender As EmailSender
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
        emailSender = New EmailSender()

        ' Cargar datos al cargar el formulario
        Me.SOLICITUDESTableAdapter.Fill(Me.Progra3DataSet.SOLICITUDES)

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
            If column.Name <> "ESTADO" AndAlso column.Name <> "FECHA_INICIO" AndAlso column.Name <> "FECHA_FIN" AndAlso column.Name <> "EMAIL" Then
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
End Class
