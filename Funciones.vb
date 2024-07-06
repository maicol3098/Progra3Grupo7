Module Funciones

    Public ntipoid, f, k As Integer
    Public resultado As String
    Public Sub set_sololetras(ByRef ee As System.Windows.Forms.KeyPressEventArgs)
        Dim cadena As String
        cadena = " ABCDEFGHIJKLMNOPQRSTUVWXYZ"

        If InStr(cadena, ee.KeyChar) Then


            ee.Handled = False
            Else
                ee.Handled = True
        End If
    End Sub




End Module
