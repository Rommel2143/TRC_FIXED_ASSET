Imports MySql.Data.MySqlClient
Public Class FIXED_ASSET_GENERATE
    Private Sub FIXED_ASSET_GENERATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_no_Leave(sender As Object, e As EventArgs) Handles txt_no.Leave
        If Not String.IsNullOrWhiteSpace(txt_no.Text) Then
            LoadDataByNo(txt_no.Text)
        End If
    End Sub

    Private Sub LoadDataByNo(no As String)
        Try
            OpenConnection()
            Dim query As String = "SELECT FANO, FATYPE, SECTION, ITEMDES, DATE, PONO, SINO, AMOUNT, SUPPLIER FROM tblfixedasset WHERE NO = @no"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@no", no)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txt_fano.Text = reader("FANO").ToString()
                txt_fatype.Text = reader("FATYPE").ToString()
                txt_section.Text = reader("SECTION").ToString()
                txt_itemdes.Text = reader("ITEMDES").ToString()
                dt_date.Value = Convert.ToDateTime(reader("DATE"))
                txt_pono.Text = reader("PONO").ToString()
                txt_sino.Text = reader("SINO").ToString()
                txt_amount.Text = reader("AMOUNT").ToString()
                txt_supplier.Text = reader("SUPPLIER").ToString()

            Else
                MessageBox.Show("No record found for this NO.")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub


End Class