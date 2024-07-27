Imports System.Net.Mail

Public Class EmailSender
    Private smtpServer As SmtpClient
    Private fromAddress As String

    ' Constructor para inicializar el cliente con configuracion
    Public Sub New()
        smtpServer = New SmtpClient("localhost")
        smtpServer.Port = 587
        smtpServer.Credentials = New Net.NetworkCredential("notificaciones@timeoffapp.com", "welcome01")
        smtpServer.EnableSsl = False
        fromAddress = "notificaciones@timeoffapp.com"
    End Sub

    ' Metodo para enviar los mensajes
    Public Sub SendEmail(toAddress As String, subject As String, body As String)
        Dim mail As New MailMessage()
        mail.From = New MailAddress(fromAddress)
        mail.To.Add(toAddress)
        mail.Subject = subject
        mail.Body = body

        Try
            smtpServer.Send(mail)
            MessageBox.Show("Mensaje enviado.")
        Catch ex As Exception
            MessageBox.Show("Error enviando el mensaje: " & ex.Message)
        End Try
    End Sub
End Class
