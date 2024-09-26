Imports MySql.Data.MySqlClient

Module Module1
    Public Function connection() As MySqlConnection
        Return New MySqlConnection("server=localhost;port=3306;username=root;password=;database=trcdatabase")
    End Function

    Public con As MySqlConnection = connection()
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Sub OpenConnection()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Error opening connection: " & ex.Message)
        End Try
    End Sub

    Public Sub CloseConnection()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error closing connection: " & ex.Message)
        End Try
    End Sub
End Module