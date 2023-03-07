Imports MySql.Data.MySqlClient

Public Class FormTrashSolderPaste
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            conn.Open()
            str = "SELECT * FROM prodsys2_solder_paste_mgt_line_tbl WHERE txn_id='" & TextBox1.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            Try
                If rd.HasRows Then
                    rd.Close()
                    conn.Close()

                    conn.Open()
                    For Baris As Integer = 0 To FormSolderPasteMGT.DataGridView4.Rows.Count - 1
                        Dim sql As String
                        rd.Close()
                        sql = "UPDATE prodsys2_solder_paste_mgt_line_tbl SET run_time = @run_time, end_time = @end_time, status = @status WHERE txn_id = @txn_id"
                        cmd.Connection = conn
                        cmd.CommandText = sql
                        cmd.Parameters.AddWithValue("@txn_id", TextBox1.Text)
                        cmd.Parameters.AddWithValue("@run_time", FormSolderPasteMGT.DataGridView4.Rows(Baris).Cells(6).Value)
                        cmd.Parameters.AddWithValue("@end_time", System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))
                        cmd.Parameters.AddWithValue("@status", "EMPTY")
                        Dim r As Integer
                        Try
                            r = cmd.ExecuteNonQuery()
                            cmd.Parameters.Clear()
                        Catch ex As Exception
                            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            rd.Close()
                            conn.Close()
                            conn.Dispose()
                        End Try
                    Next
                    conn.Close()
                Else
                    MsgBox("SOLDER PASTE TIDAK ADA DI LINE", vbInformation)
                    TextBox1.Clear()
                    TextBox1.Select()
                    rd.Close()
                    conn.Close()
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                rd.Close()
                conn.Close()
                conn.Dispose()
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conn.Open()
        str = "SELECT * FROM prodsys2_solder_paste_mgt_line_tbl WHERE txn_id='" & TextBox1.Text & "'"
        cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        Try
            If rd.HasRows Then
                rd.Close()
                conn.Close()

                conn.Open()
                For Baris As Integer = 0 To FormSolderPasteMGT.DataGridView4.Rows.Count - 1
                    Dim sql As String
                    rd.Close()
                    sql = "UPDATE prodsys2_solder_paste_mgt_line_tbl SET run_time = @run_time, end_time = @end_time, status = @status WHERE txn_id = @txn_id"
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    cmd.Parameters.AddWithValue("@txn_id", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@run_time", FormSolderPasteMGT.DataGridView4.Rows(Baris).Cells(6).Value)
                    cmd.Parameters.AddWithValue("@end_time", System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@status", "EMPTY")
                    Dim r As Integer
                    Try
                        r = cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()
                    Catch ex As Exception
                        MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        rd.Close()
                        conn.Close()
                        conn.Dispose()
                    End Try
                Next
                conn.Close()
            Else
                MsgBox("SOLDER PASTE TIDAK ADA DI LINE", vbInformation)
                TextBox1.Clear()
                TextBox1.Select()
                rd.Close()
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rd.Close()
            conn.Close()
            conn.Dispose()
        End Try
    End Sub

    Private Sub FormTrashSolderPaste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub
End Class