Imports MySql.Data.MySqlClient
Public Class FormAttachMSL3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormProdPlanMSL3.ShowDialog()
    End Sub

    Private Sub FormAttachMSL3_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox14.Text = FormMain.LabelNama.Text
        TextBox17.Text = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        TextBox19.Text = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Dim now As DateTime = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        'Dim start As DateTime = System.DateTime.Now.ToString("5/11/2022 13:00:00")
        'Dim durasi As TimeSpan = New TimeSpan

        'durasi = now - start
        'TextBox16.Text = durasi.ToString

        'If durasi > TimeSpan.FromDays(7) Then
        'TextBox16.BackColor = Color.Red
        'TextBox16.ForeColor = Color.AntiqueWhite
        'Else
        'TextBox16.ReadOnly = True
        'End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        conn.Open()
        cmd = New MySql.Data.MySqlClient.MySqlCommand
        cmd.Connection = conn
        str = "INSERT INTO `prodsys2_msl3_transaction_attach_log_tbl`(`unique_id`, `pn_maker`, `pn_lg`, `lot_id`, `qty`, `incoming_date`, `line`, `shift`, `supply_wo`, `lot_qty`, `pn`, `start_time`, `run_time`, `end_time`, `employee`, `remark`, `is_detach`, `date_attach`, `date_detach`) VALUES (@unique_id,@pn_maker,@pn_lg,@lot_id,@qty,@incoming_date,@line,@shift,@supply_wo,@lot_qty,@pn,@start_time,@run_time,@end_time,@employee,@remark,@is_detach,@date_attach,@date_detach)"
        cmd.Parameters.Add("@unique_id", MySqlDbType.VarChar).Value = TextBox1.Text
        cmd.Parameters.Add("@pn_maker", MySqlDbType.VarChar).Value = TextBox2.Text
        cmd.Parameters.Add("@pn_lg", MySqlDbType.VarChar).Value = TextBox3.Text
        cmd.Parameters.Add("@lot_id", MySqlDbType.VarChar).Value = TextBox4.Text
        cmd.Parameters.Add("@qty", MySqlDbType.VarChar).Value = TextBox5.Text
        cmd.Parameters.Add("@incoming_date", MySqlDbType.VarChar).Value = TextBox6.Text
        cmd.Parameters.Add("@line", MySqlDbType.VarChar).Value = ComboBox1.Text
        If CheckBox1.Checked = True Then
            cmd.Parameters.Add("@shift", MySqlDbType.VarChar).Value = CheckBox1.Text
        ElseIf CheckBox2.Checked = True Then
            cmd.Parameters.Add("@shift", MySqlDbType.VarChar).Value = CheckBox2.Text
        End If
        cmd.Parameters.Add("@supply_wo", MySqlDbType.VarChar).Value = TextBox9.Text
        cmd.Parameters.Add("@pn", MySqlDbType.VarChar).Value = TextBox8.Text
        cmd.Parameters.Add("@lot_qty", MySqlDbType.VarChar).Value = TextBox7.Text
        cmd.Parameters.Add("@start_time", MySqlDbType.VarChar).Value = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        cmd.Parameters.Add("@run_time", MySqlDbType.VarChar).Value = TextBox16.Text
        cmd.Parameters.Add("@end_time", MySqlDbType.VarChar).Value = TextBox15.Text
        cmd.Parameters.Add("@employee", MySqlDbType.VarChar).Value = TextBox14.Text
        cmd.Parameters.Add("@remark", MySqlDbType.VarChar).Value = TextBox13.Text
        cmd.Parameters.Add("@is_detach", MySqlDbType.VarChar).Value = "0"
        cmd.Parameters.Add("@date_attach", MySqlDbType.VarChar).Value = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        cmd.Parameters.Add("@date_detach", MySqlDbType.VarChar).Value = TextBox18.Text
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class