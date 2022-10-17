Imports System.Data.Odbc
Module modbellen
    Public con As Odbc.OdbcConnection
    Public Sub connectDB()

        Try
            con = New Odbc.OdbcConnection("DSN=DSNbellen")
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub




End Module
