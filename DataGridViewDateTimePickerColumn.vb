Namespace CustomControls

    ' clase de datagrid para guardar el DateTimePicker
    Public Class DataGridViewDateTimePickerColumn
        Inherits DataGridViewColumn

        Public Sub New()
            MyBase.New(New DataGridViewDateTimePickerCell())
        End Sub

        Public Overrides Property CellTemplate() As DataGridViewCell
            Get
                Return MyBase.CellTemplate
            End Get
            Set(value As DataGridViewCell)
                ' asegurarse que se usa el tipo DataGridViewDateTimePickerCell.
                If (value IsNot Nothing) AndAlso Not TypeOf (value) Is DataGridViewDateTimePickerCell Then
                    Throw New InvalidCastException("Must be a DataGridViewDateTimePickerCell")
                End If
                MyBase.CellTemplate = value
            End Set
        End Property
    End Class

    ' clase DataGridViewCell para guardar el DateTimePicker
    Public Class DataGridViewDateTimePickerCell
        Inherits DataGridViewTextBoxCell

        Public Sub New()
            ' usar formato de fecha corta
            Me.Style.Format = "d"
        End Sub

        Public Overrides Sub InitializeEditingControl(rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As DataGridViewCellStyle)
            ' configurar el valor actual en la celda
            MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

            Dim ctl As DateTimePickerEditingControl = CType(DataGridView.EditingControl, DateTimePickerEditingControl)
            If Me.Value IsNot Nothing AndAlso Me.Value IsNot DBNull.Value Then
                ctl.Value = CType(Me.Value, DateTime)
            Else
                ctl.Value = DateTime.Now
            End If
        End Sub

        Public Overrides ReadOnly Property EditType() As Type
            Get
                ' obtener el tipo de control de edicion
                Return GetType(DateTimePickerEditingControl)
            End Get
        End Property

        Public Overrides ReadOnly Property ValueType() As Type
            Get
                ' obtener el valor de fecha 
                Return GetType(DateTime)
            End Get
        End Property

        Public Overrides ReadOnly Property DefaultNewRowValue() As Object
            Get
                ' poner valor de fecha actualn en celdas nuevas
                Return DateTime.Now
            End Get
        End Property
    End Class

    ' control de edicion
    Public Class DateTimePickerEditingControl
        Inherits DateTimePicker
        Implements IDataGridViewEditingControl

        Private dataGridViewControl As DataGridView
        Private valueIsChanged As Boolean = False
        Private rowIndexNum As Integer

        Public Sub New()
            Me.Format = DateTimePickerFormat.Short
        End Sub

        Public Property EditingControlFormattedValue() As Object Implements IDataGridViewEditingControl.EditingControlFormattedValue
            Get
                Return Me.Value.ToShortDateString()
            End Get
            Set(value As Object)
                If TypeOf value Is String Then
                    Try
                        Me.Value = DateTime.Parse(CStr(value))
                    Catch
                        Me.Value = DateTime.Now
                    End Try
                End If
            End Set
        End Property

        Public Sub ApplyCellStyleToEditingControl(dataGridViewCellStyle As DataGridViewCellStyle) Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl
            Me.Font = dataGridViewCellStyle.Font
            Me.CalendarForeColor = dataGridViewCellStyle.ForeColor
            Me.CalendarMonthBackground = dataGridViewCellStyle.BackColor
        End Sub

        Public Function GetEditingControlFormattedValue(context As DataGridViewDataErrorContexts) As Object Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
            Return Me.Value.ToShortDateString()
        End Function

        Public Property EditingControlRowIndex() As Integer Implements IDataGridViewEditingControl.EditingControlRowIndex
            Get
                Return rowIndexNum
            End Get
            Set(value As Integer)
                rowIndexNum = value
            End Set
        End Property

        Public Function EditingControlWantsInputKey(key As Keys, dataGridViewWantsInputKey As Boolean) As Boolean Implements IDataGridViewEditingControl.EditingControlWantsInputKey

            Select Case key And Keys.KeyCode
                Case Keys.Left, Keys.Up, Keys.Down, Keys.Right, Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp
                    Return True
                Case Else
                    Return Not dataGridViewWantsInputKey
            End Select
        End Function

        Public Sub PrepareEditingControlForEdit(selectAll As Boolean) Implements IDataGridViewEditingControl.PrepareEditingControlForEdit

        End Sub

        Public Property RepositionEditingControlOnValueChange() As Boolean Implements IDataGridViewEditingControl.RepositionEditingControlOnValueChange
            Get
                Return False
            End Get
            Set(value As Boolean)

            End Set
        End Property

        Public Property EditingControlDataGridView() As DataGridView Implements IDataGridViewEditingControl.EditingControlDataGridView
            Get
                Return dataGridViewControl
            End Get
            Set(value As DataGridView)
                dataGridViewControl = value
            End Set
        End Property

        Public Property EditingControlValueChanged() As Boolean Implements IDataGridViewEditingControl.EditingControlValueChanged
            Get
                Return valueIsChanged
            End Get
            Set(value As Boolean)
                valueIsChanged = value
            End Set
        End Property

        Public ReadOnly Property EditingPanelCursor() As Cursor Implements IDataGridViewEditingControl.EditingPanelCursor
            Get
                Return MyBase.Cursor
            End Get
        End Property

        Protected Overrides Sub OnValueChanged(eventargs As EventArgs)
            ' notificar que los valores cambiaron
            valueIsChanged = True
            Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
            MyBase.OnValueChanged(eventargs)
        End Sub
    End Class

End Namespace
