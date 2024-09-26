Imports MySql.Data.MySqlClient

Public Class adduser
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        Try
            OpenConnection()

            ' Check if the record already exists
            Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM `tblscanoperator` WHERE `IDNUMBER` = @idnumber", con)
                checkCmd.Parameters.AddWithValue("@idnumber", txtidnumber.Text)

                Dim recordExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If recordExists > 0 Then
                    MessageBox.Show("Record already registered!")
                Else
                    ' Record does not exist, proceed to add it
                    Using cmd As New MySqlCommand("INSERT INTO `tblscanoperator`(`IDNUMBER`, `FULLNAME`, `STATUS`) VALUES (@idnumber, @fullname, 'user')", con)
                        cmd.Parameters.AddWithValue("@idnumber", txtidnumber.Text)
                        cmd.Parameters.AddWithValue("@fullname", txtfullname.Text)

                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Record added successfully!")
                    End Using
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error adding record: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub
End Class
