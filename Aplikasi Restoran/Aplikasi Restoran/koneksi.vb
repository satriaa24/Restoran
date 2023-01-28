Imports System.Data.SqlClient
Module koneksi
    Public CONN As SqlConnection
    Public CMD As SqlCommand
    Public DS As DataSet
    Public DA As SqlDataAdapter
    Public RD As SqlDataReader
    Public str As String
    Public Sub koneksi()
        str = "data source=DESKTOP-8TK8LD1\SQLEXPRESS01;initial catalog=db_restoran;integrated security=SSPI;Persist Security Info=True;MultipleActiveResultSets=True"
        CONN = New SqlConnection(str)
        Try
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function sqltable(ByVal source As String) As DataTable
        Try
            Dim adp As New SqlClient.SqlDataAdapter(source, CONN)
            Dim dt As New DataTable
            adp.Fill(dt)
            sqltable = dt
        Catch ex As Exception
        End Try

    End Function
End Module