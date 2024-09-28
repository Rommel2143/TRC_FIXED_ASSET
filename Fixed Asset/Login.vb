Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbarcode.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub txtbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtbarcode.TextChanged

    End Sub
    Private Sub txtbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try

                Dim idwithA As String = "A" & txtbarcode.Text & "A"
                Dim idwithoutA As String = txtbarcode.Text.TrimStart("A"c).TrimEnd("A"c)
                Dim idwithoutasmall As String = txtbarcode.Text.TrimStart("a"c).TrimEnd("a"c)


                con.Close()
                con.Open()

                Dim cmd As New MySqlCommand("SELECT FULLNAME FROM tblscanoperator WHERE IDNUMBER = @idwithoutA OR IDNUMBER = @idwithA OR IDNUMBER = @idwithoutasmall", con)
                cmd.Parameters.AddWithValue("@idwithoutA", idwithoutA)
                cmd.Parameters.AddWithValue("@idwithA", idwithA)
                cmd.Parameters.AddWithValue("@idwithoutasmall", idwithoutasmall)


                Dim dr As MySqlDataReader = cmd.ExecuteReader()


                If dr.Read() Then

                    Dim fullname As String = dr("FULLNAME").ToString()

                    display_form(Form1)
                    Form1.SetFullname(fullname)

                    Me.Hide()


                    labelerror.Visible = False
                Else

                    noid()
                End If

                dr.Close()
            Catch ex As Exception

                MessageBox.Show(ex.Message)
            Finally

                con.Close()
                txtbarcode.Clear()
            End Try
        End If
    End Sub

    Private Sub noid()
        Try
            labelerror.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class