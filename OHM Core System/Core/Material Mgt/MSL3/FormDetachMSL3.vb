Imports MySql.Data.MySqlClient
Public Class FormDetachMSL3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn.Open()
        cmd = New MySql.Data.MySqlClient.MySqlCommand
        cmd.Connection = conn
        str = "UPDATE prodsys2_msl3_transaction_attach_log_tbl SET run_time = @run_time, end_time = @end_time, is_detach = @is_detach, date_detach = @date_detach WHERE unique_id = @unique_id"
        cmd.Parameters.Add("@unique_id", MySqlDbType.VarChar).Value = TextBox1.Text
        cmd.Parameters.Add("@pn_maker", MySqlDbType.VarChar).Value = TextBox2.Text
        cmd.Parameters.Add("@pn_lg", MySqlDbType.VarChar).Value = TextBox3.Text
        cmd.Parameters.Add("@lot_id", MySqlDbType.VarChar).Value = TextBox4.Text
        cmd.Parameters.Add("@qty", MySqlDbType.VarChar).Value = TextBox5.Text
        cmd.Parameters.Add("@incoming_date", MySqlDbType.VarChar).Value = TextBox6.Text
        cmd.Parameters.Add("@line", MySqlDbType.VarChar).Value = TextBox6.Text
        If CheckBox1.Checked = True Then
            cmd.Parameters.Add("@shift", MySqlDbType.VarChar).Value = CheckBox1.Text
        ElseIf CheckBox2.Checked = True Then
            cmd.Parameters.Add("@shift", MySqlDbType.VarChar).Value = CheckBox2.Text
        End If
        cmd.Parameters.Add("@supply_wo", MySqlDbType.VarChar).Value = TextBox9.Text
        cmd.Parameters.Add("@pn", MySqlDbType.VarChar).Value = TextBox8.Text
        cmd.Parameters.Add("@lot_qty", MySqlDbType.VarChar).Value = TextBox7.Text
        cmd.Parameters.Add("@start_time", MySqlDbType.VarChar).Value = TextBox17.Text
        cmd.Parameters.Add("@run_time", MySqlDbType.VarChar).Value = TextBox16.Text
        cmd.Parameters.Add("@end_time", MySqlDbType.VarChar).Value = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        cmd.Parameters.Add("@is_detach", MySqlDbType.VarChar).Value = "1"
        cmd.Parameters.Add("@date_attach", MySqlDbType.VarChar).Value = TextBox19.Text
        cmd.Parameters.Add("@date_detach", MySqlDbType.VarChar).Value = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        cmd.CommandText = str
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
        conn.Close()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class