Imports MySql.Data.MySqlClient
Public Class addfatype


    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        Try
            OpenConnection()
            Dim destination As String = cb_status.Text

            ' Check if the record already exists based on destination
            Dim checkCmd As New MySqlCommand()
            If destination = "Section" Then
                checkCmd.CommandText = "SELECT COUNT(*) FROM tblcn WHERE selection = @selection"
            Else
                checkCmd.CommandText = "SELECT COUNT(*) FROM cbmasterlist WHERE selection = @selection"
            End If
            checkCmd.Connection = con
            checkCmd.Parameters.AddWithValue("@selection", txtmasterlist.Text)

            Dim recordExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If recordExists > 0 Then
                MessageBox.Show("Record already registered!")
            Else
                ' Record does not exist, proceed to add it
                cmd.Connection = con
                cmd.Parameters.Clear() ' Clear previous parameters
                cmd.Parameters.AddWithValue("@selection", txtmasterlist.Text)

                If destination = "Section" Then
                    cmd.CommandText = "INSERT INTO tblcn(selection) VALUES (@selection)"
                Else
                    cmd.CommandText = "INSERT INTO cbmasterlist(selection, destination) VALUES (@selection, @destination)"
                    cmd.Parameters.AddWithValue("@destination", destination)
                End If

                cmd.ExecuteNonQuery()
                MessageBox.Show("Record added successfully!")
                ' Optional: Clear the input field after adding
                txtmasterlist.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show("Error adding record: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub



End Class